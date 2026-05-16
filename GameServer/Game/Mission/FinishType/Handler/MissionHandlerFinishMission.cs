using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.Data.Config;
using March7thHoney.Data.Excel;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Player;

namespace March7thHoney.GameServer.Game.Mission.FinishType.Handler;

[MissionFinishType(MissionFinishTypeEnum.FinishMission)]
public class MissionHandlerFinishMission : MissionFinishTypeHandler
{
	public override async ValueTask HandleMissionFinishType(PlayerInstance player, SubMissionInfo info, object? arg)
	{
		bool flag = true;
		foreach (int item in info.ParamIntList ?? new List<int>())
		{
			if (player.MissionManager.GetMainMissionStatus(item) != MissionPhaseEnum.Finish)
			{
				flag = false;
				break;
			}
		}
		if (flag)
		{
			await player.MissionManager.FinishSubMission(info.ID);
		}
	}

	public override async ValueTask HandleQuestFinishType(PlayerInstance player, QuestDataExcel quest, FinishWayExcel excel, object? arg)
	{
		int num = 0;
		foreach (int paramInt in excel.ParamIntList)
		{
			if (player.MissionManager.GetMainMissionStatus(paramInt) == MissionPhaseEnum.Finish)
			{
				num++;
			}
		}
		await player.QuestManager.UpdateQuestProgress(quest.QuestID, num);
	}
}
