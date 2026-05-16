using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.GridFight;

public class PacketGridFightSeasonTalentResetScRsp : BasePacket
{
	public PacketGridFightSeasonTalentResetScRsp()
		: base(8536)
	{
		SetData(new GridFightSeasonTalentResetScRsp());
	}
}
