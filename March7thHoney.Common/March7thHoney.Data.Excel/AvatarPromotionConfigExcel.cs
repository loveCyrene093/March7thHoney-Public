using System.Collections.Generic;

namespace March7thHoney.Data.Excel;

[ResourceEntity("AvatarPromotionConfig.json,AvatarPromotionConfigLD.json", true)]
public class AvatarPromotionConfigExcel : ExcelResource
{
	public class ItemParam
	{
		public int ItemID;

		public int ItemNum;
	}

	public int AvatarID { get; set; }

	public int Promotion { get; set; }

	public int MaxLevel { get; set; }

	public int PlayerLevelRequire { get; set; }

	public int WorldLevelRequire { get; set; }

	public List<ItemParam> PromotionCostList { get; set; } = new List<ItemParam>();

	public override int GetId()
	{
		return AvatarID * 10 + Promotion;
	}

	public override void Loaded()
	{
		GameData.AvatarPromotionConfigData.TryAdd(GetId(), this);
	}
}
