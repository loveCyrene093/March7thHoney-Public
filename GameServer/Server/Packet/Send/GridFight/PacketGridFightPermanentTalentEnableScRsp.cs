using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.GridFight;

public class PacketGridFightPermanentTalentEnableScRsp : BasePacket
{
	public PacketGridFightPermanentTalentEnableScRsp()
		: base(8438)
	{
		SetData(new GridFightPermanentTalentEnableScRsp());
	}
}
