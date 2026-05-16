using March7thHoney.GameServer.Game.Battle;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Scene;

public class PacketSceneEnterStageScRsp : BasePacket
{
	public PacketSceneEnterStageScRsp()
		: base(1500)
	{
		SceneEnterStageScRsp data = new SceneEnterStageScRsp
		{
			Retcode = 1u
		};
		SetData(data);
	}

	public PacketSceneEnterStageScRsp(BattleInstance battleInstance)
		: base(1500)
	{
		SceneEnterStageScRsp data = new SceneEnterStageScRsp
		{
			BattleInfo = battleInstance.ToProto()
		};
		SetData(data);
	}
}
