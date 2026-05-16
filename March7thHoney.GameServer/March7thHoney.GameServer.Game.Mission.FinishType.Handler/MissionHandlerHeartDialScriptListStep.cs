using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.Data.Config;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Scene;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Player;

namespace March7thHoney.GameServer.Game.Mission.FinishType.Handler;

[MissionFinishType(MissionFinishTypeEnum.HeartDialScriptListStep)]
public class MissionHandlerHeartDialScriptListStep : MissionFinishTypeHandler
{
	public override async ValueTask HandleMissionFinishType(PlayerInstance player, SubMissionInfo info, object? arg)
	{
		int num = 0;
		foreach (int item in info.ParamIntList ?? new List<int>())
		{
			HeartDialInfo value = null;
			player.HeartDialData?.DialList.TryGetValue(item, out value);
			if (value != null && value.StepType == (HeartDialStepTypeEnum)info.ParamInt1)
			{
				num++;
			}
		}
		if (num >= info.Progress)
		{
			await player.MissionManager.FinishSubMission(info.ID);
			return;
		}
		MissionManager? missionManager = player.MissionManager;
		if (missionManager == null || missionManager.GetMissionProgress(info.ID) != num)
		{
			await player.MissionManager.SetMissionProgress(info.ID, num);
		}
	}

	public override async ValueTask HandleQuestFinishType(PlayerInstance player, QuestDataExcel quest, FinishWayExcel excel, object? arg)
	{
		await ValueTask.CompletedTask;
	}
}
