namespace March7thHoney.Data.Excel;

public class MappingInfoItem
{
	public int ItemID { get; set; }

	public int ItemNum { get; set; }

	public int MinCount { get; set; }

	public int MaxCount { get; set; }

	public int Chance { get; set; } = 100;

	public MappingInfoItem()
	{
	}

	public MappingInfoItem(int itemId, int itemNum)
	{
		ItemID = itemId;
		ItemNum = itemNum;
	}
}
