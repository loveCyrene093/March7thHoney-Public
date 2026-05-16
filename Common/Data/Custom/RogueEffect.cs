using System.Collections.Generic;
using March7thHoney.Enums.Rogue;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Custom;

public class RogueEffect
{
	public int EffectId { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public RogueMiracleEffectTypeEnum Type { get; set; }

	public string DynamicKey { get; set; } = "";

	public List<int> Params { get; set; } = new List<int>();
}
