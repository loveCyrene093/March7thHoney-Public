using System.Collections.Generic;
using March7thHoney.Enums.GridFight;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Excel;

[ResourceEntity("GridFightAffixConfig.json")]
public class GridFightAffixConfigExcel : ExcelResource
{
	public uint ID { get; set; }

	public List<uint> RuleParamList { get; set; } = new List<uint>();

	[JsonConverter(typeof(StringEnumConverter))]
	public GridFightAffixRuleEnum AffixRule { get; set; }

	public override int GetId()
	{
		return (int)ID;
	}

	public override void Loaded()
	{
		GameData.GridFightAffixConfigData.TryAdd(ID, this);
	}
}
