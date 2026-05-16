using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.Data.Config;
using March7thHoney.Data.Excel;
using March7thHoney.Enums.Mission;
using March7thHoney.Enums.Scene;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Game.Scene.Entity;

namespace March7thHoney.GameServer.Game.Mission.FinishType.Handler;

[MissionFinishType(MissionFinishTypeEnum.PropState)]
public class MissionHandlerPropState : MissionFinishTypeHandler
{
	public override async ValueTask HandleMissionFinishType(PlayerInstance player, SubMissionInfo info, object? arg)
	{
		if (player.SceneInstance?.FloorId != info.LevelFloorID)
		{
			return;
		}
		List<EntityProp> entitiesInGroup = player.SceneInstance.GetEntitiesInGroup<EntityProp>(info.ParamInt1);
		foreach (EntityProp item in entitiesInGroup)
		{
			if (item.PropInfo.ID == info.ParamInt2 && item.State == (PropStateEnum)info.ParamInt3)
			{
				await player.MissionManager.FinishSubMission(info.ID);
			}
			else if (info.ParamInt3 == 7 || info.ParamInt3 == 8)
			{
				await player.MissionManager.FinishSubMission(info.ID);
			}
		}
	}

	public override async ValueTask HandleQuestFinishType(PlayerInstance player, QuestDataExcel quest, FinishWayExcel excel, object? arg)
	{
		if (player.SceneInstance?.FloorId != excel.MazeFloorID)
		{
			return;
		}
		List<EntityProp> entitiesInGroup = player.SceneInstance.GetEntitiesInGroup<EntityProp>(excel.ParamInt1);
		foreach (EntityProp item in entitiesInGroup)
		{
			if (item.PropInfo.ID == excel.ParamInt2 && item.State == (PropStateEnum)excel.ParamInt3)
			{
				await player.QuestManager.AddQuestProgress(quest.QuestID, 1);
			}
			else if (excel.ParamInt3 == 7 || excel.ParamInt3 == 8)
			{
				await player.QuestManager.AddQuestProgress(quest.QuestID, 1);
			}
		}
	}
}
