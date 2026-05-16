using March7thHoney.Enums.Item;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Excel;

[ResourceEntity("EquipmentConfig.json")]
public class EquipmentConfigExcel : ExcelResource
{
	public int EquipmentID { get; set; }

	public bool Release { get; set; }

	public int ExpType { get; set; }

	public int MaxPromotion { get; set; }

	public int MaxRank { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public RarityEnum Rarity { get; set; }

	public override int GetId()
	{
		return EquipmentID;
	}

	public override void Loaded()
	{
		if (Release)
		{
			GameData.EquipmentConfigData.Add(EquipmentID, this);
		}
	}
}
