using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum ExtraLineupType
{
	[OriginalName("LINEUP_NONE")]
	LineupNone = 0,
	[OriginalName("LINEUP_CHALLENGE")]
	LineupChallenge = 1,
	[OriginalName("LINEUP_ROGUE")]
	LineupRogue = 2,
	[OriginalName("LINEUP_CHALLENGE_2")]
	LineupChallenge2 = 3,
	[OriginalName("LINEUP_CHALLENGE_3")]
	LineupChallenge3 = 4,
	[OriginalName("LINEUP_ROGUE_CHALLENGE")]
	LineupRogueChallenge = 5,
	[OriginalName("LINEUP_STAGE_TRIAL")]
	LineupStageTrial = 6,
	[OriginalName("LINEUP_ROGUE_TRIAL")]
	LineupRogueTrial = 7,
	[OriginalName("LINEUP_ACTIVITY")]
	LineupActivity = 8,
	[OriginalName("LINEUP_BOXING_CLUB")]
	LineupBoxingClub = 9,
	[OriginalName("LINEUP_TREASURE_DUNGEON")]
	LineupTreasureDungeon = 11,
	[OriginalName("LINEUP_CHESS_ROGUE")]
	LineupChessRogue = 12,
	[OriginalName("LINEUP_HELIOBUS")]
	LineupHeliobus = 13,
	[OriginalName("LINEUP_TOURN_ROGUE")]
	LineupTournRogue = 14,
	[OriginalName("LINEUP_RELIC_ROGUE")]
	LineupRelicRogue = 15,
	[OriginalName("LINEUP_ARCADE_ROGUE")]
	LineupArcadeRogue = 16,
	[OriginalName("LINEUP_MAGIC_ROGUE")]
	LineupMagicRogue = 17,
	[OriginalName("LINEUP_FATE")]
	LineupFate = 18,
	[OriginalName("LINEUP_GRID_FIGHT")]
	LineupGridFight = 19
}
