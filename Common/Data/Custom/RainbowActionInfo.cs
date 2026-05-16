using System.Collections.Generic;
using March7thHoney.Enums.Scene;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Custom;

public class RainbowActionInfo
{
	[JsonConverter(typeof(StringEnumConverter))]
	public SceneActionTypeEnum ActionType { get; set; }

	public Dictionary<string, object> Params { get; set; } = new Dictionary<string, object>();
}
