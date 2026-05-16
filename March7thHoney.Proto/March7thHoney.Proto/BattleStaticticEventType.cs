using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum BattleStaticticEventType
{
	[OriginalName("BATTLE_STATICTIC_EVENT_NONE")]
	BattleStaticticEventNone,
	[OriginalName("BATTLE_STATICTIC_EVENT_TREASURE_DUNGEON_ADD_EXPLORE")]
	BattleStaticticEventTreasureDungeonAddExplore,
	[OriginalName("BATTLE_STATICTIC_EVENT_TREASURE_DUNGEON_OPEN_GRID")]
	BattleStaticticEventTreasureDungeonOpenGrid,
	[OriginalName("BATTLE_STATICTIC_EVENT_TREASURE_DUNGEON_PICKUP_ITEM")]
	BattleStaticticEventTreasureDungeonPickupItem,
	[OriginalName("BATTLE_STATICTIC_EVENT_TREASURE_DUNGEON_USE_BUFF")]
	BattleStaticticEventTreasureDungeonUseBuff,
	[OriginalName("BATTLE_STATICTIC_EVENT_TELEVISION_ACTIVITY_UPDATE_MAZE_BUFF_LAYER")]
	BattleStaticticEventTelevisionActivityUpdateMazeBuffLayer,
	[OriginalName("BATTLE_STATICTIC_EVENT_ROGUE_TOURN_TITAN_EXTRA_COIN")]
	BattleStaticticEventRogueTournTitanExtraCoin,
	[OriginalName("BATTLE_STATICTIC_EVENT_ROGUE_TOURN_TITAN_EXTRA_COIN_TIMES")]
	BattleStaticticEventRogueTournTitanExtraCoinTimes
}
