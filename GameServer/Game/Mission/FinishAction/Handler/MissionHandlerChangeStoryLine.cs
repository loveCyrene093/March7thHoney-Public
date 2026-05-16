using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Player;

namespace March7thHoney.GameServer.Game.Mission.FinishAction.Handler;

[MissionFinishAction(FinishActionTypeEnum.ChangeStoryLine)]
public class MissionHandlerChangeStoryLine : MissionFinishActionHandler
{
	public override async ValueTask OnHandle(List<int> @params, List<string> paramString, PlayerInstance player)
	{
		int num = @params[0];
		int entryId = @params[1];
		int anchorGroupId = @params[2];
		int anchorId = @params[3];
		if (num == 0)
		{
			await player.StoryLineManager.FinishStoryLine(entryId, anchorGroupId, anchorId);
		}
		else
		{
			await player.StoryLineManager.InitStoryLine(num, entryId, anchorGroupId, anchorId);
		}
	}
}
