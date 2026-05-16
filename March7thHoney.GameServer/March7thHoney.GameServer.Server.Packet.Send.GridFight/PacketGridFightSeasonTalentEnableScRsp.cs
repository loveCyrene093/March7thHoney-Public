using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.GridFight;

public class PacketGridFightSeasonTalentEnableScRsp : BasePacket
{
	public PacketGridFightSeasonTalentEnableScRsp()
		: base(8712)
	{
		SetData(new GridFightSeasonTalentEnableScRsp());
	}
}
