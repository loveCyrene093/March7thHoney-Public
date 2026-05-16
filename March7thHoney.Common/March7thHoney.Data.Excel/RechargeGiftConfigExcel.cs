using System.Collections.Generic;

namespace March7thHoney.Data.Excel;

[ResourceEntity("RechargeGiftConfig.json")]
public class RechargeGiftConfigExcel : ExcelResource
{
	public int GiftType { get; set; }

	public List<int> GiftIDList { get; set; } = new List<int>();

	public override int GetId()
	{
		return GiftType;
	}

	public override void Loaded()
	{
		GameData.RechargeGiftConfigData.Add(GiftType, this);
	}
}
