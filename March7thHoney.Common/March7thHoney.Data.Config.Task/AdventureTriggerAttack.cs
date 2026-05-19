using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace March7thHoney.Data.Config.Task;

public class AdventureTriggerAttack : TaskConfigInfo
{
	public TargetEvaluator AttackTargetType { get; set; } = new TargetEvaluator();

	public TargetEvaluator AttackRootTargetType { get; set; } = new TargetEvaluator();

	public bool TriggerBattle { get; set; } = true;

	public float TriggerBattleDelay { get; set; }

	public List<TaskConfigInfo> OnAttack { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> OnBattle { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> OnHit { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> OnKill { get; set; } = new List<TaskConfigInfo>();

	public bool IncludeProps { get; set; }

	public bool HitTargetFaceToAttacker { get; set; }

	public bool TriggerBattleByAllHitTarget { get; set; }

	public bool AttackDetectCollision { get; set; }

	public string EnterBattleSelectTargetType { get; set; } = "";

	public new static TaskConfigInfo LoadFromJsonObject(JObject obj)
	{
		AdventureTriggerAttack adventureTriggerAttack = new AdventureTriggerAttack
		{
			Type = obj["Type"].ToObject<string>()
		};
		if (obj.TryGetValue("AttackTargetType", out JToken value))
		{
			JObject jObject = value as JObject;
			Type type = System.Type.GetType("March7thHoney.Data.Config.Task." + jObject?["Type"]?.ToString().Replace("RPG.GameCore.", ""));
			if ((object)type == null)
			{
				type = System.Type.GetType("March7thHoney.Data.Config.Task.TargetEvaluator");
			}
			adventureTriggerAttack.AttackTargetType = jObject.ToObject(type) as TargetEvaluator;
		}
		if (obj.TryGetValue("AttackRootTargetType", out JToken value2))
		{
			JObject jObject2 = value2 as JObject;
			Type type2 = System.Type.GetType("March7thHoney.Data.Config.Task." + jObject2?["Type"]?.ToString().Replace("RPG.GameCore.", ""));
			if ((object)type2 == null)
			{
				type2 = System.Type.GetType("March7thHoney.Data.Config.Task.TargetEvaluator");
			}
			adventureTriggerAttack.AttackRootTargetType = jObject2.ToObject(type2) as TargetEvaluator;
		}
		foreach (TaskConfigInfo item in obj["OnAttack"]?.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)) ?? Array.Empty<TaskConfigInfo>())
		{
			adventureTriggerAttack.OnAttack.Add(item);
		}
		foreach (TaskConfigInfo item2 in obj["OnBattle"]?.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)) ?? Array.Empty<TaskConfigInfo>())
		{
			adventureTriggerAttack.OnBattle.Add(item2);
		}
		foreach (TaskConfigInfo item3 in obj["OnHit"]?.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)) ?? Array.Empty<TaskConfigInfo>())
		{
			adventureTriggerAttack.OnHit.Add(item3);
		}
		foreach (TaskConfigInfo item4 in obj["OnKill"]?.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)) ?? Array.Empty<TaskConfigInfo>())
		{
			adventureTriggerAttack.OnKill.Add(item4);
		}
		if (obj.TryGetValue("TriggerBattle", out value))
		{
			adventureTriggerAttack.TriggerBattle = value.ToObject<bool>();
		}
		if (obj.TryGetValue("TriggerBattleDelay", out value))
		{
			adventureTriggerAttack.TriggerBattleDelay = value.ToObject<float>();
		}
		if (obj.TryGetValue("IncludeProps", out value))
		{
			adventureTriggerAttack.IncludeProps = value.ToObject<bool>();
		}
		if (obj.TryGetValue("HitTargetFaceToAttacker", out value))
		{
			adventureTriggerAttack.HitTargetFaceToAttacker = value.ToObject<bool>();
		}
		if (obj.TryGetValue("TriggerBattleByAllHitTarget", out value))
		{
			adventureTriggerAttack.TriggerBattleByAllHitTarget = value.ToObject<bool>();
		}
		if (obj.TryGetValue("AttackDetectCollision", out value))
		{
			adventureTriggerAttack.AttackDetectCollision = value.ToObject<bool>();
		}
		if (obj.TryGetValue("EnterBattleSelectTargetType", out value))
		{
			adventureTriggerAttack.EnterBattleSelectTargetType = value.ToObject<string>() ?? "";
		}
		return adventureTriggerAttack;
	}
}
