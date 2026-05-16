using System;
using System.Net.Sockets;

namespace March7thHoney.Kcp.KcpSharp;

internal sealed class KcpSocketTransportForMultiplexConnection<T> : KcpSocketTransport<KcpMultiplexConnection<T>>, IKcpTransport<IKcpMultiplexConnection<T>>, IKcpTransport, IKcpExceptionProducer<IKcpTransport<IKcpMultiplexConnection<T>>>, IDisposable
{
	private readonly Action<T?>? _disposeAction;

	private Func<Exception, IKcpTransport<IKcpMultiplexConnection<T>>, object?, bool>? _exceptionHandler;

	private object? _exceptionHandlerState;

	IKcpMultiplexConnection<T> IKcpTransport<IKcpMultiplexConnection<T>>.Connection => base.Connection;

	internal KcpSocketTransportForMultiplexConnection(UdpClient listener, int mtu)
		: base(listener, mtu)
	{
	}

	internal KcpSocketTransportForMultiplexConnection(UdpClient listener, int mtu, Action<T?>? disposeAction)
		: base(listener, mtu)
	{
		_disposeAction = disposeAction;
	}

	public void SetExceptionHandler(Func<Exception, IKcpTransport<IKcpMultiplexConnection<T>>, object?, bool> handler, object? state)
	{
		_exceptionHandler = handler;
		_exceptionHandlerState = state;
	}

	protected override KcpMultiplexConnection<T> Activate()
	{
		return new KcpMultiplexConnection<T>(this, _disposeAction);
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
