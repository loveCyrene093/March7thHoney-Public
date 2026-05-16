using Newtonsoft.Json;

namespace March7thHoney.Data.Excel;

public class BossAndFloorInfo
{
	[JsonProperty("LKPOGAKCEMO")]
	public int MonsterId { get; set; }
}
