using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.GridFight;

public class PacketEPJJBNPIFLC : BasePacket
{
	public PacketEPJJBNPIFLC()
		: base(8551)
	{
		SetData(new EPJJBNPIFLC());
	}
}
