using System.Collections.Generic;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Scene;

public class PacketUpdateFloorSavedValueNotify : BasePacket
{
	public PacketUpdateFloorSavedValueNotify(string name, int savedValue, PlayerInstance player)
		: base(1415)
	{
		UpdateFloorSavedValueNotify updateFloorSavedValueNotify = new UpdateFloorSavedValueNotify
		{
			FloorId = (uint)player.SceneInstance.FloorId,
			PlaneId = (uint)player.SceneInstance.PlaneId,
			DimensionId = (uint)player.SceneInstance.ResolveDimensionId()
		};
		updateFloorSavedValueNotify.SavedValue.Add(name, savedValue);
		SetData(updateFloorSavedValueNotify);
	}

	public PacketUpdateFloorSavedValueNotify(Dictionary<string, int> update, PlayerInstance player)
		: base(1415)
	{
		UpdateFloorSavedValueNotify updateFloorSavedValueNotify = new UpdateFloorSavedValueNotify
		{
			FloorId = (uint)player.SceneInstance.FloorId,
			PlaneId = (uint)player.SceneInstance.PlaneId,
			DimensionId = (uint)player.SceneInstance.ResolveDimensionId()
		};
		foreach (KeyValuePair<string, int> item in update)
		{
			updateFloorSavedValueNotify.SavedValue.Add(item.Key, item.Value);
		}
		SetData(updateFloorSavedValueNotify);
	}
}
