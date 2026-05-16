using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Inventory;
using March7thHoney.Enums.Item;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.Shop;

public class ShopService : BasePlayerManager
{
	public ShopService(PlayerInstance player)
		: base(player)
	{
	}

	public async ValueTask<List<ItemData>> BuyItem(int shopId, int goodsId, int count)
	{
		GameData.ShopConfigData.TryGetValue(shopId, out ShopConfigExcel value);
		if (value == null)
		{
			return new List<ItemData>();
		}
		ShopGoodsConfigExcel goods = value.Goods.Find((ShopGoodsConfigExcel g) => g.GoodsID == goodsId);
		if (goods == null)
		{
			return new List<ItemData>();
		}
		GameData.ItemConfigData.TryGetValue(goods.ItemID, out ItemConfigExcel itemConfig);
		if (itemConfig == null)
		{
			return new List<ItemData>();
		}
		foreach (KeyValuePair<int, int> cost in goods.CostList)
		{
			await base.Player.InventoryManager.RemoveItem(cost.Key, cost.Value * count);
		}
		List<ItemData> items = new List<ItemData>();
		ItemMainTypeEnum itemMainType = itemConfig.ItemMainType;
		if ((uint)(itemMainType - 3) <= 1u)
		{
			for (int i = 0; i < count; i++)
			{
				ItemData itemData = await base.Player.InventoryManager.AddItem(itemConfig.ID, 1, notify: false);
				if (itemData != null)
				{
					items.Add(itemData);
				}
			}
		}
		else
		{
			ItemData itemData2 = await base.Player.InventoryManager.AddItem(itemConfig.ID, count, notify: false);
			if (itemData2 != null)
			{
				if (GameData.ItemUseDataData.TryGetValue(itemData2.ItemId, out ItemUseDataExcel value2) && value2.IsAutoUse)
				{
					(Retcode, List<ItemData>) tuple = await base.Player.InventoryManager.UseItem(itemData2.ItemId);
					if (tuple.Item2 != null)
					{
						items.AddRange(tuple.Item2);
					}
				}
				else
				{
					items.Add(itemData2);
				}
			}
		}
		await base.Player.MissionManager.HandleFinishType(MissionFinishTypeEnum.BuyShopGoods, goods);
		return items;
	}
}
