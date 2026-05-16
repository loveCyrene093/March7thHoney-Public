namespace March7thHoney.Data.Excel;

[ResourceEntity("CakeConfig.json")]
public class CakeConfigExcel : ExcelResource
{
	public int ID { get; set; }

	public int NPCID { get; set; }

	public override int GetId()
	{
		return ID;
	}

	public override void Loaded()
	{
		GameData.CakeConfigData[ID] = this;
	}
}
