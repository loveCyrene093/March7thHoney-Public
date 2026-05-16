using System;
using System.Collections.Generic;
using System.Linq;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Inventory;
using March7thHoney.Database.Lineup;
using March7thHoney.Enums.Avatar;
using March7thHoney.Enums.Item;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.Database.Avatar;

public class FormalAvatarInfo : BaseAvatarInfo
{
	public int Exp { get; set; }

	public int Rewards { get; set; }

	public long Timestamp { get; set; }

	public bool IsMarked { get; set; }

	public FormalAvatarInfo()
	{
	}

	public FormalAvatarInfo(int baseAvatarId, int avatarId, bool addSkills)
	{
		base.BaseAvatarId = baseAvatarId;
		base.AvatarId = avatarId;
		if (addSkills)
		{
			CheckPathSkillTree();
		}
	}

	public bool HasTakenReward(int promotion)
	{
		return (Rewards & (1 << promotion)) != 0;
	}

	public void ValidateHero(Gender gender)
	{
		KeyValuePair<int, PathInfo>[] array = base.PathInfos.ToArray();
		for (int i = 0; i < array.Length; i++)
		{
			KeyValuePair<int, PathInfo> keyValuePair = array[i];
			if (GameData.MultiplePathAvatarConfigData.TryGetValue(keyValuePair.Key, out MultiplePathAvatarConfigExcel value) && value.Gender != GenderTypeEnum.GENDER_NONE && value.Gender != (GenderTypeEnum)gender)
			{
				base.PathInfos.Remove(keyValuePair.Key);
			}
		}
	}

	public void CheckPathSkillTree()
	{
		if (GameData.AvatarConfigData.TryGetValue(base.AvatarId, out AvatarConfigExcel value) && !base.PathInfos.ContainsKey(base.AvatarId) && value.DefaultSkillTree[0].Count != 0)
		{
			PathInfo pathInfo = new PathInfo(base.AvatarId);
			pathInfo.GetSkillTree();
			base.PathInfos.Add(base.AvatarId, pathInfo);
		}
	}

	public void TakeReward(int promotion)
	{
		Rewards |= 1 << promotion;
	}

	public override March7thHoney.Proto.Avatar ToProto()
	{
		March7thHoney.Proto.Avatar avatar = new March7thHoney.Proto.Avatar
		{
			BaseAvatarId = (uint)base.BaseAvatarId,
			Level = (uint)base.Level,
			Exp = (uint)Exp,
			Promotion = (uint)base.Promotion,
			FirstMetTimeStamp = (ulong)Timestamp,
			IsMarked = IsMarked,
			CurMultiPathAvatarType = (uint)base.AvatarId
		};
		if (GetCurPathInfo().EquipId != 0)
		{
			avatar.EquipmentUniqueId = (uint)GetCurPathInfo().EquipId;
		}
		for (int i = 0; i < base.Promotion; i++)
		{
			if (HasTakenReward(i))
			{
				avatar.HasTakenPromotionRewardList.Add((uint)i);
			}
		}
		return avatar;
	}

	public override LineupAvatar ToLineupInfo(int slot, March7thHoney.Database.Lineup.LineupInfo info, AvatarType avatarType = AvatarType.AvatarFormalType)
	{
		return new LineupAvatar
		{
			Id = (uint)base.BaseAvatarId,
			Slot = (uint)slot,
			AvatarType = avatarType,
			Hp = (uint)(info.IsExtraLineup() ? base.ExtraLineupHp : base.CurrentHp),
			SpBar = new SpBarInfo
			{
				CurSp = (uint)(info.IsExtraLineup() ? base.ExtraLineupSp : base.CurrentSp),
				MaxSp = 10000u
			}
		};
	}

	public override BattleAvatar ToBattleProto(PlayerDataCollection collection, AvatarType avatarType = AvatarType.AvatarFormalType)
	{
		BattleAvatar battleAvatar = CreateBaseProto(collection, avatarType);
		bool flag = IsUpgradableType(avatarType);
		if (!GameData.AvatarConfigData.TryGetValue(base.AvatarId, out AvatarConfigExcel value))
		{
			return battleAvatar;
		}
		if (flag)
		{
			ApplyMaxLevel(battleAvatar);
		}
		ProcessSkills(battleAvatar, flag);
		ProcessRelics(battleAvatar, collection, flag);
		ProcessEquipment(battleAvatar, collection, flag, value);
		return battleAvatar;
	}

	private BattleAvatar CreateBaseProto(PlayerDataCollection collection, AvatarType avatarType)
	{
		bool isExtraLineup = collection.LineupInfo.LineupType != 0;
		return new BattleAvatar
		{
			Id = (uint)base.AvatarId,
			AvatarType = avatarType,
			Level = (uint)base.Level,
			Promotion = (uint)base.Promotion,
			Rank = (uint)GetCurPathInfo().Rank,
			Index = (uint)collection.LineupInfo.GetSlot(base.BaseAvatarId),
			Hp = (uint)GetCurHp(isExtraLineup),
			SpBar = new SpBarInfo
			{
				CurSp = (uint)GetCurSp(isExtraLineup),
				MaxSp = 10000u
			},
			WorldLevel = (uint)collection.PlayerData.WorldLevel,
			EnhancedId = (uint)GetCurPathInfo().EnhanceId
		};
	}

	private static bool IsUpgradableType(AvatarType avatarType)
	{
		if ((uint)(avatarType - 6) <= 1u)
		{
			return true;
		}
		return false;
	}

	private static void ApplyMaxLevel(BattleAvatar proto)
	{
		proto.Level = 80u;
		proto.Promotion = 6u;
	}

	private void ProcessSkills(BattleAvatar proto, bool isUpgradable)
	{
		foreach (KeyValuePair<int, int> item in GetCurPathInfo().GetSkillTree())
		{
			item.Deconstruct(out var key, out var value);
			int num = key;
			int num2 = value;
			int level = (isUpgradable ? GetUpgradedSkillLevel(num, num2) : num2);
			proto.SkilltreeList.Add(new AvatarSkillTree
			{
				PointId = (uint)num,
				Level = (uint)level
			});
		}
	}

	private static int GetUpgradedSkillLevel(int skillId, int currentLevel)
	{
		int num = GameData.AvatarSkillTreeConfigData.GetValueOrDefault(skillId * 100 + currentLevel)?.MaxLevel ?? 1;
		return Math.Max(Math.Max(1, num - 2), currentLevel);
	}

	private void ProcessRelics(BattleAvatar proto, PlayerDataCollection collection, bool isUpgradable)
	{
		UpgradeAvatarSubRelicTypeEnum upgradeType = GameData.UpgradeAvatarSubTypeData.GetValueOrDefault((uint)base.AvatarId)?.SubType ?? UpgradeAvatarSubRelicTypeEnum.Base;
		AvatarRelicRecommendExcel valueOrDefault = GameData.AvatarRelicRecommendData.GetValueOrDefault((uint)base.AvatarId);
		Dictionary<int, int> relic = GetCurPathInfo().Relic;
		for (int i = 1; i <= 6; i++)
		{
			relic.TryAdd(i, 0);
		}
		foreach (KeyValuePair<int, int> item in relic)
		{
			item.Deconstruct(out var key, out var value);
			int slot = key;
			int relicId = value;
			BattleRelic battleRelic = CreateRelicForSlot(slot, relicId, collection, isUpgradable, upgradeType, valueOrDefault);
			if (battleRelic != null)
			{
				proto.RelicList.Add(battleRelic);
			}
		}
	}

	private BattleRelic? CreateRelicForSlot(int slot, int relicId, PlayerDataCollection collection, bool isUpgradable, UpgradeAvatarSubRelicTypeEnum upgradeType, AvatarRelicRecommendExcel? recommend)
	{
		ItemData itemData = collection.InventoryData.RelicItems.Find((ItemData x) => x.UniqueId == relicId);
		if (itemData != null && (!isUpgradable || itemData.Level >= 15 || recommend == null))
		{
			return CreateRelicFromItem(itemData);
		}
		if (!isUpgradable)
		{
			return null;
		}
		return CreateInternalRelic(slot, upgradeType, recommend);
	}

	private static BattleRelic CreateRelicFromItem(ItemData item)
	{
		BattleRelic relic = new BattleRelic
		{
			Id = (uint)item.ItemId,
			UniqueId = (uint)item.UniqueId,
			Level = (uint)item.Level,
			MainAffixId = (uint)item.MainAffix
		};
		item.SubAffixes.ForEach(delegate(ItemSubAffix sub)
		{
			relic.SubAffixList.Add(sub.ToProto());
		});
		return relic;
	}

	private BattleRelic? CreateInternalRelic(int slot, UpgradeAvatarSubRelicTypeEnum upgradeType, AvatarRelicRecommendExcel? recommend)
	{
		if (recommend == null)
		{
			return null;
		}
		uint recommendedRelicSet = GetRecommendedRelicSet(slot, recommend);
		UpgradeAvatarSubRelicExcel relicUpgradeInfo = GetRelicUpgradeInfo(upgradeType, (RelicTypeEnum)slot);
		RelicConfigExcel relicConfigExcel = FindRelicConfig(recommendedRelicSet, (RelicTypeEnum)slot);
		if (relicUpgradeInfo == null || relicConfigExcel == null)
		{
			return null;
		}
		uint mainAffixId = GetMainAffixId(slot, recommend, relicConfigExcel);
		if (mainAffixId == 0)
		{
			return null;
		}
		return BuildBattleRelic(relicConfigExcel, mainAffixId, relicUpgradeInfo);
	}

	private static uint GetRecommendedRelicSet(int slot, AvatarRelicRecommendExcel recommend)
	{
		if (slot > 4)
		{
			return recommend.Set2IDList.First();
		}
		return recommend.Set4IDList.First();
	}

	private UpgradeAvatarSubRelicExcel? GetRelicUpgradeInfo(UpgradeAvatarSubRelicTypeEnum upgradeType, RelicTypeEnum slotType)
	{
		return GameData.UpgradeAvatarSubRelicData.GetValueOrDefault(upgradeType, new Dictionary<RarityEnum, Dictionary<uint, Dictionary<RelicTypeEnum, UpgradeAvatarSubRelicExcel>>>()).GetValueOrDefault(RarityEnum.CombatPowerRelicRarity5, new Dictionary<uint, Dictionary<RelicTypeEnum, UpgradeAvatarSubRelicExcel>>()).GetValueOrDefault(15u, new Dictionary<RelicTypeEnum, UpgradeAvatarSubRelicExcel>())
			.GetValueOrDefault(slotType);
	}

	private static RelicConfigExcel? FindRelicConfig(uint relicSet, RelicTypeEnum slotType)
	{
		return GameData.RelicConfigData.Values.FirstOrDefault((RelicConfigExcel x) => x.SetID == relicSet && x.Rarity == RarityEnum.CombatPowerRelicRarity5 && x.Type == slotType);
	}

	private uint GetMainAffixId(int slot, AvatarRelicRecommendExcel recommend, RelicConfigExcel relicItem)
	{
		AvatarPropertyTypeEnum? mainAffix = recommend.PropertyList.FirstOrDefault((AvatarRelicRecommendMainAffix x) => x.RelicType == (RelicTypeEnum)slot)?.PropertyType;
		if (!mainAffix.HasValue)
		{
			return GetRandomRelicMainAffix(relicItem.ID);
		}
		return (uint)(GameData.RelicMainAffixData[relicItem.MainAffixGroup].Values.FirstOrDefault((RelicMainAffixConfigExcel x) => x.Property == mainAffix)?.AffixID ?? 0);
	}

	private static BattleRelic BuildBattleRelic(RelicConfigExcel relicItem, uint mainAffixId, UpgradeAvatarSubRelicExcel relicInfo)
	{
		BattleRelic battleRelic = new BattleRelic
		{
			Id = (uint)relicItem.ID,
			Level = 15u,
			MainAffixId = mainAffixId
		};
		foreach (UpgradeAvatarSubAffixInfo relic in relicInfo.SubAffixes)
		{
			RelicSubAffixConfigExcel relicSubAffixConfigExcel = GameData.RelicSubAffixData[relicItem.SubAffixGroup].Values.FirstOrDefault((RelicSubAffixConfigExcel x) => x.Property == relic.AffixProperty);
			if (relicSubAffixConfigExcel != null)
			{
				battleRelic.SubAffixList.Add(new RelicAffix
				{
					AffixId = (uint)relicSubAffixConfigExcel.AffixID,
					Cnt = relic.AffixCount,
					Step = (uint)(relic.AffixCount * relicSubAffixConfigExcel.StepNum)
				});
			}
		}
		return battleRelic;
	}

	private void ProcessEquipment(BattleAvatar proto, PlayerDataCollection collection, bool isUpgradable, AvatarConfigExcel avatarConf)
	{
		int equipId = GetCurPathInfo().EquipId;
		ItemData equipData = GetCurPathInfo().EquipData;
		if (equipId != 0)
		{
			ItemData itemData = collection.InventoryData.EquipmentItems.Find((ItemData x) => x.UniqueId == equipId);
			if (itemData != null)
			{
				proto.EquipmentList.Add(CreateEquipmentFromItem(itemData, isUpgradable, avatarConf));
			}
		}
		else if (equipData != null)
		{
			proto.EquipmentList.Add(CreateEquipmentFromData(equipData));
		}
		else if (isUpgradable)
		{
			BattleEquipment battleEquipment = CreateInternalEquipment(avatarConf);
			if (battleEquipment != null)
			{
				proto.EquipmentList.Add(battleEquipment);
			}
		}
	}

	private BattleEquipment CreateEquipmentFromItem(ItemData item, bool isUpgradable, AvatarConfigExcel avatarConf)
	{
		int itemId = item.ItemId;
		int level = item.Level;
		int promotion = item.Promotion;
		int rank = item.Rank;
		int promotion2 = promotion;
		int level2 = level;
		int num = itemId;
		if (isUpgradable)
		{
			(num, level2, promotion2, rank) = UpgradeEquipment(num, rank, avatarConf);
		}
		return new BattleEquipment
		{
			Id = (uint)num,
			Level = (uint)level2,
			Promotion = (uint)promotion2,
			Rank = (uint)rank
		};
	}

	private (int itemId, int level, int promotion, int rank) UpgradeEquipment(int itemId, int rank, AvatarConfigExcel avatarConf)
	{
		if (GameData.EquipmentConfigData.TryGetValue(itemId, out EquipmentConfigExcel value) && value.Rarity == RarityEnum.CombatPowerLightconeRarity3)
		{
			if (GameData.UpgradeAvatarEquipmentData.TryGetValue(avatarConf.AvatarBaseType, out UpgradeAvatarEquipmentExcel value2))
			{
				itemId = (int)value2.EquipmentId;
				value = GameData.EquipmentConfigData.GetValueOrDefault(itemId);
			}
			return (itemId: itemId, level: 80, promotion: value?.MaxPromotion ?? 6, rank: 1);
		}
		return (itemId: itemId, level: 80, promotion: 6, rank: rank);
	}

	private static BattleEquipment CreateEquipmentFromData(ItemData data)
	{
		return new BattleEquipment
		{
			Id = (uint)data.ItemId,
			Level = (uint)data.Level,
			Promotion = (uint)data.Promotion,
			Rank = (uint)data.Rank
		};
	}

	private static BattleEquipment? CreateInternalEquipment(AvatarConfigExcel avatarConf)
	{
		if (!GameData.UpgradeAvatarEquipmentData.TryGetValue(avatarConf.AvatarBaseType, out UpgradeAvatarEquipmentExcel value))
		{
			return null;
		}
		return new BattleEquipment
		{
			Id = value.EquipmentId,
			Level = 80u,
			Promotion = 6u,
			Rank = 1u
		};
	}

	public uint GetRandomRelicMainAffix(int itemId)
	{
		GameData.RelicConfigData.TryGetValue(itemId, out RelicConfigExcel value);
		if (value == null)
		{
			return 0u;
		}
		GameData.RelicMainAffixData.TryGetValue(value.MainAffixGroup, out Dictionary<int, RelicMainAffixConfigExcel> value2);
		if (value2 == null)
		{
			return 0u;
		}
		List<uint> list = new List<uint>();
		list.AddRange(value2.Values.Select((RelicMainAffixConfigExcel affix) => (uint)affix.AffixID));
		return list.RandomElement();
	}

	public ChallengePeakBuild ToPeakAvatarProto()
	{
		return new ChallengePeakBuild
		{
			AvatarId = (uint)base.AvatarId,
			EquipmentUniqueId = (uint)GetCurPathInfo().EquipId,
			RelicList = { GetCurPathInfo().Relic.Select((KeyValuePair<int, int> relic) => new EquipRelic
			{
				Type = (uint)relic.Key,
				RelicUniqueId = (uint)relic.Value
			}) }
		};
	}

	public List<AvatarPathData> ToAvatarPathDataProto()
	{
		List<AvatarPathData> list = new List<AvatarPathData>();
		foreach (PathInfo value2 in base.PathInfos.Values)
		{
			AvatarPathData avatarPathData = new AvatarPathData
			{
				AvatarId = (uint)value2.PathId,
				Rank = (uint)value2.Rank,
				PathEquipmentId = (uint)value2.EquipId,
				DressedSkinId = (uint)value2.Skin,
				UnkEnhancedId = (uint)value2.EnhanceId
			};
			foreach (KeyValuePair<int, int> item in value2.GetSkillTree())
			{
				int key = item.Key * 100 + item.Value;
				AvatarSkillTreeConfigExcel value;
				int num = (GameData.AvatarSkillTreeConfigData.TryGetValue(key, out value) ? value.GetMultiPointId() : 0);
				if (num <= 0)
				{
					num = item.Key;
				}
				avatarPathData.AvatarPathSkillTree.Add(new AvatarPathSkillTree
				{
					PointId = (uint)num,
					Level = (uint)item.Value
				});
			}
			foreach (KeyValuePair<int, int> item2 in value2.Relic)
			{
				avatarPathData.EquipRelicList.Add(new EquipRelic
				{
					Type = (uint)item2.Key,
					RelicUniqueId = (uint)item2.Value
				});
			}
			list.Add(avatarPathData);
		}
		return list;
	}

	public DisplayAvatarDetailInfo ToDetailProto(int pos, PlayerDataCollection collection)
	{
		DisplayAvatarDetailInfo displayAvatarDetailInfo = new DisplayAvatarDetailInfo
		{
			AvatarId = (uint)base.AvatarId,
			Level = (uint)base.Level,
			Exp = (uint)Exp,
			Promotion = (uint)base.Promotion,
			Rank = (uint)GetCurPathInfo().Rank,
			Pos = (uint)pos,
			DressedSkinId = (uint)GetCurPathInfo().Skin
		};
		InventoryData inventoryData = collection.InventoryData;
		foreach (KeyValuePair<int, int> item in GetCurPathInfo().Relic)
		{
			ItemData itemData = inventoryData.RelicItems.Find((ItemData x) => x.UniqueId == item.Value);
			displayAvatarDetailInfo.RelicList.Add(itemData.ToDisplayRelicProto());
		}
		if (GetCurPathInfo().EquipId != 0)
		{
			ItemData itemData2 = inventoryData.EquipmentItems.Find((ItemData x) => x.UniqueId == GetCurPathInfo().EquipId);
			displayAvatarDetailInfo.Equipment = itemData2.ToDisplayEquipmentProto();
		}
		foreach (KeyValuePair<int, int> item2 in GetCurPathInfo().GetSkillTree())
		{
			displayAvatarDetailInfo.SkilltreeList.Add(new AvatarSkillTree
			{
				PointId = (uint)item2.Key,
				Level = (uint)item2.Value
			});
		}
		return displayAvatarDetailInfo;
	}
}
