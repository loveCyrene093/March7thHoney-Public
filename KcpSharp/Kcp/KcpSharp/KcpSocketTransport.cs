using System;
using System.Buffers;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using March7thHoney.Util;

namespace March7thHoney.Kcp.KcpSharp;

public static class KcpSocketTransport
{
	public static IKcpTransport<KcpConversation> CreateConversation(UdpClient listener, IPEndPoint endPoint, long conversationId, KcpConversationOptions? options)
	{
		if (listener == null)
		{
			throw new ArgumentNullException("listener");
		}
		if (endPoint == null)
		{
			throw new ArgumentNullException("endPoint");
		}
		return new KcpSocketTransportForConversation(listener, endPoint, conversationId, options);
	}

	public static IKcpTransport<KcpConversation> CreateConversation(UdpClient listener, IPEndPoint endPoint, KcpConversationOptions? options)
	{
		if (listener == null)
		{
			throw new ArgumentNullException("listener");
		}
		if (endPoint == null)
		{
			throw new ArgumentNullException("endPoint");
		}
		return new KcpSocketTransportForConversation(listener, endPoint, null, options);
	}

	public static IKcpTransport<KcpRawChannel> CreateRawChannel(UdpClient listener, IPEndPoint endPoint, long conversationId, KcpRawChannelOptions? options)
	{
		if (listener == null)
		{
			throw new ArgumentNullException("listener");
		}
		if (endPoint == null)
		{
			throw new ArgumentNullException("endPoint");
		}
		return new KcpSocketTransportForRawChannel(listener, endPoint, conversationId, options);
	}

	public static IKcpTransport<KcpRawChannel> CreateRawChannel(UdpClient listener, IPEndPoint endPoint, KcpRawChannelOptions? options)
	{
		if (listener == null)
		{
			throw new ArgumentNullException("listener");
		}
		if (endPoint == null)
		{
			throw new ArgumentNullException("endPoint");
		}
		return new KcpSocketTransportForRawChannel(listener, endPoint, null, options);
	}

	public static IKcpTransport<IKcpMultiplexConnection> CreateMultiplexConnection(UdpClient listener, int mtu)
	{
		if (listener == null)
		{
			throw new ArgumentNullException("listener");
		}
		return new KcpSocketTransportForMultiplexConnection<object>(listener, mtu);
	}

	public static IKcpTransport<IKcpMultiplexConnection<T>> CreateMultiplexConnection<T>(UdpClient listener, IPEndPoint endPoint, int mtu)
	{
		if (listener == null)
		{
			throw new ArgumentNullException("listener");
		}
		if (endPoint == null)
		{
			throw new ArgumentNullException("endPoint");
		}
		return new KcpSocketTransportForMultiplexConnection<T>(listener, mtu);
	}

	public static IKcpTransport<IKcpMultiplexConnection<T>> CreateMultiplexConnection<T>(UdpClient listener, EndPoint endPoint, int mtu, Action<T?>? disposeAction)
	{
		if (listener == null)
		{
			throw new ArgumentNullException("listener");
		}
		if (endPoint == null)
		{
			throw new ArgumentNullException("endPoint");
		}
		return new KcpSocketTransportForMultiplexConnection<T>(listener, mtu, disposeAction);
	}
}
public abstract class KcpSocketTransport<T> : IKcpTransport, IDisposable where T : class, IKcpConversation
{
	private readonly int _mtu;

	private readonly UdpClient _udpListener;

	private T? _connection;

	private CancellationTokenSource? _cts;

	private bool _disposed;

	public T Connection => _connection ?? throw new InvalidOperationException();

	protected KcpSocketTransport(UdpClient listener, int mtu)
	{
		_udpListener = listener ?? throw new ArgumentNullException("listener");
		_mtu = mtu;
		if (mtu < 50)
		{
			throw new ArgumentOutOfRangeException("mtu");
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	public ValueTask SendPacketAsync(Memory<byte> packet, IPEndPoint endpoint, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (_disposed)
		{
			return default(ValueTask);
		}
		if (packet.Length > _mtu)
		{
			return default(ValueTask);
		}
		return new ValueTask(_udpListener.SendAsync(packet.ToArray(), endpoint, cancellationToken).AsTask());
	}

	protected abstract T Activate();

	protected virtual IMemoryOwner<byte> AllocateBuffer(int size)
	{
		return new ArrayMemoryOwner(GC.AllocateUninitializedArray<byte>(size, pinned: true));
	}

	protected virtual bool HandleException(Exception ex)
	{
		return false;
	}

	public void Start()
	{
		if (_disposed)
		{
			throw new ObjectDisposedException("KcpSocketTransport");
		}
		if (_connection != null)
		{
			throw new InvalidOperationException();
		}
		_connection = Activate();
		if (_connection == null)
		{
			throw new InvalidOperationException();
		}
		_cts = new CancellationTokenSource();
		RunReceiveLoop();
	}

	private async void RunReceiveLoop()
	{
		CancellationToken cancellationToken = _cts?.Token ?? new CancellationToken(canceled: true);
		IKcpConversation connection = _connection;
		if (connection == null || cancellationToken.IsCancellationRequested)
		{
			return;
		}
		using (AllocateBuffer(_mtu))
		{
			_ = 2;
			try
			{
				while (!cancellationToken.IsCancellationRequested)
				{
					int bytesReceived = 0;
					bool error = false;
					UdpReceiveResult result = default(UdpReceiveResult);
					try
					{
						result = await _udpListener.ReceiveAsync(cancellationToken);
						bytesReceived = result.Buffer.Length;
					}
					catch
					{
					}
					if (bytesReceived != 0 && bytesReceived <= _mtu)
					{
						if (bytesReceived == 20)
						{
							await March7thHoneyListener.HandleHandshake(result);
						}
						else if (!error)
						{
							await connection.InputPakcetAsync(result, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
						}
					}
				}
			}
			catch (OperationCanceledException)
			{
			}
			catch (Exception ex2)
			{
				HandleExceptionWrapper(ex2);
			}
		}
	}

	private bool HandleExceptionWrapper(Exception ex)
	{
		bool result;
		try
		{
			new Logger("KcpServer").Error("KCP Error:", ex);
			result = HandleException(ex);
		}
		catch
		{
			result = false;
		}
		_connection?.SetTransportClosed();
		CancellationTokenSource cancellationTokenSource = Interlocked.Exchange(ref _cts, null);
		if (cancellationTokenSource != null)
		{
			cancellationTokenSource.Cancel();
			cancellationTokenSource.Dispose();
		}
		return result;
	}

	protected virtual void Dispose(bool disposing)
	{
		if (_disposed)
		{
			return;
		}
		if (disposing)
		{
			CancellationTokenSource cancellationTokenSource = Interlocked.Exchange(ref _cts, null);
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
				cancellationTokenSource.Dispose();
			}
			_connection?.Dispose();
		}
		_connection = null;
		_cts = null;
		_disposed = true;
	}

	~KcpSocketTransport()
	{
		Dispose(disposing: false);
	}
}
