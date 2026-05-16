namespace March7thHoney.Data.Excel;

[ResourceEntity("GridFightItems.json")]
public class GridFightItemsExcel : ExcelResource
{
	public uint ID { get; set; }

	public HashName ItemName { get; set; } = new HashName();

	public override int GetId()
	{
		return (int)ID;
	}

	public override void Loaded()
	{
		GameData.GridFightItemsData.TryAdd(ID, this);
	}
}
