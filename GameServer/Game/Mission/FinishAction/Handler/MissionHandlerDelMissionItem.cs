using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Player;

namespace March7thHoney.GameServer.Game.Mission.FinishAction.Handler;

[MissionFinishAction(FinishActionTypeEnum.delMissionItem)]
public class MissionHandlerDelMissionItem : MissionFinishActionHandler
{
	public override async ValueTask OnHandle(List<int> @params, List<string> paramString, PlayerInstance player)
	{
		if (@params.Count >= 2)
		{
			for (int i = 0; i < @params.Count; i += 2)
			{
				int itemId = @params[i];
				int count = @params[i + 1];
				await player.InventoryManager.RemoveItem(itemId, count);
			}
		}
	}
}
