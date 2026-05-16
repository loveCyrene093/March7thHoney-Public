using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.GridFight;

public class PacketHGOIBDBMDBG : BasePacket
{
	public PacketHGOIBDBMDBG()
		: base(8686)
	{
		SetData(new HGOIBDBMDBG());
	}
}
