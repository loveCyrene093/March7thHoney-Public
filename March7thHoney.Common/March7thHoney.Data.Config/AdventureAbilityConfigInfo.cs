using System.Collections.Generic;
using System.Linq;
using March7thHoney.Data.Config.Task;
using Newtonsoft.Json.Linq;

namespace March7thHoney.Data.Config;

public class AdventureAbilityConfigInfo
{
	public List<TaskConfigInfo> OnAbort { get; set; } = new List<TaskConfigInfo>();

	public string Name { get; set; } = "";

	public List<TaskConfigInfo> OnAdd { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> OnRemove { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> OnStart { get; set; } = new List<TaskConfigInfo>();

	public static AdventureAbilityConfigInfo LoadFromJsonObject(JObject obj)
	{
		AdventureAbilityConfigInfo adventureAbilityConfigInfo = new AdventureAbilityConfigInfo();
		if (obj.ContainsKey("OnAbort"))
		{
			adventureAbilityConfigInfo.OnAbort = obj["OnAbort"]?.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)).ToList() ?? new List<TaskConfigInfo>();
		}
		if (obj.ContainsKey("Name"))
		{
			adventureAbilityConfigInfo.Name = obj["Name"]?.ToObject<string>() ?? "";
		}
		if (obj.ContainsKey("OnAdd"))
		{
			adventureAbilityConfigInfo.OnAdd = obj["OnAdd"]?.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)).ToList() ?? new List<TaskConfigInfo>();
		}
		if (obj.ContainsKey("OnRemove"))
		{
			adventureAbilityConfigInfo.OnRemove = obj["OnRemove"]?.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)).ToList() ?? new List<TaskConfigInfo>();
		}
		if (obj.ContainsKey("OnStart"))
		{
			adventureAbilityConfigInfo.OnStart = obj["OnStart"]?.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)).ToList() ?? new List<TaskConfigInfo>();
		}
		return adventureAbilityConfigInfo;
	}
}
