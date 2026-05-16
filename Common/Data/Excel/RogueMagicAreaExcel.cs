using System.Collections.Generic;
using March7thHoney.Enums.RogueMagic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Excel;

[ResourceEntity("RogueMagicArea.json")]
public class RogueMagicAreaExcel : ExcelResource
{
	public int AreaID { get; set; }

	public int ExtraLayerID { get; set; }

	public List<int> LayerIDList { get; set; } = new List<int>();

	public List<int> DifficultyIDList { get; set; } = new List<int>();

	public int FirstReward { get; set; }

	public int AreaIndex { get; set; }

	public int UnlockID { get; set; }

	public bool IsHard { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public RogueMagicAreaGroupIDEnum AreaGroupID { get; set; }

	public override int GetId()
	{
		return AreaID;
	}

	public override void Loaded()
	{
		GameData.RogueMagicAreaData.Add(AreaID, this);
	}
}
