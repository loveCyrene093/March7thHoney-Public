using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace March7thHoney.Data.Config.AdventureAbility;

public class AdventureModifierLookupTableConfig
{
	public Dictionary<string, AdventureModifierConfig> ModifierMap { get; set; } = new Dictionary<string, AdventureModifierConfig>();

	public static AdventureModifierLookupTableConfig LoadFromJObject(JObject obj)
	{
		AdventureModifierLookupTableConfig adventureModifierLookupTableConfig = new AdventureModifierLookupTableConfig();
		if (!obj.ContainsKey("ModifierMap"))
		{
			return adventureModifierLookupTableConfig;
		}
		foreach (KeyValuePair<string, JObject> item in obj["ModifierMap"].ToObject<Dictionary<string, JObject>>())
		{
			adventureModifierLookupTableConfig.ModifierMap.Add(item.Key, AdventureModifierConfig.LoadFromJObject(item.Value));
		}
		return adventureModifierLookupTableConfig;
	}
}
