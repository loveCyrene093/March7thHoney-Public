using System;
using Newtonsoft.Json.Linq;

namespace March7thHoney.Data.Config.Task;

public class ByIsContainAdventureModifier : PredicateConfigInfo
{
	public TargetEvaluator TargetType { get; set; } = new TargetEvaluator();

	public string ModifierName { get; set; } = "";

	public new static PredicateConfigInfo LoadFromJsonObject(JObject obj)
	{
		ByIsContainAdventureModifier byIsContainAdventureModifier = new ByIsContainAdventureModifier
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
			byIsContainAdventureModifier.TargetType = jObject.ToObject(type) as TargetEvaluator;
		}
		if (obj.TryGetValue("ModifierName", out value))
		{
			byIsContainAdventureModifier.ModifierName = value.ToObject<string>();
		}
		return byIsContainAdventureModifier;
	}
}
