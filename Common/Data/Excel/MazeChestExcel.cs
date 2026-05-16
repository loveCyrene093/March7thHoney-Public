using System.Collections.Generic;
using March7thHoney.Enums.Scene;
using March7thHoney.Util;
using Newtonsoft.Json;

namespace March7thHoney.Data.Excel;

[ResourceEntity("MazeChest.json")]
public class MazeChestExcel : ExcelResource
{
	public int WorldID { get; set; }

	public int ID { get; set; }

	[JsonConverter(typeof(SafeEnumListConverter<ChestTypeEnum>))]
	public List<ChestTypeEnum> ChestType { get; set; } = new List<ChestTypeEnum>();

	public override int GetId()
	{
		return ID;
	}

	public override void Loaded()
	{
		GameData.MazeChestData.Add(ID, this);
	}
}
