using System.Collections.Generic;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Inventory;
using March7thHoney.Database.Lineup;
using March7thHoney.Proto;

namespace March7thHoney.Database.Avatar;

public class SpecialAvatarInfo : BaseAvatarInfo
{
	public int SpecialAvatarId { get; set; }

	public void CheckLevel(int worldLevel)
	{
		if (GameData.SpecialAvatarData.TryGetValue(base.AvatarId * 10 + worldLevel, out SpecialAvatarExcel value) || GameData.SpecialAvatarData.TryGetValue(base.AvatarId * 10 + 1, out value))
		{
			base.Level = value.Level;
			base.Promotion = value.Promotion;
			GetCurPathInfo().Rank = value.Rank;
			GetCurPathInfo().EquipData = new ItemData
			{
				ItemId = value.EquipmentID,
				Level = value.EquipmentLevel,
				Promotion = value.EquipmentPromotion,
				Rank = value.EquipmentRank
			};
		}
	}

	public override March7thHoney.Proto.Avatar ToProto()
	{
		March7thHoney.Proto.Avatar avatar = new March7thHoney.Proto.Avatar
		{
			BaseAvatarId = (uint)base.BaseAvatarId,
			Level = (uint)base.Level,
			Promotion = (uint)base.Promotion,
			CurMultiPathAvatarType = (uint)GetCurPathInfo().PathId
		};
		if (GetCurPathInfo().EquipId != 0)
		{
			avatar.EquipmentUniqueId = (uint)GetCurPathInfo().EquipId;
		}
		return avatar;
	}

	public override LineupAvatar ToLineupInfo(int slot, March7thHoney.Database.Lineup.LineupInfo info, AvatarType avatarType = AvatarType.AvatarFormalType)
	{
		return new LineupAvatar
		{
			Id = (uint)SpecialAvatarId,
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
		BattleAvatar battleAvatar = new BattleAvatar
		{
			Id = (uint)SpecialAvatarId,
			AvatarType = avatarType,
			Level = (uint)base.Level,
			Promotion = (uint)base.Promotion,
			Rank = (uint)GetCurPathInfo().Rank,
			Index = (uint)collection.LineupInfo.GetSlot(base.BaseAvatarId),
			Hp = (uint)GetCurHp(collection.LineupInfo.LineupType != 0),
			SpBar = new SpBarInfo
			{
				CurSp = (uint)GetCurSp(collection.LineupInfo.LineupType != 0),
				MaxSp = 10000u
			},
			WorldLevel = (uint)collection.PlayerData.WorldLevel
		};
		foreach (KeyValuePair<int, int> item in GetCurPathInfo().GetSkillTree())
		{
			battleAvatar.SkilltreeList.Add(new AvatarSkillTree
			{
				PointId = (uint)item.Key,
				Level = (uint)item.Value
			});
		}
		foreach (KeyValuePair<int, int> relic in GetCurPathInfo().Relic)
		{
			ItemData itemData = collection.InventoryData.RelicItems?.Find((ItemData item) => item.UniqueId == relic.Value);
			if (itemData == null)
			{
				continue;
			}
			BattleRelic battleRelic = new BattleRelic
			{
				Id = (uint)itemData.ItemId,
				UniqueId = (uint)itemData.UniqueId,
				Level = (uint)itemData.Level,
				MainAffixId = (uint)itemData.MainAffix
			};
			if (itemData.SubAffixes.Count >= 1)
			{
				foreach (ItemSubAffix subAffix in itemData.SubAffixes)
				{
					battleRelic.SubAffixList.Add(subAffix.ToProto());
				}
			}
			battleAvatar.RelicList.Add(battleRelic);
		}
		if (GetCurPathInfo().EquipId != 0)
		{
			ItemData itemData2 = collection.InventoryData.EquipmentItems.Find((ItemData item) => item.UniqueId == GetCurPathInfo().EquipId);
			if (itemData2 != null)
			{
				battleAvatar.EquipmentList.Add(new BattleEquipment
				{
					Id = (uint)itemData2.ItemId,
					Level = (uint)itemData2.Level,
					Promotion = (uint)itemData2.Promotion,
					Rank = (uint)itemData2.Rank
				});
			}
		}
		else if (GetCurPathInfo().EquipData != null)
		{
			battleAvatar.EquipmentList.Add(new BattleEquipment
			{
				Id = (uint)GetCurPathInfo().EquipData.ItemId,
				Level = (uint)GetCurPathInfo().EquipData.Level,
				Promotion = (uint)GetCurPathInfo().EquipData.Promotion,
				Rank = (uint)GetCurPathInfo().EquipData.Rank
			});
		}
		return battleAvatar;
	}
}
