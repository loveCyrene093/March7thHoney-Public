using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum PlayerActionType
{
	[OriginalName("PlayerActionType_PlayerActionNone")]
	PlayerActionNone = 0,
	[OriginalName("PlayerActionType_PlayerActionRegister")]
	PlayerActionRegister = 1,
	[OriginalName("PlayerActionType_PlayerActionLogin")]
	PlayerActionLogin = 2,
	[OriginalName("PlayerActionType_PlayerActionLogout")]
	PlayerActionLogout = 3,
	[OriginalName("PlayerActionType_PlayerActionAddExp")]
	PlayerActionAddExp = 4,
	[OriginalName("PlayerActionType_PlayerActionLevelUp")]
	PlayerActionLevelUp = 5,
	[OriginalName("PlayerActionType_PlayerActionAddMaterial")]
	PlayerActionAddMaterial = 6,
	[OriginalName("PlayerActionType_PlayerActionSaveStat")]
	PlayerActionSaveStat = 7,
	[OriginalName("PlayerActionType_PlayerActionTravelBrochureInteract")]
	PlayerActionTravelBrochureInteract = 8,
	[OriginalName("PlayerActionType_PlayerActionRelay")]
	PlayerActionRelay = 9,
	[OriginalName("PlayerActionType_PlayerActionRecharge")]
	PlayerActionRecharge = 101,
	[OriginalName("PlayerActionType_PlayerActionBuyGoods")]
	PlayerActionBuyGoods = 102,
	[OriginalName("PlayerActionType_PlayerActionAddCoin")]
	PlayerActionAddCoin = 103,
	[OriginalName("PlayerActionType_PlayerActionMonthCardDailyHcoin")]
	PlayerActionMonthCardDailyHcoin = 104,
	[OriginalName("PlayerActionType_PlayerActionMonthCardBuyMcoin")]
	PlayerActionMonthCardBuyMcoin = 105,
	[OriginalName("PlayerActionType_PlayerActionRechargeFreeCoin")]
	PlayerActionRechargeFreeCoin = 106,
	[OriginalName("PlayerActionType_PlayerActionAddMonthCard")]
	PlayerActionAddMonthCard = 107,
	[OriginalName("PlayerActionType_PlayerActionRechargeGiftPay")]
	PlayerActionRechargeGiftPay = 108,
	[OriginalName("PlayerActionType_PlayerActionRechargeGiftFree")]
	PlayerActionRechargeGiftFree = 109,
	[OriginalName("PlayerActionType_PlayerActionRechargeBenefit")]
	PlayerActionRechargeBenefit = 110,
	[OriginalName("PlayerActionType_PlayerActionRechargeGiftTakeReward")]
	PlayerActionRechargeGiftTakeReward = 111,
	[OriginalName("PlayerActionType_PlayerActionRechargeGiftReach")]
	PlayerActionRechargeGiftReach = 112,
	[OriginalName("PlayerActionType_PlayerActionRechargeBenefitReach")]
	PlayerActionRechargeBenefitReach = 113,
	[OriginalName("PlayerActionType_PlayerActionMonthCardEndMail")]
	PlayerActionMonthCardEndMail = 114,
	[OriginalName("PlayerActionType_PlayerActionMissionAccept")]
	PlayerActionMissionAccept = 201,
	[OriginalName("PlayerActionType_PlayerActionMissionFinish")]
	PlayerActionMissionFinish = 202,
	[OriginalName("PlayerActionType_PlayerActionMissionFail")]
	PlayerActionMissionFail = 203,
	[OriginalName("PlayerActionType_PlayerActionMainMissionAccept")]
	PlayerActionMainMissionAccept = 204,
	[OriginalName("PlayerActionType_PlayerActionSubMissionAccept")]
	PlayerActionSubMissionAccept = 205,
	[OriginalName("PlayerActionType_PlayerActionMainMissionFinish")]
	PlayerActionMainMissionFinish = 206,
	[OriginalName("PlayerActionType_PlayerActionSubMissionFinish")]
	PlayerActionSubMissionFinish = 207,
	[OriginalName("PlayerActionType_PlayerActionDailyTaskFinish")]
	PlayerActionDailyTaskFinish = 208,
	[OriginalName("PlayerActionType_PlayerActionDailyTaskTakeReward")]
	PlayerActionDailyTaskTakeReward = 209,
	[OriginalName("PlayerActionType_PlayerActionNpcTalkReward")]
	PlayerActionNpcTalkReward = 210,
	[OriginalName("PlayerActionType_PlayerActionMainMissionRecover")]
	PlayerActionMainMissionRecover = 211,
	[OriginalName("PlayerActionType_PlayerActionMainMissionDisable")]
	PlayerActionMainMissionDisable = 212,
	[OriginalName("PlayerActionType_PlayerActionConsumeItemSubMissionFinish")]
	PlayerActionConsumeItemSubMissionFinish = 213,
	[OriginalName("PlayerActionType_PlayerActionItemMonitorAllSources")]
	PlayerActionItemMonitorAllSources = 999,
	[OriginalName("PlayerActionType_PlayerActionGm")]
	PlayerActionGm = 1001,
	[OriginalName("PlayerActionType_PlayerActionCustomOp")]
	PlayerActionCustomOp = 1002,
	[OriginalName("PlayerActionType_PlayerActionCheckSum")]
	PlayerActionCheckSum = 1003,
	[OriginalName("PlayerActionType_PlayerActionPlayerLocation")]
	PlayerActionPlayerLocation = 1004,
	[OriginalName("PlayerActionType_PlayerActionChangeLanguage")]
	PlayerActionChangeLanguage = 1005,
	[OriginalName("PlayerActionType_PlayerActionClientReport")]
	PlayerActionClientReport = 1006,
	[OriginalName("PlayerActionType_PlayerActionAceReport")]
	PlayerActionAceReport = 1007,
	[OriginalName("PlayerActionType_PlayerActionPlayerPowerInfo")]
	PlayerActionPlayerPowerInfo = 1008,
	[OriginalName("PlayerActionType_PlayerActionDailyRefresh")]
	PlayerActionDailyRefresh = 1009,
	[OriginalName("PlayerActionType_PlayerActionAvatarValueInfo")]
	PlayerActionAvatarValueInfo = 1010,
	[OriginalName("PlayerActionType_PlayerActionMoveCheckFailedReport")]
	PlayerActionMoveCheckFailedReport = 1011,
	[OriginalName("PlayerActionType_PlayerActionBattleFailedReport")]
	PlayerActionBattleFailedReport = 1012,
	[OriginalName("PlayerActionType_PlayerActionSecurityReport")]
	PlayerActionSecurityReport = 1013,
	[OriginalName("PlayerActionType_PlayerActionAvatarPromotion")]
	PlayerActionAvatarPromotion = 1101,
	[OriginalName("PlayerActionType_PlayerActionAvatarAdd")]
	PlayerActionAvatarAdd = 1103,
	[OriginalName("PlayerActionType_PlayerActionAvatarUseExpItem")]
	PlayerActionAvatarUseExpItem = 1104,
	[OriginalName("PlayerActionType_PlayerActionAvatarLevelUp")]
	PlayerActionAvatarLevelUp = 1105,
	[OriginalName("PlayerActionType_PlayerActionSkillTreeUp")]
	PlayerActionSkillTreeUp = 1106,
	[OriginalName("PlayerActionType_PlayerActionAvatarHpChange")]
	PlayerActionAvatarHpChange = 1107,
	[OriginalName("PlayerActionType_PlayerActionAvatarMpChange")]
	PlayerActionAvatarMpChange = 1108,
	[OriginalName("PlayerActionType_PlayerActionAvatarAddExp")]
	PlayerActionAvatarAddExp = 1109,
	[OriginalName("PlayerActionType_PlayerActionAvatarRankUp")]
	PlayerActionAvatarRankUp = 1110,
	[OriginalName("PlayerActionType_PlayerActionAvatarRepeated")]
	PlayerActionAvatarRepeated = 1111,
	[OriginalName("PlayerActionType_PlayerActionMpMaxChange")]
	PlayerActionMpMaxChange = 1112,
	[OriginalName("PlayerActionType_PlayerActionAvatarTakePromotionReward")]
	PlayerActionAvatarTakePromotionReward = 1113,
	[OriginalName("PlayerActionType_PlayerActionAvatarRelicAffixInfo")]
	PlayerActionAvatarRelicAffixInfo = 1114,
	[OriginalName("PlayerActionType_PlayerActionAvatarMark")]
	PlayerActionAvatarMark = 1115,
	[OriginalName("PlayerActionType_PlayerActionAvatarSystemPowerReset")]
	PlayerActionAvatarSystemPowerReset = 1116,
	[OriginalName("PlayerActionType_PlayerActionAvatarChangePath")]
	PlayerActionAvatarChangePath = 1119,
	[OriginalName("PlayerActionType_PlayerActionSetGrowthTargetAvatar")]
	PlayerActionSetGrowthTargetAvatar = 1120,
	[OriginalName("PlayerActionType_PlayerActionDelAvatar")]
	PlayerActionDelAvatar = 1121,
	[OriginalName("PlayerActionType_PlayerActionAvatarSkinChange")]
	PlayerActionAvatarSkinChange = 1122,
	[OriginalName("PlayerActionType_PlayerActionSetGrowthTargetFunctionConfig")]
	PlayerActionSetGrowthTargetFunctionConfig = 1123,
	[OriginalName("PlayerActionType_PlayerActionAvatarSkinActivityReissue")]
	PlayerActionAvatarSkinActivityReissue = 1124,
	[OriginalName("PlayerActionType_PlayerActionSetAvatarEnhancedId")]
	PlayerActionSetAvatarEnhancedId = 1125,
	[OriginalName("PlayerActionType_PlayerActionDressPlayerOutfit")]
	PlayerActionDressPlayerOutfit = 1126,
	[OriginalName("PlayerActionType_PlayerActionStageBegin")]
	PlayerActionStageBegin = 1202,
	[OriginalName("PlayerActionType_PlayerActionStageEnd")]
	PlayerActionStageEnd = 1203,
	[OriginalName("PlayerActionType_PlayerActionCocoonStageBegin")]
	PlayerActionCocoonStageBegin = 1205,
	[OriginalName("PlayerActionType_PlayerActionCocoonStageEnd")]
	PlayerActionCocoonStageEnd = 1206,
	[OriginalName("PlayerActionType_PlayerActionFarmElementEnd")]
	PlayerActionFarmElementEnd = 1207,
	[OriginalName("PlayerActionType_PlayerActionElementStageEnd")]
	PlayerActionElementStageEnd = 1208,
	[OriginalName("PlayerActionType_PlayerActionCocoonSweep")]
	PlayerActionCocoonSweep = 1209,
	[OriginalName("PlayerActionType_PlayerActionFarmElementSweep")]
	PlayerActionFarmElementSweep = 1210,
	[OriginalName("PlayerActionType_PlayerActionRecoverStamina")]
	PlayerActionRecoverStamina = 1301,
	[OriginalName("PlayerActionType_PlayerActionExchangeStamina")]
	PlayerActionExchangeStamina = 1302,
	[OriginalName("PlayerActionType_PlayerActionLoginReward")]
	PlayerActionLoginReward = 1303,
	[OriginalName("PlayerActionType_PlayerActionModifyNickname")]
	PlayerActionModifyNickname = 1304,
	[OriginalName("PlayerActionType_PlayerActionGetLevelReward")]
	PlayerActionGetLevelReward = 1305,
	[OriginalName("PlayerActionType_PlayerActionWorldLevelUp")]
	PlayerActionWorldLevelUp = 1306,
	[OriginalName("PlayerActionType_PlayerActionAddStamina")]
	PlayerActionAddStamina = 1307,
	[OriginalName("PlayerActionType_PlayerActionGameplayBirthdayRewardMail")]
	PlayerActionGameplayBirthdayRewardMail = 1308,
	[OriginalName("PlayerActionType_PlayerActionRechargeRebateReward")]
	PlayerActionRechargeRebateReward = 1309,
	[OriginalName("PlayerActionType_PlayerActionGameplayBirthdaySet")]
	PlayerActionGameplayBirthdaySet = 1310,
	[OriginalName("PlayerActionType_PlayerActionReserveStaminaExchange")]
	PlayerActionReserveStaminaExchange = 1311,
	[OriginalName("PlayerActionType_PlayerActionReserveStaminaAdd")]
	PlayerActionReserveStaminaAdd = 1312,
	[OriginalName("PlayerActionType_PlayerActionReserveStaminaChange")]
	PlayerActionReserveStaminaChange = 1313,
	[OriginalName("PlayerActionType_PlayerActionNowStamina")]
	PlayerActionNowStamina = 1314,
	[OriginalName("PlayerActionType_PlayerActionFtcResetNickname")]
	PlayerActionFtcResetNickname = 1315,
	[OriginalName("PlayerActionType_PlayerActionReserveAndFuelExchangeStamina")]
	PlayerActionReserveAndFuelExchangeStamina = 1316,
	[OriginalName("PlayerActionType_PlayerActionMail")]
	PlayerActionMail = 1401,
	[OriginalName("PlayerActionType_PlayerActionMailOpByUser")]
	PlayerActionMailOpByUser = 1402,
	[OriginalName("PlayerActionType_PlayerActionMailOpByMuip")]
	PlayerActionMailOpByMuip = 1403,
	[OriginalName("PlayerActionType_PlayerActionMailOpByGm")]
	PlayerActionMailOpByGm = 1404,
	[OriginalName("PlayerActionType_PlayerActionMailOpByFull")]
	PlayerActionMailOpByFull = 1405,
	[OriginalName("PlayerActionType_PlayerActionMailOpByExpire")]
	PlayerActionMailOpByExpire = 1406,
	[OriginalName("PlayerActionType_PlayerActionMailOpByInternal")]
	PlayerActionMailOpByInternal = 1407,
	[OriginalName("PlayerActionType_PlayerActionAddMail")]
	PlayerActionAddMail = 1408,
	[OriginalName("PlayerActionType_PlayerActionDelMail")]
	PlayerActionDelMail = 1409,
	[OriginalName("PlayerActionType_PlayerActionTakeAttachment")]
	PlayerActionTakeAttachment = 1410,
	[OriginalName("PlayerActionType_PlayerActionReadMail")]
	PlayerActionReadMail = 1411,
	[OriginalName("PlayerActionType_PlayerActionBattleAvatar")]
	PlayerActionBattleAvatar = 1501,
	[OriginalName("PlayerActionType_PlayerActionBattleMonster")]
	PlayerActionBattleMonster = 1502,
	[OriginalName("PlayerActionType_PlayerActionBattleEnd")]
	PlayerActionBattleEnd = 1504,
	[OriginalName("PlayerActionType_PlayerActionBattleReplay")]
	PlayerActionBattleReplay = 1505,
	[OriginalName("PlayerActionType_PlayerActionBattleAvatarDeath")]
	PlayerActionBattleAvatarDeath = 1506,
	[OriginalName("PlayerActionType_PlayerActionBattleSwitchPhase")]
	PlayerActionBattleSwitchPhase = 1507,
	[OriginalName("PlayerActionType_PlayerActionBattleMonsterSkill")]
	PlayerActionBattleMonsterSkill = 1508,
	[OriginalName("PlayerActionType_PlayerActionBattleRebattle")]
	PlayerActionBattleRebattle = 1509,
	[OriginalName("PlayerActionType_PlayerActionBattleAvatarServant")]
	PlayerActionBattleAvatarServant = 1510,
	[OriginalName("PlayerActionType_PlayerActionMissionReward")]
	PlayerActionMissionReward = 1602,
	[OriginalName("PlayerActionType_PlayerActionQuestAccept")]
	PlayerActionQuestAccept = 1603,
	[OriginalName("PlayerActionType_PlayerActionQuestFinish")]
	PlayerActionQuestFinish = 1604,
	[OriginalName("PlayerActionType_PlayerActionQuestRemove")]
	PlayerActionQuestRemove = 1605,
	[OriginalName("PlayerActionType_PlayerActionQuestReward")]
	PlayerActionQuestReward = 1606,
	[OriginalName("PlayerActionType_PlayerActionQuestAutoClose")]
	PlayerActionQuestAutoClose = 1607,
	[OriginalName("PlayerActionType_PlayerActionQuestExpired")]
	PlayerActionQuestExpired = 1608,
	[OriginalName("PlayerActionType_PlayerActionMissionRequired")]
	PlayerActionMissionRequired = 1609,
	[OriginalName("PlayerActionType_PlayerActionSubmissionReward")]
	PlayerActionSubmissionReward = 1610,
	[OriginalName("PlayerActionType_PlayerActionAchievementLevelReward")]
	PlayerActionAchievementLevelReward = 1611,
	[OriginalName("PlayerActionType_PlayerActionQuestDelete")]
	PlayerActionQuestDelete = 1612,
	[OriginalName("PlayerActionType_PlayerActionSubMissionReward2")]
	PlayerActionSubMissionReward2 = 1613,
	[OriginalName("PlayerActionType_PlayerActionMissionCompensate")]
	PlayerActionMissionCompensate = 1614,
	[OriginalName("PlayerActionType_PlayerActionMissionRecycle")]
	PlayerActionMissionRecycle = 1615,
	[OriginalName("PlayerActionType_PlayerActionQuestReset")]
	PlayerActionQuestReset = 1616,
	[OriginalName("PlayerActionType_PlayerActionQuestOptionalReward")]
	PlayerActionQuestOptionalReward = 1617,
	[OriginalName("PlayerActionType_PlayerActionMcvChange")]
	PlayerActionMcvChange = 1618,
	[OriginalName("PlayerActionType_PlayerActionQuestReissue")]
	PlayerActionQuestReissue = 1619,
	[OriginalName("PlayerActionType_PlayerActionPropInteract")]
	PlayerActionPropInteract = 1704,
	[OriginalName("PlayerActionType_PlayerActionAvatarMazeSkill")]
	PlayerActionAvatarMazeSkill = 1705,
	[OriginalName("PlayerActionType_PlayerActionEnterMaze")]
	PlayerActionEnterMaze = 1706,
	[OriginalName("PlayerActionType_PlayerActionOrdinaryInteract")]
	PlayerActionOrdinaryInteract = 1707,
	[OriginalName("PlayerActionType_PlayerActionChestInteract")]
	PlayerActionChestInteract = 1708,
	[OriginalName("PlayerActionType_PlayerActionCheckPointUnlock")]
	PlayerActionCheckPointUnlock = 1709,
	[OriginalName("PlayerActionType_PlayerActionCheckPointInteract")]
	PlayerActionCheckPointInteract = 1710,
	[OriginalName("PlayerActionType_PlayerActionCheckPointRevive")]
	PlayerActionCheckPointRevive = 1711,
	[OriginalName("PlayerActionType_PlayerActionCheckPointTransfer")]
	PlayerActionCheckPointTransfer = 1712,
	[OriginalName("PlayerActionType_PlayerActionMonsterInteract")]
	PlayerActionMonsterInteract = 1714,
	[OriginalName("PlayerActionType_PlayerActionNpcInteract")]
	PlayerActionNpcInteract = 1716,
	[OriginalName("PlayerActionType_PlayerActionPropHit")]
	PlayerActionPropHit = 1717,
	[OriginalName("PlayerActionType_PlayerActionPrelogueRevive")]
	PlayerActionPrelogueRevive = 1718,
	[OriginalName("PlayerActionType_PlayerActionPropState")]
	PlayerActionPropState = 1719,
	[OriginalName("PlayerActionType_PlayerActionCheckPointRecover")]
	PlayerActionCheckPointRecover = 1720,
	[OriginalName("PlayerActionType_PlayerActionMechanismBar")]
	PlayerActionMechanismBar = 1722,
	[OriginalName("PlayerActionType_PlayerActionSubmitOrigamiItem")]
	PlayerActionSubmitOrigamiItem = 1723,
	[OriginalName("PlayerActionType_PlayerActionMazeBuffDropItem")]
	PlayerActionMazeBuffDropItem = 1724,
	[OriginalName("PlayerActionType_PlayerActionFsvChange")]
	PlayerActionFsvChange = 1725,
	[OriginalName("PlayerActionType_PlayerActionTimelinePropState")]
	PlayerActionTimelinePropState = 1726,
	[OriginalName("PlayerActionType_PlayerActionGroupPropertyChange")]
	PlayerActionGroupPropertyChange = 1727,
	[OriginalName("PlayerActionType_PlayerActionOpenGroupPropertyChest")]
	PlayerActionOpenGroupPropertyChest = 1728,
	[OriginalName("PlayerActionType_PlayerActionEquipmentPromotion")]
	PlayerActionEquipmentPromotion = 1901,
	[OriginalName("PlayerActionType_PlayerActionAddItem")]
	PlayerActionAddItem = 1902,
	[OriginalName("PlayerActionType_PlayerActionUseItem")]
	PlayerActionUseItem = 1904,
	[OriginalName("PlayerActionType_PlayerActionEquipmentRankUp")]
	PlayerActionEquipmentRankUp = 1905,
	[OriginalName("PlayerActionType_PlayerActionEquipmentLevelUp")]
	PlayerActionEquipmentLevelUp = 1906,
	[OriginalName("PlayerActionType_PlayerActionExpUpEquipmentReturn")]
	PlayerActionExpUpEquipmentReturn = 1907,
	[OriginalName("PlayerActionType_PlayerActionBagFullRewardMail")]
	PlayerActionBagFullRewardMail = 1908,
	[OriginalName("PlayerActionType_PlayerActionEquipmentAdd")]
	PlayerActionEquipmentAdd = 1909,
	[OriginalName("PlayerActionType_PlayerActionEquipmentWear")]
	PlayerActionEquipmentWear = 1910,
	[OriginalName("PlayerActionType_PlayerActionItemCompose")]
	PlayerActionItemCompose = 1911,
	[OriginalName("PlayerActionType_PlayerActionRelicLevelUp")]
	PlayerActionRelicLevelUp = 1912,
	[OriginalName("PlayerActionType_PlayerActionExpUpRelicReturn")]
	PlayerActionExpUpRelicReturn = 1913,
	[OriginalName("PlayerActionType_PlayerActionRelicNumChanged")]
	PlayerActionRelicNumChanged = 1914,
	[OriginalName("PlayerActionType_PlayerActionRelicWear")]
	PlayerActionRelicWear = 1915,
	[OriginalName("PlayerActionType_PlayerActionRelicCompose")]
	PlayerActionRelicCompose = 1916,
	[OriginalName("PlayerActionType_PlayerActionSellItem")]
	PlayerActionSellItem = 1917,
	[OriginalName("PlayerActionType_PlayerActionUnlockMusic")]
	PlayerActionUnlockMusic = 1918,
	[OriginalName("PlayerActionType_PlayerActionExchangeHcoinWithPayMcoin")]
	PlayerActionExchangeHcoinWithPayMcoin = 1919,
	[OriginalName("PlayerActionType_PlayerActionGetReward")]
	PlayerActionGetReward = 1920,
	[OriginalName("PlayerActionType_PlayerActionExchangeHcoinWithFreeMcoin")]
	PlayerActionExchangeHcoinWithFreeMcoin = 1921,
	[OriginalName("PlayerActionType_PlayerActionItemComposeFormulaUnlock")]
	PlayerActionItemComposeFormulaUnlock = 1922,
	[OriginalName("PlayerActionType_PlayerActionExchangeHcoin")]
	PlayerActionExchangeHcoin = 1923,
	[OriginalName("PlayerActionType_PlayerActionCityShopLevelReward")]
	PlayerActionCityShopLevelReward = 1924,
	[OriginalName("PlayerActionType_PlayerActionItemRecycle")]
	PlayerActionItemRecycle = 1925,
	[OriginalName("PlayerActionType_PlayerActionMuseumFundsConsume")]
	PlayerActionMuseumFundsConsume = 1926,
	[OriginalName("PlayerActionType_PlayerActionMuseumEventBuyStuff")]
	PlayerActionMuseumEventBuyStuff = 1927,
	[OriginalName("PlayerActionType_PlayerActionMuseumMarketBuyStuff")]
	PlayerActionMuseumMarketBuyStuff = 1928,
	[OriginalName("PlayerActionType_PlayerActionMuseumRandomEvent")]
	PlayerActionMuseumRandomEvent = 1929,
	[OriginalName("PlayerActionType_PlayerActionMuseumInitialItem")]
	PlayerActionMuseumInitialItem = 1930,
	[OriginalName("PlayerActionType_PlayerActionOptionalBoxReward")]
	PlayerActionOptionalBoxReward = 1931,
	[OriginalName("PlayerActionType_PlayerActionDestroyItem")]
	PlayerActionDestroyItem = 1932,
	[OriginalName("PlayerActionType_PlayerActionTransferExp")]
	PlayerActionTransferExp = 1933,
	[OriginalName("PlayerActionType_PlayerActionOndutyUse")]
	PlayerActionOndutyUse = 1934,
	[OriginalName("PlayerActionType_PlayerActionItemMark")]
	PlayerActionItemMark = 1935,
	[OriginalName("PlayerActionType_PlayerActionRelicDiscard")]
	PlayerActionRelicDiscard = 1936,
	[OriginalName("PlayerActionType_PlayerActionGeneralVirtualItemChange")]
	PlayerActionGeneralVirtualItemChange = 1937,
	[OriginalName("PlayerActionType_PlayerActionRelicLock")]
	PlayerActionRelicLock = 1938,
	[OriginalName("PlayerActionType_PlayerActionRelicFilterPlanSave")]
	PlayerActionRelicFilterPlanSave = 1939,
	[OriginalName("PlayerActionType_PlayerActionRelicFilterPlanDelete")]
	PlayerActionRelicFilterPlanDelete = 1940,
	[OriginalName("PlayerActionType_PlayerActionRelicFilterPlanMark")]
	PlayerActionRelicFilterPlanMark = 1941,
	[OriginalName("PlayerActionType_PlayerActionRelicSell")]
	PlayerActionRelicSell = 1942,
	[OriginalName("PlayerActionType_PlayerActionRelicReforge")]
	PlayerActionRelicReforge = 1943,
	[OriginalName("PlayerActionType_PlayerActionRelicSmartWearCustomPlan")]
	PlayerActionRelicSmartWearCustomPlan = 1944,
	[OriginalName("PlayerActionType_PlayerActionRecoverRelic")]
	PlayerActionRecoverRelic = 1945,
	[OriginalName("PlayerActionType_PlayerActionRecoverEquipment")]
	PlayerActionRecoverEquipment = 1946,
	[OriginalName("PlayerActionType_PlayerActionEquipmentSell")]
	PlayerActionEquipmentSell = 1947,
	[OriginalName("PlayerActionType_PlayerActionRelicSmartWearPinRelic")]
	PlayerActionRelicSmartWearPinRelic = 1948,
	[OriginalName("PlayerActionType_PlayerActionRelicCocoonSetting")]
	PlayerActionRelicCocoonSetting = 1949,
	[OriginalName("PlayerActionType_PlayerActionPersonalCardChange")]
	PlayerActionPersonalCardChange = 1950,
	[OriginalName("PlayerActionType_PlayerActionPhoneCaseChange")]
	PlayerActionPhoneCaseChange = 1951,
	[OriginalName("PlayerActionType_PlayerActionDeliveryItemReward")]
	PlayerActionDeliveryItemReward = 1952,
	[OriginalName("PlayerActionType_PlayerActionItemAutoTransfer")]
	PlayerActionItemAutoTransfer = 1953,
	[OriginalName("PlayerActionType_PlayerActionItemAutoTransferInBag")]
	PlayerActionItemAutoTransferInBag = 1954,
	[OriginalName("PlayerActionType_PlayerActionItemAutoTransferOnAdd")]
	PlayerActionItemAutoTransferOnAdd = 1955,
	[OriginalName("PlayerActionType_PlayerActionAddExtraCoin")]
	PlayerActionAddExtraCoin = 1956,
	[OriginalName("PlayerActionType_PlayerActionVariableDiceExchangePartnerCoin")]
	PlayerActionVariableDiceExchangePartnerCoin = 1957,
	[OriginalName("PlayerActionType_PlayerActionRelicBox")]
	PlayerActionRelicBox = 1958,
	[OriginalName("PlayerActionType_PlayerActionRelicBoxSettle")]
	PlayerActionRelicBoxSettle = 1959,
	[OriginalName("PlayerActionType_PlayerActionRelicBoxRegular")]
	PlayerActionRelicBoxRegular = 1960,
	[OriginalName("PlayerActionType_PlayerActionRelicReplace")]
	PlayerActionRelicReplace = 1961,
	[OriginalName("PlayerActionType_PlayerActionEquipmentUpCostPileSetting")]
	PlayerActionEquipmentUpCostPileSetting = 1962,
	[OriginalName("PlayerActionType_PlayerActionRelicBoxShow")]
	PlayerActionRelicBoxShow = 1963,
	[OriginalName("PlayerActionType_PlayerActionTutorialGuideFinish")]
	PlayerActionTutorialGuideFinish = 2001,
	[OriginalName("PlayerActionType_PlayerActionTutorial")]
	PlayerActionTutorial = 2002,
	[OriginalName("PlayerActionType_PlayerActionTutorialGuide")]
	PlayerActionTutorialGuide = 2003,
	[OriginalName("PlayerActionType_PlayerActionMonsterDrop")]
	PlayerActionMonsterDrop = 2101,
	[OriginalName("PlayerActionType_PlayerActionFinishChallenge")]
	PlayerActionFinishChallenge = 2201,
	[OriginalName("PlayerActionType_PlayerActionChallengeStars")]
	PlayerActionChallengeStars = 2202,
	[OriginalName("PlayerActionType_PlayerActionChallengeStart")]
	PlayerActionChallengeStart = 2203,
	[OriginalName("PlayerActionType_PlayerActionChallengeEnd")]
	PlayerActionChallengeEnd = 2204,
	[OriginalName("PlayerActionType_PlayerActionChallengeWin")]
	PlayerActionChallengeWin = 2205,
	[OriginalName("PlayerActionType_PlayerActionChallengeFail")]
	PlayerActionChallengeFail = 2206,
	[OriginalName("PlayerActionType_PlayerActionChallengeLeave")]
	PlayerActionChallengeLeave = 2207,
	[OriginalName("PlayerActionType_PlayerActionChallengeSwitch")]
	PlayerActionChallengeSwitch = 2208,
	[OriginalName("PlayerActionType_PlayerActionChallengeBonusReward")]
	PlayerActionChallengeBonusReward = 2210,
	[OriginalName("PlayerActionType_PlayerActionChallengeStarsReward")]
	PlayerActionChallengeStarsReward = 2211,
	[OriginalName("PlayerActionType_PlayerActionChallengeRestart")]
	PlayerActionChallengeRestart = 2212,
	[OriginalName("PlayerActionType_PlayerActionChallengeStoryStart")]
	PlayerActionChallengeStoryStart = 2213,
	[OriginalName("PlayerActionType_PlayerActionChallengeStoryEnd")]
	PlayerActionChallengeStoryEnd = 2214,
	[OriginalName("PlayerActionType_PlayerActionChallengeFastPass")]
	PlayerActionChallengeFastPass = 2215,
	[OriginalName("PlayerActionType_PlayerActionChallengeStoryFastPass")]
	PlayerActionChallengeStoryFastPass = 2216,
	[OriginalName("PlayerActionType_PlayerActionChallengeMemoryFastPass")]
	PlayerActionChallengeMemoryFastPass = 2217,
	[OriginalName("PlayerActionType_PlayerActionChallengeBattleTarget")]
	PlayerActionChallengeBattleTarget = 2218,
	[OriginalName("PlayerActionType_PlayerActionChallengeBossEnd")]
	PlayerActionChallengeBossEnd = 2219,
	[OriginalName("PlayerActionType_PlayerActionChallengeBossFastPass")]
	PlayerActionChallengeBossFastPass = 2220,
	[OriginalName("PlayerActionType_PlayerActionChallengeStartPartial")]
	PlayerActionChallengeStartPartial = 2221,
	[OriginalName("PlayerActionType_PlayerActionChallengeBossPhaseStart")]
	PlayerActionChallengeBossPhaseStart = 2222,
	[OriginalName("PlayerActionType_PlayerActionChallengeBossPhaseEnd")]
	PlayerActionChallengeBossPhaseEnd = 2223,
	[OriginalName("PlayerActionType_PlayerActionChallengeBossPhaseEndBeforeBattle")]
	PlayerActionChallengeBossPhaseEndBeforeBattle = 2224,
	[OriginalName("PlayerActionType_PlayerActionChallengeRecommendLineup")]
	PlayerActionChallengeRecommendLineup = 2225,
	[OriginalName("PlayerActionType_PlayerActionChallengeStoryFeverBattleEnd")]
	PlayerActionChallengeStoryFeverBattleEnd = 2226,
	[OriginalName("PlayerActionType_PlayerActionTeamInfoChange")]
	PlayerActionTeamInfoChange = 2301,
	[OriginalName("PlayerActionType_PlayerActionChangeCurrentAvatar")]
	PlayerActionChangeCurrentAvatar = 2302,
	[OriginalName("PlayerActionType_PlayerActionCreateVirtualTeam")]
	PlayerActionCreateVirtualTeam = 2303,
	[OriginalName("PlayerActionType_PlayerActionTeamNameEdit")]
	PlayerActionTeamNameEdit = 2304,
	[OriginalName("PlayerActionType_PlayerActionReplaceLineupAvatar")]
	PlayerActionReplaceLineupAvatar = 2305,
	[OriginalName("PlayerActionType_PlayerActionAvatarBuffChange")]
	PlayerActionAvatarBuffChange = 2401,
	[OriginalName("PlayerActionType_PlayerActionEnvBuffChange")]
	PlayerActionEnvBuffChange = 2402,
	[OriginalName("PlayerActionType_PlayerActionGameCore")]
	PlayerActionGameCore = 2403,
	[OriginalName("PlayerActionType_PlayerActionAvatarGlobalBuff")]
	PlayerActionAvatarGlobalBuff = 2404,
	[OriginalName("PlayerActionType_PlayerActionRogueExploreStart")]
	PlayerActionRogueExploreStart = 2501,
	[OriginalName("PlayerActionType_PlayerActionRogueEnterRoom")]
	PlayerActionRogueEnterRoom = 2502,
	[OriginalName("PlayerActionType_PlayerActionRogueLeaveRoom")]
	PlayerActionRogueLeaveRoom = 2503,
	[OriginalName("PlayerActionType_PlayerActionRogueExploreFinish")]
	PlayerActionRogueExploreFinish = 2504,
	[OriginalName("PlayerActionType_PlayerActionRogueSelectBuff")]
	PlayerActionRogueSelectBuff = 2505,
	[OriginalName("PlayerActionType_PlayerActionRogueRollBuff")]
	PlayerActionRogueRollBuff = 2506,
	[OriginalName("PlayerActionType_PlayerActionRogueRevive")]
	PlayerActionRogueRevive = 2507,
	[OriginalName("PlayerActionType_PlayerActionRogueChallengeStart")]
	PlayerActionRogueChallengeStart = 2512,
	[OriginalName("PlayerActionType_PlayerActionRogueMiracle")]
	PlayerActionRogueMiracle = 2514,
	[OriginalName("PlayerActionType_PlayerActionRogueAddBuff")]
	PlayerActionRogueAddBuff = 2515,
	[OriginalName("PlayerActionType_PlayerActionRoguePickAvatar")]
	PlayerActionRoguePickAvatar = 2516,
	[OriginalName("PlayerActionType_PlayerActionRogueSeasonChanged")]
	PlayerActionRogueSeasonChanged = 2522,
	[OriginalName("PlayerActionType_PlayerActionRogueAeonLevelUp")]
	PlayerActionRogueAeonLevelUp = 2524,
	[OriginalName("PlayerActionType_PlayerActionRogueOpenDoor")]
	PlayerActionRogueOpenDoor = 2525,
	[OriginalName("PlayerActionType_PlayerActionRogueScoreReward")]
	PlayerActionRogueScoreReward = 2526,
	[OriginalName("PlayerActionType_PlayerActionRogueEnhanceBuff")]
	PlayerActionRogueEnhanceBuff = 2527,
	[OriginalName("PlayerActionType_PlayerActionRogueSelectBonus")]
	PlayerActionRogueSelectBonus = 2528,
	[OriginalName("PlayerActionType_PlayerActionRogueAreaFirstReward")]
	PlayerActionRogueAreaFirstReward = 2529,
	[OriginalName("PlayerActionType_PlayerActionRogueEnableTalent")]
	PlayerActionRogueEnableTalent = 2530,
	[OriginalName("PlayerActionType_PlayerActionRogueAeonUnlock")]
	PlayerActionRogueAeonUnlock = 2531,
	[OriginalName("PlayerActionType_PlayerActionRogueAeonAddExp")]
	PlayerActionRogueAeonAddExp = 2532,
	[OriginalName("PlayerActionType_PlayerActionRogueImmerseLevelUp")]
	PlayerActionRogueImmerseLevelUp = 2533,
	[OriginalName("PlayerActionType_PlayerActionRogueSelectMiracle")]
	PlayerActionRogueSelectMiracle = 2534,
	[OriginalName("PlayerActionType_PlayerActionRogueUnlockArea")]
	PlayerActionRogueUnlockArea = 2535,
	[OriginalName("PlayerActionType_PlayerActionRogueExploreScoreChange")]
	PlayerActionRogueExploreScoreChange = 2536,
	[OriginalName("PlayerActionType_PlayerActionRogueUpdateRewardPool")]
	PlayerActionRogueUpdateRewardPool = 2537,
	[OriginalName("PlayerActionType_PlayerActionRogueSwapBuff")]
	PlayerActionRogueSwapBuff = 2539,
	[OriginalName("PlayerActionType_PlayerActionRogueWeeklyRefresh")]
	PlayerActionRogueWeeklyRefresh = 2540,
	[OriginalName("PlayerActionType_PlayerActionRogueExchangeKey")]
	PlayerActionRogueExchangeKey = 2541,
	[OriginalName("PlayerActionType_PlayerActionRogueGetObjectReward")]
	PlayerActionRogueGetObjectReward = 2542,
	[OriginalName("PlayerActionType_PlayerActionRogueAreaMonsterDrop")]
	PlayerActionRogueAreaMonsterDrop = 2543,
	[OriginalName("PlayerActionType_PlayerActionRogueAddMiracle")]
	PlayerActionRogueAddMiracle = 2544,
	[OriginalName("PlayerActionType_PlayerActionRogueSwapMiracle")]
	PlayerActionRogueSwapMiracle = 2545,
	[OriginalName("PlayerActionType_PlayerActionRogueOpenObjectReward")]
	PlayerActionRogueOpenObjectReward = 2546,
	[OriginalName("PlayerActionType_PlayerActionRogueAeonEffect")]
	PlayerActionRogueAeonEffect = 2547,
	[OriginalName("PlayerActionType_PlayerActionRogueReforgeBuff")]
	PlayerActionRogueReforgeBuff = 2548,
	[OriginalName("PlayerActionType_PlayerActionRogueTradeMiracle")]
	PlayerActionRogueTradeMiracle = 2549,
	[OriginalName("PlayerActionType_PlayerActionRogueRemoveAvatar")]
	PlayerActionRogueRemoveAvatar = 2550,
	[OriginalName("PlayerActionType_PlayerActionRogueDialogueSelect")]
	PlayerActionRogueDialogueSelect = 2551,
	[OriginalName("PlayerActionType_PlayerActionRogueSelectAeon")]
	PlayerActionRogueSelectAeon = 2552,
	[OriginalName("PlayerActionType_PlayerActionRogueDialogueFinish")]
	PlayerActionRogueDialogueFinish = 2553,
	[OriginalName("PlayerActionType_PlayerActionRogueHandbookReward")]
	PlayerActionRogueHandbookReward = 2554,
	[OriginalName("PlayerActionType_PlayerActionRogueAdventureRoomReward")]
	PlayerActionRogueAdventureRoomReward = 2555,
	[OriginalName("PlayerActionType_PlayerActionRogueShopBuy")]
	PlayerActionRogueShopBuy = 2556,
	[OriginalName("PlayerActionType_PlayerActionRogueRepairMiracle")]
	PlayerActionRogueRepairMiracle = 2557,
	[OriginalName("PlayerActionType_PlayerActionRogueReplaceAllMiracle")]
	PlayerActionRogueReplaceAllMiracle = 2558,
	[OriginalName("PlayerActionType_PlayerActionRogueMiracleBroken")]
	PlayerActionRogueMiracleBroken = 2559,
	[OriginalName("PlayerActionType_PlayerActionRogueShopRefresh")]
	PlayerActionRogueShopRefresh = 2560,
	[OriginalName("PlayerActionType_PlayerActionRogueLevelMechanism")]
	PlayerActionRogueLevelMechanism = 2561,
	[OriginalName("PlayerActionType_PlayerActionRogueRemoveMiracle")]
	PlayerActionRogueRemoveMiracle = 2562,
	[OriginalName("PlayerActionType_PlayerActionRogueDropBuff")]
	PlayerActionRogueDropBuff = 2563,
	[OriginalName("PlayerActionType_PlayerActionRogueDestroyMiracle")]
	PlayerActionRogueDestroyMiracle = 2564,
	[OriginalName("PlayerActionType_PlayerActionRogueActivateFormula")]
	PlayerActionRogueActivateFormula = 2565,
	[OriginalName("PlayerActionType_PlayerActionRogueDeactivateFormula")]
	PlayerActionRogueDeactivateFormula = 2566,
	[OriginalName("PlayerActionType_PlayerActionRogueRemoveBuff")]
	PlayerActionRogueRemoveBuff = 2567,
	[OriginalName("PlayerActionType_PlayerActionRogueSelectFormula")]
	PlayerActionRogueSelectFormula = 2568,
	[OriginalName("PlayerActionType_PlayerActionRogueDropFormula")]
	PlayerActionRogueDropFormula = 2569,
	[OriginalName("PlayerActionType_PlayerActionRogueRollFormula")]
	PlayerActionRogueRollFormula = 2570,
	[OriginalName("PlayerActionType_PlayerActionRogueReforgeFormula")]
	PlayerActionRogueReforgeFormula = 2571,
	[OriginalName("PlayerActionType_PlayerActionRogueComposeMiracle")]
	PlayerActionRogueComposeMiracle = 2572,
	[OriginalName("PlayerActionType_PlayerActionRogueReforgeMiracle")]
	PlayerActionRogueReforgeMiracle = 2573,
	[OriginalName("PlayerActionType_PlayerActionRogueDoGamble")]
	PlayerActionRogueDoGamble = 2574,
	[OriginalName("PlayerActionType_PlayerActionRogueKeywordActivate")]
	PlayerActionRogueKeywordActivate = 2575,
	[OriginalName("PlayerActionType_PlayerActionRogueKeywordDeactivate")]
	PlayerActionRogueKeywordDeactivate = 2576,
	[OriginalName("PlayerActionType_PlayerActionRogueSourceDefault")]
	PlayerActionRogueSourceDefault = 2577,
	[OriginalName("PlayerActionType_PlayerActionRoguePlayerSelect")]
	PlayerActionRoguePlayerSelect = 2578,
	[OriginalName("PlayerActionType_PlayerActionRogueLayerSettlement")]
	PlayerActionRogueLayerSettlement = 2579,
	[OriginalName("PlayerActionType_PlayerActionRogueFormula")]
	PlayerActionRogueFormula = 2580,
	[OriginalName("PlayerActionType_PlayerActionRogueWorkbench")]
	PlayerActionRogueWorkbench = 2581,
	[OriginalName("PlayerActionType_PlayerActionRogueModifier")]
	PlayerActionRogueModifier = 2582,
	[OriginalName("PlayerActionType_PlayerActionRogueReforge")]
	PlayerActionRogueReforge = 2583,
	[OriginalName("PlayerActionType_PlayerActionRogueTalent")]
	PlayerActionRogueTalent = 2584,
	[OriginalName("PlayerActionType_PlayerActionRogueReroll")]
	PlayerActionRogueReroll = 2585,
	[OriginalName("PlayerActionType_PlayerActionRogueCoinChange")]
	PlayerActionRogueCoinChange = 2586,
	[OriginalName("PlayerActionType_PlayerActionRogueMagicScepterShop")]
	PlayerActionRogueMagicScepterShop = 2587,
	[OriginalName("PlayerActionType_PlayerActionRogueMagicUnitShop")]
	PlayerActionRogueMagicUnitShop = 2588,
	[OriginalName("PlayerActionType_PlayerActionRogueMagicScepterLevelUp")]
	PlayerActionRogueMagicScepterLevelUp = 2589,
	[OriginalName("PlayerActionType_PlayerActionGacha")]
	PlayerActionGacha = 2601,
	[OriginalName("PlayerActionType_PlayerActionAddGachaTicket")]
	PlayerActionAddGachaTicket = 2602,
	[OriginalName("PlayerActionType_PlayerActionGachaExchange")]
	PlayerActionGachaExchange = 2603,
	[OriginalName("PlayerActionType_PlayerActionSetGachaDecideItem")]
	PlayerActionSetGachaDecideItem = 2604,
	[OriginalName("PlayerActionType_PlayerActionEventMissionAccept")]
	PlayerActionEventMissionAccept = 2801,
	[OriginalName("PlayerActionType_PlayerActionEventMissionFinish")]
	PlayerActionEventMissionFinish = 2802,
	[OriginalName("PlayerActionType_PlayerActionEventMissionReward")]
	PlayerActionEventMissionReward = 2803,
	[OriginalName("PlayerActionType_PlayerActionRaidFinish")]
	PlayerActionRaidFinish = 2901,
	[OriginalName("PlayerActionType_PlayerActionRaidBegin")]
	PlayerActionRaidBegin = 2902,
	[OriginalName("PlayerActionType_PlayerActionChallengeRaidReward")]
	PlayerActionChallengeRaidReward = 2903,
	[OriginalName("PlayerActionType_PlayerActionStartRaid")]
	PlayerActionStartRaid = 2904,
	[OriginalName("PlayerActionType_PlayerActionEndRaid")]
	PlayerActionEndRaid = 2905,
	[OriginalName("PlayerActionType_PlayerActionRaidTargetFinish")]
	PlayerActionRaidTargetFinish = 2906,
	[OriginalName("PlayerActionType_PlayerActionArchiveRaid")]
	PlayerActionArchiveRaid = 2907,
	[OriginalName("PlayerActionType_PlayerActionHeroBaseTypeChange")]
	PlayerActionHeroBaseTypeChange = 3051,
	[OriginalName("PlayerActionType_PlayerActionHeroBaseTypeAddByMission")]
	PlayerActionHeroBaseTypeAddByMission = 3052,
	[OriginalName("PlayerActionType_PlayerActionHeroBaseTypeAddByReq")]
	PlayerActionHeroBaseTypeAddByReq = 3053,
	[OriginalName("PlayerActionType_PlayerActionHeroBaseTypeAdd")]
	PlayerActionHeroBaseTypeAdd = 3054,
	[OriginalName("PlayerActionType_PlayerActionDialogueSelect")]
	PlayerActionDialogueSelect = 3101,
	[OriginalName("PlayerActionType_PlayerActionExpeditionStart")]
	PlayerActionExpeditionStart = 3151,
	[OriginalName("PlayerActionType_PlayerActionExpeditionFinish")]
	PlayerActionExpeditionFinish = 3152,
	[OriginalName("PlayerActionType_PlayerActionExpeditionReward")]
	PlayerActionExpeditionReward = 3153,
	[OriginalName("PlayerActionType_PlayerActionActivityExpeditionStart")]
	PlayerActionActivityExpeditionStart = 3154,
	[OriginalName("PlayerActionType_PlayerActionActivityExpeditionFinish")]
	PlayerActionActivityExpeditionFinish = 3155,
	[OriginalName("PlayerActionType_PlayerActionActivityExpeditionReward")]
	PlayerActionActivityExpeditionReward = 3156,
	[OriginalName("PlayerActionType_PlayerActionActivityExpeditionBegin")]
	PlayerActionActivityExpeditionBegin = 3157,
	[OriginalName("PlayerActionType_PlayerActionActivityExpeditionEnd")]
	PlayerActionActivityExpeditionEnd = 3158,
	[OriginalName("PlayerActionType_PlayerActionExpeditionSet")]
	PlayerActionExpeditionSet = 3159,
	[OriginalName("PlayerActionType_PlayerActionExpeditionTakeReward")]
	PlayerActionExpeditionTakeReward = 3160,
	[OriginalName("PlayerActionType_PlayerActionActivityLoginReward")]
	PlayerActionActivityLoginReward = 3201,
	[OriginalName("PlayerActionType_PlayerActionFriendReport")]
	PlayerActionFriendReport = 3301,
	[OriginalName("PlayerActionType_PlayerActionAssistReward")]
	PlayerActionAssistReward = 3302,
	[OriginalName("PlayerActionType_PlayerActionAssistAvatarRefresh")]
	PlayerActionAssistAvatarRefresh = 3303,
	[OriginalName("PlayerActionType_PlayerActionAssistAvatarBattleStart")]
	PlayerActionAssistAvatarBattleStart = 3304,
	[OriginalName("PlayerActionType_PlayerActionAssistAvatarBattleEnd")]
	PlayerActionAssistAvatarBattleEnd = 3305,
	[OriginalName("PlayerActionType_PlayerActionFriendApply")]
	PlayerActionFriendApply = 3306,
	[OriginalName("PlayerActionType_PlayerActionFriendManage")]
	PlayerActionFriendManage = 3307,
	[OriginalName("PlayerActionType_PlayerActionFriendBlacklist")]
	PlayerActionFriendBlacklist = 3308,
	[OriginalName("PlayerActionType_PlayerActionFriendModifyRemarkName")]
	PlayerActionFriendModifyRemarkName = 3309,
	[OriginalName("PlayerActionType_PlayerActionFriendMark")]
	PlayerActionFriendMark = 3310,
	[OriginalName("PlayerActionType_PlayerActionFriendAssistList")]
	PlayerActionFriendAssistList = 3311,
	[OriginalName("PlayerActionType_PlayerActionBattlePassLevelReward")]
	PlayerActionBattlePassLevelReward = 3202,
	[OriginalName("PlayerActionType_PlayerActionBattlePass128TierReward")]
	PlayerActionBattlePass128TierReward = 3203,
	[OriginalName("PlayerActionType_PlayerActionBattlePassLevelRewardAutoMail")]
	PlayerActionBattlePassLevelRewardAutoMail = 3204,
	[OriginalName("PlayerActionType_PlayerActionBuyBattlePass")]
	PlayerActionBuyBattlePass = 3205,
	[OriginalName("PlayerActionType_PlayerActionAddBattlePassExp")]
	PlayerActionAddBattlePassExp = 3206,
	[OriginalName("PlayerActionType_PlayerActionBattlePassLevelUp")]
	PlayerActionBattlePassLevelUp = 3207,
	[OriginalName("PlayerActionType_PlayerActionBuyBattlePassLevel")]
	PlayerActionBuyBattlePassLevel = 3208,
	[OriginalName("PlayerActionType_PlayerActionBattlePassEndMail")]
	PlayerActionBattlePassEndMail = 3209,
	[OriginalName("PlayerActionType_PlayerActionBattlePass68TierReward")]
	PlayerActionBattlePass68TierReward = 3210,
	[OriginalName("PlayerActionType_PlayerActionModifySign")]
	PlayerActionModifySign = 3401,
	[OriginalName("PlayerActionType_PlayerActionDisplayAvatarSet")]
	PlayerActionDisplayAvatarSet = 3402,
	[OriginalName("PlayerActionType_PlayerActionAssistAvatarSet")]
	PlayerActionAssistAvatarSet = 3403,
	[OriginalName("PlayerActionType_PlayerActionAchievementFinish")]
	PlayerActionAchievementFinish = 3501,
	[OriginalName("PlayerActionType_PlayerActionAchievementReward")]
	PlayerActionAchievementReward = 3502,
	[OriginalName("PlayerActionType_PlayerActionAchievementAddExp")]
	PlayerActionAchievementAddExp = 3503,
	[OriginalName("PlayerActionType_PlayerActionAchievementLevelUp")]
	PlayerActionAchievementLevelUp = 3504,
	[OriginalName("PlayerActionType_PlayerActionPunkLordReward")]
	PlayerActionPunkLordReward = 3601,
	[OriginalName("PlayerActionType_PlayerActionPunkLordBossSearch")]
	PlayerActionPunkLordBossSearch = 3604,
	[OriginalName("PlayerActionType_PlayerActionPunkLordBossShare")]
	PlayerActionPunkLordBossShare = 3605,
	[OriginalName("PlayerActionType_PlayerActionStartPunkLordRaid")]
	PlayerActionStartPunkLordRaid = 3606,
	[OriginalName("PlayerActionType_PlayerActionPunkLordSupportTimes")]
	PlayerActionPunkLordSupportTimes = 3608,
	[OriginalName("PlayerActionType_PlayerActionPunkLordScoreReward")]
	PlayerActionPunkLordScoreReward = 3609,
	[OriginalName("PlayerActionType_PlayerActionPunkLordListRefresh")]
	PlayerActionPunkLordListRefresh = 3610,
	[OriginalName("PlayerActionType_PlayerActionPunkLordPowerAttack")]
	PlayerActionPunkLordPowerAttack = 3611,
	[OriginalName("PlayerActionType_PlayerActionPunkLordBattleEnd")]
	PlayerActionPunkLordBattleEnd = 3612,
	[OriginalName("PlayerActionType_PlayerActionPunkLordBossDeath")]
	PlayerActionPunkLordBossDeath = 3613,
	[OriginalName("PlayerActionType_PlayerActionPunkLordBossScore")]
	PlayerActionPunkLordBossScore = 3614,
	[OriginalName("PlayerActionType_PlayerActionDailyActiveLevelReward")]
	PlayerActionDailyActiveLevelReward = 3701,
	[OriginalName("PlayerActionType_PlayerActionDailyActiveAddPoint")]
	PlayerActionDailyActiveAddPoint = 3702,
	[OriginalName("PlayerActionType_PlayerActionDailyActiveDeleteOldQuest")]
	PlayerActionDailyActiveDeleteOldQuest = 3703,
	[OriginalName("PlayerActionType_PlayerActionFightActivityBegin")]
	PlayerActionFightActivityBegin = 3791,
	[OriginalName("PlayerActionType_PlayerActionFightActivityEnd")]
	PlayerActionFightActivityEnd = 3792,
	[OriginalName("PlayerActionType_PlayerActionFightActivityReward")]
	PlayerActionFightActivityReward = 3801,
	[OriginalName("PlayerActionType_PlayerActionActivityEndMail")]
	PlayerActionActivityEndMail = 3802,
	[OriginalName("PlayerActionType_PlayerActionAppointmentMail")]
	PlayerActionAppointmentMail = 3803,
	[OriginalName("PlayerActionType_PlayerActionShareReward")]
	PlayerActionShareReward = 3804,
	[OriginalName("PlayerActionType_PlayerActionActivityTrialReward")]
	PlayerActionActivityTrialReward = 3805,
	[OriginalName("PlayerActionType_PlayerActionActivityTrialStart")]
	PlayerActionActivityTrialStart = 3806,
	[OriginalName("PlayerActionType_PlayerActionPsPreOrderMail1")]
	PlayerActionPsPreOrderMail1 = 3811,
	[OriginalName("PlayerActionType_PlayerActionPsPreOrderMail2")]
	PlayerActionPsPreOrderMail2 = 3812,
	[OriginalName("PlayerActionType_PlayerActionPsLoginMail")]
	PlayerActionPsLoginMail = 3813,
	[OriginalName("PlayerActionType_PlayerActionLoginMail")]
	PlayerActionLoginMail = 3814,
	[OriginalName("PlayerActionType_PlayerActionGooglePoints100Mail")]
	PlayerActionGooglePoints100Mail = 3821,
	[OriginalName("PlayerActionType_PlayerActionGooglePoints150Mail")]
	PlayerActionGooglePoints150Mail = 3822,
	[OriginalName("PlayerActionType_PlayerActionTrainVisitorBehaviorFinish")]
	PlayerActionTrainVisitorBehaviorFinish = 3901,
	[OriginalName("PlayerActionType_PlayerActionEnterViewTrain")]
	PlayerActionEnterViewTrain = 3902,
	[OriginalName("PlayerActionType_PlayerActionTrainVisitorBehaviorRewardForceSend")]
	PlayerActionTrainVisitorBehaviorRewardForceSend = 3903,
	[OriginalName("PlayerActionType_PlayerActionTrainVisitorRegisterOpen")]
	PlayerActionTrainVisitorRegisterOpen = 3904,
	[OriginalName("PlayerActionType_PlayerActionTrainVisitorBehaviorRewardForceSendByRegister")]
	PlayerActionTrainVisitorBehaviorRewardForceSendByRegister = 3905,
	[OriginalName("PlayerActionType_PlayerActionTrainVisitorClearLastTrainVisitor")]
	PlayerActionTrainVisitorClearLastTrainVisitor = 3906,
	[OriginalName("PlayerActionType_PlayerActionTrainVisitorRefreshTrainVisitor")]
	PlayerActionTrainVisitorRefreshTrainVisitor = 3907,
	[OriginalName("PlayerActionType_PlayerActionTrainVisitorRefreshNpc")]
	PlayerActionTrainVisitorRefreshNpc = 3908,
	[OriginalName("PlayerActionType_PlayerActionMessageGroupAccept")]
	PlayerActionMessageGroupAccept = 3951,
	[OriginalName("PlayerActionType_PlayerActionMessageSectionAccept")]
	PlayerActionMessageSectionAccept = 3952,
	[OriginalName("PlayerActionType_PlayerActionMessageSectionFinish")]
	PlayerActionMessageSectionFinish = 3953,
	[OriginalName("PlayerActionType_PlayerActionMessageItemFinish")]
	PlayerActionMessageItemFinish = 3954,
	[OriginalName("PlayerActionType_PlayerActionFinishMessageGroupReward")]
	PlayerActionFinishMessageGroupReward = 3955,
	[OriginalName("PlayerActionType_PlayerActionSubstituteMessageGroupReward")]
	PlayerActionSubstituteMessageGroupReward = 3956,
	[OriginalName("PlayerActionType_PlayerActionDeleteMessageGroup")]
	PlayerActionDeleteMessageGroup = 3957,
	[OriginalName("PlayerActionType_PlayerActionDeleteMessageSection")]
	PlayerActionDeleteMessageSection = 3958,
	[OriginalName("PlayerActionType_PlayerActionDeleteMessageGroupByConfig")]
	PlayerActionDeleteMessageGroupByConfig = 3959,
	[OriginalName("PlayerActionType_PlayerActionDeleteMessageGroupByActivity")]
	PlayerActionDeleteMessageGroupByActivity = 3960,
	[OriginalName("PlayerActionType_PlayerActionDeleteMessageGroupByMission")]
	PlayerActionDeleteMessageGroupByMission = 3961,
	[OriginalName("PlayerActionType_PlayerActionTextJoinSave")]
	PlayerActionTextJoinSave = 4001,
	[OriginalName("PlayerActionType_PlayerActionBoxingClubStart")]
	PlayerActionBoxingClubStart = 4051,
	[OriginalName("PlayerActionType_PlayerActionBoxingClubFinish")]
	PlayerActionBoxingClubFinish = 4052,
	[OriginalName("PlayerActionType_PlayerActionBoxingClubPause")]
	PlayerActionBoxingClubPause = 4053,
	[OriginalName("PlayerActionType_PlayerActionBoxingClubStageStart")]
	PlayerActionBoxingClubStageStart = 4054,
	[OriginalName("PlayerActionType_PlayerActionTalkSend")]
	PlayerActionTalkSend = 4101,
	[OriginalName("PlayerActionType_PlayerActionSelectInclinationText")]
	PlayerActionSelectInclinationText = 4102,
	[OriginalName("PlayerActionType_PlayerActionMuseumSettleTurnOpen")]
	PlayerActionMuseumSettleTurnOpen = 4201,
	[OriginalName("PlayerActionType_PlayerActionMuseumUpgradeArea")]
	PlayerActionMuseumUpgradeArea = 4202,
	[OriginalName("PlayerActionType_PlayerActionMuseumUpgradeAreaStat")]
	PlayerActionMuseumUpgradeAreaStat = 4203,
	[OriginalName("PlayerActionType_PlayerActionMuseumDispatchRewardRegular")]
	PlayerActionMuseumDispatchRewardRegular = 4204,
	[OriginalName("PlayerActionType_PlayerActionMuseumDispatchRewardDirectional")]
	PlayerActionMuseumDispatchRewardDirectional = 4205,
	[OriginalName("PlayerActionType_PlayerActionMuseumPhaseTargetFinished")]
	PlayerActionMuseumPhaseTargetFinished = 4206,
	[OriginalName("PlayerActionType_PlayerActionMuseumGetStuff")]
	PlayerActionMuseumGetStuff = 4207,
	[OriginalName("PlayerActionType_PlayerActionMuseumGetExhibit")]
	PlayerActionMuseumGetExhibit = 4208,
	[OriginalName("PlayerActionType_PlayerActionMuseumTakeCollectMission")]
	PlayerActionMuseumTakeCollectMission = 4209,
	[OriginalName("PlayerActionType_PlayerActionMuseumAreaUnlock")]
	PlayerActionMuseumAreaUnlock = 4210,
	[OriginalName("PlayerActionType_PlayerActionMuseumAreaUpgrade")]
	PlayerActionMuseumAreaUpgrade = 4211,
	[OriginalName("PlayerActionType_PlayerActionMuseumAreaStatUpgrade")]
	PlayerActionMuseumAreaStatUpgrade = 4212,
	[OriginalName("PlayerActionType_PlayerActionMuseumEnterNextRound")]
	PlayerActionMuseumEnterNextRound = 4213,
	[OriginalName("PlayerActionType_PlayerActionMuseumStartDispatch")]
	PlayerActionMuseumStartDispatch = 4214,
	[OriginalName("PlayerActionType_PlayerActionMuseumSettleDispatch")]
	PlayerActionMuseumSettleDispatch = 4215,
	[OriginalName("PlayerActionType_PlayerActionMuseumRenewPointChanged")]
	PlayerActionMuseumRenewPointChanged = 4216,
	[OriginalName("PlayerActionType_PlayerActionMuseumTargetReward")]
	PlayerActionMuseumTargetReward = 4217,
	[OriginalName("PlayerActionType_PlayerActionMuseumPhaseUpgrade")]
	PlayerActionMuseumPhaseUpgrade = 4218,
	[OriginalName("PlayerActionType_PlayerActionMuseumCollectReward")]
	PlayerActionMuseumCollectReward = 4219,
	[OriginalName("PlayerActionType_PlayerActionMuseumTargetStart")]
	PlayerActionMuseumTargetStart = 4220,
	[OriginalName("PlayerActionType_PlayerActionMuseumTargetFinish")]
	PlayerActionMuseumTargetFinish = 4221,
	[OriginalName("PlayerActionType_PlayerActionActivityMonsterResearchConsumeMaterial")]
	PlayerActionActivityMonsterResearchConsumeMaterial = 4301,
	[OriginalName("PlayerActionType_PlayerActionActivityMonsterResearchTakeReward")]
	PlayerActionActivityMonsterResearchTakeReward = 4302,
	[OriginalName("PlayerActionType_PlayerActionPlayerReturnStart")]
	PlayerActionPlayerReturnStart = 4401,
	[OriginalName("PlayerActionType_PlayerActionPlayerReturnSign")]
	PlayerActionPlayerReturnSign = 4402,
	[OriginalName("PlayerActionType_PlayerActionPlayerReturnPoint")]
	PlayerActionPlayerReturnPoint = 4403,
	[OriginalName("PlayerActionType_PlayerActionPlayerReturnCountdown")]
	PlayerActionPlayerReturnCountdown = 4404,
	[OriginalName("PlayerActionType_PlayerActionPlayerReturnFinish")]
	PlayerActionPlayerReturnFinish = 4405,
	[OriginalName("PlayerActionType_PlayerActionPlayerReturnCompensate")]
	PlayerActionPlayerReturnCompensate = 4406,
	[OriginalName("PlayerActionType_PlayerActionPlayerReturnGetRelic")]
	PlayerActionPlayerReturnGetRelic = 4407,
	[OriginalName("PlayerActionType_PlayerActionPlayerReturnBpExpExtra")]
	PlayerActionPlayerReturnBpExpExtra = 4408,
	[OriginalName("PlayerActionType_PlayerActionPlayerReturnHcoinExtra")]
	PlayerActionPlayerReturnHcoinExtra = 4409,
	[OriginalName("PlayerActionType_PlayerActionPlayerReturnCustomRelic")]
	PlayerActionPlayerReturnCustomRelic = 4410,
	[OriginalName("PlayerActionType_PlayerActionRogueChallengeActivityStart")]
	PlayerActionRogueChallengeActivityStart = 4411,
	[OriginalName("PlayerActionType_PlayerActionRogueChallengeActivityFinish")]
	PlayerActionRogueChallengeActivityFinish = 4412,
	[OriginalName("PlayerActionType_PlayerActionRogueChallengeActivitySave")]
	PlayerActionRogueChallengeActivitySave = 4413,
	[OriginalName("PlayerActionType_PlayerActionPlayerReturnLoginMail")]
	PlayerActionPlayerReturnLoginMail = 4431,
	[OriginalName("PlayerActionType_PlayerActionAetherDivideUsePassiveSkillItem")]
	PlayerActionAetherDivideUsePassiveSkillItem = 4450,
	[OriginalName("PlayerActionType_PlayerActionAetherDivideClearPassiveSkill")]
	PlayerActionAetherDivideClearPassiveSkill = 4451,
	[OriginalName("PlayerActionType_PlayerActionAetherDivideFinishChallenge")]
	PlayerActionAetherDivideFinishChallenge = 4452,
	[OriginalName("PlayerActionType_PlayerActionAetherDivideOverflowChunkReward")]
	PlayerActionAetherDivideOverflowChunkReward = 4453,
	[OriginalName("PlayerActionType_PlayerActionAetherDivideLevelUp")]
	PlayerActionAetherDivideLevelUp = 4454,
	[OriginalName("PlayerActionType_PlayerActionAetherDivideNewReward")]
	PlayerActionAetherDivideNewReward = 4455,
	[OriginalName("PlayerActionType_PlayerActionAetherDivideMonsterAdd")]
	PlayerActionAetherDivideMonsterAdd = 4456,
	[OriginalName("PlayerActionType_PlayerActionAetherDivideMonsterLevel")]
	PlayerActionAetherDivideMonsterLevel = 4457,
	[OriginalName("PlayerActionType_PlayerActionAetherDivideMonsterSkillWear")]
	PlayerActionAetherDivideMonsterSkillWear = 4458,
	[OriginalName("PlayerActionType_PlayerActionAetherDivideTeamChange")]
	PlayerActionAetherDivideTeamChange = 4459,
	[OriginalName("PlayerActionType_PlayerActionAetherDivideStageBegin")]
	PlayerActionAetherDivideStageBegin = 4460,
	[OriginalName("PlayerActionType_PlayerActionAetherDivideStageEnd")]
	PlayerActionAetherDivideStageEnd = 4461,
	[OriginalName("PlayerActionType_PlayerActionAetherDivideStageRoll")]
	PlayerActionAetherDivideStageRoll = 4462,
	[OriginalName("PlayerActionType_PlayerActionAlleyEventFinish")]
	PlayerActionAlleyEventFinish = 4501,
	[OriginalName("PlayerActionType_PlayerActionAlleyTakeReward")]
	PlayerActionAlleyTakeReward = 4502,
	[OriginalName("PlayerActionType_PlayerActionAlleyPrestigeLevelUp")]
	PlayerActionAlleyPrestigeLevelUp = 4503,
	[OriginalName("PlayerActionType_PlayerActionAlleyLogisticsFinish")]
	PlayerActionAlleyLogisticsFinish = 4504,
	[OriginalName("PlayerActionType_PlayerActionAlleyPlacingGameFinish")]
	PlayerActionAlleyPlacingGameFinish = 4505,
	[OriginalName("PlayerActionType_PlayerActionAlleyGuaranteedFunds")]
	PlayerActionAlleyGuaranteedFunds = 4506,
	[OriginalName("PlayerActionType_PlayerActionAlleyTakeEventReward")]
	PlayerActionAlleyTakeEventReward = 4507,
	[OriginalName("PlayerActionType_PlayerActionAlleySpecialOrderFinish")]
	PlayerActionAlleySpecialOrderFinish = 4508,
	[OriginalName("PlayerActionType_PlayerActionSensitiveWordShield")]
	PlayerActionSensitiveWordShield = 4601,
	[OriginalName("PlayerActionType_PlayerActionSensitiveWordServerInternalError")]
	PlayerActionSensitiveWordServerInternalError = 4602,
	[OriginalName("PlayerActionType_PlayerActionSensitiveWordPlatformError")]
	PlayerActionSensitiveWordPlatformError = 4603,
	[OriginalName("PlayerActionType_PlayerActionTreasureDungeonStart")]
	PlayerActionTreasureDungeonStart = 4701,
	[OriginalName("PlayerActionType_PlayerActionTreasureDungeonFinish")]
	PlayerActionTreasureDungeonFinish = 4702,
	[OriginalName("PlayerActionType_PlayerActionTreasureDungeonEnterFloor")]
	PlayerActionTreasureDungeonEnterFloor = 4703,
	[OriginalName("PlayerActionType_PlayerActionTreasureDungeonLeaveFloor")]
	PlayerActionTreasureDungeonLeaveFloor = 4704,
	[OriginalName("PlayerActionType_PlayerActionTreasureDungeonUseItem")]
	PlayerActionTreasureDungeonUseItem = 4705,
	[OriginalName("PlayerActionType_PlayerActionTreasureDungeonAvatarChange")]
	PlayerActionTreasureDungeonAvatarChange = 4706,
	[OriginalName("PlayerActionType_PlayerActionTreasureDungeonBattleStart")]
	PlayerActionTreasureDungeonBattleStart = 4707,
	[OriginalName("PlayerActionType_PlayerActionTreasureDungeonBattleEnd")]
	PlayerActionTreasureDungeonBattleEnd = 4708,
	[OriginalName("PlayerActionType_PlayerActionTreasureDungeonPickupBuff")]
	PlayerActionTreasureDungeonPickupBuff = 4709,
	[OriginalName("PlayerActionType_PlayerActionChessRogueFirstFinish")]
	PlayerActionChessRogueFirstFinish = 4801,
	[OriginalName("PlayerActionType_PlayerActionChessRogueGiveupDice")]
	PlayerActionChessRogueGiveupDice = 4802,
	[OriginalName("PlayerActionType_PlayerActionChessRogueSubStorySelect")]
	PlayerActionChessRogueSubStorySelect = 4803,
	[OriginalName("PlayerActionType_PlayerActionChessRogueActionPoint")]
	PlayerActionChessRogueActionPoint = 4804,
	[OriginalName("PlayerActionType_PlayerActionChessRogueReviveByProp")]
	PlayerActionChessRogueReviveByProp = 4805,
	[OriginalName("PlayerActionType_PlayerActionChessRogueStartLevel")]
	PlayerActionChessRogueStartLevel = 4806,
	[OriginalName("PlayerActionType_PlayerActionChessRogueDiceEffect")]
	PlayerActionChessRogueDiceEffect = 4807,
	[OriginalName("PlayerActionType_PlayerActionChessRogueMainStoryFinish")]
	PlayerActionChessRogueMainStoryFinish = 4808,
	[OriginalName("PlayerActionType_PlayerActionChessRogueAeonTalentEffect")]
	PlayerActionChessRogueAeonTalentEffect = 4809,
	[OriginalName("PlayerActionType_PlayerActionChessRogueModifierOthersEffect")]
	PlayerActionChessRogueModifierOthersEffect = 4810,
	[OriginalName("PlayerActionType_PlayerActionChessRogueAddBuff")]
	PlayerActionChessRogueAddBuff = 4811,
	[OriginalName("PlayerActionType_PlayerActionChessRogueReforgeBuff")]
	PlayerActionChessRogueReforgeBuff = 4812,
	[OriginalName("PlayerActionType_PlayerActionChessRogueBuffLevelUp")]
	PlayerActionChessRogueBuffLevelUp = 4813,
	[OriginalName("PlayerActionType_PlayerActionChessRogueEnhanceBuff")]
	PlayerActionChessRogueEnhanceBuff = 4814,
	[OriginalName("PlayerActionType_PlayerActionChessRogueAddMiracle")]
	PlayerActionChessRogueAddMiracle = 4815,
	[OriginalName("PlayerActionType_PlayerActionChessRogueSwapMiracle")]
	PlayerActionChessRogueSwapMiracle = 4816,
	[OriginalName("PlayerActionType_PlayerActionChessRogueSelectBonus")]
	PlayerActionChessRogueSelectBonus = 4817,
	[OriginalName("PlayerActionType_PlayerActionChessRogueDialogueFinish")]
	PlayerActionChessRogueDialogueFinish = 4818,
	[OriginalName("PlayerActionType_PlayerActionChessRogueSubStoryFinish")]
	PlayerActionChessRogueSubStoryFinish = 4819,
	[OriginalName("PlayerActionType_PlayerActionChessRogueAdventureRoomFinish")]
	PlayerActionChessRogueAdventureRoomFinish = 4820,
	[OriginalName("PlayerActionType_PlayerActionChessRogueFinishLevel")]
	PlayerActionChessRogueFinishLevel = 4821,
	[OriginalName("PlayerActionType_PlayerActionChessRogueStartLayer")]
	PlayerActionChessRogueStartLayer = 4822,
	[OriginalName("PlayerActionType_PlayerActionChessRogueFinishLayer")]
	PlayerActionChessRogueFinishLayer = 4823,
	[OriginalName("PlayerActionType_PlayerActionChessRogueEnterRoom")]
	PlayerActionChessRogueEnterRoom = 4824,
	[OriginalName("PlayerActionType_PlayerActionChessRogueLeaveRoom")]
	PlayerActionChessRogueLeaveRoom = 4825,
	[OriginalName("PlayerActionType_PlayerActionChessRogueRollDice")]
	PlayerActionChessRogueRollDice = 4826,
	[OriginalName("PlayerActionType_PlayerActionChessRogueSelectDice")]
	PlayerActionChessRogueSelectDice = 4827,
	[OriginalName("PlayerActionType_PlayerActionChessRogueUnlockDice")]
	PlayerActionChessRogueUnlockDice = 4828,
	[OriginalName("PlayerActionType_PlayerActionChessRogueBoardEvent")]
	PlayerActionChessRogueBoardEvent = 4829,
	[OriginalName("PlayerActionType_PlayerActionChessRogueDimensionPoint")]
	PlayerActionChessRogueDimensionPoint = 4830,
	[OriginalName("PlayerActionType_PlayerActionChessRoguePickAvatar")]
	PlayerActionChessRoguePickAvatar = 4831,
	[OriginalName("PlayerActionType_PlayerActionChessRogueReviveAvatar")]
	PlayerActionChessRogueReviveAvatar = 4832,
	[OriginalName("PlayerActionType_PlayerActionChessRogueNousSubStorySelect")]
	PlayerActionChessRogueNousSubStorySelect = 4833,
	[OriginalName("PlayerActionType_PlayerActionChessRogueLevelMechanism")]
	PlayerActionChessRogueLevelMechanism = 4844,
	[OriginalName("PlayerActionType_PlayerActionChessRogueNousStartLevel")]
	PlayerActionChessRogueNousStartLevel = 4845,
	[OriginalName("PlayerActionType_PlayerActionChessRogueNousFinishLevel")]
	PlayerActionChessRogueNousFinishLevel = 4846,
	[OriginalName("PlayerActionType_PlayerActionChessRogueNousStartLayer")]
	PlayerActionChessRogueNousStartLayer = 4847,
	[OriginalName("PlayerActionType_PlayerActionChessRogueNousFinishLayer")]
	PlayerActionChessRogueNousFinishLayer = 4848,
	[OriginalName("PlayerActionType_PlayerActionChessRogueNousEnterRoom")]
	PlayerActionChessRogueNousEnterRoom = 4849,
	[OriginalName("PlayerActionType_PlayerActionChessRogueNousLeaveRoom")]
	PlayerActionChessRogueNousLeaveRoom = 4850,
	[OriginalName("PlayerActionType_PlayerActionChessRogueNousSelectDice")]
	PlayerActionChessRogueNousSelectDice = 4851,
	[OriginalName("PlayerActionType_PlayerActionChessRogueNousUnlockDiceBranch")]
	PlayerActionChessRogueNousUnlockDiceBranch = 4852,
	[OriginalName("PlayerActionType_PlayerActionChessRogueNousUnlockDiceSurface")]
	PlayerActionChessRogueNousUnlockDiceSurface = 4853,
	[OriginalName("PlayerActionType_PlayerActionChessRogueNousEditDice")]
	PlayerActionChessRogueNousEditDice = 4854,
	[OriginalName("PlayerActionType_PlayerActionChessRogueNousValueChange")]
	PlayerActionChessRogueNousValueChange = 4855,
	[OriginalName("PlayerActionType_PlayerActionChessRogueNousMainStoryTrigger")]
	PlayerActionChessRogueNousMainStoryTrigger = 4856,
	[OriginalName("PlayerActionType_PlayerActionChessRogueNousMainStoryFinish")]
	PlayerActionChessRogueNousMainStoryFinish = 4857,
	[OriginalName("PlayerActionType_PlayerActionChessRogueNousSubStoryTrigger")]
	PlayerActionChessRogueNousSubStoryTrigger = 4858,
	[OriginalName("PlayerActionType_PlayerActionChessRogueNousSubStoryFinish")]
	PlayerActionChessRogueNousSubStoryFinish = 4859,
	[OriginalName("PlayerActionType_PlayerActionChessRogueNousEnableTalent")]
	PlayerActionChessRogueNousEnableTalent = 4860,
	[OriginalName("PlayerActionType_PlayerActionChessRogueSelectBuff")]
	PlayerActionChessRogueSelectBuff = 4861,
	[OriginalName("PlayerActionType_PlayerActionChessRogueSelectMiracle")]
	PlayerActionChessRogueSelectMiracle = 4862,
	[OriginalName("PlayerActionType_PlayerActionChessRogueRemoveMiracle")]
	PlayerActionChessRogueRemoveMiracle = 4863,
	[OriginalName("PlayerActionType_PlayerActionChessRogueBoardCell")]
	PlayerActionChessRogueBoardCell = 4864,
	[OriginalName("PlayerActionType_PlayerActionFantasticStoryBattleBegin")]
	PlayerActionFantasticStoryBattleBegin = 4901,
	[OriginalName("PlayerActionType_PlayerActionFantasticStoryBattleEnd")]
	PlayerActionFantasticStoryBattleEnd = 4902,
	[OriginalName("PlayerActionType_PlayerActionRogueEndlessReward")]
	PlayerActionRogueEndlessReward = 4950,
	[OriginalName("PlayerActionType_PlayerActionRogueEndlessLevelStart")]
	PlayerActionRogueEndlessLevelStart = 4951,
	[OriginalName("PlayerActionType_PlayerActionRogueEndlessStageBegin")]
	PlayerActionRogueEndlessStageBegin = 4952,
	[OriginalName("PlayerActionType_PlayerActionRogueEndlessStageEnd")]
	PlayerActionRogueEndlessStageEnd = 4953,
	[OriginalName("PlayerActionType_PlayerActionBattleCollegeReward")]
	PlayerActionBattleCollegeReward = 5001,
	[OriginalName("PlayerActionType_PlayerActionCommonRogueMiracleForBuffShop")]
	PlayerActionCommonRogueMiracleForBuffShop = 5051,
	[OriginalName("PlayerActionType_PlayerActionCommonRogueAdventureRoomFinish")]
	PlayerActionCommonRogueAdventureRoomFinish = 5052,
	[OriginalName("PlayerActionType_PlayerActionCommonRogueBuyBuffShop")]
	PlayerActionCommonRogueBuyBuffShop = 5053,
	[OriginalName("PlayerActionType_PlayerActionCommonRogueBuyBuffShopRefresh")]
	PlayerActionCommonRogueBuyBuffShopRefresh = 5054,
	[OriginalName("PlayerActionType_PlayerActionCommonRogueCollectionUnlock")]
	PlayerActionCommonRogueCollectionUnlock = 5055,
	[OriginalName("PlayerActionType_PlayerActionCommonRogueCollectionSet")]
	PlayerActionCommonRogueCollectionSet = 5056,
	[OriginalName("PlayerActionType_PlayerActionCommonRogueExhibitionUnlock")]
	PlayerActionCommonRogueExhibitionUnlock = 5057,
	[OriginalName("PlayerActionType_PlayerActionCommonRogueExhibitionSet")]
	PlayerActionCommonRogueExhibitionSet = 5058,
	[OriginalName("PlayerActionType_PlayerActionCommonRogueChestInteract")]
	PlayerActionCommonRogueChestInteract = 5059,
	[OriginalName("PlayerActionType_PlayerActionCommonRogueAdventureRoomWolfgunFinish")]
	PlayerActionCommonRogueAdventureRoomWolfgunFinish = 5060,
	[OriginalName("PlayerActionType_PlayerActionHeliobusPostIncomeReward")]
	PlayerActionHeliobusPostIncomeReward = 5101,
	[OriginalName("PlayerActionType_PlayerActionHeliobusPostFansReward")]
	PlayerActionHeliobusPostFansReward = 5102,
	[OriginalName("PlayerActionType_PlayerActionHeliobusLevelUpgrade")]
	PlayerActionHeliobusLevelUpgrade = 5103,
	[OriginalName("PlayerActionType_PlayerActionHeliobusPostReplyReward")]
	PlayerActionHeliobusPostReplyReward = 5104,
	[OriginalName("PlayerActionType_PlayerActionHeliobusCommentReplyReward")]
	PlayerActionHeliobusCommentReplyReward = 5105,
	[OriginalName("PlayerActionType_PlayerActionHeliobusChallengeFirstReward")]
	PlayerActionHeliobusChallengeFirstReward = 5106,
	[OriginalName("PlayerActionType_PlayerActionHeliobusFansAdd")]
	PlayerActionHeliobusFansAdd = 5107,
	[OriginalName("PlayerActionType_PlayerActionHeliobusActionDaySettle")]
	PlayerActionHeliobusActionDaySettle = 5108,
	[OriginalName("PlayerActionType_PlayerActionHeliobusSkillUnlock")]
	PlayerActionHeliobusSkillUnlock = 5109,
	[OriginalName("PlayerActionType_PlayerActionHeliobusStageBegin")]
	PlayerActionHeliobusStageBegin = 5110,
	[OriginalName("PlayerActionType_PlayerActionHeliobusStageEnd")]
	PlayerActionHeliobusStageEnd = 5111,
	[OriginalName("PlayerActionType_PlayerActionHeliobusSnsRead")]
	PlayerActionHeliobusSnsRead = 5112,
	[OriginalName("PlayerActionType_PlayerActionHeliobusSnsPostUnlock")]
	PlayerActionHeliobusSnsPostUnlock = 5113,
	[OriginalName("PlayerActionType_PlayerActionHeliobusSnsCommentUnlock")]
	PlayerActionHeliobusSnsCommentUnlock = 5114,
	[OriginalName("PlayerActionType_PlayerActionHeliobusSnsComment")]
	PlayerActionHeliobusSnsComment = 5115,
	[OriginalName("PlayerActionType_PlayerActionHeliobusSnsPost")]
	PlayerActionHeliobusSnsPost = 5116,
	[OriginalName("PlayerActionType_PlayerActionHeliobusSnsLike")]
	PlayerActionHeliobusSnsLike = 5117,
	[OriginalName("PlayerActionType_PlayerActionHeliobusPhaseUpgrade")]
	PlayerActionHeliobusPhaseUpgrade = 5118,
	[OriginalName("PlayerActionType_PlayerActionPsPointCard30Reward")]
	PlayerActionPsPointCard30Reward = 5201,
	[OriginalName("PlayerActionType_PlayerActionPsPointCard50Reward")]
	PlayerActionPsPointCard50Reward = 5202,
	[OriginalName("PlayerActionType_PlayerActionPsPointCard100Reward")]
	PlayerActionPsPointCard100Reward = 5203,
	[OriginalName("PlayerActionType_PlayerActionPsnPlusGiftReward")]
	PlayerActionPsnPlusGiftReward = 5204,
	[OriginalName("PlayerActionType_PlayerActionAppleGiftCardReward")]
	PlayerActionAppleGiftCardReward = 5205,
	[OriginalName("PlayerActionType_PlayerActionHeartDialSubmitItem")]
	PlayerActionHeartDialSubmitItem = 5301,
	[OriginalName("PlayerActionType_PlayerActionHeartDialDialoguePerform")]
	PlayerActionHeartDialDialoguePerform = 5302,
	[OriginalName("PlayerActionType_PlayerActionHeartDialTraceConsume")]
	PlayerActionHeartDialTraceConsume = 5303,
	[OriginalName("PlayerActionType_PlayerActionHeartDialChangeEmotion")]
	PlayerActionHeartDialChangeEmotion = 5304,
	[OriginalName("PlayerActionType_PlayerActionTravelBrochureAddDefaultPaster")]
	PlayerActionTravelBrochureAddDefaultPaster = 5401,
	[OriginalName("PlayerActionType_PlayerActionSpaceZooBorn")]
	PlayerActionSpaceZooBorn = 5501,
	[OriginalName("PlayerActionType_PlayerActionSpaceZooMutate")]
	PlayerActionSpaceZooMutate = 5502,
	[OriginalName("PlayerActionType_PlayerActionSpaceZooDelete")]
	PlayerActionSpaceZooDelete = 5503,
	[OriginalName("PlayerActionType_PlayerActionSpaceZooExchangeItem")]
	PlayerActionSpaceZooExchangeItem = 5504,
	[OriginalName("PlayerActionType_PlayerActionSpaceZooExpPoint")]
	PlayerActionSpaceZooExpPoint = 5505,
	[OriginalName("PlayerActionType_PlayerActionSpaceZooTakeReward")]
	PlayerActionSpaceZooTakeReward = 5506,
	[OriginalName("PlayerActionType_PlayerActionSpaceZooCollection")]
	PlayerActionSpaceZooCollection = 5507,
	[OriginalName("PlayerActionType_PlayerActionSpaceZooShow")]
	PlayerActionSpaceZooShow = 5508,
	[OriginalName("PlayerActionType_PlayerActionSpaceZooSpecialData")]
	PlayerActionSpaceZooSpecialData = 5509,
	[OriginalName("PlayerActionType_PlayerActionStrongChallengeBattleBegin")]
	PlayerActionStrongChallengeBattleBegin = 5701,
	[OriginalName("PlayerActionType_PlayerActionStrongChallengeBattleEnd")]
	PlayerActionStrongChallengeBattleEnd = 5702,
	[OriginalName("PlayerActionType_PlayerActionRollShopDoGacha")]
	PlayerActionRollShopDoGacha = 5751,
	[OriginalName("PlayerActionType_PlayerActionRollShopTakeReward")]
	PlayerActionRollShopTakeReward = 5752,
	[OriginalName("PlayerActionType_PlayerActionOfferingSubmitItem")]
	PlayerActionOfferingSubmitItem = 5801,
	[OriginalName("PlayerActionType_PlayerActionOfferingTakeReward")]
	PlayerActionOfferingTakeReward = 5802,
	[OriginalName("PlayerActionType_PlayerActionTravelBrochurePageUnlock")]
	PlayerActionTravelBrochurePageUnlock = 5851,
	[OriginalName("PlayerActionType_PlayerActionTravelBrochurePageInteractAward")]
	PlayerActionTravelBrochurePageInteractAward = 5852,
	[OriginalName("PlayerActionType_PlayerActionTravelBrochureStickerUnlock")]
	PlayerActionTravelBrochureStickerUnlock = 5853,
	[OriginalName("PlayerActionType_PlayerActionTravelBrochureStickerApply")]
	PlayerActionTravelBrochureStickerApply = 5854,
	[OriginalName("PlayerActionType_PlayerActionTravelBrochureStickerRemove")]
	PlayerActionTravelBrochureStickerRemove = 5855,
	[OriginalName("PlayerActionType_PlayerActionTravelBrochurePageReset")]
	PlayerActionTravelBrochurePageReset = 5856,
	[OriginalName("PlayerActionType_PlayerActionTrackMainMissionId")]
	PlayerActionTrackMainMissionId = 5901,
	[OriginalName("PlayerActionType_PlayerActionWolfBroBegin")]
	PlayerActionWolfBroBegin = 5911,
	[OriginalName("PlayerActionType_PlayerActionWolfBroGroupStateChange")]
	PlayerActionWolfBroGroupStateChange = 5912,
	[OriginalName("PlayerActionType_PlayerActionWolfBroEnd")]
	PlayerActionWolfBroEnd = 5913,
	[OriginalName("PlayerActionType_PlayerActionWolfBroBulletZero")]
	PlayerActionWolfBroBulletZero = 5914,
	[OriginalName("PlayerActionType_PlayerActionWolfBroActivateBullet")]
	PlayerActionWolfBroActivateBullet = 5915,
	[OriginalName("PlayerActionType_PlayerActionWolfBroBulletNumChange")]
	PlayerActionWolfBroBulletNumChange = 5916,
	[OriginalName("PlayerActionType_PlayerActionWolfBroUseBulletNull")]
	PlayerActionWolfBroUseBulletNull = 5917,
	[OriginalName("PlayerActionType_PlayerActionWolfBroUseBulletHitMonster")]
	PlayerActionWolfBroUseBulletHitMonster = 5918,
	[OriginalName("PlayerActionType_PlayerActionWolfBroPickUpBullet")]
	PlayerActionWolfBroPickUpBullet = 5919,
	[OriginalName("PlayerActionType_PlayerActionWolfBroRestoreArchive")]
	PlayerActionWolfBroRestoreArchive = 5920,
	[OriginalName("PlayerActionType_PlayerActionTelevisionActivityBattleBegin")]
	PlayerActionTelevisionActivityBattleBegin = 5921,
	[OriginalName("PlayerActionType_PlayerActionTelevisionActivityBattleEnd")]
	PlayerActionTelevisionActivityBattleEnd = 5922,
	[OriginalName("PlayerActionType_PlayerActionFeverTimeActivityBattleBegin")]
	PlayerActionFeverTimeActivityBattleBegin = 5923,
	[OriginalName("PlayerActionType_PlayerActionFeverTimeActivityBattleEnd")]
	PlayerActionFeverTimeActivityBattleEnd = 5924,
	[OriginalName("PlayerActionType_PlayerActionGunPlayEnd")]
	PlayerActionGunPlayEnd = 5925,
	[OriginalName("PlayerActionType_PlayerActionActivityStarFightBegin")]
	PlayerActionActivityStarFightBegin = 5926,
	[OriginalName("PlayerActionType_PlayerActionActivityStarFightEnd")]
	PlayerActionActivityStarFightEnd = 5927,
	[OriginalName("PlayerActionType_PlayerActionMapRotationEnterRegion")]
	PlayerActionMapRotationEnterRegion = 5931,
	[OriginalName("PlayerActionType_PlayerActionMapRotationLeaveRegion")]
	PlayerActionMapRotationLeaveRegion = 5932,
	[OriginalName("PlayerActionType_PlayerActionMapRotationInteractCharger")]
	PlayerActionMapRotationInteractCharger = 5933,
	[OriginalName("PlayerActionType_PlayerActionMapRotationDeployRotater")]
	PlayerActionMapRotationDeployRotater = 5934,
	[OriginalName("PlayerActionType_PlayerActionMapRotationRotateMap")]
	PlayerActionMapRotationRotateMap = 5935,
	[OriginalName("PlayerActionType_PlayerActionMapRotationAddEnergy")]
	PlayerActionMapRotationAddEnergy = 5936,
	[OriginalName("PlayerActionType_PlayerActionMapRotationSetMaxEnergy")]
	PlayerActionMapRotationSetMaxEnergy = 5937,
	[OriginalName("PlayerActionType_PlayerActionMapRotationRemoveRotater")]
	PlayerActionMapRotationRemoveRotater = 5938,
	[OriginalName("PlayerActionType_PlayerActionMapRotationAutoDeployRotater")]
	PlayerActionMapRotationAutoDeployRotater = 5939,
	[OriginalName("PlayerActionType_PlayerActionMapRotationAutoRemoveRotater")]
	PlayerActionMapRotationAutoRemoveRotater = 5940,
	[OriginalName("PlayerActionType_PlayerActionDrinkMakerAddTips")]
	PlayerActionDrinkMakerAddTips = 5951,
	[OriginalName("PlayerActionType_PlayerActionDrinkMakerFinishChallenge")]
	PlayerActionDrinkMakerFinishChallenge = 5952,
	[OriginalName("PlayerActionType_PlayerActionDrinkMakerGuestMaxFaithReward")]
	PlayerActionDrinkMakerGuestMaxFaithReward = 5953,
	[OriginalName("PlayerActionType_PlayerActionDrinkMakerMakeDrink")]
	PlayerActionDrinkMakerMakeDrink = 5954,
	[OriginalName("PlayerActionType_PlayerActionDrinkMakerSaveCustomDrink")]
	PlayerActionDrinkMakerSaveCustomDrink = 5955,
	[OriginalName("PlayerActionType_PlayerActionDrinkMakerEndSequence")]
	PlayerActionDrinkMakerEndSequence = 5956,
	[OriginalName("PlayerActionType_PlayerActionDrinkMakerCheersMakeDrink")]
	PlayerActionDrinkMakerCheersMakeDrink = 5957,
	[OriginalName("PlayerActionType_PlayerActionDrinkMakerCheersNpcDrink")]
	PlayerActionDrinkMakerCheersNpcDrink = 5958,
	[OriginalName("PlayerActionType_PlayerActionChangeStoryLine")]
	PlayerActionChangeStoryLine = 6001,
	[OriginalName("PlayerActionType_PlayerActionContentPackageStatusChange")]
	PlayerActionContentPackageStatusChange = 6011,
	[OriginalName("PlayerActionType_PlayerActionContentPackageTrackChange")]
	PlayerActionContentPackageTrackChange = 6012,
	[OriginalName("PlayerActionType_PlayerActionContentPackageAcceptMainMission")]
	PlayerActionContentPackageAcceptMainMission = 6013,
	[OriginalName("PlayerActionType_PlayerActionWorldDirectUnlock")]
	PlayerActionWorldDirectUnlock = 6041,
	[OriginalName("PlayerActionType_PlayerActionMonopolyTurnFinish")]
	PlayerActionMonopolyTurnFinish = 6051,
	[OriginalName("PlayerActionType_PlayerActionMonopolyAssetTurntax")]
	PlayerActionMonopolyAssetTurntax = 6052,
	[OriginalName("PlayerActionType_PlayerActionMonopolyAssetBonus")]
	PlayerActionMonopolyAssetBonus = 6053,
	[OriginalName("PlayerActionType_PlayerActionMonopolyEventEffect")]
	PlayerActionMonopolyEventEffect = 6054,
	[OriginalName("PlayerActionType_PlayerActionMonopolyMiniGameSettle")]
	PlayerActionMonopolyMiniGameSettle = 6055,
	[OriginalName("PlayerActionType_PlayerActionMonopolyGameRaiseRatio")]
	PlayerActionMonopolyGameRaiseRatio = 6056,
	[OriginalName("PlayerActionType_PlayerActionMonopolyMoveRollDice")]
	PlayerActionMonopolyMoveRollDice = 6057,
	[OriginalName("PlayerActionType_PlayerActionMonopolyMove")]
	PlayerActionMonopolyMove = 6059,
	[OriginalName("PlayerActionType_PlayerActionMonopolyBuyGoods")]
	PlayerActionMonopolyBuyGoods = 6060,
	[OriginalName("PlayerActionType_PlayerActionMonopolyUpgradeAsset")]
	PlayerActionMonopolyUpgradeAsset = 6061,
	[OriginalName("PlayerActionType_PlayerActionMonopolyEventRerollRandom")]
	PlayerActionMonopolyEventRerollRandom = 6062,
	[OriginalName("PlayerActionType_PlayerActionMonopolyDailyRefresh")]
	PlayerActionMonopolyDailyRefresh = 6063,
	[OriginalName("PlayerActionType_PlayerActionMonopolyGameGuessBuyInformation")]
	PlayerActionMonopolyGameGuessBuyInformation = 6064,
	[OriginalName("PlayerActionType_PlayerActionMonopolyDailyFirstEnterActivity")]
	PlayerActionMonopolyDailyFirstEnterActivity = 6065,
	[OriginalName("PlayerActionType_PlayerActionMonopolySocialEvent")]
	PlayerActionMonopolySocialEvent = 6066,
	[OriginalName("PlayerActionType_PlayerActionMonopolyRaffleTicketReward")]
	PlayerActionMonopolyRaffleTicketReward = 6067,
	[OriginalName("PlayerActionType_PlayerActionMonopolyLike")]
	PlayerActionMonopolyLike = 6068,
	[OriginalName("PlayerActionType_PlayerActionMonopolyPhaseReward")]
	PlayerActionMonopolyPhaseReward = 6069,
	[OriginalName("PlayerActionType_PlayerActionMonopolyMbtiReportReward")]
	PlayerActionMonopolyMbtiReportReward = 6070,
	[OriginalName("PlayerActionType_PlayerActionMonopolyDailySettle")]
	PlayerActionMonopolyDailySettle = 6071,
	[OriginalName("PlayerActionType_PlayerActionMonopolyStart")]
	PlayerActionMonopolyStart = 6072,
	[OriginalName("PlayerActionType_PlayerActionMonopolyGetBuff")]
	PlayerActionMonopolyGetBuff = 6073,
	[OriginalName("PlayerActionType_PlayerActionMonopolyAssetFundsChange")]
	PlayerActionMonopolyAssetFundsChange = 6074,
	[OriginalName("PlayerActionType_PlayerActionMonopolyAssetUpgrade")]
	PlayerActionMonopolyAssetUpgrade = 6075,
	[OriginalName("PlayerActionType_PlayerActionMonopolyDirectCoinGameSettle")]
	PlayerActionMonopolyDirectCoinGameSettle = 6076,
	[OriginalName("PlayerActionType_PlayerActionMonopolyExtractRaffleTicket")]
	PlayerActionMonopolyExtractRaffleTicket = 6077,
	[OriginalName("PlayerActionType_PlayerActionMonopolyMbtiProgressChange")]
	PlayerActionMonopolyMbtiProgressChange = 6078,
	[OriginalName("PlayerActionType_PlayerActionMonopolyQuizGameSettle")]
	PlayerActionMonopolyQuizGameSettle = 6079,
	[OriginalName("PlayerActionType_PlayerActionMonopolyEventSettle")]
	PlayerActionMonopolyEventSettle = 6080,
	[OriginalName("PlayerActionType_PlayerActionMonopolyItemChange")]
	PlayerActionMonopolyItemChange = 6081,
	[OriginalName("PlayerActionType_PlayerActionMonopolyCellTrigger")]
	PlayerActionMonopolyCellTrigger = 6082,
	[OriginalName("PlayerActionType_PlayerActionMonopolyEventTrigger")]
	PlayerActionMonopolyEventTrigger = 6083,
	[OriginalName("PlayerActionType_PlayerActionMonopolyClickEffect")]
	PlayerActionMonopolyClickEffect = 6084,
	[OriginalName("PlayerActionType_PlayerActionEvolveBuildLevelFinish")]
	PlayerActionEvolveBuildLevelFinish = 6101,
	[OriginalName("PlayerActionType_PlayerActionEvolveBuildShopAbilityUp")]
	PlayerActionEvolveBuildShopAbilityUp = 6102,
	[OriginalName("PlayerActionType_PlayerActionEvolveBuildShopAbilityDown")]
	PlayerActionEvolveBuildShopAbilityDown = 6103,
	[OriginalName("PlayerActionType_PlayerActionEvolveBuildTakeExpReward")]
	PlayerActionEvolveBuildTakeExpReward = 6104,
	[OriginalName("PlayerActionType_PlayerActionEvolveBuildBattleEndAddCoin")]
	PlayerActionEvolveBuildBattleEndAddCoin = 6105,
	[OriginalName("PlayerActionType_PlayerActionEvolveBuildShopAbilityReset")]
	PlayerActionEvolveBuildShopAbilityReset = 6106,
	[OriginalName("PlayerActionType_PlayerActionEvolveBuildLevelStart")]
	PlayerActionEvolveBuildLevelStart = 6107,
	[OriginalName("PlayerActionType_PlayerActionEvolveBuildLevelEnd")]
	PlayerActionEvolveBuildLevelEnd = 6108,
	[OriginalName("PlayerActionType_PlayerActionEvolveBuildStageStart")]
	PlayerActionEvolveBuildStageStart = 6109,
	[OriginalName("PlayerActionType_PlayerActionEvolveBuildStageEnd")]
	PlayerActionEvolveBuildStageEnd = 6110,
	[OriginalName("PlayerActionType_PlayerActionEvolveBuildLevelLeave")]
	PlayerActionEvolveBuildLevelLeave = 6111,
	[OriginalName("PlayerActionType_PlayerActionClockParkUnlockScript")]
	PlayerActionClockParkUnlockScript = 6151,
	[OriginalName("PlayerActionType_PlayerActionClockParkUnlockTalent")]
	PlayerActionClockParkUnlockTalent = 6152,
	[OriginalName("PlayerActionType_PlayerActionClockParkFinishScript")]
	PlayerActionClockParkFinishScript = 6153,
	[OriginalName("PlayerActionType_PlayerActionClockParkRoundUpdate")]
	PlayerActionClockParkRoundUpdate = 6154,
	[OriginalName("PlayerActionType_PlayerActionClockParkScriptBegin")]
	PlayerActionClockParkScriptBegin = 6155,
	[OriginalName("PlayerActionType_PlayerActionRogueTournStartLevel")]
	PlayerActionRogueTournStartLevel = 6200,
	[OriginalName("PlayerActionType_PlayerActionRogueTournFinishLevel")]
	PlayerActionRogueTournFinishLevel = 6201,
	[OriginalName("PlayerActionType_PlayerActionRogueTournExpReward")]
	PlayerActionRogueTournExpReward = 6202,
	[OriginalName("PlayerActionType_PlayerActionRogueTournFinishWeekChallenge")]
	PlayerActionRogueTournFinishWeekChallenge = 6203,
	[OriginalName("PlayerActionType_PlayerActionRogueTournPermanentTalentEffect")]
	PlayerActionRogueTournPermanentTalentEffect = 6204,
	[OriginalName("PlayerActionType_PlayerActionRogueTournFinishFormulaStory")]
	PlayerActionRogueTournFinishFormulaStory = 6205,
	[OriginalName("PlayerActionType_PlayerActionRogueTournRevive")]
	PlayerActionRogueTournRevive = 6206,
	[OriginalName("PlayerActionType_PlayerActionRogueTournStageBegin")]
	PlayerActionRogueTournStageBegin = 6207,
	[OriginalName("PlayerActionType_PlayerActionRogueTournStageEnd")]
	PlayerActionRogueTournStageEnd = 6208,
	[OriginalName("PlayerActionType_PlayerActionRogueTournPermanentEnableTalent")]
	PlayerActionRogueTournPermanentEnableTalent = 6209,
	[OriginalName("PlayerActionType_PlayerActionRogueTournPermanentResetTalent")]
	PlayerActionRogueTournPermanentResetTalent = 6210,
	[OriginalName("PlayerActionType_PlayerActionRogueTournCocoonStageBegin")]
	PlayerActionRogueTournCocoonStageBegin = 6211,
	[OriginalName("PlayerActionType_PlayerActionRogueTournCocoonStageEnd")]
	PlayerActionRogueTournCocoonStageEnd = 6212,
	[OriginalName("PlayerActionType_PlayerActionRogueTournExpUpdate")]
	PlayerActionRogueTournExpUpdate = 6213,
	[OriginalName("PlayerActionType_PlayerActionRogueTournEnterRoom")]
	PlayerActionRogueTournEnterRoom = 6214,
	[OriginalName("PlayerActionType_PlayerActionRogueTournLeaveRoom")]
	PlayerActionRogueTournLeaveRoom = 6215,
	[OriginalName("PlayerActionType_PlayerActionRogueTournArchiveSave")]
	PlayerActionRogueTournArchiveSave = 6216,
	[OriginalName("PlayerActionType_PlayerActionRogueTournSelectBonus")]
	PlayerActionRogueTournSelectBonus = 6217,
	[OriginalName("PlayerActionType_PlayerActionRogueTournDialogueFinish")]
	PlayerActionRogueTournDialogueFinish = 6218,
	[OriginalName("PlayerActionType_PlayerActionRogueTournDoGamble")]
	PlayerActionRogueTournDoGamble = 6219,
	[OriginalName("PlayerActionType_PlayerActionRogueTournRoomContentGenerate")]
	PlayerActionRogueTournRoomContentGenerate = 6220,
	[OriginalName("PlayerActionType_PlayerActionRogueTournAddMiracle")]
	PlayerActionRogueTournAddMiracle = 6221,
	[OriginalName("PlayerActionType_PlayerActionRogueTournRemoveMiracle")]
	PlayerActionRogueTournRemoveMiracle = 6222,
	[OriginalName("PlayerActionType_PlayerActionRogueTournSelectMiracle")]
	PlayerActionRogueTournSelectMiracle = 6223,
	[OriginalName("PlayerActionType_PlayerActionRogueTournDropMiracle")]
	PlayerActionRogueTournDropMiracle = 6224,
	[OriginalName("PlayerActionType_PlayerActionRogueTournAddBuff")]
	PlayerActionRogueTournAddBuff = 6225,
	[OriginalName("PlayerActionType_PlayerActionRogueTournSelectBuff")]
	PlayerActionRogueTournSelectBuff = 6226,
	[OriginalName("PlayerActionType_PlayerActionRogueTournBuffLevelUp")]
	PlayerActionRogueTournBuffLevelUp = 6227,
	[OriginalName("PlayerActionType_PlayerActionRogueTournRemoveBuff")]
	PlayerActionRogueTournRemoveBuff = 6228,
	[OriginalName("PlayerActionType_PlayerActionRogueTournAddFormula")]
	PlayerActionRogueTournAddFormula = 6229,
	[OriginalName("PlayerActionType_PlayerActionRogueTournRemoveFormula")]
	PlayerActionRogueTournRemoveFormula = 6230,
	[OriginalName("PlayerActionType_PlayerActionRogueTournSelectFormula")]
	PlayerActionRogueTournSelectFormula = 6231,
	[OriginalName("PlayerActionType_PlayerActionRogueTournActivateFormula")]
	PlayerActionRogueTournActivateFormula = 6232,
	[OriginalName("PlayerActionType_PlayerActionRogueTournAdventureRoomFinish")]
	PlayerActionRogueTournAdventureRoomFinish = 6233,
	[OriginalName("PlayerActionType_PlayerActionRogueTournAlterLineup")]
	PlayerActionRogueTournAlterLineup = 6234,
	[OriginalName("PlayerActionType_PlayerActionRogueTournSeasonEnableTalent")]
	PlayerActionRogueTournSeasonEnableTalent = 6235,
	[OriginalName("PlayerActionType_PlayerActionRogueTournTitanStartLevel")]
	PlayerActionRogueTournTitanStartLevel = 6236,
	[OriginalName("PlayerActionType_PlayerActionRogueTournTitanFinishLevel")]
	PlayerActionRogueTournTitanFinishLevel = 6237,
	[OriginalName("PlayerActionType_PlayerActionRogueTournTitanEnterRoom")]
	PlayerActionRogueTournTitanEnterRoom = 6238,
	[OriginalName("PlayerActionType_PlayerActionRogueTournTitanLeaveRoom")]
	PlayerActionRogueTournTitanLeaveRoom = 6239,
	[OriginalName("PlayerActionType_PlayerActionRogueTournTitanStageBegin")]
	PlayerActionRogueTournTitanStageBegin = 6240,
	[OriginalName("PlayerActionType_PlayerActionRogueTournTitanStageEnd")]
	PlayerActionRogueTournTitanStageEnd = 6241,
	[OriginalName("PlayerActionType_PlayerActionRogueTournTitanArchiveSave")]
	PlayerActionRogueTournTitanArchiveSave = 6243,
	[OriginalName("PlayerActionType_PlayerActionRogueTournTitanAddTitanBless")]
	PlayerActionRogueTournTitanAddTitanBless = 6244,
	[OriginalName("PlayerActionType_PlayerActionRogueTournTitanSelectTitanBless")]
	PlayerActionRogueTournTitanSelectTitanBless = 6245,
	[OriginalName("PlayerActionType_PlayerActionRogueTournDivisionChange")]
	PlayerActionRogueTournDivisionChange = 6246,
	[OriginalName("PlayerActionType_PlayerActionRogueTournSelectReRollMiracle")]
	PlayerActionRogueTournSelectReRollMiracle = 6247,
	[OriginalName("PlayerActionType_PlayerActionRogueTournTriggerBattleByShop")]
	PlayerActionRogueTournTriggerBattleByShop = 6248,
	[OriginalName("PlayerActionType_PlayerActionRogueTournUseSuperRewardKey")]
	PlayerActionRogueTournUseSuperRewardKey = 6249,
	[OriginalName("PlayerActionType_PlayerActionRogueTournPersonaStyleExpChange")]
	PlayerActionRogueTournPersonaStyleExpChange = 6250,
	[OriginalName("PlayerActionType_PlayerActionRogueTournPersonaStyleSelect")]
	PlayerActionRogueTournPersonaStyleSelect = 6251,
	[OriginalName("PlayerActionType_PlayerActionRogueTournPersonaStartLevel")]
	PlayerActionRogueTournPersonaStartLevel = 6252,
	[OriginalName("PlayerActionType_PlayerActionRogueTournPersonaFinishLevel")]
	PlayerActionRogueTournPersonaFinishLevel = 6253,
	[OriginalName("PlayerActionType_PlayerActionRogueTournPersonaEnterRoom")]
	PlayerActionRogueTournPersonaEnterRoom = 6254,
	[OriginalName("PlayerActionType_PlayerActionRogueTournPersonaLeaveRoom")]
	PlayerActionRogueTournPersonaLeaveRoom = 6255,
	[OriginalName("PlayerActionType_PlayerActionRogueTournPersonaStageBegin")]
	PlayerActionRogueTournPersonaStageBegin = 6256,
	[OriginalName("PlayerActionType_PlayerActionRogueTournPersonaStageEnd")]
	PlayerActionRogueTournPersonaStageEnd = 6257,
	[OriginalName("PlayerActionType_PlayerActionRogueTournPersonaArchiveSave")]
	PlayerActionRogueTournPersonaArchiveSave = 6258,
	[OriginalName("PlayerActionType_PlayerActionRogueTournHexEquipmentChange")]
	PlayerActionRogueTournHexEquipmentChange = 6259,
	[OriginalName("PlayerActionType_PlayerActionRogueTournPersonaRoomCardChange")]
	PlayerActionRogueTournPersonaRoomCardChange = 6260,
	[OriginalName("PlayerActionType_PlayerActionRogueTournPersonaRoomCardLevelChange")]
	PlayerActionRogueTournPersonaRoomCardLevelChange = 6261,
	[OriginalName("PlayerActionType_PlayerActionRogueTournPersonaRoomCardAttributeChange")]
	PlayerActionRogueTournPersonaRoomCardAttributeChange = 6262,
	[OriginalName("PlayerActionType_PlayerActionRogueTournPersonaRoomCardSelect")]
	PlayerActionRogueTournPersonaRoomCardSelect = 6263,
	[OriginalName("PlayerActionType_PlayerActionRogueTournPersonaRoomCardWash")]
	PlayerActionRogueTournPersonaRoomCardWash = 6264,
	[OriginalName("PlayerActionType_PlayerActionRogueTournPersonaStyleGiftSelect")]
	PlayerActionRogueTournPersonaStyleGiftSelect = 6265,
	[OriginalName("PlayerActionType_PlayerActionRogueTournPersonaStyleGiftSelectRefresh")]
	PlayerActionRogueTournPersonaStyleGiftSelectRefresh = 6266,
	[OriginalName("PlayerActionType_PlayerActionRogueTournPersonaRoomCardReroll")]
	PlayerActionRogueTournPersonaRoomCardReroll = 6267,
	[OriginalName("PlayerActionType_PlayerActionRogueTournMiracleStatusChange")]
	PlayerActionRogueTournMiracleStatusChange = 6268,
	[OriginalName("PlayerActionType_PlayerActionRogueWorkbenchReforgeFormula")]
	PlayerActionRogueWorkbenchReforgeFormula = 6281,
	[OriginalName("PlayerActionType_PlayerActionRogueWorkbenchReforgeMiracle")]
	PlayerActionRogueWorkbenchReforgeMiracle = 6282,
	[OriginalName("PlayerActionType_PlayerActionRogueWorkbenchComposeMiracle")]
	PlayerActionRogueWorkbenchComposeMiracle = 6283,
	[OriginalName("PlayerActionType_PlayerActionRogueWorkbenchReforgeBuff")]
	PlayerActionRogueWorkbenchReforgeBuff = 6284,
	[OriginalName("PlayerActionType_PlayerActionRogueWorkbenchEnhanceBuff")]
	PlayerActionRogueWorkbenchEnhanceBuff = 6285,
	[OriginalName("PlayerActionType_PlayerActionMatchThreePveSettle")]
	PlayerActionMatchThreePveSettle = 6301,
	[OriginalName("PlayerActionType_PlayerActionMatchThreeSettle")]
	PlayerActionMatchThreeSettle = 6302,
	[OriginalName("PlayerActionType_PlayerActionFightMatch3GameStart")]
	PlayerActionFightMatch3GameStart = 6303,
	[OriginalName("PlayerActionType_PlayerActionFightMatch3GameEnd")]
	PlayerActionFightMatch3GameEnd = 6304,
	[OriginalName("PlayerActionType_PlayerActionFightMatch3TurnEnd")]
	PlayerActionFightMatch3TurnEnd = 6305,
	[OriginalName("PlayerActionType_PlayerActionMatchThreeBirdPos")]
	PlayerActionMatchThreeBirdPos = 6306,
	[OriginalName("PlayerActionType_PlayerActionMultiplePlayInvite")]
	PlayerActionMultiplePlayInvite = 6307,
	[OriginalName("PlayerActionType_PlayerActionMultiplePlayInviteRespond")]
	PlayerActionMultiplePlayInviteRespond = 6308,
	[OriginalName("PlayerActionType_PlayerActionMultiplePlayLobbyEnter")]
	PlayerActionMultiplePlayLobbyEnter = 6309,
	[OriginalName("PlayerActionType_PlayerActionMultiplePlayLobbyQuit")]
	PlayerActionMultiplePlayLobbyQuit = 6310,
	[OriginalName("PlayerActionType_PlayerActionMultiplePlayLobbyKick")]
	PlayerActionMultiplePlayLobbyKick = 6311,
	[OriginalName("PlayerActionType_PlayerActionMultiplePlayLobbyMatch")]
	PlayerActionMultiplePlayLobbyMatch = 6312,
	[OriginalName("PlayerActionType_PlayerActionMarbleSettle")]
	PlayerActionMarbleSettle = 6313,
	[OriginalName("PlayerActionType_PlayerActionMatchThreeSoloSettle")]
	PlayerActionMatchThreeSoloSettle = 6314,
	[OriginalName("PlayerActionType_PlayerActionMatchThreeV2BattleitemLevelup")]
	PlayerActionMatchThreeV2BattleitemLevelup = 6315,
	[OriginalName("PlayerActionType_PlayerActionMatchThreeV2PveSettle")]
	PlayerActionMatchThreeV2PveSettle = 6316,
	[OriginalName("PlayerActionType_PlayerActionMatchThreeV2PvpSettle")]
	PlayerActionMatchThreeV2PvpSettle = 6317,
	[OriginalName("PlayerActionType_PlayerActionMatch3SoloGameStart")]
	PlayerActionMatch3SoloGameStart = 6318,
	[OriginalName("PlayerActionType_PlayerActionMatch3SoloGameEnd")]
	PlayerActionMatch3SoloGameEnd = 6319,
	[OriginalName("PlayerActionType_PlayerActionMatch3SoloRoundEnd")]
	PlayerActionMatch3SoloRoundEnd = 6320,
	[OriginalName("PlayerActionType_PlayerActionMatch3RoyaleSettle")]
	PlayerActionMatch3RoyaleSettle = 6321,
	[OriginalName("PlayerActionType_PlayerActionMatch3RoyaleGameStart")]
	PlayerActionMatch3RoyaleGameStart = 6322,
	[OriginalName("PlayerActionType_PlayerActionMatch3RoyaleGameEnd")]
	PlayerActionMatch3RoyaleGameEnd = 6323,
	[OriginalName("PlayerActionType_PlayerActionMatch3RoyaleRoundEnd")]
	PlayerActionMatch3RoyaleRoundEnd = 6324,
	[OriginalName("PlayerActionType_PlayerActionDiceCombatSettle")]
	PlayerActionDiceCombatSettle = 6325,
	[OriginalName("PlayerActionType_PlayerActionDiceCombatV2Settle")]
	PlayerActionDiceCombatV2Settle = 6326,
	[OriginalName("PlayerActionType_PlayerActionSwordTrainingLearnSkill")]
	PlayerActionSwordTrainingLearnSkill = 6351,
	[OriginalName("PlayerActionType_PlayerActionSwordTrainingNormalAction")]
	PlayerActionSwordTrainingNormalAction = 6352,
	[OriginalName("PlayerActionType_PlayerActionSwordTrainingStoryEffect")]
	PlayerActionSwordTrainingStoryEffect = 6353,
	[OriginalName("PlayerActionType_PlayerActionSwordTrainingEndingHint")]
	PlayerActionSwordTrainingEndingHint = 6354,
	[OriginalName("PlayerActionType_PlayerActionSwordTrainingActionHint")]
	PlayerActionSwordTrainingActionHint = 6355,
	[OriginalName("PlayerActionType_PlayerActionSwordTrainingRestoreGameByExam")]
	PlayerActionSwordTrainingRestoreGameByExam = 6356,
	[OriginalName("PlayerActionType_PlayerActionSwordTrainingStoryLineFirstClear")]
	PlayerActionSwordTrainingStoryLineFirstClear = 6357,
	[OriginalName("PlayerActionType_PlayerActionSwordTrainingTakeEndingReward")]
	PlayerActionSwordTrainingTakeEndingReward = 6358,
	[OriginalName("PlayerActionType_PlayerActionSwordTrainingStoryLineBegin")]
	PlayerActionSwordTrainingStoryLineBegin = 6359,
	[OriginalName("PlayerActionType_PlayerActionSwordTrainingEnterTurn")]
	PlayerActionSwordTrainingEnterTurn = 6360,
	[OriginalName("PlayerActionType_PlayerActionSwordTrainingPlanAction")]
	PlayerActionSwordTrainingPlanAction = 6361,
	[OriginalName("PlayerActionType_PlayerActionSwordTrainingActionPhaseEnd")]
	PlayerActionSwordTrainingActionPhaseEnd = 6362,
	[OriginalName("PlayerActionType_PlayerActionSwordTrainingStory")]
	PlayerActionSwordTrainingStory = 6363,
	[OriginalName("PlayerActionType_PlayerActionSwordTrainingStatusChange")]
	PlayerActionSwordTrainingStatusChange = 6364,
	[OriginalName("PlayerActionType_PlayerActionSwordTrainingMoodChange")]
	PlayerActionSwordTrainingMoodChange = 6365,
	[OriginalName("PlayerActionType_PlayerActionSwordTrainingBattleBegin")]
	PlayerActionSwordTrainingBattleBegin = 6366,
	[OriginalName("PlayerActionType_PlayerActionSwordTrainingBattleEnd")]
	PlayerActionSwordTrainingBattleEnd = 6367,
	[OriginalName("PlayerActionType_PlayerActionSwordTrainingCombatRankChange")]
	PlayerActionSwordTrainingCombatRankChange = 6368,
	[OriginalName("PlayerActionType_PlayerActionSwordTrainingStoryLineEnd")]
	PlayerActionSwordTrainingStoryLineEnd = 6369,
	[OriginalName("PlayerActionType_PlayerActionSwordTrainingResumeStoryLine")]
	PlayerActionSwordTrainingResumeStoryLine = 6370,
	[OriginalName("PlayerActionType_PlayerActionSwordTrainingGameSuccess")]
	PlayerActionSwordTrainingGameSuccess = 6371,
	[OriginalName("PlayerActionType_PlayerActionSwordTrainingGameGiveUp")]
	PlayerActionSwordTrainingGameGiveUp = 6372,
	[OriginalName("PlayerActionType_PlayerActionSwordTrainingExam")]
	PlayerActionSwordTrainingExam = 6374,
	[OriginalName("PlayerActionType_PlayerActionSwordTrainingDialogue")]
	PlayerActionSwordTrainingDialogue = 6375,
	[OriginalName("PlayerActionType_PlayerActionSwordTrainingSetSkillTrace")]
	PlayerActionSwordTrainingSetSkillTrace = 6376,
	[OriginalName("PlayerActionType_PlayerActionFightFestFinishScoreRaceMission")]
	PlayerActionFightFestFinishScoreRaceMission = 6401,
	[OriginalName("PlayerActionType_PlayerActionFightFestFinishScoreRacePhase")]
	PlayerActionFightFestFinishScoreRacePhase = 6402,
	[OriginalName("PlayerActionType_PlayerActionFightFestRaceStart")]
	PlayerActionFightFestRaceStart = 6403,
	[OriginalName("PlayerActionType_PlayerActionFightFestRaceEnd")]
	PlayerActionFightFestRaceEnd = 6404,
	[OriginalName("PlayerActionType_PlayerActionFightFestChallengeStart")]
	PlayerActionFightFestChallengeStart = 6405,
	[OriginalName("PlayerActionType_PlayerActionFightFestChallengeEnd")]
	PlayerActionFightFestChallengeEnd = 6406,
	[OriginalName("PlayerActionType_PlayerActionFightFestGetCoachItem")]
	PlayerActionFightFestGetCoachItem = 6407,
	[OriginalName("PlayerActionType_PlayerActionFightFestAcceptScoreRaceMission")]
	PlayerActionFightFestAcceptScoreRaceMission = 6408,
	[OriginalName("PlayerActionType_PlayerActionPetUse")]
	PlayerActionPetUse = 6451,
	[OriginalName("PlayerActionType_PlayerActionMusicRhythmPassLevelStar")]
	PlayerActionMusicRhythmPassLevelStar = 6501,
	[OriginalName("PlayerActionType_PlayerActionMusicRhythmLevelBegin")]
	PlayerActionMusicRhythmLevelBegin = 6502,
	[OriginalName("PlayerActionType_PlayerActionMusicRhythmLevelEnd")]
	PlayerActionMusicRhythmLevelEnd = 6503,
	[OriginalName("PlayerActionType_PlayerActionTrackPhotoStageBegin")]
	PlayerActionTrackPhotoStageBegin = 6551,
	[OriginalName("PlayerActionType_PlayerActionTrackPhotoStageEnd")]
	PlayerActionTrackPhotoStageEnd = 6552,
	[OriginalName("PlayerActionType_PlayerActionSummonActivityBattleBegin")]
	PlayerActionSummonActivityBattleBegin = 6561,
	[OriginalName("PlayerActionType_PlayerActionSummonActivityBattleEnd")]
	PlayerActionSummonActivityBattleEnd = 6562,
	[OriginalName("PlayerActionType_PlayerActionRaidCollectionEnterNextRaid")]
	PlayerActionRaidCollectionEnterNextRaid = 6571,
	[OriginalName("PlayerActionType_PlayerActionDifficultyAdjustmentSet")]
	PlayerActionDifficultyAdjustmentSet = 6572,
	[OriginalName("PlayerActionType_PlayerActionDifficultyAdjustmentUnset")]
	PlayerActionDifficultyAdjustmentUnset = 6573,
	[OriginalName("PlayerActionType_PlayerActionRogueArcadeAdventureRoomStart")]
	PlayerActionRogueArcadeAdventureRoomStart = 6580,
	[OriginalName("PlayerActionType_PlayerActionRogueArcadeAdventureRoomFinish")]
	PlayerActionRogueArcadeAdventureRoomFinish = 6581,
	[OriginalName("PlayerActionType_PlayerActionRogueMagicStartLevel")]
	PlayerActionRogueMagicStartLevel = 6601,
	[OriginalName("PlayerActionType_PlayerActionRogueMagicFinishLevel")]
	PlayerActionRogueMagicFinishLevel = 6602,
	[OriginalName("PlayerActionType_PlayerActionRogueMagicRevive")]
	PlayerActionRogueMagicRevive = 6603,
	[OriginalName("PlayerActionType_PlayerActionRogueMagicEnterRoom")]
	PlayerActionRogueMagicEnterRoom = 6604,
	[OriginalName("PlayerActionType_PlayerActionRogueMagicLeaveRoom")]
	PlayerActionRogueMagicLeaveRoom = 6605,
	[OriginalName("PlayerActionType_PlayerActionRogueMagicAddMiracle")]
	PlayerActionRogueMagicAddMiracle = 6606,
	[OriginalName("PlayerActionType_PlayerActionRogueMagicRemoveMiracle")]
	PlayerActionRogueMagicRemoveMiracle = 6607,
	[OriginalName("PlayerActionType_PlayerActionRogueMagicStageBegin")]
	PlayerActionRogueMagicStageBegin = 6608,
	[OriginalName("PlayerActionType_PlayerActionRogueMagicStageEnd")]
	PlayerActionRogueMagicStageEnd = 6609,
	[OriginalName("PlayerActionType_PlayerActionRogueMagicEnableTalent")]
	PlayerActionRogueMagicEnableTalent = 6610,
	[OriginalName("PlayerActionType_PlayerActionRogueMagicFinishStory")]
	PlayerActionRogueMagicFinishStory = 6611,
	[OriginalName("PlayerActionType_PlayerActionRogueMagicAddScepter")]
	PlayerActionRogueMagicAddScepter = 6612,
	[OriginalName("PlayerActionType_PlayerActionRogueMagicSelectScepter")]
	PlayerActionRogueMagicSelectScepter = 6613,
	[OriginalName("PlayerActionType_PlayerActionRogueMagicMountUnit")]
	PlayerActionRogueMagicMountUnit = 6614,
	[OriginalName("PlayerActionType_PlayerActionRogueMagicAutoMountUnit")]
	PlayerActionRogueMagicAutoMountUnit = 6615,
	[OriginalName("PlayerActionType_PlayerActionRogueMagicAddMagicUnit")]
	PlayerActionRogueMagicAddMagicUnit = 6616,
	[OriginalName("PlayerActionType_PlayerActionRogueMagicRemoveMagicUnit")]
	PlayerActionRogueMagicRemoveMagicUnit = 6617,
	[OriginalName("PlayerActionType_PlayerActionRogueMagicWorkbenchComposeMagicUnit")]
	PlayerActionRogueMagicWorkbenchComposeMagicUnit = 6618,
	[OriginalName("PlayerActionType_PlayerActionRogueMagicWorkbenchReforgeMagicUnit")]
	PlayerActionRogueMagicWorkbenchReforgeMagicUnit = 6619,
	[OriginalName("PlayerActionType_PlayerActionRogueMagicWorkbenchLevelUpScepter")]
	PlayerActionRogueMagicWorkbenchLevelUpScepter = 6620,
	[OriginalName("PlayerActionType_PlayerActionTrainPartyGamePlayStart")]
	PlayerActionTrainPartyGamePlayStart = 6701,
	[OriginalName("PlayerActionType_PlayerActionTrainPartyPhaseBegin")]
	PlayerActionTrainPartyPhaseBegin = 6702,
	[OriginalName("PlayerActionType_PlayerActionTrainPartyPhaseEnd")]
	PlayerActionTrainPartyPhaseEnd = 6703,
	[OriginalName("PlayerActionType_PlayerActionTrainPartyRound")]
	PlayerActionTrainPartyRound = 6704,
	[OriginalName("PlayerActionType_PlayerActionTrainPartyMeetingBegin")]
	PlayerActionTrainPartyMeetingBegin = 6705,
	[OriginalName("PlayerActionType_PlayerActionTrainPartyMeetingEnd")]
	PlayerActionTrainPartyMeetingEnd = 6706,
	[OriginalName("PlayerActionType_PlayerActionTrainPartyMeetingPlayCard")]
	PlayerActionTrainPartyMeetingPlayCard = 6707,
	[OriginalName("PlayerActionType_PlayerActionTrainPartyMeetingReRoll")]
	PlayerActionTrainPartyMeetingReRoll = 6708,
	[OriginalName("PlayerActionType_PlayerActionTrainPartyBuildAreaUnlock")]
	PlayerActionTrainPartyBuildAreaUnlock = 6709,
	[OriginalName("PlayerActionType_PlayerActionTrainPartyBuildStep")]
	PlayerActionTrainPartyBuildStep = 6710,
	[OriginalName("PlayerActionType_PlayerActionTrainPartyBuildLevelAward")]
	PlayerActionTrainPartyBuildLevelAward = 6711,
	[OriginalName("PlayerActionType_PlayerActionTrainPartyBuildingDynamicBuff")]
	PlayerActionTrainPartyBuildingDynamicBuff = 6712,
	[OriginalName("PlayerActionType_PlayerActionTrainPartyBuildDiy")]
	PlayerActionTrainPartyBuildDiy = 6713,
	[OriginalName("PlayerActionType_PlayerActionSelfRoomBuildDiy")]
	PlayerActionSelfRoomBuildDiy = 6714,
	[OriginalName("PlayerActionType_PlayerActionSkipUnlockSelfRoom")]
	PlayerActionSkipUnlockSelfRoom = 6715,
	[OriginalName("PlayerActionType_PlayerActionSelfRoomBuildDiyMerge")]
	PlayerActionSelfRoomBuildDiyMerge = 6716,
	[OriginalName("PlayerActionType_PlayerActionPlayerRoomDisplayAreaChange")]
	PlayerActionPlayerRoomDisplayAreaChange = 6717,
	[OriginalName("PlayerActionType_PlayerActionSwitchHandOpPropState")]
	PlayerActionSwitchHandOpPropState = 6801,
	[OriginalName("PlayerActionType_PlayerActionEraFlipperChangeRegionState")]
	PlayerActionEraFlipperChangeRegionState = 6811,
	[OriginalName("PlayerActionType_PlayerActionEraFlipperChangePropState")]
	PlayerActionEraFlipperChangePropState = 6812,
	[OriginalName("PlayerActionType_PlayerActionActivityBenefitReward")]
	PlayerActionActivityBenefitReward = 6820,
	[OriginalName("PlayerActionType_PlayerActionActivityBenefitJoin")]
	PlayerActionActivityBenefitJoin = 6821,
	[OriginalName("PlayerActionType_PlayerActionActivityBenefitInitialReward")]
	PlayerActionActivityBenefitInitialReward = 6822,
	[OriginalName("PlayerActionType_PlayerActionActiveActivityReward")]
	PlayerActionActiveActivityReward = 6831,
	[OriginalName("PlayerActionType_PlayerActionPamSkinChangeSkin")]
	PlayerActionPamSkinChangeSkin = 6851,
	[OriginalName("PlayerActionType_PlayerActionChestFind")]
	PlayerActionChestFind = 6861,
	[OriginalName("PlayerActionType_PlayerActionReissueMarkChestItemMail")]
	PlayerActionReissueMarkChestItemMail = 6862,
	[OriginalName("PlayerActionType_PlayerActionMarblePassMatch")]
	PlayerActionMarblePassMatch = 6871,
	[OriginalName("PlayerActionType_PlayerActionMarbleBuySeal")]
	PlayerActionMarbleBuySeal = 6872,
	[OriginalName("PlayerActionType_PlayerActionMarbleFightGameBegin")]
	PlayerActionMarbleFightGameBegin = 6873,
	[OriginalName("PlayerActionType_PlayerActionMarbleFightGameEnd")]
	PlayerActionMarbleFightGameEnd = 6874,
	[OriginalName("PlayerActionType_PlayerActionMarbleFightGameRound")]
	PlayerActionMarbleFightGameRound = 6875,
	[OriginalName("PlayerActionType_PlayerActionMarbleFightGameTurn")]
	PlayerActionMarbleFightGameTurn = 6876,
	[OriginalName("PlayerActionType_PlayerActionPlanetFesLevelUp")]
	PlayerActionPlanetFesLevelUp = 6901,
	[OriginalName("PlayerActionType_PlayerActionPlanetFesActivityInit")]
	PlayerActionPlanetFesActivityInit = 6902,
	[OriginalName("PlayerActionType_PlayerActionPlanetFesAvatarLevelUp")]
	PlayerActionPlanetFesAvatarLevelUp = 6903,
	[OriginalName("PlayerActionType_PlayerActionPlanetFesTakeRegionPhaseReward")]
	PlayerActionPlanetFesTakeRegionPhaseReward = 6904,
	[OriginalName("PlayerActionType_PlayerActionPlanetFesAddItem")]
	PlayerActionPlanetFesAddItem = 6905,
	[OriginalName("PlayerActionType_PlayerActionPlanetFesQuest")]
	PlayerActionPlanetFesQuest = 6906,
	[OriginalName("PlayerActionType_PlayerActionPlanetFesBusinessDayFinish")]
	PlayerActionPlanetFesBusinessDayFinish = 6907,
	[OriginalName("PlayerActionType_PlayerActionPlanetFesAvatarStarUp")]
	PlayerActionPlanetFesAvatarStarUp = 6908,
	[OriginalName("PlayerActionType_PlayerActionPlanetFesUnlockLand")]
	PlayerActionPlanetFesUnlockLand = 6909,
	[OriginalName("PlayerActionType_PlayerActionPlanetFesBusinessEventFinish")]
	PlayerActionPlanetFesBusinessEventFinish = 6910,
	[OriginalName("PlayerActionType_PlayerActionPlanetFesActivateCard")]
	PlayerActionPlanetFesActivateCard = 6911,
	[OriginalName("PlayerActionType_PlayerActionPlanetFesSkillLevelUp")]
	PlayerActionPlanetFesSkillLevelUp = 6912,
	[OriginalName("PlayerActionType_PlayerActionPlanetFesGacha")]
	PlayerActionPlanetFesGacha = 6913,
	[OriginalName("PlayerActionType_PlayerActionPlanetFesBusinessEventHandle")]
	PlayerActionPlanetFesBusinessEventHandle = 6914,
	[OriginalName("PlayerActionType_PlayerActionPlanetFesCardApplyPermission")]
	PlayerActionPlanetFesCardApplyPermission = 6915,
	[OriginalName("PlayerActionType_PlayerActionPlanetFesCardInteract")]
	PlayerActionPlanetFesCardInteract = 6916,
	[OriginalName("PlayerActionType_PlayerActionPlanetFesToSns")]
	PlayerActionPlanetFesToSns = 6917,
	[OriginalName("PlayerActionType_PlayerActionPlanetFesSetWorkAvatar")]
	PlayerActionPlanetFesSetWorkAvatar = 6918,
	[OriginalName("PlayerActionType_PlayerActionPlanetFesSummary")]
	PlayerActionPlanetFesSummary = 6919,
	[OriginalName("PlayerActionType_PlayerActionTarotBookCharacterLevelUp")]
	PlayerActionTarotBookCharacterLevelUp = 6951,
	[OriginalName("PlayerActionType_PlayerActionTarotBookOpenPack")]
	PlayerActionTarotBookOpenPack = 6952,
	[OriginalName("PlayerActionType_PlayerActionTarotBookUnlockStory")]
	PlayerActionTarotBookUnlockStory = 6953,
	[OriginalName("PlayerActionType_PlayerActionTarotBookUnlockStorySingle")]
	PlayerActionTarotBookUnlockStorySingle = 6954,
	[OriginalName("PlayerActionType_PlayerActionTarotBookFinishStory")]
	PlayerActionTarotBookFinishStory = 6955,
	[OriginalName("PlayerActionType_PlayerActionTarotBookFinishInteraction")]
	PlayerActionTarotBookFinishInteraction = 6956,
	[OriginalName("PlayerActionType_PlayerActionTarotBookChangeEnergy")]
	PlayerActionTarotBookChangeEnergy = 6957,
	[OriginalName("PlayerActionType_PlayerActionTarotBookUnlockInteraction")]
	PlayerActionTarotBookUnlockInteraction = 6958,
	[OriginalName("PlayerActionType_PlayerActionChimeraRoundStart")]
	PlayerActionChimeraRoundStart = 6971,
	[OriginalName("PlayerActionType_PlayerActionChimeraRoundWorkStart")]
	PlayerActionChimeraRoundWorkStart = 6972,
	[OriginalName("PlayerActionType_PlayerActionChimeraRoundWorkEnd")]
	PlayerActionChimeraRoundWorkEnd = 6973,
	[OriginalName("PlayerActionType_PlayerActionChimeraEndlessStart")]
	PlayerActionChimeraEndlessStart = 6974,
	[OriginalName("PlayerActionType_PlayerActionChimeraEndlessEnd")]
	PlayerActionChimeraEndlessEnd = 6975,
	[OriginalName("PlayerActionType_PlayerActionChimeraEndlessWorkStart")]
	PlayerActionChimeraEndlessWorkStart = 6976,
	[OriginalName("PlayerActionType_PlayerActionChimeraEndlessWorkEnd")]
	PlayerActionChimeraEndlessWorkEnd = 6977,
	[OriginalName("PlayerActionType_PlayerActionChimeraRankChange")]
	PlayerActionChimeraRankChange = 6978,
	[OriginalName("PlayerActionType_PlayerActionChimeraGet")]
	PlayerActionChimeraGet = 6979,
	[OriginalName("PlayerActionType_PlayerActionStoryTokenTakeActivityReward")]
	PlayerActionStoryTokenTakeActivityReward = 6991,
	[OriginalName("PlayerActionType_PlayerActionReissueAvatarTokenItem")]
	PlayerActionReissueAvatarTokenItem = 6992,
	[OriginalName("PlayerActionType_PlayerActionAvatarDeliverRewardActivityTakeReward")]
	PlayerActionAvatarDeliverRewardActivityTakeReward = 7001,
	[OriginalName("PlayerActionType_PlayerActionElfRestaurantBuyField")]
	PlayerActionElfRestaurantBuyField = 7011,
	[OriginalName("PlayerActionType_PlayerActionElfRestaurantPlantSeed")]
	PlayerActionElfRestaurantPlantSeed = 7012,
	[OriginalName("PlayerActionType_PlayerActionElfRestaurantRecycleSeed")]
	PlayerActionElfRestaurantRecycleSeed = 7013,
	[OriginalName("PlayerActionType_PlayerActionElfRestaurantHarvestCrop")]
	PlayerActionElfRestaurantHarvestCrop = 7014,
	[OriginalName("PlayerActionType_PlayerActionElfRestaurantUpgradeEmployeeLevel")]
	PlayerActionElfRestaurantUpgradeEmployeeLevel = 7015,
	[OriginalName("PlayerActionType_PlayerActionElfRestaurantUpgradeFacilityLevel")]
	PlayerActionElfRestaurantUpgradeFacilityLevel = 7016,
	[OriginalName("PlayerActionType_PlayerActionElfRestaurantUpgradeRecipeLevel")]
	PlayerActionElfRestaurantUpgradeRecipeLevel = 7017,
	[OriginalName("PlayerActionType_PlayerActionElfRestaurantBuyShopItem")]
	PlayerActionElfRestaurantBuyShopItem = 7018,
	[OriginalName("PlayerActionType_PlayerActionElfRestaurantFinishTradeOrder")]
	PlayerActionElfRestaurantFinishTradeOrder = 7019,
	[OriginalName("PlayerActionType_PlayerActionElfRestaurantTakeVillagerReward")]
	PlayerActionElfRestaurantTakeVillagerReward = 7020,
	[OriginalName("PlayerActionType_PlayerActionElfRestaurantSettleRestaurantPlay")]
	PlayerActionElfRestaurantSettleRestaurantPlay = 7021,
	[OriginalName("PlayerActionType_PlayerActionElfRestaurantInit")]
	PlayerActionElfRestaurantInit = 7022,
	[OriginalName("PlayerActionType_PlayerActionElfRestaurantSettleProgress")]
	PlayerActionElfRestaurantSettleProgress = 7023,
	[OriginalName("PlayerActionType_PlayerActionElfRestaurantSettleDay")]
	PlayerActionElfRestaurantSettleDay = 7024,
	[OriginalName("PlayerActionType_PlayerActionElfRestaurantAddItem")]
	PlayerActionElfRestaurantAddItem = 7025,
	[OriginalName("PlayerActionType_PlayerActionLocalLegendReward")]
	PlayerActionLocalLegendReward = 7031,
	[OriginalName("PlayerActionType_PlayerActionFateLevelStart")]
	PlayerActionFateLevelStart = 7041,
	[OriginalName("PlayerActionType_PlayerActionFateLevelSettle")]
	PlayerActionFateLevelSettle = 7042,
	[OriginalName("PlayerActionType_PlayerActionFateBattleStart")]
	PlayerActionFateBattleStart = 7043,
	[OriginalName("PlayerActionType_PlayerActionFateBattleEnd")]
	PlayerActionFateBattleEnd = 7044,
	[OriginalName("PlayerActionType_PlayerActionFateAddHougu")]
	PlayerActionFateAddHougu = 7045,
	[OriginalName("PlayerActionType_PlayerActionFateSelectHougu")]
	PlayerActionFateSelectHougu = 7046,
	[OriginalName("PlayerActionType_PlayerActionFateSelectReiju")]
	PlayerActionFateSelectReiju = 7047,
	[OriginalName("PlayerActionType_PlayerActionFateRefreshReiju")]
	PlayerActionFateRefreshReiju = 7048,
	[OriginalName("PlayerActionType_PlayerActionFateAddCoin")]
	PlayerActionFateAddCoin = 7049,
	[OriginalName("PlayerActionType_PlayerActionFateBuyBuff")]
	PlayerActionFateBuyBuff = 7050,
	[OriginalName("PlayerActionType_PlayerActionFateSellBuff")]
	PlayerActionFateSellBuff = 7051,
	[OriginalName("PlayerActionType_PlayerActionFateRefreshShop")]
	PlayerActionFateRefreshShop = 7052,
	[OriginalName("PlayerActionType_PlayerActionFateLockGoods")]
	PlayerActionFateLockGoods = 7053,
	[OriginalName("PlayerActionType_PlayerActionFateUnlockGoods")]
	PlayerActionFateUnlockGoods = 7054,
	[OriginalName("PlayerActionType_PlayerActionFateTakeExpReward")]
	PlayerActionFateTakeExpReward = 7055,
	[OriginalName("PlayerActionType_PlayerActionFateAddExp")]
	PlayerActionFateAddExp = 7056,
	[OriginalName("PlayerActionType_PlayerActionFateMasterHpChange")]
	PlayerActionFateMasterHpChange = 7057,
	[OriginalName("PlayerActionType_PlayerActionParkourStartLevel")]
	PlayerActionParkourStartLevel = 7061,
	[OriginalName("PlayerActionType_PlayerActionParkourEndLevel")]
	PlayerActionParkourEndLevel = 7062,
	[OriginalName("PlayerActionType_PlayerActionBasinChestInteractResult")]
	PlayerActionBasinChestInteractResult = 7091,
	[OriginalName("PlayerActionType_PlayerActionRogueMiracleSwap")]
	PlayerActionRogueMiracleSwap = 7092,
	[OriginalName("PlayerActionType_PlayerActionHipplenEndingTakeReward")]
	PlayerActionHipplenEndingTakeReward = 7101,
	[OriginalName("PlayerActionType_PlayerActionHipplenGiftDeliverReward")]
	PlayerActionHipplenGiftDeliverReward = 7102,
	[OriginalName("PlayerActionType_PlayerActionHipplenCycleStart")]
	PlayerActionHipplenCycleStart = 7103,
	[OriginalName("PlayerActionType_PlayerActionHipplenCycleFinish")]
	PlayerActionHipplenCycleFinish = 7104,
	[OriginalName("PlayerActionType_PlayerActionHipplenAgendaPlan")]
	PlayerActionHipplenAgendaPlan = 7105,
	[OriginalName("PlayerActionType_PlayerActionHipplenAgendaSettle")]
	PlayerActionHipplenAgendaSettle = 7106,
	[OriginalName("PlayerActionType_PlayerActionHipplenTrialStart")]
	PlayerActionHipplenTrialStart = 7107,
	[OriginalName("PlayerActionType_PlayerActionHipplenTrialFinish")]
	PlayerActionHipplenTrialFinish = 7108,
	[OriginalName("PlayerActionType_PlayerActionHipplenStatusChange")]
	PlayerActionHipplenStatusChange = 7109,
	[OriginalName("PlayerActionType_PlayerActionHipplenOutfitChange")]
	PlayerActionHipplenOutfitChange = 7110,
	[OriginalName("PlayerActionType_PlayerActionHipplenTraitUnlock")]
	PlayerActionHipplenTraitUnlock = 7111,
	[OriginalName("PlayerActionType_PlayerActionHipplenEndingUnlock")]
	PlayerActionHipplenEndingUnlock = 7112,
	[OriginalName("PlayerActionType_PlayerActionHipplenOutfitUnlock")]
	PlayerActionHipplenOutfitUnlock = 7113,
	[OriginalName("PlayerActionType_PlayerActionHipplenGiftUnlock")]
	PlayerActionHipplenGiftUnlock = 7114,
	[OriginalName("PlayerActionType_PlayerActionHipplenIncidentFinish")]
	PlayerActionHipplenIncidentFinish = 7115,
	[OriginalName("PlayerActionType_PlayerActionChallengePeakStart")]
	PlayerActionChallengePeakStart = 7121,
	[OriginalName("PlayerActionType_PlayerActionChallengePeakReward")]
	PlayerActionChallengePeakReward = 7122,
	[OriginalName("PlayerActionType_PlayerActionChallengePeakMobStart")]
	PlayerActionChallengePeakMobStart = 7123,
	[OriginalName("PlayerActionType_PlayerActionChallengePeakMobSettle")]
	PlayerActionChallengePeakMobSettle = 7124,
	[OriginalName("PlayerActionType_PlayerActionChallengePeakBossStart")]
	PlayerActionChallengePeakBossStart = 7125,
	[OriginalName("PlayerActionType_PlayerActionChallengePeakBossSettle")]
	PlayerActionChallengePeakBossSettle = 7126,
	[OriginalName("PlayerActionType_PlayerActionChallengePeakFastPass")]
	PlayerActionChallengePeakFastPass = 7127,
	[OriginalName("PlayerActionType_PlayerActionChallengePeakRecommendLineup")]
	PlayerActionChallengePeakRecommendLineup = 7128,
	[OriginalName("PlayerActionType_PlayerActionChallengePeakMobBattleEnd")]
	PlayerActionChallengePeakMobBattleEnd = 7129,
	[OriginalName("PlayerActionType_PlayerActionChallengePeakMobRecordClear")]
	PlayerActionChallengePeakMobRecordClear = 7130,
	[OriginalName("PlayerActionType_PlayerActionCakeRaceLoan")]
	PlayerActionCakeRaceLoan = 7141,
	[OriginalName("PlayerActionType_PlayerActionCakeRaceSectionBegin")]
	PlayerActionCakeRaceSectionBegin = 7142,
	[OriginalName("PlayerActionType_PlayerActionCakeRaceSectionEnd")]
	PlayerActionCakeRaceSectionEnd = 7143,
	[OriginalName("PlayerActionType_PlayerActionCakeRaceRoomSectionSettle")]
	PlayerActionCakeRaceRoomSectionSettle = 7144,
	[OriginalName("PlayerActionType_PlayerActionCakeRaceGameSettle")]
	PlayerActionCakeRaceGameSettle = 7145,
	[OriginalName("PlayerActionType_PlayerActionCakeRaceGameBetCat")]
	PlayerActionCakeRaceGameBetCat = 7146,
	[OriginalName("PlayerActionType_PlayerActionCakeRaceGameWinCoin")]
	PlayerActionCakeRaceGameWinCoin = 7147,
	[OriginalName("PlayerActionType_PlayerActionCakeRaceLikeFriendRanking")]
	PlayerActionCakeRaceLikeFriendRanking = 7148,
	[OriginalName("PlayerActionType_PlayerActionElationBattleBegin")]
	PlayerActionElationBattleBegin = 7161,
	[OriginalName("PlayerActionType_PlayerActionElationBattleEnd")]
	PlayerActionElationBattleEnd = 7162,
	[OriginalName("PlayerActionType_PlayerActionActivityHotDataChange")]
	PlayerActionActivityHotDataChange = 7170,
	[OriginalName("PlayerActionType_PlayerActionChimeraDuelGameSettle")]
	PlayerActionChimeraDuelGameSettle = 7181,
	[OriginalName("PlayerActionType_PlayerActionChimeraDuelMasterUnlock")]
	PlayerActionChimeraDuelMasterUnlock = 7182,
	[OriginalName("PlayerActionType_PlayerActionChimeraDuelGameStart")]
	PlayerActionChimeraDuelGameStart = 7183,
	[OriginalName("PlayerActionType_PlayerActionChimeraDuelBattleStart")]
	PlayerActionChimeraDuelBattleStart = 7184,
	[OriginalName("PlayerActionType_PlayerActionChimeraDuelBattleEnd")]
	PlayerActionChimeraDuelBattleEnd = 7185,
	[OriginalName("PlayerActionType_PlayerActionChimeraDuelChimeraBuy")]
	PlayerActionChimeraDuelChimeraBuy = 7186,
	[OriginalName("PlayerActionType_PlayerActionChimeraDuelItemBuy")]
	PlayerActionChimeraDuelItemBuy = 7187,
	[OriginalName("PlayerActionType_PlayerActionChimeraDuelShopRefresh")]
	PlayerActionChimeraDuelShopRefresh = 7188,
	[OriginalName("PlayerActionType_PlayerActionChimeraDuelChimeraEnhance")]
	PlayerActionChimeraDuelChimeraEnhance = 7189,
	[OriginalName("PlayerActionType_PlayerActionChimeraDuelChimeraSell")]
	PlayerActionChimeraDuelChimeraSell = 7190,
	[OriginalName("PlayerActionType_PlayerActionChimeraDuelShopStart")]
	PlayerActionChimeraDuelShopStart = 7191,
	[OriginalName("PlayerActionType_PlayerActionChimeraDuelShopEnd")]
	PlayerActionChimeraDuelShopEnd = 7192,
	[OriginalName("PlayerActionType_PlayerActionChimeraDuelFriendPvpLineupSave")]
	PlayerActionChimeraDuelFriendPvpLineupSave = 7193,
	[OriginalName("PlayerActionType_PlayerActionChimeraDuelDefendLineupSet")]
	PlayerActionChimeraDuelDefendLineupSet = 7194,
	[OriginalName("PlayerActionType_PlayerActionMazePuzzleFinishChenLingGameBoy")]
	PlayerActionMazePuzzleFinishChenLingGameBoy = 7201,
	[OriginalName("PlayerActionType_PlayerActionMazePuzzleFiveDimMoneyChange")]
	PlayerActionMazePuzzleFiveDimMoneyChange = 7202,
	[OriginalName("PlayerActionType_PlayerActionMazePuzzleFinishFiveDimMiniGame")]
	PlayerActionMazePuzzleFinishFiveDimMiniGame = 7203,
	[OriginalName("PlayerActionType_PlayerActionMazePuzzleOpenChenLingGameBoyCheatMode")]
	PlayerActionMazePuzzleOpenChenLingGameBoyCheatMode = 7204,
	[OriginalName("PlayerActionType_PlayerActionMazePuzzleEnterFiveDimGame")]
	PlayerActionMazePuzzleEnterFiveDimGame = 7205,
	[OriginalName("PlayerActionType_PlayerActionMazePuzzleLeaveFiveDimGame")]
	PlayerActionMazePuzzleLeaveFiveDimGame = 7206,
	[OriginalName("PlayerActionType_PlayerActionMazePuzzleFiveDimGameSkillChange")]
	PlayerActionMazePuzzleFiveDimGameSkillChange = 7207,
	[OriginalName("PlayerActionType_PlayerActionGridFightGameStart")]
	PlayerActionGridFightGameStart = 7251,
	[OriginalName("PlayerActionType_PlayerActionGridFightGameEnd")]
	PlayerActionGridFightGameEnd = 7252,
	[OriginalName("PlayerActionType_PlayerActionGridFightRoundStart")]
	PlayerActionGridFightRoundStart = 7253,
	[OriginalName("PlayerActionType_PlayerActionGridFightRoundEnd")]
	PlayerActionGridFightRoundEnd = 7254,
	[OriginalName("PlayerActionType_PlayerActionGridFightBattleStart")]
	PlayerActionGridFightBattleStart = 7255,
	[OriginalName("PlayerActionType_PlayerActionGridFightBattleEnd")]
	PlayerActionGridFightBattleEnd = 7256,
	[OriginalName("PlayerActionType_PlayerActionGridFightBattleRole")]
	PlayerActionGridFightBattleRole = 7257,
	[OriginalName("PlayerActionType_PlayerActionGridFightPortalRefresh")]
	PlayerActionGridFightPortalRefresh = 7258,
	[OriginalName("PlayerActionType_PlayerActionGridFightPortalSelect")]
	PlayerActionGridFightPortalSelect = 7259,
	[OriginalName("PlayerActionType_PlayerActionGridFightAugmentRefresh")]
	PlayerActionGridFightAugmentRefresh = 7260,
	[OriginalName("PlayerActionType_PlayerActionGridFightAugmentSelect")]
	PlayerActionGridFightAugmentSelect = 7261,
	[OriginalName("PlayerActionType_PlayerActionGridFightShopRefresh")]
	PlayerActionGridFightShopRefresh = 7262,
	[OriginalName("PlayerActionType_PlayerActionGridFightShopBuy")]
	PlayerActionGridFightShopBuy = 7263,
	[OriginalName("PlayerActionType_PlayerActionGridFightSupplyRefresh")]
	PlayerActionGridFightSupplyRefresh = 7264,
	[OriginalName("PlayerActionType_PlayerActionGridFightSupplySelect")]
	PlayerActionGridFightSupplySelect = 7265,
	[OriginalName("PlayerActionType_PlayerActionGridFightForgeOpen")]
	PlayerActionGridFightForgeOpen = 7266,
	[OriginalName("PlayerActionType_PlayerActionGridFightSpecialShopBuy")]
	PlayerActionGridFightSpecialShopBuy = 7267,
	[OriginalName("PlayerActionType_PlayerActionGridFightGetExp")]
	PlayerActionGridFightGetExp = 7268,
	[OriginalName("PlayerActionType_PlayerActionGridFightGetOrb")]
	PlayerActionGridFightGetOrb = 7269,
	[OriginalName("PlayerActionType_PlayerActionGridFightUseOrb")]
	PlayerActionGridFightUseOrb = 7270,
	[OriginalName("PlayerActionType_PlayerActionGridFightGetRole")]
	PlayerActionGridFightGetRole = 7271,
	[OriginalName("PlayerActionType_PlayerActionGridFightGetCoin")]
	PlayerActionGridFightGetCoin = 7272,
	[OriginalName("PlayerActionType_PlayerActionGridFightGetFreeRefresh")]
	PlayerActionGridFightGetFreeRefresh = 7273,
	[OriginalName("PlayerActionType_PlayerActionGridFightGetItem")]
	PlayerActionGridFightGetItem = 7274,
	[OriginalName("PlayerActionType_PlayerActionGridFightGetEquip")]
	PlayerActionGridFightGetEquip = 7275,
	[OriginalName("PlayerActionType_PlayerActionGridFightDressEquip")]
	PlayerActionGridFightDressEquip = 7276,
	[OriginalName("PlayerActionType_PlayerActionGridFightGetHp")]
	PlayerActionGridFightGetHp = 7277,
	[OriginalName("PlayerActionType_PlayerActionGridFightWeeklyScoreChange")]
	PlayerActionGridFightWeeklyScoreChange = 7278,
	[OriginalName("PlayerActionType_PlayerActionGridFightGetWeeklyReward")]
	PlayerActionGridFightGetWeeklyReward = 7279,
	[OriginalName("PlayerActionType_PlayerActionGridFightSeasonExpChange")]
	PlayerActionGridFightSeasonExpChange = 7280,
	[OriginalName("PlayerActionType_PlayerActionGridFightTalentEnable")]
	PlayerActionGridFightTalentEnable = 7281,
	[OriginalName("PlayerActionType_PlayerActionGridFightTalentReset")]
	PlayerActionGridFightTalentReset = 7282,
	[OriginalName("PlayerActionType_PlayerActionGridFightTutorialTaskFinish")]
	PlayerActionGridFightTutorialTaskFinish = 7283,
	[OriginalName("PlayerActionType_PlayerActionGridFightEliteBranchRefresh")]
	PlayerActionGridFightEliteBranchRefresh = 7284,
	[OriginalName("PlayerActionType_PlayerActionGridFightTutorialResume")]
	PlayerActionGridFightTutorialResume = 7285,
	[OriginalName("PlayerActionType_PlayerActionGridFightGetProjection")]
	PlayerActionGridFightGetProjection = 7286,
	[OriginalName("PlayerActionType_PlayerActionGridFightGetPresent")]
	PlayerActionGridFightGetPresent = 7287,
	[OriginalName("PlayerActionType_PlayerActionGridFightOpenPresent")]
	PlayerActionGridFightOpenPresent = 7288,
	[OriginalName("PlayerActionType_PlayerActionGridFightSettleSeasonEnd")]
	PlayerActionGridFightSettleSeasonEnd = 7289,
	[OriginalName("PlayerActionType_PlayerActionGridFightFavoriteArchive")]
	PlayerActionGridFightFavoriteArchive = 7290,
	[OriginalName("PlayerActionType_PlayerActionGridFightFormationEdit")]
	PlayerActionGridFightFormationEdit = 7291,
	[OriginalName("PlayerActionType_PlayerActionGridFightModifierUpdate")]
	PlayerActionGridFightModifierUpdate = 7292,
	[OriginalName("PlayerActionType_PlayerActionLocalLegendBattleBegin")]
	PlayerActionLocalLegendBattleBegin = 7361,
	[OriginalName("PlayerActionType_PlayerActionLocalLegendBattleEnd")]
	PlayerActionLocalLegendBattleEnd = 7362,
	[OriginalName("PlayerActionType_PlayerActionDiceCombatBuyShopGood")]
	PlayerActionDiceCombatBuyShopGood = 7351,
	[OriginalName("PlayerActionType_PlayerActionDiceCombatUpgradeAvatar")]
	PlayerActionDiceCombatUpgradeAvatar = 7352,
	[OriginalName("PlayerActionType_PlayerActionDiceCombatFinishPveStage")]
	PlayerActionDiceCombatFinishPveStage = 7353,
	[OriginalName("PlayerActionType_PlayerActionDiceCombatBegin")]
	PlayerActionDiceCombatBegin = 7354,
	[OriginalName("PlayerActionType_PlayerActionDiceCombatTurnEnd")]
	PlayerActionDiceCombatTurnEnd = 7355,
	[OriginalName("PlayerActionType_PlayerActionDiceCombatEnd")]
	PlayerActionDiceCombatEnd = 7356,
	[OriginalName("PlayerActionType_PlayerActionDiceCombatScoreChange")]
	PlayerActionDiceCombatScoreChange = 7357,
	[OriginalName("PlayerActionType_PlayerActionDiceCombatChangeColorDice")]
	PlayerActionDiceCombatChangeColorDice = 7358,
	[OriginalName("PlayerActionType_PlayerActionInteractiveTriggerMazeBuffAdd")]
	PlayerActionInteractiveTriggerMazeBuffAdd = 7371,
	[OriginalName("PlayerActionType_PlayerActionLlmChat")]
	PlayerActionLlmChat = 7376,
	[OriginalName("PlayerActionType_PlayerActionLlmChatNextQuestion")]
	PlayerActionLlmChatNextQuestion = 7377,
	[OriginalName("PlayerActionType_PlayerActionLlmChatFeedback")]
	PlayerActionLlmChatFeedback = 7378,
	[OriginalName("PlayerActionType_PlayerActionAiPamChatPointChange")]
	PlayerActionAiPamChatPointChange = 7379,
	[OriginalName("PlayerActionType_PlayerActionTrainCakeCatchCatGodInteract")]
	PlayerActionTrainCakeCatchCatGodInteract = 7381,
	[OriginalName("PlayerActionType_PlayerActionTrainCakeCatchOpenBox")]
	PlayerActionTrainCakeCatchOpenBox = 7382,
	[OriginalName("PlayerActionType_PlayerActionTrainCakeCatchSearchCat")]
	PlayerActionTrainCakeCatchSearchCat = 7383,
	[OriginalName("PlayerActionType_PlayerActionTrainCakeCatchUnlockPerformance")]
	PlayerActionTrainCakeCatchUnlockPerformance = 7384,
	[OriginalName("PlayerActionType_PlayerActionTrainCakeCatchUpdateDiyInfo")]
	PlayerActionTrainCakeCatchUpdateDiyInfo = 7385,
	[OriginalName("PlayerActionType_PlayerActionSocialPlayTalk")]
	PlayerActionSocialPlayTalk = 7386,
	[OriginalName("PlayerActionType_PlayerActionSocialPlayKickOutPlayer")]
	PlayerActionSocialPlayKickOutPlayer = 7387,
	[OriginalName("PlayerActionType_PlayerActionSocialPlayPopularityValue")]
	PlayerActionSocialPlayPopularityValue = 7388,
	[OriginalName("PlayerActionType_PlayerActionSocialPlayLeaveRoom")]
	PlayerActionSocialPlayLeaveRoom = 7389,
	[OriginalName("PlayerActionType_PlayerActionSocialPlayEnterRoom")]
	PlayerActionSocialPlayEnterRoom = 7390,
	[OriginalName("PlayerActionType_PlayerActionTrainCakeCatchCatGodAppear")]
	PlayerActionTrainCakeCatchCatGodAppear = 7391,
	[OriginalName("PlayerActionType_PlayerActionIdleLiveUpgradeTeamSlot")]
	PlayerActionIdleLiveUpgradeTeamSlot = 7401,
	[OriginalName("PlayerActionType_PlayerActionIdleLiveFinishSubNode")]
	PlayerActionIdleLiveFinishSubNode = 7402,
	[OriginalName("PlayerActionType_PlayerActionIdleLiveFinishChapterFinalAct")]
	PlayerActionIdleLiveFinishChapterFinalAct = 7403,
	[OriginalName("PlayerActionType_PlayerActionIdleLiveCollectIncome")]
	PlayerActionIdleLiveCollectIncome = 7404,
	[OriginalName("PlayerActionType_PlayerActionIdleLiveOpenChest")]
	PlayerActionIdleLiveOpenChest = 7405,
	[OriginalName("PlayerActionType_PlayerActionIdleLiveTakeTaskReward")]
	PlayerActionIdleLiveTakeTaskReward = 7406,
	[OriginalName("PlayerActionType_PlayerActionIdleLiveTechTreeChange")]
	PlayerActionIdleLiveTechTreeChange = 7407,
	[OriginalName("PlayerActionType_PlayerActionIdleLiveModifyCustomTitle")]
	PlayerActionIdleLiveModifyCustomTitle = 7408,
	[OriginalName("PlayerActionType_PlayerActionIdleLiveCatchUpReward")]
	PlayerActionIdleLiveCatchUpReward = 7409,
	[OriginalName("PlayerActionType_PlayerActionIdleLiveTakeMessageReward")]
	PlayerActionIdleLiveTakeMessageReward = 7410,
	[OriginalName("PlayerActionType_PlayerActionIdleLiveTakeGiftReward")]
	PlayerActionIdleLiveTakeGiftReward = 7411,
	[OriginalName("PlayerActionType_PlayerActionIdleLiveEndDungeon")]
	PlayerActionIdleLiveEndDungeon = 7412,
	[OriginalName("PlayerActionType_PlayerActionIdleLiveActivityInit")]
	PlayerActionIdleLiveActivityInit = 7413,
	[OriginalName("PlayerActionType_PlayerActionIdleLiveEquipDiscard")]
	PlayerActionIdleLiveEquipDiscard = 7414,
	[OriginalName("PlayerActionType_PlayerActionIdleLiveDoGacha")]
	PlayerActionIdleLiveDoGacha = 7415,
	[OriginalName("PlayerActionType_PlayerActionIdleLiveAddAvatar")]
	PlayerActionIdleLiveAddAvatar = 7416,
	[OriginalName("PlayerActionType_PlayerActionIdleLiveTaskChange")]
	PlayerActionIdleLiveTaskChange = 7417,
	[OriginalName("PlayerActionType_PlayerActionIdleLiveReplaceTeam")]
	PlayerActionIdleLiveReplaceTeam = 7418,
	[OriginalName("PlayerActionType_PlayerActionIdleLiveHandleNormalEquip")]
	PlayerActionIdleLiveHandleNormalEquip = 7419,
	[OriginalName("PlayerActionType_PlayerActionIdleLiveUpgradeSpecialEquip")]
	PlayerActionIdleLiveUpgradeSpecialEquip = 7420,
	[OriginalName("PlayerActionType_PlayerActionIdleLiveDressSpecialEquip")]
	PlayerActionIdleLiveDressSpecialEquip = 7421,
	[OriginalName("PlayerActionType_PlayerActionIdleLiveAddItem")]
	PlayerActionIdleLiveAddItem = 7422,
	[OriginalName("PlayerActionType_PlayerActionIdleLiveQuestionChange")]
	PlayerActionIdleLiveQuestionChange = 7423,
	[OriginalName("PlayerActionType_PlayerActionIdleLiveStartNodeBattle")]
	PlayerActionIdleLiveStartNodeBattle = 7424,
	[OriginalName("PlayerActionType_PlayerActionIdleLiveFinishNodeBattle")]
	PlayerActionIdleLiveFinishNodeBattle = 7425,
	[OriginalName("PlayerActionType_PlayerActionIdleLiveFinishNode")]
	PlayerActionIdleLiveFinishNode = 7426,
	[OriginalName("PlayerActionType_PlayerActionIdleLiveMessageChange")]
	PlayerActionIdleLiveMessageChange = 7427,
	[OriginalName("PlayerActionType_PlayerActionNewYearBoatTakeReward")]
	PlayerActionNewYearBoatTakeReward = 7451,
	[OriginalName("PlayerActionType_PlayerActionNewYearBoatSelectBoat")]
	PlayerActionNewYearBoatSelectBoat = 7452,
	[OriginalName("PlayerActionType_PlayerActionNewYearBoatPeriodSettle")]
	PlayerActionNewYearBoatPeriodSettle = 7453,
	[OriginalName("PlayerActionType_PlayerActionBenefitV2ActivityTakeReward")]
	PlayerActionBenefitV2ActivityTakeReward = 7454,
	[OriginalName("PlayerActionType_PlayerActionBenefitV2ActivityDraw")]
	PlayerActionBenefitV2ActivityDraw = 7455,
	[OriginalName("PlayerActionType_PlayerActionJukeboxSetting")]
	PlayerActionJukeboxSetting = 7471,
	[OriginalName("PlayerActionType_PlayerActionJukeboxSettingReset")]
	PlayerActionJukeboxSettingReset = 7472,
	[OriginalName("PlayerActionType_PlayerActionDiceCombatV2FinishPveStage")]
	PlayerActionDiceCombatV2FinishPveStage = 7476,
	[OriginalName("PlayerActionType_PlayerActionDiceCombatV2Begin")]
	PlayerActionDiceCombatV2Begin = 7477,
	[OriginalName("PlayerActionType_PlayerActionDiceCombatV2TurnEnd")]
	PlayerActionDiceCombatV2TurnEnd = 7478,
	[OriginalName("PlayerActionType_PlayerActionDiceCombatV2End")]
	PlayerActionDiceCombatV2End = 7479,
	[OriginalName("PlayerActionType_PlayerActionDiceCombatV2TacticsPointChange")]
	PlayerActionDiceCombatV2TacticsPointChange = 7480,
	[OriginalName("PlayerActionType_PlayerActionDiceCombatV2TacticsCardChange")]
	PlayerActionDiceCombatV2TacticsCardChange = 7481,
	[OriginalName("PlayerActionType_PlayerActionDiceCombatV2DiceChangeRequest")]
	PlayerActionDiceCombatV2DiceChangeRequest = 7482,
	[OriginalName("PlayerActionType_PlayerActionDiceCombatV2DiceChange")]
	PlayerActionDiceCombatV2DiceChange = 7483,
	[OriginalName("PlayerActionType_PlayerActionLimaoNewsSubmitIssue")]
	PlayerActionLimaoNewsSubmitIssue = 7486,
	[OriginalName("PlayerActionType_PlayerActionLimaoNewsSubmitPost")]
	PlayerActionLimaoNewsSubmitPost = 7487,
	[OriginalName("PlayerActionType_PlayerActionLimaoNewsOfficeSurveyStateChange")]
	PlayerActionLimaoNewsOfficeSurveyStateChange = 7488,
	[OriginalName("PlayerActionType_PlayerActionLimaoNewsTriggerMessage")]
	PlayerActionLimaoNewsTriggerMessage = 7489,
	[OriginalName("PlayerActionType_PlayerActionLimaoNewsFinishMessage")]
	PlayerActionLimaoNewsFinishMessage = 7490,
	[OriginalName("PlayerActionType_PlayerActionLimaoNewsFinishCondition")]
	PlayerActionLimaoNewsFinishCondition = 7491,
	[OriginalName("PlayerActionType_PlayerActionLimaoNewsUnlockPost")]
	PlayerActionLimaoNewsUnlockPost = 7492,
	[OriginalName("PlayerActionType_PlayerActionLimaoNewsReplyComment")]
	PlayerActionLimaoNewsReplyComment = 7493,
	[OriginalName("PlayerActionType_PlayerActionLimaoNewsBanPost")]
	PlayerActionLimaoNewsBanPost = 7494,
	[OriginalName("PlayerActionType_PlayerActionLimaoNewsTriggerOfficeEvent")]
	PlayerActionLimaoNewsTriggerOfficeEvent = 7495,
	[OriginalName("PlayerActionType_PlayerActionLimaoNewsFinishOfficeEvent")]
	PlayerActionLimaoNewsFinishOfficeEvent = 7496,
	[OriginalName("PlayerActionType_PlayerActionLimaoNewsUpvoteContent")]
	PlayerActionLimaoNewsUpvoteContent = 7497,
	[OriginalName("PlayerActionType_PlayerActionChenLingBattleActivatePrivilege")]
	PlayerActionChenLingBattleActivatePrivilege = 7506,
	[OriginalName("PlayerActionType_PlayerActionChenLingBattleConquerLevelUp")]
	PlayerActionChenLingBattleConquerLevelUp = 7507,
	[OriginalName("PlayerActionType_PlayerActionChenLingBattleStartStage")]
	PlayerActionChenLingBattleStartStage = 7508,
	[OriginalName("PlayerActionType_PlayerActionChenLingBattleSettleStage")]
	PlayerActionChenLingBattleSettleStage = 7509,
	[OriginalName("PlayerActionType_PlayerActionChenLingBattleStartBattle")]
	PlayerActionChenLingBattleStartBattle = 7510,
	[OriginalName("PlayerActionType_PlayerActionChenLingBattleFinishBattle")]
	PlayerActionChenLingBattleFinishBattle = 7511,
	[OriginalName("PlayerActionType_PlayerActionChenLingBattleFinishWave")]
	PlayerActionChenLingBattleFinishWave = 7512,
	[OriginalName("PlayerActionType_PlayerActionChenLingBattleSelectCard")]
	PlayerActionChenLingBattleSelectCard = 7513,
	[OriginalName("PlayerActionType_PlayerActionChenLingBattleRefreshCard")]
	PlayerActionChenLingBattleRefreshCard = 7514,
	[OriginalName("PlayerActionType_PlayerActionChenLingBattleBuyShopItem")]
	PlayerActionChenLingBattleBuyShopItem = 7515,
	[OriginalName("PlayerActionType_PlayerActionChenLingBattleRefreshShop")]
	PlayerActionChenLingBattleRefreshShop = 7516,
	[OriginalName("PlayerActionType_PlayerActionChenLingBattleSelectPolicy")]
	PlayerActionChenLingBattleSelectPolicy = 7517,
	[OriginalName("PlayerActionType_PlayerActionChenLingBattleRefreshPolicy")]
	PlayerActionChenLingBattleRefreshPolicy = 7518,
	[OriginalName("PlayerActionType_PlayerActionChenLingBattleAddHandCard")]
	PlayerActionChenLingBattleAddHandCard = 7519,
	[OriginalName("PlayerActionType_PlayerActionChenLingBattleUseHandCard")]
	PlayerActionChenLingBattleUseHandCard = 7520,
	[OriginalName("PlayerActionType_PlayerActionChenLingBattleSellHandCard")]
	PlayerActionChenLingBattleSellHandCard = 7521,
	[OriginalName("PlayerActionType_PlayerActionChenLingBattleEntityUpgrade")]
	PlayerActionChenLingBattleEntityUpgrade = 7522,
	[OriginalName("PlayerActionType_PlayerActionChenLingBattleCloneEntity")]
	PlayerActionChenLingBattleCloneEntity = 7523,
	[OriginalName("PlayerActionType_PlayerActionCycleScoreChange")]
	PlayerActionCycleScoreChange = 7541,
	[OriginalName("PlayerActionType_PlayerActionCycleScoreTakeReward")]
	PlayerActionCycleScoreTakeReward = 7542,
	[OriginalName("PlayerActionType_PlayerActionRelicPresetPlanSave")]
	PlayerActionRelicPresetPlanSave = 7581,
	[OriginalName("PlayerActionType_PlayerActionRelicPresetPlanDelete")]
	PlayerActionRelicPresetPlanDelete = 7582,
	[OriginalName("PlayerActionType_PlayerActionRelicPresetPlanModifyName")]
	PlayerActionRelicPresetPlanModifyName = 7583
}
