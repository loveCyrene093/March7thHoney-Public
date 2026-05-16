using Newtonsoft.Json;

namespace March7thHoney.Data.Excel;

public class LockMagicUnitInfo
{
	[JsonProperty("GHFHMJLCIEC")]
	public int MagicUnitId { get; set; }

	[JsonProperty("LDEDAMNEIJO")]
	public int MagicUnitLevel { get; set; }
}
