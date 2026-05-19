using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace March7thHoney.Data.Freesr;

public sealed class FreesrCalyxAvatar
{
	[JsonPropertyName("avatar_id")]
	public int AvatarId { get; set; }

	[JsonPropertyName("level")]
	public int Level { get; set; }

	[JsonPropertyName("promotion")]
	public int Promotion { get; set; }

	[JsonPropertyName("data")]
	public FreesrCalyxAvatarExtra? Data { get; set; }

	[JsonPropertyName("sp_value")]
	public int? SpValue { get; set; }

	[JsonPropertyName("sp_max")]
	public int? SpMax { get; set; }

	[JsonPropertyName("techniques")]
	public List<int>? Techniques { get; set; }

	[JsonPropertyName("enhanced_id")]
	public int? EnhancedId { get; set; }
}
