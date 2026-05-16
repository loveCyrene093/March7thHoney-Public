using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.DiceCombat;

public class PacketV2FinishPveStageScRsp : BasePacket
{
	public PacketV2FinishPveStageScRsp(uint stageId, bool isWin)
		: base(9280)
	{
		SetData(new V2FinishPveStageScRsp
		{
			Retcode = 0u,
			MMLKFJIAKKH = stageId,
			IsWin = isWin,
			Reward = new ItemList()
		});
	}
}
