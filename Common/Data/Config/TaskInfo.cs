using System.Collections.Generic;
using March7thHoney.Enums.Avatar;
using Newtonsoft.Json;

namespace March7thHoney.Data.Config;

public class TaskInfo
{
	public string Type { get; set; } = "";

	public int ID { get; set; }

	public int SummonUnitID { get; set; }

	public bool TriggerBattle { get; set; }

	public SummonUnitInfo SummonUnit { get; set; } = new SummonUnitInfo();

	public List<TaskInfo> OnAttack { get; set; } = new List<TaskInfo>();

	public List<TaskInfo> OnBattle { get; set; } = new List<TaskInfo>();

	public List<TaskInfo> SuccessTaskList { get; set; } = new List<TaskInfo>();

	public List<TaskInfo> OnProjectileHit { get; set; } = new List<TaskInfo>();

	public List<TaskInfo> OnProjectileLifetimeFinish { get; set; } = new List<TaskInfo>();

	public LifeTimeInfo LifeTime { get; set; } = new LifeTimeInfo();

	[JsonIgnore]
	public TaskTypeEnum TaskType { get; set; }

	public void Loaded()
	{
		foreach (TaskInfo item in OnAttack)
		{
			item.Loaded();
		}
		foreach (TaskInfo item2 in OnBattle)
		{
			item2.Loaded();
		}
		foreach (TaskInfo successTask in SuccessTaskList)
		{
			successTask.Loaded();
		}
		foreach (TaskInfo item3 in OnProjectileHit)
		{
			item3.Loaded();
		}
		foreach (TaskInfo item4 in OnProjectileLifetimeFinish)
		{
			item4.Loaded();
		}
		if (Type.Contains("AddMazeBuff"))
		{
			TaskType = TaskTypeEnum.AddMazeBuff;
		}
		else if (Type.Contains("RemoveMazeBuff"))
		{
			TaskType = TaskTypeEnum.RemoveMazeBuff;
		}
		else if (Type.Contains("AdventureModifyTeamPlayerHP"))
		{
			TaskType = TaskTypeEnum.AdventureModifyTeamPlayerHP;
		}
		else if (Type.Contains("AdventureModifyTeamPlayerSP"))
		{
			TaskType = TaskTypeEnum.AdventureModifyTeamPlayerSP;
		}
		else if (Type.Contains("CreateSummonUnit"))
		{
			TaskType = TaskTypeEnum.CreateSummonUnit;
		}
		else if (Type.Contains("DestroySummonUnit"))
		{
			TaskType = TaskTypeEnum.DestroySummonUnit;
		}
		else if (Type.Contains("AdventureSetAttackTargetMonsterDie"))
		{
			TaskType = TaskTypeEnum.AdventureSetAttackTargetMonsterDie;
		}
		else if (SuccessTaskList.Count > 0)
		{
			TaskType = TaskTypeEnum.SuccessTaskList;
		}
		else if (Type.Contains("AdventureTriggerAttack"))
		{
			TaskType = TaskTypeEnum.AdventureTriggerAttack;
		}
		else if (Type.Contains("AdventureFireProjectile"))
		{
			TaskType = TaskTypeEnum.AdventureFireProjectile;
		}
	}

	public int GetID()
	{
		if (ID <= 0)
		{
			return SummonUnitID;
		}
		return ID;
	}

	public List<TaskInfo> GetAttackInfo()
	{
		List<TaskInfo> list = new List<TaskInfo>();
		list.AddRange(OnAttack);
		list.AddRange(OnBattle);
		return list;
	}
}
