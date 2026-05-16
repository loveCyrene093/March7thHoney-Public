using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.DiceCombat;

public class PacketDiceCombatFinishPveStageScRsp : BasePacket
{
	public PacketDiceCombatFinishPveStageScRsp(uint stageId, bool isWin)
		: base(9265)
	{
		SetData(new FinishPveStageScRsp
		{
			Retcode = 0u,
			IsWin = isWin,
			MMLKFJIAKKH = stageId
		});
	}
}
