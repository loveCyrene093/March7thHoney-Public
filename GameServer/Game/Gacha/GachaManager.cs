using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Custom;
using March7thHoney.Data.Excel;
using March7thHoney.Database;
using March7thHoney.Database.Avatar;
using March7thHoney.Database.Gacha;
using March7thHoney.Database.Inventory;
using March7thHoney.Enums;
using March7thHoney.Enums.Item;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.PlayerSync;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.Gacha;

public class GachaManager : BasePlayerManager
{
	public GachaData GachaData { get; }

	public GachaManager(PlayerInstance player)
		: base(player)
	{
		GachaData = DatabaseHelper.Instance.GetInstanceOrCreateNew<GachaData>(player.Uid);
		if (GachaData.GachaHistory.Count >= 50)
		{
			GachaData.GachaHistory.RemoveRange(0, GachaData.GachaHistory.Count - 50);
		}
		foreach (DecideAvatarOrderExcel item in from x in GameData.DecideAvatarOrderData.Values.ToList()
			orderby -x.Order
			select x)
		{
			if (!GachaData.GachaDecideOrder.Contains(item.ItemID))
			{
				GachaData.GachaDecideOrder.Add(item.ItemID);
			}
		}
	}

	public List<int> GetPurpleAvatars()
	{
		List<int> list = new List<int>();
		foreach (AvatarConfigExcel value in GameData.AvatarConfigData.Values)
		{
			if (value.Rarity == RarityEnum.CombatPowerAvatarRarityType4 && (!GameData.MultiplePathAvatarConfigData.ContainsKey(value.AvatarID) || GameData.MultiplePathAvatarConfigData[value.AvatarID].BaseAvatarID == value.AvatarID) && value.MaxRank > 0)
			{
				list.Add(value.AvatarID);
			}
		}
		return list;
	}

	public List<int> GetGoldAvatars()
	{
		int num = 7;
		List<int> list = new List<int>(num);
		CollectionsMarshal.SetCount(list, num);
		Span<int> span = CollectionsMarshal.AsSpan(list);
		span[0] = 1003;
		span[1] = 1004;
		span[2] = 1101;
		span[3] = 1107;
		span[4] = 1104;
		span[5] = 1209;
		span[6] = 1211;
		return list;
	}

	public List<int> GetAllGoldAvatars()
	{
		List<int> list = new List<int>();
		foreach (AvatarConfigExcel value in GameData.AvatarConfigData.Values)
		{
			if (value.Rarity == RarityEnum.CombatPowerAvatarRarityType5)
			{
				list.Add(value.AvatarID);
			}
		}
		return list;
	}

	public List<int> GetBlueWeapons()
	{
		List<int> list = new List<int>();
		foreach (EquipmentConfigExcel value in GameData.EquipmentConfigData.Values)
		{
			if (value.Rarity == RarityEnum.CombatPowerLightconeRarity3)
			{
				list.Add(value.EquipmentID);
			}
		}
		return list;
	}

	public List<int> GetPurpleWeapons()
	{
		List<int> list = new List<int>();
		foreach (EquipmentConfigExcel value in GameData.EquipmentConfigData.Values)
		{
			if (value.Rarity == RarityEnum.CombatPowerLightconeRarity4)
			{
				list.Add(value.EquipmentID);
			}
		}
		return list;
	}

	public List<int> GetGoldWeapons()
	{
		int num = 7;
		List<int> list = new List<int>(num);
		CollectionsMarshal.SetCount(list, num);
		Span<int> span = CollectionsMarshal.AsSpan(list);
		span[0] = 23000;
		span[1] = 23002;
		span[2] = 23003;
		span[3] = 23004;
		span[4] = 23005;
		span[5] = 23012;
		span[6] = 23013;
		return list;
	}

	public List<int> GetAllGoldWeapons()
	{
		List<int> list = new List<int>();
		foreach (EquipmentConfigExcel value in GameData.EquipmentConfigData.Values)
		{
			if (value.Rarity == RarityEnum.CombatPowerLightconeRarity5)
			{
				list.Add(value.EquipmentID);
			}
		}
		return list;
	}

	public int GetRarity(int itemId)
	{
		if (GetAllGoldAvatars().Contains(itemId) || GetAllGoldWeapons().Contains(itemId))
		{
			return 5;
		}
		if (GetPurpleAvatars().Contains(itemId) || GetPurpleWeapons().Contains(itemId))
		{
			return 4;
		}
		if (GetBlueWeapons().Contains(itemId))
		{
			return 3;
		}
		return 0;
	}

	public int GetType(int itemId)
	{
		if (GetAllGoldAvatars().Contains(itemId) || GetPurpleAvatars().Contains(itemId))
		{
			return 1;
		}
		if (GetAllGoldWeapons().Contains(itemId) || GetPurpleWeapons().Contains(itemId) || GetBlueWeapons().Contains(itemId))
		{
			return 2;
		}
		return 0;
	}

	public async ValueTask<DoGachaScRsp?> DoGacha(int bannerId, int times)
	{
		BannerConfig bannerConfig = GameData.BannersConfig.Banners.Find((BannerConfig x) => x.GachaId == bannerId);
		if (bannerConfig == null)
		{
			return null;
		}
		base.Player.InventoryManager?.RemoveItem(bannerConfig.GachaType.GetCostItemId(), times);
		List<int> range = GachaData.GachaDecideOrder.GetRange(0, 7);
		List<int> list = new List<int>();
		for (int num = 0; num < times; num++)
		{
			int item = bannerConfig.DoGacha(range, GetPurpleAvatars(), GetPurpleWeapons(), GetGoldWeapons(), GetBlueWeapons(), GachaData);
			list.Add(item);
		}
		List<GachaItem> gachaItems = new List<GachaItem>();
		List<ItemData> syncItems = new List<ItemData>();
		foreach (int item2 in list)
		{
			int dirt = 0;
			int star = 0;
			int rarity = GetRarity(item2);
			GachaData.GachaHistory.Add(new March7thHoney.Database.Gacha.GachaInfo
			{
				GachaId = bannerId,
				ItemId = item2,
				Time = DateTimeOffset.UtcNow.ToUnixTimeSeconds()
			});
			GachaItem gachaItem = new GachaItem();
			switch (rarity)
			{
			case 5:
				if (GetType(item2) == 1)
				{
					FormalAvatarInfo formalAvatarInfo2 = base.Player.AvatarManager?.GetFormalAvatar(item2);
					if (formalAvatarInfo2 != null)
					{
						star += 40;
						int itemId2 = item2 + 10000;
						ItemData? item4 = base.Player.InventoryManager.GetItem(itemId2);
						if (formalAvatarInfo2.PathInfos[item2].Rank + item4?.Count >= 6)
						{
							star += 60;
							break;
						}
						ItemList itemList2 = new ItemList();
						itemList2.ItemList_.Add(new Item
						{
							ItemId = (uint)itemId2,
							Num = 1u
						});
						gachaItem.TransferItemList = itemList2;
					}
				}
				else
				{
					star += 20;
				}
				break;
			case 4:
				if (GetType(item2) == 1)
				{
					FormalAvatarInfo formalAvatarInfo = base.Player.AvatarManager?.GetFormalAvatar(item2);
					if (formalAvatarInfo != null)
					{
						star += 8;
						int itemId = item2 + 10000;
						ItemData? item3 = base.Player.InventoryManager.GetItem(itemId);
						if (formalAvatarInfo.PathInfos[item2].Rank + item3?.Count >= 6)
						{
							star += 12;
							break;
						}
						ItemList itemList = new ItemList();
						itemList.ItemList_.Add(new Item
						{
							ItemId = (uint)itemId,
							Num = 1u
						});
						gachaItem.TransferItemList = itemList;
					}
				}
				else
				{
					star += 8;
				}
				break;
			default:
				dirt += 20;
				break;
			}
			ItemData i;
			if (GameData.ItemConfigData[item2].ItemMainType == ItemMainTypeEnum.AvatarCard && base.Player.AvatarManager.GetFormalAvatar(item2) == null)
			{
				i = null;
				await base.Player.AvatarManager.AddAvatar(item2, sync: true, notify: true, isGacha: true);
			}
			else
			{
				i = await base.Player.InventoryManager.AddItem(item2, 1, notify: false, 1, 1, sync: false, returnRaw: true);
			}
			if (i != null)
			{
				syncItems.Add(i);
			}
			gachaItem.GachaItem_ = new Item
			{
				ItemId = (uint)item2,
				Num = 1u,
				Level = 1u,
				Rank = 1u
			};
			ItemList tokenItem = new ItemList();
			if (dirt > 0)
			{
				ItemData itemData = await base.Player.InventoryManager.AddItem(251, dirt, notify: false, 1, 1, sync: false, returnRaw: true);
				if (itemData != null)
				{
					ItemData itemData2 = syncItems.Find((ItemData x) => x.ItemId == 251);
					if (itemData2 == null)
					{
						syncItems.Add(itemData);
					}
					else
					{
						itemData2.Count = itemData.Count;
					}
				}
				tokenItem.ItemList_.Add(new Item
				{
					ItemId = 251u,
					Num = (uint)dirt
				});
			}
			if (star > 0)
			{
				ItemData itemData3 = await base.Player.InventoryManager.AddItem(252, star, notify: false, 1, 1, sync: false, returnRaw: true);
				if (itemData3 != null)
				{
					ItemData itemData4 = syncItems.Find((ItemData x) => x.ItemId == 252);
					if (itemData4 == null)
					{
						syncItems.Add(itemData3);
					}
					else
					{
						itemData4.Count = itemData3.Count;
					}
				}
				tokenItem.ItemList_.Add(new Item
				{
					ItemId = 252u,
					Num = (uint)star
				});
			}
			gachaItem.TokenItem = tokenItem;
			GachaItem gachaItem2 = gachaItem;
			if (gachaItem2.TransferItemList == null)
			{
				gachaItem2.TransferItemList = new ItemList();
			}
			gachaItems.Add(gachaItem);
		}
		await base.Player.SendPacket(new PacketPlayerSyncScNotify(syncItems));
		DoGachaScRsp doGachaScRsp = new DoGachaScRsp();
		doGachaScRsp.GachaId = (uint)bannerId;
		doGachaScRsp.GachaNum = (uint)times;
		doGachaScRsp.GachaItemList.AddRange(gachaItems);
		return doGachaScRsp;
	}

	public GetGachaInfoScRsp ToProto()
	{
		GetGachaInfoScRsp getGachaInfoScRsp = new GetGachaInfoScRsp
		{
			GachaRandom = (uint)Random.Shared.Next(1000, 1999)
		};
		foreach (BannerConfig banner in GameData.BannersConfig.Banners)
		{
			getGachaInfoScRsp.GachaInfoList.Add(banner.ToInfo(GachaData.GachaDecideOrder, GetGoldAvatars()));
		}
		return getGachaInfoScRsp;
	}
}
