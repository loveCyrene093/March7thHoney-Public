using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum VirtualItemType
{
	[OriginalName("VIRTUAL_ITEM_NONE")]
	VirtualItemNone = 0,
	[OriginalName("VIRTUAL_ITEM_HCOIN")]
	VirtualItemHcoin = 1,
	[OriginalName("VIRTUAL_ITEM_SCOIN")]
	VirtualItemScoin = 2,
	[OriginalName("VIRTUAL_ITEM_MCOIN")]
	VirtualItemMcoin = 3,
	[OriginalName("VIRTUAL_ITEM_STAMINA")]
	VirtualItemStamina = 11,
	[OriginalName("VIRTUAL_ITEM_RESERVE_STAMINA")]
	VirtualItemReserveStamina = 12,
	[OriginalName("VIRTUAL_ITEM_AVATAR_EXP")]
	VirtualItemAvatarExp = 21,
	[OriginalName("VIRTUAL_ITEM_EXP")]
	VirtualItemExp = 22,
	[OriginalName("VIRTUAL_ITEM_DAILY_ACTIVE_POINT")]
	VirtualItemDailyActivePoint = 23,
	[OriginalName("VIRTUAL_ITEM_MP_MAX")]
	VirtualItemMpMax = 24,
	[OriginalName("VIRTUAL_ITEM_PLAYER_RETURN_POINT")]
	VirtualItemPlayerReturnPoint = 25,
	[OriginalName("VIRTUAL_ITEM_BATTLE_COLLEGE_POINT")]
	VirtualItemBattleCollegePoint = 26,
	[OriginalName("VIRTUAL_ITEM_ROGUE_COIN")]
	VirtualItemRogueCoin = 31,
	[OriginalName("VIRTUAL_ITEM_ROGUE_TALENT_COIN")]
	VirtualItemRogueTalentCoin = 32,
	[OriginalName("VIRTUAL_ITEM_ROGUE_REWARD_KEY")]
	VirtualItemRogueRewardKey = 33,
	[OriginalName("VIRTUAL_ITEM_ROGUE_SUPER_REWARD_KEY")]
	VirtualItemRogueSuperRewardKey = 34,
	[OriginalName("VIRTUAL_ITEM_ACHIEVEMENT_EXP")]
	VirtualItemAchievementExp = 41,
	[OriginalName("VIRTUAL_ITEM_BP_EXP")]
	VirtualItemBpExp = 51,
	[OriginalName("VIRTUAL_ITEM_BP_REAL_EXP")]
	VirtualItemBpRealExp = 52,
	[OriginalName("VIRTUAL_ITEM_MUSEUM_FUNDS")]
	VirtualItemMuseumFunds = 53,
	[OriginalName("VIRTUAL_TRAINPARTY_BUILDING_FUNDS")]
	VirtualTrainpartyBuildingFunds = 54,
	[OriginalName("VIRTUAL_TRAINPARTY_AREA_UNLOCK_COIN")]
	VirtualTrainpartyAreaUnlockCoin = 55,
	[OriginalName("VIRTUAL_TRAINPARTY_MOBILITY")]
	VirtualTrainpartyMobility = 56,
	[OriginalName("VIRTUAL_ITEM_WARRIOR_EXP")]
	VirtualItemWarriorExp = 190,
	[OriginalName("VIRTUAL_ITEM_ROGUE_EXP")]
	VirtualItemRogueExp = 191,
	[OriginalName("VIRTUAL_ITEM_MAGE_EXP")]
	VirtualItemMageExp = 192,
	[OriginalName("VIRTUAL_ITEM_SHAMAN_EXP")]
	VirtualItemShamanExp = 193,
	[OriginalName("VIRTUAL_ITEM_WARLOCK_EXP")]
	VirtualItemWarlockExp = 194,
	[OriginalName("VIRTUAL_ITEM_KNIGHT_EXP")]
	VirtualItemKnightExp = 195,
	[OriginalName("VIRTUAL_ITEM_PRIEST_EXP")]
	VirtualItemPriestExp = 196,
	[OriginalName("VIRTUAL_ITEM_PUNK_LORD_POINT")]
	VirtualItemPunkLordPoint = 100000,
	[OriginalName("VIRTUAL_ITEM_GAMEPLAY_COUNTER_MONSTER_SNEAK_VISION")]
	VirtualItemGameplayCounterMonsterSneakVision = 280001,
	[OriginalName("VIRTUAL_ITEM_GAMEPLAY_COUNTER_WOLF_BRO_BULLET")]
	VirtualItemGameplayCounterWolfBroBullet = 280002,
	[OriginalName("VIRTUAL_ITEM_ALLEY_FUNDS")]
	VirtualItemAlleyFunds = 281001,
	[OriginalName("VIRTUAL_ITEM_ROGUE_PUMAN_COUPON")]
	VirtualItemRoguePumanCoupon = 281012,
	[OriginalName("VIRTUAL_ITEM_MONTH_CARD")]
	VirtualItemMonthCard = 300101,
	[OriginalName("VIRTUAL_ITEM_BP_NORMAL")]
	VirtualItemBpNormal = 300102,
	[OriginalName("VIRTUAL_ITEM_BP_DELUXE")]
	VirtualItemBpDeluxe = 300103,
	[OriginalName("VIRTUAL_ITEM_BP_UPGRADE")]
	VirtualItemBpUpgrade = 300104,
	[OriginalName("VIRTUAL_ITEM_HELIOBUS_FANS")]
	VirtualItemHeliobusFans = 281002,
	[OriginalName("VIRTUAL_ITEM_SPACE_ZOO_HYBRID_ITEM")]
	VirtualItemSpaceZooHybridItem = 281003,
	[OriginalName("VIRTUAL_ITEM_SPACE_ZOO_EXP_POINT")]
	VirtualItemSpaceZooExpPoint = 281004,
	[OriginalName("VIRTUAL_ITEM_ROGUE_NOUS_TALENT_COIN")]
	VirtualItemRogueNousTalentCoin = 281013,
	[OriginalName("VIRTUAL_ITEM_EVOLVE_BUILD_COIN")]
	VirtualItemEvolveBuildCoin = 281019,
	[OriginalName("VIRTUAL_ITEM_DRINK_MAKER_TIP")]
	VirtualItemDrinkMakerTip = 281005,
	[OriginalName("VIRTUAL_ITEM_MONOPOLY_DICE")]
	VirtualItemMonopolyDice = 281014,
	[OriginalName("VIRTUAL_ITEM_MONOPOLY_COIN")]
	VirtualItemMonopolyCoin = 281015,
	[OriginalName("VIRTUAL_ITEM_MONOPOLY_CHEATDICE")]
	VirtualItemMonopolyCheatdice = 281016,
	[OriginalName("VIRTUAL_ITEM_MONOPOLY_REROLL")]
	VirtualItemMonopolyReroll = 281017,
	[OriginalName("VIRTUAL_ITEM_ROGUE_TOURN_PERMANENT_TALENT_COIN")]
	VirtualItemRogueTournPermanentTalentCoin = 281018,
	[OriginalName("VIRTUAL_ITEM_ROGUE_TOURN_SEASON_TALENT_COIN")]
	VirtualItemRogueTournSeasonTalentCoin = 281020,
	[OriginalName("VIRTUAL_ITEM_ROGUE_TOURN_EXP")]
	VirtualItemRogueTournExp = 281022,
	[OriginalName("VIRTUAL_ITEM_MATCHTHREE_COIN")]
	VirtualItemMatchthreeCoin = 281024,
	[OriginalName("VIRTUAL_ITEM_SWORD_TRAINING_SKILL_POINT")]
	VirtualItemSwordTrainingSkillPoint = 281023,
	[OriginalName("VIRTUAL_ITEM_FIGHT_FEST_COIN")]
	VirtualItemFightFestCoin = 281025,
	[OriginalName("VIRTUAL_ITEM_ROGUE_MAGIC_TALENT_COIN")]
	VirtualItemRogueMagicTalentCoin = 281026,
	[OriginalName("VIRTUAL_ITEM_EVOLVE_BUILD_SC_COIN")]
	VirtualItemEvolveBuildScCoin = 281027,
	[OriginalName("VIRTUAL_ITEM_EVOLVE_BUILD_REWARD_EXP")]
	VirtualItemEvolveBuildRewardExp = 281028,
	[OriginalName("VIRTUAL_ITEM_MATCHTHREE_V2_COIN")]
	VirtualItemMatchthreeV2Coin = 281029,
	[OriginalName("VIRTUAL_ITEM_GRID_FIGHT_COIN")]
	VirtualItemGridFightCoin = 281031,
	[OriginalName("VIRTUAL_ITEM_GRID_FIGHT_TALENT_COIN")]
	VirtualItemGridFightTalentCoin = 281032,
	[OriginalName("VIRTUAL_ITEM_GRID_FIGHT_SEASON_EXP")]
	VirtualItemGridFightSeasonExp = 281033,
	[OriginalName("VIRTUAL_ITEM_GRID_FIGHT_GAMEPLAY_EXP")]
	VirtualItemGridFightGameplayExp = 281034,
	[OriginalName("VIRTUAL_ITEM_GRID_FIGHT_FREE_REFRESH_TIMES")]
	VirtualItemGridFightFreeRefreshTimes = 281035,
	[OriginalName("VIRTUAL_ITEM_CAKE_RACE_COIN")]
	VirtualItemCakeRaceCoin = 281038,
	[OriginalName("VIRTUAL_ITEM_CAKE_RACE_SCORE")]
	VirtualItemCakeRaceScore = 281039
}
