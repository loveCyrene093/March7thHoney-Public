using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Player;

namespace March7thHoney.GameServer.Game.Mission.FinishAction.Handler;

[MissionFinishAction(FinishActionTypeEnum.MoveToAnchor)]
public class MissionHandlerMoveToAnchor : MissionFinishActionHandler
{
	public override async ValueTask OnHandle(List<int> @params, List<string> paramString, PlayerInstance player)
	{
		int entranceId = @params[0];
		int anchorGroupId = @params[1];
		int anchorId = @params[2];
		await player.EnterSceneByEntranceId(entranceId, anchorGroupId, anchorId, sendPacket: true);
	}
}
