using Newtonsoft.Json;

namespace March7thHoney.Data.Excel;

[ResourceEntity("RogueMazeBuff.json")]
public class RogueMazeBuffExcel : ExcelResource
{
	[JsonIgnore]
	public string? Name;

	public int ID { get; set; }

	public int Lv { get; set; }

	public int LvMax { get; set; }

	public HashName BuffName { get; set; } = new HashName();

	public override int GetId()
	{
		return ID * 100 + Lv;
	}

	public override void Loaded()
	{
		GameData.RogueMazeBuffData.Add(GetId(), this);
	}
}
