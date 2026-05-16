using Newtonsoft.Json;

namespace March7thHoney.Data.Excel;

public class StageConfigInfo
{
	[JsonProperty("HEIKKHLKMOA")]
	public string Key { get; set; } = "";

	[JsonProperty("MBMDOCJIMEJ")]
	public string Value { get; set; } = "";
}
