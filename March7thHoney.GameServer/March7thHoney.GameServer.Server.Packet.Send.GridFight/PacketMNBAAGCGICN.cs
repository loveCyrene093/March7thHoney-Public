using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.GridFight;

public class PacketMNBAAGCGICN : BasePacket
{
	public PacketMNBAAGCGICN()
		: base(8490)
	{
		SetData(new MNBAAGCGICN());
	}
}
