namespace March7thHoney.Data.Excel;

[ResourceEntity("DecideAvatarOrder.json")]
public class DecideAvatarOrderExcel : ExcelResource
{
	public int ItemID { get; set; }

	public int Order { get; set; }

	public override int GetId()
	{
		return ItemID;
	}

	public override void Loaded()
	{
		GameData.DecideAvatarOrderData.Add(ItemID, this);
	}
}
