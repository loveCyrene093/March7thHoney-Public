using System;
using Newtonsoft.Json.Linq;

namespace March7thHoney.Data.Config.Task;

public class RefreshMazeBuffTime : TaskConfigInfo
{
	public TargetEvaluator TargetType { get; set; } = new TargetEvaluator();

	public int ID { get; set; }

	public DynamicFloat LifeTime { get; set; } = new DynamicFloat();

	public new static TaskConfigInfo LoadFromJsonObject(JObject obj)
	{
		RefreshMazeBuffTime refreshMazeBuffTime = new RefreshMazeBuffTime
		{
			Type = obj["Type"].ToObject<string>()
		};
		if (obj.TryGetValue("TargetType", out JToken value))
		{
			JObject jObject = value as JObject;
			Type type = System.Type.GetType("March7thHoney.Data.Config.Task." + jObject?["Type"]?.ToString().Replace("RPG.GameCore.", ""));
			if ((object)type == null)
			{
				type = System.Type.GetType("March7thHoney.Data.Config.Task.TargetEvaluator");
			}
			refreshMazeBuffTime.TargetType = jObject.ToObject(type) as TargetEvaluator;
		}
		if (obj.TryGetValue("ID", out value))
		{
			refreshMazeBuffTime.ID = value.ToObject<int>();
		}
		if (obj.TryGetValue("LifeTime", out value))
		{
			refreshMazeBuffTime.LifeTime = value.ToObject<DynamicFloat>();
		}
		return refreshMazeBuffTime;
	}
}
