namespace March7thHoney.Data.Excel;

[ResourceEntity("AvatarExpItemConfig.json")]
public class AvatarExpItemConfigExcel : ExcelResource
{
	public int ItemID { get; set; }

	public int Exp { get; set; }

	public override int GetId()
	{
		return ItemID;
	}

	public override void Loaded()
	{
		if (Exp > 0)
		{
			GameData.AvatarExpItemConfigData.Add(GetId(), this);
		}
	}

	public override void AfterAllDone()
	{
		GameData.ItemConfigData.TryGetValue(ItemID, out ItemConfigExcel value);
		if (value != null)
		{
			value.Exp = Exp;
		}
	}
}
