using System.Collections.Generic;
using System.Linq;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Proto;

namespace March7thHoney.Database.Inventory;

public class OfferingTypeData
{
	public OfferingState State { get; set; } = OfferingState.Open;

	public int CurExp { get; set; }

	public int OfferingId { get; set; }

	public int Level { get; set; }

	public List<int> TakenReward { get; set; } = new List<int>();

	public OfferingInfo ToProto()
	{
		int totalExp = CurExp + (from level in Enumerable.Range(1, Level)
			select GameData.OfferingLevelConfigData.GetValueOrDefault(OfferingId)?.GetValueOrDefault(level)).OfType<OfferingLevelConfigExcel>().Sum((OfferingLevelConfigExcel config) => config.ItemCost);
		return new OfferingInfo
		{
			OfferingState = State,
			HasTakenRewardIdList = { TakenReward.Select((int x) => (uint)x) },
			LevelExp = (uint)CurExp,
			OfferingId = (uint)OfferingId,
			OfferingLevel = (uint)Level,
			TotalExp = (uint)totalExp
		};
	}
}
