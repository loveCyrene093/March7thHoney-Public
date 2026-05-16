using System;
using System.Text;
using System.Threading.Tasks;
using March7thHoney.Data.Config;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Scene;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Player;

namespace March7thHoney.GameServer.Game.Mission.FinishType.Handler;

[MissionFinishType(MissionFinishTypeEnum.TimeLineSetState)]
public class MissionHandlerTimeLineSetState : MissionFinishTypeHandler
{
	public override async ValueTask HandleMissionFinishType(PlayerInstance player, SubMissionInfo info, object? arg)
	{
		int levelFloorID = info.LevelFloorID;
		int paramInt = info.ParamInt1;
		int paramInt2 = info.ParamInt2;
		string paramStr = info.ParamStr1;
		ScenePropTimelineData scenePropTimelineData = player.GetScenePropTimelineData(levelFloorID, paramInt, paramInt2);
		if (scenePropTimelineData != null && !(Encoding.UTF8.GetString(Convert.FromBase64String(scenePropTimelineData.ByteValue)) != paramStr))
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
		ScenePropTimelineData scenePropTimelineData = player.GetScenePropTimelineData(mazeFloorID, paramInt, paramInt2);
		if (scenePropTimelineData != null && !(Encoding.UTF8.GetString(Convert.FromBase64String(scenePropTimelineData.ByteValue)) != paramStr))
		{
			await player.QuestManager.AddQuestProgress(excel.ID, 1);
		}
	}
}
