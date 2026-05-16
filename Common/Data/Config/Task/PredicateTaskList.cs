using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace March7thHoney.Data.Config.Task;

public class PredicateTaskList : TaskConfigInfo
{
	public PredicateConfigInfo Predicate { get; set; } = new PredicateConfigInfo();

	public List<TaskConfigInfo> SuccessTaskList { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> FailedTaskList { get; set; } = new List<TaskConfigInfo>();

	public new static TaskConfigInfo LoadFromJsonObject(JObject obj)
	{
		PredicateTaskList predicateTaskList = new PredicateTaskList();
		predicateTaskList.Type = obj["Type"].ToObject<string>();
		if (obj.ContainsKey("Predicate"))
		{
			predicateTaskList.Predicate = PredicateConfigInfo.LoadFromJsonObject(obj["Predicate"] as JObject);
		}
		if (obj.ContainsKey("SuccessTaskList"))
		{
			predicateTaskList.SuccessTaskList = obj["SuccessTaskList"]?.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)).ToList() ?? new List<TaskConfigInfo>();
		}
		if (obj.ContainsKey("FailedTaskList"))
		{
			predicateTaskList.FailedTaskList = obj["FailedTaskList"]?.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)).ToList() ?? new List<TaskConfigInfo>();
		}
		return predicateTaskList;
	}
}
