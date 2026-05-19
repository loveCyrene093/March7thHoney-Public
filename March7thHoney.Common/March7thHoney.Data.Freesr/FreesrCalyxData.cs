using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace March7thHoney.Data.Freesr;

public sealed class FreesrCalyxData
{
	[JsonPropertyName("relics")]
	public List<FreesrCalyxRelic>? Relics { get; set; }

	[JsonPropertyName("lightcones")]
	public List<FreesrCalyxLightcone>? Lightcones { get; set; }

	[JsonPropertyName("avatars")]
	public Dictionary<int, FreesrCalyxAvatar>? Avatars { get; set; }

	[JsonPropertyName("battle_config")]
	public FreesrBattleConfig? BattleConfig { get; set; }
}
