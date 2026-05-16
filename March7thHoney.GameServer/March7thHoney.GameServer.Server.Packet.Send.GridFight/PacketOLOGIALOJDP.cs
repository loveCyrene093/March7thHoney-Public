using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.GridFight;

public class PacketOLOGIALOJDP : BasePacket
{
	public PacketOLOGIALOJDP()
		: base(8696)
	{
		SetData(new OLOGIALOJDP());
	}
}
