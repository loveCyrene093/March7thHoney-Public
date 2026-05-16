using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace March7thHoney.Data.Config.Task;

public class ByAnd : PredicateConfigInfo
{
	public List<PredicateConfigInfo> PredicateList { get; set; } = new List<PredicateConfigInfo>();

	public new static PredicateConfigInfo LoadFromJsonObject(JObject obj)
	{
		ByAnd byAnd = new ByAnd
		{
			Type = obj["Type"].ToObject<string>()
		};
		foreach (PredicateConfigInfo item in obj["PredicateList"]?.Select((JToken x) => PredicateConfigInfo.LoadFromJsonObject(x as JObject)) ?? Array.Empty<PredicateConfigInfo>())
		{
			byAnd.PredicateList.Add(item);
		}
		return byAnd;
	}
}
