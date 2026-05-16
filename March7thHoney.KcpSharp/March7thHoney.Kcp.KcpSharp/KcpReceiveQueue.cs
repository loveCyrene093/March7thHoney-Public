using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace March7thHoney.Kcp.KcpSharp;

internal sealed class KcpReceiveQueue : IValueTaskSource<KcpConversationReceiveResult>, IValueTaskSource<int>, IValueTaskSource<bool>, IDisposable
{
	private readonly KcpSendReceiveQueueItemCache _cache;

	private readonly LinkedList<(KcpBuffer Data, byte Fragment)> _queue;

	private readonly int _queueSize;

	private readonly bool _stream;

	private bool _activeWait;

	private Memory<byte> _buffer;

	private CancellationTokenRegistration _cancellationRegistration;

	private CancellationToken _cancellationToken;

	private int _completedPacketsCount;

	private bool _disposed;

	private int _minimumBytes;

	private int _minimumSegments;

	private ManualResetValueTaskSourceCore<KcpConversationReceiveResult> _mrvtsc;

	private byte _operationMode;

	private bool _signaled;

	private bool _transportClosed;

	public KcpReceiveQueue(bool stream, int queueSize, KcpSendReceiveQueueItemCache cache)
	{
		_mrvtsc = new ManualResetValueTaskSourceCore<KcpConversationReceiveResult>
		{
			RunContinuationsAsynchronously = true
		};
		_queue = new LinkedList<(KcpBuffer, byte)>();
		_stream = stream;
		_queueSize = queueSize;
		_cache = cache;
	}

	public void Dispose()
	{
		lock (_queue)
		{
			if (!_disposed)
			{
				if (_activeWait && !_signaled)
				{
					ClearPreviousOperation(signaled: true);
					_mrvtsc.SetResult(default(KcpConversationReceiveResult));
				}
				for (LinkedListNode<(KcpBuffer, byte)> linkedListNode = _queue.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
				{
					linkedListNode.ValueRef.Item1.Release();
				}
				_queue.Clear();
				_disposed = true;
				_transportClosed = true;
			}
		}
	}

	bool IValueTaskSource<bool>.GetResult(short token)
	{
		_cancellationRegistration.Dispose();
		try
		{
			return !_mrvtsc.GetResult(token).TransportClosed;
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

	int IValueTaskSource<int>.GetResult(short token)
	{
		_cancellationRegistration.Dispose();
		try
		{
			return _mrvtsc.GetResult(token).BytesReceived;
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

	public ValueTaskSourceStatus GetStatus(short token)
	{
		return _mrvtsc.GetStatus(token);
	}

	public void OnCompleted(Action<object?> continuation, object? state, short token, ValueTaskSourceOnCompletedFlags flags)
	{
		_mrvtsc.OnCompleted(continuation, state, token, flags);
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
			if (_completedPacketsCount == 0)
			{
				result = new KcpConversationReceiveResult(0);
				return false;
			}
			LinkedListNode<(KcpBuffer, byte)> first = _queue.First;
			if (first == null)
			{
				result = new KcpConversationReceiveResult(0);
				return false;
			}
			if (CalculatePacketSize(first, out var packetSize))
			{
				result = new KcpConversationReceiveResult(packetSize);
				return true;
			}
			result = default(KcpConversationReceiveResult);
			return false;
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
			_operationMode = 1;
			_buffer = default(Memory<byte>);
			_minimumBytes = 0;
			_minimumSegments = 0;
			version = _mrvtsc.Version;
			if (_completedPacketsCount > 0)
			{
				ConsumePacket(_buffer.Span, out var result, out var bufferTooSmall);
				ClearPreviousOperation(signaled: false);
				if (bufferTooSmall)
				{
					return new ValueTask<KcpConversationReceiveResult>(Task.FromException<KcpConversationReceiveResult>(ThrowHelper.NewBufferTooSmallForBufferArgument()));
				}
				return new ValueTask<KcpConversationReceiveResult>(result);
			}
			_activeWait = true;
			_cancellationToken = cancellationToken;
		}
		_cancellationRegistration = cancellationToken.UnsafeRegister(delegate(object? state)
		{
			((KcpReceiveQueue)state).SetCanceled();
		}, this);
		return new ValueTask<KcpConversationReceiveResult>(this, version);
	}

	public ValueTask<bool> WaitForAvailableDataAsync(int minimumBytes, int minimumSegments, CancellationToken cancellationToken)
	{
		if (minimumBytes < 0)
		{
			return new ValueTask<bool>(Task.FromException<bool>(ThrowHelper.NewArgumentOutOfRangeException("minimumBytes")));
		}
		if (minimumSegments < 0)
		{
			return new ValueTask<bool>(Task.FromException<bool>(ThrowHelper.NewArgumentOutOfRangeException("minimumSegments")));
		}
		short version;
		lock (_queue)
		{
			if (_transportClosed || _disposed)
			{
				return default(ValueTask<bool>);
			}
			if (_activeWait)
			{
				return new ValueTask<bool>(Task.FromException<bool>(ThrowHelper.NewConcurrentReceiveException()));
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return new ValueTask<bool>(Task.FromCanceled<bool>(cancellationToken));
			}
			if (CheckQueeuSize(_queue, minimumBytes, minimumSegments, _stream))
			{
				return new ValueTask<bool>(result: true);
			}
			_activeWait = true;
			_operationMode = 2;
			_buffer = default(Memory<byte>);
			_minimumBytes = minimumBytes;
			_minimumSegments = minimumSegments;
			_cancellationToken = cancellationToken;
			version = _mrvtsc.Version;
		}
		_cancellationRegistration = cancellationToken.UnsafeRegister(delegate(object? state)
		{
			((KcpReceiveQueue)state).SetCanceled();
		}, this);
		return new ValueTask<bool>(this, version);
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
			if (_completedPacketsCount == 0)
			{
				result = new KcpConversationReceiveResult(0);
				return false;
			}
			_operationMode = 0;
			ConsumePacket(buffer, out result, out var bufferTooSmall);
			ClearPreviousOperation(signaled: false);
			if (bufferTooSmall)
			{
				ThrowHelper.ThrowBufferTooSmall();
			}
			return true;
		}
	}

	public ValueTask<KcpConversationReceiveResult> ReceiveAsync(Memory<byte> buffer, CancellationToken cancellationToken)
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
			_operationMode = 0;
			_buffer = buffer;
			version = _mrvtsc.Version;
			if (_completedPacketsCount > 0)
			{
				ConsumePacket(_buffer.Span, out var result, out var bufferTooSmall);
				ClearPreviousOperation(signaled: false);
				if (bufferTooSmall)
				{
					return new ValueTask<KcpConversationReceiveResult>(Task.FromException<KcpConversationReceiveResult>(ThrowHelper.NewBufferTooSmallForBufferArgument()));
				}
				return new ValueTask<KcpConversationReceiveResult>(result);
			}
			_activeWait = true;
			_cancellationToken = cancellationToken;
		}
		_cancellationRegistration = cancellationToken.UnsafeRegister(delegate(object? state)
		{
			((KcpReceiveQueue)state).SetCanceled();
		}, this);
		return new ValueTask<KcpConversationReceiveResult>(this, version);
	}

	public ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken)
	{
		short version;
		lock (_queue)
		{
			if (_transportClosed || _disposed)
			{
				return new ValueTask<int>(Task.FromException<int>(ThrowHelper.NewTransportClosedForStreamException()));
			}
			if (_activeWait)
			{
				return new ValueTask<int>(Task.FromException<int>(ThrowHelper.NewConcurrentReceiveException()));
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return new ValueTask<int>(Task.FromCanceled<int>(cancellationToken));
			}
			_operationMode = 0;
			_buffer = buffer;
			version = _mrvtsc.Version;
			if (_completedPacketsCount > 0)
			{
				ConsumePacket(_buffer.Span, out var result, out var bufferTooSmall);
				ClearPreviousOperation(signaled: false);
				if (bufferTooSmall)
				{
					return new ValueTask<int>(Task.FromException<int>(ThrowHelper.NewBufferTooSmallForBufferArgument()));
				}
				return new ValueTask<int>(result.BytesReceived);
			}
			_activeWait = true;
			_cancellationToken = cancellationToken;
		}
		_cancellationRegistration = cancellationToken.UnsafeRegister(delegate(object? state)
		{
			((KcpReceiveQueue)state).SetCanceled();
		}, this);
		return new ValueTask<int>(this, version);
	}

	public bool CancelPendingOperation(Exception? innerException, CancellationToken cancellationToken)
	{
		lock (_queue)
		{
			if (_activeWait && !_signaled)
			{
				ClearPreviousOperation(signaled: true);
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
				ClearPreviousOperation(signaled: true);
				_mrvtsc.SetException(new OperationCanceledException(cancellationToken));
			}
		}
	}

	private void ClearPreviousOperation(bool signaled)
	{
		_signaled = signaled;
		_operationMode = 0;
		_buffer = default(Memory<byte>);
		_minimumBytes = 0;
		_minimumSegments = 0;
		_cancellationToken = default(CancellationToken);
	}

	public void Enqueue(KcpBuffer buffer, byte fragment)
	{
		lock (_queue)
		{
			if (_transportClosed || _disposed)
			{
				return;
			}
			if (_stream)
			{
				if (buffer.Length == 0)
				{
					return;
				}
				fragment = 0;
				_queue.AddLast(_cache.Rent(in buffer, 0));
			}
			else
			{
				LinkedListNode<(KcpBuffer, byte)> last = _queue.Last;
				if (last == null || last.ValueRef.Item2 == 0 || last.ValueRef.Item2 - 1 == fragment)
				{
					_queue.AddLast(_cache.Rent(in buffer, fragment));
				}
				else
				{
					fragment = 0;
					_queue.AddLast(_cache.Rent(in buffer, 0));
				}
			}
			if (fragment == 0)
			{
				_completedPacketsCount++;
				if (_activeWait && !_signaled)
				{
					TryCompleteReceive();
					TryCompleteWaitForData();
				}
			}
		}
	}

	private void TryCompleteReceive()
	{
		if (_operationMode <= 1)
		{
			ConsumePacket(_buffer.Span, out var result, out var bufferTooSmall);
			ClearPreviousOperation(signaled: true);
			if (bufferTooSmall)
			{
				_mrvtsc.SetException(ThrowHelper.NewBufferTooSmallForBufferArgument());
			}
			else
			{
				_mrvtsc.SetResult(result);
			}
		}
	}

	private void TryCompleteWaitForData()
	{
		if (_operationMode == 2 && CheckQueeuSize(_queue, _minimumBytes, _minimumSegments, _stream))
		{
			ClearPreviousOperation(signaled: true);
			_mrvtsc.SetResult(new KcpConversationReceiveResult(0));
		}
	}

	private void ConsumePacket(Span<byte> buffer, out KcpConversationReceiveResult result, out bool bufferTooSmall)
	{
		LinkedListNode<(KcpBuffer, byte)> linkedListNode = _queue.First;
		if (linkedListNode == null)
		{
			result = default(KcpConversationReceiveResult);
			bufferTooSmall = false;
			return;
		}
		if (_operationMode == 1)
		{
			if (CalculatePacketSize(linkedListNode, out var packetSize))
			{
				result = new KcpConversationReceiveResult(packetSize);
			}
			else
			{
				result = default(KcpConversationReceiveResult);
			}
			bufferTooSmall = false;
			return;
		}
		int num = 0;
		if (!_stream)
		{
			while (linkedListNode != null)
			{
				num += linkedListNode.ValueRef.Item1.Length;
				if (linkedListNode.ValueRef.Item2 == 0)
				{
					break;
				}
				linkedListNode = linkedListNode.Next;
			}
			if (linkedListNode == null)
			{
				result = default(KcpConversationReceiveResult);
				bufferTooSmall = false;
				return;
			}
			if (num > buffer.Length)
			{
				result = default(KcpConversationReceiveResult);
				bufferTooSmall = true;
				return;
			}
		}
		bool flag = false;
		num = 0;
		linkedListNode = _queue.First;
		while (linkedListNode != null)
		{
			LinkedListNode<(KcpBuffer, byte)> next = linkedListNode.Next;
			byte item = linkedListNode.ValueRef.Item2;
			ref KcpBuffer item2 = ref linkedListNode.ValueRef.Item1;
			int num2 = Math.Min(item2.Length, buffer.Length);
			item2.DataRegion.Span.Slice(0, num2).CopyTo(buffer);
			buffer = buffer.Slice(num2);
			num += num2;
			flag = true;
			if (num2 != item2.Length)
			{
				linkedListNode.ValueRef = (item2.Consume(num2), linkedListNode.ValueRef.Item2);
			}
			else
			{
				item2.Release();
				_queue.Remove(linkedListNode);
				_cache.Return(linkedListNode);
				if (item == 0)
				{
					_completedPacketsCount--;
				}
			}
			if ((!_stream && item == 0) || num2 == 0)
			{
				break;
			}
			linkedListNode = next;
		}
		if (!flag)
		{
			result = default(KcpConversationReceiveResult);
			bufferTooSmall = false;
		}
		else
		{
			result = new KcpConversationReceiveResult(num);
			bufferTooSmall = false;
		}
	}

	private static bool CalculatePacketSize(LinkedListNode<(KcpBuffer Data, byte Fragment)> first, out int packetSize)
	{
		int num = first.ValueRef.Data.Length;
		if (first.ValueRef.Fragment == 0)
		{
			packetSize = num;
			return true;
		}
		for (LinkedListNode<(KcpBuffer, byte)> next = first.Next; next != null; next = next.Next)
		{
			num += next.ValueRef.Item1.Length;
			if (next.ValueRef.Item2 == 0)
			{
				packetSize = num;
				return true;
			}
		}
		packetSize = 0;
		return false;
	}

	private static bool CheckQueeuSize(LinkedList<(KcpBuffer Data, byte Fragment)> queue, int minimumBytes, int minimumSegments, bool stream)
	{
		for (LinkedListNode<(KcpBuffer, byte)> linkedListNode = queue.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
		{
			minimumBytes = Math.Max(minimumBytes - linkedListNode.ValueRef.Item1.Length, 0);
			if (stream || linkedListNode.ValueRef.Item2 == 0)
			{
				minimumSegments = Math.Max(minimumSegments - 1, 0);
			}
			if (minimumBytes == 0 && minimumSegments == 0)
			{
				return true;
			}
		}
		if (minimumBytes == 0)
		{
			return minimumSegments == 0;
		}
		return false;
	}

	public void SetTransportClosed()
	{
		lock (_queue)
		{
			if (!_transportClosed && !_disposed)
			{
				if (_activeWait && !_signaled)
				{
					ClearPreviousOperation(signaled: true);
					_mrvtsc.SetResult(default(KcpConversationReceiveResult));
				}
				_transportClosed = true;
			}
		}
	}

	public int GetQueueSize()
	{
		lock (_queue)
		{
			_ = _queue.Count;
		}
		return Math.Max(_queue.Count - _queueSize, 0);
	}
}
