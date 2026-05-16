namespace March7thHoney.Data.Excel;

[ResourceEntity("RogueNousDifficultyLevel.json")]
public class RogueNousDifficultyLevelExcel : ExcelResource
{
	public int DifficultyID { get; set; }

	public override int GetId()
	{
		return DifficultyID;
	}

	public override void Loaded()
	{
		GameData.RogueNousDifficultyLevelData[DifficultyID] = this;
	}
}
