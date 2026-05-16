namespace March7thHoney.Data.Excel;

[ResourceEntity("RogueDialogueDynamicDisplay.json")]
public class RogueDialogueDynamicDisplayExcel : ExcelResource
{
	public int DisplayID { get; set; }

	public HashName ContentText { get; set; } = new HashName();

	public override int GetId()
	{
		return DisplayID;
	}

	public override void Loaded()
	{
		GameData.RogueDialogueDynamicDisplayData.Add(DisplayID, this);
	}
}
