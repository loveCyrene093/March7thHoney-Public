using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Battle;

public class PacketGetCurBattleInfoScRsp : BasePacket
{
	public PacketGetCurBattleInfoScRsp()
		: base(118)
	{
		GetCurBattleInfoScRsp data = new GetCurBattleInfoScRsp
		{
			BattleInfo = new SceneBattleInfo()
		};
		SetData(data);
	}
}
