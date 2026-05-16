using System.Collections.Generic;

namespace March7thHoney.Data.Excel;

[ResourceEntity("AdventurePlayer.json,ActivityAdventurePlayer.json", true)]
public class AdventurePlayerExcel : ExcelResource
{
	public int ID { get; set; }

	public int AvatarID { get; set; }

	public List<int> MazeSkillIdList { get; set; } = new List<int>();

	public string PlayerJsonPath { get; set; } = "";

	public override int GetId()
	{
		return ID;
	}

	public override void Loaded()
	{
		GameData.AdventurePlayerData[ID] = this;
	}
}
