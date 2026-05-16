using System.Collections.Generic;
using System.Linq;
using March7thHoney.Data.Config.Task;
using Newtonsoft.Json.Linq;

namespace March7thHoney.Data.Config.SummonUnit;

public class UnitCustomTriggerConfigInfo
{
	public string TriggerName { get; set; } = "";

	public bool DefaultEnable { get; set; }

	public DynamicFloat Radius { get; set; } = new DynamicFloat();

	public bool UseVerticalBound { get; set; }

	public float UpperBound { get; set; }

	public float LowerBound { get; set; }

	public bool NeedRaycast { get; set; }

	public float RayStartOffsetY { get; set; }

	public bool ForceSyncTargetToSever { get; set; }

	public bool DependOnServerTarget { get; set; }

	public bool IsSingle { get; set; }

	public DynamicFloat TargetGroupID { get; set; } = new DynamicFloat();

	public DynamicFloat TargetID { get; set; } = new DynamicFloat();

	public string ColliderRelativePath { get; set; } = "";

	public bool DestroyAfterTriggered { get; set; }

	public bool DisableAfterTriggered { get; set; }

	public List<TaskConfigInfo> OnTriggerEnable { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> OnTriggerDisable { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> OnTriggerEnter { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> OnTriggerExit { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> OnTriggerEnterRollback { get; set; } = new List<TaskConfigInfo>();

	public bool BlockDialogueInRange { get; set; }

	public bool DestroyAfterGraphEnd { get; set; }

	public bool TriggerByFakeAvatar { get; set; }

	public bool SkipFakeAvatar { get; set; }

	public static UnitCustomTriggerConfigInfo LoadFromJsonObject(JObject obj)
	{
		UnitCustomTriggerConfigInfo unitCustomTriggerConfigInfo = new UnitCustomTriggerConfigInfo();
		if (obj.TryGetValue("TriggerName", out JToken value))
		{
			unitCustomTriggerConfigInfo.TriggerName = value.ToString();
		}
		if (obj.TryGetValue("DefaultEnable", out value))
		{
			unitCustomTriggerConfigInfo.DefaultEnable = value.Value<bool>();
		}
		if (obj.TryGetValue("Radius", out value))
		{
			unitCustomTriggerConfigInfo.Radius = value.ToObject<DynamicFloat>() ?? new DynamicFloat();
		}
		if (obj.TryGetValue("UseVerticalBound", out value))
		{
			unitCustomTriggerConfigInfo.UseVerticalBound = value.Value<bool>();
		}
		if (obj.TryGetValue("UpperBound", out value))
		{
			unitCustomTriggerConfigInfo.UpperBound = value.Value<float>();
		}
		if (obj.TryGetValue("LowerBound", out value))
		{
			unitCustomTriggerConfigInfo.LowerBound = value.Value<float>();
		}
		if (obj.TryGetValue("NeedRaycast", out value))
		{
			unitCustomTriggerConfigInfo.NeedRaycast = value.Value<bool>();
		}
		if (obj.TryGetValue("RayStartOffsetY", out value))
		{
			unitCustomTriggerConfigInfo.RayStartOffsetY = value.Value<float>();
		}
		if (obj.TryGetValue("ForceSyncTargetToSever", out value))
		{
			unitCustomTriggerConfigInfo.ForceSyncTargetToSever = value.Value<bool>();
		}
		if (obj.TryGetValue("DependOnServerTarget", out value))
		{
			unitCustomTriggerConfigInfo.DependOnServerTarget = value.Value<bool>();
		}
		if (obj.TryGetValue("IsSingle", out value))
		{
			unitCustomTriggerConfigInfo.IsSingle = value.Value<bool>();
		}
		if (obj.TryGetValue("TargetGroupID", out value))
		{
			unitCustomTriggerConfigInfo.TargetGroupID = value.ToObject<DynamicFloat>() ?? new DynamicFloat();
		}
		if (obj.TryGetValue("TargetID", out value))
		{
			unitCustomTriggerConfigInfo.TargetID = value.ToObject<DynamicFloat>() ?? new DynamicFloat();
		}
		if (obj.TryGetValue("ColliderRelativePath", out value))
		{
			unitCustomTriggerConfigInfo.ColliderRelativePath = value.ToString();
		}
		if (obj.TryGetValue("DestroyAfterTriggered", out value))
		{
			unitCustomTriggerConfigInfo.DestroyAfterTriggered = value.Value<bool>();
		}
		if (obj.TryGetValue("DisableAfterTriggered", out value))
		{
			unitCustomTriggerConfigInfo.DisableAfterTriggered = value.Value<bool>();
		}
		if (obj.TryGetValue("OnTriggerEnable", out value))
		{
			unitCustomTriggerConfigInfo.OnTriggerEnable = value.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)).ToList();
		}
		if (obj.TryGetValue("OnTriggerDisable", out value))
		{
			unitCustomTriggerConfigInfo.OnTriggerDisable = value.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)).ToList();
		}
		if (obj.TryGetValue("OnTriggerEnter", out value))
		{
			unitCustomTriggerConfigInfo.OnTriggerEnter = value.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)).ToList();
		}
		if (obj.TryGetValue("OnTriggerExit", out value))
		{
			unitCustomTriggerConfigInfo.OnTriggerExit = value.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)).ToList();
		}
		if (obj.TryGetValue("OnTriggerEnterRollback", out value))
		{
			unitCustomTriggerConfigInfo.OnTriggerEnterRollback = value.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)).ToList();
		}
		if (obj.TryGetValue("BlockDialogueInRange", out value))
		{
			unitCustomTriggerConfigInfo.BlockDialogueInRange = value.Value<bool>();
		}
		if (obj.TryGetValue("DestroyAfterGraphEnd", out value))
		{
			unitCustomTriggerConfigInfo.DestroyAfterGraphEnd = value.Value<bool>();
		}
		if (obj.TryGetValue("TriggerByFakeAvatar", out value))
		{
			unitCustomTriggerConfigInfo.TriggerByFakeAvatar = value.Value<bool>();
		}
		if (obj.TryGetValue("SkipFakeAvatar", out value))
		{
			unitCustomTriggerConfigInfo.SkipFakeAvatar = value.Value<bool>();
		}
		return unitCustomTriggerConfigInfo;
	}
}
