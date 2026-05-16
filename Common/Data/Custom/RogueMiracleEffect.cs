using System.Collections.Generic;

namespace March7thHoney.Data.Custom;

public class RogueMiracleEffect
{
	public int MiracleId { get; set; }

	public int MaxDurability { get; set; }

	public Dictionary<int, RogueEffect> Effects { get; set; } = new Dictionary<int, RogueEffect>();
}
