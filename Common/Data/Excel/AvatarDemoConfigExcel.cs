using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace March7thHoney.Data.Excel;

[ResourceEntity("AvatarDemoConfig.json")]
public class AvatarDemoConfigExcel : ExcelResource
{
	public class StageMonsterInfo(int ConfigId, int NpcMonsterId, int EventId)
	{
		public int ConfigId = ConfigId;

		public int EventId = EventId;

		public int NpcMonsterId = NpcMonsterId;
	}

	public int StageID { get; set; }

	public int AvatarID { get; set; }

	public int[] TrialAvatarList { get; set; } = Array.Empty<int>();

	public int RewardID { get; set; }

	public int MazeGroupID1 { get; set; }

	public int RaidID { get; set; }

	public int MapEntranceID { get; set; }

	public int[]? ConfigList1 { get; set; } = Array.Empty<int>();

	public int[]? NpcMonsterIDList1 { get; set; } = Array.Empty<int>();

	public int[]? EventIDList1 { get; set; } = Array.Empty<int>();

	public bool EnableMazeSkillEffect { get; set; }

	[JsonIgnore]
	public Dictionary<int, StageMonsterInfo> StageMonsters1 { get; set; } = new Dictionary<int, StageMonsterInfo>();

	public override int GetId()
	{
		return StageID;
	}

	public override void Loaded()
	{
		for (int i = 0; i < ConfigList1?.Length && ConfigList1[i] != 0; i++)
		{
			StageMonsterInfo stageMonsterInfo = new StageMonsterInfo(ConfigList1[i], NpcMonsterIDList1[i], EventIDList1[i]);
			StageMonsters1.Add(stageMonsterInfo.ConfigId, stageMonsterInfo);
		}
		ConfigList1 = null;
		NpcMonsterIDList1 = null;
		EventIDList1 = null;
		GameData.AvatarDemoConfigData.Add(GetId(), this);
	}
}
