using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database;
using March7thHoney.Database.Message;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.PlayerSync;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.Message;

public class MessageManager(PlayerInstance player) : BasePlayerManager(player)
{
	public MessageData Data { get; } = DatabaseHelper.Instance.GetInstanceOrCreateNew<MessageData>(player.Uid);

	public List<MessageSectionData> PendingMessagePerformSectionList { get; private set; } = new List<MessageSectionData>();

	public MessageSectionData? GetMessageSectionData(int sectionId)
	{
		GameData.MessageSectionConfigData.TryGetValue(sectionId, out MessageSectionConfigExcel value);
		if (value == null)
		{
			return null;
		}
		int groupID = value.GroupID;
		if (!Data.Groups.TryGetValue(groupID, out MessageGroupData value2))
		{
			return null;
		}
		return value2.Sections.FirstOrDefault((MessageSectionData m) => m.SectionId == sectionId);
	}

	public List<MessageGroup> GetMessageGroup(int contactId)
	{
		GameData.MessageContactsConfigData.TryGetValue(contactId, out MessageContactsConfigExcel value);
		if (value == null)
		{
			return new List<MessageGroup>();
		}
		bool flag = !ConfigManager.Config.ServerOption.EnableMission;
		List<MessageGroup> list = new List<MessageGroup>();
		foreach (MessageGroupConfigExcel group in value.Groups)
		{
			if (Data.Groups.TryGetValue(group.ID, out MessageGroupData value2))
			{
				MessageGroup messageGroup = new MessageGroup
				{
					Id = (uint)group.ID,
					Status = value2.Status,
					RefreshTime = value2.RefreshTime
				};
				foreach (MessageSectionData section in value2.Sections)
				{
					MessageSection messageSection = new MessageSection
					{
						Id = (uint)section.SectionId,
						Status = section.Status
					};
					messageSection.MessageItemList.AddRange(section.ToChooseItemId.Select((int m) => (uint)m));
					messageSection.ItemList.AddRange(section.Items.Select((MessageItemData m) => new MessageItem
					{
						ItemId = (uint)m.ItemId
					}));
					messageGroup.MessageSectionList.Add(messageSection);
				}
				messageGroup.MessageSectionId = (uint)value2.CurrentSectionId;
				list.Add(messageGroup);
			}
			else if (flag)
			{
				MessageGroup messageGroup2 = new MessageGroup
				{
					Id = (uint)group.ID,
					Status = MessageGroupStatus.MessageGroupFinish,
					RefreshTime = Extensions.GetUnixSec()
				};
				if (GameData.MessageGroupConfigData.TryGetValue(group.ID, out MessageGroupConfigExcel value3))
				{
					foreach (int messageSectionID in value3.MessageSectionIDList)
					{
						messageGroup2.MessageSectionList.Add(new MessageSection
						{
							Id = (uint)messageSectionID,
							Status = MessageSectionStatus.MessageSectionFinish
						});
					}
					if (value3.MessageSectionIDList.Count > 0)
					{
						List<int> messageSectionIDList = value3.MessageSectionIDList;
						messageGroup2.MessageSectionId = (uint)messageSectionIDList[messageSectionIDList.Count - 1];
					}
				}
				list.Add(messageGroup2);
			}
			else
			{
				list.Add(new MessageGroup
				{
					Id = (uint)group.ID,
					Status = MessageGroupStatus.MessageGroupNone,
					RefreshTime = 0L
				});
			}
		}
		return list;
	}

	public async ValueTask AddMessageSection(int sectionId)
	{
		GameData.MessageSectionConfigData.TryGetValue(sectionId, out MessageSectionConfigExcel value);
		if (value == null || (Data.Groups.TryGetValue(value.GroupID, out MessageGroupData value2) && value2.Sections.Find((MessageSectionData x) => x.SectionId == sectionId) != null))
		{
			return;
		}
		foreach (int startMessageItemID in value.StartMessageItemIDList)
		{
			await AddMessageItem(startMessageItemID);
		}
	}

	public async ValueTask AddMessageItem(int itemId, bool sendPacket = true)
	{
		GameData.MessageItemConfigData.TryGetValue(itemId, out MessageItemConfigExcel value);
		if (value == null)
		{
			return;
		}
		int groupID = value.GroupID;
		int sectionId = value.SectionID;
		if (!Data.Groups.TryGetValue(groupID, out MessageGroupData group))
		{
			group = new MessageGroupData
			{
				GroupId = groupID,
				CurrentSectionId = sectionId,
				RefreshTime = Extensions.GetUnixSec(),
				Status = MessageGroupStatus.MessageGroupDoing
			};
			group.Sections.Add(new MessageSectionData
			{
				SectionId = sectionId,
				Status = MessageSectionStatus.MessageSectionDoing,
				ToChooseItemId = value.NextItemIDList
			});
			Data.Groups.Add(groupID, group);
		}
		else
		{
			group.CurrentSectionId = sectionId;
			group.RefreshTime = Extensions.GetUnixSec();
			group.Status = MessageGroupStatus.MessageGroupDoing;
			if (group.Sections.All((MessageSectionData m) => m.SectionId != sectionId))
			{
				group.Sections.Add(new MessageSectionData
				{
					SectionId = sectionId,
					Status = MessageSectionStatus.MessageSectionDoing,
					ToChooseItemId = value.NextItemIDList
				});
				if (value.NextItemIDList.Count == 1)
				{
					await FinishMessageItem(value.NextItemIDList[0], sendPacket: false);
				}
			}
			else
			{
				group.Sections.First((MessageSectionData m) => m.SectionId == sectionId).Status = MessageSectionStatus.MessageSectionDoing;
			}
		}
		if (sendPacket)
		{
			PacketPlayerSyncScNotify packet = new PacketPlayerSyncScNotify(group, group.Sections.First((MessageSectionData m) => m.SectionId == sectionId));
			await base.Player.SendPacket(packet);
		}
	}

	public async ValueTask FinishSection(int sectionId, bool sendPacket = true)
	{
		GameData.MessageSectionConfigData.TryGetValue(sectionId, out MessageSectionConfigExcel value);
		if (value == null)
		{
			return;
		}
		int groupID = value.GroupID;
		if (!Data.Groups.TryGetValue(groupID, out MessageGroupData value2))
		{
			return;
		}
		MessageSectionData messageSectionData = value2.Sections.First((MessageSectionData m) => m.SectionId == sectionId);
		if (messageSectionData.Status == MessageSectionStatus.MessageSectionDoing)
		{
			messageSectionData.Status = MessageSectionStatus.MessageSectionFinish;
			if (value2.Sections.All((MessageSectionData m) => m.Status == MessageSectionStatus.MessageSectionFinish))
			{
				value2.Status = MessageGroupStatus.MessageGroupFinish;
			}
			if (sendPacket)
			{
				PacketPlayerSyncScNotify packet = new PacketPlayerSyncScNotify(value2, messageSectionData);
				await base.Player.SendPacket(packet);
			}
			await base.Player.MissionManager.HandleFinishType(MissionFinishTypeEnum.MessagePerformSectionFinish);
			await base.Player.MissionManager.HandleFinishType(MissionFinishTypeEnum.MessageSectionFinish);
		}
	}

	public async ValueTask FinishMessageItem(int itemId, bool sendPacket = true)
	{
		GameData.MessageItemConfigData.TryGetValue(itemId, out MessageItemConfigExcel value);
		if (value == null)
		{
			return;
		}
		int groupID = value.GroupID;
		int sectionId = value.SectionID;
		if (!Data.Groups.TryGetValue(groupID, out MessageGroupData group))
		{
			return;
		}
		MessageSectionData section = group.Sections.First((MessageSectionData m) => m.SectionId == sectionId);
		if (section.Status == MessageSectionStatus.MessageSectionDoing)
		{
			section.ToChooseItemId.Clear();
			section.Items.Add(new MessageItemData
			{
				ItemId = itemId
			});
			section.ToChooseItemId.AddRange(value.NextItemIDList);
			group.RefreshTime = Extensions.GetUnixSec();
			if (section.ToChooseItemId.Count == 1)
			{
				await FinishMessageItem(section.ToChooseItemId[0], sendPacket: false);
			}
			if (sendPacket)
			{
				PacketPlayerSyncScNotify packet = new PacketPlayerSyncScNotify(group, section);
				await base.Player.SendPacket(packet);
			}
		}
	}
}
