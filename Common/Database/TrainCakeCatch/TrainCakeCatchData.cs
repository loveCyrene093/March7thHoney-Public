using System.Collections.Generic;
using SqlSugar;

namespace March7thHoney.Database.TrainCakeCatch;

[SugarTable("TrainCakeCatch")]
public class TrainCakeCatchData : BaseDatabaseDataHelper
{
	[SugarColumn(IsJson = true)]
	public List<CakeTreeSlotInfo> CatTreeSlots { get; set; } = new List<CakeTreeSlotInfo>();

	[SugarColumn(IsJson = true)]
	public List<DiyDiceSlotInfo> DiceSlots { get; set; } = new List<DiyDiceSlotInfo>();

	[SugarColumn(IsJson = true)]
	public List<DiyStagePlacement> StagePlacements { get; set; } = new List<DiyStagePlacement>();

	public int DiyTheme { get; set; }

	[SugarColumn(IsJson = true)]
	public List<int> PerformanceIds { get; set; } = new List<int>();
}
