using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Data.Config;
using March7thHoney.Data.Excel;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.Mission.FinishType.Handler;

[MissionFinishType(MissionFinishTypeEnum.RaidFinishCnt)]
public class MissionHandlerRaidFinishCnt : MissionFinishTypeHandler
{
	public override async ValueTask HandleMissionFinishType(PlayerInstance player, SubMissionInfo info, object? arg)
	{
		if ((info.ParamIntList ?? new List<int>()).Count((int raidId) => player.RaidManager.GetRaidStatus(raidId) == RaidStatus.Finish) >= info.Progress)
		{
			await player.MissionManager.FinishSubMission(info.ID);
		}
	}

	public override async ValueTask HandleQuestFinishType(PlayerInstance player, QuestDataExcel quest, FinishWayExcel excel, object? arg)
	{
		int progress = excel.ParamIntList.Count((int raidLevel) => player.RaidManager.GetRaidStatus(excel.ParamInt1, raidLevel) == RaidStatus.Finish);
		await player.QuestManager.UpdateQuestProgress(quest.QuestID, progress);
	}
}
