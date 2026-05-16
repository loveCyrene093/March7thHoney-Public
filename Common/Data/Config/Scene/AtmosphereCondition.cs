using System.Collections.Generic;
using March7thHoney.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Config.Scene;

public class AtmosphereCondition
{
	public List<Dictionary<string, object>> Conditions { get; set; } = new List<Dictionary<string, object>>();

	[JsonConverter(typeof(StringEnumConverter))]
	public OperationEnum Operation { get; set; }
}
