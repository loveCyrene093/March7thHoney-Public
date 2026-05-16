using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Player;

public class PacketRetcodeNotify : BasePacket
{
	public PacketRetcodeNotify(Retcode retcode)
		: base(691)
	{
		SetData(new PlayerSyncScNotify());
	}
}
