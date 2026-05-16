using System.Collections.Generic;
using Newtonsoft.Json;

namespace March7thHoney.Data.Excel;

[ResourceEntity("RogueAreaConfig.json")]
public class RogueAreaConfigExcel : ExcelResource
{
	public int RogueAreaID { get; set; }

	public int AreaProgress { get; set; }

	public int Difficulty { get; set; }

	public int FirstReward { get; set; }

	public Dictionary<int, int> ScoreMap { get; set; } = new Dictionary<int, int>();

	[JsonIgnore]
	public int MapId { get; set; }

	[JsonIgnore]
	public Dictionary<int, RogueMapExcel> RogueMaps { get; set; } = new Dictionary<int, RogueMapExcel>();

	public override int GetId()
	{
		return RogueAreaID;
	}

	public override void Loaded()
	{
		GameData.RogueAreaConfigData.Add(RogueAreaID, this);
		MapId = AreaProgress * 100 + Difficulty;
	}

	public override void AfterAllDone()
	{
		GameData.RogueMapData.TryGetValue(MapId, out Dictionary<int, RogueMapExcel> value);
		if (value != null)
		{
			RogueMaps = value;
		}
	}
}
