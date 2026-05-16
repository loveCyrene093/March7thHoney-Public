using System.Collections.Generic;

namespace March7thHoney.Data.Excel;

[ResourceEntity("RogueMap.json")]
public class RogueMapExcel : ExcelResource
{
	public int RogueMapID { get; set; }

	public int SiteID { get; set; }

	public bool IsStart { get; set; }

	public double PosX { get; set; }

	public double PosY { get; set; }

	public List<int> NextSiteIDList { get; set; } = new List<int>();

	public List<int> LevelList { get; set; } = new List<int>();

	public override int GetId()
	{
		return RogueMapID * 1000 + SiteID;
	}

	public override void Loaded()
	{
		if (GameData.RogueMapData.TryGetValue(RogueMapID, out Dictionary<int, RogueMapExcel> value))
		{
			value.Add(SiteID, this);
			return;
		}
		GameData.RogueMapData.Add(RogueMapID, new Dictionary<int, RogueMapExcel> { { SiteID, this } });
	}
}
