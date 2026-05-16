using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.Data.Config;
using March7thHoney.Data.Excel;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Player;

namespace March7thHoney.GameServer.Game.Mission.FinishType.Handler;

[MissionFinishType(MissionFinishTypeEnum.SubMissionFinishCnt)]
public class MissionHandlerSubMissionFinishCnt : MissionFinishTypeHandler
{
	public override async ValueTask HandleMissionFinishType(PlayerInstance player, SubMissionInfo info, object? arg)
	{
		int num = 0;
		foreach (int item in info.ParamIntList ?? new List<int>())
		{
			MissionPhaseEnum subMissionStatus = player.MissionManager.GetSubMissionStatus(item);
			if (subMissionStatus == MissionPhaseEnum.Finish || subMissionStatus == MissionPhaseEnum.Cancel)
			{
				num++;
			}
		}
		if (num >= info.Progress)
		{
			await player.MissionManager.FinishSubMission(info.ID);
		}
		else if (player.MissionManager.GetMissionProgress(info.ID) != num)
		{
			await player.MissionManager.SetMissionProgress(info.ID, num);
		}
	}

	public override async ValueTask HandleQuestFinishType(PlayerInstance player, QuestDataExcel quest, FinishWayExcel excel, object? arg)
	{
		int num = 0;
		foreach (int paramInt in excel.ParamIntList)
		{
			MissionPhaseEnum subMissionStatus = player.MissionManager.GetSubMissionStatus(paramInt);
			if (subMissionStatus == MissionPhaseEnum.Finish || subMissionStatus == MissionPhaseEnum.Cancel)
			{
				num++;
			}
		}
		await player.QuestManager.UpdateQuestProgress(quest.QuestID, num);
	}
}
