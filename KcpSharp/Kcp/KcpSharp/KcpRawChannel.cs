using System;
using System.Buffers.Binary;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace March7thHoney.Kcp.KcpSharp;

public sealed class KcpRawChannel : IKcpConversation, IDisposable, IKcpExceptionProducer<KcpRawChannel>
{
	private readonly IKcpBufferPool _bufferPool;

	private readonly ulong? _id;

	private readonly int _mtu;

	private readonly int _postBufferSize;

	private readonly int _preBufferSize;

	private readonly KcpRawReceiveQueue _receiveQueue;

	private readonly IPEndPoint _remoteEndPoint;

	private readonly AsyncAutoResetEvent<int> _sendNotification;

	private readonly KcpRawSendOperation _sendOperation;

	private readonly IKcpTransport _transport;

	private Func<Exception, KcpRawChannel, object?, bool>? _exceptionHandler;

	private object? _exceptionHandlerState;

	private CancellationTokenSource? _sendLoopCts;

	public long? ConversationId => (long?)_id;

	public bool TransportClosed => _sendLoopCts == null;

	public KcpRawChannel(IPEndPoint remoteEndPoint, IKcpTransport transport, KcpRawChannelOptions? options)
		: this(remoteEndPoint, transport, null, options)
	{
	}

	public KcpRawChannel(IPEndPoint remoteEndPoint, IKcpTransport transport, long conversationId, KcpRawChannelOptions? options)
		: this(remoteEndPoint, transport, (ulong)conversationId, options)
	{
	}

	private KcpRawChannel(IPEndPoint remoteEndPoint, IKcpTransport transport, ulong? conversationId, KcpRawChannelOptions? options)
	{
		_bufferPool = options?.BufferPool ?? DefaultArrayPoolBufferAllocator.Default;
		_remoteEndPoint = remoteEndPoint;
		_transport = transport;
		_id = conversationId;
		if (options == null)
		{
			_mtu = 1400;
		}
		else
		{
			if (options.Mtu < 50)
			{
				throw new ArgumentException("MTU must be at least 50.", "options");
			}
			_mtu = options.Mtu;
		}
		_preBufferSize = options?.PreBufferSize ?? 0;
		_postBufferSize = options?.PostBufferSize ?? 0;
		if (_preBufferSize < 0)
		{
			throw new ArgumentException("PreBufferSize must be a non-negative integer.", "options");
		}
		if (_postBufferSize < 0)
		{
			throw new ArgumentException("PostBufferSize must be a non-negative integer.", "options");
		}
		if ((uint)(_preBufferSize + _postBufferSize) >= (uint)_mtu)
		{
			throw new ArgumentException("The sum of PreBufferSize and PostBufferSize must be less than MTU.", "options");
		}
		if (conversationId.HasValue && (uint)(_preBufferSize + _postBufferSize) >= (uint)(_mtu - 4))
		{
			throw new ArgumentException("The sum of PreBufferSize and PostBufferSize is too large. There is not enough space in the packet for the conversation ID.", "options");
		}
		int num = options?.ReceiveQueueSize ?? 32;
		if (num < 1)
		{
			throw new ArgumentException("QueueSize must be a positive integer.", "options");
		}
		_sendLoopCts = new CancellationTokenSource();
		_sendNotification = new AsyncAutoResetEvent<int>();
		_receiveQueue = new KcpRawReceiveQueue(_bufferPool, num);
		_sendOperation = new KcpRawSendOperation(_sendNotification);
		RunSendLoop();
	}

	public ValueTask InputPakcetAsync(UdpReceiveResult packet, CancellationToken cancellationToken = default(CancellationToken))
	{
		ReadOnlySpan<byte> readOnlySpan = packet.Buffer.AsSpan();
		int num = (_id.HasValue ? 8 : 0);
		if (readOnlySpan.Length < num || readOnlySpan.Length > _mtu)
		{
			return default(ValueTask);
		}
		if (_id.HasValue)
		{
			if (BinaryPrimitives.ReadUInt64BigEndian(readOnlySpan) != _id.GetValueOrDefault())
			{
				return default(ValueTask);
			}
			readOnlySpan = readOnlySpan.Slice(8);
		}
		_receiveQueue.Enqueue(readOnlySpan);
		return default(ValueTask);
	}

	public void SetTransportClosed()
	{
		CancellationTokenSource cancellationTokenSource = Interlocked.Exchange(ref _sendLoopCts, null);
		if (cancellationTokenSource != null)
		{
			cancellationTokenSource.Cancel();
			cancellationTokenSource.Dispose();
		}
		_receiveQueue.SetTransportClosed();
		_sendOperation.SetTransportClosed();
		_sendNotification.Set(0);
	}

	public void Dispose()
	{
		SetTransportClosed();
		_receiveQueue.Dispose();
		_sendOperation.Dispose();
	}

	public void SetExceptionHandler(Func<Exception, KcpRawChannel, object?, bool> handler, object? state)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		_exceptionHandler = handler;
		_exceptionHandlerState = state;
	}

	public ValueTask<bool> SendAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
	{
		return _sendOperation.SendAsync(buffer, cancellationToken);
	}

	public bool CancelPendingSend()
	{
		return _sendOperation.CancelPendingOperation(null, default(CancellationToken));
	}

	public bool CancelPendingSend(Exception? innerException, CancellationToken cancellationToken)
	{
		return _sendOperation.CancelPendingOperation(innerException, cancellationToken);
	}

	private async void RunSendLoop()
	{
		CancellationToken cancellationToken = _sendLoopCts?.Token ?? new CancellationToken(canceled: true);
		KcpRawSendOperation sendOperation = _sendOperation;
		AsyncAutoResetEvent<int> ev = _sendNotification;
		int mss = _mtu - _preBufferSize - _postBufferSize;
		if (_id.HasValue)
		{
			mss -= 8;
		}
		try
		{
			while (!cancellationToken.IsCancellationRequested)
			{
				int num = await ev.WaitAsync().ConfigureAwait(continueOnCapturedContext: false);
				if (cancellationToken.IsCancellationRequested)
				{
					break;
				}
				if (num < 0 || num > mss)
				{
					sendOperation.TryConsume(default(Memory<byte>), out var _);
					continue;
				}
				int num2 = _preBufferSize + _postBufferSize;
				if (_id.HasValue)
				{
					num2 += 8;
				}
				using KcpRentedBuffer owner = _bufferPool.Rent(new KcpBufferPoolRentOptions(num + num2, isOutbound: true));
				Memory<byte> buffer = owner.Memory;
				Span<byte> span;
				if (_preBufferSize != 0)
				{
					span = buffer.Span.Slice(0, _preBufferSize);
					span.Clear();
					buffer = buffer.Slice(_preBufferSize);
				}
				if (_id.HasValue)
				{
					BinaryPrimitives.WriteUInt64LittleEndian(buffer.Span, _id.GetValueOrDefault());
					buffer = buffer.Slice(8);
				}
				if (!sendOperation.TryConsume(buffer, out var bytesWritten2))
				{
					continue;
				}
				num = Math.Min(num, bytesWritten2);
				buffer = buffer.Slice(num);
				if (_postBufferSize != 0)
				{
					span = buffer.Span;
					span.Slice(0, _postBufferSize).Clear();
				}
				try
				{
					await _transport.SendPacketAsync(owner.Memory.Slice(0, num + num2), _remoteEndPoint, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				}
				catch (Exception ex)
				{
					if (!HandleFlushException(ex))
					{
						break;
					}
				}
			}
		}
		catch (OperationCanceledException)
		{
		}
		catch (Exception ex3)
		{
			HandleFlushException(ex3);
		}
	}

	private bool HandleFlushException(Exception ex)
	{
		Func<Exception, KcpRawChannel, object, bool> exceptionHandler = _exceptionHandler;
		object exceptionHandlerState = _exceptionHandlerState;
		bool flag = false;
		if (exceptionHandler != null)
		{
			try
			{
				flag = exceptionHandler(ex, this, exceptionHandlerState);
			}
			catch
			{
				flag = false;
			}
		}
		if (!flag)
		{
			SetTransportClosed();
		}
		return flag;
	}

	public bool TryPeek(out KcpConversationReceiveResult result)
	{
		return _receiveQueue.TryPeek(out result);
	}

	public bool TryReceive(Span<byte> buffer, out KcpConversationReceiveResult result)
	{
		return _receiveQueue.TryReceive(buffer, out result);
	}

	public ValueTask<KcpConversationReceiveResult> WaitToReceiveAsync(CancellationToken cancellationToken)
	{
		return _receiveQueue.WaitToReceiveAsync(cancellationToken);
	}

	public ValueTask<KcpConversationReceiveResult> ReceiveAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
	{
		return _receiveQueue.ReceiveAsync(buffer, cancellationToken);
	}

	public bool CancelPendingReceive()
	{
		return _receiveQueue.CancelPendingOperation(null, default(CancellationToken));
	}

	public bool CancelPendingReceive(Exception? innerException, CancellationToken cancellationToken)
	{
		return _receiveQueue.CancelPendingOperation(innerException, cancellationToken);
	}
}
