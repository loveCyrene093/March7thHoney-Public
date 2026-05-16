using System.Collections.Generic;

namespace March7thHoney.Data.Excel;

[ResourceEntity("ItemComposeConfig.json")]
public class ItemComposeConfigExcel : ExcelResource
{
	public int ID { get; set; }

	public int ItemID { get; set; }

	public int CoinCost { get; set; }

	public List<MaterialItem> MaterialCost { get; set; } = new List<MaterialItem>();

	public override int GetId()
	{
		return ID;
	}

	public override void Loaded()
	{
		GameData.ItemComposeConfigData[ID] = this;
	}
}
