using March7thHoney.Enums.Server;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Custom;

public class PacketActionData
{
	[JsonConverter(typeof(StringEnumConverter))]
	public PacketActionTypeEnum Action { get; set; }

	public PacketActionParamData Param { get; set; } = new PacketActionParamData();
}
