using System.Collections.Generic;

namespace March7thHoney.Data.Excel;

[ResourceEntity("RogueMonsterGroup.json")]
public class RogueMonsterGroupExcel : ExcelResource
{
	public Dictionary<string, double> RogueMonsterListAndWeight { get; set; } = new Dictionary<string, double>();

	public int RogueMonsterGroupID { get; set; }

	public int EliteGroup { get; set; }

	public override int GetId()
	{
		return RogueMonsterGroupID;
	}

	public override void Loaded()
	{
		GameData.RogueMonsterGroupData.Add(GetId(), this);
	}
}
