using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace March7thHoney.Data.Excel;

[ResourceEntity("ChallengePeakConfig.json")]
public class ChallengePeakConfigExcel : ExcelResource
{
	public int ID { get; set; }

	public List<int> TagList { get; set; } = new List<int>();

	public List<int> HPProgressValueList { get; set; } = new List<int>();

	public List<int> ProgressValueList { get; set; } = new List<int>();

	public List<int> EventIDList { get; set; } = new List<int>();

	public List<int> NormalTargetList { get; set; } = new List<int>();

	[JsonIgnore]
	public Dictionary<int, List<ChallengeConfigExcel.ChallengeMonsterInfo>> ChallengeMonsters { get; } = new Dictionary<int, List<ChallengeConfigExcel.ChallengeMonsterInfo>>();

	[JsonIgnore]
	public ChallengePeakBossConfigExcel? BossExcel { get; set; }

	[JsonIgnore]
	public int OverrideMapEntranceId { get; set; }

	[JsonIgnore]
	public int OverrideMazeGroupId { get; set; }

	[JsonIgnore]
	public int OverrideNpcMonsterId { get; set; }

	public override int GetId()
	{
		return ID;
	}

	public override void Loaded()
	{
		GameData.ChallengePeakConfigData.TryAdd(ID, this);
	}

	public override void AfterAllDone()
	{
		RebuildChallengeMonsters();
	}

	public int GetMapEntranceId()
	{
		if (OverrideMapEntranceId <= 0)
		{
			return 0;
		}
		return OverrideMapEntranceId;
	}

	public int GetMazeGroupId()
	{
		if (OverrideMazeGroupId > 0)
		{
			return OverrideMazeGroupId;
		}
		return 0;
	}

	public void RebuildChallengeMonsters()
	{
		int mazeGroupId = GetMazeGroupId();
		ChallengeMonsters.Clear();
		ChallengeMonsters.Add(mazeGroupId, new List<ChallengeConfigExcel.ChallengeMonsterInfo>());
		int num = 200000;
		foreach (int eventID in EventIDList)
		{
			if (GameData.StageConfigData.TryGetValue(eventID, out StageConfigExcel value))
			{
				int key = value.MonsterList.LastOrDefault()?.Monster0 ?? 0;
				if (GameData.MonsterConfigData.TryGetValue(key, out MonsterConfigExcel value2) && GameData.MonsterTemplateConfigData.TryGetValue(value2.MonsterTemplateID, out MonsterTemplateConfigExcel value3))
				{
					int npcMonsterId = ((OverrideNpcMonsterId > 0) ? OverrideNpcMonsterId : value3.NPCMonsterList.Take(2).LastOrDefault(0));
					ChallengeMonsters[mazeGroupId].Add(new ChallengeConfigExcel.ChallengeMonsterInfo(++num, npcMonsterId, eventID));
				}
			}
		}
	}
}
