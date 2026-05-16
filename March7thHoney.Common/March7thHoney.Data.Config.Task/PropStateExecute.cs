using System;
using System.Collections.Generic;
using System.Linq;
using March7thHoney.Enums.Scene;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace March7thHoney.Data.Config.Task;

public class PropStateExecute : TaskConfigInfo
{
	public TargetEvaluator TargetType { get; set; } = new TargetEvaluator();

	[JsonConverter(typeof(StringEnumConverter))]
	public PropStateEnum State { get; set; }

	public List<TaskConfigInfo> Execute { get; set; } = new List<TaskConfigInfo>();

	public new static TaskConfigInfo LoadFromJsonObject(JObject obj)
	{
		PropStateExecute propStateExecute = new PropStateExecute
		{
			Type = obj["Type"].ToObject<string>()
		};
		if (obj.ContainsKey("TargetType"))
		{
			JObject jObject = obj["TargetType"] as JObject;
			Type type = System.Type.GetType("March7thHoney.Data.Config.Task." + jObject?["Type"]?.ToString().Replace("RPG.GameCore.", ""));
			if ((object)type == null)
			{
				type = System.Type.GetType("March7thHoney.Data.Config.Task.TargetEvaluator");
			}
			propStateExecute.TargetType = jObject.ToObject(type) as TargetEvaluator;
		}
		if (obj.ContainsKey("State"))
		{
			propStateExecute.State = obj["State"]?.ToObject<PropStateEnum>() ?? PropStateEnum.Closed;
		}
		foreach (TaskConfigInfo item in obj["Execute"]?.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)) ?? Array.Empty<TaskConfigInfo>())
		{
			propStateExecute.Execute.Add(item);
		}
		return propStateExecute;
	}
}
