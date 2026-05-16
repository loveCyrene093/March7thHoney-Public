using March7thHoney.Enums.Mission;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Excel;

public class StoryLineCondition
{
	[JsonConverter(typeof(StringEnumConverter))]
	public StoryLineConditionTypeEnum Type { get; set; }

	public int Param { get; set; }
}
