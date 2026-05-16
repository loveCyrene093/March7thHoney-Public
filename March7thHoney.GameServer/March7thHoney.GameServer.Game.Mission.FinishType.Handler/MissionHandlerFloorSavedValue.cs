using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.Data.Config;
using March7thHoney.Data.Excel;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Player;

namespace March7thHoney.GameServer.Game.Mission.FinishType.Handler;

[MissionFinishType(MissionFinishTypeEnum.FloorSavedValue)]
public class MissionHandlerFloorSavedValue : MissionFinishTypeHandler
{
	public override async ValueTask HandleMissionFinishType(PlayerInstance player, SubMissionInfo info, object? arg)
	{
		Dictionary<string, int> value = default(Dictionary<string, int>);
		if ((player.SceneData?.FloorSavedData.TryGetValue(info.LevelFloorID, out value) ?? false) && value.TryGetValue(info.ParamStr1, out var value2) && value2 == info.ParamInt1)
		{
			await player.MissionManager.FinishSubMission(info.ID);
		}
	}

	public override async ValueTask HandleQuestFinishType(PlayerInstance player, QuestDataExcel quest, FinishWayExcel excel, object? arg)
	{
		await ValueTask.CompletedTask;
	}
}
