using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace March7thHoney.Data.Freesr;

public sealed class FreesrCalyxRelic
{
	[JsonPropertyName("level")]
	public int Level { get; set; }

	[JsonPropertyName("relic_id")]
	public int RelicId { get; set; }

	[JsonPropertyName("main_affix_id")]
	public int MainAffixId { get; set; }

	[JsonPropertyName("equip_avatar")]
	public int EquipAvatar { get; set; }

	[JsonPropertyName("sub_affixes")]
	public List<FreesrCalyxRelicSubAffix>? SubAffixes { get; set; }
}
