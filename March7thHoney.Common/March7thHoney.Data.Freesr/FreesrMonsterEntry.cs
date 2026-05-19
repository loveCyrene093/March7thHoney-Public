using System.Text.Json.Serialization;

namespace March7thHoney.Data.Freesr;

public sealed class FreesrMonsterEntry
{
	[JsonPropertyName("monster_id")]
	public int MonsterId { get; set; }

	[JsonPropertyName("amount")]
	public int Amount { get; set; }

	[JsonPropertyName("level")]
	public int Level { get; set; }
}
