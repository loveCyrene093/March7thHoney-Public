using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace March7thHoney.Kcp.KcpSharp;

public interface IKcpTransport
{
	ValueTask SendPacketAsync(Memory<byte> packet, IPEndPoint remoteEndpoint, CancellationToken cancellationToken);
}
public interface IKcpTransport<out T> : IKcpTransport, IKcpExceptionProducer<IKcpTransport<T>>, IDisposable
{
	T Connection { get; }

	void Start();
}
