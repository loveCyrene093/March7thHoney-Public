using System.Collections.Generic;
using March7thHoney.Enums.Rogue;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Config;

public class RogueChestModifierEvent
{
	[JsonConverter(typeof(StringEnumConverter))]
	public ModifierTriggerTypeEnum TriggerType { get; set; }

	public List<int> TriggerParamList { get; set; } = new List<int>();

	[JsonConverter(typeof(StringEnumConverter))]
	public ModifierEffectTypeEnum EffectType { get; set; }

	public List<int> EffectParamList { get; set; } = new List<int>();

	public List<int> EffectParam2List { get; set; } = new List<int>();

	public float Weight { get; set; }
}
