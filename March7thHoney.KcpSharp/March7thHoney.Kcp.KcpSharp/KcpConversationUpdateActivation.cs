using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace March7thHoney.Kcp.KcpSharp;

internal sealed class KcpConversationUpdateActivation : IValueTaskSource<KcpConversationUpdateNotification>, IDisposable
{
	private class WaitList : IValueTaskSource, IKcpConversationUpdateNotificationSource, IDisposable
	{
		private readonly KcpConversationUpdateActivation _parent;

		private bool _available;

		private CancellationTokenRegistration _cancellationRegistration;

		private CancellationToken _cancellationToken;

		private bool _disposed;

		private LinkedList<WaitItem>? _list;

		private ManualResetValueTaskSourceCore<bool> _mrvtsc;

		private bool _occupied;

		private ReadOnlyMemory<byte> _packet;

		private bool _signaled;

		public ReadOnlyMemory<byte> Packet
		{
			get
			{
				lock (this)
				{
					if (_available && _occupied && !_signaled)
					{
						return _packet;
					}
				}
				return default(ReadOnlyMemory<byte>);
			}
		}

		public WaitList(KcpConversationUpdateActivation parent)
		{
			_parent = parent;
			_mrvtsc = new ManualResetValueTaskSourceCore<bool>
			{
				RunContinuationsAsynchronously = true
			};
		}

		public void Dispose()
		{
			if (_disposed)
			{
				return;
			}
			lock (this)
			{
				_disposed = true;
				if (_available && !_occupied && !_signaled)
				{
					_signaled = true;
					_packet = default(ReadOnlyMemory<byte>);
					_cancellationToken = default(CancellationToken);
					_mrvtsc.SetResult(result: false);
				}
				LinkedList<WaitItem> list = _list;
				if (list != null)
				{
					_list = null;
					LinkedListNode<WaitItem> linkedListNode = list.First;
					LinkedListNode<WaitItem> linkedListNode2 = linkedListNode?.Next;
					while (linkedListNode != null)
					{
						linkedListNode.Value.Release();
						list.Remove(linkedListNode);
						linkedListNode = linkedListNode2;
						linkedListNode2 = linkedListNode?.Next;
					}
				}
			}
		}

		public void Release()
		{
			lock (this)
			{
				if (_available && _occupied && !_signaled)
				{
					_signaled = true;
					_packet = default(ReadOnlyMemory<byte>);
					_cancellationToken = default(CancellationToken);
					_mrvtsc.SetResult(result: true);
				}
			}
		}

		ValueTaskSourceStatus IValueTaskSource.GetStatus(short token)
		{
			return _mrvtsc.GetStatus(token);
		}

		void IValueTaskSource.OnCompleted(Action<object?> continuation, object? state, short token, ValueTaskSourceOnCompletedFlags flags)
		{
			_mrvtsc.OnCompleted(continuation, state, token, flags);
		}

		void IValueTaskSource.GetResult(short token)
		{
			_cancellationRegistration.Dispose();
			try
			{
				_mrvtsc.GetResult(token);
			}
			finally
			{
				_mrvtsc.Reset();
				lock (this)
				{
					_available = false;
					_occupied = false;
					_signaled = false;
					_cancellationRegistration = default(CancellationTokenRegistration);
				}
			}
		}

		public ValueTask InputPacketAsync(ReadOnlyMemory<byte> packet, CancellationToken cancellationToken)
		{
			WaitItem waitItem = null;
			short token = 0;
			lock (this)
			{
				if (_disposed)
				{
					return default(ValueTask);
				}
				if (cancellationToken.IsCancellationRequested)
				{
					return new ValueTask(Task.FromCanceled(cancellationToken));
				}
				if (_available)
				{
					waitItem = new WaitItem(this, packet, cancellationToken);
					if (_list == null)
					{
						_list = new LinkedList<WaitItem>();
					}
					_list.AddLast(waitItem.Node);
				}
				else
				{
					token = _mrvtsc.Version;
					_available = true;
					_packet = packet;
					_cancellationToken = cancellationToken;
				}
			}
			ValueTask result;
			if (waitItem == null)
			{
				_cancellationRegistration = cancellationToken.UnsafeRegister(delegate(object? state)
				{
					((WaitList)state).CancelWaiting();
				}, this);
				result = new ValueTask(this, token);
			}
			else
			{
				waitItem.RegisterCancellationToken();
				result = new ValueTask(waitItem.Task);
			}
			_parent.NotifyPacketReceived();
			return result;
		}

		private void CancelWaiting()
		{
			lock (this)
			{
				if (_available && !_occupied && !_signaled)
				{
					_signaled = true;
					CancellationToken cancellationToken = _cancellationToken;
					_packet = default(ReadOnlyMemory<byte>);
					_cancellationToken = default(CancellationToken);
					_mrvtsc.SetException(new OperationCanceledException(cancellationToken));
				}
			}
		}

		public bool Occupy(out KcpConversationUpdateNotification notification)
		{
			lock (this)
			{
				if (_disposed)
				{
					notification = default(KcpConversationUpdateNotification);
					return false;
				}
				if (_available && !_occupied && !_signaled)
				{
					_occupied = true;
					notification = new KcpConversationUpdateNotification(this, skipTimerNotification: true);
					return true;
				}
				if (_list == null)
				{
					notification = default(KcpConversationUpdateNotification);
					return false;
				}
				LinkedListNode<WaitItem> first = _list.First;
				if (first != null)
				{
					_list.Remove(first);
					notification = new KcpConversationUpdateNotification(first.Value, skipTimerNotification: true);
					return true;
				}
			}
			notification = default(KcpConversationUpdateNotification);
			return false;
		}

		internal bool TryRemove(WaitItem item)
		{
			lock (this)
			{
				LinkedList<WaitItem> list = _list;
				if (list == null)
				{
					return false;
				}
				LinkedListNode<WaitItem> node = item.Node;
				if (node.Previous == null && node.Next == null)
				{
					return false;
				}
				list.Remove(node);
				return true;
			}
		}
	}

	private class WaitItem : TaskCompletionSource, IKcpConversationUpdateNotificationSource
	{
		private readonly WaitList _parent;

		private CancellationTokenRegistration _cancellationRegistration;

		private CancellationToken _cancellationToken;

		private ReadOnlyMemory<byte> _packet;

		private bool _released;

		public LinkedListNode<WaitItem> Node { get; }

		public ReadOnlyMemory<byte> Packet
		{
			get
			{
				lock (this)
				{
					if (!_released)
					{
						return _packet;
					}
				}
				return default(ReadOnlyMemory<byte>);
			}
		}

		public WaitItem(WaitList parent, ReadOnlyMemory<byte> packet, CancellationToken cancellationToken)
		{
			_parent = parent;
			_packet = packet;
			_cancellationToken = cancellationToken;
			Node = new LinkedListNode<WaitItem>(this);
		}

		public void Release()
		{
			CancellationTokenRegistration cancellationRegistration;
			lock (this)
			{
				_released = true;
				cancellationRegistration = _cancellationRegistration;
				_packet = default(ReadOnlyMemory<byte>);
				_cancellationToken = default(CancellationToken);
				_cancellationRegistration = default(CancellationTokenRegistration);
			}
			TrySetResult();
			cancellationRegistration.Dispose();
		}

		public void RegisterCancellationToken()
		{
			_cancellationRegistration = _cancellationToken.UnsafeRegister(delegate(object? state)
			{
				((WaitItem)state).CancelWaiting();
			}, this);
		}

		private void CancelWaiting()
		{
			if (_parent.TryRemove(this))
			{
				CancellationToken cancellationToken;
				lock (this)
				{
					_released = true;
					cancellationToken = _cancellationToken;
					_ = _cancellationRegistration;
					_packet = default(ReadOnlyMemory<byte>);
					_cancellationToken = default(CancellationToken);
					_cancellationRegistration = default(CancellationTokenRegistration);
				}
				TrySetCanceled(cancellationToken);
			}
			_cancellationRegistration.Dispose();
		}
	}

	private readonly Timer _timer;

	private readonly WaitList _waitList;

	private bool _activeWait;

	private CancellationTokenRegistration _cancellationRegistration;

	private CancellationToken _cancellationToken;

	private bool _disposed;

	private ManualResetValueTaskSourceCore<KcpConversationUpdateNotification> _mrvtsc;

	private bool _notificationPending;

	private bool _signaled;

	public KcpConversationUpdateActivation(int interval)
	{
		_timer = new Timer(delegate(object? state)
		{
			if (((WeakReference<KcpConversationUpdateActivation>)state).TryGetTarget(out var target))
			{
				target.Notify();
			}
		}, new WeakReference<KcpConversationUpdateActivation>(this), interval, interval);
		_mrvtsc = new ManualResetValueTaskSourceCore<KcpConversationUpdateNotification>
		{
			RunContinuationsAsynchronously = true
		};
		_waitList = new WaitList(this);
	}

	public void Dispose()
	{
		lock (this)
		{
			if (_disposed)
			{
				return;
			}
			_disposed = true;
			if (_activeWait && !_signaled)
			{
				_signaled = true;
				_cancellationToken = default(CancellationToken);
				_mrvtsc.SetResult(default(KcpConversationUpdateNotification));
			}
		}
		_timer.Dispose();
		_waitList.Dispose();
	}

	ValueTaskSourceStatus IValueTaskSource<KcpConversationUpdateNotification>.GetStatus(short token)
	{
		return _mrvtsc.GetStatus(token);
	}

	void IValueTaskSource<KcpConversationUpdateNotification>.OnCompleted(Action<object?> continuation, object? state, short token, ValueTaskSourceOnCompletedFlags flags)
	{
		_mrvtsc.OnCompleted(continuation, state, token, flags);
	}

	KcpConversationUpdateNotification IValueTaskSource<KcpConversationUpdateNotification>.GetResult(short token)
	{
		_cancellationRegistration.Dispose();
		try
		{
			return _mrvtsc.GetResult(token);
		}
		finally
		{
			_mrvtsc.Reset();
			lock (this)
			{
				_signaled = false;
				_activeWait = false;
				_cancellationRegistration = default(CancellationTokenRegistration);
			}
		}
	}

	public void Notify()
	{
		if (_disposed)
		{
			return;
		}
		lock (this)
		{
			if (!_disposed && !_notificationPending)
			{
				if (_activeWait && !_signaled)
				{
					_signaled = true;
					_cancellationToken = default(CancellationToken);
					_mrvtsc.SetResult(default(KcpConversationUpdateNotification));
				}
				else
				{
					_notificationPending = true;
				}
			}
		}
	}

	private void NotifyPacketReceived()
	{
		lock (this)
		{
			if (!_disposed && _activeWait && !_signaled && _waitList.Occupy(out var notification))
			{
				_signaled = true;
				_cancellationToken = default(CancellationToken);
				bool notificationPending = _notificationPending;
				_notificationPending = false;
				_mrvtsc.SetResult(notification.WithTimerNotification(notificationPending));
			}
		}
	}

	public ValueTask<KcpConversationUpdateNotification> WaitAsync(CancellationToken cancellationToken)
	{
		short version;
		lock (this)
		{
			if (_disposed)
			{
				return default(ValueTask<KcpConversationUpdateNotification>);
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return new ValueTask<KcpConversationUpdateNotification>(Task.FromCanceled<KcpConversationUpdateNotification>(cancellationToken));
			}
			if (_activeWait)
			{
				throw new InvalidOperationException();
			}
			if (_waitList.Occupy(out var notification))
			{
				bool notificationPending = _notificationPending;
				_notificationPending = false;
				return new ValueTask<KcpConversationUpdateNotification>(notification.WithTimerNotification(notificationPending));
			}
			if (_notificationPending)
			{
				_notificationPending = false;
				return default(ValueTask<KcpConversationUpdateNotification>);
			}
			_activeWait = true;
			_cancellationToken = cancellationToken;
			version = _mrvtsc.Version;
		}
		_cancellationRegistration = cancellationToken.UnsafeRegister(delegate(object? state)
		{
			((KcpConversationUpdateActivation)state).CancelWaiting();
		}, this);
		return new ValueTask<KcpConversationUpdateNotification>(this, version);
	}

	private void CancelWaiting()
	{
		lock (this)
		{
			if (_activeWait && !_signaled)
			{
				CancellationToken cancellationToken = _cancellationToken;
				_signaled = true;
				_cancellationToken = default(CancellationToken);
				_mrvtsc.SetException(new OperationCanceledException(cancellationToken));
			}
		}
	}

	public ValueTask InputPacketAsync(ReadOnlyMemory<byte> packet, CancellationToken cancellationToken)
	{
		if (_disposed)
		{
			return default(ValueTask);
		}
		return _waitList.InputPacketAsync(packet, cancellationToken);
	}
}
