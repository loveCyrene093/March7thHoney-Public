using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Scene;

namespace March7thHoney.GameServer.Game.Mission.FinishAction.Handler;

[MissionFinishAction(FinishActionTypeEnum.SetFloorSavedValue)]
public class MissionHandlerSetFloorSavedValue : MissionFinishActionHandler
{
	public override async ValueTask OnHandle(List<int> @params, List<string> paramString, PlayerInstance player)
	{
		int.TryParse(paramString[0], out var plane);
		int.TryParse(paramString[1], out var floor);
		player.SceneData.FloorSavedData.TryGetValue(floor, out Dictionary<string, int> value);
		if (value == null)
		{
			value = new Dictionary<string, int>();
			player.SceneData.FloorSavedData[floor] = value;
		}
		value[paramString[2]] = int.Parse(paramString[3]);
		await player.SendPacket(new PacketUpdateFloorSavedValueNotify(paramString[2], int.Parse(paramString[3]), player));
		player.TaskManager?.SceneTaskTrigger.TriggerFloor(plane, floor);
	}
}
