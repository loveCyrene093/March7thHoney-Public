using System.Collections.Generic;

namespace March7thHoney.Data.Excel;

[ResourceEntity("RogueDLCDifficulty.json")]
public class RogueDLCDifficultyExcel : ExcelResource
{
	public int DifficultyID { get; set; }

	public List<int> DifficultyCutList { get; set; } = new List<int>();

	public List<int> DifficultyLevelGroup { get; set; } = new List<int>();

	public List<int> LevelList { get; set; } = new List<int>();

	public override int GetId()
	{
		return DifficultyID;
	}

	public override void Loaded()
	{
		GameData.RogueDLCDifficultyData.Add(GetId(), this);
	}
}
