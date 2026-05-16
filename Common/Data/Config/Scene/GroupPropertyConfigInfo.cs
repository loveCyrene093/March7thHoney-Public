using March7thHoney.Enums.Scene;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Config.Scene;

public class GroupPropertyConfigInfo
{
	public int ID { get; set; }

	public string Name { get; set; } = "";

	[JsonConverter(typeof(StringEnumConverter))]
	public GroupPropertySideEnum Side { get; set; }

	public short DefaultValue { get; set; }

	public short MaxValue { get; set; }

	public short MinValue { get; set; }
}
