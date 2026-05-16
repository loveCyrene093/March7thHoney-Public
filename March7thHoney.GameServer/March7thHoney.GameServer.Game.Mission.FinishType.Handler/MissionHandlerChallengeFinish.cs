using System.Threading.Tasks;
using March7thHoney.Data.Config;
using March7thHoney.Data.Excel;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Challenge.Definitions;
using March7thHoney.GameServer.Game.Player;

namespace March7thHoney.GameServer.Game.Mission.FinishType.Handler;

[MissionFinishType(MissionFinishTypeEnum.ChallengeFinish)]
public class MissionHandlerChallengeFinish : MissionFinishTypeHandler
{
	public override async ValueTask HandleMissionFinishType(PlayerInstance player, SubMissionInfo info, object? arg)
	{
		if (arg is BaseLegacyChallengeInstance baseLegacyChallengeInstance && baseLegacyChallengeInstance.Config.ID == info.ParamInt1 && baseLegacyChallengeInstance.IsWin)
		{
			await player.MissionManager.FinishSubMission(info.ID);
		}
	}

	public override async ValueTask HandleQuestFinishType(PlayerInstance player, QuestDataExcel quest, FinishWayExcel excel, object? arg)
	{
		if (arg is BaseLegacyChallengeInstance baseLegacyChallengeInstance && baseLegacyChallengeInstance.Config.ID == excel.ParamInt1 && baseLegacyChallengeInstance.IsWin)
		{
			await player.QuestManager.AddQuestProgress(quest.QuestID, 1);
		}
	}
}
