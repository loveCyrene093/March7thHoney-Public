using System.Collections.Generic;
using March7thHoney.Enums.Rogue;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Custom;

public class RogueDialogueEventConditionData
{
	[JsonConverter(typeof(StringEnumConverter))]
	public RogueEventConditionTypeEnum Name { get; set; }

	public Dictionary<string, object> Param { get; set; } = new Dictionary<string, object>();
}
