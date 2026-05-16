using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database;
using March7thHoney.Database.Inventory;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Offering;
using March7thHoney.GameServer.Server.Packet.Send.PlayerSync;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.Inventory;

public class OfferingManager : BasePlayerManager
{
	public OfferingData Data;

	public OfferingManager(PlayerInstance player)
	{
		Data = DatabaseHelper.Instance.GetInstanceOrCreateNew<OfferingData>(player.Uid);
		base._002Ector(player);
	}

	public OfferingTypeData? GetOfferingData(int offeringId)
	{
		if (Data.Offerings.TryGetValue(offeringId, out OfferingTypeData value))
		{
			return value;
		}
		OfferingTypeConfigExcel valueOrDefault = GameData.OfferingTypeConfigData.GetValueOrDefault(offeringId);
		if (valueOrDefault == null)
		{
			return null;
		}
		int unlockID = valueOrDefault.UnlockID;
		OfferingTypeData offeringTypeData = new OfferingTypeData
		{
			OfferingId = offeringId,
			State = OfferingState.Lock
		};
		if (base.Player.QuestManager.UnlockHandler.GetUnlockStatus(unlockID))
		{
			offeringTypeData.State = OfferingState.Open;
		}
		Data.Offerings[offeringId] = offeringTypeData;
		return offeringTypeData;
	}

	public async ValueTask UpdateOfferingData()
	{
		List<OfferingTypeData> list = new List<OfferingTypeData>();
		foreach (OfferingTypeData value in Data.Offerings.Values)
		{
			OfferingTypeConfigExcel valueOrDefault = GameData.OfferingTypeConfigData.GetValueOrDefault(value.OfferingId);
			if (valueOrDefault != null)
			{
				if (base.Player.QuestManager.UnlockHandler.GetUnlockStatus(valueOrDefault.UnlockID) && value.State != OfferingState.Open)
				{
					value.State = OfferingState.Open;
					list.Add(value);
				}
				else if (!base.Player.QuestManager.UnlockHandler.GetUnlockStatus(valueOrDefault.UnlockID) && value.State != OfferingState.Lock)
				{
					value.State = OfferingState.Lock;
					list.Add(value);
				}
			}
		}
		foreach (OfferingTypeData item in list)
		{
			await base.Player.SendPacket(new PacketOfferingInfoScNotify(item));
		}
	}

	public async ValueTask<(Retcode, OfferingTypeData? data)> SubmitOfferingItem(int offeringId)
	{
		OfferingTypeData offering = GetOfferingData(offeringId);
		if (offering == null || offering.State != OfferingState.Open)
		{
			return (Retcode.RetOfferingNotUnlock, null);
		}
		OfferingTypeConfigExcel valueOrDefault = GameData.OfferingTypeConfigData.GetValueOrDefault(offeringId);
		if (valueOrDefault == null)
		{
			return (Retcode.RetOfferingNotUnlock, null);
		}
		if (offering.Level >= valueOrDefault.MaxLevel)
		{
			return (Retcode.RetOfferingReachMaxLevel, offering);
		}
		ItemData item = base.Player.InventoryManager.GetItem(valueOrDefault.ItemID);
		if (item == null || item.Count < 1)
		{
			return (Retcode.RetOfferingItemNotEnough, offering);
		}
		int num = item.Count;
		while (offering.Level < valueOrDefault.MaxLevel)
		{
			OfferingLevelConfigExcel offeringLevelConfigExcel = GameData.OfferingLevelConfigData.GetValueOrDefault(offeringId)?.GetValueOrDefault(offering.Level + 1);
			if (offeringLevelConfigExcel == null)
			{
				break;
			}
			if (num + offering.CurExp < offeringLevelConfigExcel.ItemCost)
			{
				offering.CurExp += num;
				num = 0;
				break;
			}
			num -= offeringLevelConfigExcel.ItemCost - offering.CurExp;
			offering.Level++;
			offering.CurExp = 0;
		}
		await base.Player.InventoryManager.RemoveItem(item.ItemId, item.Count - num);
		return (Retcode.RetSucc, offering);
	}

	public async ValueTask<(Retcode, OfferingTypeData? data, List<ItemData> reward)> TakeOfferingReward(int offeringId, List<int> takeList)
	{
		OfferingTypeData offering = GetOfferingData(offeringId);
		if (offering == null || offering.State != OfferingState.Open)
		{
			return (Retcode.RetOfferingNotUnlock, null, new List<ItemData>());
		}
		if (GameData.OfferingTypeConfigData.GetValueOrDefault(offeringId) == null)
		{
			return (Retcode.RetOfferingNotUnlock, offering, new List<ItemData>());
		}
		List<int> list = new List<int>();
		foreach (OfferingLevelConfigExcel item in takeList.Select((int take) => GameData.OfferingLevelConfigData.GetValueOrDefault(offeringId)?.GetValueOrDefault(take)))
		{
			if (item != null && item.Level <= offering.Level && !offering.TakenReward.Contains(item.Level))
			{
				list.Add(item.RewardID);
				continue;
			}
			return (Retcode.RetOfferingLevelNotUnlock, offering, new List<ItemData>());
		}
		offering.TakenReward.AddRange(takeList);
		List<ItemData> reward = new List<ItemData>();
		foreach (int item2 in list)
		{
			List<ItemData> list2 = reward;
			list2.AddRange(await base.Player.InventoryManager.HandleReward(item2, notify: false, sync: false));
		}
		await base.Player.SendPacket(new PacketPlayerSyncScNotify(reward));
		return (Retcode.RetSucc, offering, reward);
	}
}
