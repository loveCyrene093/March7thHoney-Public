using System.Collections.Generic;

namespace March7thHoney.Data.Excel;

[ResourceEntity("RogueTournDifficulty.json")]
public class RogueTournDifficultyExcel : ExcelResource
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
		GameData.RogueTournDifficultyData.Add(GetId(), this);
	}
}
