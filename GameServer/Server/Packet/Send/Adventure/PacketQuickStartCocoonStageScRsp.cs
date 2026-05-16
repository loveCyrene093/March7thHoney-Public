using March7thHoney.GameServer.Game.Battle;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Adventure;

public class PacketQuickStartCocoonStageScRsp : BasePacket
{
	public PacketQuickStartCocoonStageScRsp()
		: base(1318)
	{
		QuickStartCocoonStageScRsp data = new QuickStartCocoonStageScRsp
		{
			Retcode = 1u
		};
		SetData(data);
	}

	public PacketQuickStartCocoonStageScRsp(BattleInstance battle, int cocoonId, int wave)
		: base(1318)
	{
		QuickStartCocoonStageScRsp data = new QuickStartCocoonStageScRsp
		{
			CocoonId = (uint)cocoonId,
			Wave = (uint)wave,
			Count = (uint)wave,
			BattleInfo = battle.ToProto()
		};
		SetData(data);
	}
}
