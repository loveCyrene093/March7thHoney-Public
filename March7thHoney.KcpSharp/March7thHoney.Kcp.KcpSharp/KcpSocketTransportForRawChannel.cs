using System;
using System.Net;
using System.Net.Sockets;

namespace March7thHoney.Kcp.KcpSharp;

internal sealed class KcpSocketTransportForRawChannel : KcpSocketTransport<KcpRawChannel>, IKcpTransport<KcpRawChannel>, IKcpTransport, IKcpExceptionProducer<IKcpTransport<KcpRawChannel>>, IDisposable
{
	private readonly long? _conversationId;

	private readonly KcpRawChannelOptions? _options;

	private readonly IPEndPoint _remoteEndPoint;

	private Func<Exception, IKcpTransport<KcpRawChannel>, object?, bool>? _exceptionHandler;

	private object? _exceptionHandlerState;

	internal KcpSocketTransportForRawChannel(UdpClient listener, IPEndPoint endPoint, long? conversationId, KcpRawChannelOptions? options)
		: base(listener, options?.Mtu ?? 1400)
	{
		_conversationId = conversationId;
		_remoteEndPoint = endPoint;
		_options = options;
	}

	public void SetExceptionHandler(Func<Exception, IKcpTransport<KcpRawChannel>, object?, bool> handler, object? state)
	{
		_exceptionHandler = handler;
		_exceptionHandlerState = state;
	}

	protected override KcpRawChannel Activate()
	{
		if (!_conversationId.HasValue)
		{
			return new KcpRawChannel(_remoteEndPoint, this, _options);
		}
		return new KcpRawChannel(_remoteEndPoint, this, _conversationId.GetValueOrDefault(), _options);
	}

	protected override bool HandleException(Exception ex)
	{
		if (_exceptionHandler != null)
		{
			return _exceptionHandler(ex, this, _exceptionHandlerState);
		}
		return false;
	}
}
