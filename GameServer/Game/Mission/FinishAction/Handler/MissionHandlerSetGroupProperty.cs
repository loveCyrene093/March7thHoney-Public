using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Player;

namespace March7thHoney.GameServer.Game.Mission.FinishAction.Handler;

[MissionFinishAction(FinishActionTypeEnum.SetGroupProperty)]
public class MissionHandlerSetGroupProperty : MissionFinishActionHandler
{
	public override async ValueTask OnHandle(List<int> @params, List<string> paramString, PlayerInstance player)
	{
		string text = paramString[0];
		string text2 = paramString[1];
		string text3 = paramString[2];
		if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(text2) && !string.IsNullOrEmpty(text3))
		{
			await player.SceneInstance.UpdateGroupProperty(int.Parse(text), text2, int.Parse(text3));
		}
	}
}
