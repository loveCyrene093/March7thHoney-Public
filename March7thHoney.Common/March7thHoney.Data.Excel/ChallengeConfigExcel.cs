using System.Collections.Generic;
using Newtonsoft.Json;

namespace March7thHoney.Data.Excel;

[ResourceEntity("ChallengeMazeConfig.json,ChallengeStoryMazeConfig.json,ChallengeBossMazeConfig.json", true)]
public class ChallengeConfigExcel : ExcelResource
{
	public class ChallengeMonsterInfo
	{
		public int ConfigId;

		public int EventId;

		public int NpcMonsterId;

		[JsonConstructor]
		public ChallengeMonsterInfo(int configId, int npcMonsterId, int eventId)
		{
			ConfigId = configId;
			EventId = eventId;
			NpcMonsterId = npcMonsterId;
			base._002Ector();
		}
	}

	[JsonIgnore]
	public ChallengeBossExtraExcel? BossExcel;

	[JsonIgnore]
	public ChallengeStoryExtraExcel? StoryExcel;

	public int ID { get; set; }

	public int GroupID { get; set; }

	public int MapEntranceID { get; set; }

	public int MapEntranceID2 { get; set; }

	public int StageNum { get; set; }

	public int ChallengeCountDown { get; set; }

	public int MazeBuffID { get; set; }

	public uint Floor { get; set; }

	public List<int>? ChallengeTargetID { get; set; } = new List<int>();

	public int MazeGroupID1 { get; set; }

	public List<int>? ConfigList1 { get; set; } = new List<int>();

	public List<int>? NpcMonsterIDList1 { get; set; } = new List<int>();

	public List<int>? EventIDList1 { get; set; } = new List<int>();

	public int MazeGroupID2 { get; set; }

	public List<int>? ConfigList2 { get; set; } = new List<int>();

	public List<int>? NpcMonsterIDList2 { get; set; } = new List<int>();

	public List<int>? EventIDList2 { get; set; } = new List<int>();

	[JsonIgnore]
	public Dictionary<int, List<ChallengeMonsterInfo>> ChallengeMonsters1 { get; set; } = new Dictionary<int, List<ChallengeMonsterInfo>>();

	[JsonIgnore]
	public Dictionary<int, List<ChallengeMonsterInfo>> ChallengeMonsters2 { get; set; } = new Dictionary<int, List<ChallengeMonsterInfo>>();

	public override int GetId()
	{
		return ID;
	}

	public bool IsStory()
	{
		return StoryExcel != null;
	}

	public bool IsBoss()
	{
		return BossExcel != null;
	}

	public void SetStoryExcel(ChallengeStoryExtraExcel storyExcel)
	{
		StoryExcel = storyExcel;
		ChallengeCountDown = (int)storyExcel.TurnLimit;
	}

	public void SetBossExcel(ChallengeBossExtraExcel bossExcel)
	{
		BossExcel = bossExcel;
	}

	public override void Loaded()
	{
		for (int i = 0; i < ConfigList1?.Count && ConfigList1[i] != 0; i++)
		{
			ChallengeMonsterInfo item = new ChallengeMonsterInfo(ConfigList1[i], NpcMonsterIDList1[i], EventIDList1[i]);
			ChallengeMonsters1.TryAdd(MazeGroupID1, new List<ChallengeMonsterInfo>());
			ChallengeMonsters1[MazeGroupID1].Add(item);
		}
		for (int j = 0; j < ConfigList2?.Count && ConfigList2[j] != 0; j++)
		{
			ChallengeMonsterInfo item2 = new ChallengeMonsterInfo(ConfigList2[j], NpcMonsterIDList2[j], EventIDList2[j]);
			ChallengeMonsters2.TryAdd(MazeGroupID2, new List<ChallengeMonsterInfo>());
			ChallengeMonsters2[MazeGroupID2].Add(item2);
		}
		ConfigList1 = null;
		NpcMonsterIDList1 = null;
		EventIDList1 = null;
		ConfigList2 = null;
		NpcMonsterIDList2 = null;
		EventIDList2 = null;
		GameData.ChallengeConfigData[ID] = this;
	}
}
