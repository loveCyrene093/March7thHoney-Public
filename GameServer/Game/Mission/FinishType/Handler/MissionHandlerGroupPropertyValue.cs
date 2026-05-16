using System.Threading.Tasks;
using March7thHoney.Data.Config;
using March7thHoney.Data.Excel;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Game.Scene;

namespace March7thHoney.GameServer.Game.Mission.FinishType.Handler;

[MissionFinishType(MissionFinishTypeEnum.GroupPropertyValue)]
public class MissionHandlerGroupPropertyValue : MissionFinishTypeHandler
{
	public override async ValueTask HandleMissionFinishType(PlayerInstance player, SubMissionInfo info, object? arg)
	{
		int levelFloorID = info.LevelFloorID;
		int paramInt = info.ParamInt1;
		int paramInt2 = info.ParamInt2;
		string paramStr = info.ParamStr1;
		SceneInstance? sceneInstance = player.SceneInstance;
		if (sceneInstance != null && sceneInstance.FloorId == levelFloorID && player.SceneInstance.GetGroupProperty(paramInt, paramStr) == paramInt2)
		{
			await player.MissionManager.FinishSubMission(info.ID);
		}
	}

	public override async ValueTask HandleQuestFinishType(PlayerInstance player, QuestDataExcel quest, FinishWayExcel excel, object? arg)
	{
		int mazeFloorID = excel.MazeFloorID;
		int paramInt = excel.ParamInt1;
		int paramInt2 = excel.ParamInt2;
		string paramStr = excel.ParamStr1;
		SceneInstance? sceneInstance = player.SceneInstance;
		if (sceneInstance != null && sceneInstance.FloorId == mazeFloorID && player.SceneInstance.GetGroupProperty(paramInt, paramStr) == paramInt2)
		{
			await player.QuestManager.AddQuestProgress(quest.QuestID, 1);
		}
	}
}
