using System.Threading.Tasks;
using March7thHoney.Data.Config;
using March7thHoney.Data.Excel;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Battle;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.Mission.FinishType.Handler;

[MissionFinishType(MissionFinishTypeEnum.BattleChallenge)]
public class MissionHandlerBattleChallenge : MissionFinishTypeHandler
{
	public override async ValueTask HandleMissionFinishType(PlayerInstance player, SubMissionInfo info, object? arg)
	{
		await ValueTask.CompletedTask;
	}

	public override async ValueTask HandleQuestFinishType(PlayerInstance player, QuestDataExcel quest, FinishWayExcel excel, object? arg)
	{
		if (!(arg is BattleInstance battleInstance))
		{
			return;
		}
		int num = 0;
		if (battleInstance.BattleResult == null)
		{
			return;
		}
		foreach (BattleTargetList value in battleInstance.BattleResult.Stt.BattleTargetInfo.Values)
		{
			foreach (BattleTarget item in value.BattleTargetList_)
			{
				if (excel.ParamIntList.Contains((int)item.Id))
				{
					num += (int)item.Progress;
				}
			}
		}
		await player.QuestManager.UpdateQuestProgress(quest.QuestID, num);
	}
}
