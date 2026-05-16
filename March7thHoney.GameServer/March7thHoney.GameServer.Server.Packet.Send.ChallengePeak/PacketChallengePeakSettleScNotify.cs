using System.Collections.Generic;
using March7thHoney.Data.Excel;
using March7thHoney.GameServer.Game.Challenge.Instances;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.ChallengePeak;

public class PacketChallengePeakSettleScNotify : BasePacket
{
	public PacketChallengePeakSettleScNotify(ChallengePeakInstance inst, List<uint> targetIdList)
		: base(8905)
	{
		ChallengePeakSettleScNotify obj = new ChallengePeakSettleScNotify
		{
			CyclesUsed = inst.Data.Peak.RoundCnt,
			IsWin = inst.IsWin,
			PeakId = inst.Data.Peak.CurrentPeakLevelId,
			FinishedTargetList = { (IEnumerable<uint>)targetIdList }
		};
		int hardModeHasPassed;
		if (inst != null && inst.IsWin)
		{
			ChallengePeakConfigExcel config = inst.Config;
			if (config != null && config.BossExcel != null)
			{
				hardModeHasPassed = (inst.Data.Peak.IsHard ? 1 : 0);
				goto IL_0085;
			}
		}
		hardModeHasPassed = 0;
		goto IL_0085;
		IL_0085:
		obj.HardModeHasPassed = (byte)hardModeHasPassed != 0;
		ChallengePeakSettleScNotify data = obj;
		SetData(data);
	}
}
