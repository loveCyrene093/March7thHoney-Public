using System.Collections.Generic;

namespace March7thHoney.Data.Excel;

[ResourceEntity("RogueDLCBossBp.json")]
public class RogueDLCBossBpExcel : ExcelResource
{
	public int BossBpID { get; set; }

	public List<BossAndFloorInfo> MonsterAndFloorList { get; set; } = new List<BossAndFloorInfo>();

	public List<int> BossDecayList { get; set; } = new List<int>();

	public override int GetId()
	{
		return BossBpID;
	}

	public override void Loaded()
	{
		GameData.RogueDLCBossBpData.Add(BossBpID, this);
	}
}
