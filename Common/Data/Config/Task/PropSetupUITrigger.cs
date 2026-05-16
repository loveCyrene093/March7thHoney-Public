using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace March7thHoney.Data.Config.Task;

public class PropSetupUITrigger : TaskConfigInfo
{
	public string ColliderRelativePath { get; set; } = string.Empty;

	public bool DestroyAfterTriggered { get; set; }

	public bool DisableAfterTriggered { get; set; }

	public bool DisableWhenTriggered { get; set; }

	public string ButtonIcon { get; set; } = string.Empty;

	public List<TaskConfigInfo> ButtonCallback { get; set; } = new List<TaskConfigInfo>();

	public bool ForceInteractInDanger { get; set; }

	public bool ConsiderAngleLimit { get; set; }

	public float InteractAngleRange { get; set; }

	public bool TriggerByFakeAvatar { get; set; }

	public bool SkipFakeAvatar { get; set; }

	public PredicateConfigInfo OnEnterFilter { get; set; } = new PredicateConfigInfo();

	public TargetEvaluator TargetType { get; set; } = new TargetEvaluator();

	public new static TaskConfigInfo LoadFromJsonObject(JObject obj)
	{
		PropSetupUITrigger propSetupUITrigger = new PropSetupUITrigger();
		propSetupUITrigger.Type = obj["Type"].ToObject<string>();
		if (obj.ContainsKey("OnEnterFilter"))
		{
			propSetupUITrigger.OnEnterFilter = PredicateConfigInfo.LoadFromJsonObject(obj["OnEnterFilter"] as JObject);
		}
		if (obj.ContainsKey("ButtonCallback"))
		{
			propSetupUITrigger.ButtonCallback = obj["ButtonCallback"]?.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)).ToList() ?? new List<TaskConfigInfo>();
		}
		if (obj.ContainsKey("TargetType"))
		{
			JObject jObject = obj["TargetType"] as JObject;
			Type type = System.Type.GetType("March7thHoney.Data.Config.Task." + jObject?["Type"]?.ToString().Replace("RPG.GameCore.", ""));
			if ((object)type == null)
			{
				type = System.Type.GetType("March7thHoney.Data.Config.Task.TargetEvaluator");
			}
			propSetupUITrigger.TargetType = jObject.ToObject(type) as TargetEvaluator;
		}
		if (propSetupUITrigger.ButtonCallback.Count > 0 && propSetupUITrigger.ButtonCallback[0].Type == "RPG.GameCore.PropStateExecute")
		{
			propSetupUITrigger.Type = obj["Type"].ToObject<string>();
		}
		propSetupUITrigger.ColliderRelativePath = obj["ColliderRelativePath"]?.ToString() ?? string.Empty;
		propSetupUITrigger.DestroyAfterTriggered = obj["DestroyAfterTriggered"]?.ToObject<bool>() ?? false;
		propSetupUITrigger.DisableAfterTriggered = obj["DisableAfterTriggered"]?.ToObject<bool>() ?? false;
		propSetupUITrigger.DisableWhenTriggered = obj["DisableWhenTriggered"]?.ToObject<bool>() ?? false;
		propSetupUITrigger.ButtonIcon = obj["ButtonIcon"]?.ToString() ?? string.Empty;
		propSetupUITrigger.ForceInteractInDanger = obj["ForceInteractInDanger"]?.ToObject<bool>() ?? false;
		propSetupUITrigger.ConsiderAngleLimit = obj["ConsiderAngleLimit"]?.ToObject<bool>() ?? false;
		propSetupUITrigger.InteractAngleRange = obj["InteractAngleRange"]?.ToObject<float>() ?? 0f;
		propSetupUITrigger.TriggerByFakeAvatar = obj["TriggerByFakeAvatar"]?.ToObject<bool>() ?? false;
		propSetupUITrigger.SkipFakeAvatar = obj["SkipFakeAvatar"]?.ToObject<bool>() ?? false;
		return propSetupUITrigger;
	}
}
