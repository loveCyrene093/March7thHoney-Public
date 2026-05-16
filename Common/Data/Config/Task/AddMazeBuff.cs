using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace March7thHoney.Data.Config.Task;

public class AddMazeBuff : TaskConfigInfo
{
	public TargetEvaluator TargetType { get; set; } = new TargetEvaluator();

	public int ID { get; set; }

	public PredicateConfigInfo Condition { get; set; } = new PredicateConfigInfo();

	public TargetEvaluator BindingAffectedTarget { get; set; } = new TargetEvaluator();

	public DynamicFloat LifeTime { get; set; } = new DynamicFloat();

	public DynamicFloat Count { get; set; } = new DynamicFloat();

	public DynamicFloat Level { get; set; } = new DynamicFloat();

	public Dictionary<string, DynamicFloat> DynamicValues { get; set; } = new Dictionary<string, DynamicFloat>();

	public new static TaskConfigInfo LoadFromJsonObject(JObject obj)
	{
		AddMazeBuff addMazeBuff = new AddMazeBuff
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
			addMazeBuff.TargetType = jObject.ToObject(type) as TargetEvaluator;
		}
		if (obj.TryGetValue("ID", out value))
		{
			addMazeBuff.ID = value.ToObject<int>();
		}
		if (obj.TryGetValue("Condition", out value))
		{
			JObject jObject2 = value as JObject;
			Type type2 = System.Type.GetType("March7thHoney.Data.Config.Task." + jObject2?["Type"]?.ToString().Replace("RPG.GameCore.", ""));
			if ((object)type2 == null)
			{
				type2 = System.Type.GetType("March7thHoney.Data.Config.Task.PredicateConfigInfo");
			}
			addMazeBuff.Condition = jObject2.ToObject(type2) as PredicateConfigInfo;
		}
		if (obj.TryGetValue("BindingAffectedTarget", out value))
		{
			JObject jObject3 = value as JObject;
			Type type3 = System.Type.GetType("March7thHoney.Data.Config.Task." + jObject3?["Type"]?.ToString().Replace("RPG.GameCore.", ""));
			if ((object)type3 == null)
			{
				type3 = System.Type.GetType("March7thHoney.Data.Config.Task.TargetEvaluator");
			}
			addMazeBuff.BindingAffectedTarget = jObject3.ToObject(type3) as TargetEvaluator;
		}
		if (obj.TryGetValue("LifeTime", out value))
		{
			addMazeBuff.LifeTime = value.ToObject<DynamicFloat>();
		}
		if (obj.TryGetValue("Count", out value))
		{
			addMazeBuff.Count = value.ToObject<DynamicFloat>();
		}
		if (obj.TryGetValue("Level", out value))
		{
			addMazeBuff.Level = value.ToObject<DynamicFloat>();
		}
		if (!obj.TryGetValue("DynamicValues", out value))
		{
			return addMazeBuff;
		}
		JObject obj2 = value as JObject;
		Dictionary<string, DynamicFloat> dictionary = new Dictionary<string, DynamicFloat>();
		foreach (KeyValuePair<string, JToken> item in obj2)
		{
			item.Deconstruct(out var key, out var value2);
			string key2 = key;
			dictionary[key2] = value2?.ToObject<DynamicFloat>();
		}
		addMazeBuff.DynamicValues = dictionary;
		return addMazeBuff;
	}
}
