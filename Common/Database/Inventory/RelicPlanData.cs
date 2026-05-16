using System.Collections.Generic;

namespace March7thHoney.Database.Inventory;

public class RelicPlanData
{
	public int EquipAvatar { get; set; }

	public List<int> InsideRelic { get; set; } = new List<int>();

	public List<int> OutsideRelic { get; set; } = new List<int>();
}
