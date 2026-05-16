using System.Threading.Tasks;
using March7thHoney.Data.Config;
using March7thHoney.Data.Excel;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Battle;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.Mission.FinishType.Handler;

[MissionFinishType(MissionFinishTypeEnum.BattleWinWithCustomValue)]
public class MissionHandlerBattleWinWithCustomValue : MissionFinishTypeHandler
{
	public override async ValueTask HandleMissionFinishType(PlayerInstance player, SubMissionInfo info, object? arg)
	{
		if (arg is BattleInstance { StageId: var stageId } battleInstance && stageId.ToString().StartsWith(info.ParamInt2.ToString()) && battleInstance.BattleEndStatus == BattleEndStatus.BattleEndWin && battleInstance.BattleResult != null && battleInstance.BattleResult.Stt.CustomValues.TryGetValue(info.ParamStr1, out var value) && (int)value == info.ParamInt1)
		{
			await player.MissionManager.FinishSubMission(info.ID);
		}
	}

	public override async ValueTask HandleQuestFinishType(PlayerInstance player, QuestDataExcel quest, FinishWayExcel excel, object? arg)
	{
		await ValueTask.CompletedTask;
	}
}
