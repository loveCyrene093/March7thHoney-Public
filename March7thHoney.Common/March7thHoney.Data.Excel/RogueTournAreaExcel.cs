using System.Collections.Generic;
using March7thHoney.Enums.TournRogue;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Excel;

[ResourceEntity("RogueTournArea.json")]
public class RogueTournAreaExcel : ExcelResource
{
	public List<int> MonsterDisplayItemList { get; set; } = new List<int>();

	public List<int> LayerIDList { get; set; } = new List<int>();

	public List<int> DifficultyIDList { get; set; } = new List<int>();

	public int WorldLevelLimit { get; set; }

	public int FirstReward { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public RogueTournDifficultyTypeEnum Difficulty { get; set; }

	public int ExpScoreID { get; set; }

	public int UnlockID { get; set; }

	public int AreaID { get; set; }

	public int DivisionLevel { get; set; }

	public HashName AreaNameID { get; set; } = new HashName();

	public bool IsHard { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public RogueTournModeEnum TournMode { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public RogueTournAreaGroupIDEnum AreaGroupID { get; set; }

	public override int GetId()
	{
		return AreaID;
	}

	public override void Loaded()
	{
		GameData.RogueTournAreaData.TryAdd(AreaID, this);
	}
}
