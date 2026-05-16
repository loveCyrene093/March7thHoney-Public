using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace March7thHoney.Kcp.KcpSharp;

internal sealed class KcpSendQueue : IValueTaskSource<bool>, IValueTaskSource, IDisposable
{
	private readonly IKcpBufferPool _bufferPool;

	private readonly KcpSendReceiveQueueItemCache _cache;

	private readonly int _capacity;

	private readonly int _mss;

	private readonly LinkedList<(KcpBuffer Data, byte Fragment)> _queue;

	private readonly bool _stream;

	private readonly KcpConversationUpdateActivation _updateActivation;

	private bool _ackListNotEmpty;

	private bool _activeWait;

	private ReadOnlyMemory<byte> _buffer;

	private CancellationTokenRegistration _cancellationRegistration;

	private CancellationToken _cancellationToken;

	private bool _disposed;

	private bool _forStream;

	private ManualResetValueTaskSourceCore<bool> _mrvtsc;

	private byte _operationMode;

	private bool _signled;

	private bool _transportClosed;

	private long _unflushedBytes;

	private int _waitForByteCount;

	private int _waitForSegmentCount;

	public KcpSendQueue(IKcpBufferPool bufferPool, KcpConversationUpdateActivation updateActivation, bool stream, int capacity, int mss, KcpSendReceiveQueueItemCache cache)
	{
		_bufferPool = bufferPool;
		_updateActivation = updateActivation;
		_stream = stream;
		_capacity = capacity;
		_mss = mss;
		_cache = cache;
		_mrvtsc = new ManualResetValueTaskSourceCore<bool>
		{
			RunContinuationsAsynchronously = true
		};
		_queue = new LinkedList<(KcpBuffer, byte)>();
	}

	public void Dispose()
	{
		lock (_queue)
		{
			if (_disposed)
			{
				return;
			}
			if (_activeWait && !_signled)
			{
				if (_forStream)
				{
					ClearPreviousOperation();
					_mrvtsc.SetException(ThrowHelper.NewTransportClosedForStreamException());
				}
				else
				{
					ClearPreviousOperation();
					_mrvtsc.SetResult(result: false);
				}
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

	void IValueTaskSource.GetResult(short token)
	{
		try
		{
			_mrvtsc.GetResult(token);
		}
		finally
		{
			_mrvtsc.Reset();
			lock (_queue)
			{
				_activeWait = false;
				_signled = false;
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

	bool IValueTaskSource<bool>.GetResult(short token)
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
				_signled = false;
				_cancellationRegistration = default(CancellationTokenRegistration);
			}
		}
	}

	public bool TryGetAvailableSpace(out int byteCount, out int segmentCount)
	{
		lock (_queue)
		{
			if (_transportClosed || _disposed)
			{
				byteCount = 0;
				segmentCount = 0;
				return false;
			}
			if (_activeWait && _operationMode == 0)
			{
				byteCount = 0;
				segmentCount = 0;
				return true;
			}
			GetAvailableSpaceCore(out byteCount, out segmentCount);
			return true;
		}
	}

	private void GetAvailableSpaceCore(out int byteCount, out int segmentCount)
	{
		int mss = _mss;
		int num = _capacity - _queue.Count;
		if (num < 0)
		{
			byteCount = 0;
			segmentCount = 0;
			return;
		}
		int num2 = num * mss;
		if (_stream)
		{
			LinkedListNode<(KcpBuffer, byte)> last = _queue.Last;
			if (last != null)
			{
				num2 += _mss - last.ValueRef.Item1.Length;
			}
		}
		byteCount = num2;
		segmentCount = num;
	}

	public ValueTask<bool> WaitForAvailableSpaceAsync(int minimumBytes, int minimumSegments, CancellationToken cancellationToken)
	{
		short version;
		lock (_queue)
		{
			if (_transportClosed || _disposed)
			{
				minimumBytes = 0;
				minimumSegments = 0;
				return default(ValueTask<bool>);
			}
			if ((uint)minimumBytes > (uint)(_mss * _capacity))
			{
				return new ValueTask<bool>(Task.FromException<bool>(ThrowHelper.NewArgumentOutOfRangeException("minimumBytes")));
			}
			if ((uint)minimumSegments > (uint)_capacity)
			{
				return new ValueTask<bool>(Task.FromException<bool>(ThrowHelper.NewArgumentOutOfRangeException("minimumSegments")));
			}
			if (_activeWait)
			{
				return new ValueTask<bool>(Task.FromException<bool>(ThrowHelper.NewConcurrentSendException()));
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return new ValueTask<bool>(Task.FromCanceled<bool>(cancellationToken));
			}
			GetAvailableSpaceCore(out var byteCount, out var segmentCount);
			if (byteCount >= minimumBytes && segmentCount >= minimumSegments)
			{
				return new ValueTask<bool>(result: true);
			}
			_activeWait = true;
			_forStream = false;
			_operationMode = 2;
			_waitForByteCount = minimumBytes;
			_waitForSegmentCount = minimumSegments;
			_cancellationToken = cancellationToken;
			version = _mrvtsc.Version;
		}
		_cancellationRegistration = cancellationToken.UnsafeRegister(delegate(object? state)
		{
			((KcpSendQueue)state).SetCanceled();
		}, this);
		return new ValueTask<bool>(this, version);
	}

	public bool TrySend(ReadOnlySpan<byte> buffer, bool allowPartialSend, out int bytesWritten)
	{
		lock (_queue)
		{
			if (allowPartialSend && !_stream)
			{
				ThrowHelper.ThrowAllowPartialSendArgumentException();
			}
			if (_transportClosed || _disposed)
			{
				bytesWritten = 0;
				return false;
			}
			int mss = _mss;
			if (!allowPartialSend)
			{
				int num = mss * (_capacity - _queue.Count);
				if (num < 0)
				{
					bytesWritten = 0;
					return false;
				}
				if (_stream)
				{
					LinkedListNode<(KcpBuffer, byte)> last = _queue.Last;
					if (last != null)
					{
						num += mss - last.ValueRef.Item1.Length;
					}
				}
				if (buffer.Length > num)
				{
					bytesWritten = 0;
					return false;
				}
			}
			bytesWritten = 0;
			if (_stream)
			{
				LinkedListNode<(KcpBuffer, byte)> last2 = _queue.Last;
				if (last2 != null)
				{
					ref KcpBuffer item = ref last2.ValueRef.Item1;
					int val = mss - item.Length;
					val = Math.Min(val, buffer.Length);
					if (val > 0)
					{
						item = item.AppendData(buffer.Slice(0, val));
						buffer = buffer.Slice(val);
						Interlocked.Add(ref _unflushedBytes, val);
						bytesWritten = val;
					}
				}
				if (buffer.IsEmpty)
				{
					return true;
				}
			}
			bool flag = false;
			int num2 = ((buffer.Length <= mss) ? 1 : ((buffer.Length + mss - 1) / mss));
			while (num2 > 0 && _queue.Count < _capacity)
			{
				int num3 = --num2;
				int num4 = ((buffer.Length > mss) ? mss : buffer.Length);
				KcpBuffer buffer2 = KcpBuffer.CreateFromSpan(_bufferPool.Rent(new KcpBufferPoolRentOptions(mss, isOutbound: false)), buffer.Slice(0, num4));
				buffer = buffer.Slice(num4);
				_queue.AddLast(_cache.Rent(in buffer2, (byte)((!_stream) ? ((byte)num3) : 0)));
				Interlocked.Add(ref _unflushedBytes, num4);
				bytesWritten += num4;
				flag = true;
			}
			if (flag)
			{
				_updateActivation.Notify();
			}
			return flag;
		}
	}

	public ValueTask<bool> SendAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken)
	{
		short version;
		lock (_queue)
		{
			if (_transportClosed || _disposed)
			{
				return new ValueTask<bool>(result: false);
			}
			if (_activeWait)
			{
				return new ValueTask<bool>(Task.FromException<bool>(ThrowHelper.NewConcurrentSendException()));
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return new ValueTask<bool>(Task.FromCanceled<bool>(cancellationToken));
			}
			int mss = _mss;
			if (_stream)
			{
				LinkedListNode<(KcpBuffer, byte)> last = _queue.Last;
				if (last != null)
				{
					ref KcpBuffer item = ref last.ValueRef.Item1;
					int val = mss - item.Length;
					val = Math.Min(val, buffer.Length);
					if (val > 0)
					{
						item = item.AppendData(buffer.Span.Slice(0, val));
						buffer = buffer.Slice(val);
						Interlocked.Add(ref _unflushedBytes, val);
					}
				}
				if (buffer.IsEmpty)
				{
					return new ValueTask<bool>(result: true);
				}
			}
			int num = ((buffer.Length <= mss) ? 1 : ((buffer.Length + mss - 1) / mss));
			if (!_stream && num > 256)
			{
				return new ValueTask<bool>(Task.FromException<bool>(ThrowHelper.NewMessageTooLargeForBufferArgument()));
			}
			while (num > 0 && _queue.Count < _capacity)
			{
				int num2 = --num;
				int num3 = ((buffer.Length > mss) ? mss : buffer.Length);
				KcpBuffer buffer2 = KcpBuffer.CreateFromSpan(_bufferPool.Rent(new KcpBufferPoolRentOptions(mss, isOutbound: false)), buffer.Span.Slice(0, num3));
				buffer = buffer.Slice(num3);
				_queue.AddLast(_cache.Rent(in buffer2, (byte)((!_stream) ? ((byte)num2) : 0)));
				Interlocked.Add(ref _unflushedBytes, num3);
			}
			_updateActivation.Notify();
			if (num == 0)
			{
				return new ValueTask<bool>(result: true);
			}
			_activeWait = true;
			_forStream = false;
			_operationMode = 0;
			_buffer = buffer;
			_cancellationToken = cancellationToken;
			version = _mrvtsc.Version;
		}
		_cancellationRegistration = cancellationToken.UnsafeRegister(delegate(object? state)
		{
			((KcpSendQueue)state).SetCanceled();
		}, this);
		return new ValueTask<bool>(this, version);
	}

	public ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken)
	{
		short version;
		lock (_queue)
		{
			if (_transportClosed || _disposed)
			{
				return new ValueTask(Task.FromException(ThrowHelper.NewTransportClosedForStreamException()));
			}
			if (_activeWait)
			{
				return new ValueTask(Task.FromException(ThrowHelper.NewConcurrentSendException()));
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return new ValueTask(Task.FromCanceled(cancellationToken));
			}
			int mss = _mss;
			if (_stream)
			{
				LinkedListNode<(KcpBuffer, byte)> last = _queue.Last;
				if (last != null)
				{
					ref KcpBuffer item = ref last.ValueRef.Item1;
					int val = mss - item.Length;
					val = Math.Min(val, buffer.Length);
					if (val > 0)
					{
						item = item.AppendData(buffer.Span.Slice(0, val));
						buffer = buffer.Slice(val);
						Interlocked.Add(ref _unflushedBytes, val);
					}
				}
				if (buffer.IsEmpty)
				{
					return default(ValueTask);
				}
			}
			int num = ((buffer.Length <= mss) ? 1 : ((buffer.Length + mss - 1) / mss));
			while (num > 0 && _queue.Count < _capacity)
			{
				int num2 = ((buffer.Length > mss) ? mss : buffer.Length);
				KcpBuffer buffer2 = KcpBuffer.CreateFromSpan(_bufferPool.Rent(new KcpBufferPoolRentOptions(mss, isOutbound: false)), buffer.Span.Slice(0, num2));
				buffer = buffer.Slice(num2);
				_queue.AddLast(_cache.Rent(in buffer2, 0));
				Interlocked.Add(ref _unflushedBytes, num2);
			}
			_updateActivation.Notify();
			if (num == 0)
			{
				return default(ValueTask);
			}
			_activeWait = true;
			_forStream = true;
			_operationMode = 0;
			_buffer = buffer;
			_cancellationToken = cancellationToken;
			version = _mrvtsc.Version;
		}
		_cancellationRegistration = cancellationToken.UnsafeRegister(delegate(object? state)
		{
			((KcpSendQueue)state).SetCanceled();
		}, this);
		return new ValueTask(this, version);
	}

	public ValueTask<bool> FlushAsync(CancellationToken cancellationToken)
	{
		short version;
		lock (_queue)
		{
			if (_transportClosed || _disposed)
			{
				return new ValueTask<bool>(result: false);
			}
			if (_activeWait)
			{
				return new ValueTask<bool>(Task.FromException<bool>(ThrowHelper.NewConcurrentSendException()));
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return new ValueTask<bool>(Task.FromCanceled<bool>(cancellationToken));
			}
			_activeWait = true;
			_forStream = false;
			_operationMode = 1;
			_buffer = default(ReadOnlyMemory<byte>);
			_cancellationToken = cancellationToken;
			version = _mrvtsc.Version;
		}
		_cancellationRegistration = cancellationToken.UnsafeRegister(delegate(object? state)
		{
			((KcpSendQueue)state).SetCanceled();
		}, this);
		return new ValueTask<bool>(this, version);
	}

	public ValueTask FlushForStreamAsync(CancellationToken cancellationToken)
	{
		short version;
		lock (_queue)
		{
			if (_transportClosed || _disposed)
			{
				return new ValueTask(Task.FromException(ThrowHelper.NewTransportClosedForStreamException()));
			}
			if (_activeWait)
			{
				return new ValueTask(Task.FromException(ThrowHelper.NewConcurrentSendException()));
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return new ValueTask(Task.FromCanceled(cancellationToken));
			}
			_activeWait = true;
			_forStream = true;
			_operationMode = 1;
			_buffer = default(ReadOnlyMemory<byte>);
			_cancellationToken = cancellationToken;
			version = _mrvtsc.Version;
		}
		_cancellationRegistration = cancellationToken.UnsafeRegister(delegate(object? state)
		{
			((KcpSendQueue)state).SetCanceled();
		}, this);
		return new ValueTask(this, version);
	}

	public bool CancelPendingOperation(Exception? innerException, CancellationToken cancellationToken)
	{
		lock (_queue)
		{
			if (_activeWait && !_signled)
			{
				ClearPreviousOperation();
				_mrvtsc.SetException(ThrowHelper.NewOperationCanceledExceptionForCancelPendingSend(innerException, cancellationToken));
				return true;
			}
		}
		return false;
	}

	private void SetCanceled()
	{
		lock (_queue)
		{
			if (_activeWait && !_signled)
			{
				CancellationToken cancellationToken = _cancellationToken;
				ClearPreviousOperation();
				_mrvtsc.SetException(new OperationCanceledException(cancellationToken));
			}
		}
	}

	private void ClearPreviousOperation()
	{
		_signled = true;
		_forStream = false;
		_operationMode = 0;
		_buffer = default(ReadOnlyMemory<byte>);
		_waitForByteCount = 0;
		_waitForSegmentCount = 0;
		_cancellationToken = default(CancellationToken);
	}

	public bool TryDequeue(out KcpBuffer data, out byte fragment)
	{
		lock (_queue)
		{
			LinkedListNode<(KcpBuffer, byte)> first = _queue.First;
			if (first == null)
			{
				data = default(KcpBuffer);
				fragment = 0;
				return false;
			}
			(data, fragment) = first.ValueRef;
			_queue.RemoveFirst();
			first.ValueRef = default((KcpBuffer, byte));
			_cache.Return(first);
			MoveOneSegmentIn();
			CheckForAvailableSpace();
			return true;
		}
	}

	public void NotifyAckListChanged(bool itemsListNotEmpty)
	{
		lock (_queue)
		{
			if (!_transportClosed && !_disposed)
			{
				_ackListNotEmpty = itemsListNotEmpty;
				TryCompleteFlush(Interlocked.Read(ref _unflushedBytes));
			}
		}
	}

	private void MoveOneSegmentIn()
	{
		if (_activeWait && !_signled && _operationMode == 0)
		{
			ReadOnlyMemory<byte> buffer = _buffer;
			int mss = _mss;
			int num = ((buffer.Length <= mss) ? 1 : ((buffer.Length + mss - 1) / mss));
			int num2 = ((buffer.Length > mss) ? mss : buffer.Length);
			KcpBuffer buffer2 = KcpBuffer.CreateFromSpan(_bufferPool.Rent(new KcpBufferPoolRentOptions(mss, isOutbound: false)), buffer.Span.Slice(0, num2));
			_buffer = buffer.Slice(num2);
			_queue.AddLast(_cache.Rent(in buffer2, (byte)((!_stream) ? ((byte)(num - 1)) : 0)));
			Interlocked.Add(ref _unflushedBytes, num2);
			if (num == 1)
			{
				ClearPreviousOperation();
				_mrvtsc.SetResult(result: true);
			}
		}
	}

	private void CheckForAvailableSpace()
	{
		if (_activeWait && !_signled && _operationMode == 2)
		{
			GetAvailableSpaceCore(out var byteCount, out var segmentCount);
			if (byteCount >= _waitForByteCount && segmentCount >= _waitForSegmentCount)
			{
				ClearPreviousOperation();
				_mrvtsc.SetResult(result: true);
			}
		}
	}

	private void TryCompleteFlush(long unflushedBytes)
	{
		if (_activeWait && !_signled && _operationMode == 1 && _queue.Last == null && unflushedBytes == 0L && !_ackListNotEmpty)
		{
			ClearPreviousOperation();
			_mrvtsc.SetResult(result: true);
		}
	}

	public void SubtractUnflushedBytes(int size)
	{
		if (Interlocked.Add(ref _unflushedBytes, -size) == 0L)
		{
			lock (_queue)
			{
				TryCompleteFlush(0L);
			}
		}
	}

	public long GetUnflushedBytes()
	{
		if (_transportClosed || _disposed)
		{
			return 0L;
		}
		return Interlocked.Read(ref _unflushedBytes);
	}

	public void SetTransportClosed()
	{
		lock (_queue)
		{
			if (_transportClosed || _disposed)
			{
				return;
			}
			if (_activeWait && !_signled)
			{
				if (_forStream)
				{
					ClearPreviousOperation();
					_mrvtsc.SetException(ThrowHelper.NewTransportClosedForStreamException());
				}
				else
				{
					ClearPreviousOperation();
					_mrvtsc.SetResult(result: false);
				}
			}
			_transportClosed = true;
			Interlocked.Exchange(ref _unflushedBytes, 0L);
		}
	}
}
