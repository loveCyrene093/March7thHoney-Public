using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum Retcode
{
	[OriginalName("RET_SUCC")]
	RetSucc = 0,
	[OriginalName("RET_FAIL")]
	RetFail = 1,
	[OriginalName("RET_SERVER_INTERNAL_ERROR")]
	RetServerInternalError = 2,
	[OriginalName("RET_TIMEOUT")]
	RetTimeout = 3,
	[OriginalName("RET_REPEATED_REQ")]
	RetRepeatedReq = 4,
	[OriginalName("RET_REQ_PARA_INVALID")]
	RetReqParaInvalid = 5,
	[OriginalName("RET_PLAYER_DATA_ERROR")]
	RetPlayerDataError = 6,
	[OriginalName("RET_PLAYER_CLIENT_PAUSED")]
	RetPlayerClientPaused = 7,
	[OriginalName("RET_FUNC_CHECK_FAILED")]
	RetFuncCheckFailed = 8,
	[OriginalName("RET_FEATURE_SWITCH_CLOSED")]
	RetFeatureSwitchClosed = 9,
	[OriginalName("RET_FREQ_OVER_LIMIT")]
	RetFreqOverLimit = 10,
	[OriginalName("RET_SYSTEM_BUSY")]
	RetSystemBusy = 11,
	[OriginalName("RET_PLAYER_NOT_ONLINE")]
	RetPlayerNotOnline = 12,
	[OriginalName("RET_OPERATION_IN_CD")]
	RetOperationInCd = 13,
	[OriginalName("RET_REPEATE_LOGIN")]
	RetRepeateLogin = 1000,
	[OriginalName("RET_RETRY_LOGIN")]
	RetRetryLogin = 1001,
	[OriginalName("RET_WAIT_LOGIN")]
	RetWaitLogin = 1002,
	[OriginalName("RET_NOT_IN_WHITE_LIST")]
	RetNotInWhiteList = 1003,
	[OriginalName("RET_IN_BLACK_LIST")]
	RetInBlackList = 1004,
	[OriginalName("RET_ACCOUNT_VERIFY_ERROR")]
	RetAccountVerifyError = 1005,
	[OriginalName("RET_ACCOUNT_PARA_ERROR")]
	RetAccountParaError = 1006,
	[OriginalName("RET_ANTI_ADDICT_LOGIN")]
	RetAntiAddictLogin = 1007,
	[OriginalName("RET_CHECK_SUM_ERROR")]
	RetCheckSumError = 1008,
	[OriginalName("RET_REACH_MAX_PLAYER_NUM")]
	RetReachMaxPlayerNum = 1009,
	[OriginalName("RET_ALREADY_REGISTERED")]
	RetAlreadyRegistered = 1010,
	[OriginalName("RET_GENDER_ERROR")]
	RetGenderError = 1011,
	[OriginalName("SET_NICKNAME_RET_CALLBACK_PROCESSING")]
	SetNicknameRetCallbackProcessing = 1012,
	[OriginalName("RET_IN_GM_BIND_ACCESS")]
	RetInGmBindAccess = 1013,
	[OriginalName("RET_QUEST_REWARD_ALREADY_TAKEN")]
	RetQuestRewardAlreadyTaken = 1100,
	[OriginalName("RET_QUEST_NOT_ACCEPT")]
	RetQuestNotAccept = 1101,
	[OriginalName("RET_QUEST_NOT_FINISH")]
	RetQuestNotFinish = 1102,
	[OriginalName("RET_QUEST_STATUS_ERROR")]
	RetQuestStatusError = 1103,
	[OriginalName("RET_ACHIEVEMENT_LEVEL_NOT_REACH")]
	RetAchievementLevelNotReach = 1104,
	[OriginalName("RET_ACHIEVEMENT_LEVEL_ALREADY_TAKEN")]
	RetAchievementLevelAlreadyTaken = 1105,
	[OriginalName("RET_AVATAR_NOT_EXIST")]
	RetAvatarNotExist = 1200,
	[OriginalName("RET_AVATAR_RES_EXP_NOT_ENOUGH")]
	RetAvatarResExpNotEnough = 1201,
	[OriginalName("RET_AVATAR_EXP_REACH_PROMOTION_LIMIT")]
	RetAvatarExpReachPromotionLimit = 1202,
	[OriginalName("RET_AVATAR_REACH_MAX_PROMOTION")]
	RetAvatarReachMaxPromotion = 1203,
	[OriginalName("RET_SKILLTREE_CONFIG_NOT_EXIST")]
	RetSkilltreeConfigNotExist = 1204,
	[OriginalName("RET_SKILLTREE_ALREADY_UNLOCK")]
	RetSkilltreeAlreadyUnlock = 1205,
	[OriginalName("RET_SKILLTREE_PRE_LOCKED")]
	RetSkilltreePreLocked = 1206,
	[OriginalName("RET_SKILLTREE_LEVEL_NOT_MEET")]
	RetSkilltreeLevelNotMeet = 1207,
	[OriginalName("RET_SKILLTREE_RANK_NOT_MEET")]
	RetSkilltreeRankNotMeet = 1208,
	[OriginalName("RET_AVATAR_DRESS_NO_EQUIPMENT")]
	RetAvatarDressNoEquipment = 1209,
	[OriginalName("RET_AVATAR_EXP_ITEM_NOT_EXIST")]
	RetAvatarExpItemNotExist = 1210,
	[OriginalName("RET_SKILLTREE_POINT_LOCKED")]
	RetSkilltreePointLocked = 1211,
	[OriginalName("RET_SKILLTREE_POINT_LEVEL_UPGRADE_NOT_MATCH")]
	RetSkilltreePointLevelUpgradeNotMatch = 1212,
	[OriginalName("RET_SKILLTREE_POINT_LEVEL_REACH_MAX")]
	RetSkilltreePointLevelReachMax = 1213,
	[OriginalName("RET_WORLD_LEVEL_NOT_MEET")]
	RetWorldLevelNotMeet = 1214,
	[OriginalName("RET_PLAYER_LEVEL_NOT_MEET")]
	RetPlayerLevelNotMeet = 1215,
	[OriginalName("RET_AVATAR_RANK_NOT_MATCH")]
	RetAvatarRankNotMatch = 1216,
	[OriginalName("RET_AVATAR_RANK_REACH_MAX")]
	RetAvatarRankReachMax = 1217,
	[OriginalName("RET_HERO_BASIC_TYPE_NOT_MATCH")]
	RetHeroBasicTypeNotMatch = 1218,
	[OriginalName("RET_AVATAR_PROMOTION_NOT_MEET")]
	RetAvatarPromotionNotMeet = 1219,
	[OriginalName("RET_PROMOTION_REWARD_CONFIG_NOT_EXIST")]
	RetPromotionRewardConfigNotExist = 1220,
	[OriginalName("RET_PROMOTION_REWARD_ALREADY_TAKEN")]
	RetPromotionRewardAlreadyTaken = 1221,
	[OriginalName("RET_AVATAR_SKIN_ITEM_NOT_EXIST")]
	RetAvatarSkinItemNotExist = 1222,
	[OriginalName("RET_AVATAR_SKIN_ALREADY_DRESSED")]
	RetAvatarSkinAlreadyDressed = 1223,
	[OriginalName("RET_AVATAR_NOT_DRESS_SKIN")]
	RetAvatarNotDressSkin = 1224,
	[OriginalName("RET_AVATAR_SKIN_NOT_MATCH_AVATAR")]
	RetAvatarSkinNotMatchAvatar = 1225,
	[OriginalName("RET_AVATAR_PATH_NOT_MATCH")]
	RetAvatarPathNotMatch = 1226,
	[OriginalName("RET_AVATAR_ENHANCED_ID_NOT_EXIST")]
	RetAvatarEnhancedIdNotExist = 1227,
	[OriginalName("RET_AVATAR_ENHANCED_ID_ALREADY_SET")]
	RetAvatarEnhancedIdAlreadySet = 1228,
	[OriginalName("RET_AVATAR_NOT_CUR_ENHANCED_ID")]
	RetAvatarNotCurEnhancedId = 1229,
	[OriginalName("RET_PLAYER_OUTFIT_CONFIG_NOT_EXIST")]
	RetPlayerOutfitConfigNotExist = 1230,
	[OriginalName("RET_PLAYER_OUTFIT_SLOT_CONFLICT")]
	RetPlayerOutfitSlotConflict = 1231,
	[OriginalName("RET_PLAYER_OUTFIT_IS_DEFAULT")]
	RetPlayerOutfitIsDefault = 1232,
	[OriginalName("RET_PLAYER_OUTFIT_NOT_OWNED")]
	RetPlayerOutfitNotOwned = 1233,
	[OriginalName("RET_SKILLTREE_FAST_LEVEL_UP_CLOSE")]
	RetSkilltreeFastLevelUpClose = 1234,
	[OriginalName("RET_ITEM_NOT_EXIST")]
	RetItemNotExist = 1300,
	[OriginalName("RET_ITEM_COST_NOT_ENOUGH")]
	RetItemCostNotEnough = 1301,
	[OriginalName("RET_ITEM_COST_TOO_MUCH")]
	RetItemCostTooMuch = 1302,
	[OriginalName("RET_ITEM_NO_COST")]
	RetItemNoCost = 1303,
	[OriginalName("RET_ITEM_NOT_ENOUGH")]
	RetItemNotEnough = 1304,
	[OriginalName("RET_ITEM_INVALID")]
	RetItemInvalid = 1305,
	[OriginalName("RET_ITEM_CONFIG_NOT_EXIST")]
	RetItemConfigNotExist = 1306,
	[OriginalName("RET_SCOIN_NOT_ENOUGH")]
	RetScoinNotEnough = 1307,
	[OriginalName("RET_ITEM_REWARD_EXCEED_LIMIT")]
	RetItemRewardExceedLimit = 1308,
	[OriginalName("RET_ITEM_INVALID_USE")]
	RetItemInvalidUse = 1309,
	[OriginalName("RET_ITEM_USE_CONFIG_NOT_EXIST")]
	RetItemUseConfigNotExist = 1310,
	[OriginalName("RET_REWARD_CONFIG_NOT_EXIST")]
	RetRewardConfigNotExist = 1311,
	[OriginalName("RET_ITEM_EXCEED_LIMIT")]
	RetItemExceedLimit = 1312,
	[OriginalName("RET_ITEM_COUNT_INVALID")]
	RetItemCountInvalid = 1313,
	[OriginalName("RET_ITEM_USE_TARGET_TYPE_INVALID")]
	RetItemUseTargetTypeInvalid = 1314,
	[OriginalName("RET_ITEM_USE_SATIETY_FULL")]
	RetItemUseSatietyFull = 1315,
	[OriginalName("RET_ITEM_COMPOSE_NOT_EXIST")]
	RetItemComposeNotExist = 1316,
	[OriginalName("RET_RELIC_COMPOSE_NOT_EXIST")]
	RetRelicComposeNotExist = 1317,
	[OriginalName("RET_ITEM_CAN_NOT_SELL")]
	RetItemCanNotSell = 1318,
	[OriginalName("RET_ITEM_SELL_EXCEDD_LIMIT")]
	RetItemSellExceddLimit = 1319,
	[OriginalName("RET_ITEM_NOT_IN_COST_LIST")]
	RetItemNotInCostList = 1320,
	[OriginalName("RET_ITEM_SPECIAL_COST_NOT_ENOUGH")]
	RetItemSpecialCostNotEnough = 1321,
	[OriginalName("RET_ITEM_SPECIAL_COST_TOO_MUCH")]
	RetItemSpecialCostTooMuch = 1322,
	[OriginalName("RET_ITEM_FORMULA_NOT_EXIST")]
	RetItemFormulaNotExist = 1323,
	[OriginalName("RET_ITEM_AUTO_GIFT_OPTIONAL_NOT_EXIST")]
	RetItemAutoGiftOptionalNotExist = 1324,
	[OriginalName("RET_RELIC_COMPOSE_RELIC_INVALID")]
	RetRelicComposeRelicInvalid = 1325,
	[OriginalName("RET_RELIC_COMPOSE_MAIN_AFFIX_ID_INVALID")]
	RetRelicComposeMainAffixIdInvalid = 1326,
	[OriginalName("RET_RELIC_COMPOSE_WRONG_FORMULA_TYPE")]
	RetRelicComposeWrongFormulaType = 1327,
	[OriginalName("RET_RELIC_COMPOSE_RELIC_NOT_EXIST")]
	RetRelicComposeRelicNotExist = 1328,
	[OriginalName("RET_RELIC_COMPOSE_BLACK_GOLD_COUNT_INVALID")]
	RetRelicComposeBlackGoldCountInvalid = 1329,
	[OriginalName("RET_RELIC_COMPOSE_BLACK_GOLD_NOT_NEED")]
	RetRelicComposeBlackGoldNotNeed = 1330,
	[OriginalName("RET_MONTH_CARD_CANNOT_USE")]
	RetMonthCardCannotUse = 1331,
	[OriginalName("RET_ITEM_REWARD_EXCEED_DISAPPEAR")]
	RetItemRewardExceedDisappear = 1332,
	[OriginalName("RET_ITEM_NEED_RECYCLE")]
	RetItemNeedRecycle = 1333,
	[OriginalName("RET_ITEM_COMPOSE_EXCEED_LIMIT")]
	RetItemComposeExceedLimit = 1334,
	[OriginalName("RET_ITEM_CAN_NOT_DESTROY")]
	RetItemCanNotDestroy = 1335,
	[OriginalName("RET_ITEM_ALREADY_MARK")]
	RetItemAlreadyMark = 1336,
	[OriginalName("RET_ITEM_MARK_EXCEED_LIMIT")]
	RetItemMarkExceedLimit = 1337,
	[OriginalName("RET_ITEM_NOT_MARK")]
	RetItemNotMark = 1338,
	[OriginalName("RET_ITEN_TURN_FOOD_NOT_SET")]
	RetItenTurnFoodNotSet = 1339,
	[OriginalName("RET_ITEM_TURN_FOOD_ALREADY_SET")]
	RetItemTurnFoodAlreadySet = 1340,
	[OriginalName("RET_ITEM_TURN_FOOD_CONSUME_TYPE_ERROR")]
	RetItemTurnFoodConsumeTypeError = 1341,
	[OriginalName("RET_ITEM_TURN_FOOD_SWITCH_ALREADY_OPEN")]
	RetItemTurnFoodSwitchAlreadyOpen = 1342,
	[OriginalName("RET_ITEM_TURN_FOOD_SWITCH_ALREADY_CLOSE")]
	RetItemTurnFoodSwitchAlreadyClose = 1343,
	[OriginalName("RET_HCOIN_EXCHANGE_TOO_MUCH")]
	RetHcoinExchangeTooMuch = 1344,
	[OriginalName("RET_ITEM_TURN_FOOD_SCENE_TYPE_ERROR")]
	RetItemTurnFoodSceneTypeError = 1345,
	[OriginalName("RET_EQUIPMENT_ALREADY_DRESSED")]
	RetEquipmentAlreadyDressed = 1350,
	[OriginalName("RET_EQUIPMENT_NOT_EXIST")]
	RetEquipmentNotExist = 1351,
	[OriginalName("RET_EQUIPMENT_REACH_LEVEL_LIMIT")]
	RetEquipmentReachLevelLimit = 1352,
	[OriginalName("RET_EQUIPMENT_CONSUME_SELF")]
	RetEquipmentConsumeSelf = 1353,
	[OriginalName("RET_EQUIPMENT_ALREADY_LOCKED")]
	RetEquipmentAlreadyLocked = 1354,
	[OriginalName("RET_EQUIPMENT_ALREADY_UNLOCKED")]
	RetEquipmentAlreadyUnlocked = 1355,
	[OriginalName("RET_EQUIPMENT_LOCKED")]
	RetEquipmentLocked = 1356,
	[OriginalName("RET_EQUIPMENT_SELECT_NUM_OVER_LIMIT")]
	RetEquipmentSelectNumOverLimit = 1357,
	[OriginalName("RET_EQUIPMENT_RANK_UP_MUST_CONSUME_SAME_TID")]
	RetEquipmentRankUpMustConsumeSameTid = 1358,
	[OriginalName("RET_EQUIPMENT_PROMOTION_REACH_MAX")]
	RetEquipmentPromotionReachMax = 1359,
	[OriginalName("RET_EQUIPMENT_RANK_UP_REACH_MAX")]
	RetEquipmentRankUpReachMax = 1360,
	[OriginalName("RET_EQUIPMENT_LEVEL_REACH_MAX")]
	RetEquipmentLevelReachMax = 1361,
	[OriginalName("RET_EQUIPMENT_EXCEED_LIMIT")]
	RetEquipmentExceedLimit = 1362,
	[OriginalName("RET_RELIC_NOT_EXIST")]
	RetRelicNotExist = 1363,
	[OriginalName("RET_RELIC_REACH_LEVEL_LIMIT")]
	RetRelicReachLevelLimit = 1364,
	[OriginalName("RET_RELIC_CONSUME_SELF")]
	RetRelicConsumeSelf = 1365,
	[OriginalName("RET_RELIC_ALREADY_DRESSED")]
	RetRelicAlreadyDressed = 1366,
	[OriginalName("RET_RELIC_LOCKED")]
	RetRelicLocked = 1367,
	[OriginalName("RET_RELIC_ALREADY_LOCKED")]
	RetRelicAlreadyLocked = 1368,
	[OriginalName("RET_RELIC_ALREADY_UNLOCKED")]
	RetRelicAlreadyUnlocked = 1369,
	[OriginalName("RET_RELIC_LEVEL_IS_NOT_ZERO")]
	RetRelicLevelIsNotZero = 1370,
	[OriginalName("RET_UNIQUE_ID_REPEATED")]
	RetUniqueIdRepeated = 1371,
	[OriginalName("RET_EQUIPMENT_LEVEL_NOT_MEET")]
	RetEquipmentLevelNotMeet = 1372,
	[OriginalName("RET_EQUIPMENT_ITEM_NOT_IN_COST_LIST")]
	RetEquipmentItemNotInCostList = 1373,
	[OriginalName("RET_EQUIPMENT_LEVEL_GREATER_THAN_ONE")]
	RetEquipmentLevelGreaterThanOne = 1374,
	[OriginalName("RET_EQUIPMENT_ALREADY_RANKED")]
	RetEquipmentAlreadyRanked = 1375,
	[OriginalName("RET_RELIC_EXCEED_LIMIT")]
	RetRelicExceedLimit = 1376,
	[OriginalName("RET_RELIC_ALREADY_DISCARDED")]
	RetRelicAlreadyDiscarded = 1377,
	[OriginalName("RET_RELIC_ALREADY_UNDISCARDED")]
	RetRelicAlreadyUndiscarded = 1378,
	[OriginalName("RET_EQUIPMENT_BATCH_LOCK_TOO_FAST")]
	RetEquipmentBatchLockTooFast = 1379,
	[OriginalName("RET_RELIC_FILTER_PLAN_SLOT_EMPTY")]
	RetRelicFilterPlanSlotEmpty = 1380,
	[OriginalName("RET_RELIC_FILTER_PLAN_NUM_EXCEED_LIMIT")]
	RetRelicFilterPlanNumExceedLimit = 1381,
	[OriginalName("RET_RELIC_FILTER_PLAN_NAME_UTF8_ERROR")]
	RetRelicFilterPlanNameUtf8Error = 1382,
	[OriginalName("RET_RELIC_FILTER_PLAN_NAME_FORMAT_ERROR")]
	RetRelicFilterPlanNameFormatError = 1383,
	[OriginalName("RET_RELIC_FILTER_PLAN_NO_CHANGE")]
	RetRelicFilterPlanNoChange = 1384,
	[OriginalName("RET_RELIC_REFORGE_NOT_CONFIRMED")]
	RetRelicReforgeNotConfirmed = 1385,
	[OriginalName("RET_EQUIPMENT_ALREADY_LEVELUP")]
	RetEquipmentAlreadyLevelup = 1386,
	[OriginalName("RET_EQUIPMENT_RARITY_ERROR")]
	RetEquipmentRarityError = 1387,
	[OriginalName("RET_LINEUP_INVALID_INDEX")]
	RetLineupInvalidIndex = 1400,
	[OriginalName("RET_LINEUP_INVALID_MEMBER_POS")]
	RetLineupInvalidMemberPos = 1401,
	[OriginalName("RET_LINEUP_SWAP_NOT_EXIST")]
	RetLineupSwapNotExist = 1402,
	[OriginalName("RET_LINEUP_AVATAR_ALREADY_IN")]
	RetLineupAvatarAlreadyIn = 1403,
	[OriginalName("RET_LINEUP_CREATE_AVATAR_ERROR")]
	RetLineupCreateAvatarError = 1404,
	[OriginalName("RET_LINEUP_AVATAR_INIT_ERROR")]
	RetLineupAvatarInitError = 1405,
	[OriginalName("RET_LINEUP_NOT_EXIST")]
	RetLineupNotExist = 1406,
	[OriginalName("RET_LINEUP_ONLY_ONE_MEMBER")]
	RetLineupOnlyOneMember = 1407,
	[OriginalName("RET_LINEUP_SAME_LEADER_SLOT")]
	RetLineupSameLeaderSlot = 1408,
	[OriginalName("RET_LINEUP_NO_LEADER_SELECT")]
	RetLineupNoLeaderSelect = 1409,
	[OriginalName("RET_LINEUP_SWAP_SAME_SLOT")]
	RetLineupSwapSameSlot = 1410,
	[OriginalName("RET_LINEUP_AVATAR_NOT_EXIST")]
	RetLineupAvatarNotExist = 1411,
	[OriginalName("RET_LINEUP_TRIAL_AVATAR_CAN_NOT_QUIT")]
	RetLineupTrialAvatarCanNotQuit = 1412,
	[OriginalName("RET_LINEUP_VIRTUAL_LINEUP_PLANE_NOT_MATCH")]
	RetLineupVirtualLineupPlaneNotMatch = 1413,
	[OriginalName("RET_LINEUP_NOT_VALID_LEADER")]
	RetLineupNotValidLeader = 1414,
	[OriginalName("RET_LINEUP_SAME_INDEX")]
	RetLineupSameIndex = 1415,
	[OriginalName("RET_LINEUP_IS_EMPTY")]
	RetLineupIsEmpty = 1416,
	[OriginalName("RET_LINEUP_NAME_FORMAT_ERROR")]
	RetLineupNameFormatError = 1417,
	[OriginalName("RET_LINEUP_TYPE_NOT_MATCH")]
	RetLineupTypeNotMatch = 1418,
	[OriginalName("RET_LINEUP_REPLACE_ALL_FAILED")]
	RetLineupReplaceAllFailed = 1419,
	[OriginalName("RET_LINEUP_NOT_ALLOW_EDIT")]
	RetLineupNotAllowEdit = 1420,
	[OriginalName("RET_LINEUP_AVATAR_IS_ALIVE")]
	RetLineupAvatarIsAlive = 1421,
	[OriginalName("RET_LINEUP_ASSIST_HAS_ONLY_MEMBER")]
	RetLineupAssistHasOnlyMember = 1422,
	[OriginalName("RET_LINEUP_ASSIST_CANNOT_SWITCH")]
	RetLineupAssistCannotSwitch = 1423,
	[OriginalName("RET_LINEUP_AVATAR_TYPE_INVALID")]
	RetLineupAvatarTypeInvalid = 1424,
	[OriginalName("RET_LINEUP_NAME_UTF8_ERROR")]
	RetLineupNameUtf8Error = 1425,
	[OriginalName("RET_LINEUP_LEADER_LOCK")]
	RetLineupLeaderLock = 1426,
	[OriginalName("RET_LINEUP_STORY_LINE_NOT_MATCH")]
	RetLineupStoryLineNotMatch = 1427,
	[OriginalName("RET_LINEUP_AVATAR_LOCK")]
	RetLineupAvatarLock = 1428,
	[OriginalName("RET_LINEUP_AVATAR_INVALID")]
	RetLineupAvatarInvalid = 1429,
	[OriginalName("RET_LINEUP_AVATAR_ALREADY_INIT")]
	RetLineupAvatarAlreadyInit = 1430,
	[OriginalName("RET_LINEUP_LIMITED")]
	RetLineupLimited = 1431,
	[OriginalName("RET_MAIL_NOT_EXIST")]
	RetMailNotExist = 1700,
	[OriginalName("RET_MAIL_RANGE_INVALID")]
	RetMailRangeInvalid = 1701,
	[OriginalName("RET_MAIL_MAIL_ID_INVALID")]
	RetMailMailIdInvalid = 1702,
	[OriginalName("RET_MAIL_NO_MAIL_TAKE_ATTACHMENT")]
	RetMailNoMailTakeAttachment = 1703,
	[OriginalName("RET_MAIL_NO_MAIL_TO_DEL")]
	RetMailNoMailToDel = 1704,
	[OriginalName("RET_MAIL_TYPE_INVALID")]
	RetMailTypeInvalid = 1705,
	[OriginalName("RET_MAIL_PARA_INVALID")]
	RetMailParaInvalid = 1706,
	[OriginalName("RET_MAIL_ATTACHEMENT_INVALID")]
	RetMailAttachementInvalid = 1707,
	[OriginalName("RET_MAIL_TICKET_INVALID")]
	RetMailTicketInvalid = 1708,
	[OriginalName("RET_MAIL_TICKET_REPEATED")]
	RetMailTicketRepeated = 1709,
	[OriginalName("RET_STAGE_SETTLE_ERROR")]
	RetStageSettleError = 1800,
	[OriginalName("RET_STAGE_CONFIG_NOT_EXIST")]
	RetStageConfigNotExist = 1801,
	[OriginalName("RET_STAGE_NOT_FOUND")]
	RetStageNotFound = 1802,
	[OriginalName("RET_STAGE_COCOON_PROP_NOT_VALID")]
	RetStageCocoonPropNotValid = 1804,
	[OriginalName("RET_STAGE_COCOON_WAVE_NOT_VALID")]
	RetStageCocoonWaveNotValid = 1805,
	[OriginalName("RET_STAGE_PROP_ID_NOT_EQUAL")]
	RetStagePropIdNotEqual = 1806,
	[OriginalName("RET_STAGE_COCOON_WAVE_OVER")]
	RetStageCocoonWaveOver = 1807,
	[OriginalName("RET_STAGE_WEEK_COCOON_OVER_CNT")]
	RetStageWeekCocoonOverCnt = 1808,
	[OriginalName("RET_STAGE_COCOON_NOT_OPEN")]
	RetStageCocoonNotOpen = 1809,
	[OriginalName("RET_STAGE_TRIAL_NOT_OPEN")]
	RetStageTrialNotOpen = 1810,
	[OriginalName("RET_STAGE_FARM_NOT_OPEN")]
	RetStageFarmNotOpen = 1811,
	[OriginalName("RET_STAGE_FARM_TYPE_ERROR")]
	RetStageFarmTypeError = 1812,
	[OriginalName("RET_STAGE_FARM_SWEEP_CD")]
	RetStageFarmSweepCd = 1813,
	[OriginalName("RET_STAGE_FARM_ELEMENT_CHALLENGE_CNT_INVALID")]
	RetStageFarmElementChallengeCntInvalid = 1814,
	[OriginalName("RET_CHAPTER_LOCK")]
	RetChapterLock = 1900,
	[OriginalName("RET_CHAPTER_CHALLENGE_NUM_NOT_ENOUGH")]
	RetChapterChallengeNumNotEnough = 1901,
	[OriginalName("RET_CHAPTER_REWARD_ID_NOT_EXIST")]
	RetChapterRewardIdNotExist = 1902,
	[OriginalName("RET_CHAPTER_REWARD_ALREADY_TAKEN")]
	RetChapterRewardAlreadyTaken = 1903,
	[OriginalName("RET_BATTLE_STAGE_NOT_MATCH")]
	RetBattleStageNotMatch = 2000,
	[OriginalName("RET_IN_BATTLE_NOW")]
	RetInBattleNow = 2001,
	[OriginalName("RET_BATTLE_CHEAT")]
	RetBattleCheat = 2002,
	[OriginalName("RET_BATTLE_FAIL")]
	RetBattleFail = 2003,
	[OriginalName("RET_BATTLE_NO_LINEUP")]
	RetBattleNoLineup = 2004,
	[OriginalName("RET_BATTLE_LINEUP_EMPTY")]
	RetBattleLineupEmpty = 2005,
	[OriginalName("RET_BATTLE_VERSION_NOT_MATCH")]
	RetBattleVersionNotMatch = 2006,
	[OriginalName("RET_BATTLE_QUIT_BY_SERVER")]
	RetBattleQuitByServer = 2007,
	[OriginalName("RET_IN_BATTLE_CHECK")]
	RetInBattleCheck = 2008,
	[OriginalName("RET_BATTLE_CHECK_NEED_RETRY")]
	RetBattleCheckNeedRetry = 2009,
	[OriginalName("RET_BATTLE_COST_TIME_CHECK_FAIL")]
	RetBattleCostTimeCheckFail = 2010,
	[OriginalName("RET_LACK_EXCHANGE_STAMINA_TIMES")]
	RetLackExchangeStaminaTimes = 2100,
	[OriginalName("RET_LACK_STAMINA")]
	RetLackStamina = 2101,
	[OriginalName("RET_STAMINA_FULL")]
	RetStaminaFull = 2102,
	[OriginalName("RET_AUTHKEY_SIGN_TYPE_ERROR")]
	RetAuthkeySignTypeError = 2103,
	[OriginalName("RET_AUTHKEY_SIGN_VER_ERROR")]
	RetAuthkeySignVerError = 2104,
	[OriginalName("RET_NICKNAME_FORMAT_ERROR")]
	RetNicknameFormatError = 2105,
	[OriginalName("RET_SENSITIVE_WORDS")]
	RetSensitiveWords = 2106,
	[OriginalName("RET_LEVEL_REWARD_HAS_TAKEN")]
	RetLevelRewardHasTaken = 2107,
	[OriginalName("RET_LEVEL_REWARD_LEVEL_ERROR")]
	RetLevelRewardLevelError = 2108,
	[OriginalName("RET_LANGUAGE_INVALID")]
	RetLanguageInvalid = 2109,
	[OriginalName("RET_NICKNAME_IN_CD")]
	RetNicknameInCd = 2110,
	[OriginalName("RET_GAMEPLAY_BIRTHDAY_INVALID")]
	RetGameplayBirthdayInvalid = 2111,
	[OriginalName("RET_GAMEPLAY_BIRTHDAY_ALREADY_SET")]
	RetGameplayBirthdayAlreadySet = 2112,
	[OriginalName("RET_NICKNAME_UTF8_ERROR")]
	RetNicknameUtf8Error = 2113,
	[OriginalName("RET_NICKNAME_DIGIT_LIMIT_ERROR")]
	RetNicknameDigitLimitError = 2114,
	[OriginalName("RET_SENSITIVE_WORDS_PLATFORM_ERROR")]
	RetSensitiveWordsPlatformError = 2115,
	[OriginalName("RET_PLAYER_SETTING_TYPE_INVALID")]
	RetPlayerSettingTypeInvalid = 2116,
	[OriginalName("RET_MAZE_LACK_TICKET")]
	RetMazeLackTicket = 2201,
	[OriginalName("RET_MAZE_NOT_UNLOCK")]
	RetMazeNotUnlock = 2202,
	[OriginalName("RET_MAZE_NO_ABILITY")]
	RetMazeNoAbility = 2204,
	[OriginalName("RET_MAZE_NO_PLANE")]
	RetMazeNoPlane = 2205,
	[OriginalName("RET_MAZE_MAP_NOT_EXIST")]
	RetMazeMapNotExist = 2207,
	[OriginalName("RET_MAZE_MP_NOT_ENOUGH")]
	RetMazeMpNotEnough = 2213,
	[OriginalName("RET_SPRING_NOT_ENABLE")]
	RetSpringNotEnable = 2214,
	[OriginalName("RET_SPRING_TOO_FAR")]
	RetSpringTooFar = 2216,
	[OriginalName("RET_NOT_IN_MAZE")]
	RetNotInMaze = 2218,
	[OriginalName("RET_MAZE_TIME_OF_DAY_TYPE_ERROR")]
	RetMazeTimeOfDayTypeError = 2223,
	[OriginalName("RET_SCENE_TRANSFER_LOCKED_BY_TASK")]
	RetSceneTransferLockedByTask = 2224,
	[OriginalName("RET_PLOT_NOT_UNLOCK")]
	RetPlotNotUnlock = 2300,
	[OriginalName("RET_MISSION_NOT_EXIST")]
	RetMissionNotExist = 2400,
	[OriginalName("RET_MISSION_ALREADY_DONE")]
	RetMissionAlreadyDone = 2401,
	[OriginalName("RET_DAILY_TASK_NOT_FINISH")]
	RetDailyTaskNotFinish = 2402,
	[OriginalName("RET_DAILY_TASK_REWARD_HAS_TAKEN")]
	RetDailyTaskRewardHasTaken = 2403,
	[OriginalName("RET_MISSION_NOT_FINISH")]
	RetMissionNotFinish = 2404,
	[OriginalName("RET_MISSION_NOT_DOING")]
	RetMissionNotDoing = 2405,
	[OriginalName("RET_MISSION_FINISH_WAY_NOT_MATCH")]
	RetMissionFinishWayNotMatch = 2406,
	[OriginalName("RET_MISSION_SCENE_NOT_MATCH")]
	RetMissionSceneNotMatch = 2407,
	[OriginalName("RET_MISSION_CUSTOM_VALUE_NOT_VALID")]
	RetMissionCustomValueNotValid = 2408,
	[OriginalName("RET_MISSION_SUB_MISSION_NOT_MATCH")]
	RetMissionSubMissionNotMatch = 2409,
	[OriginalName("RET_ADVENTURE_MAP_NOT_EXIST")]
	RetAdventureMapNotExist = 2500,
	[OriginalName("RET_SCENE_ENTITY_NOT_EXIST")]
	RetSceneEntityNotExist = 2600,
	[OriginalName("RET_NOT_IN_SCENE")]
	RetNotInScene = 2601,
	[OriginalName("RET_SCENE_MONSTER_NOT_EXIST")]
	RetSceneMonsterNotExist = 2602,
	[OriginalName("RET_INTERACT_CONFIG_NOT_EXIST")]
	RetInteractConfigNotExist = 2603,
	[OriginalName("RET_UNSUPPORTED_PROP_STATE")]
	RetUnsupportedPropState = 2604,
	[OriginalName("RET_SCENE_ENTRY_ID_NOT_MATCH")]
	RetSceneEntryIdNotMatch = 2605,
	[OriginalName("RET_SCENE_ENTITY_MOVE_CHECK_FAILED")]
	RetSceneEntityMoveCheckFailed = 2606,
	[OriginalName("RET_ASSIST_MONSTER_COUNT_LIMIT")]
	RetAssistMonsterCountLimit = 2607,
	[OriginalName("RET_SCENE_USE_SKILL_FAIL")]
	RetSceneUseSkillFail = 2608,
	[OriginalName("RET_PROP_IS_HIDDEN")]
	RetPropIsHidden = 2609,
	[OriginalName("RET_LOADING_SUCC_ALREADY")]
	RetLoadingSuccAlready = 2610,
	[OriginalName("RET_SCENE_ENTITY_TYPE_INVALID")]
	RetSceneEntityTypeInvalid = 2611,
	[OriginalName("RET_INTERACT_TYPE_INVALID")]
	RetInteractTypeInvalid = 2612,
	[OriginalName("RET_INTERACT_NOT_IN_REGION")]
	RetInteractNotInRegion = 2613,
	[OriginalName("RET_INTERACT_SUB_TYPE_INVALID")]
	RetInteractSubTypeInvalid = 2614,
	[OriginalName("RET_NOT_LEADER_ENTITY")]
	RetNotLeaderEntity = 2615,
	[OriginalName("RET_MONSTER_IS_NOT_FARM_ELEMENT")]
	RetMonsterIsNotFarmElement = 2616,
	[OriginalName("RET_MONSTER_CONFIG_NOT_EXIST")]
	RetMonsterConfigNotExist = 2617,
	[OriginalName("RET_AVATAR_HP_ALREADY_FULL")]
	RetAvatarHpAlreadyFull = 2618,
	[OriginalName("RET_CUR_INTERACT_ENTITY_NOT_MATCH")]
	RetCurInteractEntityNotMatch = 2619,
	[OriginalName("RET_PLANE_TYPE_NOT_ALLOW")]
	RetPlaneTypeNotAllow = 2620,
	[OriginalName("RET_GROUP_NOT_EXIST")]
	RetGroupNotExist = 2621,
	[OriginalName("RET_GROUP_SAVE_DATA_IN_CD")]
	RetGroupSaveDataInCd = 2622,
	[OriginalName("RET_GROUP_SAVE_LENGH_REACH_MAX")]
	RetGroupSaveLenghReachMax = 2623,
	[OriginalName("RET_RECENT_ELEMENT_NOT_EXIST")]
	RetRecentElementNotExist = 2624,
	[OriginalName("RET_RECENT_ELEMENT_STAGE_NOT_MATCH")]
	RetRecentElementStageNotMatch = 2625,
	[OriginalName("RET_SCENE_POSITION_VERSION_NOT_MATCH")]
	RetScenePositionVersionNotMatch = 2626,
	[OriginalName("RET_GAMEPLAY_COUNTER_NOT_EXIST")]
	RetGameplayCounterNotExist = 2627,
	[OriginalName("RET_GAMEPLAY_COUNTER_NOT_ENOUGH")]
	RetGameplayCounterNotEnough = 2628,
	[OriginalName("RET_GROUP_STATE_NOT_MATCH")]
	RetGroupStateNotMatch = 2629,
	[OriginalName("RET_SCENE_ENTITY_POS_NOT_MATCH")]
	RetSceneEntityPosNotMatch = 2630,
	[OriginalName("RET_GROUP_STATE_CUSTOM_SAVE_DATA_OFF")]
	RetGroupStateCustomSaveDataOff = 2631,
	[OriginalName("RET_SCENE_NOT_MATCH")]
	RetSceneNotMatch = 2632,
	[OriginalName("RET_PROP_TYPE_INVALID")]
	RetPropTypeInvalid = 2633,
	[OriginalName("RET_NOT_IN_CORRECT_SCENE")]
	RetNotInCorrectScene = 2634,
	[OriginalName("RET_NOT_IN_CORRECT_DIMENSION")]
	RetNotInCorrectDimension = 2635,
	[OriginalName("RET_NOT_CORRECT_GROUP_PROPERTY_NAME")]
	RetNotCorrectGroupPropertyName = 2636,
	[OriginalName("RET_BUY_TIMES_LIMIT")]
	RetBuyTimesLimit = 2700,
	[OriginalName("RET_BUY_LIMIT_TYPE")]
	RetBuyLimitType = 2701,
	[OriginalName("RET_SHOP_NOT_OPEN")]
	RetShopNotOpen = 2702,
	[OriginalName("RET_GOODS_NOT_OPEN")]
	RetGoodsNotOpen = 2703,
	[OriginalName("RET_CITY_LEVEL_REWARD_TAKEN")]
	RetCityLevelRewardTaken = 2704,
	[OriginalName("RET_CITY_LEVEL_NOT_MEET")]
	RetCityLevelNotMeet = 2705,
	[OriginalName("RET_SINGLE_BUY_LIMIT")]
	RetSingleBuyLimit = 2706,
	[OriginalName("RET_TUTORIAL_NOT_UNLOCK")]
	RetTutorialNotUnlock = 2751,
	[OriginalName("RET_TUTORIAL_UNLOCK_ALREADY")]
	RetTutorialUnlockAlready = 2752,
	[OriginalName("RET_TUTORIAL_FINISH_ALREADY")]
	RetTutorialFinishAlready = 2753,
	[OriginalName("RET_TUTORIAL_PRE_NOT_UNLOCK")]
	RetTutorialPreNotUnlock = 2754,
	[OriginalName("RET_TUTORIAL_PLAYER_LEVEL_NOT_MATCH")]
	RetTutorialPlayerLevelNotMatch = 2755,
	[OriginalName("RET_TUTORIAL_TUTORIAL_NOT_FOUND")]
	RetTutorialTutorialNotFound = 2756,
	[OriginalName("RET_CHALLENGE_NOT_EXIST")]
	RetChallengeNotExist = 2801,
	[OriginalName("RET_CHALLENGE_NOT_UNLOCK")]
	RetChallengeNotUnlock = 2802,
	[OriginalName("RET_CHALLENGE_ALREADY")]
	RetChallengeAlready = 2803,
	[OriginalName("RET_CHALLENGE_LINEUP_EDIT_FORBIDDEN")]
	RetChallengeLineupEditForbidden = 2804,
	[OriginalName("RET_CHALLENGE_LINEUP_EMPTY")]
	RetChallengeLineupEmpty = 2805,
	[OriginalName("RET_CHALLENGE_NOT_DOING")]
	RetChallengeNotDoing = 2806,
	[OriginalName("RET_CHALLENGE_NOT_FINISH")]
	RetChallengeNotFinish = 2807,
	[OriginalName("RET_CHALLENGE_TARGET_NOT_FINISH")]
	RetChallengeTargetNotFinish = 2808,
	[OriginalName("RET_CHALLENGE_TARGET_REWARD_TAKEN")]
	RetChallengeTargetRewardTaken = 2809,
	[OriginalName("RET_CHALLENGE_TIME_NOT_VALID")]
	RetChallengeTimeNotValid = 2810,
	[OriginalName("RET_CHALLENGE_STARS_COUNT_NOT_MEET")]
	RetChallengeStarsCountNotMeet = 2811,
	[OriginalName("RET_CHALLENGE_STARS_REWARD_TAKEN")]
	RetChallengeStarsRewardTaken = 2812,
	[OriginalName("RET_CHALLENGE_STARS_NOT_EXIST")]
	RetChallengeStarsNotExist = 2813,
	[OriginalName("RET_CHALLENGE_CUR_SCENE_NOT_ENTRY_FLOOR")]
	RetChallengeCurSceneNotEntryFloor = 2814,
	[OriginalName("RET_CHALLENGE_NO_TEAM_ARCHIVE")]
	RetChallengeNoTeamArchive = 2815,
	[OriginalName("RET_CHALLENGE_LINEUP_AVATAR_TYPE_INVALID")]
	RetChallengeLineupAvatarTypeInvalid = 2816,
	[OriginalName("RET_CHALLENGE_LINEUP_RECOMMEND_IN_CD")]
	RetChallengeLineupRecommendInCd = 2817,
	[OriginalName("RET_BASIC_TYPE_ALREADY")]
	RetBasicTypeAlready = 2850,
	[OriginalName("RET_NO_BASIC_TYPE")]
	RetNoBasicType = 2851,
	[OriginalName("RET_NOT_CHOOSE_BASIC_TYPE")]
	RetNotChooseBasicType = 2852,
	[OriginalName("RET_NOT_FUNC_CLOSE")]
	RetNotFuncClose = 2853,
	[OriginalName("RET_NOT_CHOOSE_GENDER")]
	RetNotChooseGender = 2854,
	[OriginalName("RET_NOT_REQ_UNLOCK_BASIC_TYPE")]
	RetNotReqUnlockBasicType = 2855,
	[OriginalName("RET_AVATAR_PATH_LOCKED")]
	RetAvatarPathLocked = 2856,
	[OriginalName("RET_ROGUE_STATUS_NOT_MATCH")]
	RetRogueStatusNotMatch = 2901,
	[OriginalName("RET_ROGUE_SELECT_BUFF_NOT_EXIST")]
	RetRogueSelectBuffNotExist = 2902,
	[OriginalName("RET_ROGUE_COIN_NOT_ENOUGH")]
	RetRogueCoinNotEnough = 2903,
	[OriginalName("RET_ROGUE_STAMINA_NOT_ENOUGH")]
	RetRogueStaminaNotEnough = 2904,
	[OriginalName("RET_ROGUE_APPRAISAL_COUNT_NOT_ENOUGH")]
	RetRogueAppraisalCountNotEnough = 2905,
	[OriginalName("RET_ROGUE_PROP_ALREADY_USED")]
	RetRoguePropAlreadyUsed = 2906,
	[OriginalName("RET_ROGUE_RECORD_ALREADY_SAVED")]
	RetRogueRecordAlreadySaved = 2907,
	[OriginalName("RET_ROGUE_ROLL_BUFF_MAX_COUNT")]
	RetRogueRollBuffMaxCount = 2908,
	[OriginalName("RET_ROGUE_PICK_AVATAR_INVALID")]
	RetRoguePickAvatarInvalid = 2909,
	[OriginalName("RET_ROGUE_QUEST_EXPIRE")]
	RetRogueQuestExpire = 2910,
	[OriginalName("RET_ROGUE_QUEST_REWARD_ALREADY")]
	RetRogueQuestRewardAlready = 2911,
	[OriginalName("RET_ROGUE_REVIVE_COUNT_NOT_ENOUGH")]
	RetRogueReviveCountNotEnough = 2912,
	[OriginalName("RET_ROGUE_AREA_INVALID")]
	RetRogueAreaInvalid = 2913,
	[OriginalName("RET_ROGUE_SCORE_REWARD_POOL_INVALID")]
	RetRogueScoreRewardPoolInvalid = 2914,
	[OriginalName("RET_ROGUE_SCORE_REWARD_ROW_INVALID")]
	RetRogueScoreRewardRowInvalid = 2915,
	[OriginalName("RET_ROGUE_AEON_LEVEL_NOT_MEET")]
	RetRogueAeonLevelNotMeet = 2916,
	[OriginalName("RET_ROGUE_AEON_LEVEL_REWARD_ALREADY_TAKEN")]
	RetRogueAeonLevelRewardAlreadyTaken = 2917,
	[OriginalName("RET_ROGUE_AEON_CONFIG_NOT_EXIST")]
	RetRogueAeonConfigNotExist = 2918,
	[OriginalName("RET_ROGUE_TRIAL_AVATAR_INVALID")]
	RetRogueTrialAvatarInvalid = 2919,
	[OriginalName("RET_ROGUE_HANDBOOK_REWARD_ALREADY_TAKEN")]
	RetRogueHandbookRewardAlreadyTaken = 2920,
	[OriginalName("RET_ROGUE_ROOM_TYPE_NOT_MATCH")]
	RetRogueRoomTypeNotMatch = 2921,
	[OriginalName("RET_ROGUE_SHOP_GOOD_NOT_FOUND")]
	RetRogueShopGoodNotFound = 2922,
	[OriginalName("RET_ROGUE_SHOP_GOOD_ALREADY_BOUGHT")]
	RetRogueShopGoodAlreadyBought = 2923,
	[OriginalName("RET_ROGUE_SHOP_GOOD_ALREADY_OWN")]
	RetRogueShopGoodAlreadyOwn = 2924,
	[OriginalName("RET_ROGUE_SHOP_MIRACLE_NOT_EXIST")]
	RetRogueShopMiracleNotExist = 2925,
	[OriginalName("RET_ROGUE_SHOP_NOT_EXIST")]
	RetRogueShopNotExist = 2926,
	[OriginalName("RET_ROGUE_SHOP_CANNOT_REFRESH")]
	RetRogueShopCannotRefresh = 2927,
	[OriginalName("RET_ROGUE_SELECT_BUFF_CERTAIN_MISMATCH")]
	RetRogueSelectBuffCertainMismatch = 2928,
	[OriginalName("RET_ROGUE_ACTION_QUEUE_NOT_EMPTY_BATTLE")]
	RetRogueActionQueueNotEmptyBattle = 2929,
	[OriginalName("RET_ROGUE_ACTION_QUEUE_NOT_EMPTY_OTHERS")]
	RetRogueActionQueueNotEmptyOthers = 2930,
	[OriginalName("RET_MISSION_EVENT_CONFIG_NOT_EXIST")]
	RetMissionEventConfigNotExist = 2951,
	[OriginalName("RET_MISSION_EVENT_NOT_CLIENT")]
	RetMissionEventNotClient = 2952,
	[OriginalName("RET_MISSION_EVENT_FINISHED")]
	RetMissionEventFinished = 2953,
	[OriginalName("RET_MISSION_EVENT_DOING")]
	RetMissionEventDoing = 2954,
	[OriginalName("RET_HAS_CHALLENGE_MISSION_EVENT")]
	RetHasChallengeMissionEvent = 2955,
	[OriginalName("RET_NOT_CHALLENGE_MISSION_EVENT")]
	RetNotChallengeMissionEvent = 2956,
	[OriginalName("RET_GACHA_ID_NOT_EXIST")]
	RetGachaIdNotExist = 3001,
	[OriginalName("RET_GACHA_NUM_INVALID")]
	RetGachaNumInvalid = 3002,
	[OriginalName("RET_GACHA_FIRST_GACHA_MUST_ONE")]
	RetGachaFirstGachaMustOne = 3003,
	[OriginalName("RET_GACHA_REQ_DUPLICATED")]
	RetGachaReqDuplicated = 3004,
	[OriginalName("RET_GACHA_NOT_IN_SCHEDULE")]
	RetGachaNotInSchedule = 3005,
	[OriginalName("RET_GACHA_NEWBIE_CLOSE")]
	RetGachaNewbieClose = 3006,
	[OriginalName("RET_GACHA_TODAY_LIMITED")]
	RetGachaTodayLimited = 3007,
	[OriginalName("RET_GACHA_NOT_SUPPORT")]
	RetGachaNotSupport = 3008,
	[OriginalName("RET_GACHA_CEILING_NOT_ENOUGH")]
	RetGachaCeilingNotEnough = 3009,
	[OriginalName("RET_GACHA_CEILING_CLOSE")]
	RetGachaCeilingClose = 3010,
	[OriginalName("RET_GACHA_LOCKED")]
	RetGachaLocked = 3011,
	[OriginalName("RET_GACHA_DECIDE_ITEM_TYPE_INVALID")]
	RetGachaDecideItemTypeInvalid = 3012,
	[OriginalName("RET_GACHA_DECIDE_ITEM_ID_INVALID")]
	RetGachaDecideItemIdInvalid = 3013,
	[OriginalName("RET_NOT_IN_RAID")]
	RetNotInRaid = 3101,
	[OriginalName("RET_RAID_DOING")]
	RetRaidDoing = 3102,
	[OriginalName("RET_NOT_PROP")]
	RetNotProp = 3103,
	[OriginalName("RET_RAID_ID_NOT_MATCH")]
	RetRaidIdNotMatch = 3104,
	[OriginalName("RET_RAID_RESTART_NOT_MATCH")]
	RetRaidRestartNotMatch = 3105,
	[OriginalName("RET_RAID_LIMIT")]
	RetRaidLimit = 3106,
	[OriginalName("RET_RAID_AVATAR_LIST_EMPTY")]
	RetRaidAvatarListEmpty = 3107,
	[OriginalName("RET_RAID_AVATAR_NOT_EXIST")]
	RetRaidAvatarNotExist = 3108,
	[OriginalName("RET_CHALLENGE_RAID_REWARD_ALREADY")]
	RetChallengeRaidRewardAlready = 3109,
	[OriginalName("RET_CHALLENGE_RAID_SCORE_NOT_REACH")]
	RetChallengeRaidScoreNotReach = 3110,
	[OriginalName("RET_CHALLENGE_RAID_NOT_OPEN")]
	RetChallengeRaidNotOpen = 3111,
	[OriginalName("RET_RAID_FINISHED")]
	RetRaidFinished = 3112,
	[OriginalName("RET_RAID_WORLD_LEVEL_NOT_LOCK")]
	RetRaidWorldLevelNotLock = 3113,
	[OriginalName("RET_RAID_CANNOT_USE_ASSIST")]
	RetRaidCannotUseAssist = 3114,
	[OriginalName("RET_RAID_AVATAR_NOT_MATCH")]
	RetRaidAvatarNotMatch = 3115,
	[OriginalName("RET_RAID_CAN_NOT_SAVE")]
	RetRaidCanNotSave = 3116,
	[OriginalName("RET_RAID_NO_SAVE")]
	RetRaidNoSave = 3117,
	[OriginalName("RET_ACTIVITY_RAID_NOT_OPEN")]
	RetActivityRaidNotOpen = 3118,
	[OriginalName("RET_RAID_AVATAR_CAPTAIN_NOT_EXIST")]
	RetRaidAvatarCaptainNotExist = 3119,
	[OriginalName("RET_RAID_STORY_LINE_NOT_MATCH")]
	RetRaidStoryLineNotMatch = 3120,
	[OriginalName("RET_TALK_EVENT_ALREADY_TAKEN")]
	RetTalkEventAlreadyTaken = 3151,
	[OriginalName("RET_NPC_ALREADY_MEET")]
	RetNpcAlreadyMeet = 3152,
	[OriginalName("RET_NPC_NOT_IN_CONFIG")]
	RetNpcNotInConfig = 3153,
	[OriginalName("RET_DIALOGUE_GROUP_DISMATCH")]
	RetDialogueGroupDismatch = 3154,
	[OriginalName("RET_DIALOGUE_EVENT_INVALID")]
	RetDialogueEventInvalid = 3155,
	[OriginalName("RET_TALK_EVENT_TAKE_PROTO_NOT_MATCH")]
	RetTalkEventTakeProtoNotMatch = 3156,
	[OriginalName("RET_TALK_EVENT_NOT_VALID")]
	RetTalkEventNotValid = 3157,
	[OriginalName("RET_EXPEDITION_CONFIG_NOT_EXIST")]
	RetExpeditionConfigNotExist = 3201,
	[OriginalName("RET_EXPEDITION_REWARD_CONFIG_NOT_EXIST")]
	RetExpeditionRewardConfigNotExist = 3202,
	[OriginalName("RET_EXPEDITION_NOT_UNLOCKED")]
	RetExpeditionNotUnlocked = 3203,
	[OriginalName("RET_EXPEDITION_ALREADY_ACCEPTED")]
	RetExpeditionAlreadyAccepted = 3204,
	[OriginalName("RET_EXPEDITION_REPEATED_AVATAR")]
	RetExpeditionRepeatedAvatar = 3205,
	[OriginalName("RET_AVATAR_ALREADY_DISPATCHED")]
	RetAvatarAlreadyDispatched = 3206,
	[OriginalName("RET_EXPEDITION_NOT_ACCEPTED")]
	RetExpeditionNotAccepted = 3207,
	[OriginalName("RET_EXPEDITION_NOT_FINISH")]
	RetExpeditionNotFinish = 3208,
	[OriginalName("RET_EXPEDITION_ALREADY_FINISH")]
	RetExpeditionAlreadyFinish = 3209,
	[OriginalName("RET_EXPEDITION_TEAM_COUNT_LIMIT")]
	RetExpeditionTeamCountLimit = 3210,
	[OriginalName("RET_EXPEDITION_AVATAR_NUM_NOT_MATCH")]
	RetExpeditionAvatarNumNotMatch = 3211,
	[OriginalName("RET_EXPEDITION_NOT_OPEN")]
	RetExpeditionNotOpen = 3212,
	[OriginalName("RET_EXPEDITION_FRIEND_AVATAR_NOT_VALID")]
	RetExpeditionFriendAvatarNotValid = 3213,
	[OriginalName("RET_EXPEDITION_NOT_PUBLISHED")]
	RetExpeditionNotPublished = 3214,
	[OriginalName("RET_LOGIN_ACTIVITY_HAS_TAKEN")]
	RetLoginActivityHasTaken = 3301,
	[OriginalName("RET_LOGIN_ACTIVITY_DAYS_LACK")]
	RetLoginActivityDaysLack = 3302,
	[OriginalName("RET_TRIAL_ACTIVITY_REWARD_ALREADY_TAKE")]
	RetTrialActivityRewardAlreadyTake = 3303,
	[OriginalName("RET_TRIAL_ACTIVITY_STAGE_NOT_FINISH")]
	RetTrialActivityStageNotFinish = 3304,
	[OriginalName("RET_MATERIAL_SUBMIT_ACTIVITY_HAS_TAKEN")]
	RetMaterialSubmitActivityHasTaken = 3305,
	[OriginalName("RET_MATERIAL_SUBMIT_ACTIVITY_MATERIAL_NOT_SUBMITTED")]
	RetMaterialSubmitActivityMaterialNotSubmitted = 3306,
	[OriginalName("RET_MATERIAL_SUBMIT_ACTIVITY_MATERIAL_ALREADY_SUBMITTED")]
	RetMaterialSubmitActivityMaterialAlreadySubmitted = 3307,
	[OriginalName("RET_FANTASTIC_STORY_ACTIVITY_STORY_ERROR")]
	RetFantasticStoryActivityStoryError = 3308,
	[OriginalName("RET_FANTASTIC_STORY_ACTIVITY_STORY_NOT_OPEN")]
	RetFantasticStoryActivityStoryNotOpen = 3309,
	[OriginalName("RET_FANTASTIC_STORY_ACTIVITY_BATTLE_ERROR")]
	RetFantasticStoryActivityBattleError = 3310,
	[OriginalName("RET_FANTASTIC_STORY_ACTIVITY_BATTLE_NOT_OPEN")]
	RetFantasticStoryActivityBattleNotOpen = 3311,
	[OriginalName("RET_FANTASTIC_STORY_ACTIVITY_BATTLE_AVATAR_ERROR")]
	RetFantasticStoryActivityBattleAvatarError = 3312,
	[OriginalName("RET_FANTASTIC_STORY_ACTIVITY_BATTLE_BUFF_ERROR")]
	RetFantasticStoryActivityBattleBuffError = 3313,
	[OriginalName("RET_FANTASTIC_STORY_ACTIVITY_PRE_BATTLE_SCORE_NOT_ENOUGH")]
	RetFantasticStoryActivityPreBattleScoreNotEnough = 3314,
	[OriginalName("RET_TRIAL_ACTIVITY_ALREADY_IN_TRIAL_ACTIVITY")]
	RetTrialActivityAlreadyInTrialActivity = 3315,
	[OriginalName("RET_COMMON_ACTIVITY_NOT_OPEN")]
	RetCommonActivityNotOpen = 3316,
	[OriginalName("RET_BENEFIT_NOT_READY")]
	RetBenefitNotReady = 3317,
	[OriginalName("RET_COMMON_ACTIVITY_BUSY")]
	RetCommonActivityBusy = 3318,
	[OriginalName("RET_AVATAR_DELIVER_REWARD_PHASE_ERROR")]
	RetAvatarDeliverRewardPhaseError = 3319,
	[OriginalName("RET_MESSAGE_CONFIG_NOT_EXIST")]
	RetMessageConfigNotExist = 3501,
	[OriginalName("RET_MESSAGE_SECTION_NOT_TAKE")]
	RetMessageSectionNotTake = 3502,
	[OriginalName("RET_MESSAGE_GROUP_NOT_TAKE")]
	RetMessageGroupNotTake = 3503,
	[OriginalName("RET_MESSAGE_SECTION_ID_NOT_MATCH")]
	RetMessageSectionIdNotMatch = 3504,
	[OriginalName("RET_MESSAGE_SECTION_CAN_NOT_FINISH")]
	RetMessageSectionCanNotFinish = 3505,
	[OriginalName("RET_MESSAGE_ITEM_CAN_NOT_FINISH")]
	RetMessageItemCanNotFinish = 3506,
	[OriginalName("RET_MESSAGE_ITEM_RAID_CAN_NOT_FINISH")]
	RetMessageItemRaidCanNotFinish = 3507,
	[OriginalName("RET_FRIEND_ALREADY_IS_FRIEND")]
	RetFriendAlreadyIsFriend = 3601,
	[OriginalName("RET_FRIEND_IS_NOT_FRIEND")]
	RetFriendIsNotFriend = 3602,
	[OriginalName("RET_FRIEND_APPLY_EXPIRE")]
	RetFriendApplyExpire = 3603,
	[OriginalName("RET_FRIEND_IN_BLACKLIST")]
	RetFriendInBlacklist = 3604,
	[OriginalName("RET_FRIEND_NOT_IN_BLACKLIST")]
	RetFriendNotInBlacklist = 3605,
	[OriginalName("RET_FRIEND_NUMBER_LIMIT")]
	RetFriendNumberLimit = 3606,
	[OriginalName("RET_FRIEND_BLACKLIST_NUMBER_LIMIT")]
	RetFriendBlacklistNumberLimit = 3607,
	[OriginalName("RET_FRIEND_DAILY_APPLY_LIMIT")]
	RetFriendDailyApplyLimit = 3608,
	[OriginalName("RET_FRIEND_IN_HANDLE_LIMIT")]
	RetFriendInHandleLimit = 3609,
	[OriginalName("RET_FRIEND_APPLY_IN_CD")]
	RetFriendApplyInCd = 3610,
	[OriginalName("RET_FRIEND_REMARK_NAME_FORMAT_ERROR")]
	RetFriendRemarkNameFormatError = 3611,
	[OriginalName("RET_FRIEND_PLAYER_NOT_FOUND")]
	RetFriendPlayerNotFound = 3612,
	[OriginalName("RET_FRIEND_IN_TARGET_BLACKLIST")]
	RetFriendInTargetBlacklist = 3613,
	[OriginalName("RET_FRIEND_TARGET_NUMBER_LIMIT")]
	RetFriendTargetNumberLimit = 3614,
	[OriginalName("RET_ASSIST_QUERY_TOO_FAST")]
	RetAssistQueryTooFast = 3615,
	[OriginalName("RET_ASSIST_NOT_EXIST")]
	RetAssistNotExist = 3616,
	[OriginalName("RET_ASSIST_USED_ALREADY")]
	RetAssistUsedAlready = 3617,
	[OriginalName("RET_FRIEND_REPORT_REASON_FORMAT_ERROR")]
	RetFriendReportReasonFormatError = 3618,
	[OriginalName("RET_FRIEND_REPORT_SENSITIVE_WORDS")]
	RetFriendReportSensitiveWords = 3619,
	[OriginalName("RET_ASSIST_USED_TIMES_OVER")]
	RetAssistUsedTimesOver = 3620,
	[OriginalName("RET_ASSIST_QUIT_ALREADY")]
	RetAssistQuitAlready = 3621,
	[OriginalName("RET_ASSIST_AVATAR_IN_LINEUP")]
	RetAssistAvatarInLineup = 3622,
	[OriginalName("RET_ASSIST_NO_REWARD")]
	RetAssistNoReward = 3623,
	[OriginalName("RET_FRIEND_SEARCH_NUM_LIMIT")]
	RetFriendSearchNumLimit = 3624,
	[OriginalName("RET_FRIEND_SEARCH_IN_CD")]
	RetFriendSearchInCd = 3625,
	[OriginalName("RET_FRIEND_REMARK_NAME_UTF8_ERROR")]
	RetFriendRemarkNameUtf8Error = 3626,
	[OriginalName("RET_FRIEND_REPORT_REASON_UTF8_ERROR")]
	RetFriendReportReasonUtf8Error = 3627,
	[OriginalName("RET_ASSIST_SET_ALREADY")]
	RetAssistSetAlready = 3628,
	[OriginalName("RET_FRIEND_TARGET_FORBID_OTHER_APPLY")]
	RetFriendTargetForbidOtherApply = 3629,
	[OriginalName("RET_FRIEND_MARKED_CNT_MAX")]
	RetFriendMarkedCntMax = 3630,
	[OriginalName("RET_FRIEND_MARKED_ALREADY")]
	RetFriendMarkedAlready = 3631,
	[OriginalName("RET_FRIEND_NOT_MARKED")]
	RetFriendNotMarked = 3632,
	[OriginalName("RET_FRIEND_CHALLENGE_LINEUP_RECOMMEND_IN_CD")]
	RetFriendChallengeLineupRecommendInCd = 3633,
	[OriginalName("RET_VIEW_PLAYER_CARD_IN_CD")]
	RetViewPlayerCardInCd = 3634,
	[OriginalName("RET_VIEW_PLAYER_BATTLE_RECORD_IN_CD")]
	RetViewPlayerBattleRecordInCd = 3635,
	[OriginalName("RET_ASSIST_LIST_STRANGER_CONFIG_ERROR")]
	RetAssistListStrangerConfigError = 3636,
	[OriginalName("RET_PLAYER_BOARD_HEAD_ICON_NOT_EXIST")]
	RetPlayerBoardHeadIconNotExist = 3701,
	[OriginalName("RET_PLAYER_BOARD_HEAD_ICON_LOCKED")]
	RetPlayerBoardHeadIconLocked = 3702,
	[OriginalName("RET_PLAYER_BOARD_HEAD_ICON_ALREADY_UNLOCKED")]
	RetPlayerBoardHeadIconAlreadyUnlocked = 3703,
	[OriginalName("RET_PLAYER_BOARD_DISPLAY_AVATAR_NOT_EXIST")]
	RetPlayerBoardDisplayAvatarNotExist = 3704,
	[OriginalName("RET_PLAYER_BOARD_DISPLAY_AVATAR_EXCEED_LIMIT")]
	RetPlayerBoardDisplayAvatarExceedLimit = 3705,
	[OriginalName("RET_PLAYER_BOARD_DISPLAY_REPEATED_AVATAR")]
	RetPlayerBoardDisplayRepeatedAvatar = 3706,
	[OriginalName("RET_PLAYER_BOARD_DISPLAY_AVATAR_SAME_POS")]
	RetPlayerBoardDisplayAvatarSamePos = 3707,
	[OriginalName("RET_PLAYER_BOARD_DISPLAY_AVATAR_LOCKED")]
	RetPlayerBoardDisplayAvatarLocked = 3708,
	[OriginalName("RET_SIGNATURE_LENGTH_EXCEED_LIMIT")]
	RetSignatureLengthExceedLimit = 3709,
	[OriginalName("RET_SIGNATURE_SENSITIVE_WORDS")]
	RetSignatureSensitiveWords = 3710,
	[OriginalName("RET_PLAYER_BOARD_ASSIST_AVATAR_NOT_EXIST")]
	RetPlayerBoardAssistAvatarNotExist = 3712,
	[OriginalName("RET_PLAYER_BOARD_ASSIST_AVATAR_LOCKED")]
	RetPlayerBoardAssistAvatarLocked = 3713,
	[OriginalName("RET_SIGNATURE_UTF8_ERROR")]
	RetSignatureUtf8Error = 3714,
	[OriginalName("RET_PLAYER_BOARD_ASSIST_AVATAR_CNT_ERROR")]
	RetPlayerBoardAssistAvatarCntError = 3715,
	[OriginalName("RET_PLAYER_BOARD_PERSONAL_CARD_NOT_EXIST")]
	RetPlayerBoardPersonalCardNotExist = 3716,
	[OriginalName("RET_PLAYER_BOARD_PERSONAL_CARD_LOCKED")]
	RetPlayerBoardPersonalCardLocked = 3717,
	[OriginalName("RET_PLAYER_BOARD_PERSONAL_NO_CHANGE")]
	RetPlayerBoardPersonalNoChange = 3718,
	[OriginalName("RET_BATTLE_PASS_TIER_NOT_VALID")]
	RetBattlePassTierNotValid = 3801,
	[OriginalName("RET_BATTLE_PASS_LEVEL_NOT_MEET")]
	RetBattlePassLevelNotMeet = 3802,
	[OriginalName("RET_BATTLE_PASS_REWARD_TAKE_ALREADY")]
	RetBattlePassRewardTakeAlready = 3803,
	[OriginalName("RET_BATTLE_PASS_NOT_PREMIUM")]
	RetBattlePassNotPremium = 3804,
	[OriginalName("RET_BATTLE_PASS_NOT_DOING")]
	RetBattlePassNotDoing = 3805,
	[OriginalName("RET_BATTLE_PASS_LEVEL_INVALID")]
	RetBattlePassLevelInvalid = 3806,
	[OriginalName("RET_BATTLE_PASS_NOT_UNLOCK")]
	RetBattlePassNotUnlock = 3807,
	[OriginalName("RET_BATTLE_PASS_NO_REWARD")]
	RetBattlePassNoReward = 3808,
	[OriginalName("RET_BATTLE_PASS_QUEST_NOT_VALID")]
	RetBattlePassQuestNotValid = 3809,
	[OriginalName("RET_BATTLE_PASS_NOT_CHOOSE_OPTIONAL")]
	RetBattlePassNotChooseOptional = 3810,
	[OriginalName("RET_BATTLE_PASS_NOT_TAKE_REWARD")]
	RetBattlePassNotTakeReward = 3811,
	[OriginalName("RET_BATTLE_PASS_OPTIONAL_NOT_VALID")]
	RetBattlePassOptionalNotValid = 3812,
	[OriginalName("RET_BATTLE_PASS_BUY_ALREADY")]
	RetBattlePassBuyAlready = 3813,
	[OriginalName("RET_BATTLE_PASS_NEAR_END")]
	RetBattlePassNearEnd = 3814,
	[OriginalName("RET_MUSIC_LOCKED")]
	RetMusicLocked = 3901,
	[OriginalName("RET_MUSIC_NOT_EXIST")]
	RetMusicNotExist = 3902,
	[OriginalName("RET_MUSIC_UNLOCK_FAILED")]
	RetMusicUnlockFailed = 3903,
	[OriginalName("RET_PUNK_LORD_LACK_SUMMON_TIMES")]
	RetPunkLordLackSummonTimes = 4001,
	[OriginalName("RET_PUNK_LORD_ATTACKING_MONSTER_LIMIT")]
	RetPunkLordAttackingMonsterLimit = 4002,
	[OriginalName("RET_PUNK_LORD_MONSTER_NOT_EXIST")]
	RetPunkLordMonsterNotExist = 4003,
	[OriginalName("RET_PUNK_LORD_MONSTER_ALREADY_SHARED")]
	RetPunkLordMonsterAlreadyShared = 4004,
	[OriginalName("RET_PUNK_LORD_MONSTER_EXPIRED")]
	RetPunkLordMonsterExpired = 4005,
	[OriginalName("RET_PUNK_LORD_SELF_MONSTER_ATTACK_LIMIT")]
	RetPunkLordSelfMonsterAttackLimit = 4006,
	[OriginalName("RET_PUNK_LORD_LACK_SUPPORT_TIMES")]
	RetPunkLordLackSupportTimes = 4007,
	[OriginalName("RET_PUNK_LORD_MONSTER_ALREADY_KILLED")]
	RetPunkLordMonsterAlreadyKilled = 4008,
	[OriginalName("RET_PUNK_LORD_MONSTER_ATTACKER_LIMIT")]
	RetPunkLordMonsterAttackerLimit = 4009,
	[OriginalName("RET_PUNK_LORD_WORLD_LEVLE_NOT_VALID")]
	RetPunkLordWorldLevleNotValid = 4010,
	[OriginalName("RET_PUNK_LORD_REWARD_LEVLE_NOT_EXIST")]
	RetPunkLordRewardLevleNotExist = 4011,
	[OriginalName("RET_PUNK_LORD_POINT_NOT_MEET")]
	RetPunkLordPointNotMeet = 4012,
	[OriginalName("RET_PUNK_LORD_IN_ATTACKING")]
	RetPunkLordInAttacking = 4013,
	[OriginalName("RET_PUNK_LORD_OPERATION_IN_CD")]
	RetPunkLordOperationInCd = 4014,
	[OriginalName("RET_PUNK_LORD_REWARD_ALREADY_TAKEN")]
	RetPunkLordRewardAlreadyTaken = 4015,
	[OriginalName("RET_PUNK_LORD_OVER_BONUS_REWARD_LIMIT")]
	RetPunkLordOverBonusRewardLimit = 4016,
	[OriginalName("RET_PUNK_LORD_NOT_IN_SCHEDULE")]
	RetPunkLordNotInSchedule = 4017,
	[OriginalName("RET_PUNK_LORD_MONSTER_NOT_ATTACKED")]
	RetPunkLordMonsterNotAttacked = 4018,
	[OriginalName("RET_PUNK_LORD_MONSTER_NOT_KILLED")]
	RetPunkLordMonsterNotKilled = 4019,
	[OriginalName("RET_PUNK_LORD_MONSTER_KILLED_SCORE_ALREADY_TAKE")]
	RetPunkLordMonsterKilledScoreAlreadyTake = 4020,
	[OriginalName("RET_PUNK_LORD_REWARD_LEVLE_ALREADY_TAKE")]
	RetPunkLordRewardLevleAlreadyTake = 4021,
	[OriginalName("RET_DAILY_ACTIVE_LEVEL_INVALID")]
	RetDailyActiveLevelInvalid = 4101,
	[OriginalName("RET_DAILY_ACTIVE_LEVEL_REWARD_ALREADY_TAKEN")]
	RetDailyActiveLevelRewardAlreadyTaken = 4102,
	[OriginalName("RET_DAILY_ACTIVE_LEVEL_AP_NOT_ENOUGH")]
	RetDailyActiveLevelApNotEnough = 4103,
	[OriginalName("RET_DAILY_MEET_PAM")]
	RetDailyMeetPam = 4201,
	[OriginalName("RET_REPLAY_ID_NOT_MATCH")]
	RetReplayIdNotMatch = 4251,
	[OriginalName("RET_REPLAY_REQ_NOT_VALID")]
	RetReplayReqNotValid = 4252,
	[OriginalName("RET_FIGHT_ACTIVITY_DIFFICULTY_LEVEL_NOT_PASSED")]
	RetFightActivityDifficultyLevelNotPassed = 4301,
	[OriginalName("RET_FIGHT_ACTIVITY_DIFFICULTY_LEVEL_REWARD_ALREADY_TAKE")]
	RetFightActivityDifficultyLevelRewardAlreadyTake = 4302,
	[OriginalName("RET_FIGHT_ACTIVITY_STAGE_NOT_OPEN")]
	RetFightActivityStageNotOpen = 4303,
	[OriginalName("RET_FIGHT_ACTIVITY_LEVEL_NOT_UNLOCK")]
	RetFightActivityLevelNotUnlock = 4304,
	[OriginalName("RET_TRAIN_VISITOR_VISITOR_NOT_EXIST")]
	RetTrainVisitorVisitorNotExist = 4351,
	[OriginalName("RET_TRAIN_VISITOR_BEHAVIOR_NOT_EXIST")]
	RetTrainVisitorBehaviorNotExist = 4352,
	[OriginalName("RET_TRAIN_VISITOR_BEHAVIOR_FINISHED")]
	RetTrainVisitorBehaviorFinished = 4353,
	[OriginalName("RET_TRAIN_VISITOR_ALL_BEHAVIOR_REWARD_TAKEN")]
	RetTrainVisitorAllBehaviorRewardTaken = 4354,
	[OriginalName("RET_TRAIN_VISITOR_GET_ON_MISSION_NOT_FINISH")]
	RetTrainVisitorGetOnMissionNotFinish = 4355,
	[OriginalName("RET_TRAIN_VISITOR_NOT_GET_OFF_OR_BE_TRAIN_MEMBER")]
	RetTrainVisitorNotGetOffOrBeTrainMember = 4356,
	[OriginalName("RET_TEXT_JOIN_UNKNOW_IS_OVERRIDE")]
	RetTextJoinUnknowIsOverride = 4401,
	[OriginalName("RET_TEXT_JOIN_ID_NOT_EXIST")]
	RetTextJoinIdNotExist = 4402,
	[OriginalName("RET_TEXT_JOIN_CAN_NOT_OVERRIDE")]
	RetTextJoinCanNotOverride = 4403,
	[OriginalName("RET_TEXT_JOIN_ITEM_ID_ERROR")]
	RetTextJoinItemIdError = 4404,
	[OriginalName("RET_TEXT_JOIN_SENSITIVE_CHECK_ERROR")]
	RetTextJoinSensitiveCheckError = 4405,
	[OriginalName("RET_TEXT_JOIN_MUST_OVERRIDE")]
	RetTextJoinMustOverride = 4406,
	[OriginalName("RET_TEXT_JOIN_TEXT_EMPTY")]
	RetTextJoinTextEmpty = 4407,
	[OriginalName("RET_TEXT_JOIN_TEXT_FORMAT_ERROR")]
	RetTextJoinTextFormatError = 4408,
	[OriginalName("RET_TEXT_JOIN_TEXT_UTF8_ERROR")]
	RetTextJoinTextUtf8Error = 4409,
	[OriginalName("RET_TEXT_JOIN_BATCH_REQ_ID_REPEAT")]
	RetTextJoinBatchReqIdRepeat = 4410,
	[OriginalName("RET_TEXT_JOIN_TYPE_NOT_SUPPORT_BATCH_REQ")]
	RetTextJoinTypeNotSupportBatchReq = 4411,
	[OriginalName("RET_TEXT_JOIN_AVATAR_ID_NOT_EXIST")]
	RetTextJoinAvatarIdNotExist = 4412,
	[OriginalName("RET_TEXT_JOIN_UNKNOW_TYPE")]
	RetTextJoinUnknowType = 4413,
	[OriginalName("RET_PAM_MISSION_MISSION_ID_ERROR")]
	RetPamMissionMissionIdError = 4451,
	[OriginalName("RET_PAM_MISSION_MISSION_EXPIRE")]
	RetPamMissionMissionExpire = 4452,
	[OriginalName("RET_CHAT_TYPE_NOT_EXIST")]
	RetChatTypeNotExist = 4501,
	[OriginalName("RET_MSG_TYPE_NOT_EXIST")]
	RetMsgTypeNotExist = 4502,
	[OriginalName("RET_CHAT_NO_TARGET_UID")]
	RetChatNoTargetUid = 4503,
	[OriginalName("RET_CHAT_MSG_EMPTY")]
	RetChatMsgEmpty = 4504,
	[OriginalName("RET_CHAT_MSG_EXCEED_LIMIT")]
	RetChatMsgExceedLimit = 4505,
	[OriginalName("RET_CHAT_MSG_SENSITIVE_CHECK_ERROR")]
	RetChatMsgSensitiveCheckError = 4506,
	[OriginalName("RET_CHAT_MSG_UTF8_ERROR")]
	RetChatMsgUtf8Error = 4507,
	[OriginalName("RET_CHAT_FORBID_SWITCH_OPEN")]
	RetChatForbidSwitchOpen = 4508,
	[OriginalName("RET_CHAT_FORBID")]
	RetChatForbid = 4509,
	[OriginalName("RET_CHAT_MSG_INCLUDE_SPECIAL_STR")]
	RetChatMsgIncludeSpecialStr = 4510,
	[OriginalName("RET_CHAT_MSG_EMOJI_NOT_EXIST")]
	RetChatMsgEmojiNotExist = 4511,
	[OriginalName("RET_CHAT_MSG_EMOJI_GENDER_NOT_MATCH")]
	RetChatMsgEmojiGenderNotMatch = 4512,
	[OriginalName("RET_CHAT_MSG_EMOJI_NOT_MARKED")]
	RetChatMsgEmojiNotMarked = 4513,
	[OriginalName("RET_CHAT_MSG_EMOJI_ALREADY_MARKED")]
	RetChatMsgEmojiAlreadyMarked = 4514,
	[OriginalName("RET_CHAT_MSG_EMOJI_MARKED_MAX_LIMIT")]
	RetChatMsgEmojiMarkedMaxLimit = 4515,
	[OriginalName("RET_BOXING_CLUB_CHALLENGE_NOT_OPEN")]
	RetBoxingClubChallengeNotOpen = 4601,
	[OriginalName("RET_MUSEUM_NOT_OPEN")]
	RetMuseumNotOpen = 4651,
	[OriginalName("RET_MUSEUM_TURN_CNT_NOT_MATCH")]
	RetMuseumTurnCntNotMatch = 4652,
	[OriginalName("RET_MUSEUM_PHASE_NOT_REACH")]
	RetMuseumPhaseNotReach = 4653,
	[OriginalName("RET_MUSEUM_UNKNOW_STUFF")]
	RetMuseumUnknowStuff = 4654,
	[OriginalName("RET_MUSEUM_UNKNOW_AREA")]
	RetMuseumUnknowArea = 4655,
	[OriginalName("RET_MUSEUM_UNKNOW_POS")]
	RetMuseumUnknowPos = 4656,
	[OriginalName("RET_MUSEUM_STUFF_ALREADY_IN_AREA")]
	RetMuseumStuffAlreadyInArea = 4657,
	[OriginalName("RET_MUSEUM_STUFF_NOT_IN_AREA")]
	RetMuseumStuffNotInArea = 4658,
	[OriginalName("RET_MUSEUM_GET_NPC_REPEAT")]
	RetMuseumGetNpcRepeat = 4659,
	[OriginalName("RET_MUSEUM_GET_NPC_UNLOCK")]
	RetMuseumGetNpcUnlock = 4660,
	[OriginalName("RET_MUSEUM_GET_NPC_NOT_ENOUGH")]
	RetMuseumGetNpcNotEnough = 4661,
	[OriginalName("RET_MUSEUM_CHANGE_STUFF_AREA_ERROR")]
	RetMuseumChangeStuffAreaError = 4662,
	[OriginalName("RET_MUSEUM_NOT_INIT")]
	RetMuseumNotInit = 4663,
	[OriginalName("RET_MUSEUM_EVENT_ERROR")]
	RetMuseumEventError = 4664,
	[OriginalName("RET_MUSEUM_UNKNOW_CHOOSE_EVENT_ID")]
	RetMuseumUnknowChooseEventId = 4665,
	[OriginalName("RET_MUSEUM_EVENT_ORDER_NOT_MATCH")]
	RetMuseumEventOrderNotMatch = 4666,
	[OriginalName("RET_MUSEUM_EVENT_PHASE_NOT_UNLOCK")]
	RetMuseumEventPhaseNotUnlock = 4667,
	[OriginalName("RET_MUSEUM_EVENT_MISSION_NOT_FOUND")]
	RetMuseumEventMissionNotFound = 4668,
	[OriginalName("RET_MUSEUM_AREA_LEVEL_UP_ALREADY")]
	RetMuseumAreaLevelUpAlready = 4669,
	[OriginalName("RET_MUSEUM_STUFF_ALREADY_USED")]
	RetMuseumStuffAlreadyUsed = 4670,
	[OriginalName("RET_MUSEUM_EVENT_ROUND_NOT_UNLOCK")]
	RetMuseumEventRoundNotUnlock = 4671,
	[OriginalName("RET_MUSEUM_STUFF_IN_AREA")]
	RetMuseumStuffInArea = 4672,
	[OriginalName("RET_MUSEUM_STUFF_DISPATCH")]
	RetMuseumStuffDispatch = 4673,
	[OriginalName("RET_MUSEUM_IS_END")]
	RetMuseumIsEnd = 4674,
	[OriginalName("RET_MUSEUM_STUFF_LEAVING")]
	RetMuseumStuffLeaving = 4675,
	[OriginalName("RET_MUSEUM_EVENT_MISSION_NOT_FINISH")]
	RetMuseumEventMissionNotFinish = 4678,
	[OriginalName("RET_MUSEUM_COLLECT_REWARD_NOT_EXIST")]
	RetMuseumCollectRewardNotExist = 4679,
	[OriginalName("RET_MUSEUM_COLLECT_REWARD_ALREADY_TAKEN")]
	RetMuseumCollectRewardAlreadyTaken = 4680,
	[OriginalName("RET_MUSEUM_ACCEPT_MISSION_MAX_LIMIT")]
	RetMuseumAcceptMissionMaxLimit = 4681,
	[OriginalName("RET_ROGUE_CHALLENGE_NOT_OPEN")]
	RetRogueChallengeNotOpen = 4701,
	[OriginalName("RET_ROGUE_CHALLENGE_ASSIS_REFRESH_LIMIT")]
	RetRogueChallengeAssisRefreshLimit = 4702,
	[OriginalName("RET_ALLEY_NOT_INIT")]
	RetAlleyNotInit = 4721,
	[OriginalName("RET_ALLEY_NOT_OPEN")]
	RetAlleyNotOpen = 4722,
	[OriginalName("RET_ALLEY_MAP_NOT_EXIST")]
	RetAlleyMapNotExist = 4724,
	[OriginalName("RET_ALLEY_EMPTY_POS_LIST")]
	RetAlleyEmptyPosList = 4725,
	[OriginalName("RET_ALLEY_LINE_POS_INVALID")]
	RetAlleyLinePosInvalid = 4726,
	[OriginalName("RET_ALLEY_SHOP_NOT_UNLOCK")]
	RetAlleyShopNotUnlock = 4727,
	[OriginalName("RET_ALLEY_DEPOT_FULL")]
	RetAlleyDepotFull = 4728,
	[OriginalName("RET_ALLEY_SHOP_NOT_INCLUDE")]
	RetAlleyShopNotInclude = 4729,
	[OriginalName("RET_ALLEY_EVENT_NOT_UNLOCK")]
	RetAlleyEventNotUnlock = 4730,
	[OriginalName("RET_ALLEY_EVENT_NOT_REFRESH")]
	RetAlleyEventNotRefresh = 4731,
	[OriginalName("RET_ALLEY_EVENT_STATE_DOING")]
	RetAlleyEventStateDoing = 4732,
	[OriginalName("RET_ALLEY_EVENT_STATE_FINISH")]
	RetAlleyEventStateFinish = 4733,
	[OriginalName("RET_ALLEY_EVENT_ERROR")]
	RetAlleyEventError = 4734,
	[OriginalName("RET_ALLEY_REWARD_LEVEL_ERROR")]
	RetAlleyRewardLevelError = 4735,
	[OriginalName("RET_ALLEY_REWARD_PRESTIGE_NOT_ENOUGH")]
	RetAlleyRewardPrestigeNotEnough = 4736,
	[OriginalName("RET_ALLEY_SHIP_EMPTY")]
	RetAlleyShipEmpty = 4737,
	[OriginalName("RET_ALLEY_SHIP_ID_DISMATCH")]
	RetAlleyShipIdDismatch = 4738,
	[OriginalName("RET_ALLEY_SHIP_NOT_EXIST")]
	RetAlleyShipNotExist = 4739,
	[OriginalName("RET_ALLEY_SHIP_NOT_UNLOCK")]
	RetAlleyShipNotUnlock = 4740,
	[OriginalName("RET_ALLEY_GOODS_NOT_EXIST")]
	RetAlleyGoodsNotExist = 4741,
	[OriginalName("RET_ALLEY_GOODS_NOT_UNLOCK")]
	RetAlleyGoodsNotUnlock = 4742,
	[OriginalName("RET_ALLEY_PROFIT_NOT_POSITIVE")]
	RetAlleyProfitNotPositive = 4743,
	[OriginalName("RET_ALLEY_SPECIAL_ORDER_DISMATCH")]
	RetAlleySpecialOrderDismatch = 4744,
	[OriginalName("RET_ALLEY_ORDER_GOODS_OVER_LIMIT")]
	RetAlleyOrderGoodsOverLimit = 4745,
	[OriginalName("RET_ALLEY_SPECIAL_ORDER_CONDITION_NOT_MEET")]
	RetAlleySpecialOrderConditionNotMeet = 4746,
	[OriginalName("RET_ALLEY_DEPOT_SIZE_OVER_LIMIT")]
	RetAlleyDepotSizeOverLimit = 4747,
	[OriginalName("RET_ALLEY_GOODS_NOT_ENOUGH")]
	RetAlleyGoodsNotEnough = 4748,
	[OriginalName("RET_ALLEY_ORDER_INDEX_INVALID")]
	RetAlleyOrderIndexInvalid = 4749,
	[OriginalName("RET_ALLEY_REWARD_ALREADY_TAKE")]
	RetAlleyRewardAlreadyTake = 4750,
	[OriginalName("RET_ALLEY_REWARD_NOT_EXIST")]
	RetAlleyRewardNotExist = 4751,
	[OriginalName("RET_ALLEY_MAIN_MISSION_NOT_DOING")]
	RetAlleyMainMissionNotDoing = 4752,
	[OriginalName("RET_ALLEY_CRITICAL_EVENT_NOT_FINISH")]
	RetAlleyCriticalEventNotFinish = 4753,
	[OriginalName("RET_ALLEY_SHOP_GOODS_NOT_VALID")]
	RetAlleyShopGoodsNotValid = 4754,
	[OriginalName("RET_ALLEY_SLASH_NOT_OPEN")]
	RetAlleySlashNotOpen = 4755,
	[OriginalName("RET_ALLEY_PLACING_ANCHOR_INVALID")]
	RetAlleyPlacingAnchorInvalid = 4756,
	[OriginalName("RET_ALLEY_PLACING_GOODS_INDEX_INVALID")]
	RetAlleyPlacingGoodsIndexInvalid = 4757,
	[OriginalName("RET_ALLEY_SAVE_MAP_TOO_QUICK")]
	RetAlleySaveMapTooQuick = 4758,
	[OriginalName("RET_ALLEY_MAP_NOT_LINK")]
	RetAlleyMapNotLink = 4759,
	[OriginalName("RET_ALLEY_FUNDS_NOT_LOWER_BASE")]
	RetAlleyFundsNotLowerBase = 4760,
	[OriginalName("RET_ALLEY_EVENT_NOT_FINISH")]
	RetAlleyEventNotFinish = 4761,
	[OriginalName("RET_ALLEY_NORMAL_ORDER_NOT_MEET")]
	RetAlleyNormalOrderNotMeet = 4762,
	[OriginalName("RET_PLAYER_RETURN_NOT_OPEN")]
	RetPlayerReturnNotOpen = 4801,
	[OriginalName("RET_PLAYER_RETURN_IS_SIGNED")]
	RetPlayerReturnIsSigned = 4802,
	[OriginalName("RET_PLAYER_RETURN_POINT_NOT_ENOUGH")]
	RetPlayerReturnPointNotEnough = 4803,
	[OriginalName("RET_PLAYER_RETURN_CONDITION_INVALID")]
	RetPlayerReturnConditionInvalid = 4804,
	[OriginalName("RET_PLAYER_RETURN_HAS_SIGNED")]
	RetPlayerReturnHasSigned = 4805,
	[OriginalName("RET_PLAYER_RETURN_REWARD_TAKEN")]
	RetPlayerReturnRewardTaken = 4806,
	[OriginalName("RET_PLAYER_RETURN_RELIC_TAKEN")]
	RetPlayerReturnRelicTaken = 4807,
	[OriginalName("RET_PLAYER_RETURN_CONFIG_ERROR")]
	RetPlayerReturnConfigError = 4808,
	[OriginalName("RET_PLAYER_RETURN_OPTIONAL_GIFT_INVALID")]
	RetPlayerReturnOptionalGiftInvalid = 4809,
	[OriginalName("RET_PLAYER_RETURN_OPTIONAL_GIFT_NOT_EXIST")]
	RetPlayerReturnOptionalGiftNotExist = 4810,
	[OriginalName("RET_PLAYER_RETURN_SIGN_TYPE_INVALID")]
	RetPlayerReturnSignTypeInvalid = 4811,
	[OriginalName("RET_AETHER_DIVIDE_NO_LINEUP")]
	RetAetherDivideNoLineup = 4851,
	[OriginalName("RET_AETHER_DIVIDE_LINEUP_INVALID")]
	RetAetherDivideLineupInvalid = 4852,
	[OriginalName("RET_CHAT_BUBBLE_ID_ERROR")]
	RetChatBubbleIdError = 4901,
	[OriginalName("RET_CHAT_BUBBLE_ID_NOT_UNLOCK")]
	RetChatBubbleIdNotUnlock = 4902,
	[OriginalName("RET_PHONE_THEME_ID_ERROR")]
	RetPhoneThemeIdError = 4903,
	[OriginalName("RET_PHONE_THEME_ID_NOT_UNLOCK")]
	RetPhoneThemeIdNotUnlock = 4904,
	[OriginalName("RET_CHAT_BUBBLE_SELECT_IS_CURRENT")]
	RetChatBubbleSelectIsCurrent = 4905,
	[OriginalName("RET_PHONE_THEME_SELECT_IS_CURRENT")]
	RetPhoneThemeSelectIsCurrent = 4906,
	[OriginalName("RET_PHONE_CASE_ID_ERROR")]
	RetPhoneCaseIdError = 4907,
	[OriginalName("RET_PHONE_CASE_ID_NOT_UNLOCK")]
	RetPhoneCaseIdNotUnlock = 4908,
	[OriginalName("RET_PHONE_CASE_SELECT_IS_CURRENT")]
	RetPhoneCaseSelectIsCurrent = 4909,
	[OriginalName("RET_CHESS_ROGUE_CONFIG_NOT_FOUND")]
	RetChessRogueConfigNotFound = 4951,
	[OriginalName("RET_CHESS_ROGUE_CONFIG_INVALID")]
	RetChessRogueConfigInvalid = 4952,
	[OriginalName("RET_CHESS_ROGUE_NO_VALID_ROOM")]
	RetChessRogueNoValidRoom = 4963,
	[OriginalName("RET_CHESS_ROGUE_NO_CELL_INFO")]
	RetChessRogueNoCellInfo = 4964,
	[OriginalName("RET_CHESS_ROGUE_CELL_NOT_FINISH")]
	RetChessRogueCellNotFinish = 4965,
	[OriginalName("RET_CHESS_ROGUE_CELL_IS_LOCKED")]
	RetChessRogueCellIsLocked = 4966,
	[OriginalName("RET_CHESS_ROGUE_SCHEDULE_NOT_MATCH")]
	RetChessRogueScheduleNotMatch = 4967,
	[OriginalName("RET_CHESS_ROGUE_STATUS_FAIL")]
	RetChessRogueStatusFail = 4968,
	[OriginalName("RET_CHESS_ROGUE_AREA_NOT_EXIST")]
	RetChessRogueAreaNotExist = 4969,
	[OriginalName("RET_CHESS_ROGUE_LINEUP_FAIL")]
	RetChessRogueLineupFail = 4970,
	[OriginalName("RET_CHESS_ROGUE_AEON_FAIL")]
	RetChessRogueAeonFail = 4980,
	[OriginalName("RET_CHESS_ROGUE_ENTER_CELL_FAIL")]
	RetChessRogueEnterCellFail = 4981,
	[OriginalName("RET_CHESS_ROGUE_ROLL_DICE_FAIL")]
	RetChessRogueRollDiceFail = 4982,
	[OriginalName("RET_CHESS_ROGUE_DICE_STATUS_FAIL")]
	RetChessRogueDiceStatusFail = 4983,
	[OriginalName("RET_CHESS_ROGUE_DICE_CNT_NOT_FULL")]
	RetChessRogueDiceCntNotFull = 4984,
	[OriginalName("RET_CHESS_ROGUE_UNLOCK")]
	RetChessRogueUnlock = 4985,
	[OriginalName("RET_CHESS_ROGUE_PICK_AVATAR_FAIL")]
	RetChessRoguePickAvatarFail = 4986,
	[OriginalName("RET_CHESS_ROGUE_AVATAR_INVALID")]
	RetChessRogueAvatarInvalid = 4987,
	[OriginalName("RET_CHESS_ROGUE_CELL_CAN_NOT_SELECT")]
	RetChessRogueCellCanNotSelect = 4988,
	[OriginalName("RET_CHESS_ROGUE_DICE_CONFIRMED")]
	RetChessRogueDiceConfirmed = 4989,
	[OriginalName("RET_CHESS_ROGUE_NOUS_DICE_NOT_MATCH")]
	RetChessRogueNousDiceNotMatch = 4990,
	[OriginalName("RET_CHESS_ROGUE_NOUS_DICE_RARITY_FAIL")]
	RetChessRogueNousDiceRarityFail = 4991,
	[OriginalName("RET_CHESS_ROGUE_NOUS_DICE_SURFACE_DUPLICATE")]
	RetChessRogueNousDiceSurfaceDuplicate = 4992,
	[OriginalName("RET_CHESS_ROGUE_NOT_IN_ROGUE")]
	RetChessRogueNotInRogue = 4993,
	[OriginalName("RET_CHESS_ROGUE_NOUS_DICE_BRANCH_LIMIT")]
	RetChessRogueNousDiceBranchLimit = 4994,
	[OriginalName("RET_HELIOBUS_NOT_OPEN")]
	RetHeliobusNotOpen = 5101,
	[OriginalName("RET_HELIOBUS_SNS_POST_NOT_UNLOCK")]
	RetHeliobusSnsPostNotUnlock = 5102,
	[OriginalName("RET_HELIOBUS_SNS_ALREADY_READ")]
	RetHeliobusSnsAlreadyRead = 5103,
	[OriginalName("RET_HELIOBUS_SNS_ALREADY_LIKED")]
	RetHeliobusSnsAlreadyLiked = 5104,
	[OriginalName("RET_HELIOBUS_SNS_ALREADY_COMMENTED")]
	RetHeliobusSnsAlreadyCommented = 5105,
	[OriginalName("RET_HELIOBUS_SNS_IN_MISSION")]
	RetHeliobusSnsInMission = 5106,
	[OriginalName("RET_HELIOBUS_SNS_ALREADY_POSTED")]
	RetHeliobusSnsAlreadyPosted = 5107,
	[OriginalName("RET_HELIOBUS_SNS_NOT_DOING_MISSION")]
	RetHeliobusSnsNotDoingMission = 5108,
	[OriginalName("RET_HELIOBUS_REWARD_LEVEL_MAX")]
	RetHeliobusRewardLevelMax = 5109,
	[OriginalName("RET_HELIOBUS_INCOME_NOT_ENOUGH")]
	RetHeliobusIncomeNotEnough = 5110,
	[OriginalName("RET_HELIOBUS_SNS_COMMENT_NOT_UNLOCK")]
	RetHeliobusSnsCommentNotUnlock = 5111,
	[OriginalName("RET_HELIOBUS_CHALLENGE_NOT_UNLOCK")]
	RetHeliobusChallengeNotUnlock = 5112,
	[OriginalName("RET_HELIOBUS_CHALLENGE_ID_ERROR")]
	RetHeliobusChallengeIdError = 5113,
	[OriginalName("RET_HELIOBUS_SKILL_NOT_UNLOCK")]
	RetHeliobusSkillNotUnlock = 5114,
	[OriginalName("RET_HELIOBUS_ACCEPT_POST_MISSION_FAIL")]
	RetHeliobusAcceptPostMissionFail = 5115,
	[OriginalName("RET_HELIOBUS_SKILL_NOT_SELECTED")]
	RetHeliobusSkillNotSelected = 5116,
	[OriginalName("RET_HELIOBUS_PLANE_TYPE_INVALID")]
	RetHeliobusPlaneTypeInvalid = 5117,
	[OriginalName("RET_REDDOT_PARAM_INVALID")]
	RetReddotParamInvalid = 5151,
	[OriginalName("RET_REDDOT_ACTIVITY_NOT_OPEN")]
	RetReddotActivityNotOpen = 5152,
	[OriginalName("RET_ROGUE_ENDLESS_ACTIVITY_CONFIG_ERROR")]
	RetRogueEndlessActivityConfigError = 5201,
	[OriginalName("RET_ROGUE_ENDLESS_ACTIVITY_NOT_OPEN")]
	RetRogueEndlessActivityNotOpen = 5202,
	[OriginalName("RET_ROGUE_ENDLESS_ACTIVITY_OVER_BONUS_REWARD_LIMIT")]
	RetRogueEndlessActivityOverBonusRewardLimit = 5203,
	[OriginalName("RET_ROGUE_ENDLESS_ACTIVITY_SCORE_NOT_MEET")]
	RetRogueEndlessActivityScoreNotMeet = 5204,
	[OriginalName("RET_ROGUE_ENDLESS_ACTIVITY_REWARD_LEVLE_ALREADY_TAKE")]
	RetRogueEndlessActivityRewardLevleAlreadyTake = 5205,
	[OriginalName("RET_HEART_DIAL_SCRIPT_NOT_FOUND")]
	RetHeartDialScriptNotFound = 5251,
	[OriginalName("RET_HEART_DIAL_SCRIPT_EMOTION_THE_SAME")]
	RetHeartDialScriptEmotionTheSame = 5252,
	[OriginalName("RET_HEART_DIAL_SCRIPT_STEP_NOT_NORMAL")]
	RetHeartDialScriptStepNotNormal = 5253,
	[OriginalName("RET_HEART_DIAL_SCRIPT_CONDITION_NOT_MATCH")]
	RetHeartDialScriptConditionNotMatch = 5254,
	[OriginalName("RET_HEART_DIAL_SCRIPT_SUBMIT_ITEM_NUM_NOT_MATCH")]
	RetHeartDialScriptSubmitItemNumNotMatch = 5255,
	[OriginalName("RET_HEART_DIAL_SCRIPT_SUBMIT_ITEM_ID_NOT_MATCH")]
	RetHeartDialScriptSubmitItemIdNotMatch = 5256,
	[OriginalName("RET_HEART_DIAL_DIALOGUE_NOT_FOUND")]
	RetHeartDialDialogueNotFound = 5257,
	[OriginalName("RET_HEART_DIAL_DIALOGUE_ALREADY_PERFORMED")]
	RetHeartDialDialogueAlreadyPerformed = 5258,
	[OriginalName("RET_HEART_DIAL_NPC_NOT_FOUND")]
	RetHeartDialNpcNotFound = 5259,
	[OriginalName("RET_HEART_DIAL_TRACE_CONFIG_NOT_FOUND")]
	RetHeartDialTraceConfigNotFound = 5260,
	[OriginalName("RET_HEART_DIAL_FLOOR_TRACE_EXIST")]
	RetHeartDialFloorTraceExist = 5261,
	[OriginalName("RET_HEART_DIAL_TRACE_FLOOR_NOT_MATCH")]
	RetHeartDialTraceFloorNotMatch = 5262,
	[OriginalName("RET_TRAVEL_BROCHURE_CONFIG_ERROR")]
	RetTravelBrochureConfigError = 5301,
	[OriginalName("RET_TRAVEL_BROCHURE_PARAM_INVALID")]
	RetTravelBrochureParamInvalid = 5302,
	[OriginalName("RET_TRAVEL_BROCHURE_LOCKED")]
	RetTravelBrochureLocked = 5303,
	[OriginalName("RET_TRAVEL_BROCHURE_CANNOT_OPERATE")]
	RetTravelBrochureCannotOperate = 5304,
	[OriginalName("RET_TRAVEL_BROCHURE_WORLD_ID_NOT_MATCH")]
	RetTravelBrochureWorldIdNotMatch = 5305,
	[OriginalName("RET_TRAVEL_BROCHURE_HAS_NO_WORLD_BOOK")]
	RetTravelBrochureHasNoWorldBook = 5306,
	[OriginalName("RET_TRAVEL_BROCHURE_PAGE_FULL")]
	RetTravelBrochurePageFull = 5307,
	[OriginalName("RET_MAP_ROTATION_NOT_IN_REGION")]
	RetMapRotationNotInRegion = 5351,
	[OriginalName("RET_MAP_ROTATION_ROTATER_ALREADY_DEPLOYED")]
	RetMapRotationRotaterAlreadyDeployed = 5352,
	[OriginalName("RET_MAP_ROTATION_ENERGY_NOT_ENOUGH")]
	RetMapRotationEnergyNotEnough = 5353,
	[OriginalName("RET_MAP_ROTATION_ENTITY_NOT_ON_CUR_POSE")]
	RetMapRotationEntityNotOnCurPose = 5354,
	[OriginalName("RET_MAP_ROTATION_ROTATER_NOT_DEPLOYED")]
	RetMapRotationRotaterNotDeployed = 5355,
	[OriginalName("RET_MAP_ROTATION_POSE_ROTATER_MISMATCH")]
	RetMapRotationPoseRotaterMismatch = 5356,
	[OriginalName("RET_MAP_ROTATION_ROTATER_NOT_REMOVABLE")]
	RetMapRotationRotaterNotRemovable = 5357,
	[OriginalName("RET_MAP_ROTATION_ROTATER_DISPOSABLE")]
	RetMapRotationRotaterDisposable = 5358,
	[OriginalName("RET_SPACE_ZOO_ACTIVITY_CAT_NOT_FOUND")]
	RetSpaceZooActivityCatNotFound = 5401,
	[OriginalName("RET_SPACE_ZOO_ACTIVITY_CAT_PARAM_INVALID")]
	RetSpaceZooActivityCatParamInvalid = 5402,
	[OriginalName("RET_SPACE_ZOO_ACTIVITY_CAT_ITEM_NOT_ENOUGH")]
	RetSpaceZooActivityCatItemNotEnough = 5403,
	[OriginalName("RET_SPACE_ZOO_ACTIVITY_CAT_BAG_FULL")]
	RetSpaceZooActivityCatBagFull = 5404,
	[OriginalName("RET_SPACE_ZOO_ACTIVITY_CAT_NOT_TO_MUTATE")]
	RetSpaceZooActivityCatNotToMutate = 5405,
	[OriginalName("RET_SPACE_ZOO_ACTIVITY_CAT_STATE_ERROR")]
	RetSpaceZooActivityCatStateError = 5406,
	[OriginalName("RET_SPACE_ZOO_ACTIVITY_CAT_CATTERY_LOCKED")]
	RetSpaceZooActivityCatCatteryLocked = 5407,
	[OriginalName("RET_SPACE_ZOO_ACTIVITY_CAT_OUT_NOW")]
	RetSpaceZooActivityCatOutNow = 5408,
	[OriginalName("RET_SPACE_ZOO_ACTIVITY_CAT_CONFIG_NOT_FOUND")]
	RetSpaceZooActivityCatConfigNotFound = 5409,
	[OriginalName("RET_SPACE_ZOO_ACTIVITY_CAT_FEATURE_NOT_FOUND")]
	RetSpaceZooActivityCatFeatureNotFound = 5410,
	[OriginalName("RET_SPACE_ZOO_ACTIVITY_CAT_ADD_CAT_ERROR")]
	RetSpaceZooActivityCatAddCatError = 5411,
	[OriginalName("RET_SPACE_ZOO_ACTIVITY_CAT_MONEY_NOT_ENOUGH")]
	RetSpaceZooActivityCatMoneyNotEnough = 5412,
	[OriginalName("RET_SPACE_ZOO_ACTIVITY_CAT_COND_NOT_MATCH")]
	RetSpaceZooActivityCatCondNotMatch = 5413,
	[OriginalName("RET_STRONG_CHALLENGE_ACTIVITY_STAGE_CFG_MISS")]
	RetStrongChallengeActivityStageCfgMiss = 5501,
	[OriginalName("RET_STRONG_CHALLENGE_ACTIVITY_STAGE_NOT_OPEN")]
	RetStrongChallengeActivityStageNotOpen = 5502,
	[OriginalName("RET_STRONG_CHALLENGE_ACTIVITY_BUFF_ERROR")]
	RetStrongChallengeActivityBuffError = 5503,
	[OriginalName("RET_ROLL_SHOP_NOT_FOUND")]
	RetRollShopNotFound = 5551,
	[OriginalName("RET_ROLL_SHOP_GROUP_EMPTY")]
	RetRollShopGroupEmpty = 5552,
	[OriginalName("RET_ROLL_SHOP_EMPTY")]
	RetRollShopEmpty = 5553,
	[OriginalName("RET_ROLL_SHOP_GACHA_REQ_DUPLICATED")]
	RetRollShopGachaReqDuplicated = 5554,
	[OriginalName("RET_ROLL_SHOP_RANDOM_ERROR")]
	RetRollShopRandomError = 5555,
	[OriginalName("RET_ROLL_SHOP_GROUP_TYPE_NOT_FOUND")]
	RetRollShopGroupTypeNotFound = 5556,
	[OriginalName("RET_ROLL_SHOP_HAS_STORED_REWARD_ALREADY")]
	RetRollShopHasStoredRewardAlready = 5557,
	[OriginalName("RET_ROLL_SHOP_NO_STORED_REWARD")]
	RetRollShopNoStoredReward = 5558,
	[OriginalName("RET_ROLL_SHOP_NOT_IN_VALID_SCENE")]
	RetRollShopNotInValidScene = 5559,
	[OriginalName("RET_ROLL_SHOP_INVALID_ROLL_SHOP_TYPE")]
	RetRollShopInvalidRollShopType = 5560,
	[OriginalName("RET_ACTIVITY_RAID_COLLECTION_PREV_NOT_FINISH")]
	RetActivityRaidCollectionPrevNotFinish = 5601,
	[OriginalName("RET_ACTIVITY_RAID_COLLECTION_GROUP_ENTER_NEXT_UNAVAILABLE")]
	RetActivityRaidCollectionGroupEnterNextUnavailable = 5602,
	[OriginalName("RET_ACTIVITY_RAID_COLLECTION_IS_LAST")]
	RetActivityRaidCollectionIsLast = 5603,
	[OriginalName("RET_ACTIVITY_RAID_COLLECTION_IS_NOT_NEXT")]
	RetActivityRaidCollectionIsNotNext = 5604,
	[OriginalName("RET_OFFERING_NOT_UNLOCK")]
	RetOfferingNotUnlock = 5651,
	[OriginalName("RET_OFFERING_LEVEL_NOT_UNLOCK")]
	RetOfferingLevelNotUnlock = 5652,
	[OriginalName("RET_OFFERING_REACH_MAX_LEVEL")]
	RetOfferingReachMaxLevel = 5653,
	[OriginalName("RET_OFFERING_ITEM_NOT_ENOUGH")]
	RetOfferingItemNotEnough = 5654,
	[OriginalName("RET_OFFERING_LONGTAIL_NOT_OPEN")]
	RetOfferingLongtailNotOpen = 5655,
	[OriginalName("RET_OFFERING_REWARD_CONDITION")]
	RetOfferingRewardCondition = 5656,
	[OriginalName("RET_DRINK_MAKER_CHAT_INVALID")]
	RetDrinkMakerChatInvalid = 5701,
	[OriginalName("RET_DRINK_MAKER_PARAM_INVALID")]
	RetDrinkMakerParamInvalid = 5702,
	[OriginalName("RET_DRINK_MAKER_PARAM_NOT_UNLOCK")]
	RetDrinkMakerParamNotUnlock = 5703,
	[OriginalName("RET_DRINK_MAKER_CONFIG_NOT_FOUND")]
	RetDrinkMakerConfigNotFound = 5704,
	[OriginalName("RET_DRINK_MAKER_NOT_LAST_CHAT")]
	RetDrinkMakerNotLastChat = 5705,
	[OriginalName("RET_DRINK_MAKER_DAY_AND_FREE_PHASE_NOT_OPEN")]
	RetDrinkMakerDayAndFreePhaseNotOpen = 5706,
	[OriginalName("RET_DRINK_MAKER_CHEERS_NOT_ABLE_TO_NEXT_GROUP")]
	RetDrinkMakerCheersNotAbleToNextGroup = 5707,
	[OriginalName("RET_DRINK_MAKER_CHEERS_DRINK_ALREADY_MADE")]
	RetDrinkMakerCheersDrinkAlreadyMade = 5708,
	[OriginalName("RET_DRINK_MAKER_CHEERS_ACTIVITY_NOT_OPEN")]
	RetDrinkMakerCheersActivityNotOpen = 5709,
	[OriginalName("RET_DRINK_MAKER_CHEERS_MAKE_DRINK_PRE_MISSION_NOT_FINISHED")]
	RetDrinkMakerCheersMakeDrinkPreMissionNotFinished = 5710,
	[OriginalName("RET_MONOPOLY_NOT_OPEN")]
	RetMonopolyNotOpen = 5751,
	[OriginalName("RET_MONOPOLY_CONFIG_ERROR")]
	RetMonopolyConfigError = 5752,
	[OriginalName("RET_MONOPOLY_DICE_NOT_ENOUGH")]
	RetMonopolyDiceNotEnough = 5753,
	[OriginalName("RET_MONOPOLY_CUR_CELL_NOT_FINISH")]
	RetMonopolyCurCellNotFinish = 5754,
	[OriginalName("RET_MONOPOLY_COIN_NOT_ENOUGH")]
	RetMonopolyCoinNotEnough = 5755,
	[OriginalName("RET_MONOPOLY_CELL_WAIT_PENDING")]
	RetMonopolyCellWaitPending = 5756,
	[OriginalName("RET_MONOPOLY_CELL_STATE_ERROR")]
	RetMonopolyCellStateError = 5757,
	[OriginalName("RET_MONOPOLY_CELL_CONTENT_ERROR")]
	RetMonopolyCellContentError = 5758,
	[OriginalName("RET_MONOPOLY_ITEM_NOT_ENOUGH")]
	RetMonopolyItemNotEnough = 5759,
	[OriginalName("RET_MONOPOLY_CELL_CONTENT_CANNOT_GIVEUP")]
	RetMonopolyCellContentCannotGiveup = 5760,
	[OriginalName("RET_MONOPOLY_ASSET_LEVEL_INVALID")]
	RetMonopolyAssetLevelInvalid = 5761,
	[OriginalName("RET_MONOPOLY_TURN_NOT_FINISH")]
	RetMonopolyTurnNotFinish = 5762,
	[OriginalName("RET_MONOPOLY_GUIDE_NOT_FINISH")]
	RetMonopolyGuideNotFinish = 5763,
	[OriginalName("RET_MONOPOLY_RAFFLE_REWARD_REISSUED")]
	RetMonopolyRaffleRewardReissued = 5764,
	[OriginalName("RET_MONOPOLY_NO_GAME_ACTIVE")]
	RetMonopolyNoGameActive = 5771,
	[OriginalName("RET_MONOPOLY_GAME_RATIO_NOT_INCREASABLE")]
	RetMonopolyGameRatioNotIncreasable = 5772,
	[OriginalName("RET_MONOPOLY_GAME_RATIO_MAX")]
	RetMonopolyGameRatioMax = 5773,
	[OriginalName("RET_MONOPOLY_GAME_TARGET_RATIO_INVALID")]
	RetMonopolyGameTargetRatioInvalid = 5774,
	[OriginalName("RET_MONOPOLY_GAME_BINGO_FLIP_POS_INVALID")]
	RetMonopolyGameBingoFlipPosInvalid = 5775,
	[OriginalName("RET_MONOPOLY_GAME_GUESS_ALREADY_CHOOSE")]
	RetMonopolyGameGuessAlreadyChoose = 5776,
	[OriginalName("RET_MONOPOLY_GAME_GUESS_CHOOSE_INVALID")]
	RetMonopolyGameGuessChooseInvalid = 5777,
	[OriginalName("RET_MONOPOLY_GAME_GUESS_INFORMATION_ALREADY_BOUGHT")]
	RetMonopolyGameGuessInformationAlreadyBought = 5778,
	[OriginalName("RET_MONOPOLY_GAME_RAISE_RATIO_NOT_UNLOCK")]
	RetMonopolyGameRaiseRatioNotUnlock = 5779,
	[OriginalName("RET_MONOPOLY_FRIEND_NOT_SYNCED")]
	RetMonopolyFriendNotSynced = 5785,
	[OriginalName("RET_MONOPOLY_GET_FRIEND_RANKING_LIST_IN_CD")]
	RetMonopolyGetFriendRankingListInCd = 5786,
	[OriginalName("RET_MONOPOLY_LIKE_TARGET_NOT_FRIEND")]
	RetMonopolyLikeTargetNotFriend = 5787,
	[OriginalName("RET_MONOPOLY_DAILY_ALREADY_LIKED")]
	RetMonopolyDailyAlreadyLiked = 5788,
	[OriginalName("RET_MONOPOLY_SOCIAL_EVENT_STATUS_NOT_MATCH")]
	RetMonopolySocialEventStatusNotMatch = 5789,
	[OriginalName("RET_MONOPOLY_SOCIAL_EVENT_SERVER_CACHE_NOT_EXIST")]
	RetMonopolySocialEventServerCacheNotExist = 5790,
	[OriginalName("RET_MONOPOLY_ACTIVITY_ID_NOT_MATCH")]
	RetMonopolyActivityIdNotMatch = 5791,
	[OriginalName("RET_MONOPOLY_RAFFLE_POOL_NOT_EXIST")]
	RetMonopolyRafflePoolNotExist = 5792,
	[OriginalName("RET_MONOPOLY_RAFFLE_POOL_TIME_NOT_MATCH")]
	RetMonopolyRafflePoolTimeNotMatch = 5793,
	[OriginalName("RET_MONOPOLY_RAFFLE_POOL_PHASE_NOT_MEET")]
	RetMonopolyRafflePoolPhaseNotMeet = 5794,
	[OriginalName("RET_MONOPOLY_RAFFLE_POOL_SHOW_TIME_NOT_MEET")]
	RetMonopolyRafflePoolShowTimeNotMeet = 5795,
	[OriginalName("RET_MONOPOLY_RAFFLE_TICKET_NOT_FOUND")]
	RetMonopolyRaffleTicketNotFound = 5796,
	[OriginalName("RET_MONOPOLY_RAFFLE_TICKET_TIME_NOT_MEET")]
	RetMonopolyRaffleTicketTimeNotMeet = 5797,
	[OriginalName("RET_MONOPOLY_RAFFLE_TICKET_REWARD_ALREADY_TAKEN")]
	RetMonopolyRaffleTicketRewardAlreadyTaken = 5798,
	[OriginalName("RET_MONOPOLY_RAFFLE_POOL_NOT_IN_RAFFLE_TIME")]
	RetMonopolyRafflePoolNotInRaffleTime = 5799,
	[OriginalName("RET_MONOPOLY_MBTI_REPORT_REWARD_ALREADY_TAKEN")]
	RetMonopolyMbtiReportRewardAlreadyTaken = 5800,
	[OriginalName("RET_EVOLVE_BUILD_LEVEL_GAMING")]
	RetEvolveBuildLevelGaming = 5801,
	[OriginalName("RET_EVEOLVE_BUILD_LEVEL_BAN_RANDOM")]
	RetEveolveBuildLevelBanRandom = 5802,
	[OriginalName("RET_EVOLVE_BUILD_FIRST_REWARD_ALREADY_TAKEN")]
	RetEvolveBuildFirstRewardAlreadyTaken = 5803,
	[OriginalName("RET_EVOLVE_BUILD_LEVEL_UNFINISH")]
	RetEvolveBuildLevelUnfinish = 5804,
	[OriginalName("RET_EVOLVE_BUILD_SHOP_ABILITY_MAX_LEVEL")]
	RetEvolveBuildShopAbilityMaxLevel = 5805,
	[OriginalName("RET_EVOLVE_BUILD_SHOP_ABILITY_MIN_LEVEL")]
	RetEvolveBuildShopAbilityMinLevel = 5806,
	[OriginalName("RET_EVOLVE_BUILD_SHOP_ABILITY_NOT_GET")]
	RetEvolveBuildShopAbilityNotGet = 5807,
	[OriginalName("RET_EVOLVE_BUILD_LEVEL_LOCK")]
	RetEvolveBuildLevelLock = 5808,
	[OriginalName("RET_EVOLVE_BUILD_EXP_NOT_ENOUGH")]
	RetEvolveBuildExpNotEnough = 5809,
	[OriginalName("RET_EVOLVE_BUILD_SHOP_ABILITY_LEVEL_ERROR")]
	RetEvolveBuildShopAbilityLevelError = 5810,
	[OriginalName("RET_EVOLVE_BUILD_ACTIVITY_NOT_OPEN")]
	RetEvolveBuildActivityNotOpen = 5811,
	[OriginalName("RET_EVOLVE_BUILD_SHOP_ABILITY_EMPTY")]
	RetEvolveBuildShopAbilityEmpty = 5812,
	[OriginalName("RET_EVOLVE_BUILD_LEVEL_NOT_START")]
	RetEvolveBuildLevelNotStart = 5813,
	[OriginalName("RET_EVOLVE_BUILD_SHOP_LOCK")]
	RetEvolveBuildShopLock = 5814,
	[OriginalName("RET_EVOLVE_BUILD_REWARD_LOCK")]
	RetEvolveBuildRewardLock = 5815,
	[OriginalName("RET_EVOLVE_BUILD_REWARD_LEVEL_MAX")]
	RetEvolveBuildRewardLevelMax = 5816,
	[OriginalName("RET_EVOLVE_BUILD_REWARD_ALREADY_ALL_TAKEN")]
	RetEvolveBuildRewardAlreadyAllTaken = 5717,
	[OriginalName("RET_EVOLVE_BUILD_SEASON_ERROR")]
	RetEvolveBuildSeasonError = 5718,
	[OriginalName("RET_EVOLVE_BUILD_TEACH_SKIP_QUEST_NOT_FINISH")]
	RetEvolveBuildTeachSkipQuestNotFinish = 5719,
	[OriginalName("RET_CLOCK_PARK_CONFIG_ERROR")]
	RetClockParkConfigError = 5851,
	[OriginalName("RET_CLOCK_PARK_EFFECT_ERROR")]
	RetClockParkEffectError = 5852,
	[OriginalName("RET_CLOCK_PARK_SCRIPT_ALREADY_UNLOCK")]
	RetClockParkScriptAlreadyUnlock = 5853,
	[OriginalName("RET_CLOCK_PARK_SCRIPT_UNLOCK_CONDITION_NOT_MEET")]
	RetClockParkScriptUnlockConditionNotMeet = 5854,
	[OriginalName("RET_CLOCK_PARK_TALENT_ALREADY_UNLOCK")]
	RetClockParkTalentAlreadyUnlock = 5855,
	[OriginalName("RET_CLOCK_PARK_SCRIPT_LOCKED")]
	RetClockParkScriptLocked = 5856,
	[OriginalName("RET_CLOCK_PARK_HAS_ONGOING_SCRIPT")]
	RetClockParkHasOngoingScript = 5857,
	[OriginalName("RET_CLOCK_PARK_NO_ONGOING_SCRIPT")]
	RetClockParkNoOngoingScript = 5858,
	[OriginalName("RET_CLOCK_PARK_DICE_PLACEMENT_ERROR")]
	RetClockParkDicePlacementError = 5859,
	[OriginalName("RET_CLOCK_PARK_MISMATCH_STATUS")]
	RetClockParkMismatchStatus = 5860,
	[OriginalName("RET_CLOCK_PARK_NO_BUFF")]
	RetClockParkNoBuff = 5861,
	[OriginalName("RET_CLOCK_PARK_SLOT_MACHINE_GACHA_REQ_DUPLICATED")]
	RetClockParkSlotMachineGachaReqDuplicated = 5862,
	[OriginalName("RET_CLOCK_PARK_SLOT_MACHINE_COST_NOT_ENOUGH")]
	RetClockParkSlotMachineCostNotEnough = 5863,
	[OriginalName("RET_CLOCK_PARK_SLOT_MACHINE_GACHA_CNT_EXCEED_LIMIT")]
	RetClockParkSlotMachineGachaCntExceedLimit = 5864,
	[OriginalName("RET_CLOCK_PARK_NOT_OPEN")]
	RetClockParkNotOpen = 5865,
	[OriginalName("RET_TOURN_ROGUE_STATUS_MISMATCH")]
	RetTournRogueStatusMismatch = 5901,
	[OriginalName("RET_MAGIC_ROGUE_STATUS_MISMATCH")]
	RetMagicRogueStatusMismatch = 5902,
	[OriginalName("RET_AUTO_MOUNT_MAGIC_UNIT_NO_MATCHED_MAGIC_SCEPTER")]
	RetAutoMountMagicUnitNoMatchedMagicScepter = 5903,
	[OriginalName("RET_MAGIC_UNIT_WORKBENCH_REFORGE_GEN_FAIL")]
	RetMagicUnitWorkbenchReforgeGenFail = 5904,
	[OriginalName("RET_MATCH_ALREADY_IN_MATCH")]
	RetMatchAlreadyInMatch = 6201,
	[OriginalName("RET_MATCH_NOT_IN_MATCH")]
	RetMatchNotInMatch = 6202,
	[OriginalName("RET_MATCH_PLAY_NOT_OPEN")]
	RetMatchPlayNotOpen = 6203,
	[OriginalName("RET_CROSS_STATE_ERROR")]
	RetCrossStateError = 6204,
	[OriginalName("RET_MATCH_VERSION_NOT_EQUAL")]
	RetMatchVersionNotEqual = 6205,
	[OriginalName("RET_MATCH_PLAYER_NOT_IN_LOBBY_ROOM")]
	RetMatchPlayerNotInLobbyRoom = 6206,
	[OriginalName("RET_LOBBY_STATE_NOT_MATCH")]
	RetLobbyStateNotMatch = 6207,
	[OriginalName("RET_LOBBY_ROOM_NOT_EXIST")]
	RetLobbyRoomNotExist = 6208,
	[OriginalName("RET_LOBBY_ROOM_PALYER_FULL")]
	RetLobbyRoomPalyerFull = 6209,
	[OriginalName("RET_LOBBY_ROOM_PALYER_NOT_READY")]
	RetLobbyRoomPalyerNotReady = 6210,
	[OriginalName("RET_LOBBY_ROOM_PALYER_FIGHTING")]
	RetLobbyRoomPalyerFighting = 6211,
	[OriginalName("RET_FIGHT_ROOM_NOT_EXIST")]
	RetFightRoomNotExist = 6250,
	[OriginalName("RET_FIGHT_MATCH3_PLAYER_STATE_ERR")]
	RetFightMatch3PlayerStateErr = 6251,
	[OriginalName("RET_FIGHT_MATCH3_ROOM_STATE_ERR")]
	RetFightMatch3RoomStateErr = 6252,
	[OriginalName("RET_CROSS_STATE_TIME_OUT")]
	RetCrossStateTimeOut = 6253,
	[OriginalName("RET_LOBBY_START_FIGHT_DISABLE")]
	RetLobbyStartFightDisable = 6254,
	[OriginalName("RET_LOBBY_START_FIGHT_PLAYER_LACK")]
	RetLobbyStartFightPlayerLack = 6255,
	[OriginalName("RET_MATCH_CLIENT_DATA_VERSION_LOW")]
	RetMatchClientDataVersionLow = 6256,
	[OriginalName("RET_LOBBY_START_MATCH_DISABLE")]
	RetLobbyStartMatchDisable = 6257,
	[OriginalName("RET_LOBBY_INTERACT_IN_CD")]
	RetLobbyInteractInCd = 6258,
	[OriginalName("RET_LOBBY_OWNER_STATE_ERR")]
	RetLobbyOwnerStateErr = 6259,
	[OriginalName("RET_LOBBY_OP_TOO_FAST")]
	RetLobbyOpTooFast = 6260,
	[OriginalName("RET_FIGHT_MATCH3_SOLO_PLAYER_TURN_ERR")]
	RetFightMatch3SoloPlayerTurnErr = 6261,
	[OriginalName("RET_MATCH_PLAY_NOT_SUPPORTED")]
	RetMatchPlayNotSupported = 6262,
	[OriginalName("RET_MATCH_PLAY_DATA_NOT_EXIST")]
	RetMatchPlayDataNotExist = 6263,
	[OriginalName("RET_MATCH_PLAY_NOT_SUPPORT_FRIEND_RANKING")]
	RetMatchPlayNotSupportFriendRanking = 6264,
	[OriginalName("RET_MATCH_PLAY_GET_FRIEND_RANKING_INFO_IN_CD")]
	RetMatchPlayGetFriendRankingInfoInCd = 6265,
	[OriginalName("RET_SWORD_TRAINING_NO_ACTIVE_GAME")]
	RetSwordTrainingNoActiveGame = 6301,
	[OriginalName("RET_SWORD_TRAINING_NO_PENDING_ACTION_MATCH")]
	RetSwordTrainingNoPendingActionMatch = 6302,
	[OriginalName("RET_SWORD_TRAINING_PARTNER_ABILITY_INVALID")]
	RetSwordTrainingPartnerAbilityInvalid = 6303,
	[OriginalName("RET_SWORD_TRAINING_SKILL_ALREADY_LEARNED")]
	RetSwordTrainingSkillAlreadyLearned = 6304,
	[OriginalName("RET_SWORD_TRAINING_CONDITION_NOT_MEET")]
	RetSwordTrainingConditionNotMeet = 6305,
	[OriginalName("RET_SWORD_TRAINING_PARENT_SKILL_NOT_LEARNED")]
	RetSwordTrainingParentSkillNotLearned = 6306,
	[OriginalName("RET_SWORD_TRAINING_SKILL_TYPE_NOT_UNLOCK")]
	RetSwordTrainingSkillTypeNotUnlock = 6307,
	[OriginalName("RET_SWORD_TRAINING_GAME_ALREADY_EXIST")]
	RetSwordTrainingGameAlreadyExist = 6308,
	[OriginalName("RET_SWORD_TRAINING_ENDING_HINT_NOT_MATCH")]
	RetSwordTrainingEndingHintNotMatch = 6309,
	[OriginalName("RET_SWORD_TRAINING_STORYLINE_CONFIG_NOT_FOUND")]
	RetSwordTrainingStorylineConfigNotFound = 6310,
	[OriginalName("RET_SWORD_TRAINING_STORY_CONFIG_NOT_FOUND")]
	RetSwordTrainingStoryConfigNotFound = 6311,
	[OriginalName("RET_SWORD_TRAINING_UNLOCK_NOT_FINISH")]
	RetSwordTrainingUnlockNotFinish = 6312,
	[OriginalName("RET_SWORD_TRAINING_OPTION_MISMATCH")]
	RetSwordTrainingOptionMismatch = 6313,
	[OriginalName("RET_SWORD_TRAINING_RESTORE_WITHOUT_EXAM_FAILED")]
	RetSwordTrainingRestoreWithoutExamFailed = 6314,
	[OriginalName("RET_SWORD_TRAINING_NO_RESTORE_GAME_AVAILABLE")]
	RetSwordTrainingNoRestoreGameAvailable = 6315,
	[OriginalName("RET_SWORD_TRAINING_ENDING_STORY_NOT_MATCH")]
	RetSwordTrainingEndingStoryNotMatch = 6316,
	[OriginalName("RET_SWORD_TRAINING_ENDING_NOT_FINISH")]
	RetSwordTrainingEndingNotFinish = 6317,
	[OriginalName("RET_SWORD_TRAINING_ENDING_REWARD_TAKEN")]
	RetSwordTrainingEndingRewardTaken = 6318,
	[OriginalName("RET_SWORD_TRAINING_COMBAT_RANK_NOT_CHANGE")]
	RetSwordTrainingCombatRankNotChange = 6319,
	[OriginalName("RET_SWORD_TRAINING_DIRECT_BATTLE_DISABLE")]
	RetSwordTrainingDirectBattleDisable = 6320,
	[OriginalName("RET_FIGHT_FEST_PHASE_NOT_MATCH")]
	RetFightFestPhaseNotMatch = 6351,
	[OriginalName("RET_FIGHT_FEST_SCORE_RACE_ALREADY_FINISH")]
	RetFightFestScoreRaceAlreadyFinish = 6352,
	[OriginalName("RET_FIGHT_FEST_CHALLENGE_LOCKED")]
	RetFightFestChallengeLocked = 6353,
	[OriginalName("RET_FIGHT_FEST_COACH_SKILL_LOCKED")]
	RetFightFestCoachSkillLocked = 6354,
	[OriginalName("RET_FIGHT_FEST_COACH_SKILL_EQUIP_TYPE_EXISTED")]
	RetFightFestCoachSkillEquipTypeExisted = 6355,
	[OriginalName("RET_FIGHT_FEST_SCORE_RACE_MISSION_DOIND")]
	RetFightFestScoreRaceMissionDoind = 6356,
	[OriginalName("RET_FIGHT_FEST_COACH_SKILL_NO_EQUIP")]
	RetFightFestCoachSkillNoEquip = 6357,
	[OriginalName("RET_PET_NOT_EXIST")]
	RetPetNotExist = 6401,
	[OriginalName("RET_PET_ALREADY_SUMMONED")]
	RetPetAlreadySummoned = 6402,
	[OriginalName("RET_PET_NOT_SUMMONED")]
	RetPetNotSummoned = 6403,
	[OriginalName("RET_MUSIC_RHYTHM_LEVEL_TIME_TOO_SHORT")]
	RetMusicRhythmLevelTimeTooShort = 6451,
	[OriginalName("RET_MUSIC_RHYTHM_NOT_IN_LEVEL")]
	RetMusicRhythmNotInLevel = 6452,
	[OriginalName("RET_MUSIC_RHYTHM_PRE_DIFFICULTY_NOT_PASS")]
	RetMusicRhythmPreDifficultyNotPass = 6453,
	[OriginalName("RET_MUSIC_RHYTHM_SONG_LIMITED")]
	RetMusicRhythmSongLimited = 6454,
	[OriginalName("RET_MUSIC_RHYTHM_SONG_LOCKED")]
	RetMusicRhythmSongLocked = 6455,
	[OriginalName("RET_MUSIC_RHYTHM_TRACK_LOCKED")]
	RetMusicRhythmTrackLocked = 6456,
	[OriginalName("RET_MUSIC_RHYTHM_LEVEL_NOT_UNLOCK")]
	RetMusicRhythmLevelNotUnlock = 6457,
	[OriginalName("RET_MUSIC_RHYTHM_SONG_SFX_LOCKED")]
	RetMusicRhythmSongSfxLocked = 6458,
	[OriginalName("RET_TRAIN_PARTY_COIN_NOT_ENOUGH")]
	RetTrainPartyCoinNotEnough = 6501,
	[OriginalName("RET_TRAIN_PARTY_DIY_TAG_NOT_MATCH")]
	RetTrainPartyDiyTagNotMatch = 6502,
	[OriginalName("RET_TRAIN_PARTY_USE_CARD_MOBILITY_NOT_ENOUGH")]
	RetTrainPartyUseCardMobilityNotEnough = 6503,
	[OriginalName("RET_TRAIN_PARTY_AREA_UNLOCK_COIN_NOT_ENOUGH")]
	RetTrainPartyAreaUnlockCoinNotEnough = 6504,
	[OriginalName("RET_TAROT_BOOK_ENERGY_NOT_ENOUGH")]
	RetTarotBookEnergyNotEnough = 6601,
	[OriginalName("RET_TAROT_BOOK_PACK_NOT_AVAILABLE")]
	RetTarotBookPackNotAvailable = 6602,
	[OriginalName("RET_TAROT_BOOK_STORY_ALREADY_UNLOCK")]
	RetTarotBookStoryAlreadyUnlock = 6603,
	[OriginalName("RET_TAROT_BOOK_CARD_NOT_ENOUGH")]
	RetTarotBookCardNotEnough = 6604,
	[OriginalName("RET_TAROT_BOOK_CLUE_NOT_ENOUGH")]
	RetTarotBookClueNotEnough = 6605,
	[OriginalName("RET_TAROT_BOOK_UNLOCK_STORY_CARD_NOT_SAME")]
	RetTarotBookUnlockStoryCardNotSame = 6606,
	[OriginalName("RET_TAROT_BOOK_STORY_NOT_UNLOCK")]
	RetTarotBookStoryNotUnlock = 6607,
	[OriginalName("RET_TAROT_BOOK_STORY_ALREADY_FINISH")]
	RetTarotBookStoryAlreadyFinish = 6608,
	[OriginalName("RET_TAROT_BOOK_INTERACTION_ALREADY_FINISH")]
	RetTarotBookInteractionAlreadyFinish = 6609,
	[OriginalName("RET_CHIMERA_CHIMERA_NOT_UNLOCK")]
	RetChimeraChimeraNotUnlock = 6621,
	[OriginalName("RET_CHIMERA_CHIMERA_DUPLICATED")]
	RetChimeraChimeraDuplicated = 6622,
	[OriginalName("RET_CHIMERA_CHIMERA_TYPE_ERROR")]
	RetChimeraChimeraTypeError = 6623,
	[OriginalName("RET_CHIMERA_WORK_MISMATCH_ROUND")]
	RetChimeraWorkMismatchRound = 6624,
	[OriginalName("RET_CHIMERA_WORK_ROUND_OPTION_NOT_MEET")]
	RetChimeraWorkRoundOptionNotMeet = 6625,
	[OriginalName("RET_CHIMERA_ENDLESS_NOT_UNLOCK")]
	RetChimeraEndlessNotUnlock = 6626,
	[OriginalName("RET_CHIMERA_IN_ENDLESS")]
	RetChimeraInEndless = 6627,
	[OriginalName("RET_CHIMERA_NOT_IN_ENDLESS")]
	RetChimeraNotInEndless = 6628,
	[OriginalName("RET_CHIMERA_CHIMERA_FALL_IN_ENDLESS")]
	RetChimeraChimeraFallInEndless = 6629,
	[OriginalName("RET_PLANET_FES_AVATAR_NOT_EXIST")]
	RetPlanetFesAvatarNotExist = 6641,
	[OriginalName("RET_PLANET_FES_LAND_NOT_EXIST")]
	RetPlanetFesLandNotExist = 6642,
	[OriginalName("RET_PLANET_FES_ITEM_NOT_ENOUGH")]
	RetPlanetFesItemNotEnough = 6643,
	[OriginalName("RET_PLANET_FES_LAND_ALREADY_UNLOCK")]
	RetPlanetFesLandAlreadyUnlock = 6644,
	[OriginalName("RET_PLANET_FES_WORK_AVATAR_REPEAT")]
	RetPlanetFesWorkAvatarRepeat = 6645,
	[OriginalName("RET_PLANET_FES_WORK_AVATAR_TYPE_NOT_MATCH")]
	RetPlanetFesWorkAvatarTypeNotMatch = 6646,
	[OriginalName("RET_PLANET_FES_ACTIVITY_NOT_OPEN")]
	RetPlanetFesActivityNotOpen = 6647,
	[OriginalName("RET_PLANET_FES_SKILLTREE_PHASE_NOT_UNLOCK")]
	RetPlanetFesSkilltreePhaseNotUnlock = 6648,
	[OriginalName("RET_PLANET_FES_SKILL_NOT_UNLOCK")]
	RetPlanetFesSkillNotUnlock = 6649,
	[OriginalName("RET_PLANET_FES_CONFIG_ERROR")]
	RetPlanetFesConfigError = 6650,
	[OriginalName("RET_PLANET_FES_NOT_IN_BUSINESS_DAY")]
	RetPlanetFesNotInBusinessDay = 6651,
	[OriginalName("RET_PLANET_FES_EVENT_LOCKED")]
	RetPlanetFesEventLocked = 6652,
	[OriginalName("RET_PLANET_FES_EVENT_FINISHED")]
	RetPlanetFesEventFinished = 6653,
	[OriginalName("RET_PLANET_FES_EVENT_IN_CD")]
	RetPlanetFesEventInCd = 6654,
	[OriginalName("RET_PLANET_FES_EVENT_ALREADY_IN_STATE")]
	RetPlanetFesEventAlreadyInState = 6655,
	[OriginalName("RET_PLANET_FES_EVENT_NO_WORK_AVATAR")]
	RetPlanetFesEventNoWorkAvatar = 6656,
	[OriginalName("RET_PLANET_FES_EVENT_PROCESSING_CANNOT_DISAPPEAR")]
	RetPlanetFesEventProcessingCannotDisappear = 6657,
	[OriginalName("RET_PLANET_FES_EVENT_OPTION_PHASE_WRONG")]
	RetPlanetFesEventOptionPhaseWrong = 6658,
	[OriginalName("RET_PLANET_FES_FUNCTION_NOT_UNLOCK")]
	RetPlanetFesFunctionNotUnlock = 6659,
	[OriginalName("RET_PLANET_FES_REWARD_ALREADY_TAKEN")]
	RetPlanetFesRewardAlreadyTaken = 6660,
	[OriginalName("RET_PLANET_FES_EVENT_GAME_NOT_ACTIVE")]
	RetPlanetFesEventGameNotActive = 6661,
	[OriginalName("RET_PLANET_FES_REGION_PROGRESS_NOT_ENOUGH")]
	RetPlanetFesRegionProgressNotEnough = 6662,
	[OriginalName("RET_PLANET_FES_FRIEND_ITEM_NOT_ENOUGH")]
	RetPlanetFesFriendItemNotEnough = 6663,
	[OriginalName("RET_PLANET_FES_PIECE_PERMISSION_BAN")]
	RetPlanetFesPiecePermissionBan = 6664,
	[OriginalName("RET_PLANET_FES_PIECE_OFFER_NOT_EXIST")]
	RetPlanetFesPieceOfferNotExist = 6665,
	[OriginalName("RET_PLANET_FES_PIECE_APPLY_IN_STACK_TOO_MUCH")]
	RetPlanetFesPieceApplyInStackTooMuch = 6666,
	[OriginalName("RET_PLANET_FES_PIECE_APPLY_NOT_EXIST")]
	RetPlanetFesPieceApplyNotExist = 6667,
	[OriginalName("RET_PLANET_FES_GET_FRIEND_RANKING_LIST_IN_CD")]
	RetPlanetFesGetFriendRankingListInCd = 6668,
	[OriginalName("RET_PLANET_FES_GIVE_PIECE_OWNED_BY_TARGET")]
	RetPlanetFesGivePieceOwnedByTarget = 6669,
	[OriginalName("RET_PLANET_FES_LEVEL_MAX")]
	RetPlanetFesLevelMax = 6670,
	[OriginalName("RET_PLANET_FES_EXCLUSIVE_EVENT")]
	RetPlanetFesExclusiveEvent = 6671,
	[OriginalName("RET_MARBLE_SEAL_ALREADY_UNLOCKED")]
	RetMarbleSealAlreadyUnlocked = 6701,
	[OriginalName("RET_MARBLE_SEAL_SHOP_ITEM_NOT_ENOUGH")]
	RetMarbleSealShopItemNotEnough = 6702,
	[OriginalName("RET_MARBLE_SEAL_LOCKED")]
	RetMarbleSealLocked = 6703,
	[OriginalName("RET_CAKE_RACE_FIELD_LOCKED")]
	RetCakeRaceFieldLocked = 6751,
	[OriginalName("RET_CAKE_RACE_FIELD_COST_NOT_ENOUGH")]
	RetCakeRaceFieldCostNotEnough = 6752,
	[OriginalName("RET_CAKE_RACE_FIELD_PVP_ONLY")]
	RetCakeRaceFieldPvpOnly = 6753,
	[OriginalName("RET_CAKE_RACE_ALREADY_IN_GAME")]
	RetCakeRaceAlreadyInGame = 6754,
	[OriginalName("RET_CAKE_RACE_GET_FRIEND_RANKING_LIST_IN_CD")]
	RetCakeRaceGetFriendRankingListInCd = 6755,
	[OriginalName("RET_CAKE_RACE_LIKE_FRIEND_TARGET_NOT_FRIEND")]
	RetCakeRaceLikeFriendTargetNotFriend = 6756,
	[OriginalName("RET_CAKE_RACE_LIKE_FRIEND_DAILY_ALREADY_LIKED")]
	RetCakeRaceLikeFriendDailyAlreadyLiked = 6757,
	[OriginalName("RET_CAKE_RACE_LIKE_FRIEND_IN_CD")]
	RetCakeRaceLikeFriendInCd = 6758,
	[OriginalName("RET_FATE_STATUS_NOT_MATCH")]
	RetFateStatusNotMatch = 6771,
	[OriginalName("RET_FATE_BUFF_SLOT_NOT_ENOUGH")]
	RetFateBuffSlotNotEnough = 6772,
	[OriginalName("RET_FATE_COIN_NOT_ENOUGH")]
	RetFateCoinNotEnough = 6773,
	[OriginalName("RET_FATE_REIJU_REROLL_COUNT_NOT_ENOUGH")]
	RetFateReijuRerollCountNotEnough = 6774,
	[OriginalName("RET_FATE_BUFF_LEVEL_MAX")]
	RetFateBuffLevelMax = 6775,
	[OriginalName("RET_FATE_ACTION_QUEUE_NOT_EMPTY")]
	RetFateActionQueueNotEmpty = 6776,
	[OriginalName("RET_PARKOUR_ACTIVITY_NOT_OPEN")]
	RetParkourActivityNotOpen = 6801,
	[OriginalName("RET_PARKOUR_LEVEL_NOT_UNLOCK")]
	RetParkourLevelNotUnlock = 6802,
	[OriginalName("RET_PARKOUR_RAIL_BALL_NOT_ALLOWED")]
	RetParkourRailBallNotAllowed = 6803,
	[OriginalName("RET_PARKOUR_NOT_IN_LEVEL")]
	RetParkourNotInLevel = 6804,
	[OriginalName("RET_PARKOUR_LEVEL_NOT_MATCH")]
	RetParkourLevelNotMatch = 6805,
	[OriginalName("RET_PARKOUR_NOT_PLAYED_ALL_NON_STORY_LEVEL")]
	RetParkourNotPlayedAllNonStoryLevel = 6806,
	[OriginalName("RET_FTC_LIMIT_NAME_CHANGE")]
	RetFtcLimitNameChange = 6830,
	[OriginalName("RET_ELF_RESTAURANT_CONFIG_ERROR")]
	RetElfRestaurantConfigError = 6841,
	[OriginalName("RET_ELF_RESTAURANT_FIELD_ALREADY_BOUGHT")]
	RetElfRestaurantFieldAlreadyBought = 6842,
	[OriginalName("RET_ELF_RESTAURANT_FIELD_NOT_BOUGHT")]
	RetElfRestaurantFieldNotBought = 6843,
	[OriginalName("RET_ELF_RESTAURANT_FIELD_CELL_INVALID")]
	RetElfRestaurantFieldCellInvalid = 6844,
	[OriginalName("RET_ELF_RESTAURANT_FARM_TYPE_INVALID")]
	RetElfRestaurantFarmTypeInvalid = 6845,
	[OriginalName("RET_ELF_RESTAURANT_SHOP_ITEM_NOT_EXIST")]
	RetElfRestaurantShopItemNotExist = 6846,
	[OriginalName("RET_ELF_RESTAURANT_SHOP_ITEM_COUNT_LIMIT")]
	RetElfRestaurantShopItemCountLimit = 6847,
	[OriginalName("RET_ELF_RESTAURANT_TRADE_ORDER_NOT_EXIST")]
	RetElfRestaurantTradeOrderNotExist = 6848,
	[OriginalName("RET_ELF_RESTAURANT_NO_REWARD")]
	RetElfRestaurantNoReward = 6849,
	[OriginalName("RET_ELF_RESTAURANT_NOT_INIT")]
	RetElfRestaurantNotInit = 6850,
	[OriginalName("RET_GRID_FIGHT_CONF_MISS")]
	RetGridFightConfMiss = 6900,
	[OriginalName("RET_GRID_FIGHT_ROLE_NOT_EXIST")]
	RetGridFightRoleNotExist = 6901,
	[OriginalName("RET_GRID_FIGHT_ROLE_ALREADY_EXIST")]
	RetGridFightRoleAlreadyExist = 6902,
	[OriginalName("RET_GRID_FIGHT_POS_EXIST_ROLE")]
	RetGridFightPosExistRole = 6903,
	[OriginalName("RET_GRID_FIGHT_POS_NOT_VALID")]
	RetGridFightPosNotValid = 6904,
	[OriginalName("RET_GRID_FIGHT_COIN_NOT_ENOUGH")]
	RetGridFightCoinNotEnough = 6905,
	[OriginalName("RET_GRID_FIGHT_EQUIP_NOT_EXIST")]
	RetGridFightEquipNotExist = 6906,
	[OriginalName("RET_GRID_FIGHT_EQUIP_CANNOT_DRESS")]
	RetGridFightEquipCannotDress = 6907,
	[OriginalName("RET_GRID_FIGHT_PARAM_NOT_MATCH")]
	RetGridFightParamNotMatch = 6908,
	[OriginalName("RET_GRID_FIGHT_EQUIP_DRESS_SAME")]
	RetGridFightEquipDressSame = 6909,
	[OriginalName("RET_GRID_FIGHT_EQUIP_DRESSED")]
	RetGridFightEquipDressed = 6910,
	[OriginalName("RET_GRID_FIGHT_RANDOM_ERR")]
	RetGridFightRandomErr = 6911,
	[OriginalName("RET_GRID_FIGHT_GOODS_SOLD")]
	RetGridFightGoodsSold = 6912,
	[OriginalName("RET_GRID_FIGHT_ITEM_NOT_ENOUGH")]
	RetGridFightItemNotEnough = 6913,
	[OriginalName("RET_GRID_FIGHT_GAMEPLAY_LEVEL_MAX")]
	RetGridFightGameplayLevelMax = 6914,
	[OriginalName("RET_GRID_FIGHT_ALREADY_IN_GAMEPLAY")]
	RetGridFightAlreadyInGameplay = 6915,
	[OriginalName("RET_GRID_FIGHT_EQUIP_TRAIT_LIMIT")]
	RetGridFightEquipTraitLimit = 6916,
	[OriginalName("RET_GRID_FIGHT_REGION_FULL")]
	RetGridFightRegionFull = 6917,
	[OriginalName("RET_GRID_FIGHT_TEMPORARY_EQUIP")]
	RetGridFightTemporaryEquip = 6918,
	[OriginalName("RET_GRID_FIGHT_NOT_IN_GAMEPLAY")]
	RetGridFightNotInGameplay = 6919,
	[OriginalName("RET_GRID_FIGHT_ADD_EQUIP_FAIL")]
	RetGridFightAddEquipFail = 6920,
	[OriginalName("RET_GRID_FIGHT_ADD_CONSUMABLE_FAIL")]
	RetGridFightAddConsumableFail = 6921,
	[OriginalName("RET_GRID_FIGHT_CREATE_ROLE_FAIL")]
	RetGridFightCreateRoleFail = 6922,
	[OriginalName("RET_GRID_FIGHT_CANNOT_UPGRADE")]
	RetGridFightCannotUpgrade = 6923,
	[OriginalName("RET_GRID_FIGHT_NO_EMPTY_POS")]
	RetGridFightNoEmptyPos = 6924,
	[OriginalName("RET_GRID_FIGHT_FORGE_NOT_EXIST")]
	RetGridFightForgeNotExist = 6925,
	[OriginalName("RET_GRID_FIGHT_ADD_FORGE_FAIL")]
	RetGridFightAddForgeFail = 6926,
	[OriginalName("RET_GRID_FIGHT_ORB_NOT_ENOUGH")]
	RetGridFightOrbNotEnough = 6927,
	[OriginalName("RET_GRID_FIGHT_ORB_NOT_EXIST")]
	RetGridFightOrbNotExist = 6928,
	[OriginalName("RET_GRID_FIGHT_SUPPLY_NO_REROLL")]
	RetGridFightSupplyNoReroll = 6929,
	[OriginalName("RET_GRID_FIGHT_HIGH_RARIY_FOR_COPY")]
	RetGridFightHighRariyForCopy = 6930,
	[OriginalName("RET_GRID_FIGHT_ROLE_FULL_FOR_COPY")]
	RetGridFightRoleFullForCopy = 6931,
	[OriginalName("RET_GRID_FIGHT_UNDRESS_EQUIP_FAIL")]
	RetGridFightUndressEquipFail = 6932,
	[OriginalName("RET_GRID_FIGHT_DATA_LOCKED")]
	RetGridFightDataLocked = 6933,
	[OriginalName("RET_GRID_FIGHT_SAME_ROLE_IN_BATTLE")]
	RetGridFightSameRoleInBattle = 6934,
	[OriginalName("RET_GRID_FIGHT_SUPPLY_ALL_SELECTED")]
	RetGridFightSupplyAllSelected = 6935,
	[OriginalName("RET_GRID_FIGHT_TRAIT_TRACK_MAX")]
	RetGridFightTraitTrackMax = 6936,
	[OriginalName("RET_GRID_FIGHT_POS_BAN")]
	RetGridFightPosBan = 6937,
	[OriginalName("RET_GRID_FIGHT_POS_EXIST_ITEM")]
	RetGridFightPosExistItem = 6938,
	[OriginalName("RET_GRID_FIGHT_TALENT_ENABLED")]
	RetGridFightTalentEnabled = 6939,
	[OriginalName("RET_GRID_FIGHT_TALENT_COST_NOT_ENOUGH")]
	RetGridFightTalentCostNotEnough = 6940,
	[OriginalName("RET_GRID_FIGHT_TALENT_PRE_NOT_ENABLED")]
	RetGridFightTalentPreNotEnabled = 6941,
	[OriginalName("RET_GRID_FIGHT_DIVISION_INVALID")]
	RetGridFightDivisionInvalid = 6942,
	[OriginalName("RET_GRID_FIGHT_TALENT_PERMANENT_LIMIT")]
	RetGridFightTalentPermanentLimit = 6943,
	[OriginalName("RET_GRID_FIGHT_WEEKLY_REWARD_TAKEN")]
	RetGridFightWeeklyRewardTaken = 6944,
	[OriginalName("RET_GRID_FIGHT_WEEKLY_SCORE_NOT_ENOUGH")]
	RetGridFightWeeklyScoreNotEnough = 6945,
	[OriginalName("RET_GRID_FIGHT_CRAFT_COST_EQUIP_DRESSED")]
	RetGridFightCraftCostEquipDressed = 6946,
	[OriginalName("RET_GRID_FIGHT_CREATE_NPC_FAIL")]
	RetGridFightCreateNpcFail = 6947,
	[OriginalName("RET_GRID_FIGHT_NO_POS_CAN_PLACE")]
	RetGridFightNoPosCanPlace = 6948,
	[OriginalName("RET_GRID_FIGHT_NPC_POS_LIMIT")]
	RetGridFightNpcPosLimit = 6949,
	[OriginalName("RET_GRID_FIGHT_CRAFT_EQUIP_ON_DIFF_ROLE")]
	RetGridFightCraftEquipOnDiffRole = 6950,
	[OriginalName("RET_GRID_FIGHT_GLOBAL_HP_NOT_ENOUGH")]
	RetGridFightGlobalHpNotEnough = 6951,
	[OriginalName("RET_GRID_FIGHT_EQUIP_TRACK_MAX")]
	RetGridFightEquipTrackMax = 6952,
	[OriginalName("RET_GRID_FIGHT_NPC_NOT_EXIST")]
	RetGridFightNpcNotExist = 6953,
	[OriginalName("RET_GRID_FIGHT_RECYCLE_ROLE_IN_TUTORIAL")]
	RetGridFightRecycleRoleInTutorial = 6954,
	[OriginalName("RET_GRID_FIGHT_TUTORIAL_TASK_NOT_FINISHED")]
	RetGridFightTutorialTaskNotFinished = 6955,
	[OriginalName("RET_GRID_FIGHT_TUTORIAL_UPDATE_POS_ININVALID")]
	RetGridFightTutorialUpdatePosIninvalid = 6956,
	[OriginalName("RET_GRID_FIGHT_NO_REROLL_CNT")]
	RetGridFightNoRerollCnt = 6957,
	[OriginalName("RET_GRID_FIGHT_TUTORIAL_REFRESH_SHOP_LIMITED")]
	RetGridFightTutorialRefreshShopLimited = 6958,
	[OriginalName("RET_GRID_FIGHT_TUTORIAL_BUY_SHOP_LIMITED")]
	RetGridFightTutorialBuyShopLimited = 6959,
	[OriginalName("RET_GRID_FIGHT_OC_UNLOCK_QUEST_NOT_FINISHED")]
	RetGridFightOcUnlockQuestNotFinished = 6960,
	[OriginalName("RET_GRID_FIGHT_FORGE_LIMIT_SELECT_IDX_IN_TUTORIAL")]
	RetGridFightForgeLimitSelectIdxInTutorial = 6961,
	[OriginalName("RET_GRID_FIGHT_GAME_REF_ID_TOO_LONG")]
	RetGridFightGameRefIdTooLong = 6962,
	[OriginalName("RET_GRID_FIGHT_FEATURE_SWITCH_CLOSED")]
	RetGridFightFeatureSwitchClosed = 6963,
	[OriginalName("RET_GRID_FIGHT_EQUIP_TRAIT_EXCLUSIVE")]
	RetGridFightEquipTraitExclusive = 6964,
	[OriginalName("RET_GRID_FIGHT_SHOP_LOCKED")]
	RetGridFightShopLocked = 6965,
	[OriginalName("RET_GRID_FIGHT_BUY_EXP_LOCKED")]
	RetGridFightBuyExpLocked = 6966,
	[OriginalName("RET_HIPPLEN_AGENDA_WORK_UNAVAIBLE")]
	RetHipplenAgendaWorkUnavaible = 7001,
	[OriginalName("RET_HIPPLEN_AGENDA_WORK_CONFLICT")]
	RetHipplenAgendaWorkConflict = 7002,
	[OriginalName("RET_HIPPLEN_AGENDA_ACTION_LACK")]
	RetHipplenAgendaActionLack = 7003,
	[OriginalName("RET_HIPPLEN_AGENDA_ENERGY_LACK")]
	RetHipplenAgendaEnergyLack = 7004,
	[OriginalName("RET_HIPPLEN_AGENDA_NO_WORK_FOR_SETTLE")]
	RetHipplenAgendaNoWorkForSettle = 7005,
	[OriginalName("RET_HIPPLEN_AGENDA_SETTLE_WORK_MISMATCH")]
	RetHipplenAgendaSettleWorkMismatch = 7006,
	[OriginalName("RET_HIPPLEN_PHASE_CONFIG_NO_FOUND")]
	RetHipplenPhaseConfigNoFound = 7007,
	[OriginalName("RET_HIPPLEN_TRIAL_MISSION_NOT_FINISHED")]
	RetHipplenTrialMissionNotFinished = 7008,
	[OriginalName("RET_HIPPLEN_AGENDA_SET_WHEN_TRIAL")]
	RetHipplenAgendaSetWhenTrial = 7009,
	[OriginalName("RET_HIPPLEN_AGENDA_OPEN_CYCLE_FAIL")]
	RetHipplenAgendaOpenCycleFail = 7010,
	[OriginalName("RET_HIPPLEN_AGENDA_SETTLE_PARA_INVALID")]
	RetHipplenAgendaSettleParaInvalid = 7011,
	[OriginalName("RET_HIPPLEN_AGENDA_WORK_SET_TWICE")]
	RetHipplenAgendaWorkSetTwice = 7012,
	[OriginalName("RET_HIPPLEN_AGENDA_WORK_SETTLE_TWICE")]
	RetHipplenAgendaWorkSettleTwice = 7013,
	[OriginalName("RET_HIPPLEN_OUTFIT_NOT_WEARED")]
	RetHipplenOutfitNotWeared = 7014,
	[OriginalName("RET_HIPPLEN_OUTFIT_NOT_OWN")]
	RetHipplenOutfitNotOwn = 7015,
	[OriginalName("RET_HIPPLEN_OUTFIT_INVALID")]
	RetHipplenOutfitInvalid = 7016,
	[OriginalName("RET_HIPPLEN_OUTFIT_TYPE_WEARED")]
	RetHipplenOutfitTypeWeared = 7017,
	[OriginalName("RET_HIPPLEN_AGENDA_WORK_EMPTY")]
	RetHipplenAgendaWorkEmpty = 7018,
	[OriginalName("RET_HIPPLEN_ENDING_LOCK")]
	RetHipplenEndingLock = 7019,
	[OriginalName("RET_HIPPLEN_ENDING_REWARD_ALREADY_TAKEN")]
	RetHipplenEndingRewardAlreadyTaken = 7020,
	[OriginalName("RET_HIPPLEN_TRAIT_LOCK")]
	RetHipplenTraitLock = 7021,
	[OriginalName("RET_HIPPLEN_AGENDA_ACTION_LEFT")]
	RetHipplenAgendaActionLeft = 7022,
	[OriginalName("RET_HIPPLEN_BACKWARD_TRIAL_MISSION_NOT_FINISHED")]
	RetHipplenBackwardTrialMissionNotFinished = 7023,
	[OriginalName("RET_RELICBOX_HAS_PENDING_RELIC")]
	RetRelicboxHasPendingRelic = 7051,
	[OriginalName("RET_RELICBOX_NO_PENDING_RELIC")]
	RetRelicboxNoPendingRelic = 7052,
	[OriginalName("RET_RELICBOX_TARGET_AVATAR_INVALID")]
	RetRelicboxTargetAvatarInvalid = 7053,
	[OriginalName("RET_RELICBOX_TARGET_RELIC_SET_INVALID")]
	RetRelicboxTargetRelicSetInvalid = 7054,
	[OriginalName("RET_RELICBOX_ALLOW_POSITION_EMPTY")]
	RetRelicboxAllowPositionEmpty = 7055,
	[OriginalName("RET_RELICBOX_RELIC_CONFIG_NOT_FOUND")]
	RetRelicboxRelicConfigNotFound = 7056,
	[OriginalName("RET_RELICBOX_MAIN_AFFIX_ID_INVALID")]
	RetRelicboxMainAffixIdInvalid = 7057,
	[OriginalName("RET_RELICBOX_SUB_AFFIX_INVALID")]
	RetRelicboxSubAffixInvalid = 7058,
	[OriginalName("RET_RELICBOX_RELIC_CREATE_FAIL")]
	RetRelicboxRelicCreateFail = 7059,
	[OriginalName("RET_RELICBOX_LIB_CONFIG_NOT_FOUND")]
	RetRelicboxLibConfigNotFound = 7060,
	[OriginalName("RET_RELICBOX_SHIELD_LOCK")]
	RetRelicboxShieldLock = 7061,
	[OriginalName("RET_RELICBOX_CUSTOM_AVATAR_INVALID")]
	RetRelicboxCustomAvatarInvalid = 7062,
	[OriginalName("RET_RELICBOX_CUSTOM_RELIC_SET_INVALID")]
	RetRelicboxCustomRelicSetInvalid = 7063,
	[OriginalName("RET_RELICBOX_RELIC_IN_BOX")]
	RetRelicboxRelicInBox = 7064,
	[OriginalName("RET_RELICBOX_OPEN_TARGET_CONFLICT")]
	RetRelicboxOpenTargetConflict = 7065,
	[OriginalName("RET_RELICBOX_RELIC_TYPE_INVALID")]
	RetRelicboxRelicTypeInvalid = 7066,
	[OriginalName("Retcode_MBCABOJAPNF")]
	Mbcabojapnf = 7101,
	[OriginalName("Retcode_PJJKJLFAJMD")]
	Pjjkjlfajmd = 7102,
	[OriginalName("Retcode_JMOAEJMMLFK")]
	Jmoaejmmlfk = 7103,
	[OriginalName("Retcode_OGAKNDBOHIK")]
	Ogakndbohik = 7104,
	[OriginalName("Retcode_NLNCPEKBKBG")]
	Nlncpekbkbg = 7105,
	[OriginalName("Retcode_CNIOINHAGJI")]
	Cnioinhagji = 7106,
	[OriginalName("Retcode_OKAMEKOLPDB")]
	Okamekolpdb = 7107,
	[OriginalName("Retcode_NBICFEMBGEB")]
	Nbicfembgeb = 7108,
	[OriginalName("Retcode_GFBENDMKGMN")]
	Gfbendmkgmn = 7109,
	[OriginalName("Retcode_DFJINCHMDBH")]
	Dfjinchmdbh = 7110,
	[OriginalName("Retcode_FDCKOELBPFF")]
	Fdckoelbpff = 7111,
	[OriginalName("Retcode_JHLELIFPINJ")]
	Jhlelifpinj = 7112,
	[OriginalName("Retcode_HKGAOKDKFKC")]
	Hkgaokdkfkc = 7113,
	[OriginalName("Retcode_MIIGHHKMGHM")]
	Miighhkmghm = 7114,
	[OriginalName("Retcode_AGEIOBENCMJ")]
	Ageiobencmj = 7115,
	[OriginalName("Retcode_CBPGALLJEPD")]
	Cbpgalljepd = 7116,
	[OriginalName("Retcode_LFJCDIGAPNK")]
	Lfjcdigapnk = 7117,
	[OriginalName("Retcode_NHBDPKEMHJC")]
	Nhbdpkemhjc = 7118,
	[OriginalName("Retcode_EFBLJHOPKNH")]
	Efbljhopknh = 7201,
	[OriginalName("Retcode_DCJIIAHBEAG")]
	Dcjiiahbeag = 7202,
	[OriginalName("Retcode_KEMIBMAFOMD")]
	Kemibmafomd = 7203,
	[OriginalName("Retcode_FGFMKAFHIOH")]
	Fgfmkafhioh = 7204,
	[OriginalName("Retcode_JDHMBJEKFEG")]
	Jdhmbjekfeg = 7205,
	[OriginalName("Retcode_PBPLIBBEKCE")]
	Pbplibbekce = 7206,
	[OriginalName("Retcode_ONFIDLGNKCA")]
	Onfidlgnkca = 7207,
	[OriginalName("Retcode_AELGHBIMHAO")]
	Aelghbimhao = 7208,
	[OriginalName("Retcode_BFELLHHPKFO")]
	Bfellhhpkfo = 7301,
	[OriginalName("Retcode_CABLNLCHHLP")]
	Cablnlchhlp = 7302,
	[OriginalName("Retcode_DBBIPGKBKDH")]
	Dbbipgkbkdh = 7303
}
