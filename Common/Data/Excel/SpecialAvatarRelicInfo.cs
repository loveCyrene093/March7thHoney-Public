using Newtonsoft.Json;

namespace March7thHoney.Data.Excel;

public class SpecialAvatarRelicInfo
{
	[JsonProperty("BDHIKPAMCJF")]
	public int RelicID { get; set; }

	[JsonProperty("PKAFFFBFJII")]
	public int RelicLevel { get; set; }
}
