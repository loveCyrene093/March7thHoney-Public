using March7thHoney.Enums.Task;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Config.Scene;

public class SavedValueCondition
{
	public string SavedValueName { get; set; } = "";

	public int Value { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public CompareTypeEnum Operation { get; set; }
}
