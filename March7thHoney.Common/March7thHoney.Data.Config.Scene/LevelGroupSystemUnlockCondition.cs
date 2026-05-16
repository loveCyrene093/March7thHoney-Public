using System.Collections.Generic;
using March7thHoney.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Config.Scene;

public class LevelGroupSystemUnlockCondition
{
	public List<int> Conditions { get; set; } = new List<int>();

	[JsonConverter(typeof(StringEnumConverter))]
	public OperationEnum Operation { get; set; }
}
