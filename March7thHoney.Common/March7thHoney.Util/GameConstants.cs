using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace March7thHoney.Util;

public static class GameConstants
{
	public const string GAME_VERSION = "4.2.0";

	public const string AvatarDbVersion = "20250430";

	public const int GameVersionInt = 3200;

	public const int MAX_STAMINA = 300;

	public const int MAX_STAMINA_RESERVE = 2400;

	public const int STAMINA_RECOVERY_TIME = 360;

	public const int STAMINA_RESERVE_RECOVERY_TIME = 1080;

	public const int INVENTORY_MAX_EQUIPMENT = 1500;

	public const int INVENTORY_MAX_RELIC = 1500;

	public const int INVENTORY_MAX_MATERIAL = 2000;

	public const int MAX_LINEUP_COUNT = 9;

	public const int LAST_TRAIN_WORLD_ID = 501;

	public const int AMBUSH_BUFF_ID = 1000102;

	public const int CHALLENGE_ENTRANCE = 100000103;

	public const int CHALLENGE_PEAK_ENTRANCE = 100000352;

	public const int CHALLENGE_STORY_ENTRANCE = 102020107;

	public const int CHALLENGE_BOSS_ENTRANCE = 1030402;

	public const int CURRENT_ROGUE_TOURN_SEASON = 2;

	public const uint CHALLENGE_PEAK_BRONZE_FRAME_ID = 226001u;

	public const uint CHALLENGE_PEAK_SILVER_FRAME_ID = 226002u;

	public const uint CHALLENGE_PEAK_GOLD_FRAME_ID = 226003u;

	public const uint CHALLENGE_PEAK_ULTRA_FRAME_ID = 226004u;

	public const uint CHALLENGE_PEAK_CUR_GROUP_ID = 1u;

	public static Dictionary<uint, List<uint>> CHALLENGE_PEAK_TARGET_ENTRY_ID;

	public static readonly List<int> UpgradeWorldLevel;

	public static readonly List<int> AllowedChessRogueEntranceId;

	static GameConstants()
	{
		Dictionary<uint, List<uint>> dictionary = new Dictionary<uint, List<uint>>();
		int num = 2;
		List<uint> list = new List<uint>(num);
		CollectionsMarshal.SetCount(list, num);
		Span<uint> span = CollectionsMarshal.AsSpan(list);
		span[0] = 3013501u;
		span[1] = 8u;
		dictionary.Add(1u, list);
		CHALLENGE_PEAK_TARGET_ENTRY_ID = dictionary;
		num = 6;
		List<int> list2 = new List<int>(num);
		CollectionsMarshal.SetCount(list2, num);
		Span<int> span2 = CollectionsMarshal.AsSpan(list2);
		span2[0] = 20;
		span2[1] = 30;
		span2[2] = 40;
		span2[3] = 50;
		span2[4] = 60;
		span2[5] = 65;
		UpgradeWorldLevel = list2;
		num = 4;
		List<int> list3 = new List<int>(num);
		CollectionsMarshal.SetCount(list3, num);
		Span<int> span3 = CollectionsMarshal.AsSpan(list3);
		span3[0] = 8020701;
		span3[1] = 8020901;
		span3[2] = 8020401;
		span3[3] = 8020201;
		AllowedChessRogueEntranceId = list3;
	}
}
