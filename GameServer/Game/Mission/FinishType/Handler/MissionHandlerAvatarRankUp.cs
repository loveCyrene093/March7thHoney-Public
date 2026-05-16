using System.Threading.Tasks;
using March7thHoney.Data.Config;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Avatar;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Player;

namespace March7thHoney.GameServer.Game.Mission.FinishType.Handler;

[MissionFinishType(MissionFinishTypeEnum.AvatarRankUp)]
public class MissionHandlerAvatarRankUp : MissionFinishTypeHandler
{
	public override async ValueTask HandleMissionFinishType(PlayerInstance player, SubMissionInfo info, object? arg)
	{
		await ValueTask.CompletedTask;
	}

	public override async ValueTask HandleQuestFinishType(PlayerInstance player, QuestDataExcel quest, FinishWayExcel excel, object? arg)
	{
		foreach (int paramInt in excel.ParamIntList)
		{
			FormalAvatarInfo formalAvatarInfo = player.AvatarManager?.GetFormalAvatar(paramInt);
			if (formalAvatarInfo != null)
			{
				PathInfo? pathInfo = formalAvatarInfo.GetPathInfo(paramInt);
				if (pathInfo != null && pathInfo.Rank > 0)
				{
					await player.QuestManager.AddQuestProgress(quest.QuestID, 1);
				}
			}
		}
	}
}
