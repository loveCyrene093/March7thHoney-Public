using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.Data.Config;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Scene;
using March7thHoney.Enums.Mission;
using March7thHoney.Enums.Scene;
using March7thHoney.GameServer.Game.Player;

namespace March7thHoney.GameServer.Game.Mission.FinishType.Handler;

[MissionFinishType(MissionFinishTypeEnum.PropTypeInteract)]
public class MissionHandlerPropTypeInteract : MissionFinishTypeHandler
{
	public override async ValueTask HandleMissionFinishType(PlayerInstance player, SubMissionInfo info, object? arg)
	{
		await ValueTask.CompletedTask;
	}

	public override async ValueTask HandleQuestFinishType(PlayerInstance player, QuestDataExcel quest, FinishWayExcel excel, object? arg)
	{
		int num = 0;
		foreach (KeyValuePair<int, Dictionary<int, List<ScenePropData>>> item in player.SceneData?.ScenePropData ?? new Dictionary<int, Dictionary<int, List<ScenePropData>>>())
		{
			foreach (KeyValuePair<int, List<ScenePropData>> item2 in item.Value)
			{
				foreach (ScenePropData item3 in item2.Value)
				{
					if (item3.State == (PropStateEnum)excel.ParamInt2)
					{
						num++;
					}
				}
			}
		}
		await player.QuestManager.UpdateQuestProgress(quest.QuestID, num);
	}
}
