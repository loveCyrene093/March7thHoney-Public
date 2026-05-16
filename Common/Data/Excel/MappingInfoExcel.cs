using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using March7thHoney.Database.Inventory;
using March7thHoney.Enums.Item;
using March7thHoney.Util;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Excel;

[ResourceEntity("MappingInfo.json")]
public class MappingInfoExcel : ExcelResource
{
	public int ID { get; set; }

	public int WorldLevel { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public FarmTypeEnum FarmType { get; set; } = FarmTypeEnum.COCOON;

	public List<MappingInfoItem> DisplayItemList { get; set; } = new List<MappingInfoItem>();

	[JsonIgnore]
	public List<MappingInfoItem> DropItemList { get; set; } = new List<MappingInfoItem>();

	[JsonIgnore]
	public List<MappingInfoItem> DropRelicItemList { get; set; } = new List<MappingInfoItem>();

	public override int GetId()
	{
		return ID * 10 + WorldLevel;
	}

	public override void Loaded()
	{
		GameData.MappingInfoData.Add(GetId(), this);
		if (DisplayItemList.Count == 0)
		{
			return;
		}
		List<int> list = new List<int>();
		Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
		foreach (MappingInfoItem displayItem in DisplayItemList)
		{
			if (displayItem.ItemNum > 0)
			{
				DropItemList.Add(displayItem);
				continue;
			}
			if (displayItem.ItemID == 2)
			{
				DropItemList.Add(new MappingInfoItem
				{
					ItemID = 2,
					MinCount = (50 + WorldLevel * 10) * (int)FarmType,
					MaxCount = (100 + WorldLevel * 10) * (int)FarmType
				});
				continue;
			}
			GameData.ItemConfigData.TryGetValue(displayItem.ItemID, out ItemConfigExcel value);
			if (value == null)
			{
				continue;
			}
			if (value.ItemSubType == ItemSubTypeEnum.RelicSetShowOnly)
			{
				int num = displayItem.ItemID / 10 % 1000;
				int num2 = displayItem.ItemID % 10;
				int i = 20001 + num2 * 10000 + num * 10;
				for (int num3 = i + 3; i <= num3; i++)
				{
					GameData.ItemConfigData.TryGetValue(i, out ItemConfigExcel value2);
					if (value2 == null)
					{
						break;
					}
					if (!dictionary.TryGetValue(num2, out var _))
					{
						List<int> value4 = new List<int>();
						dictionary[num2] = value4;
					}
					dictionary[num2].Add(i);
				}
			}
			else if (value.ItemMainType == ItemMainTypeEnum.Material)
			{
				MappingInfoItem mappingInfoItem;
				switch (value.PurposeType)
				{
				case 1:
				{
					double num5 = value.Rarity switch
					{
						ItemRarityEnum.NotNormal => (WorldLevel < 3) ? ((double)(WorldLevel + 3)) : 2.5, 
						ItemRarityEnum.Rare => (WorldLevel < 3) ? (WorldLevel + 3) : (WorldLevel * 2 - 3), 
						_ => 1.0, 
					};
					mappingInfoItem = new MappingInfoItem(value.ID, (int)num5);
					break;
				}
				case 2:
					mappingInfoItem = new MappingInfoItem(value.ID, WorldLevel);
					break;
				case 3:
					mappingInfoItem = new MappingInfoItem(value.ID, 5);
					break;
				case 4:
					mappingInfoItem = new MappingInfoItem(value.ID, (int)((double)WorldLevel * 0.5 + 0.5));
					break;
				case 5:
				{
					double num4 = value.Rarity switch
					{
						ItemRarityEnum.NotNormal => Math.Max(5 - WorldLevel, 2.5), 
						ItemRarityEnum.Rare => WorldLevel % 3 + 1, 
						_ => 1.0, 
					};
					mappingInfoItem = new MappingInfoItem(value.ID, (int)num4);
					break;
				}
				case 11:
					mappingInfoItem = new MappingInfoItem(value.ID, 4 + WorldLevel);
					break;
				default:
					mappingInfoItem = null;
					break;
				}
				if (mappingInfoItem != null)
				{
					DropItemList.Add(mappingInfoItem);
				}
			}
			else if (value.ItemMainType == ItemMainTypeEnum.Equipment)
			{
				list.Add(value.ID);
			}
			if (list.Count > 0)
			{
				foreach (int item2 in list)
				{
					MappingInfoItem item = new MappingInfoItem(item2, 1)
					{
						Chance = WorldLevel * 10 + 40
					};
					DropItemList.Add(item);
				}
			}
			if (dictionary.Count <= 0)
			{
				continue;
			}
			foreach (KeyValuePair<int, List<int>> item3 in dictionary)
			{
				foreach (int item4 in item3.Value)
				{
					MappingInfoItem mappingInfoItem2 = new MappingInfoItem(item4, 1);
					double num6 = item3.Key switch
					{
						4 => (double)WorldLevel * 0.5 - 0.5, 
						3 => (double)WorldLevel * 0.5 + ((WorldLevel == 2) ? 1.0 : 0.0), 
						2 => (double)(6 - WorldLevel) + 0.5 - ((WorldLevel == 1) ? 3.75 : 0.0), 
						_ => (WorldLevel == 1) ? 6 : 2, 
					};
					if (num6 > 0.0)
					{
						mappingInfoItem2.ItemNum = (int)num6;
						DropRelicItemList.Add(mappingInfoItem2);
					}
				}
			}
		}
	}

	public List<ItemData> GenerateRelicDrops()
	{
		Dictionary<int, List<MappingInfoItem>> dictionary = new Dictionary<int, List<MappingInfoItem>>();
		foreach (MappingInfoItem dropRelicItem in DropRelicItemList)
		{
			GameData.ItemConfigData.TryGetValue(dropRelicItem.ItemID, out ItemConfigExcel value);
			if (value != null)
			{
				switch (value.Rarity)
				{
				case ItemRarityEnum.NotNormal:
					AddRelicToMap(dropRelicItem, 2, dictionary);
					break;
				case ItemRarityEnum.Rare:
					AddRelicToMap(dropRelicItem, 3, dictionary);
					break;
				case ItemRarityEnum.VeryRare:
					AddRelicToMap(dropRelicItem, 4, dictionary);
					break;
				case ItemRarityEnum.SuperRare:
					AddRelicToMap(dropRelicItem, 5, dictionary);
					break;
				}
			}
		}
		List<ItemData> list = new List<ItemData>();
		for (int num = 5; num >= 2; num--)
		{
			int num2 = GetRelicCountByWorldLevel(num) * ConfigManager.Config.ServerOption.ValidFarmingDropRate();
			if (num2 > 0 && dictionary.TryGetValue(num, out var value2) && !value2.IsNullOrEmpty())
			{
				while (num2 > 0)
				{
					MappingInfoItem mappingInfoItem = value2.RandomElement();
					list.Add(new ItemData
					{
						ItemId = mappingInfoItem.ItemID,
						Count = 1
					});
					num2--;
				}
			}
		}
		return list;
	}

	private void AddRelicToMap(MappingInfoItem relic, int rarity, Dictionary<int, List<MappingInfoItem>> relicsMap)
	{
		if (relicsMap.TryGetValue(rarity, out List<MappingInfoItem> value))
		{
			value.Add(relic);
			return;
		}
		int num = 1;
		List<MappingInfoItem> list = new List<MappingInfoItem>(num);
		CollectionsMarshal.SetCount(list, num);
		CollectionsMarshal.AsSpan(list)[0] = relic;
		relicsMap.Add(rarity, list);
	}

	private int GetRelicCountByWorldLevel(int rarity)
	{
		return WorldLevel switch
		{
			1 => rarity switch
			{
				2 => 6, 
				3 => 3, 
				4 => 1, 
				5 => 0, 
				_ => 0, 
			}, 
			2 => rarity switch
			{
				2 => 2, 
				3 => 4, 
				4 => 2 + LuckyRelicDropped(), 
				5 => 0, 
				_ => 0, 
			}, 
			3 => rarity switch
			{
				2 => 0, 
				3 => 4, 
				4 => 2, 
				5 => 1, 
				_ => 0, 
			}, 
			4 => rarity switch
			{
				2 => 0, 
				3 => 3, 
				4 => 2 + LuckyRelicDropped(), 
				5 => 1 + LuckyRelicDropped(), 
				_ => 0, 
			}, 
			5 => rarity switch
			{
				2 => 0, 
				3 => 1 + LuckyRelicDropped(), 
				4 => 3, 
				5 => 2, 
				_ => 0, 
			}, 
			6 => rarity switch
			{
				2 => 0, 
				3 => 0, 
				4 => 5, 
				5 => 2 + LuckyRelicDropped(), 
				_ => 0, 
			}, 
			_ => 0, 
		};
	}

	private int LuckyRelicDropped()
	{
		return (Random.Shared.Next(100) < 25) ? 1 : 0;
	}
}
