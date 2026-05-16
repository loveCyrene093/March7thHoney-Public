using System.Collections.Generic;
using March7thHoney.Enums.Rogue;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Custom;

public class ChessRogueDiceSurfaceContentEffect
{
	[JsonConverter(typeof(StringEnumConverter))]
	public ModifierEffectTypeEnum EffectType { get; set; }

	public Dictionary<string, string> Params { get; set; } = new Dictionary<string, string>();
}
