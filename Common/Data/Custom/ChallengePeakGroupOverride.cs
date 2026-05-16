using System.Collections.Generic;
using Newtonsoft.Json;

namespace March7thHoney.Data.Custom;

public class ChallengePeakGroupOverride
{
	[JsonProperty("group_id")]
	public int GroupId { get; set; }

	[JsonProperty("npc_monster_id_default")]
	public int NpcMonsterIdDefault { get; set; }

	[JsonProperty("stages")]
	public Dictionary<string, ChallengePeakStageOverride> Stages { get; set; } = new Dictionary<string, ChallengePeakStageOverride>();
}
