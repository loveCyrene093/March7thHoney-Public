using System;
using System.Collections.Generic;
using March7thHoney.Database.Inventory;
using March7thHoney.Util;
using Newtonsoft.Json;

namespace March7thHoney.Data.Excel;

[ResourceEntity("MonsterDrop.json")]
public class MonsterDropExcel : ExcelResource
{
	public int MonsterTemplateID { get; set; }

	public int WorldLevel { get; set; }

	public int AvatarExpReward { get; set; }

	public List<MonsterDropItem> DisplayItemList { get; set; } = new List<MonsterDropItem>();

	[JsonIgnore]
	public List<MonsterDropItem> DropItemList { get; set; } = new List<MonsterDropItem>();

	public override int GetId()
	{
		return MonsterTemplateID * 10 + WorldLevel;
	}

	public override void AfterAllDone()
	{
		foreach (MonsterDropItem displayItem in DisplayItemList)
		{
			GameData.ItemConfigData.TryGetValue(displayItem.ItemID, out ItemConfigExcel value);
			if (value != null)
			{
				double num = 1.0;
				double num2 = WorldLevel + 3;
				int maxCount = (int)(num2 * num);
				int minCount = (int)(num2 * num * 0.5);
				displayItem.MinCount = minCount;
				displayItem.MaxCount = maxCount;
				DropItemList.Add(displayItem);
			}
		}
		GameData.MonsterDropData.Add(GetId(), this);
	}

	public List<ItemData> CalculateDrop()
	{
		List<ItemData> list = new List<ItemData>();
		foreach (MonsterDropItem dropItem in DropItemList)
		{
			int num = Random.Shared.Next(dropItem.MinCount, dropItem.MaxCount + 1);
			list.Add(new ItemData
			{
				ItemId = dropItem.ItemID,
				Count = num * ConfigManager.Config.ServerOption.ValidFarmingDropRate()
			});
		}
		return list;
	}
}
