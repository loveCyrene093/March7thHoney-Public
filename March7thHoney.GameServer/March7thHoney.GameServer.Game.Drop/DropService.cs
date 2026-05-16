using System;
using System.Collections.Generic;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Inventory;
using March7thHoney.Enums.Scene;

namespace March7thHoney.GameServer.Game.Drop;

public class DropService
{
	public static List<ItemData> CalculateDropsFromProp(int chestId)
	{
		List<ItemData> list = new List<ItemData>();
		MazeChestExcel valueOrDefault = GameData.MazeChestData.GetValueOrDefault(chestId);
		if (valueOrDefault == null)
		{
			return list;
		}
		ChestTypeEnum chestTypeEnum = ChestTypeEnum.CHEST_NONE;
		if (valueOrDefault.ChestType.Contains(ChestTypeEnum.CHEST_HIGH_LEVEL))
		{
			chestTypeEnum = ChestTypeEnum.CHEST_HIGH_LEVEL;
		}
		else if (valueOrDefault.ChestType.Contains(ChestTypeEnum.CHEST_MIDDLE_LEVEL))
		{
			chestTypeEnum = ChestTypeEnum.CHEST_MIDDLE_LEVEL;
		}
		else if (valueOrDefault.ChestType.Contains(ChestTypeEnum.CHEST_LOW_LEVEL))
		{
			chestTypeEnum = ChestTypeEnum.CHEST_LOW_LEVEL;
		}
		ChestTypeEnum chestTypeEnum2 = ChestTypeEnum.CHEST_NONE;
		if (valueOrDefault.ChestType.Contains(ChestTypeEnum.CHEST_WORLD_ONE))
		{
			chestTypeEnum2 = ChestTypeEnum.CHEST_WORLD_ONE;
		}
		else if (valueOrDefault.ChestType.Contains(ChestTypeEnum.CHEST_WORLD_TWO))
		{
			chestTypeEnum2 = ChestTypeEnum.CHEST_WORLD_TWO;
		}
		else if (valueOrDefault.ChestType.Contains(ChestTypeEnum.CHEST_WORLD_THREE))
		{
			chestTypeEnum2 = ChestTypeEnum.CHEST_WORLD_THREE;
		}
		else if (valueOrDefault.ChestType.Contains(ChestTypeEnum.CHEST_WORLD_ZERO))
		{
			chestTypeEnum2 = ChestTypeEnum.CHEST_WORLD_ZERO;
		}
		else if (valueOrDefault.ChestType.Contains(ChestTypeEnum.CHEST_WORLD_FOUR))
		{
			chestTypeEnum2 = ChestTypeEnum.CHEST_WORLD_FOUR;
		}
		List<ItemData> list2 = list;
		ItemData itemData = new ItemData();
		itemData.ItemId = 1;
		ItemData itemData2 = itemData;
		itemData2.Count = chestTypeEnum switch
		{
			ChestTypeEnum.CHEST_LOW_LEVEL => 5, 
			ChestTypeEnum.CHEST_MIDDLE_LEVEL => 20, 
			ChestTypeEnum.CHEST_HIGH_LEVEL => 40, 
			_ => 5, 
		};
		list2.Add(itemData);
		list.Add(new ItemData
		{
			ItemId = 212,
			Count = Random.Shared.Next(3, 6)
		});
		list.Add(new ItemData
		{
			ItemId = 222,
			Count = Random.Shared.Next(3, 6)
		});
		list.Add(new ItemData
		{
			ItemId = 232,
			Count = Random.Shared.Next(3, 6)
		});
		switch (chestTypeEnum2)
		{
		case ChestTypeEnum.CHEST_WORLD_ONE:
			list2 = list;
			itemData2 = new ItemData();
			itemData2.ItemId = 120001;
			itemData = itemData2;
			itemData.Count = chestTypeEnum switch
			{
				ChestTypeEnum.CHEST_LOW_LEVEL => 20, 
				ChestTypeEnum.CHEST_MIDDLE_LEVEL => 40, 
				ChestTypeEnum.CHEST_HIGH_LEVEL => 60, 
				_ => 20, 
			};
			list2.Add(itemData2);
			break;
		case ChestTypeEnum.CHEST_WORLD_TWO:
			list2 = list;
			itemData = new ItemData();
			itemData.ItemId = 120002;
			itemData2 = itemData;
			itemData2.Count = chestTypeEnum switch
			{
				ChestTypeEnum.CHEST_LOW_LEVEL => 5, 
				ChestTypeEnum.CHEST_MIDDLE_LEVEL => 10, 
				ChestTypeEnum.CHEST_HIGH_LEVEL => 20, 
				_ => 5, 
			};
			list2.Add(itemData);
			break;
		case ChestTypeEnum.CHEST_WORLD_THREE:
			list2 = list;
			itemData2 = new ItemData();
			itemData2.ItemId = 120003;
			itemData = itemData2;
			itemData.Count = chestTypeEnum switch
			{
				ChestTypeEnum.CHEST_LOW_LEVEL => 60, 
				ChestTypeEnum.CHEST_MIDDLE_LEVEL => 90, 
				ChestTypeEnum.CHEST_HIGH_LEVEL => 120, 
				_ => 60, 
			};
			list2.Add(itemData2);
			break;
		case ChestTypeEnum.CHEST_WORLD_ZERO:
			list2 = list;
			itemData = new ItemData();
			itemData.ItemId = 120000;
			itemData2 = itemData;
			itemData2.Count = chestTypeEnum switch
			{
				ChestTypeEnum.CHEST_LOW_LEVEL => 10, 
				ChestTypeEnum.CHEST_MIDDLE_LEVEL => 20, 
				ChestTypeEnum.CHEST_HIGH_LEVEL => 50, 
				_ => 10, 
			};
			list2.Add(itemData);
			break;
		case ChestTypeEnum.CHEST_WORLD_FOUR:
			list2 = list;
			itemData2 = new ItemData();
			itemData2.ItemId = 120004;
			itemData = itemData2;
			itemData.Count = chestTypeEnum switch
			{
				ChestTypeEnum.CHEST_LOW_LEVEL => 60, 
				ChestTypeEnum.CHEST_MIDDLE_LEVEL => 90, 
				ChestTypeEnum.CHEST_HIGH_LEVEL => 120, 
				_ => 60, 
			};
			list2.Add(itemData2);
			break;
		}
		list2 = list;
		itemData = new ItemData();
		itemData.ItemId = 2;
		itemData2 = itemData;
		itemData2.Count = chestTypeEnum switch
		{
			ChestTypeEnum.CHEST_LOW_LEVEL => 750, 
			ChestTypeEnum.CHEST_MIDDLE_LEVEL => 3700, 
			ChestTypeEnum.CHEST_HIGH_LEVEL => 6000, 
			_ => 750, 
		};
		list2.Add(itemData);
		return list;
	}
}
