using System;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace March7thHoney.Kcp.KcpSharp;

internal sealed class KcpRawSendOperation : IValueTaskSource<bool>, IDisposable
{
	private readonly AsyncAutoResetEvent<int> _notification;

	private bool _activeWait;

	private ReadOnlyMemory<byte> _buffer;

	private CancellationTokenRegistration _cancellationRegistration;

	private CancellationToken _cancellationToken;

	private bool _disposed;

	private ManualResetValueTaskSourceCore<bool> _mrvtsc;

	private bool _signaled;

	private bool _transportClosed;

	public KcpRawSendOperation(AsyncAutoResetEvent<int> notification)
	{
		_notification = notification;
		_mrvtsc = new ManualResetValueTaskSourceCore<bool>
		{
			RunContinuationsAsynchronously = true
		};
	}

	public void Dispose()
	{
		lock (this)
		{
			if (!_disposed)
			{
				if (_activeWait && !_signaled)
				{
					ClearPreviousOperation();
					_mrvtsc.SetResult(result: false);
				}
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
			return _mrvtsc.GetResult(token);
		}
		finally
		{
			_mrvtsc.Reset();
			lock (this)
			{
				_activeWait = false;
				_signaled = false;
				_cancellationRegistration = default(CancellationTokenRegistration);
			}
		}
	}

	ValueTaskSourceStatus IValueTaskSource<bool>.GetStatus(short token)
	{
		return _mrvtsc.GetStatus(token);
	}

	void IValueTaskSource<bool>.OnCompleted(Action<object?> continuation, object? state, short token, ValueTaskSourceOnCompletedFlags flags)
	{
		_mrvtsc.OnCompleted(continuation, state, token, flags);
	}

	public ValueTask<bool> SendAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
	{
		short version;
		lock (this)
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
			_buffer = buffer;
			_cancellationToken = cancellationToken;
			version = _mrvtsc.Version;
		}
		_cancellationRegistration = cancellationToken.UnsafeRegister(delegate(object? state)
		{
			((KcpRawSendOperation)state).SetCanceled();
		}, this);
		_notification.Set(buffer.Length);
		return new ValueTask<bool>(this, version);
	}

	public bool CancelPendingOperation(Exception? innerException, CancellationToken cancellationToken)
	{
		lock (this)
		{
			if (_activeWait && !_signaled)
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
		lock (this)
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
		_buffer = default(ReadOnlyMemory<byte>);
		_cancellationToken = default(CancellationToken);
	}

	public bool TryConsume(Memory<byte> buffer, out int bytesWritten)
	{
		lock (this)
		{
			if (_transportClosed || _disposed)
			{
				bytesWritten = 0;
				return false;
			}
			if (!_activeWait)
			{
				bytesWritten = 0;
				return false;
			}
			ReadOnlyMemory<byte> buffer2 = _buffer;
			if (buffer2.Length > buffer.Length)
			{
				ClearPreviousOperation();
				_mrvtsc.SetException(ThrowHelper.NewMessageTooLargeForBufferArgument());
				bytesWritten = 0;
				return false;
			}
			buffer2.CopyTo(buffer);
			bytesWritten = buffer2.Length;
			ClearPreviousOperation();
			_mrvtsc.SetResult(result: true);
			return true;
		}
	}

	public void SetTransportClosed()
	{
		lock (this)
		{
			if (!_transportClosed && !_disposed)
			{
				if (_activeWait && !_signaled)
				{
					ClearPreviousOperation();
					_mrvtsc.SetResult(result: false);
				}
				_transportClosed = true;
			}
		}
	}
}
