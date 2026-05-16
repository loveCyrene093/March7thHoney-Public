using Newtonsoft.Json;

namespace March7thHoney.Data.Custom;

public class ChallengePeakStageOverride
{
	[JsonProperty("npc_monster_id")]
	public int NpcMonsterId { get; set; }

	[JsonProperty("map_entrance_id")]
	public int MapEntranceId { get; set; }

	[JsonProperty("maze_group_id")]
	public int MazeGroupId { get; set; }
}
