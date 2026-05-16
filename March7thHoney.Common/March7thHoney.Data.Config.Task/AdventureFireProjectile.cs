using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace March7thHoney.Data.Config.Task;

public class AdventureFireProjectile : TaskConfigInfo
{
	public TargetEvaluator TargetType { get; set; } = new TargetEvaluator();

	public List<TaskConfigInfo> OnProjectileHit { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> OnProjectileLifetimeFinish { get; set; } = new List<TaskConfigInfo>();

	public bool WaitProjectileFinish { get; set; }

	public string MutexName { get; set; } = "";

	public new static TaskConfigInfo LoadFromJsonObject(JObject obj)
	{
		AdventureFireProjectile adventureFireProjectile = new AdventureFireProjectile
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
			adventureFireProjectile.TargetType = jObject.ToObject(type) as TargetEvaluator;
		}
		foreach (TaskConfigInfo item in obj["OnProjectileHit"]?.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)) ?? Array.Empty<TaskConfigInfo>())
		{
			adventureFireProjectile.OnProjectileHit.Add(item);
		}
		foreach (TaskConfigInfo item2 in obj["OnProjectileLifetimeFinish"]?.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)) ?? Array.Empty<TaskConfigInfo>())
		{
			adventureFireProjectile.OnProjectileLifetimeFinish.Add(item2);
		}
		if (obj.TryGetValue("WaitProjectileFinish", out value))
		{
			adventureFireProjectile.WaitProjectileFinish = value.ToObject<bool>();
		}
		if (obj.TryGetValue("MutexName", out value))
		{
			adventureFireProjectile.MutexName = value.ToObject<string>();
		}
		return adventureFireProjectile;
	}
}
