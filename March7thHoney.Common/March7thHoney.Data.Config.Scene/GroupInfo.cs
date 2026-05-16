using System.Collections.Generic;
using March7thHoney.Data.Config.Task;
using March7thHoney.Enums.Scene;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace March7thHoney.Data.Config.Scene;

public class GroupInfo
{
	public int Id;

	[JsonConverter(typeof(StringEnumConverter))]
	public GroupLoadSideEnum LoadSide { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public GroupCategoryEnum Category { get; set; }

	public LevelGroupSystemUnlockCondition? SystemUnlockCondition { get; set; }

	public string LevelGraph { get; set; } = "";

	public bool LoadOnInitial { get; set; }

	public string GroupName { get; set; } = "";

	public SavedValueLoadCondition SavedValueCondition { get; set; } = new SavedValueLoadCondition();

	public AtmosphereCondition AtmosphereCondition { get; set; } = new AtmosphereCondition();

	public LoadCondition LoadCondition { get; set; } = new LoadCondition();

	public LoadCondition UnloadCondition { get; set; } = new LoadCondition();

	public LoadCondition ForceUnloadCondition { get; set; } = new LoadCondition();

	[JsonConverter(typeof(StringEnumConverter))]
	public SaveTypeEnum SaveType { get; set; }

	public int OwnerMainMissionID { get; set; }

	public List<AnchorInfo> AnchorList { get; set; } = new List<AnchorInfo>();

	public List<MonsterInfo> MonsterList { get; set; } = new List<MonsterInfo>();

	public List<PropInfo> PropList { get; set; } = new List<PropInfo>();

	public List<NpcInfo> NPCList { get; set; } = new List<NpcInfo>();

	public Dictionary<int, GroupPropertyConfigInfo> GroupPropertyMap { get; set; } = new Dictionary<int, GroupPropertyConfigInfo>();

	public ValueSourceInfo? ValueSource { get; set; }

	[JsonIgnore]
	public LevelGraphConfigInfo? LevelGraphConfig { get; set; }

	[JsonIgnore]
	public Dictionary<string, List<int>> PropTriggerCustomString { get; set; } = new Dictionary<string, List<int>>();

	[JsonIgnore]
	public List<string> ControlFloorSavedValue { get; set; } = new List<string>();

	[JsonIgnore]
	public List<int> RelatedBattleId { get; set; } = new List<int>();

	[JsonIgnore]
	public List<int> RelatedMissionId { get; set; } = new List<int>();

	public void Load()
	{
		foreach (PropInfo prop in PropList)
		{
			prop.Load(this);
		}
		foreach (JObject item2 in ValueSource?.Values ?? new List<JObject>())
		{
			if (item2["Key"]?.ToString() == "FSV")
			{
				JToken jToken = item2["Value"];
				if (jToken != null)
				{
					ControlFloorSavedValue.Add(jToken.ToString());
				}
			}
		}
		foreach (LevelInitSequeceConfigInfo item3 in LevelGraphConfig?.OnInitSequece ?? new List<LevelInitSequeceConfigInfo>())
		{
			foreach (TaskConfigInfo task in item3.TaskList)
			{
				if (task is TriggerBattle triggerBattle && triggerBattle.EventID.GetValue() > 0)
				{
					RelatedBattleId.Add(triggerBattle.EventID.GetValue());
				}
			}
		}
		foreach (LevelStartSequeceConfigInfo item4 in LevelGraphConfig?.OnStartSequece ?? new List<LevelStartSequeceConfigInfo>())
		{
			foreach (TaskConfigInfo task2 in item4.TaskList)
			{
				if (task2 is TriggerBattle triggerBattle2 && triggerBattle2.EventID.GetValue() > 0)
				{
					RelatedBattleId.Add(triggerBattle2.EventID.GetValue());
				}
			}
		}
		if (LoadSide != GroupLoadSideEnum.Client)
		{
			return;
		}
		foreach (Dictionary<string, object> condition in AtmosphereCondition.Conditions)
		{
			if (condition.TryGetValue("SubMissionID", out var value) && value is long num)
			{
				int item = (int)num;
				RelatedMissionId.Add(item);
			}
		}
	}
}
