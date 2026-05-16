using System.Collections.Generic;
using Newtonsoft.Json;

namespace March7thHoney.Data.Custom;

public class ChallengePeakOverrideConfig
{
	[JsonProperty("ChallengePeak")]
	public List<ChallengePeakGroupOverride> ChallengePeak { get; set; } = new List<ChallengePeakGroupOverride>();

	[JsonProperty("challenge_peak")]
	private List<ChallengePeakGroupOverride> ChallengePeakSnake
	{
		set
		{
			ChallengePeak = value ?? new List<ChallengePeakGroupOverride>();
		}
	}
}
