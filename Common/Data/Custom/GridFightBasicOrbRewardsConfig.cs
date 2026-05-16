using System.Collections.Generic;

namespace March7thHoney.Data.Custom;

public class GridFightBasicOrbRewardsConfig
{
	public Dictionary<uint, GridFightBasicOrbRewardsInfo> OrbRewards { get; set; } = new Dictionary<uint, GridFightBasicOrbRewardsInfo>();
}
