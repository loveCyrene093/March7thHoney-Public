using March7thHoney.Data.Config.Task;
using Newtonsoft.Json.Linq;

namespace March7thHoney.Data.Config.SummonUnit;

public class SummonUnitConfigInfo
{
	public string GroupConfigName { get; set; } = "";

	public string ConfigEntityPath { get; set; } = "";

	public string TickLodTemplateName { get; set; } = "";

	public string ShoesType { get; set; } = "";

	public bool ShowShadow { get; set; }

	public bool ColliderIsTrigger { get; set; }

	public string AttachPoint { get; set; } = "";

	public DynamicFloat Duration { get; set; } = new DynamicFloat();

	public SummonUnitTriggerConfigInfo TriggerConfig { get; set; } = new SummonUnitTriggerConfigInfo();

	public static SummonUnitConfigInfo LoadFromJsonObject(JObject obj)
	{
		SummonUnitConfigInfo summonUnitConfigInfo = new SummonUnitConfigInfo();
		if (obj.TryGetValue("GroupConfigName", out JToken value))
		{
			summonUnitConfigInfo.GroupConfigName = value.ToString();
		}
		if (obj.TryGetValue("ConfigEntityPath", out value))
		{
			summonUnitConfigInfo.ConfigEntityPath = value.ToString();
		}
		if (obj.TryGetValue("TickLodTemplateName", out value))
		{
			summonUnitConfigInfo.TickLodTemplateName = value.ToString();
		}
		if (obj.TryGetValue("ShoesType", out value))
		{
			summonUnitConfigInfo.ShoesType = value.ToString();
		}
		if (obj.TryGetValue("ShowShadow", out value))
		{
			summonUnitConfigInfo.ShowShadow = value.Value<bool>();
		}
		if (obj.TryGetValue("ColliderIsTrigger", out value))
		{
			summonUnitConfigInfo.ColliderIsTrigger = value.Value<bool>();
		}
		if (obj.TryGetValue("AttachPoint", out value))
		{
			summonUnitConfigInfo.AttachPoint = value.ToString();
		}
		if (obj.TryGetValue("Duration", out value))
		{
			summonUnitConfigInfo.Duration = value.ToObject<DynamicFloat>() ?? new DynamicFloat();
		}
		if (obj.TryGetValue("TriggerConfig", out value))
		{
			summonUnitConfigInfo.TriggerConfig = SummonUnitTriggerConfigInfo.LoadFromJsonObject(value as JObject);
		}
		return summonUnitConfigInfo;
	}
}
