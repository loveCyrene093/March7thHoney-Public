using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.GridFight;

public class PacketGDMIIBNJJEJ : BasePacket
{
	public PacketGDMIIBNJJEJ()
		: base(8739)
	{
		SetData(new GDMIIBNJJEJ());
	}
}
