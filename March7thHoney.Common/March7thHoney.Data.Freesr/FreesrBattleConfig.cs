using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace March7thHoney.Data.Freesr;

public sealed class FreesrBattleConfig
{
	[JsonPropertyName("battle_type")]
	public string? BattleType { get; set; }

	[JsonPropertyName("cycle_count")]
	public int CycleCount { get; set; }

	[JsonPropertyName("stage_id")]
	public int StageId { get; set; }

	[JsonPropertyName("path_resonance_id")]
	public int PathResonanceId { get; set; }

	[JsonPropertyName("monsters")]
	public List<List<FreesrMonsterEntry>>? Monsters { get; set; }

	[JsonPropertyName("blessings")]
	public List<FreesrBlessing>? Blessings { get; set; }
}
