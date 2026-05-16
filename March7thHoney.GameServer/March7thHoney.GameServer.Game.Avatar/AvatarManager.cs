using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database;
using March7thHoney.Database.Avatar;
using March7thHoney.Database.Friend;
using March7thHoney.Database.Inventory;
using March7thHoney.Enums.Item;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Avatar;
using March7thHoney.GameServer.Server.Packet.Send.PlayerSync;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.Avatar;

public class AvatarManager : BasePlayerManager
{
	public AvatarData AvatarData { get; }

	public AvatarManager(PlayerInstance player)
	{
		AvatarData = DatabaseHelper.Instance.GetInstanceOrCreateNew<AvatarData>(player.Uid);
		base._002Ector(player);
	}

	public async ValueTask<AvatarConfigExcel?> AddAvatar(int avatarId, bool sync = true, bool notify = true, bool isGacha = false)
	{
		GameData.AvatarConfigData.TryGetValue(avatarId, out AvatarConfigExcel avatarExcel);
		if (avatarExcel == null)
		{
			return null;
		}
		if (avatarExcel.MaxRank < 6)
		{
			return null;
		}
		GameData.MultiplePathAvatarConfigData.TryGetValue(avatarId, out MultiplePathAvatarConfigExcel value);
		if (value != null && value.BaseAvatarID != avatarId)
		{
			foreach (FormalAvatarInfo formalAvatar in AvatarData.FormalAvatars)
			{
				if (formalAvatar.AvatarId == value.BaseAvatarID)
				{
					formalAvatar.PathInfos.Add(avatarId, new PathInfo(avatarId));
					break;
				}
			}
			return null;
		}
		FormalAvatarInfo avatar = new FormalAvatarInfo(value?.BaseAvatarID ?? avatarId, avatarId, addSkills: true)
		{
			Level = 1,
			Timestamp = Extensions.GetUnixSec(),
			CurrentHp = 10000,
			CurrentSp = 0
		};
		AvatarData.FormalAvatars.Add(avatar);
		if (avatarExcel.Rarity == RarityEnum.CombatPowerAvatarRarityType5 && avatarExcel.AvatarID <= 3000)
		{
			base.Player.FriendRecordData.AddAndRemoveOld(new FriendDevelopmentInfoPb
			{
				DevelopmentType = DevelopmentType.KghodpfjgliApbchinmcij,
				Params = { 
				{
					"AvatarId",
					(uint)avatarExcel.AvatarID
				} }
			});
		}
		if (sync)
		{
			await base.Player.SendPacket(new PacketPlayerSyncScNotify(avatar));
		}
		if (notify)
		{
			await base.Player.SendPacket(new PacketAddAvatarScNotify(avatar.BaseAvatarId, isGacha));
		}
		return avatarExcel;
	}

	public FormalAvatarInfo? GetFormalAvatar(int avatarId)
	{
		GameData.MultiplePathAvatarConfigData.TryGetValue(avatarId, out MultiplePathAvatarConfigExcel multiPathAvatar);
		return AvatarData.FormalAvatars.Find((FormalAvatarInfo avatar) => avatar.BaseAvatarId == (multiPathAvatar?.BaseAvatarID ?? avatarId));
	}

	public SpecialAvatarInfo? GetTrialAvatar(int avatarId, bool refresh = false)
	{
		SpecialAvatarInfo specialAvatarInfo = AvatarData.TrialAvatars.Find((SpecialAvatarInfo avatar) => avatar.SpecialAvatarId == avatarId);
		if (specialAvatarInfo != null)
		{
			if (!refresh)
			{
				return specialAvatarInfo;
			}
			AvatarData.TrialAvatars.Remove(specialAvatarInfo);
		}
		if (!GameData.SpecialAvatarData.TryGetValue(avatarId * 10, out SpecialAvatarExcel value))
		{
			return null;
		}
		int num = value.AvatarID;
		if (GameData.MultiplePathAvatarConfigData.TryGetValue(num, out MultiplePathAvatarConfigExcel value2))
		{
			num = value2.BaseAvatarID;
		}
		specialAvatarInfo = new SpecialAvatarInfo
		{
			SpecialAvatarId = value.SpecialAvatarID,
			AvatarId = value.AvatarID,
			BaseAvatarId = num,
			Level = value.Level,
			Promotion = value.Promotion
		};
		specialAvatarInfo.PathInfos.Add(value.AvatarID, new PathInfo(value.AvatarID)
		{
			Rank = value.Rank,
			EquipData = new ItemData
			{
				ItemId = value.EquipmentID,
				Level = value.EquipmentLevel,
				Promotion = value.EquipmentPromotion,
				Rank = value.EquipmentRank
			}
		});
		if (!GameData.AvatarConfigData.TryGetValue(specialAvatarInfo.BaseAvatarId, out AvatarConfigExcel _))
		{
			return specialAvatarInfo;
		}
		specialAvatarInfo.GetCurPathInfo().GetSkillTree();
		AvatarData.TrialAvatars.Add(specialAvatarInfo);
		return specialAvatarInfo;
	}

	public SpecialAvatarInfo? GetTrialAvatarByWorldLevel(int specialAvatarId, int worldLevel)
	{
		SpecialAvatarInfo specialAvatarInfo = AvatarData.TrialAvatars.Find((SpecialAvatarInfo a) => a.SpecialAvatarId == specialAvatarId);
		if (specialAvatarInfo != null)
		{
			return specialAvatarInfo;
		}
		SpecialAvatarExcel value = null;
		int num = worldLevel;
		while (num >= 0 && value == null)
		{
			GameData.SpecialAvatarData.TryGetValue(specialAvatarId * 10 + num, out value);
			num--;
		}
		if (value == null)
		{
			return null;
		}
		int num2 = value.AvatarID;
		if (GameData.MultiplePathAvatarConfigData.TryGetValue(num2, out MultiplePathAvatarConfigExcel value2))
		{
			num2 = value2.BaseAvatarID;
		}
		specialAvatarInfo = new SpecialAvatarInfo
		{
			SpecialAvatarId = value.SpecialAvatarID,
			AvatarId = value.AvatarID,
			BaseAvatarId = num2,
			Level = value.Level,
			Promotion = value.Promotion
		};
		specialAvatarInfo.PathInfos.Add(value.AvatarID, new PathInfo(value.AvatarID)
		{
			Rank = value.Rank,
			EquipData = new ItemData
			{
				ItemId = value.EquipmentID,
				Level = value.EquipmentLevel,
				Promotion = value.EquipmentPromotion,
				Rank = value.EquipmentRank
			}
		});
		if (!GameData.AvatarConfigData.TryGetValue(specialAvatarInfo.BaseAvatarId, out AvatarConfigExcel _))
		{
			return specialAvatarInfo;
		}
		specialAvatarInfo.GetCurPathInfo().GetSkillTree();
		AvatarData.TrialAvatars.Add(specialAvatarInfo);
		return specialAvatarInfo;
	}

	public FormalAvatarInfo? GetHero()
	{
		return AvatarData.FormalAvatars.Find((FormalAvatarInfo avatar) => avatar.BaseAvatarId == 8001);
	}

	public async ValueTask ReforgeRelic(int uniqueId)
	{
		ItemData relic = base.Player.InventoryManager.Data.RelicItems.FirstOrDefault((ItemData x) => x.UniqueId == uniqueId);
		if (relic == null)
		{
			return;
		}
		await base.Player.InventoryManager.RemoveItem(238, 1);
		List<ItemSubAffix> subAffixes = relic.SubAffixes.Select((ItemSubAffix x) => x.Clone()).ToList();
		int num = 0;
		foreach (ItemSubAffix subAffix in relic.SubAffixes)
		{
			num += subAffix.Count - 1;
			subAffix.Count = 1;
			subAffix.Step = 0;
		}
		relic.IncreaseRandomRelicSubAffix(num);
		relic.ReforgeSubAffixes = relic.SubAffixes;
		relic.SubAffixes = subAffixes;
		await base.Player.SendPacket(new PacketPlayerSyncScNotify(relic));
	}

	public async ValueTask ConfirmReforgeRelic(int uniqueId, bool isCancel)
	{
		ItemData itemData = base.Player.InventoryManager.Data.RelicItems.FirstOrDefault((ItemData x) => x.UniqueId == uniqueId);
		if (itemData != null && itemData.ReforgeSubAffixes.Count != 0)
		{
			if (!isCancel)
			{
				itemData.SubAffixes = itemData.ReforgeSubAffixes;
			}
			itemData.ReforgeSubAffixes = new List<ItemSubAffix>();
			await base.Player.SendPacket(new PacketPlayerSyncScNotify(itemData));
		}
	}

	public List<RelicSmartWearPlan> GetRelicPlan(int avatarId)
	{
		List<RelicSmartWearPlan> list = new List<RelicSmartWearPlan>();
		foreach (KeyValuePair<int, RelicPlanData> relicPlan in base.Player.InventoryManager.Data.RelicPlans)
		{
			if (relicPlan.Value.EquipAvatar == avatarId && (relicPlan.Value.InsideRelic.Count != 0 || relicPlan.Value.OutsideRelic.Count != 0))
			{
				list.Add(new RelicSmartWearPlan
				{
					AvatarId = (uint)avatarId,
					UniqueId = (uint)relicPlan.Key,
					OutsideRelicList = { relicPlan.Value.OutsideRelic.Select((int x) => (uint)x) },
					InsideRelicList = { relicPlan.Value.InsideRelic.Select((int x) => (uint)x) }
				});
			}
		}
		return list;
	}

	public RelicSmartWearPlan AddRelicPlan(RelicSmartWearPlan plan)
	{
		Dictionary<int, RelicPlanData>.KeyCollection keys = base.Player.InventoryManager.Data.RelicPlans.Keys;
		int num = ((keys.Count <= 0) ? 1 : (keys.Max() + 1));
		base.Player.InventoryManager.Data.RelicPlans[num] = new RelicPlanData
		{
			EquipAvatar = (int)plan.AvatarId,
			InsideRelic = plan.InsideRelicList.Select((uint x) => (int)x).ToList(),
			OutsideRelic = plan.OutsideRelicList.Select((uint x) => (int)x).ToList()
		};
		plan.UniqueId = (uint)num;
		return plan;
	}

	public void UpdateRelicPlan(RelicSmartWearPlan plan)
	{
		base.Player.InventoryManager.Data.RelicPlans[(int)plan.UniqueId] = new RelicPlanData
		{
			EquipAvatar = (int)plan.AvatarId,
			InsideRelic = plan.InsideRelicList.Select((uint x) => (int)x).ToList(),
			OutsideRelic = plan.OutsideRelicList.Select((uint x) => (int)x).ToList()
		};
	}

	public void DeleteRelicPlan(int uniqueId)
	{
		base.Player.InventoryManager.Data.RelicPlans[uniqueId] = new RelicPlanData();
	}
}
