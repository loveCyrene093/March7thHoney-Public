using System.Text.Json.Serialization;

namespace March7thHoney.Data.Freesr;

public sealed class FreesrBlessing
{
	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("level")]
	public int Level { get; set; }
}
