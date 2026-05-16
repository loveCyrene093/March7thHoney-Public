using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.GridFight;

public class PacketGridFightPermanentTalentResetScRsp : BasePacket
{
	public PacketGridFightPermanentTalentResetScRsp()
		: base(8425)
	{
		SetData(new GridFightPermanentTalentResetScRsp());
	}
}
