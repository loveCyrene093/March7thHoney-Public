namespace March7thHoney.Data.Excel;

[ResourceEntity("RogueDialogueOptionDisplay.json")]
public class RogueDialogueOptionDisplayExcel : ExcelResource
{
	public int OptionDisplayID { get; set; }

	public HashName OptionTitle { get; set; } = new HashName();

	public HashName OptionDesc { get; set; } = new HashName();

	public override int GetId()
	{
		return OptionDisplayID;
	}

	public override void Loaded()
	{
		GameData.RogueDialogueOptionDisplayData.Add(OptionDisplayID, this);
	}
}
