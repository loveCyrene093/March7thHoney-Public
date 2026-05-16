using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.GridFight;

public class PacketKMDHLENLIMF : BasePacket
{
	public PacketKMDHLENLIMF()
		: base(8753)
	{
		SetData(new KMDHLENLIMF());
	}
}
