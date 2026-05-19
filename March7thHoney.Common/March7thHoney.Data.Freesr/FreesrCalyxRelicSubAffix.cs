using System.Text.Json.Serialization;

namespace March7thHoney.Data.Freesr;

public sealed class FreesrCalyxRelicSubAffix
{
	[JsonPropertyName("sub_affix_id")]
	public int SubAffixId { get; set; }

	[JsonPropertyName("count")]
	public int Count { get; set; }

	[JsonPropertyName("step")]
	public int Step { get; set; }
}
