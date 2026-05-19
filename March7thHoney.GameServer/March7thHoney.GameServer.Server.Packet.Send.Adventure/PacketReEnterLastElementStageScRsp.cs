using March7thHoney.GameServer.Game.Battle;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Adventure;

public class PacketReEnterLastElementStageScRsp : BasePacket
{
	public PacketReEnterLastElementStageScRsp()
		: base(1490)
	{
		ReEnterLastElementStageScRsp data = new ReEnterLastElementStageScRsp
		{
			Retcode = 1u
		};
		SetData(data);
	}

	public PacketReEnterLastElementStageScRsp(BattleInstance battle, int stageId)
		: base(1490)
	{
		ReEnterLastElementStageScRsp data = new ReEnterLastElementStageScRsp
		{
			StageId = (uint)stageId,
			BattleInfo = battle.ToProto()
		};
		SetData(data);
	}
}
