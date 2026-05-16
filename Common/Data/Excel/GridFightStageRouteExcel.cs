using System.Collections.Generic;
using March7thHoney.Enums.GridFight;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Excel;

[ResourceEntity("GridFightStageRoute.json")]
public class GridFightStageRouteExcel : ExcelResource
{
	public uint SectionID { get; set; }

	public uint ChapterID { get; set; }

	public uint ID { get; set; }

	public uint StageID { get; set; }

	public uint IsAugment { get; set; }

	public uint NodeTemplateID { get; set; }

	public uint BasicGoldRewardNum { get; set; }

	public List<uint> PenaltyBonusRuleIDList { get; set; } = new List<uint>();

	[JsonConverter(typeof(StringEnumConverter))]
	public GridFightNodeTypeEnum NodeType { get; set; }

	public override int GetId()
	{
		return (int)ID;
	}

	public override void Loaded()
	{
		GameData.GridFightStageRouteData.TryAdd(ID, new Dictionary<uint, GridFightStageRouteExcel>());
		GameData.GridFightStageRouteData[ID][(ChapterID << 8) | SectionID] = this;
	}
}
