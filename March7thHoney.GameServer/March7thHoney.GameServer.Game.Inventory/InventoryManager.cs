using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Protobuf.Collections;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database;
using March7thHoney.Database.Avatar;
using March7thHoney.Database.Friend;
using March7thHoney.Database.Inventory;
using March7thHoney.Enums.Item;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Game.Scene;
using March7thHoney.GameServer.Server.Packet.Send.Avatar;
using March7thHoney.GameServer.Server.Packet.Send.Lineup;
using March7thHoney.GameServer.Server.Packet.Send.Phone;
using March7thHoney.GameServer.Server.Packet.Send.Player;
using March7thHoney.GameServer.Server.Packet.Send.PlayerSync;
using March7thHoney.GameServer.Server.Packet.Send.Scene;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.Inventory;

public class InventoryManager : BasePlayerManager
{
	public InventoryData Data;

	public InventoryManager(PlayerInstance player)
	{
		Data = DatabaseHelper.Instance.GetInstanceOrCreateNew<InventoryData>(player.Uid);
		base._002Ector(player);
	}

	public async ValueTask AddItem(ItemData itemData, bool notify = true)
	{
		await PutItem(itemData.ItemId, itemData.Count, itemData.Rank, itemData.Promotion, itemData.Level, itemData.Exp, itemData.TotalExp, itemData.MainAffix, itemData.SubAffixes, itemData.ReforgeSubAffixes, itemData.UniqueId);
		await base.Player.SendPacket(new PacketPlayerSyncScNotify(itemData));
		if (notify)
		{
			await base.Player.SendPacket(new PacketScenePlaneEventScNotify(itemData));
		}
	}

	public async ValueTask AddItems(List<ItemData> items, bool notify = true)
	{
		List<ItemData> syncItems = new List<ItemData>();
		foreach (ItemData item in items)
		{
			ItemData itemData = await AddItem(item.ItemId, item.Count, notify: false, 1, 1, 0, sync: false, returnRaw: true);
			if (itemData != null)
			{
				syncItems.Add(itemData);
			}
		}
		await base.Player.SendPacket(new PacketPlayerSyncScNotify(syncItems));
		if (notify)
		{
			await base.Player.SendPacket(new PacketScenePlaneEventScNotify(items));
		}
	}

	public async ValueTask<ItemData?> AddItem(int itemId, int count, bool notify = true, int rank = 1, int level = 1, int promotion = 0, bool sync = true, bool returnRaw = false)
	{
		GameData.ItemConfigData.TryGetValue(itemId, out ItemConfigExcel itemConfig);
		if (itemConfig == null)
		{
			return null;
		}
		ItemData itemData = null;
		switch (itemConfig.ItemMainType)
		{
		case ItemMainTypeEnum.Equipment:
			if (Data.EquipmentItems.Count + 1 > 1500)
			{
				await base.Player.SendPacket(new PacketRetcodeNotify(Retcode.RetEquipmentExceedLimit));
				break;
			}
			itemData = await PutItem(itemId, 1, rank, promotion, level, 0, 0, 0, null, null, ++Data.NextUniqueId);
			if (itemConfig.Rarity == ItemRarityEnum.SuperRare)
			{
				base.Player.FriendRecordData.AddAndRemoveOld(new FriendDevelopmentInfoPb
				{
					DevelopmentType = DevelopmentType.KghodpfjgliFbpdglpbbih,
					Params = { 
					{
						"EquipmentTid",
						(uint)itemConfig.ID
					} }
				});
			}
			break;
		case ItemMainTypeEnum.Usable:
			switch (itemConfig.ItemSubType)
			{
			case ItemSubTypeEnum.HeadIcon:
				if (!base.Player.PlayerUnlockData.HeadIcons.Contains(itemId))
				{
					base.Player.PlayerUnlockData.HeadIcons.Add(itemId);
					DatabaseHelper.ToSaveUidList.SafeAdd(base.Player.Uid);
				}
				break;
			case ItemSubTypeEnum.ChatBubble:
				if (!base.Player.PlayerUnlockData.ChatBubbles.Contains(itemId))
				{
					base.Player.PlayerUnlockData.ChatBubbles.Add(itemId);
					DatabaseHelper.ToSaveUidList.SafeAdd(base.Player.Uid);
					await base.Player.SendPacket(new PacketUnlockChatBubbleScNotify(itemId));
				}
				break;
			case ItemSubTypeEnum.PhoneTheme:
				if (!base.Player.PlayerUnlockData.PhoneThemes.Contains(itemId))
				{
					base.Player.PlayerUnlockData.PhoneThemes.Add(itemId);
					DatabaseHelper.ToSaveUidList.SafeAdd(base.Player.Uid);
					await base.Player.SendPacket(new PacketUnlockPhoneThemeScNotify(itemId));
				}
				break;
			case ItemSubTypeEnum.PersonalCard:
				if (!base.Player.PlayerUnlockData.PersonalCards.Contains(itemId))
				{
					base.Player.PlayerUnlockData.PersonalCards.Add(itemId);
					DatabaseHelper.ToSaveUidList.SafeAdd(base.Player.Uid);
				}
				break;
			case ItemSubTypeEnum.PhoneCase:
				if (!base.Player.PlayerUnlockData.PhoneCases.Contains(itemId))
				{
					base.Player.PlayerUnlockData.PhoneCases.Add(itemId);
					DatabaseHelper.ToSaveUidList.SafeAdd(base.Player.Uid);
					await base.Player.SendPacket(new PacketUnlockPhoneCaseScNotify(itemId));
				}
				break;
			case ItemSubTypeEnum.PlayerOutfit:
				itemData = await PutItem(itemId, count);
				break;
			case ItemSubTypeEnum.AvatarSkin:
			{
				if (GameData.AvatarSkinData.TryGetValue(itemId, out AvatarSkinExcel value))
				{
					int avatarID = value.AvatarID;
					if (!base.Player.PlayerUnlockData.Skins.TryGetValue(avatarID, out List<int> value2))
					{
						value2 = new List<int>();
						base.Player.PlayerUnlockData.Skins[avatarID] = value2;
					}
					if (!value2.Contains(itemId))
					{
						value2.Add(itemId);
						DatabaseHelper.ToSaveUidList.SafeAdd(base.Player.Uid);
						await base.Player.SendPacket(new PacketUnlockAvatarSkinScNotify(itemId));
					}
				}
				break;
			}
			case ItemSubTypeEnum.Gift:
			case ItemSubTypeEnum.Food:
			case ItemSubTypeEnum.ForceOpitonalGift:
			case ItemSubTypeEnum.Book:
			case ItemSubTypeEnum.FindChest:
				itemData = await PutItem(itemId, count);
				break;
			}
			if (itemData == null)
			{
				itemData = new ItemData
				{
					ItemId = itemId,
					Count = count
				};
			}
			break;
		case ItemMainTypeEnum.Relic:
			if (Data.RelicItems.Count + 1 > 1500)
			{
				await base.Player.SendPacket(new PacketRetcodeNotify(Retcode.RetRelicExceedLimit));
			}
			else
			{
				itemData = (await HandleRelic(itemId, ++Data.NextUniqueId, level, 0, null, sync)).Item2;
			}
			break;
		case ItemMainTypeEnum.Virtual:
		{
			int actualCount = 0;
			switch (itemConfig.ID)
			{
			case 1:
				base.Player.Data.Hcoin += count;
				actualCount = base.Player.Data.Hcoin;
				break;
			case 2:
				base.Player.Data.Scoin += count;
				actualCount = base.Player.Data.Scoin;
				break;
			case 3:
				base.Player.Data.Mcoin += count;
				actualCount = base.Player.Data.Mcoin;
				break;
			case 11:
				base.Player.Data.Stamina += count;
				actualCount = base.Player.Data.Stamina;
				break;
			case 22:
				base.Player.Data.Exp += count;
				base.Player.OnAddExp();
				actualCount = base.Player.Data.Exp;
				break;
			case 32:
				base.Player.Data.TalentPoints += count;
				break;
			}
			if (count != 0)
			{
				await base.Player.SendPacket(new PacketPlayerSyncScNotify(base.Player.ToProto()));
				itemData = new ItemData
				{
					ItemId = itemId,
					Count = actualCount
				};
			}
			break;
		}
		case ItemMainTypeEnum.AvatarCard:
		{
			FormalAvatarInfo formalAvatarInfo = base.Player.AvatarManager?.GetFormalAvatar(itemId);
			if (formalAvatarInfo != null)
			{
				ItemData? item = base.Player.InventoryManager.GetItem(itemId + 10000);
				if ((formalAvatarInfo.PathInfos[itemId].Rank + item?.Count).GetValueOrDefault() <= 5)
				{
					itemData = await PutItem(itemId + 10000, 1);
				}
			}
			else
			{
				await base.Player.AddAvatar(itemId, sync, notify);
				await AddItem(itemId + 200000, 1, notify: false);
			}
			break;
		}
		case ItemMainTypeEnum.Mission:
			itemData = await PutItem(itemId, count);
			break;
		default:
			itemData = await PutItem(itemId, Math.Min(count, itemConfig.PileLimit));
			break;
		}
		ItemData clone = null;
		if (itemData == null)
		{
			return returnRaw ? itemData : (clone ?? itemData);
		}
		clone = itemData.Clone();
		if (sync)
		{
			await base.Player.SendPacket(new PacketPlayerSyncScNotify(itemData));
		}
		clone.Count = count;
		if (notify)
		{
			await base.Player.SendPacket(new PacketScenePlaneEventScNotify(clone));
		}
		base.Player.MissionManager?.HandleFinishType(MissionFinishTypeEnum.GetItem, itemData.ToProto());
		return returnRaw ? itemData : clone;
	}

	public async ValueTask<ItemData> PutItem(int itemId, int count, int rank = 0, int promotion = 0, int level = 0, int exp = 0, int totalExp = 0, int mainAffix = 0, List<ItemSubAffix>? subAffixes = null, List<ItemSubAffix>? regorgeSubAffixes = null, int uniqueId = 0)
	{
		if (promotion == 0 && level > 10)
		{
			promotion = GameData.GetMinPromotionForLevel(level);
		}
		ItemData item = new ItemData
		{
			ItemId = itemId,
			Count = count,
			Rank = rank,
			Promotion = promotion,
			Level = level,
			Exp = exp,
			TotalExp = totalExp,
			MainAffix = mainAffix,
			SubAffixes = (subAffixes ?? new List<ItemSubAffix>()),
			ReforgeSubAffixes = (regorgeSubAffixes ?? new List<ItemSubAffix>())
		};
		if (uniqueId > 0)
		{
			item.UniqueId = uniqueId;
		}
		switch (GameData.ItemConfigData[itemId].ItemMainType)
		{
		case ItemMainTypeEnum.Virtual:
		case ItemMainTypeEnum.Usable:
		case ItemMainTypeEnum.Material:
		case ItemMainTypeEnum.Mission:
		case ItemMainTypeEnum.Pet:
		{
			ItemData itemData = Data.MaterialItems.Find((ItemData x) => x.ItemId == itemId);
			if (itemData != null)
			{
				itemData.Count += count;
				item = itemData;
			}
			else
			{
				Data.MaterialItems.Add(item);
			}
			break;
		}
		case ItemMainTypeEnum.Equipment:
			if (Data.EquipmentItems.Count + 1 > 1500)
			{
				await base.Player.SendPacket(new PacketRetcodeNotify(Retcode.RetEquipmentExceedLimit));
				return item;
			}
			Data.EquipmentItems.Add(item);
			break;
		case ItemMainTypeEnum.Relic:
			if (Data.RelicItems.Count + 1 > 1500)
			{
				await base.Player.SendPacket(new PacketRetcodeNotify(Retcode.RetRelicExceedLimit));
				return item;
			}
			Data.RelicItems.Add(item);
			break;
		}
		return item;
	}

	public async ValueTask<List<ItemData>> RemoveItems(List<(int itemId, int count, int uniqueId)> items, bool sync = true)
	{
		List<ItemData> removedItems = new List<ItemData>();
		foreach (var item in items)
		{
			ItemData itemData = await RemoveItem(item.itemId, item.count, item.uniqueId, sync: false);
			if (itemData != null)
			{
				removedItems.Add(itemData);
			}
		}
		if (sync && removedItems.Count > 0)
		{
			await base.Player.SendPacket(new PacketPlayerSyncScNotify(removedItems));
		}
		return removedItems;
	}

	public async ValueTask<ItemData?> RemoveItem(int itemId, int count, int uniqueId = 0, bool sync = true)
	{
		GameData.ItemConfigData.TryGetValue(itemId, out ItemConfigExcel value);
		if (value == null)
		{
			return null;
		}
		ItemData itemData = null;
		switch (value.ItemMainType)
		{
		case ItemMainTypeEnum.Usable:
		case ItemMainTypeEnum.Material:
		case ItemMainTypeEnum.Mission:
		case ItemMainTypeEnum.Pet:
		{
			ItemData itemData3 = Data.MaterialItems.Find((ItemData x) => x.ItemId == itemId);
			if (itemData3 == null)
			{
				return null;
			}
			itemData3.Count -= count;
			if (itemData3.Count <= 0)
			{
				Data.MaterialItems.Remove(itemData3);
				itemData3.Count = 0;
			}
			itemData = itemData3;
			break;
		}
		case ItemMainTypeEnum.Virtual:
			switch (value.ID)
			{
			case 1:
				base.Player.Data.Hcoin -= count;
				itemData = new ItemData
				{
					ItemId = itemId,
					Count = count
				};
				break;
			case 2:
				base.Player.Data.Scoin -= count;
				itemData = new ItemData
				{
					ItemId = itemId,
					Count = count
				};
				break;
			case 3:
				base.Player.Data.Mcoin -= count;
				itemData = new ItemData
				{
					ItemId = itemId,
					Count = count
				};
				break;
			case 32:
				base.Player.Data.TalentPoints -= count;
				itemData = new ItemData
				{
					ItemId = itemId,
					Count = count
				};
				break;
			}
			if (sync && itemData != null)
			{
				await base.Player.SendPacket(new PacketPlayerSyncScNotify(base.Player.ToProto()));
			}
			break;
		case ItemMainTypeEnum.Equipment:
		{
			ItemData itemData4 = Data.EquipmentItems.Find((ItemData x) => x.UniqueId == uniqueId);
			if (itemData4 == null)
			{
				return null;
			}
			Data.EquipmentItems.Remove(itemData4);
			itemData4.Count = 0;
			itemData = itemData4;
			break;
		}
		case ItemMainTypeEnum.Relic:
		{
			ItemData itemData2 = Data.RelicItems.Find((ItemData x) => x.UniqueId == uniqueId);
			if (itemData2 == null)
			{
				return null;
			}
			Data.RelicItems.Remove(itemData2);
			itemData2.Count = 0;
			itemData = itemData2;
			break;
		}
		}
		if (itemData != null && sync)
		{
			await base.Player.SendPacket(new PacketPlayerSyncScNotify(itemData));
		}
		base.Player.MissionManager?.HandleFinishType(MissionFinishTypeEnum.UseItem, new ItemData
		{
			ItemId = itemId,
			Count = count
		});
		return itemData;
	}

	public ItemData? GetItem(int itemId, int uniqueId = 0, ItemMainTypeEnum mainType = ItemMainTypeEnum.Unknown)
	{
		GameData.ItemConfigData.TryGetValue(itemId, out ItemConfigExcel value);
		if (value == null && mainType == ItemMainTypeEnum.Unknown)
		{
			return null;
		}
		if (value != null)
		{
			mainType = value.ItemMainType;
		}
		switch (mainType)
		{
		case ItemMainTypeEnum.Usable:
		case ItemMainTypeEnum.Material:
		case ItemMainTypeEnum.Pet:
			return Data.MaterialItems.Find((ItemData x) => x.ItemId == itemId);
		case ItemMainTypeEnum.Equipment:
			if (uniqueId <= 0)
			{
				return Data.EquipmentItems.Find((ItemData x) => x.ItemId == itemId);
			}
			return Data.EquipmentItems.Find((ItemData x) => x.UniqueId == uniqueId);
		case ItemMainTypeEnum.Relic:
			if (uniqueId <= 0)
			{
				return Data.RelicItems.Find((ItemData x) => x.ItemId == itemId);
			}
			return Data.RelicItems.Find((ItemData x) => x.UniqueId == uniqueId);
		case ItemMainTypeEnum.Virtual:
			switch (value?.ID ?? 0)
			{
			case 1:
				return new ItemData
				{
					ItemId = itemId,
					Count = base.Player.Data.Hcoin
				};
			case 2:
				return new ItemData
				{
					ItemId = itemId,
					Count = base.Player.Data.Scoin
				};
			case 3:
				return new ItemData
				{
					ItemId = itemId,
					Count = base.Player.Data.Mcoin
				};
			case 11:
				return new ItemData
				{
					ItemId = itemId,
					Count = base.Player.Data.Stamina
				};
			case 22:
				return new ItemData
				{
					ItemId = itemId,
					Count = base.Player.Data.Exp
				};
			case 32:
				return new ItemData
				{
					ItemId = itemId,
					Count = base.Player.Data.TalentPoints
				};
			}
			break;
		}
		return null;
	}

	public void HandlePlaneEvent(int eventId)
	{
		GameData.PlaneEventData.TryGetValue(eventId * 10 + base.Player.Data.WorldLevel, out PlaneEventExcel value);
		if (value == null)
		{
			return;
		}
		GameData.RewardDataData.TryGetValue(value.Reward, out RewardDataExcel value2);
		value2?.GetItems().ForEach(async delegate((int, int) x)
		{
			await AddItem(x.Item1, x.Item2);
		});
		foreach (int drop in value.DropList)
		{
			GameData.RewardDataData.TryGetValue(drop, out RewardDataExcel value3);
			value3?.GetItems().ForEach(async delegate((int, int) x)
			{
				await AddItem(x.Item1, x.Item2);
			});
		}
	}

	public async ValueTask<List<ItemData>> HandleReward(int rewardId, bool notify = false, bool sync = true)
	{
		GameData.RewardDataData.TryGetValue(rewardId, out RewardDataExcel rewardData);
		if (rewardData == null)
		{
			return new List<ItemData>();
		}
		List<ItemData> items = new List<ItemData>();
		foreach (var item in rewardData.GetItems())
		{
			ItemData itemData = await AddItem(item.Item1, item.Item2, notify, 1, 1, 0, sync: false);
			if (itemData != null)
			{
				items.Add(itemData);
			}
		}
		if (sync)
		{
			await base.Player.SendPacket(new PacketPlayerSyncScNotify(items));
		}
		ItemData itemData2 = await AddItem(1, rewardData.Hcoin, notify, 1, 1, 0, sync: false);
		if (itemData2 != null)
		{
			items.Add(itemData2);
		}
		return items;
	}

	public async ValueTask<List<ItemData>> HandleMappingInfo(int mappingId, int worldLevel)
	{
		List<ItemData> list = new List<ItemData>();
		List<ItemData> resItems = new List<ItemData>();
		GameData.MappingInfoData.TryGetValue(mappingId * 10 + worldLevel, out MappingInfoExcel value);
		if (value != null)
		{
			foreach (MappingInfoItem dropItem in value.DropItemList)
			{
				if (Random.Shared.Next(0, 101) <= dropItem.Chance)
				{
					int num = ((dropItem.ItemNum > 0) ? dropItem.ItemNum : Random.Shared.Next(dropItem.MinCount, dropItem.MaxCount + 1));
					GameData.ItemConfigData.TryGetValue(dropItem.ItemID, out ItemConfigExcel value2);
					if (value2 != null)
					{
						list.Add(new ItemData
						{
							ItemId = dropItem.ItemID,
							Count = num * ((dropItem.ItemID == 22) ? 1 : ConfigManager.Config.ServerOption.ValidFarmingDropRate())
						});
					}
				}
			}
			List<ItemData> list2 = value.GenerateRelicDrops();
			list.AddRange((Data.RelicItems.Count + list2.Count - 1 > 1500) ? list2.Slice(0, 1500 - Data.RelicItems.Count + 1) : list2);
			foreach (ItemData item in list)
			{
				ItemData itemData = await base.Player.InventoryManager.AddItem(item.ItemId, item.Count, notify: false);
				itemData.Count = item.Count;
				resItems.Add(itemData);
			}
		}
		return resItems;
	}

	public async ValueTask<(int, ItemData?)> HandleRelic(int relicId, int uniqueId, int level, int mainAffixId = 0, List<(int, int)>? subAffixes = null, bool sync = true)
	{
		GameData.RelicConfigData.TryGetValue(relicId, out RelicConfigExcel value);
		GameData.ItemConfigData.TryGetValue(relicId, out ItemConfigExcel value2);
		if (value == null || value2 == null)
		{
			return (1, null);
		}
		GameData.RelicSubAffixData.TryGetValue(value.SubAffixGroup, out Dictionary<int, RelicSubAffixConfigExcel> value3);
		GameData.RelicMainAffixData.TryGetValue(value.MainAffixGroup, out Dictionary<int, RelicMainAffixConfigExcel> value4);
		if (value3 == null || value4 == null)
		{
			return (1, null);
		}
		ItemData relic = new ItemData
		{
			ItemId = relicId,
			Level = Math.Max(Math.Min(level, 9999), 0),
			UniqueId = uniqueId,
			Count = 1
		};
		if (mainAffixId == 0 || !value4.TryGetValue(mainAffixId, out var _))
		{
			relic.AddRandomRelicMainAffix();
		}
		else
		{
			relic.MainAffix = mainAffixId;
		}
		if (subAffixes == null)
		{
			subAffixes = new List<(int, int)>();
		}
		if (subAffixes.Count > 4)
		{
			return (3, null);
		}
		relic.AddRelicSubAffix(subAffixes);
		int num = new Random().Next(3, 5);
		relic.AddRandomRelicSubAffix(num - subAffixes.Count);
		if (num == 3 && level / 3 > 0)
		{
			relic.AddRandomRelicSubAffix();
		}
		int times = level / 3 - (4 - num) - subAffixes.Sum(((int, int) x) => x.Item2);
		relic.IncreaseRandomRelicSubAffix(times);
		if (!sync)
		{
			await PutItem(relic.ItemId, relic.Count, relic.Rank, relic.Promotion, relic.Level, relic.Exp, relic.TotalExp, relic.MainAffix, relic.SubAffixes, relic.ReforgeSubAffixes, relic.UniqueId);
		}
		else
		{
			await base.Player.InventoryManager.AddItem(relic, notify: false);
		}
		return (0, relic);
	}

	public async ValueTask<ItemData?> ComposeItem(int composeId, int count, List<ItemCost> costData)
	{
		foreach (ItemCost costDatum in costData)
		{
			await RemoveItem((int)costDatum.PileItem.ItemId, (int)costDatum.PileItem.ItemNum);
		}
		GameData.ItemComposeConfigData.TryGetValue(composeId, out ItemComposeConfigExcel composeConfig);
		if (composeConfig == null)
		{
			return null;
		}
		foreach (MaterialItem item in composeConfig.MaterialCost)
		{
			await RemoveItem(item.ItemID, item.ItemNum * count);
		}
		await RemoveItem(2, composeConfig.CoinCost * count);
		return await AddItem(composeConfig.ItemID, count, notify: false);
	}

	public async ValueTask<List<ItemData>> ComposeRelic(ComposeSelectedRelicCsReq req)
	{
		int count = Math.Max(1, (int)req.Count);
		if (req.ComposeItemList != null)
		{
			foreach (ItemCost item in req.ComposeItemList.ItemList)
			{
				await RemoveItem((int)item.PileItem.ItemId, (int)item.PileItem.ItemNum);
			}
		}
		if (req.WrItemList != null)
		{
			foreach (ItemCost item2 in req.WrItemList.ItemList)
			{
				await RemoveItem((int)item2.PileItem.ItemId, (int)item2.PileItem.ItemNum);
			}
		}
		GameData.ItemComposeConfigData.TryGetValue((int)req.ComposeId, out ItemComposeConfigExcel composeConfig);
		if (composeConfig == null)
		{
			return new List<ItemData>();
		}
		foreach (MaterialItem item3 in composeConfig.MaterialCost)
		{
			await RemoveItem(item3.ItemID, item3.ItemNum * count);
		}
		await RemoveItem(2, composeConfig.CoinCost * count);
		int relicId = (int)req.ComposeRelicId;
		GameData.RelicConfigData.TryGetValue(relicId, out RelicConfigExcel value);
		GameData.RelicSubAffixData.TryGetValue(value.SubAffixGroup, out Dictionary<int, RelicSubAffixConfigExcel> subAffixConfig);
		int mainAffix = (int)req.MainAffixId;
		List<ItemData> items = new List<ItemData>();
		for (int i = 0; i < count; i++)
		{
			ItemData itemData = new ItemData
			{
				ItemId = relicId,
				Level = 0,
				UniqueId = ++Data.NextUniqueId,
				MainAffix = mainAffix,
				SubAffixes = req.SubAffixIdList.Select((uint subId) => new ItemSubAffix(subAffixConfig[(int)subId], 1)).ToList(),
				Count = 1
			};
			if (mainAffix == 0)
			{
				itemData.AddRandomRelicMainAffix();
			}
			itemData.AddRandomRelicSubAffix(3 - itemData.SubAffixes.Count + itemData.LuckyRelicSubAffixCount());
			await AddItem(itemData, notify: false);
			items.Add(itemData);
		}
		return items;
	}

	public async ValueTask<List<ItemData>> SellItem(ItemCostData costData, bool toMaterial)
	{
		List<ItemData> items = new List<ItemData>();
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		List<(int, int, int)> list = new List<(int, int, int)>();
		foreach (ItemCost cost in costData.ItemList)
		{
			if (cost.EquipmentUniqueId != 0)
			{
				ItemData itemData = Data.EquipmentItems.Find((ItemData x) => x.UniqueId == cost.EquipmentUniqueId);
				if (itemData == null)
				{
					continue;
				}
				list.Add((itemData.ItemId, 1, (int)cost.EquipmentUniqueId));
				GameData.ItemConfigData.TryGetValue(itemData.ItemId, out ItemConfigExcel value);
				if (value == null)
				{
					continue;
				}
				foreach (MappingInfoItem returnItemID in value.ReturnItemIDList)
				{
					if (!dictionary.ContainsKey(returnItemID.ItemID))
					{
						dictionary[returnItemID.ItemID] = 0;
					}
					dictionary[returnItemID.ItemID] += returnItemID.ItemNum;
				}
			}
			else if (cost.RelicUniqueId != 0)
			{
				ItemData itemData2 = Data.RelicItems.Find((ItemData x) => x.UniqueId == cost.RelicUniqueId);
				if (itemData2 == null)
				{
					continue;
				}
				list.Add((itemData2.ItemId, 1, (int)cost.RelicUniqueId));
				GameData.ItemConfigData.TryGetValue(itemData2.ItemId, out ItemConfigExcel value2);
				if (value2 == null)
				{
					continue;
				}
				if (value2.Rarity != ItemRarityEnum.SuperRare || toMaterial)
				{
					foreach (MappingInfoItem returnItemID2 in value2.ReturnItemIDList)
					{
						dictionary.TryAdd(returnItemID2.ItemID, 0);
						dictionary[returnItemID2.ItemID] += returnItemID2.ItemNum;
					}
					int num = (int)((double)itemData2.CalcTotalExpGained() * 0.8);
					if ((int)((double)num * 1.5) > 0)
					{
						dictionary.TryAdd(2, 0);
						dictionary[2] += (int)((double)num * 1.5);
					}
					int num2 = num / 500;
					if (num2 > 0)
					{
						dictionary.TryAdd(232, 0);
						dictionary[232] += num2;
					}
					int num3 = num % 500 / 100;
					if (num3 > 0)
					{
						dictionary.TryAdd(231, 0);
						dictionary[231] += num3;
					}
				}
				else
				{
					int num4 = itemData2.CalcTotalExpGained();
					int num5 = (int)(10.0 + (double)num4 * 0.005144);
					if (num5 > 0)
					{
						dictionary.TryAdd(235, 0);
						dictionary[235] += num5;
					}
				}
			}
			else
			{
				list.Add(((int)cost.PileItem.ItemId, (int)cost.PileItem.ItemNum, 0));
			}
		}
		RemoveItems(list);
		foreach (KeyValuePair<int, int> item in dictionary)
		{
			ItemData itemData3 = await AddItem(item.Key, item.Value, notify: false);
			if (itemData3 != null)
			{
				items.Add(itemData3);
			}
		}
		return items;
	}

	public async ValueTask<(Retcode, List<ItemData>? returnItems)> UseItem(int itemId, int count = 1, int baseAvatarId = 0)
	{
		GameData.ItemConfigData.TryGetValue(itemId, out ItemConfigExcel value);
		if (value == null)
		{
			return (Retcode.RetItemNotExist, null);
		}
		int dataId = value.ID;
		List<ItemData> resItemDatas = new List<ItemData>();
		if (GameData.ItemUseBuffDataData.TryGetValue(dataId, out ItemUseBuffDataExcel useConfig))
		{
			for (int i = 0; i < count; i++)
			{
				if (useConfig.PreviewSkillPoint != 0f)
				{
					await base.Player.LineupManager.GainMp((int)useConfig.PreviewSkillPoint);
				}
				if (baseAvatarId > 0)
				{
					FormalAvatarInfo avatar = base.Player.AvatarManager.GetFormalAvatar(baseAvatarId);
					if (avatar == null)
					{
						return (Retcode.RetAvatarNotExist, null);
					}
					bool extraLineup = base.Player.LineupManager.GetCurLineup()?.IsExtraLineup() ?? false;
					if (useConfig.PreviewHPRecoveryPercent != 0f)
					{
						avatar.SetCurHp(Math.Min(Math.Max(avatar.CurrentHp + (int)(useConfig.PreviewHPRecoveryPercent * 10000f), 0), 10000), extraLineup);
						await base.Player.SendPacket(new PacketSyncLineupNotify(base.Player.LineupManager.GetCurLineup()));
					}
					if (useConfig.PreviewHPRecoveryValue != 0f)
					{
						avatar.SetCurHp(Math.Min(Math.Max(avatar.CurrentHp + (int)useConfig.PreviewHPRecoveryValue, 0), 10000), extraLineup);
						await base.Player.SendPacket(new PacketSyncLineupNotify(base.Player.LineupManager.GetCurLineup()));
					}
					if (useConfig.PreviewPowerPercent != 0f)
					{
						avatar.SetCurSp(Math.Min(Math.Max(avatar.CurrentHp + (int)(useConfig.PreviewPowerPercent * 10000f), 0), 10000), extraLineup);
						await base.Player.SendPacket(new PacketSyncLineupNotify(base.Player.LineupManager.GetCurLineup()));
					}
				}
				else
				{
					if (useConfig.PreviewHPRecoveryPercent != 0f)
					{
						base.Player.LineupManager.GetCurLineup().Heal((int)(useConfig.PreviewHPRecoveryPercent * 10000f), allowRevive: true);
						await base.Player.SendPacket(new PacketSyncLineupNotify(base.Player.LineupManager.GetCurLineup()));
					}
					if (useConfig.PreviewHPRecoveryValue != 0f)
					{
						base.Player.LineupManager.GetCurLineup().Heal((int)useConfig.PreviewHPRecoveryValue, allowRevive: true);
						await base.Player.SendPacket(new PacketSyncLineupNotify(base.Player.LineupManager.GetCurLineup()));
					}
					if (useConfig.PreviewPowerPercent != 0f)
					{
						base.Player.LineupManager.GetCurLineup().AddPercentSp((int)(useConfig.PreviewPowerPercent * 10000f));
						await base.Player.SendPacket(new PacketSyncLineupNotify(base.Player.LineupManager.GetCurLineup()));
					}
				}
			}
			if (useConfig.MazeBuffID > 0)
			{
				foreach (AvatarSceneInfo item in base.Player.SceneInstance?.AvatarInfo.Values.ToList() ?? new List<AvatarSceneInfo>())
				{
					if (baseAvatarId == 0 || item.AvatarInfo.BaseAvatarId == baseAvatarId)
					{
						await item.AddBuff(new SceneBuff(useConfig.MazeBuffID, 1, item.AvatarInfo.AvatarId));
					}
				}
			}
			if (useConfig.MazeBuffID2 > 0)
			{
				foreach (AvatarSceneInfo item2 in base.Player.SceneInstance?.AvatarInfo.Values.ToList() ?? new List<AvatarSceneInfo>())
				{
					if (baseAvatarId == 0 || item2.AvatarInfo.BaseAvatarId == baseAvatarId)
					{
						await item2.AddBuff(new SceneBuff(useConfig.MazeBuffID2, 1, item2.AvatarInfo.AvatarId));
					}
				}
			}
		}
		if (GameData.ItemUseDataData.TryGetValue(dataId, out ItemUseDataExcel value2))
		{
			foreach (int item3 in value2.UseParam)
			{
				List<ItemData> list = resItemDatas;
				list.AddRange(await HandleReward(item3, notify: true));
			}
		}
		await RemoveItem(itemId, count);
		return (Retcode.RetSucc, resItemDatas);
	}

	public async ValueTask EquipAvatar(int avatarId, int equipmentUniqueId)
	{
		ItemData itemData = Data.EquipmentItems.Find((ItemData x) => x.UniqueId == equipmentUniqueId);
		FormalAvatarInfo avatarData = base.Player.AvatarManager.GetFormalAvatar(avatarId);
		if (itemData == null || avatarData == null)
		{
			return;
		}
		ItemData itemData2 = Data.EquipmentItems.Find((ItemData x) => x.UniqueId == avatarData.PathInfos[avatarId].EquipId);
		if (itemData.EquipAvatar > 0)
		{
			int equipAvatar = itemData.EquipAvatar;
			FormalAvatarInfo formalAvatar = base.Player.AvatarManager.GetFormalAvatar(equipAvatar);
			if (formalAvatar != null && itemData2 != null)
			{
				formalAvatar.PathInfos[equipAvatar].EquipId = itemData2.UniqueId;
				itemData2.EquipAvatar = formalAvatar.AvatarId;
				await base.Player.SendPacket(new PacketPlayerSyncScNotify(formalAvatar, itemData2));
			}
			else if (formalAvatar != null && itemData2 == null)
			{
				formalAvatar.PathInfos[equipAvatar].EquipId = 0;
				await base.Player.SendPacket(new PacketPlayerSyncScNotify(formalAvatar));
			}
		}
		else if (itemData2 != null)
		{
			itemData2.EquipAvatar = 0;
			await base.Player.SendPacket(new PacketPlayerSyncScNotify(itemData2));
		}
		itemData.EquipAvatar = avatarData.AvatarId;
		avatarData.PathInfos[avatarId].EquipId = itemData.UniqueId;
		await base.Player.SendPacket(new PacketPlayerSyncScNotify(avatarData, itemData));
	}

	public async ValueTask EquipRelic(int avatarId, int relicUniqueId, int slot)
	{
		ItemData itemData = Data.RelicItems.Find((ItemData x) => x.UniqueId == relicUniqueId);
		FormalAvatarInfo avatarData = base.Player.AvatarManager.GetFormalAvatar(avatarId);
		if (itemData == null || avatarData == null)
		{
			return;
		}
		avatarData.PathInfos[avatarId].Relic.TryGetValue(slot, out var id);
		ItemData itemData2 = Data.RelicItems.Find((ItemData x) => x.UniqueId == id);
		if (itemData.EquipAvatar > 0)
		{
			int equipAvatar = itemData.EquipAvatar;
			FormalAvatarInfo formalAvatar = base.Player.AvatarManager.GetFormalAvatar(equipAvatar);
			if (formalAvatar != null && itemData2 != null)
			{
				formalAvatar.PathInfos[equipAvatar].Relic[slot] = itemData2.UniqueId;
				itemData2.EquipAvatar = formalAvatar.AvatarId;
				await base.Player.SendPacket(new PacketPlayerSyncScNotify(formalAvatar, itemData2));
			}
			else if (formalAvatar != null && itemData2 == null)
			{
				formalAvatar.PathInfos[equipAvatar].Relic[slot] = 0;
				await base.Player.SendPacket(new PacketPlayerSyncScNotify(formalAvatar));
			}
		}
		else if (itemData2 != null)
		{
			itemData2.EquipAvatar = 0;
			await base.Player.SendPacket(new PacketPlayerSyncScNotify(itemData2));
		}
		itemData.EquipAvatar = avatarData.AvatarId;
		avatarData.PathInfos[avatarId].Relic[slot] = itemData.UniqueId;
		await base.Player.SendPacket(new PacketPlayerSyncScNotify(avatarData, itemData));
	}

	public async ValueTask UnequipRelic(int avatarId, int slot)
	{
		FormalAvatarInfo formalAvatar = base.Player.AvatarManager.GetFormalAvatar(avatarId);
		if (formalAvatar != null)
		{
			PathInfo pathInfo = formalAvatar.PathInfos[avatarId];
			pathInfo.Relic.TryGetValue(slot, out var uniqueId);
			ItemData itemData = Data.RelicItems.Find((ItemData x) => x.UniqueId == uniqueId);
			if (itemData != null)
			{
				pathInfo.Relic.Remove(slot);
				itemData.EquipAvatar = 0;
				await base.Player.SendPacket(new PacketPlayerSyncScNotify(formalAvatar, itemData));
			}
		}
	}

	public async ValueTask UnequipEquipment(int avatarId)
	{
		FormalAvatarInfo formalAvatar = base.Player.AvatarManager.GetFormalAvatar(avatarId);
		if (formalAvatar != null)
		{
			PathInfo pathInfo = formalAvatar.PathInfos[avatarId];
			ItemData itemData = Data.EquipmentItems.Find((ItemData x) => x.UniqueId == pathInfo.EquipId);
			if (itemData != null)
			{
				itemData.EquipAvatar = 0;
				pathInfo.EquipId = 0;
				await base.Player.SendPacket(new PacketPlayerSyncScNotify(formalAvatar, itemData));
			}
		}
	}

	public async ValueTask<List<ItemData>> LevelUpAvatar(int baseAvatarId, ItemCostData item)
	{
		FormalAvatarInfo avatarData = base.Player.AvatarManager.GetFormalAvatar(baseAvatarId);
		if (avatarData == null)
		{
			return new List<ItemData>();
		}
		GameData.AvatarConfigData.TryGetValue(avatarData.AvatarId, out AvatarConfigExcel avatarConfig);
		if (avatarConfig == null)
		{
			return new List<ItemData>();
		}
		GameData.AvatarPromotionConfigData.TryGetValue(avatarData.AvatarId * 10 + avatarData.Promotion, out AvatarPromotionConfigExcel promotionConfig);
		if (promotionConfig == null)
		{
			return new List<ItemData>();
		}
		int exp = 0;
		foreach (ItemCost item2 in item.ItemList)
		{
			GameData.ItemConfigData.TryGetValue((int)item2.PileItem.ItemId, out ItemConfigExcel value);
			if (value != null)
			{
				exp += value.Exp * (int)item2.PileItem.ItemNum;
			}
		}
		int costScoin = exp / 10;
		if (base.Player.Data.Scoin < costScoin)
		{
			return new List<ItemData>();
		}
		foreach (ItemCost item3 in item.ItemList)
		{
			await RemoveItem((int)item3.PileItem.ItemId, (int)item3.PileItem.ItemNum);
		}
		await RemoveItem(2, costScoin);
		int maxLevel = promotionConfig.MaxLevel;
		int num = avatarData.Exp;
		int num2 = avatarData.Level;
		int avatarExpRequired = GameData.GetAvatarExpRequired(avatarConfig.ExpGroup, avatarData.Level);
		do
		{
			int num3 = ((num + exp < avatarExpRequired) ? exp : (avatarExpRequired - num));
			num += num3;
			exp -= num3;
			if (num >= avatarExpRequired)
			{
				num = 0;
				num2++;
				avatarExpRequired = GameData.GetAvatarExpRequired(avatarConfig.ExpGroup, num2);
			}
		}
		while (exp > 0 && avatarExpRequired > 0 && num2 < maxLevel);
		avatarData.Level = num2;
		avatarData.Exp = num;
		Dictionary<int, ItemData> list = new Dictionary<int, ItemData>();
		int leftover = exp;
		while (leftover > 0)
		{
			bool flag = false;
			foreach (EquipmentExpItemConfigExcel expItem in GameData.EquipmentExpItemConfigData.Values.Reverse())
			{
				if (leftover >= expItem.ExpProvide)
				{
					await PutItem(expItem.ItemID, 1);
					if (list.TryGetValue(expItem.ItemID, out ItemData value2))
					{
						value2.Count++;
					}
					else
					{
						value2 = new ItemData
						{
							ItemId = expItem.ItemID,
							Count = 1
						};
						list[expItem.ItemID] = value2;
					}
					leftover -= expItem.ExpProvide;
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				break;
			}
		}
		if (list.Count > 0)
		{
			await base.Player.SendPacket(new PacketPlayerSyncScNotify(list.Values.ToList()));
		}
		await base.Player.SendPacket(new PacketPlayerSyncScNotify(avatarData));
		return list.Values.ToList();
	}

	public async ValueTask<List<ItemData>> LevelUpEquipment(int equipmentUniqueId, ItemCostData item)
	{
		ItemData itemData = Data.EquipmentItems.Find((ItemData x) => x.UniqueId == equipmentUniqueId);
		if (itemData == null)
		{
			return new List<ItemData>();
		}
		GameData.EquipmentPromotionConfigData.TryGetValue(itemData.ItemId * 10 + itemData.Promotion, out EquipmentPromotionConfigExcel equipmentPromotionConfig);
		GameData.EquipmentConfigData.TryGetValue(itemData.ItemId, out EquipmentConfigExcel equipmentConfig);
		if (equipmentConfig == null || equipmentPromotionConfig == null)
		{
			return new List<ItemData>();
		}
		int exp = 0;
		foreach (ItemCost item2 in item.ItemList)
		{
			if (item2.PileItem == null)
			{
				exp += 100;
				continue;
			}
			GameData.ItemConfigData.TryGetValue((int)item2.PileItem.ItemId, out ItemConfigExcel value);
			if (value != null)
			{
				exp += value.Exp * (int)item2.PileItem.ItemNum;
			}
		}
		int costScoin = exp / 2;
		if (base.Player.Data.Scoin < costScoin)
		{
			return new List<ItemData>();
		}
		foreach (ItemCost cost in item.ItemList)
		{
			if (cost.PileItem == null)
			{
				ItemData itemData2 = Data.EquipmentItems.Find((ItemData x) => x.UniqueId == cost.EquipmentUniqueId);
				if (itemData2 != null)
				{
					await RemoveItem(itemData2.ItemId, 1, (int)cost.EquipmentUniqueId);
				}
			}
			else
			{
				await RemoveItem((int)cost.PileItem.ItemId, (int)cost.PileItem.ItemNum);
			}
		}
		await RemoveItem(2, costScoin);
		int maxLevel = equipmentPromotionConfig.MaxLevel;
		int num = itemData.Exp;
		int num2 = itemData.Level;
		int equipmentExpRequired = GameData.GetEquipmentExpRequired(equipmentConfig.ExpType, itemData.Level);
		do
		{
			int num3 = ((num + exp < equipmentExpRequired) ? exp : (equipmentExpRequired - num));
			num += num3;
			exp -= num3;
			if (num >= equipmentExpRequired)
			{
				num = 0;
				num2++;
				equipmentExpRequired = GameData.GetEquipmentExpRequired(equipmentConfig.ExpType, num2);
			}
		}
		while (exp > 0 && equipmentExpRequired > 0 && num2 < maxLevel);
		itemData.Level = num2;
		itemData.Exp = num;
		Dictionary<int, ItemData> list = new Dictionary<int, ItemData>();
		int leftover = exp;
		while (leftover > 0)
		{
			bool flag = false;
			foreach (EquipmentExpItemConfigExcel expItem in GameData.EquipmentExpItemConfigData.Values.Reverse())
			{
				if (leftover >= expItem.ExpProvide)
				{
					await PutItem(expItem.ItemID, 1);
					if (list.TryGetValue(expItem.ItemID, out ItemData value2))
					{
						value2.Count++;
					}
					else
					{
						value2 = new ItemData
						{
							ItemId = expItem.ItemID,
							Count = 1
						};
						list[expItem.ItemID] = value2;
					}
					leftover -= expItem.ExpProvide;
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				break;
			}
		}
		if (list.Count > 0)
		{
			await base.Player.SendPacket(new PacketPlayerSyncScNotify(list.Values.ToList()));
		}
		await base.Player.SendPacket(new PacketPlayerSyncScNotify(itemData));
		return list.Values.ToList();
	}

	public async ValueTask<bool> PromoteAvatar(int avatarId)
	{
		FormalAvatarInfo avatarData = base.Player.AvatarManager.GetFormalAvatar(avatarId);
		if (avatarData == null)
		{
			return false;
		}
		GameData.AvatarConfigData.TryGetValue(avatarId, out AvatarConfigExcel value);
		if (value == null || avatarData.Promotion >= value.MaxPromotion)
		{
			return false;
		}
		AvatarPromotionConfigExcel avatarPromotionConfigExcel = GameData.AvatarPromotionConfigData.Values.FirstOrDefault((AvatarPromotionConfigExcel x) => x.AvatarID == avatarId && x.Promotion == avatarData.Promotion);
		if (avatarData.Level < avatarPromotionConfigExcel.MaxLevel || base.Player.Data.Level < avatarPromotionConfigExcel.PlayerLevelRequire || base.Player.Data.WorldLevel < avatarPromotionConfigExcel.WorldLevelRequire)
		{
			return false;
		}
		foreach (AvatarPromotionConfigExcel.ItemParam promotionCost in avatarPromotionConfigExcel.PromotionCostList)
		{
			await base.Player.InventoryManager.RemoveItem(promotionCost.ItemID, promotionCost.ItemNum);
		}
		avatarData.Promotion++;
		await base.Player.SendPacket(new PacketPlayerSyncScNotify(avatarData));
		return true;
	}

	public async ValueTask<bool> PromoteEquipment(int equipmentUniqueId)
	{
		ItemData equipmentData = base.Player.InventoryManager.Data.EquipmentItems.FirstOrDefault((ItemData x) => x.UniqueId == equipmentUniqueId);
		if (equipmentData == null || equipmentData.Promotion >= GameData.EquipmentConfigData[equipmentData.ItemId].MaxPromotion)
		{
			return false;
		}
		EquipmentPromotionConfigExcel equipmentPromotionConfigExcel = GameData.EquipmentPromotionConfigData.Values.FirstOrDefault((EquipmentPromotionConfigExcel x) => x.EquipmentID == equipmentData.ItemId && x.Promotion == equipmentData.Promotion);
		if (equipmentPromotionConfigExcel == null || equipmentData.Level < equipmentPromotionConfigExcel.MaxLevel || base.Player.Data.WorldLevel < equipmentPromotionConfigExcel.WorldLevelRequire)
		{
			return false;
		}
		foreach (EquipmentPromotionConfigExcel.ItemParam promotionCost in equipmentPromotionConfigExcel.PromotionCostList)
		{
			await base.Player.InventoryManager.RemoveItem(promotionCost.ItemID, promotionCost.ItemNum);
		}
		equipmentData.Promotion++;
		await base.Player.SendPacket(new PacketPlayerSyncScNotify(equipmentData));
		return true;
	}

	public async ValueTask<List<ItemData>> LevelUpRelic(int uniqueId, ItemCostData costData)
	{
		ItemData relicItem = Data.RelicItems.Find((ItemData x) => x.UniqueId == uniqueId);
		if (relicItem == null)
		{
			return new List<ItemData>();
		}
		int exp = 0;
		int money = 0;
		foreach (ItemCost cost in costData.ItemList)
		{
			if (cost.PileItem != null)
			{
				GameData.RelicExpItemData.TryGetValue((int)cost.PileItem.ItemId, out RelicExpItemExcel value);
				if (value != null)
				{
					exp += value.ExpProvide * (int)cost.PileItem.ItemNum;
					money += value.CoinCost * (int)cost.PileItem.ItemNum;
				}
				await RemoveItem((int)cost.PileItem.ItemId, (int)cost.PileItem.ItemNum);
			}
			else
			{
				if (cost.RelicUniqueId == 0)
				{
					continue;
				}
				ItemData itemData = Data.RelicItems.Find((ItemData x) => x.UniqueId == cost.RelicUniqueId);
				if (itemData == null)
				{
					continue;
				}
				GameData.RelicConfigData.TryGetValue(itemData.ItemId, out RelicConfigExcel value2);
				if (value2 == null)
				{
					continue;
				}
				if (itemData.Level > 0)
				{
					foreach (int item in Enumerable.Range(0, itemData.Level))
					{
						GameData.RelicExpTypeData.TryGetValue(value2.ExpType * 100 + item, out RelicExpTypeExcel value3);
						if (value3 != null)
						{
							exp += value3.Exp;
						}
					}
				}
				else
				{
					exp += value2.ExpProvide;
				}
				exp += itemData.Exp;
				money += value2.CoinCost;
				await RemoveItem(itemData.ItemId, 1, (int)cost.RelicUniqueId);
			}
		}
		await RemoveItem(2, money);
		GameData.RelicConfigData.TryGetValue(relicItem.ItemId, out RelicConfigExcel value4);
		if (value4 == null)
		{
			return new List<ItemData>();
		}
		GameData.RelicExpTypeData.TryGetValue(value4.ExpType * 100 + relicItem.Level, out RelicExpTypeExcel value5);
		while (value5 != null)
		{
			int num = ((relicItem.Exp + exp < value5.Exp) ? exp : (value5.Exp - relicItem.Exp));
			relicItem.Exp += num;
			exp -= num;
			if (relicItem.Exp >= value5.Exp)
			{
				relicItem.Exp = 0;
				relicItem.Level++;
				GameData.RelicExpTypeData.TryGetValue(value4.ExpType * 100 + relicItem.Level, out value5);
				if (relicItem.Level % 3 == 0)
				{
					if (relicItem.SubAffixes.Count >= 4)
					{
						relicItem.IncreaseRandomRelicSubAffix();
					}
					else
					{
						relicItem.AddRandomRelicSubAffix();
					}
				}
			}
			if (exp <= 0 || value5 == null || value5.Exp <= 0 || relicItem.Level >= value4.MaxLevel)
			{
				break;
			}
		}
		Dictionary<int, ItemData> list = new Dictionary<int, ItemData>();
		int leftover = exp;
		while (leftover > 0)
		{
			bool flag = false;
			foreach (RelicExpItemExcel expItem in GameData.RelicExpItemData.Values.Reverse())
			{
				if (leftover >= expItem.ExpProvide)
				{
					await PutItem(expItem.ItemID, 1);
					if (list.TryGetValue(expItem.ItemID, out ItemData value6))
					{
						value6.Count++;
					}
					else
					{
						value6 = new ItemData
						{
							ItemId = expItem.ItemID,
							Count = 1
						};
						list[expItem.ItemID] = value6;
					}
					leftover -= expItem.ExpProvide;
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				break;
			}
		}
		if (list.Count > 0)
		{
			await base.Player.SendPacket(new PacketPlayerSyncScNotify(list.Values.ToList()));
		}
		await base.Player.SendPacket(new PacketPlayerSyncScNotify(relicItem));
		return list.Values.ToList();
	}

	public async ValueTask RankUpAvatar(int avatarId, ItemCostData costData)
	{
		foreach (ItemCost item in costData.ItemList)
		{
			await RemoveItem((int)item.PileItem.ItemId, (int)item.PileItem.ItemNum);
		}
		int num = avatarId;
		GameData.MultiplePathAvatarConfigData.TryGetValue(num, out MultiplePathAvatarConfigExcel value);
		if (value != null)
		{
			num = value.BaseAvatarID;
		}
		FormalAvatarInfo formalAvatar = base.Player.AvatarManager.GetFormalAvatar(num);
		if (formalAvatar != null)
		{
			formalAvatar.GetCurPathInfo().Rank++;
			await base.Player.SendPacket(new PacketPlayerSyncScNotify(formalAvatar));
		}
	}

	public async ValueTask RankUpEquipment(int equipmentUniqueId, ItemCostData costData)
	{
		int rank = 0;
		foreach (ItemCost cost in costData.ItemList)
		{
			ItemData itemData = Data.EquipmentItems.Find((ItemData x) => x.UniqueId == cost.EquipmentUniqueId);
			if (itemData != null)
			{
				await RemoveItem(itemData.ItemId, 0, (int)cost.EquipmentUniqueId);
				rank++;
			}
		}
		ItemData itemData2 = Data.EquipmentItems.Find((ItemData x) => x.UniqueId == equipmentUniqueId);
		if (itemData2 != null)
		{
			itemData2.Rank += rank;
			await base.Player.SendPacket(new PacketPlayerSyncScNotify(itemData2));
		}
	}

	public async ValueTask<bool> LockItems(RepeatedField<uint> ids, bool isLocked, ItemMainTypeEnum itemType = ItemMainTypeEnum.Unknown)
	{
		List<ItemData> list;
		switch (itemType)
		{
		case ItemMainTypeEnum.Equipment:
			list = Data.EquipmentItems;
			break;
		case ItemMainTypeEnum.Relic:
			list = Data.RelicItems;
			break;
		default:
			return false;
		}
		if (list.Count == 0)
		{
			return false;
		}
		FrozenSet<int> frozenSet = ids.ToList().ConvertAll((uint x) => (int)x).ToFrozenSet();
		List<ItemData> list2 = new List<ItemData>();
		foreach (ItemData item in list)
		{
			if (!item.Discarded && frozenSet.Contains(item.UniqueId))
			{
				item.Locked = isLocked;
				list2.Add(item);
			}
		}
		if (list2.Count <= 0)
		{
			return false;
		}
		await base.Player.SendPacket(new PacketPlayerSyncScNotify(list2));
		return true;
	}

	public async ValueTask<bool> DiscardItems(RepeatedField<uint> ids, bool discarded, ItemMainTypeEnum itemType = ItemMainTypeEnum.Unknown)
	{
		List<ItemData> list;
		switch (itemType)
		{
		case ItemMainTypeEnum.Equipment:
			list = Data.EquipmentItems;
			break;
		case ItemMainTypeEnum.Relic:
			list = Data.RelicItems;
			break;
		default:
			return false;
		}
		if (list.Count == 0)
		{
			return false;
		}
		FrozenSet<int> frozenSet = ids.ToList().ConvertAll((uint x) => (int)x).ToFrozenSet();
		List<ItemData> list2 = new List<ItemData>();
		foreach (ItemData item in list)
		{
			if (!item.Locked && frozenSet.Contains(item.UniqueId))
			{
				item.Discarded = discarded;
				list2.Add(item);
			}
		}
		if (list2.Count <= 0)
		{
			return false;
		}
		await base.Player.SendPacket(new PacketPlayerSyncScNotify(list2));
		return true;
	}
}
