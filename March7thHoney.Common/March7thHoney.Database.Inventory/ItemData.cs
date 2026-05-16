using System;
using System.Collections.Generic;
using System.Linq;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Enums.Avatar;
using March7thHoney.Enums.Item;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.Database.Inventory;

public class ItemData
{
	public int UniqueId { get; set; }

	public int ItemId { get; set; }

	public int Count { get; set; }

	public int Level { get; set; }

	public int Exp { get; set; }

	public int TotalExp { get; set; }

	public int Promotion { get; set; }

	public int Rank { get; set; }

	public bool Locked { get; set; }

	public bool Discarded { get; set; }

	public int MainAffix { get; set; }

	public List<ItemSubAffix> SubAffixes { get; set; } = new List<ItemSubAffix>();

	public List<ItemSubAffix> ReforgeSubAffixes { get; set; } = new List<ItemSubAffix>();

	public int EquipAvatar { get; set; }

	public int CalcTotalExpGained()
	{
		if (Level <= 0)
		{
			return Exp;
		}
		GameData.RelicConfigData.TryGetValue(ItemId, out RelicConfigExcel value);
		if (value == null)
		{
			return 0;
		}
		int num = 0;
		for (int i = 0; i < Level; i++)
		{
			GameData.RelicExpTypeData.TryGetValue(value.ExpType * 100 + i, out RelicExpTypeExcel value2);
			if (value2 != null)
			{
				num += value2.Exp;
			}
		}
		return num + Exp;
	}

	public void AddRandomRelicMainAffix()
	{
		GameData.RelicConfigData.TryGetValue(ItemId, out RelicConfigExcel value);
		if (value == null)
		{
			return;
		}
		GameData.RelicMainAffixData.TryGetValue(value.MainAffixGroup, out Dictionary<int, RelicMainAffixConfigExcel> value2);
		if (value2 != null)
		{
			List<int> list = new List<int>();
			list.AddRange(value2.Values.Select((RelicMainAffixConfigExcel affix) => affix.AffixID));
			MainAffix = list.RandomElement();
		}
	}

	public void AddRelicSubAffix(List<(int, int)> subAffixes)
	{
		GameData.RelicConfigData.TryGetValue(ItemId, out RelicConfigExcel value);
		if (value == null)
		{
			return;
		}
		Dictionary<int, RelicSubAffixConfigExcel> dictionary = GameData.RelicSubAffixData[value.SubAffixGroup];
		foreach (var (key, count) in subAffixes)
		{
			if (dictionary.TryGetValue(key, out var value2))
			{
				SubAffixes.Add(new ItemSubAffix(value2, count));
			}
		}
	}

	public void AddRandomRelicSubAffix(int count = 1)
	{
		if (count <= 0 || MainAffix == 0)
		{
			return;
		}
		GameData.RelicConfigData.TryGetValue(ItemId, out RelicConfigExcel value);
		if (value == null)
		{
			return;
		}
		AvatarPropertyTypeEnum property = GameData.RelicMainAffixData[value.MainAffixGroup][MainAffix].Property;
		Dictionary<int, RelicSubAffixConfigExcel> dictionary = GameData.RelicSubAffixData[value.SubAffixGroup];
		List<int> values = dictionary.Keys.ToList();
		while (count > 0)
		{
			int subId = values.RandomElement();
			if (!SubAffixes.Any((ItemSubAffix x) => x.Id == subId) && dictionary[subId].Property != property)
			{
				SubAffixes.Add(new ItemSubAffix(dictionary[subId], 1));
				count--;
			}
		}
	}

	public void IncreaseRandomRelicSubAffix(int times = 1)
	{
		if (times <= 0)
		{
			return;
		}
		GameData.RelicConfigData.TryGetValue(ItemId, out RelicConfigExcel value);
		if (value == null)
		{
			return;
		}
		GameData.RelicSubAffixData.TryGetValue(value.SubAffixGroup, out Dictionary<int, RelicSubAffixConfigExcel> value2);
		if (value2 == null)
		{
			return;
		}
		for (int i = 0; i < times; i++)
		{
			ItemSubAffix element = SubAffixes.RandomElement();
			RelicSubAffixConfigExcel relicSubAffixConfigExcel = value2.Values.ToList().Find((RelicSubAffixConfigExcel x) => x.AffixID == element.Id);
			if (relicSubAffixConfigExcel == null)
			{
				break;
			}
			element.IncreaseStep(relicSubAffixConfigExcel.StepNum);
		}
	}

	public void InitRandomRelicSubAffixesByRarity(ItemRarityEnum rarity = ItemRarityEnum.Unknown)
	{
		if (rarity == ItemRarityEnum.Unknown)
		{
			GameData.ItemConfigData.TryGetValue(ItemId, out ItemConfigExcel value);
			if (value == null)
			{
				return;
			}
			rarity = value.Rarity;
		}
		int count;
		switch (rarity)
		{
		default:
			return;
		case ItemRarityEnum.Rare:
			count = 1 + LuckyRelicSubAffixCount();
			break;
		case ItemRarityEnum.VeryRare:
			count = 2 + LuckyRelicSubAffixCount();
			break;
		case ItemRarityEnum.SuperRare:
			count = 3 + LuckyRelicSubAffixCount();
			break;
		}
		AddRandomRelicSubAffix(count);
	}

	public int LuckyRelicSubAffixCount()
	{
		return (Random.Shared.Next(100) < 20) ? 1 : 0;
	}

	public Material ToMaterialProto()
	{
		return new Material
		{
			Tid = (uint)ItemId,
			Num = (uint)Count
		};
	}

	public Relic ToRelicProto()
	{
		Relic relic = new Relic
		{
			Tid = (uint)ItemId,
			UniqueId = (uint)UniqueId,
			Level = (uint)Level,
			IsProtected = Locked,
			Exp = (uint)Exp,
			IsDiscarded = Discarded,
			DressAvatarId = (uint)EquipAvatar,
			MainAffixId = (uint)MainAffix
		};
		if (SubAffixes.Count > 0)
		{
			foreach (ItemSubAffix subAffix in SubAffixes)
			{
				relic.SubAffixList.Add(subAffix.ToProto());
			}
		}
		if (ReforgeSubAffixes.Count > 0)
		{
			foreach (ItemSubAffix reforgeSubAffix in ReforgeSubAffixes)
			{
				relic.ReforgeSubAffixList.Add(reforgeSubAffix.ToProto());
			}
		}
		return relic;
	}

	public Equipment ToEquipmentProto()
	{
		return new Equipment
		{
			Tid = (uint)ItemId,
			UniqueId = (uint)UniqueId,
			Level = (uint)Level,
			Exp = (uint)Exp,
			IsProtected = Locked,
			Promotion = (uint)Promotion,
			Rank = (uint)Rank,
			DressAvatarId = (uint)EquipAvatar
		};
	}

	public ChallengeBossEquipmentInfo ToChallengeEquipmentProto()
	{
		return new ChallengeBossEquipmentInfo
		{
			Tid = (uint)ItemId,
			UniqueId = (uint)UniqueId,
			Level = (uint)Level,
			Promotion = (uint)Promotion,
			Rank = (uint)Rank
		};
	}

	public ChallengeBossRelicInfo ToChallengeRelicProto()
	{
		ChallengeBossRelicInfo challengeBossRelicInfo = new ChallengeBossRelicInfo
		{
			Tid = (uint)ItemId,
			UniqueId = (uint)UniqueId,
			Level = (uint)Level,
			MainAffixId = (uint)MainAffix
		};
		if (SubAffixes.Count < 1)
		{
			return challengeBossRelicInfo;
		}
		foreach (ItemSubAffix subAffix in SubAffixes)
		{
			challengeBossRelicInfo.SubAffixList.Add(subAffix.ToProto());
		}
		return challengeBossRelicInfo;
	}

	public Item ToProto()
	{
		return new Item
		{
			ItemId = (uint)ItemId,
			Num = (uint)Count,
			Level = (uint)Level,
			MainAffixId = (uint)MainAffix,
			Rank = (uint)Rank,
			Promotion = (uint)Promotion,
			UniqueId = (uint)UniqueId
		};
	}

	public PileItem ToPileProto()
	{
		return new PileItem
		{
			ItemId = (uint)ItemId,
			ItemNum = (uint)Count
		};
	}

	public DisplayEquipmentInfo ToDisplayEquipmentProto()
	{
		return new DisplayEquipmentInfo
		{
			Tid = (uint)ItemId,
			Level = (uint)Level,
			Exp = (uint)Exp,
			Promotion = (uint)Promotion,
			Rank = (uint)Rank
		};
	}

	public DisplayRelicInfo ToDisplayRelicProto()
	{
		DisplayRelicInfo displayRelicInfo = new DisplayRelicInfo
		{
			Tid = (uint)ItemId,
			Level = (uint)Level,
			Type = (uint)GameData.RelicConfigData[ItemId].Type,
			MainAffixId = (uint)MainAffix
		};
		if (SubAffixes.Count >= 1)
		{
			foreach (ItemSubAffix subAffix in SubAffixes)
			{
				displayRelicInfo.SubAffixList.Add(subAffix.ToProto());
			}
		}
		return displayRelicInfo;
	}

	public ItemData Clone()
	{
		return new ItemData
		{
			UniqueId = UniqueId,
			ItemId = ItemId,
			Count = Count,
			Level = Level,
			Exp = Exp,
			TotalExp = TotalExp,
			Promotion = Promotion,
			Rank = Rank,
			Locked = Locked,
			Discarded = Discarded,
			MainAffix = MainAffix,
			SubAffixes = SubAffixes.Select((ItemSubAffix x) => x.Clone()).ToList(),
			ReforgeSubAffixes = ReforgeSubAffixes.Select((ItemSubAffix x) => x.Clone()).ToList(),
			EquipAvatar = EquipAvatar
		};
	}
}
