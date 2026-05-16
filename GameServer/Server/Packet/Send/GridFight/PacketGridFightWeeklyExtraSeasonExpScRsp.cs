using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.GridFight;

public class PacketGridFightWeeklyExtraSeasonExpScRsp : BasePacket
{
	public PacketGridFightWeeklyExtraSeasonExpScRsp(uint extraExp = 337u)
		: base(8771)
	{
		SetData(new GridFightWeeklyExtraSeasonExpScRsp
		{
			CurTakenExtraExp = extraExp
		});
	}
}
