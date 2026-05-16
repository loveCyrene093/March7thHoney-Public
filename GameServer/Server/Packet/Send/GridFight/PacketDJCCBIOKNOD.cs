using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.GridFight;

public class PacketDJCCBIOKNOD : BasePacket
{
	public PacketDJCCBIOKNOD()
		: base(8515)
	{
		SetData(new DJCCBIOKNOD());
	}
}
