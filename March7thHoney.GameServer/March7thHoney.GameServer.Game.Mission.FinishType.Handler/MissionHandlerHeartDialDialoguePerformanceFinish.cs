using System.Threading.Tasks;
using March7thHoney.Data.Config;
using March7thHoney.Data.Excel;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Player;

namespace March7thHoney.GameServer.Game.Mission.FinishType.Handler;

[MissionFinishType(MissionFinishTypeEnum.HeartDialDialoguePerformanceFinish)]
public class MissionHandlerHeartDialDialoguePerformanceFinish : MissionFinishTypeHandler
{
	public override async ValueTask HandleMissionFinishType(PlayerInstance player, SubMissionInfo info, object? arg)
	{
		if (!(arg is string text) || !text.StartsWith("HeartDial_"))
		{
			return;
		}
		int item = int.Parse(text.Replace("HeartDial_", ""));
		if (info.ParamIntList?.Contains(item) ?? false)
		{
			await player.MissionManager.AddMissionProgress(info.ID, 1);
			if (player.MissionManager.GetMissionProgress(info.ID) >= info.Progress)
			{
				await player.MissionManager.FinishSubMission(info.ID);
			}
		}
	}

	public override async ValueTask HandleQuestFinishType(PlayerInstance player, QuestDataExcel quest, FinishWayExcel excel, object? arg)
	{
		await ValueTask.CompletedTask;
	}
}
