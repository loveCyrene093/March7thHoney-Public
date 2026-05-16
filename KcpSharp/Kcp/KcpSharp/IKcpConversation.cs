using System;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace March7thHoney.Kcp.KcpSharp;

public interface IKcpConversation : IDisposable
{
	ValueTask InputPakcetAsync(UdpReceiveResult packet, CancellationToken cancellationToken);

	void SetTransportClosed();
}
