using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace March7thHoney.Data.Config.SummonUnit;

public class SummonUnitTriggerConfigInfo
{
	public List<UnitCustomTriggerConfigInfo> CustomTriggers { get; set; } = new List<UnitCustomTriggerConfigInfo>();

	public static SummonUnitTriggerConfigInfo LoadFromJsonObject(JObject obj)
	{
		SummonUnitTriggerConfigInfo summonUnitTriggerConfigInfo = new SummonUnitTriggerConfigInfo();
		if (obj.ContainsKey("CustomTriggers"))
		{
			summonUnitTriggerConfigInfo.CustomTriggers = obj["CustomTriggers"]?.Select((JToken x) => UnitCustomTriggerConfigInfo.LoadFromJsonObject(x as JObject)).ToList() ?? new List<UnitCustomTriggerConfigInfo>();
		}
		return summonUnitTriggerConfigInfo;
	}
}
