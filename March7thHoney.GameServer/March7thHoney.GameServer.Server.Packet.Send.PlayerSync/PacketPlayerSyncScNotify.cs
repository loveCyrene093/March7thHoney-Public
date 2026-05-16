using System.Collections.Generic;
using System.Linq;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Avatar;
using March7thHoney.Database.Inventory;
using March7thHoney.Database.Message;
using March7thHoney.Database.Quests;
using March7thHoney.Enums.Item;
using March7thHoney.GameServer.Game.Sync;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.PlayerSync;

public class PacketPlayerSyncScNotify : BasePacket
{
	public PacketPlayerSyncScNotify(List<BaseSyncData> datas)
		: base(691)
	{
		PlayerSyncScNotify notify = new PlayerSyncScNotify();
		foreach (BaseSyncData data in datas)
		{
			data.SyncData(in notify);
		}
		SetData(notify);
	}

	public PacketPlayerSyncScNotify(ItemData item)
		: base(691)
	{
		PlayerSyncScNotify playerSyncScNotify = new PlayerSyncScNotify();
		AddItemToProto(item, playerSyncScNotify);
		SetData(playerSyncScNotify);
	}

	public PacketPlayerSyncScNotify(List<ItemData> item)
		: base(691)
	{
		PlayerSyncScNotify playerSyncScNotify = new PlayerSyncScNotify();
		foreach (ItemData item2 in item)
		{
			AddItemToProto(item2, playerSyncScNotify);
		}
		SetData(playerSyncScNotify);
	}

	public PacketPlayerSyncScNotify(BaseAvatarInfo avatar)
		: base(691)
	{
		PlayerSyncScNotify playerSyncScNotify = new PlayerSyncScNotify
		{
			AvatarSync = new AvatarSync()
		};
		AddAvatarToProto(avatar, playerSyncScNotify.AvatarSync);
		SetData(playerSyncScNotify);
	}

	public PacketPlayerSyncScNotify(List<BaseAvatarInfo> avatars)
		: base(691)
	{
		PlayerSyncScNotify playerSyncScNotify = new PlayerSyncScNotify
		{
			AvatarSync = new AvatarSync()
		};
		foreach (BaseAvatarInfo avatar in avatars)
		{
			AddAvatarToProto(avatar, playerSyncScNotify.AvatarSync);
		}
		SetData(playerSyncScNotify);
	}

	public PacketPlayerSyncScNotify(List<FormalAvatarInfo> avatars)
		: base(691)
	{
		PlayerSyncScNotify playerSyncScNotify = new PlayerSyncScNotify
		{
			AvatarSync = new AvatarSync()
		};
		foreach (FormalAvatarInfo avatar in avatars)
		{
			AddAvatarToProto(avatar, playerSyncScNotify.AvatarSync);
		}
		SetData(playerSyncScNotify);
	}

	public PacketPlayerSyncScNotify(BaseAvatarInfo avatar, ItemData item)
		: base(691)
	{
		PlayerSyncScNotify playerSyncScNotify = new PlayerSyncScNotify();
		AddItemToProto(item, playerSyncScNotify);
		playerSyncScNotify.AvatarSync = new AvatarSync();
		AddAvatarToProto(avatar, playerSyncScNotify.AvatarSync);
		SetData(playerSyncScNotify);
	}

	public PacketPlayerSyncScNotify(MissionSync mission)
		: base(691)
	{
		PlayerSyncScNotify data = new PlayerSyncScNotify
		{
			MissionSync = mission
		};
		SetData(data);
	}

	public PacketPlayerSyncScNotify(PlayerBasicInfo info)
		: base(691)
	{
		PlayerSyncScNotify data = new PlayerSyncScNotify
		{
			BasicInfo = info
		};
		SetData(data);
	}

	public PacketPlayerSyncScNotify(PlayerBasicInfo info, List<ItemData> item)
		: base(691)
	{
		PlayerSyncScNotify playerSyncScNotify = new PlayerSyncScNotify
		{
			BasicInfo = info
		};
		foreach (ItemData item2 in item)
		{
			AddItemToProto(item2, playerSyncScNotify);
		}
		SetData(playerSyncScNotify);
	}

	public PacketPlayerSyncScNotify(PlayerOutfitInfo playerOutfitData)
		: base(691)
	{
		PlayerSyncScNotify data = new PlayerSyncScNotify
		{
			PlayerOutfitData = playerOutfitData
		};
		SetData(data);
	}

	public PacketPlayerSyncScNotify(MessageGroupData? groupData, MessageSectionData? sectionData)
		: base(691)
	{
		PlayerSyncScNotify playerSyncScNotify = new PlayerSyncScNotify
		{
			SyncStatus = new SyncStatus()
		};
		if (groupData != null)
		{
			playerSyncScNotify.SyncStatus.MessageGroupStatus.Add(new GroupStatus
			{
				GroupId = (uint)groupData.GroupId,
				GroupStatus_ = groupData.Status,
				RefreshTime = groupData.RefreshTime
			});
		}
		if (sectionData != null)
		{
			playerSyncScNotify.SyncStatus.SectionStatus.Add(new SectionStatus
			{
				SectionId = (uint)sectionData.SectionId,
				SectionStatus_ = sectionData.Status
			});
		}
		SetData(playerSyncScNotify);
	}

	public PacketPlayerSyncScNotify(QuestInfo quest)
		: base(691)
	{
		SetData(new PlayerSyncScNotify
		{
			QuestList = { quest.ToProto() }
		});
	}

	public PacketPlayerSyncScNotify(List<QuestInfo> quest)
		: base(691)
	{
		SetData(new PlayerSyncScNotify
		{
			QuestList = { quest.Select((QuestInfo x) => x.ToProto()) }
		});
	}

	private void AddItemToProto(ItemData item, PlayerSyncScNotify notify)
	{
		GameData.ItemConfigData.TryGetValue(item.ItemId, out ItemConfigExcel value);
		if (value == null)
		{
			return;
		}
		switch (value.ItemMainType)
		{
		case ItemMainTypeEnum.Equipment:
			if (item.Count > 0)
			{
				notify.EquipmentList.Add(item.ToEquipmentProto());
			}
			else
			{
				notify.DelEquipmentList.Add((uint)item.UniqueId);
			}
			break;
		case ItemMainTypeEnum.Relic:
			if (item.Count > 0)
			{
				notify.RelicList.Add(item.ToRelicProto());
			}
			else
			{
				notify.DelRelicList.Add((uint)item.UniqueId);
			}
			break;
		case ItemMainTypeEnum.Usable:
		case ItemMainTypeEnum.Material:
		case ItemMainTypeEnum.Mission:
		case ItemMainTypeEnum.Pet:
			notify.MaterialList.Add(item.ToMaterialProto());
			break;
		case ItemMainTypeEnum.Display:
			break;
		}
	}

	private static void AddAvatarToProto(BaseAvatarInfo avatar, AvatarSync sync)
	{
		sync.AvatarList.Add(avatar.ToProto());
		if (avatar is FormalAvatarInfo formalAvatarInfo)
		{
			sync.AvatarPathDataInfoList.Add(formalAvatarInfo.ToAvatarPathDataProto());
		}
	}
}
