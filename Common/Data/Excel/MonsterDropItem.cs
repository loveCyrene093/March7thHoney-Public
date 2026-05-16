using Newtonsoft.Json;

namespace March7thHoney.Data.Excel;

public class MonsterDropItem
{
	public int ItemID { get; set; }

	[JsonIgnore]
	public int MinCount { get; set; }

	[JsonIgnore]
	public int MaxCount { get; set; }
}
