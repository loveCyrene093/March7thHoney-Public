using System.Threading.Tasks;
using March7thHoney.Data.Config;
using March7thHoney.Data.Excel;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Player;

namespace March7thHoney.GameServer.Game.Mission.FinishType.Handler;

[MissionFinishType(MissionFinishTypeEnum.EnterRaidScene)]
public class MissionHandlerEnterRaidScene : MissionFinishTypeHandler
{
	public override async ValueTask HandleMissionFinishType(PlayerInstance player, SubMissionInfo info, object? arg)
	{
		if (player.RaidManager.RaidData.CurRaidId != info.ParamInt1)
		{
			await player.RaidManager.EnterRaid(info.ParamInt1, 0);
		}
		await player.EnterScene(info.ParamInt2, 0, sendPacket: true);
		await player.MissionManager.FinishSubMission(info.ID);
	}

	public override async ValueTask HandleQuestFinishType(PlayerInstance player, QuestDataExcel quest, FinishWayExcel excel, object? arg)
	{
		await ValueTask.CompletedTask;
	}
}
