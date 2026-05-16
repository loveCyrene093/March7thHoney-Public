using System.Collections.Generic;

namespace March7thHoney.Database.TrainCakeCatch;

public class DiyDiceSlotInfo
{
	public int DiceSlotId { get; set; }

	public int Index { get; set; }

	public List<int> Values { get; set; } = new List<int>();
}
