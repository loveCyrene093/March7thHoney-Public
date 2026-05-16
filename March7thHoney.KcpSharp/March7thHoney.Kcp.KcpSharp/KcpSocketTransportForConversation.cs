using System;
using System.Net;
using System.Net.Sockets;

namespace March7thHoney.Kcp.KcpSharp;

internal sealed class KcpSocketTransportForConversation : KcpSocketTransport<KcpConversation>, IKcpTransport<KcpConversation>, IKcpTransport, IKcpExceptionProducer<IKcpTransport<KcpConversation>>, IDisposable
{
	private readonly long? _conversationId;

	private readonly KcpConversationOptions? _options;

	private readonly IPEndPoint _remoteEndPoint;

	private Func<Exception, IKcpTransport<KcpConversation>, object?, bool>? _exceptionHandler;

	private object? _exceptionHandlerState;

	internal KcpSocketTransportForConversation(UdpClient listener, IPEndPoint endPoint, long? conversationId, KcpConversationOptions? options)
		: base(listener, options?.Mtu ?? 1400)
	{
		_conversationId = conversationId;
		_remoteEndPoint = endPoint;
		_options = options;
	}

	public void SetExceptionHandler(Func<Exception, IKcpTransport<KcpConversation>, object?, bool> handler, object? state)
	{
		_exceptionHandler = handler;
		_exceptionHandlerState = state;
	}

	protected override KcpConversation Activate()
	{
		if (!_conversationId.HasValue)
		{
			return new KcpConversation(_remoteEndPoint, this, _options);
		}
		return new KcpConversation(_remoteEndPoint, this, _conversationId.GetValueOrDefault(), _options);
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
