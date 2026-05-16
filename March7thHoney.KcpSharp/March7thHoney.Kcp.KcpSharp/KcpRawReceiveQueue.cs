using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace March7thHoney.Kcp.KcpSharp;

internal sealed class KcpRawReceiveQueue : IValueTaskSource<KcpConversationReceiveResult>, IDisposable
{
	private readonly IKcpBufferPool _bufferPool;

	private readonly int _capacity;

	private readonly LinkedList<KcpBuffer> _queue;

	private readonly LinkedList<KcpBuffer> _recycled;

	private bool _activeWait;

	private Memory<byte> _buffer;

	private bool _bufferProvided;

	private CancellationTokenRegistration _cancellationRegistration;

	private CancellationToken _cancellationToken;

	private bool _disposed;

	private ManualResetValueTaskSourceCore<KcpConversationReceiveResult> _mrvtsc;

	private bool _signaled;

	private bool _transportClosed;

	public KcpRawReceiveQueue(IKcpBufferPool bufferPool, int capacity)
	{
		_bufferPool = bufferPool;
		_capacity = capacity;
		_queue = new LinkedList<KcpBuffer>();
		_recycled = new LinkedList<KcpBuffer>();
	}

	public void Dispose()
	{
		lock (_queue)
		{
			if (!_disposed)
			{
				if (_activeWait && !_signaled)
				{
					ClearPreviousOperation();
					_mrvtsc.SetResult(default(KcpConversationReceiveResult));
				}
				for (LinkedListNode<KcpBuffer> linkedListNode = _queue.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
				{
					linkedListNode.ValueRef.Release();
				}
				_queue.Clear();
				_recycled.Clear();
				_disposed = true;
				_transportClosed = true;
			}
		}
	}

	KcpConversationReceiveResult IValueTaskSource<KcpConversationReceiveResult>.GetResult(short token)
	{
		_cancellationRegistration.Dispose();
		try
		{
			return _mrvtsc.GetResult(token);
		}
		finally
		{
			_mrvtsc.Reset();
			lock (_queue)
			{
				_activeWait = false;
				_signaled = false;
				_cancellationRegistration = default(CancellationTokenRegistration);
			}
		}
	}

	ValueTaskSourceStatus IValueTaskSource<KcpConversationReceiveResult>.GetStatus(short token)
	{
		return _mrvtsc.GetStatus(token);
	}

	void IValueTaskSource<KcpConversationReceiveResult>.OnCompleted(Action<object?> continuation, object? state, short token, ValueTaskSourceOnCompletedFlags flags)
	{
		_mrvtsc.OnCompleted(continuation, state, token, flags);
	}

	public bool TryPeek(out KcpConversationReceiveResult result)
	{
		lock (_queue)
		{
			if (_disposed || _transportClosed)
			{
				result = default(KcpConversationReceiveResult);
				return false;
			}
			if (_activeWait)
			{
				ThrowHelper.ThrowConcurrentReceiveException();
			}
			LinkedListNode<KcpBuffer> first = _queue.First;
			if (first == null)
			{
				result = new KcpConversationReceiveResult(0);
				return false;
			}
			result = new KcpConversationReceiveResult(first.ValueRef.Length);
			return true;
		}
	}

	public ValueTask<KcpConversationReceiveResult> WaitToReceiveAsync(CancellationToken cancellationToken)
	{
		short version;
		lock (_queue)
		{
			if (_transportClosed || _disposed)
			{
				return default(ValueTask<KcpConversationReceiveResult>);
			}
			if (_activeWait)
			{
				return new ValueTask<KcpConversationReceiveResult>(Task.FromException<KcpConversationReceiveResult>(ThrowHelper.NewConcurrentReceiveException()));
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return new ValueTask<KcpConversationReceiveResult>(Task.FromCanceled<KcpConversationReceiveResult>(cancellationToken));
			}
			LinkedListNode<KcpBuffer> first = _queue.First;
			if (first != null)
			{
				return new ValueTask<KcpConversationReceiveResult>(new KcpConversationReceiveResult(first.ValueRef.Length));
			}
			_activeWait = true;
			_bufferProvided = false;
			_buffer = default(Memory<byte>);
			_cancellationToken = cancellationToken;
			version = _mrvtsc.Version;
		}
		_cancellationRegistration = cancellationToken.UnsafeRegister(delegate(object? state)
		{
			((KcpRawReceiveQueue)state).SetCanceled();
		}, this);
		return new ValueTask<KcpConversationReceiveResult>(this, version);
	}

	public bool TryReceive(Span<byte> buffer, out KcpConversationReceiveResult result)
	{
		lock (_queue)
		{
			if (_disposed || _transportClosed)
			{
				result = default(KcpConversationReceiveResult);
				return false;
			}
			if (_activeWait)
			{
				ThrowHelper.ThrowConcurrentReceiveException();
			}
			LinkedListNode<KcpBuffer> first = _queue.First;
			if (first == null)
			{
				result = new KcpConversationReceiveResult(0);
				return false;
			}
			ref KcpBuffer valueRef = ref first.ValueRef;
			if (buffer.Length < valueRef.Length)
			{
				ThrowHelper.ThrowBufferTooSmall();
			}
			valueRef.DataRegion.Span.CopyTo(buffer);
			result = new KcpConversationReceiveResult(valueRef.Length);
			_queue.RemoveFirst();
			valueRef.Release();
			valueRef = default(KcpBuffer);
			_recycled.AddLast(first);
			return true;
		}
	}

	public ValueTask<KcpConversationReceiveResult> ReceiveAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
	{
		short version;
		lock (_queue)
		{
			if (_transportClosed || _disposed)
			{
				return default(ValueTask<KcpConversationReceiveResult>);
			}
			if (_activeWait)
			{
				return new ValueTask<KcpConversationReceiveResult>(Task.FromException<KcpConversationReceiveResult>(ThrowHelper.NewConcurrentReceiveException()));
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return new ValueTask<KcpConversationReceiveResult>(Task.FromCanceled<KcpConversationReceiveResult>(cancellationToken));
			}
			LinkedListNode<KcpBuffer> first = _queue.First;
			if (first != null)
			{
				ref KcpBuffer valueRef = ref first.ValueRef;
				int length = valueRef.Length;
				if (buffer.Length < valueRef.Length)
				{
					return new ValueTask<KcpConversationReceiveResult>(Task.FromException<KcpConversationReceiveResult>(ThrowHelper.NewBufferTooSmallForBufferArgument()));
				}
				_queue.Remove(first);
				valueRef.DataRegion.CopyTo(buffer);
				valueRef.Release();
				valueRef = default(KcpBuffer);
				_recycled.AddLast(first);
				return new ValueTask<KcpConversationReceiveResult>(new KcpConversationReceiveResult(length));
			}
			_activeWait = true;
			_bufferProvided = true;
			_buffer = buffer;
			_cancellationToken = cancellationToken;
			version = _mrvtsc.Version;
		}
		_cancellationRegistration = cancellationToken.UnsafeRegister(delegate(object? state)
		{
			((KcpRawReceiveQueue)state).SetCanceled();
		}, this);
		return new ValueTask<KcpConversationReceiveResult>(this, version);
	}

	public bool CancelPendingOperation(Exception? innerException, CancellationToken cancellationToken)
	{
		lock (_queue)
		{
			if (_activeWait && !_signaled)
			{
				ClearPreviousOperation();
				_mrvtsc.SetException(ThrowHelper.NewOperationCanceledExceptionForCancelPendingReceive(innerException, cancellationToken));
				return true;
			}
		}
		return false;
	}

	private void SetCanceled()
	{
		lock (_queue)
		{
			if (_activeWait && !_signaled)
			{
				CancellationToken cancellationToken = _cancellationToken;
				ClearPreviousOperation();
				_mrvtsc.SetException(new OperationCanceledException(cancellationToken));
			}
		}
	}

	private void ClearPreviousOperation()
	{
		_signaled = true;
		_bufferProvided = false;
		_buffer = default(Memory<byte>);
		_cancellationToken = default(CancellationToken);
	}

	public void Enqueue(ReadOnlySpan<byte> buffer)
	{
		lock (_queue)
		{
			if (_transportClosed || _disposed)
			{
				return;
			}
			int count = _queue.Count;
			if (count > 0 || !_activeWait)
			{
				if (count < _capacity)
				{
					KcpRentedBuffer buffer2 = _bufferPool.Rent(new KcpBufferPoolRentOptions(buffer.Length, isOutbound: false));
					_queue.AddLast(AllocateNode(KcpBuffer.CreateFromSpan(buffer2, buffer)));
				}
			}
			else if (!_bufferProvided)
			{
				KcpRentedBuffer buffer3 = _bufferPool.Rent(new KcpBufferPoolRentOptions(buffer.Length, isOutbound: false));
				_queue.AddLast(AllocateNode(KcpBuffer.CreateFromSpan(buffer3, buffer)));
				ClearPreviousOperation();
				_mrvtsc.SetResult(new KcpConversationReceiveResult(buffer.Length));
			}
			else if (buffer.Length > _buffer.Length)
			{
				KcpRentedBuffer buffer4 = _bufferPool.Rent(new KcpBufferPoolRentOptions(buffer.Length, isOutbound: false));
				_queue.AddLast(AllocateNode(KcpBuffer.CreateFromSpan(buffer4, buffer)));
				ClearPreviousOperation();
				_mrvtsc.SetException(ThrowHelper.NewBufferTooSmallForBufferArgument());
			}
			else
			{
				buffer.CopyTo(_buffer.Span);
				ClearPreviousOperation();
				_mrvtsc.SetResult(new KcpConversationReceiveResult(buffer.Length));
			}
		}
	}

	private LinkedListNode<KcpBuffer> AllocateNode(KcpBuffer buffer)
	{
		LinkedListNode<KcpBuffer> linkedListNode = _recycled.First;
		if (linkedListNode == null)
		{
			linkedListNode = new LinkedListNode<KcpBuffer>(buffer);
		}
		else
		{
			linkedListNode.ValueRef = buffer;
			_recycled.Remove(linkedListNode);
		}
		return linkedListNode;
	}

	public void SetTransportClosed()
	{
		lock (_queue)
		{
			if (!_transportClosed && !_disposed)
			{
				if (_activeWait && !_signaled)
				{
					ClearPreviousOperation();
					_mrvtsc.SetResult(default(KcpConversationReceiveResult));
				}
				_recycled.Clear();
				_transportClosed = true;
			}
		}
	}
}
