using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using March7thHoney.Data.Config;
using March7thHoney.Data.Config.AdventureAbility;
using March7thHoney.Data.Config.Character;
using March7thHoney.Data.Config.Scene;
using March7thHoney.Data.Custom;
using March7thHoney.Data.Excel;
using March7thHoney.Enums.Avatar;
using March7thHoney.Enums.GridFight;
using March7thHoney.Enums.Item;
using March7thHoney.Enums.Rogue;
using March7thHoney.Enums.TournRogue;
using March7thHoney.Util;
using Newtonsoft.Json;

namespace March7thHoney.Data;

public static class GameData
{
	public static BannersConfig BannersConfig { get; set; } = new BannersConfig();

	public static VideoKeysConfig VideoKeysConfig { get; set; } = new VideoKeysConfig();

	public static QueryProductInfoConfig QueryProductInfoConfig { get; set; } = new QueryProductInfoConfig();

	public static Dictionary<int, PamSkinConfigExcel> PamSkinConfigData { get; private set; } = new Dictionary<int, PamSkinConfigExcel>();

	public static ActivityConfig ActivityConfig { get; set; } = new ActivityConfig();

	public static Dictionary<int, MarbleMatchInfoExcel> MarbleMatchInfoData { get; private set; } = new Dictionary<int, MarbleMatchInfoExcel>();

	public static Dictionary<int, MarbleSealExcel> MarbleSealData { get; private set; } = new Dictionary<int, MarbleSealExcel>();

	public static Dictionary<int, AvatarConfigExcel> AvatarConfigData { get; private set; } = new Dictionary<int, AvatarConfigExcel>();

	public static Dictionary<uint, AvatarRelicRecommendExcel> AvatarRelicRecommendData { get; private set; } = new Dictionary<uint, AvatarRelicRecommendExcel>();

	public static Dictionary<int, AvatarGlobalBuffConfigExcel> AvatarGlobalBuffConfigData { get; private set; } = new Dictionary<int, AvatarGlobalBuffConfigExcel>();

	public static Dictionary<int, AdventureAbilityConfigListInfo> AdventureAbilityConfigListData { get; private set; } = new Dictionary<int, AdventureAbilityConfigListInfo>();

	public static Dictionary<int, AvatarPromotionConfigExcel> AvatarPromotionConfigData { get; private set; } = new Dictionary<int, AvatarPromotionConfigExcel>();

	public static Dictionary<int, AvatarExpItemConfigExcel> AvatarExpItemConfigData { get; private set; } = new Dictionary<int, AvatarExpItemConfigExcel>();

	public static Dictionary<int, AvatarSkillTreeConfigExcel> AvatarSkillTreeConfigData { get; private set; } = new Dictionary<int, AvatarSkillTreeConfigExcel>();

	public static Dictionary<int, MazeSkillExcel> MazeSkillData { get; private set; } = new Dictionary<int, MazeSkillExcel>();

	public static Dictionary<int, AvatarSkinExcel> AvatarSkinData { get; private set; } = new Dictionary<int, AvatarSkinExcel>();

	public static Dictionary<int, AvatarDemoConfigExcel> AvatarDemoConfigData { get; private set; } = new Dictionary<int, AvatarDemoConfigExcel>();

	public static Dictionary<int, ExpTypeExcel> ExpTypeData { get; } = new Dictionary<int, ExpTypeExcel>();

	public static Dictionary<int, MultiplePathAvatarConfigExcel> MultiplePathAvatarConfigData { get; private set; } = new Dictionary<int, MultiplePathAvatarConfigExcel>();

	public static Dictionary<int, AdventurePlayerExcel> AdventurePlayerData { get; private set; } = new Dictionary<int, AdventurePlayerExcel>();

	public static Dictionary<int, SummonUnitDataExcel> SummonUnitDataData { get; private set; } = new Dictionary<int, SummonUnitDataExcel>();

	public static Dictionary<int, DecideAvatarOrderExcel> DecideAvatarOrderData { get; private set; } = new Dictionary<int, DecideAvatarOrderExcel>();

	public static ConcurrentDictionary<int, CharacterConfigInfo> CharacterConfigInfoData { get; private set; } = new ConcurrentDictionary<int, CharacterConfigInfo>();

	public static Dictionary<AvatarBaseTypeEnum, UpgradeAvatarEquipmentExcel> UpgradeAvatarEquipmentData { get; private set; } = new Dictionary<AvatarBaseTypeEnum, UpgradeAvatarEquipmentExcel>();

	public static Dictionary<uint, UpgradeAvatarSubTypeExcel> UpgradeAvatarSubTypeData { get; private set; } = new Dictionary<uint, UpgradeAvatarSubTypeExcel>();

	public static Dictionary<UpgradeAvatarSubRelicTypeEnum, Dictionary<RarityEnum, Dictionary<uint, Dictionary<RelicTypeEnum, UpgradeAvatarSubRelicExcel>>>> UpgradeAvatarSubRelicData { get; private set; } = new Dictionary<UpgradeAvatarSubRelicTypeEnum, Dictionary<RarityEnum, Dictionary<uint, Dictionary<RelicTypeEnum, UpgradeAvatarSubRelicExcel>>>>();

	public static Dictionary<int, ChallengeConfigExcel> ChallengeConfigData { get; private set; } = new Dictionary<int, ChallengeConfigExcel>();

	public static Dictionary<int, ChallengeTargetExcel> ChallengeTargetData { get; private set; } = new Dictionary<int, ChallengeTargetExcel>();

	public static Dictionary<int, ChallengeGroupExcel> ChallengeGroupData { get; private set; } = new Dictionary<int, ChallengeGroupExcel>();

	public static Dictionary<int, ChallengePeakGroupConfigExcel> ChallengePeakGroupConfigData { get; private set; } = new Dictionary<int, ChallengePeakGroupConfigExcel>();

	public static Dictionary<int, ChallengePeakConfigExcel> ChallengePeakConfigData { get; private set; } = new Dictionary<int, ChallengePeakConfigExcel>();

	public static Dictionary<int, ChallengePeakBossConfigExcel> ChallengePeakBossConfigData { get; private set; } = new Dictionary<int, ChallengePeakBossConfigExcel>();

	public static ChallengePeakOverrideConfig ChallengePeakOverrideConfig { get; set; } = new ChallengePeakOverrideConfig();

	public static Dictionary<int, List<ChallengeRewardExcel>> ChallengeRewardData { get; private set; } = new Dictionary<int, List<ChallengeRewardExcel>>();

	public static Dictionary<int, List<ChallengePeakRewardExcel>> ChallengePeakRewardData { get; private set; } = new Dictionary<int, List<ChallengePeakRewardExcel>>();

	public static Dictionary<int, CocoonConfigExcel> CocoonConfigData { get; private set; } = new Dictionary<int, CocoonConfigExcel>();

	public static Dictionary<int, FarmElementConfigExcel> FarmElementConfigData { get; private set; } = new Dictionary<int, FarmElementConfigExcel>();

	public static Dictionary<int, StageConfigExcel> StageConfigData { get; private set; } = new Dictionary<int, StageConfigExcel>();

	public static Dictionary<int, RaidConfigExcel> RaidConfigData { get; private set; } = new Dictionary<int, RaidConfigExcel>();

	public static Dictionary<int, MazeBuffExcel> MazeBuffData { get; private set; } = new Dictionary<int, MazeBuffExcel>();

	public static Dictionary<int, InteractConfigExcel> InteractConfigData { get; private set; } = new Dictionary<int, InteractConfigExcel>();

	public static Dictionary<int, NPCMonsterDataExcel> NpcMonsterDataData { get; private set; } = new Dictionary<int, NPCMonsterDataExcel>();

	public static Dictionary<int, MonsterConfigExcel> MonsterConfigData { get; private set; } = new Dictionary<int, MonsterConfigExcel>();

	public static Dictionary<int, MonsterTemplateConfigExcel> MonsterTemplateConfigData { get; private set; } = new Dictionary<int, MonsterTemplateConfigExcel>();

	public static Dictionary<int, MonsterDropExcel> MonsterDropData { get; private set; } = new Dictionary<int, MonsterDropExcel>();

	public static Dictionary<int, BattleCollegeConfigExcel> BattleCollegeConfigData { get; private set; } = new Dictionary<int, BattleCollegeConfigExcel>();

	public static Dictionary<int, BattleTargetConfigExcel> BattleTargetConfigData { get; private set; } = new Dictionary<int, BattleTargetConfigExcel>();

	public static GridFightBasicOrbRewardsConfig GridFightBasicOrbRewardsConfig { get; set; } = new GridFightBasicOrbRewardsConfig();

	public static Dictionary<uint, GridFightBasicBonusPoolV2Excel> GridFightBasicBonusPoolV2Data { get; private set; } = new Dictionary<uint, GridFightBasicBonusPoolV2Excel>();

	public static Dictionary<uint, GridFightRoleBasicInfoExcel> GridFightRoleBasicInfoData { get; private set; } = new Dictionary<uint, GridFightRoleBasicInfoExcel>();

	public static Dictionary<uint, GridFightRoleStarExcel> GridFightRoleStarData { get; private set; } = new Dictionary<uint, GridFightRoleStarExcel>();

	public static Dictionary<uint, GridFightRoleRecommendEquipExcel> GridFightRoleRecommendEquipData { get; private set; } = new Dictionary<uint, GridFightRoleRecommendEquipExcel>();

	public static Dictionary<uint, GridFightCombinationBonusExcel> GridFightCombinationBonusData { get; private set; } = new Dictionary<uint, GridFightCombinationBonusExcel>();

	public static Dictionary<uint, GridFightDivisionInfoExcel> GridFightDivisionInfoData { get; private set; } = new Dictionary<uint, GridFightDivisionInfoExcel>();

	public static Dictionary<uint, GridFightDivisionStageExcel> GridFightDivisionStageData { get; private set; } = new Dictionary<uint, GridFightDivisionStageExcel>();

	public static Dictionary<uint, GridFightEquipmentExcel> GridFightEquipmentData { get; private set; } = new Dictionary<uint, GridFightEquipmentExcel>();

	public static Dictionary<uint, GridFightForgeExcel> GridFightForgeData { get; private set; } = new Dictionary<uint, GridFightForgeExcel>();

	public static Dictionary<uint, GridFightTraitEffectExcel> GridFightTraitEffectData { get; private set; } = new Dictionary<uint, GridFightTraitEffectExcel>();

	public static Dictionary<uint, GridFightTraitBonusAddRuleExcel> GridFightTraitBonusAddRuleData { get; private set; } = new Dictionary<uint, GridFightTraitBonusAddRuleExcel>();

	public static Dictionary<uint, Dictionary<uint, GridFightTraitBonusExcel>> GridFightTraitBonusData { get; private set; } = new Dictionary<uint, Dictionary<uint, GridFightTraitBonusExcel>>();

	public static Dictionary<uint, GridFightEquipUpgradeExcel> GridFightEquipUpgradeData { get; private set; } = new Dictionary<uint, GridFightEquipUpgradeExcel>();

	public static Dictionary<uint, GridFightConsumablesExcel> GridFightConsumablesData { get; private set; } = new Dictionary<uint, GridFightConsumablesExcel>();

	public static Dictionary<uint, GridFightCampExcel> GridFightCampData { get; private set; } = new Dictionary<uint, GridFightCampExcel>();

	public static Dictionary<uint, GridFightShopPriceExcel> GridFightShopPriceData { get; private set; } = new Dictionary<uint, GridFightShopPriceExcel>();

	public static Dictionary<uint, GridFightPlayerLevelExcel> GridFightPlayerLevelData { get; private set; } = new Dictionary<uint, GridFightPlayerLevelExcel>();

	public static Dictionary<uint, GridFightMonsterExcel> GridFightMonsterData { get; private set; } = new Dictionary<uint, GridFightMonsterExcel>();

	public static Dictionary<uint, GridFightAugmentExcel> GridFightAugmentData { get; private set; } = new Dictionary<uint, GridFightAugmentExcel>();

	public static Dictionary<uint, GridFightAffixConfigExcel> GridFightAffixConfigData { get; private set; } = new Dictionary<uint, GridFightAffixConfigExcel>();

	public static Dictionary<uint, GridFightOrbExcel> GridFightOrbData { get; private set; } = new Dictionary<uint, GridFightOrbExcel>();

	public static Dictionary<uint, Dictionary<GridFightAugmentQualityEnum, GridFightAugmentMonsterExcel>> GridFightAugmentMonsterData { get; private set; } = new Dictionary<uint, Dictionary<GridFightAugmentQualityEnum, GridFightAugmentMonsterExcel>>();

	public static Dictionary<uint, GridFightPortalBuffExcel> GridFightPortalBuffData { get; private set; } = new Dictionary<uint, GridFightPortalBuffExcel>();

	public static Dictionary<uint, GridFightItemsExcel> GridFightItemsData { get; private set; } = new Dictionary<uint, GridFightItemsExcel>();

	public static Dictionary<uint, GridFightTalentExcel> GridFightTalentData { get; private set; } = new Dictionary<uint, GridFightTalentExcel>();

	public static Dictionary<uint, GridFightTraitBasicInfoExcel> GridFightTraitBasicInfoData { get; private set; } = new Dictionary<uint, GridFightTraitBasicInfoExcel>();

	public static Dictionary<uint, Dictionary<uint, GridFightTraitLayerExcel>> GridFightTraitLayerData { get; private set; } = new Dictionary<uint, Dictionary<uint, GridFightTraitLayerExcel>>();

	public static Dictionary<uint, Dictionary<uint, GridFightTraitEffectLayerPaExcel>> GridFightTraitEffectLayerPaData { get; private set; } = new Dictionary<uint, Dictionary<uint, GridFightTraitEffectLayerPaExcel>>();

	public static Dictionary<uint, GridFightSeasonTalentExcel> GridFightSeasonTalentData { get; private set; } = new Dictionary<uint, GridFightSeasonTalentExcel>();

	public static Dictionary<uint, List<uint>> GridFightSeasonPortalData { get; private set; } = new Dictionary<uint, List<uint>>();

	public static Dictionary<uint, Dictionary<uint, GridFightStageRouteExcel>> GridFightStageRouteData { get; private set; } = new Dictionary<uint, Dictionary<uint, GridFightStageRouteExcel>>();

	public static Dictionary<uint, GridFightNodeTemplateExcel> GridFightNodeTemplateData { get; private set; } = new Dictionary<uint, GridFightNodeTemplateExcel>();

	public static Dictionary<int, ActionPointOverdrawExcel> ActionPointOverdrawData { get; private set; } = new Dictionary<int, ActionPointOverdrawExcel>();

	public static Dictionary<RogueDLCBlockTypeEnum, List<ChessRogueRoomConfig>> ChessRogueRoomData { get; private set; } = new Dictionary<RogueDLCBlockTypeEnum, List<ChessRogueRoomConfig>>();

	public static Dictionary<int, ChessRogueDiceSurfaceEffectConfig> ChessRogueDiceSurfaceEffectData { get; set; } = new Dictionary<int, ChessRogueDiceSurfaceEffectConfig>();

	public static Dictionary<int, RogueDLCAreaExcel> RogueDLCAreaData { get; private set; } = new Dictionary<int, RogueDLCAreaExcel>();

	public static Dictionary<int, RogueDLCBossDecayExcel> RogueDLCBossDecayData { get; private set; } = new Dictionary<int, RogueDLCBossDecayExcel>();

	public static Dictionary<int, RogueDLCBossBpExcel> RogueDLCBossBpData { get; private set; } = new Dictionary<int, RogueDLCBossBpExcel>();

	public static Dictionary<int, RogueDLCDifficultyExcel> RogueDLCDifficultyData { get; private set; } = new Dictionary<int, RogueDLCDifficultyExcel>();

	public static Dictionary<int, RogueNousAeonExcel> RogueNousAeonData { get; private set; } = new Dictionary<int, RogueNousAeonExcel>();

	public static Dictionary<int, RogueNousDiceBranchExcel> RogueNousDiceBranchData { get; private set; } = new Dictionary<int, RogueNousDiceBranchExcel>();

	public static Dictionary<int, RogueNousDiceSurfaceExcel> RogueNousDiceSurfaceData { get; private set; } = new Dictionary<int, RogueNousDiceSurfaceExcel>();

	public static Dictionary<int, RogueNousDifficultyLevelExcel> RogueNousDifficultyLevelData { get; private set; } = new Dictionary<int, RogueNousDifficultyLevelExcel>();

	public static Dictionary<int, RogueNousMainStoryExcel> RogueNousMainStoryData { get; private set; } = new Dictionary<int, RogueNousMainStoryExcel>();

	public static Dictionary<int, RogueNousSubStoryExcel> RogueNousSubStoryData { get; private set; } = new Dictionary<int, RogueNousSubStoryExcel>();

	public static Dictionary<int, RogueNousTalentExcel> RogueNousTalentData { get; private set; } = new Dictionary<int, RogueNousTalentExcel>();

	public static Dictionary<int, List<RogueDLCChessBoardExcel>> RogueSwarmChessBoardData { get; private set; } = new Dictionary<int, List<RogueDLCChessBoardExcel>>();

	public static Dictionary<int, List<RogueDLCChessBoardExcel>> RogueNousChessBoardData { get; private set; } = new Dictionary<int, List<RogueDLCChessBoardExcel>>();

	public static Dictionary<uint, RogueDialogueEventConfig> SwarmRogueDialogueEventConfig { get; private set; } = new Dictionary<uint, RogueDialogueEventConfig>();

	public static Dictionary<uint, RogueDialogueEventConfig> NousRogueDialogueEventConfig { get; private set; } = new Dictionary<uint, RogueDialogueEventConfig>();

	public static Dictionary<int, AchievementDataExcel> AchievementDataData { get; private set; } = new Dictionary<int, AchievementDataExcel>();

	public static Dictionary<int, QuestDataExcel> QuestDataData { get; private set; } = new Dictionary<int, QuestDataExcel>();

	public static Dictionary<int, FinishWayExcel> FinishWayData { get; private set; } = new Dictionary<int, FinishWayExcel>();

	public static Dictionary<int, PlayerLevelConfigExcel> PlayerLevelConfigData { get; } = new Dictionary<int, PlayerLevelConfigExcel>();

	public static Dictionary<int, BackGroundMusicExcel> BackGroundMusicData { get; private set; } = new Dictionary<int, BackGroundMusicExcel>();

	public static Dictionary<int, ChatBubbleConfigExcel> ChatBubbleConfigData { get; private set; } = new Dictionary<int, ChatBubbleConfigExcel>();

	public static Dictionary<string, RechargeConfigExcel> RechargeConfigData { get; private set; } = new Dictionary<string, RechargeConfigExcel>();

	public static Dictionary<int, RechargeGiftConfigExcel> RechargeGiftConfigData { get; private set; } = new Dictionary<int, RechargeGiftConfigExcel>();

	public static Dictionary<int, ExpeditionDataExcel> ExpeditionDataData { get; private set; } = new Dictionary<int, ExpeditionDataExcel>();

	public static Dictionary<int, List<ExpeditionRewardExcel>> ExpeditionRewardData { get; private set; } = new Dictionary<int, List<ExpeditionRewardExcel>>();

	public static Dictionary<int, OfferingTypeConfigExcel> OfferingTypeConfigData { get; private set; } = new Dictionary<int, OfferingTypeConfigExcel>();

	public static Dictionary<int, Dictionary<int, OfferingLevelConfigExcel>> OfferingLevelConfigData { get; private set; } = new Dictionary<int, Dictionary<int, OfferingLevelConfigExcel>>();

	[JsonConverter(typeof(ConcurrentDictionaryConverter<string, FloorInfo>))]
	public static ConcurrentDictionary<string, FloorInfo> FloorInfoData { get; } = new ConcurrentDictionary<string, FloorInfo>();

	public static Dictionary<int, NPCDataExcel> NpcDataData { get; private set; } = new Dictionary<int, NPCDataExcel>();

	public static Dictionary<int, MapEntranceExcel> MapEntranceData { get; } = new Dictionary<int, MapEntranceExcel>();

	public static Dictionary<int, MazePlaneExcel> MazePlaneData { get; private set; } = new Dictionary<int, MazePlaneExcel>();

	public static Dictionary<int, MazePuzzleSwitchHandExcel> MazePuzzleSwitchHandData { get; private set; } = new Dictionary<int, MazePuzzleSwitchHandExcel>();

	public static Dictionary<int, MazeChestExcel> MazeChestData { get; private set; } = new Dictionary<int, MazeChestExcel>();

	public static Dictionary<int, MazePropExcel> MazePropData { get; private set; } = new Dictionary<int, MazePropExcel>();

	public static Dictionary<int, PlaneEventExcel> PlaneEventData { get; private set; } = new Dictionary<int, PlaneEventExcel>();

	public static Dictionary<int, ContentPackageConfigExcel> ContentPackageConfigData { get; private set; } = new Dictionary<int, ContentPackageConfigExcel>();

	public static Dictionary<int, GroupSystemUnlockDataExcel> GroupSystemUnlockDataData { get; private set; } = new Dictionary<int, GroupSystemUnlockDataExcel>();

	public static Dictionary<int, FuncUnlockDataExcel> FuncUnlockDataData { get; private set; } = new Dictionary<int, FuncUnlockDataExcel>();

	public static Dictionary<int, MusicRhythmLevelExcel> MusicRhythmLevelData { get; private set; } = new Dictionary<int, MusicRhythmLevelExcel>();

	public static Dictionary<int, MusicRhythmGroupExcel> MusicRhythmGroupData { get; private set; } = new Dictionary<int, MusicRhythmGroupExcel>();

	public static Dictionary<int, MusicRhythmPhaseExcel> MusicRhythmPhaseData { get; private set; } = new Dictionary<int, MusicRhythmPhaseExcel>();

	public static Dictionary<int, MusicRhythmSongExcel> MusicRhythmSongData { get; private set; } = new Dictionary<int, MusicRhythmSongExcel>();

	public static Dictionary<int, MusicRhythmSoundEffectExcel> MusicRhythmSoundEffectData { get; private set; } = new Dictionary<int, MusicRhythmSoundEffectExcel>();

	public static Dictionary<int, MusicRhythmTrackExcel> MusicRhythmTrackData { get; private set; } = new Dictionary<int, MusicRhythmTrackExcel>();

	public static Dictionary<string, AdventureModifierConfig> AdventureModifierData { get; set; } = new Dictionary<string, AdventureModifierConfig>();

	public static SceneRainbowGroupPropertyConfig SceneRainbowGroupPropertyData { get; set; } = new SceneRainbowGroupPropertyConfig();

	public static Dictionary<int, TrainPartyPassengerConfigExcel> TrainPartyPassengerConfigData { get; private set; } = new Dictionary<int, TrainPartyPassengerConfigExcel>();

	public static Dictionary<int, TrainPartyAreaConfigExcel> TrainPartyAreaConfigData { get; private set; } = new Dictionary<int, TrainPartyAreaConfigExcel>();

	public static Dictionary<int, TrainPartyAreaGoalConfigExcel> TrainPartyAreaGoalConfigData { get; private set; } = new Dictionary<int, TrainPartyAreaGoalConfigExcel>();

	public static Dictionary<int, TrainPartyStepConfigExcel> TrainPartyStepConfigData { get; private set; } = new Dictionary<int, TrainPartyStepConfigExcel>();

	public static Dictionary<int, TrainPartyDynamicConfigExcel> TrainPartyDynamicConfigData { get; private set; } = new Dictionary<int, TrainPartyDynamicConfigExcel>();

	public static Dictionary<int, CakeConfigExcel> CakeConfigData { get; private set; } = new Dictionary<int, CakeConfigExcel>();

	public static Dictionary<int, CakePerformanceConfigExcel> CakePerformanceConfigData { get; private set; } = new Dictionary<int, CakePerformanceConfigExcel>();

	public static Dictionary<string, CakeCatchConstValueCommonExcel> CakeCatchConstValueData { get; private set; } = new Dictionary<string, CakeCatchConstValueCommonExcel>();

	public static Dictionary<int, MappingInfoExcel> MappingInfoData { get; private set; } = new Dictionary<int, MappingInfoExcel>();

	public static Dictionary<int, ItemConfigExcel> ItemConfigData { get; private set; } = new Dictionary<int, ItemConfigExcel>();

	public static Dictionary<int, ItemUseBuffDataExcel> ItemUseBuffDataData { get; private set; } = new Dictionary<int, ItemUseBuffDataExcel>();

	public static Dictionary<int, ItemUseDataExcel> ItemUseDataData { get; private set; } = new Dictionary<int, ItemUseDataExcel>();

	public static Dictionary<int, EquipmentConfigExcel> EquipmentConfigData { get; private set; } = new Dictionary<int, EquipmentConfigExcel>();

	public static Dictionary<int, EquipmentExpTypeExcel> EquipmentExpTypeData { get; } = new Dictionary<int, EquipmentExpTypeExcel>();

	public static Dictionary<int, EquipmentExpItemConfigExcel> EquipmentExpItemConfigData { get; private set; } = new Dictionary<int, EquipmentExpItemConfigExcel>();

	public static Dictionary<int, EquipmentPromotionConfigExcel> EquipmentPromotionConfigData { get; private set; } = new Dictionary<int, EquipmentPromotionConfigExcel>();

	public static Dictionary<int, Dictionary<int, RelicMainAffixConfigExcel>> RelicMainAffixData { get; private set; } = new Dictionary<int, Dictionary<int, RelicMainAffixConfigExcel>>();

	public static Dictionary<int, Dictionary<int, RelicSubAffixConfigExcel>> RelicSubAffixData { get; private set; } = new Dictionary<int, Dictionary<int, RelicSubAffixConfigExcel>>();

	public static Dictionary<int, RelicConfigExcel> RelicConfigData { get; private set; } = new Dictionary<int, RelicConfigExcel>();

	public static Dictionary<int, RelicExpItemExcel> RelicExpItemData { get; private set; } = new Dictionary<int, RelicExpItemExcel>();

	public static Dictionary<int, RelicExpTypeExcel> RelicExpTypeData { get; private set; } = new Dictionary<int, RelicExpTypeExcel>();

	public static Dictionary<int, PetExcel> PetData { get; private set; } = new Dictionary<int, PetExcel>();

	public static Dictionary<int, SpecialAvatarExcel> SpecialAvatarData { get; private set; } = new Dictionary<int, SpecialAvatarExcel>();

	public static Dictionary<int, SpecialAvatarRelicExcel> SpecialAvatarRelicData { get; private set; } = new Dictionary<int, SpecialAvatarRelicExcel>();

	public static Dictionary<int, MainMissionExcel> MainMissionData { get; private set; } = new Dictionary<int, MainMissionExcel>();

	public static Dictionary<int, SubMissionExcel> SubMissionData { get; private set; } = new Dictionary<int, SubMissionExcel>();

	public static ConcurrentDictionary<int, SubMissionData> SubMissionInfoData { get; private set; } = new ConcurrentDictionary<int, SubMissionData>();

	public static Dictionary<int, RewardDataExcel> RewardDataData { get; private set; } = new Dictionary<int, RewardDataExcel>();

	public static Dictionary<int, MessageGroupConfigExcel> MessageGroupConfigData { get; private set; } = new Dictionary<int, MessageGroupConfigExcel>();

	public static Dictionary<int, MessageSectionConfigExcel> MessageSectionConfigData { get; private set; } = new Dictionary<int, MessageSectionConfigExcel>();

	public static Dictionary<int, MessageContactsConfigExcel> MessageContactsConfigData { get; private set; } = new Dictionary<int, MessageContactsConfigExcel>();

	public static Dictionary<int, MessageItemConfigExcel> MessageItemConfigData { get; private set; } = new Dictionary<int, MessageItemConfigExcel>();

	public static Dictionary<int, PerformanceDExcel> PerformanceDData { get; private set; } = new Dictionary<int, PerformanceDExcel>();

	public static Dictionary<int, PerformanceEExcel> PerformanceEData { get; private set; } = new Dictionary<int, PerformanceEExcel>();

	public static Dictionary<int, StoryLineExcel> StoryLineData { get; private set; } = new Dictionary<int, StoryLineExcel>();

	public static Dictionary<int, Dictionary<int, StoryLineFloorDataExcel>> StoryLineFloorDataData { get; private set; } = new Dictionary<int, Dictionary<int, StoryLineFloorDataExcel>>();

	public static Dictionary<int, StroyLineTrialAvatarDataExcel> StroyLineTrialAvatarDataData { get; private set; } = new Dictionary<int, StroyLineTrialAvatarDataExcel>();

	public static Dictionary<int, HeartDialScriptExcel> HeartDialScriptData { get; private set; } = new Dictionary<int, HeartDialScriptExcel>();

	public static Dictionary<int, HeartDialDialogueExcel> HeartDialDialogueData { get; private set; } = new Dictionary<int, HeartDialDialogueExcel>();

	public static Dictionary<int, ShopConfigExcel> ShopConfigData { get; private set; } = new Dictionary<int, ShopConfigExcel>();

	public static Dictionary<int, RollShopConfigExcel> RollShopConfigData { get; private set; } = new Dictionary<int, RollShopConfigExcel>();

	public static Dictionary<int, RollShopRewardExcel> RollShopRewardData { get; private set; } = new Dictionary<int, RollShopRewardExcel>();

	public static Dictionary<int, ItemComposeConfigExcel> ItemComposeConfigData { get; private set; } = new Dictionary<int, ItemComposeConfigExcel>();

	public static Dictionary<int, DialogueEventExcel> DialogueEventData { get; private set; } = new Dictionary<int, DialogueEventExcel>();

	public static Dictionary<int, Dictionary<int, DialogueDynamicContentExcel>> DialogueDynamicContentData { get; private set; } = new Dictionary<int, Dictionary<int, DialogueDynamicContentExcel>>();

	public static Dictionary<int, RogueAeonExcel> RogueAeonData { get; private set; } = new Dictionary<int, RogueAeonExcel>();

	public static Dictionary<int, RogueBuffExcel> RogueAeonBuffData { get; private set; } = new Dictionary<int, RogueBuffExcel>();

	public static Dictionary<int, BattleEventDataExcel> RogueBattleEventData { get; private set; } = new Dictionary<int, BattleEventDataExcel>();

	public static Dictionary<int, List<RogueBuffExcel>> RogueAeonEnhanceData { get; private set; } = new Dictionary<int, List<RogueBuffExcel>>();

	public static Dictionary<int, RogueAreaConfigExcel> RogueAreaConfigData { get; private set; } = new Dictionary<int, RogueAreaConfigExcel>();

	public static Dictionary<int, RogueBonusExcel> RogueBonusData { get; private set; } = new Dictionary<int, RogueBonusExcel>();

	public static Dictionary<int, BaseRogueBuffExcel> RogueBuffData { get; private set; } = new Dictionary<int, BaseRogueBuffExcel>();

	public static Dictionary<int, BaseRogueBuffGroupExcel> RogueBuffGroupData { get; private set; } = new Dictionary<int, BaseRogueBuffGroupExcel>();

	public static Dictionary<int, RogueHandBookEventExcel> RogueHandBookEventData { get; private set; } = new Dictionary<int, RogueHandBookEventExcel>();

	public static Dictionary<int, RogueDialogueOptionDisplayExcel> RogueDialogueOptionDisplayData { get; private set; } = new Dictionary<int, RogueDialogueOptionDisplayExcel>();

	public static Dictionary<int, RogueDialogueDynamicDisplayExcel> RogueDialogueDynamicDisplayData { get; private set; } = new Dictionary<int, RogueDialogueDynamicDisplayExcel>();

	public static Dictionary<int, RogueHandbookMiracleExcel> RogueHandbookMiracleData { get; private set; } = new Dictionary<int, RogueHandbookMiracleExcel>();

	public static Dictionary<int, RogueManagerExcel> RogueManagerData { get; private set; } = new Dictionary<int, RogueManagerExcel>();

	public static Dictionary<int, Dictionary<int, RogueMapExcel>> RogueMapData { get; private set; } = new Dictionary<int, Dictionary<int, RogueMapExcel>>();

	public static Dictionary<int, List<int>> RogueMapGenData { get; set; } = new Dictionary<int, List<int>>();

	public static Dictionary<int, RogueMazeBuffExcel> RogueMazeBuffData { get; private set; } = new Dictionary<int, RogueMazeBuffExcel>();

	public static Dictionary<int, RogueMiracleExcel> RogueMiracleData { get; private set; } = new Dictionary<int, RogueMiracleExcel>();

	public static RogueMiracleEffectConfig RogueMiracleEffectData { get; set; } = new RogueMiracleEffectConfig();

	public static Dictionary<int, List<int>> RogueMiracleGroupData { get; set; } = new Dictionary<int, List<int>>();

	public static Dictionary<int, RogueMiracleDisplayExcel> RogueMiracleDisplayData { get; private set; } = new Dictionary<int, RogueMiracleDisplayExcel>();

	public static Dictionary<int, RogueMonsterExcel> RogueMonsterData { get; private set; } = new Dictionary<int, RogueMonsterExcel>();

	public static Dictionary<int, RogueMonsterGroupExcel> RogueMonsterGroupData { get; private set; } = new Dictionary<int, RogueMonsterGroupExcel>();

	public static Dictionary<int, RogueNPCExcel> RogueNPCData { get; private set; } = new Dictionary<int, RogueNPCExcel>();

	public static Dictionary<int, RogueTalkNameConfigExcel> RogueTalkNameConfigData { get; private set; } = new Dictionary<int, RogueTalkNameConfigExcel>();

	public static Dictionary<int, RogueRoomExcel> RogueRoomData { get; private set; } = new Dictionary<int, RogueRoomExcel>();

	public static Dictionary<int, RogueTalentExcel> RogueTalentData { get; private set; } = new Dictionary<int, RogueTalentExcel>();

	public static Dictionary<int, RogueTurntableExcel> RogueTurntableData { get; private set; } = new Dictionary<int, RogueTurntableExcel>();

	public static Dictionary<int, RogueWolfGunMiracleTargetExcel> RogueWolfGunMiracleTargetData { get; private set; } = new Dictionary<int, RogueWolfGunMiracleTargetExcel>();

	public static Dictionary<uint, RogueDialogueEventConfig> CosmosRogueDialogueEventConfig { get; private set; } = new Dictionary<uint, RogueDialogueEventConfig>();

	public static Dictionary<int, RogueTournAreaExcel> RogueTournAreaData { get; private set; } = new Dictionary<int, RogueTournAreaExcel>();

	public static Dictionary<int, Dictionary<int, RogueTournLayerRoomExcel>> RogueTournLayerRoomData { get; private set; } = new Dictionary<int, Dictionary<int, RogueTournLayerRoomExcel>>();

	public static Dictionary<int, RogueTournWorkbenchExcel> RogueTournWorkbenchData { get; private set; } = new Dictionary<int, RogueTournWorkbenchExcel>();

	public static Dictionary<int, RogueTournDivisionExcel> RogueTournDivisionData { get; private set; } = new Dictionary<int, RogueTournDivisionExcel>();

	public static Dictionary<int, RogueTournWorkbenchFuncExcel> RogueTournWorkbenchFuncData { get; private set; } = new Dictionary<int, RogueTournWorkbenchFuncExcel>();

	public static Dictionary<int, RogueTournFormulaExcel> RogueTournFormulaData { get; private set; } = new Dictionary<int, RogueTournFormulaExcel>();

	public static Dictionary<int, RogueTournMiracleExcel> RogueTournMiracleData { get; private set; } = new Dictionary<int, RogueTournMiracleExcel>();

	public static Dictionary<int, RogueTournTitanTalentExcel> RogueTournTitanTalentData { get; private set; } = new Dictionary<int, RogueTournTitanTalentExcel>();

	public static Dictionary<RogueTitanTypeEnum, RogueTournTitanTypeExcel> RogueTournTitanTypeData { get; private set; } = new Dictionary<RogueTitanTypeEnum, RogueTournTitanTypeExcel>();

	public static Dictionary<int, RogueTournTitanBlessExcel> RogueTournTitanBlessData { get; private set; } = new Dictionary<int, RogueTournTitanBlessExcel>();

	public static Dictionary<int, RogueTournHexAvatarBaseTypeExcel> RogueTournHexAvatarBaseTypeData { get; private set; } = new Dictionary<int, RogueTournHexAvatarBaseTypeExcel>();

	public static Dictionary<int, RogueTournHandBookEventExcel> RogueTournHandBookEventData { get; private set; } = new Dictionary<int, RogueTournHandBookEventExcel>();

	public static Dictionary<int, RogueTournHandbookMiracleExcel> RogueTournHandbookMiracleData { get; private set; } = new Dictionary<int, RogueTournHandbookMiracleExcel>();

	public static Dictionary<uint, RogueTournRoomExcel> RogueTournRoomData { get; private set; } = new Dictionary<uint, RogueTournRoomExcel>();

	public static Dictionary<int, RogueTournDifficultyExcel> RogueTournDifficultyData { get; private set; } = new Dictionary<int, RogueTournDifficultyExcel>();

	public static Dictionary<int, RogueTournPermanentTalentExcel> RogueTournPermanentTalentData { get; private set; } = new Dictionary<int, RogueTournPermanentTalentExcel>();

	public static List<RogueTournRoomConfig> RogueTournRoomGenData { get; set; } = new List<RogueTournRoomConfig>();

	public static Dictionary<uint, RogueDialogueEventConfig> TournRogueDialogueEventConfig { get; private set; } = new Dictionary<uint, RogueDialogueEventConfig>();

	public static Dictionary<int, RogueMagicAreaExcel> RogueMagicAreaData { get; private set; } = new Dictionary<int, RogueMagicAreaExcel>();

	public static Dictionary<int, RogueMagicAdventureRoomExcel> RogueMagicAdventureRoomData { get; private set; } = new Dictionary<int, RogueMagicAdventureRoomExcel>();

	public static Dictionary<int, RogueMagicDifficultyCompExcel> RogueMagicDifficultyCompData { get; private set; } = new Dictionary<int, RogueMagicDifficultyCompExcel>();

	public static Dictionary<int, RogueMagicStoryExcel> RogueMagicStoryData { get; private set; } = new Dictionary<int, RogueMagicStoryExcel>();

	public static Dictionary<int, RogueMagicScepterExcel> RogueMagicScepterData { get; private set; } = new Dictionary<int, RogueMagicScepterExcel>();

	public static Dictionary<int, RogueMagicRoomExcel> RogueMagicRoomData { get; private set; } = new Dictionary<int, RogueMagicRoomExcel>();

	public static Dictionary<int, RogueMagicUnitExcel> RogueMagicUnitData { get; private set; } = new Dictionary<int, RogueMagicUnitExcel>();

	public static Dictionary<int, RogueMagicTalentExcel> RogueMagicTalentData { get; private set; } = new Dictionary<int, RogueMagicTalentExcel>();

	public static List<RogueMagicRoomConfig> RogueMagicRoomGenData { get; set; } = new List<RogueMagicRoomConfig>();

	public static Dictionary<int, int> RogueMagicLayerIdRoomCountDict { get; set; } = new Dictionary<int, int>();

	public static Dictionary<uint, RogueDialogueEventConfig> MagicRogueDialogueEventConfig { get; private set; } = new Dictionary<uint, RogueDialogueEventConfig>();

	public static Dictionary<int, MatchThreeLevelExcel> MatchThreeLevelData { get; private set; } = new Dictionary<int, MatchThreeLevelExcel>();

	public static Dictionary<int, MatchThreeBirdExcel> MatchThreeBirdData { get; private set; } = new Dictionary<int, MatchThreeBirdExcel>();

	public static Dictionary<int, TutorialDataExcel> TutorialDataData { get; private set; } = new Dictionary<int, TutorialDataExcel>();

	public static Dictionary<int, TutorialGuideDataExcel> TutorialGuideDataData { get; private set; } = new Dictionary<int, TutorialGuideDataExcel>();

	public static void GetFloorInfo(int planeId, int floorId, out FloorInfo outer)
	{
		FloorInfoData.TryGetValue("P" + planeId + "_F" + floorId, out outer);
	}

	public static FloorInfo? GetFloorInfo(int floorId)
	{
		KeyValuePair<int, MapEntranceExcel> keyValuePair = MapEntranceData.FirstOrDefault<KeyValuePair<int, MapEntranceExcel>>((KeyValuePair<int, MapEntranceExcel> x) => x.Value.FloorID == floorId);
		if (keyValuePair.Value == null)
		{
			return null;
		}
		GetFloorInfo(keyValuePair.Value.PlaneID, floorId, out FloorInfo outer);
		return outer;
	}

	public static int GetPlayerExpRequired(int level)
	{
		PlayerLevelConfigExcel playerLevelConfigExcel = PlayerLevelConfigData[level];
		PlayerLevelConfigExcel playerLevelConfigExcel2 = PlayerLevelConfigData[level - 1];
		if (playerLevelConfigExcel == null || playerLevelConfigExcel2 == null)
		{
			return 0;
		}
		return playerLevelConfigExcel.PlayerExp - playerLevelConfigExcel2.PlayerExp;
	}

	public static int GetAvatarExpRequired(int group, int level)
	{
		ExpTypeData.TryGetValue(group * 100 + level, out ExpTypeExcel value);
		return value?.Exp ?? 0;
	}

	public static int GetEquipmentExpRequired(int group, int level)
	{
		EquipmentExpTypeData.TryGetValue(group * 100 + level, out EquipmentExpTypeExcel value);
		return value?.Exp ?? 0;
	}

	public static int GetMinPromotionForLevel(int level)
	{
		return Math.Max(Math.Min((int)((double)(level - 11) / 10.0), 6), 0);
	}

	public static int GetCurrentChallengePeakGroupId()
	{
		if (ChallengePeakOverrideConfig.ChallengePeak.Count > 0)
		{
			return ChallengePeakOverrideConfig.ChallengePeak.Max((ChallengePeakGroupOverride x) => x.GroupId);
		}
		if (ChallengePeakGroupConfigData.Count > 0)
		{
			return ChallengePeakGroupConfigData.Keys.Max();
		}
		return 1;
	}
}
