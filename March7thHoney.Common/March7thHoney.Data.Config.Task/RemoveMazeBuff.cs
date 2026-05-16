using System;
using Newtonsoft.Json.Linq;

namespace March7thHoney.Data.Config.Task;

public class RemoveMazeBuff : TaskConfigInfo
{
	public TargetEvaluator TargetType { get; set; } = new TargetEvaluator();

	public int ID { get; set; }

	public new static TaskConfigInfo LoadFromJsonObject(JObject obj)
	{
		RemoveMazeBuff removeMazeBuff = new RemoveMazeBuff
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
			removeMazeBuff.TargetType = jObject.ToObject(type) as TargetEvaluator;
		}
		if (obj.TryGetValue("ID", out value))
		{
			removeMazeBuff.ID = value.ToObject<int>();
		}
		return removeMazeBuff;
	}
}
