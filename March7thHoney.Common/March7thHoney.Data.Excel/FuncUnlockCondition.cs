using March7thHoney.Enums.Quest;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Excel;

public class FuncUnlockCondition
{
	[JsonConverter(typeof(StringEnumConverter))]
	public ConditionTypeEnum Type { get; set; }

	public string Param { get; set; } = string.Empty;
}
