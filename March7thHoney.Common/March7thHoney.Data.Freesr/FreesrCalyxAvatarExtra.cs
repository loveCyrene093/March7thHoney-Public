using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace March7thHoney.Data.Freesr;

public sealed class FreesrCalyxAvatarExtra
{
	[JsonPropertyName("rank")]
	public int Rank { get; set; }

	[JsonPropertyName("skills")]
	public Dictionary<int, int>? Skills { get; set; }
}
