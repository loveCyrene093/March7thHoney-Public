using March7thHoney.Enums.Mission;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Config.Scene;

public class Condition
{
	[JsonConverter(typeof(StringEnumConverter))]
	public LevelGroupMissionTypeEnum Type { get; set; }

	public int ID { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public MissionPhaseEnum Phase { get; set; }
}
