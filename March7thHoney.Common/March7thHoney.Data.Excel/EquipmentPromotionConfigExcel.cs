using System.Collections.Generic;

namespace March7thHoney.Data.Excel;

[ResourceEntity("EquipmentPromotionConfig.json")]
public class EquipmentPromotionConfigExcel : ExcelResource
{
	public class ItemParam
	{
		public int ItemID;

		public int ItemNum;
	}

	public int EquipmentID { get; set; }

	public int Promotion { get; set; }

	public int MaxLevel { get; set; }

	public int WorldLevelRequire { get; set; }

	public List<ItemParam> PromotionCostList { get; set; } = new List<ItemParam>();

	public override int GetId()
	{
		return EquipmentID * 10 + Promotion;
	}

	public override void Loaded()
	{
		GameData.EquipmentPromotionConfigData.Add(GetId(), this);
	}
}
