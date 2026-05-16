using System.Collections.Generic;
using March7thHoney.Enums.Rogue;
using March7thHoney.Enums.TournRogue;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Excel;

[ResourceEntity("RogueTournTitanBless.json")]
public class RogueTournTitanBlessExcel : ExcelResource
{
	public int TitanBlessID { get; set; }

	public int MazeBuffID { get; set; }

	public int TitanBlessLevel { get; set; }

	public int BlessRatio { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public RogueTitanTypeEnum TitanType { get; set; }

	[JsonProperty(ItemConverterType = typeof(StringEnumConverter))]
	public List<RogueTitanCategoryEnum> BlessBattleDisplayCategoryList { get; set; } = new List<RogueTitanCategoryEnum>();

	public override int GetId()
	{
		return TitanBlessID;
	}

	public override void Loaded()
	{
		GameData.RogueTournTitanBlessData.Add(TitanBlessID, this);
	}

	public object ToResultProto(RogueCommonActionResultSourceType select)
	{
		return new
		{
			Source = (int)select,
			TitanBlessID = TitanBlessID
		};
	}
}
