using System.Collections.Generic;

namespace March7thHoney.Data.Excel;

[ResourceEntity("RogueTournLayerRoom.json")]
public class RogueTournLayerRoomExcel : ExcelResource
{
	public int LayerID { get; set; }

	public int RoomIndex { get; set; }

	public Dictionary<int, int> Door1 { get; set; } = new Dictionary<int, int>();

	public Dictionary<int, int> Door2 { get; set; } = new Dictionary<int, int>();

	public Dictionary<int, int> Door3 { get; set; } = new Dictionary<int, int>();

	public override int GetId()
	{
		return LayerID;
	}

	public override void Loaded()
	{
		GameData.RogueTournLayerRoomData.TryAdd(LayerID, new Dictionary<int, RogueTournLayerRoomExcel>());
		GameData.RogueTournLayerRoomData[LayerID][RoomIndex] = this;
	}
}
