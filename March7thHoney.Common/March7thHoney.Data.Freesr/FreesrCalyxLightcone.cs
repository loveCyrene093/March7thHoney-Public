using System.Text.Json.Serialization;

namespace March7thHoney.Data.Freesr;

public sealed class FreesrCalyxLightcone
{
	[JsonPropertyName("level")]
	public int Level { get; set; }

	[JsonPropertyName("equip_avatar")]
	public int EquipAvatar { get; set; }

	[JsonPropertyName("item_id")]
	public int ItemId { get; set; }

	[JsonPropertyName("rank")]
	public int Rank { get; set; }

	[JsonPropertyName("promotion")]
	public int Promotion { get; set; }
}
