using System.Collections.Generic;
using SqlSugar;

namespace March7thHoney.Database.Inventory;

[SugarTable("InventoryData")]
public class InventoryData : BaseDatabaseDataHelper
{
	[SugarColumn(IsJson = true)]
	public List<ItemData> MaterialItems { get; set; } = new List<ItemData>();

	[SugarColumn(IsJson = true)]
	public List<ItemData> EquipmentItems { get; set; } = new List<ItemData>();

	[SugarColumn(IsJson = true)]
	public List<ItemData> RelicItems { get; set; } = new List<ItemData>();

	[SugarColumn(IsJson = true)]
	public Dictionary<int, RelicPlanData> RelicPlans { get; set; } = new Dictionary<int, RelicPlanData>();

	public int NextUniqueId { get; set; } = 100;
}
