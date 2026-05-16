using System.Threading.Tasks;
using March7thHoney.Data.Config;
using March7thHoney.Data.Excel;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.Mission.FinishType.Handler;

[MissionFinishType(MissionFinishTypeEnum.FinishQuest)]
public class MissionHandlerFinishQuest : MissionFinishTypeHandler
{
	public override async ValueTask HandleMissionFinishType(PlayerInstance player, SubMissionInfo info, object? arg)
	{
		await ValueTask.CompletedTask;
	}

	public override async ValueTask HandleQuestFinishType(PlayerInstance player, QuestDataExcel quest, FinishWayExcel excel, object? arg)
	{
		int num = 0;
		foreach (int paramInt in excel.ParamIntList)
		{
			QuestStatus? questStatus = player.QuestManager?.GetQuestStatus(paramInt);
			if (questStatus == QuestStatus.QuestFinish || questStatus == QuestStatus.QuestClose)
			{
				num++;
			}
		}
		await player.QuestManager.UpdateQuestProgress(quest.QuestID, num);
	}
}
