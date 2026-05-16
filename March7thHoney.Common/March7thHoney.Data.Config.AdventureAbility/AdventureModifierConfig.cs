using System.Collections.Generic;
using System.Linq;
using March7thHoney.Data.Config.Task;
using Newtonsoft.Json.Linq;

namespace March7thHoney.Data.Config.AdventureAbility;

public class AdventureModifierConfig
{
	public float LifeTime { get; set; }

	public int Level { get; set; }

	public int LevelMax { get; set; }

	public bool IsCountDownAfterBattle { get; set; }

	public bool ApplyBehaviorFlagBindEffects { get; set; }

	public float TickInterval { get; set; }

	public List<TaskConfigInfo> OnInterval { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> OnAdd { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> OnCreate { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> OnDestroy { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> OnStack { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> OnAttack { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> OnBeforeBattle { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> OnAfterBattle { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> OnStage { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> OnUnstage { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> OnForeGround { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> OnBackGround { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> OnStageByStory { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> OnNpcMonsterCreate { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> OnTeamLeaderChange { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> OnBeforeAttack { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> OnBeAttack { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> OnModifierAdd { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> OnModifierRemove { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> OnOwnerBeKilled { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> OnAfterLocalPlayerUseSkill { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> ModifierTaskList { get; set; } = new List<TaskConfigInfo>();

	public List<TaskConfigInfo> OnCounterAttack { get; set; } = new List<TaskConfigInfo>();

	public int Priority { get; set; }

	public int Count { get; set; }

	public static AdventureModifierConfig LoadFromJObject(JObject obj)
	{
		AdventureModifierConfig adventureModifierConfig = new AdventureModifierConfig();
		if (obj.ContainsKey("Level"))
		{
			adventureModifierConfig.Level = obj["Level"].ToObject<int>();
		}
		if (obj.ContainsKey("LevelMax"))
		{
			adventureModifierConfig.LevelMax = obj["LevelMax"].ToObject<int>();
		}
		if (obj.ContainsKey("LifeTime"))
		{
			adventureModifierConfig.LifeTime = obj["LifeTime"].ToObject<float>();
		}
		if (obj.ContainsKey("Count"))
		{
			adventureModifierConfig.Count = obj["Count"].ToObject<int>();
		}
		if (obj.ContainsKey("TickInterval"))
		{
			adventureModifierConfig.TickInterval = obj["TickInterval"].ToObject<float>();
		}
		if (obj.ContainsKey("IsCountDownAfterBattle"))
		{
			adventureModifierConfig.IsCountDownAfterBattle = obj["IsCountDownAfterBattle"].ToObject<bool>();
		}
		if (obj.ContainsKey("ApplyBehaviorFlagBindEffects"))
		{
			adventureModifierConfig.ApplyBehaviorFlagBindEffects = obj["ApplyBehaviorFlagBindEffects"].ToObject<bool>();
		}
		if (obj.ContainsKey("OnInterval"))
		{
			adventureModifierConfig.OnInterval = obj["OnInterval"]?.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)).ToList() ?? new List<TaskConfigInfo>();
		}
		if (obj.ContainsKey("OnAdd"))
		{
			adventureModifierConfig.OnAdd = obj["OnAdd"]?.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)).ToList() ?? new List<TaskConfigInfo>();
		}
		if (obj.ContainsKey("OnCreate"))
		{
			adventureModifierConfig.OnCreate = obj["OnCreate"]?.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)).ToList() ?? new List<TaskConfigInfo>();
		}
		if (obj.ContainsKey("OnDestroy"))
		{
			adventureModifierConfig.OnDestroy = obj["OnDestroy"]?.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)).ToList() ?? new List<TaskConfigInfo>();
		}
		if (obj.ContainsKey("OnStack"))
		{
			adventureModifierConfig.OnStack = obj["OnStack"]?.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)).ToList() ?? new List<TaskConfigInfo>();
		}
		if (obj.ContainsKey("OnAttack"))
		{
			adventureModifierConfig.OnAttack = obj["OnAttack"]?.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)).ToList() ?? new List<TaskConfigInfo>();
		}
		if (obj.ContainsKey("OnBeforeBattle"))
		{
			adventureModifierConfig.OnBeforeBattle = obj["OnBeforeBattle"]?.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)).ToList() ?? new List<TaskConfigInfo>();
		}
		if (obj.ContainsKey("OnAfterBattle"))
		{
			adventureModifierConfig.OnAfterBattle = obj["OnAfterBattle"]?.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)).ToList() ?? new List<TaskConfigInfo>();
		}
		if (obj.ContainsKey("OnStage"))
		{
			adventureModifierConfig.OnStage = obj["OnStage"]?.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)).ToList() ?? new List<TaskConfigInfo>();
		}
		if (obj.ContainsKey("OnUnstage"))
		{
			adventureModifierConfig.OnUnstage = obj["OnUnstage"]?.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)).ToList() ?? new List<TaskConfigInfo>();
		}
		if (obj.ContainsKey("OnForeGround"))
		{
			adventureModifierConfig.OnForeGround = obj["OnForeGround"]?.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)).ToList() ?? new List<TaskConfigInfo>();
		}
		if (obj.ContainsKey("OnBackGround"))
		{
			adventureModifierConfig.OnBackGround = obj["OnBackGround"]?.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)).ToList() ?? new List<TaskConfigInfo>();
		}
		if (obj.ContainsKey("OnAfterLocalPlayerUseSkill"))
		{
			adventureModifierConfig.OnAfterLocalPlayerUseSkill = obj["OnAfterLocalPlayerUseSkill"]?.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)).ToList() ?? new List<TaskConfigInfo>();
		}
		if (obj.ContainsKey("OnTeamLeaderChange"))
		{
			adventureModifierConfig.OnTeamLeaderChange = obj["OnTeamLeaderChange"]?.Select((JToken x) => TaskConfigInfo.LoadFromJsonObject(x as JObject)).ToList() ?? new List<TaskConfigInfo>();
		}
		return adventureModifierConfig;
	}
}
