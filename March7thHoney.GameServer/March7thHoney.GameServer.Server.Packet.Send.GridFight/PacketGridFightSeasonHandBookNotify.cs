using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.GridFight;

public class PacketGridFightSeasonHandBookNotify : BasePacket
{
	public PacketGridFightSeasonHandBookNotify(GridFightSeasonHandBookNotify n)
		: base(8605)
	{
		SetData(n);
	}
}
