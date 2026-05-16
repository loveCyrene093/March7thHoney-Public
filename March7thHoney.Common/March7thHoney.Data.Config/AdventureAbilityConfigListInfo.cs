using System.Collections.Generic;
using System.Linq;
using March7thHoney.Data.Config.AdventureAbility;
using Newtonsoft.Json.Linq;

namespace March7thHoney.Data.Config;

public class AdventureAbilityConfigListInfo
{
	public List<AdventureAbilityConfigInfo> AbilityList { get; set; } = new List<AdventureAbilityConfigInfo>();

	public Dictionary<string, AdventureModifierConfig>? GlobalModifiers { get; set; } = new Dictionary<string, AdventureModifierConfig>();

	public static AdventureAbilityConfigListInfo LoadFromJsonObject(JObject obj)
	{
		AdventureAbilityConfigListInfo adventureAbilityConfigListInfo = new AdventureAbilityConfigListInfo();
		if (obj.ContainsKey("AbilityList"))
		{
			adventureAbilityConfigListInfo.AbilityList = obj["AbilityList"]?.Select((JToken x) => AdventureAbilityConfigInfo.LoadFromJsonObject(x as JObject)).ToList() ?? new List<AdventureAbilityConfigInfo>();
		}
		if (!obj.ContainsKey("GlobalModifiers"))
		{
			return adventureAbilityConfigListInfo;
		}
		adventureAbilityConfigListInfo.GlobalModifiers = new Dictionary<string, AdventureModifierConfig>();
		foreach (KeyValuePair<string, JObject> item in obj["GlobalModifiers"].ToObject<Dictionary<string, JObject>>())
		{
			adventureAbilityConfigListInfo.GlobalModifiers.Add(item.Key, AdventureModifierConfig.LoadFromJObject(item.Value));
		}
		return adventureAbilityConfigListInfo;
	}
}
