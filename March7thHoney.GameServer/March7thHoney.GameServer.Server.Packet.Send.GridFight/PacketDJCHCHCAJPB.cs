using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.GridFight;

public class PacketDJCHCHCAJPB : BasePacket
{
	public PacketDJCHCHCAJPB()
		: base(8509)
	{
		SetData(new DJCHCHCAJPB());
	}
}
