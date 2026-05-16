namespace March7thHoney.Data.Excel;

[ResourceEntity("RogueTalkNameConfig.json")]
public class RogueTalkNameConfigExcel : ExcelResource
{
	public int TalkNameID { get; set; }

	public HashName Name { get; set; } = new HashName();

	public override int GetId()
	{
		return TalkNameID;
	}

	public override void Loaded()
	{
		GameData.RogueTalkNameConfigData.Add(TalkNameID, this);
	}
}
