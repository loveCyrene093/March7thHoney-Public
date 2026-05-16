using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Configuration;
using March7thHoney.Database;
using March7thHoney.Database.Friend;
using March7thHoney.Database.Player;
using March7thHoney.GameServer.Command;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server;
using March7thHoney.GameServer.Server.Packet.Send.Chat;
using March7thHoney.GameServer.Server.Packet.Send.Friend;
using March7thHoney.Kcp;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.Friend;

public class FriendManager(PlayerInstance player) : BasePlayerManager(player)
{
	public FriendData FriendData { get; set; } = DatabaseHelper.Instance.GetInstanceOrCreateNew<FriendData>(player.Uid);

	public async ValueTask<Retcode> AddFriend(int targetUid)
	{
		if (targetUid == base.Player.Uid)
		{
			return Retcode.RetSucc;
		}
		if (FriendData.FriendDetailList.ContainsKey(targetUid))
		{
			return Retcode.RetFriendAlreadyIsFriend;
		}
		if (FriendData.BlackList.Contains(targetUid))
		{
			return Retcode.RetFriendInBlacklist;
		}
		if (FriendData.SendApplyList.Contains(targetUid))
		{
			return Retcode.RetSucc;
		}
		FriendData instance = DatabaseHelper.Instance.GetInstance<FriendData>(targetUid);
		if (instance == null)
		{
			return Retcode.RetFriendPlayerNotFound;
		}
		if (instance.BlackList.Contains(base.Player.Uid))
		{
			return Retcode.RetFriendInTargetBlacklist;
		}
		if (instance.ReceiveApplyList.Contains(targetUid))
		{
			return Retcode.RetSucc;
		}
		FriendData.SendApplyList.Add(targetUid);
		instance.ReceiveApplyList.Add(base.Player.Uid);
		Connection activeConnection = Listener.GetActiveConnection(targetUid);
		if (activeConnection != null)
		{
			await activeConnection.SendPacket(new PacketSyncApplyFriendScNotify(base.Player.Data));
		}
		DatabaseHelper.ToSaveUidList.Add(targetUid);
		return Retcode.RetSucc;
	}

	public async ValueTask<PlayerData?> ConfirmAddFriend(int targetUid)
	{
		if (targetUid == base.Player.Uid)
		{
			return null;
		}
		if (FriendData.FriendDetailList.ContainsKey(targetUid))
		{
			return null;
		}
		if (FriendData.BlackList.Contains(targetUid))
		{
			return null;
		}
		FriendData instance = DatabaseHelper.Instance.GetInstance<FriendData>(targetUid);
		PlayerData targetData = PlayerData.GetPlayerByUid(targetUid);
		if (instance == null || targetData == null)
		{
			return null;
		}
		if (instance.FriendDetailList.ContainsKey(base.Player.Uid))
		{
			return null;
		}
		if (instance.BlackList.Contains(base.Player.Uid))
		{
			return null;
		}
		FriendData.ReceiveApplyList.Remove(targetUid);
		FriendData.FriendDetailList.Add(targetUid, new FriendDetailData());
		instance.SendApplyList.Remove(base.Player.Uid);
		instance.FriendDetailList.Add(base.Player.Uid, new FriendDetailData());
		Connection activeConnection = Listener.GetActiveConnection(targetUid);
		if (activeConnection != null)
		{
			await activeConnection.SendPacket(new PacketSyncHandleFriendScNotify((uint)base.Player.Uid, isAccept: true, base.Player.Data));
		}
		DatabaseHelper.ToSaveUidList.Add(targetUid);
		return targetData;
	}

	public async ValueTask RefuseAddFriend(int targetUid)
	{
		FriendData instance = DatabaseHelper.Instance.GetInstance<FriendData>(targetUid);
		if (instance != null)
		{
			FriendData.ReceiveApplyList.Remove(targetUid);
			instance.SendApplyList.Remove(base.Player.Uid);
			Connection activeConnection = Listener.GetActiveConnection(targetUid);
			if (activeConnection != null)
			{
				await activeConnection.SendPacket(new PacketSyncHandleFriendScNotify((uint)base.Player.Uid, isAccept: false, base.Player.Data));
			}
			DatabaseHelper.ToSaveUidList.Add(targetUid);
		}
	}

	public async ValueTask<PlayerData?> AddBlackList(int targetUid)
	{
		PlayerData blackInfo = GetFriendPlayerData(new List<int>(1) { targetUid }).First();
		FriendData instance = DatabaseHelper.Instance.GetInstance<FriendData>(targetUid);
		if (blackInfo == null || instance == null)
		{
			return null;
		}
		FriendData.FriendDetailList.Remove(targetUid);
		instance.FriendDetailList.Remove(base.Player.Uid);
		if (!FriendData.BlackList.Contains(targetUid))
		{
			FriendData.BlackList.Add(targetUid);
		}
		Connection activeConnection = Listener.GetActiveConnection(targetUid);
		if (activeConnection != null)
		{
			await activeConnection.SendPacket(new PacketSyncAddBlacklistScNotify(base.Player.Uid));
		}
		DatabaseHelper.ToSaveUidList.Add(targetUid);
		return blackInfo;
	}

	public void RemoveBlackList(int targetUid)
	{
		if (DatabaseHelper.Instance.GetInstance<FriendData>(targetUid) != null)
		{
			FriendData.BlackList.Remove(targetUid);
		}
	}

	public async ValueTask<int?> RemoveFriend(int targetUid)
	{
		FriendData instance = DatabaseHelper.Instance.GetInstance<FriendData>(targetUid);
		if (instance == null)
		{
			return null;
		}
		FriendData.FriendDetailList.Remove(targetUid);
		instance.FriendDetailList.Remove(base.Player.Uid);
		Connection activeConnection = Listener.GetActiveConnection(targetUid);
		if (activeConnection != null)
		{
			await activeConnection.SendPacket(new PacketSyncDeleteFriendScNotify(base.Player.Uid));
		}
		DatabaseHelper.ToSaveUidList.Add(targetUid);
		return targetUid;
	}

	public async ValueTask SendMessage(int sendUid, int recvUid, string? message = null, int? extraId = null)
	{
		FriendChatData data = BuildChatData(sendUid, recvUid, message, extraId);
		await PushPrivateMessageAsync(recvUid, (uint)sendUid, data);
		if (recvUid == ConfigManager.Config.ServerOption.ServerProfile.Uid && (message?.StartsWith('/') ?? false))
		{
			string cmd = message.Substring(1);
			CommandExecutor.ExecuteCommand(new PlayerCommandSender(base.Player), cmd);
		}
		PlayerInstance playerInstance = Listener.GetActiveConnection(recvUid)?.Player;
		if (playerInstance != null)
		{
			await playerInstance.FriendManager.ReceiveMessage(sendUid, recvUid, message, extraId);
			return;
		}
		FriendData instance = DatabaseHelper.Instance.GetInstance<FriendData>(recvUid);
		if (instance != null)
		{
			if (!instance.ChatHistory.TryGetValue(sendUid, out FriendChatHistory value))
			{
				instance.ChatHistory[sendUid] = new FriendChatHistory();
				value = instance.ChatHistory[sendUid];
			}
			value.MessageList.Add(data);
			DatabaseHelper.ToSaveUidList.Add(recvUid);
		}
	}

	public async ValueTask SendInviteMessage(int sendUid, int recvUid, object info)
	{
		await ValueTask.CompletedTask;
	}

	public async ValueTask ReceiveMessage(int sendUid, int recvUid, string? message = null, int? extraId = null)
	{
		FriendChatData data = BuildChatData(sendUid, recvUid, message, extraId);
		await PushPrivateMessageAsync(sendUid, (uint)sendUid, data);
	}

	public async ValueTask ReceiveInviteMessage(int sendUid, int recvUid, object info)
	{
		await ValueTask.CompletedTask;
	}

	public FriendDetailData? GetFriendDetailData(int uid)
	{
		if (uid == ConfigManager.Config.ServerOption.ServerProfile.Uid)
		{
			return new FriendDetailData
			{
				IsMark = true
			};
		}
		if (!FriendData.FriendDetailList.TryGetValue(uid, out FriendDetailData value))
		{
			return null;
		}
		return value;
	}

	public List<ChatMessageData> GetHistoryInfo(int uid)
	{
		if (!FriendData.ChatHistory.TryGetValue(uid, out FriendChatHistory value))
		{
			return new List<ChatMessageData>();
		}
		List<ChatMessageData> list = new List<ChatMessageData>();
		foreach (FriendChatData message in value.MessageList)
		{
			ChatData chatData = new ChatData();
			if (message.ExtraId > 0)
			{
				chatData.ExtraId = (uint)message.ExtraId;
			}
			else
			{
				chatData.MessageText = message.Message;
			}
			list.Add(new ChatMessageData
			{
				CreateTime = (ulong)message.SendTime,
				ExtraA = new ChatMessageExtra
				{
					Kind = 1u,
					Value = (ulong)message.SendUid
				},
				ExtraB = new ChatMessageExtra
				{
					Kind = 1u,
					Value = (ulong)message.ReceiveUid
				},
				MessageDatas = 
				{
					new MessageChatData
					{
						MessageType = ((message.ExtraId <= 0) ? MsgType.CustomText : MsgType.Emoji),
						ChatData = chatData
					}
				}
			});
		}
		list.Reverse();
		return list;
	}

	private static FriendChatData BuildChatData(int sendUid, int recvUid, string? message, int? extraId)
	{
		return new FriendChatData
		{
			SendUid = sendUid,
			ReceiveUid = recvUid,
			Message = (message ?? ""),
			ExtraId = extraId.GetValueOrDefault(),
			SendTime = Extensions.GetUnixSec()
		};
	}

	private async ValueTask PushPrivateMessageAsync(int historyKeyUid, uint sourceUid, FriendChatData data)
	{
		if (!FriendData.ChatHistory.TryGetValue(historyKeyUid, out FriendChatHistory value))
		{
			FriendData.ChatHistory[historyKeyUid] = new FriendChatHistory();
			value = FriendData.ChatHistory[historyKeyUid];
		}
		value.MessageList.Add(data);
		await base.Player.SendPacket(new PacketRevcMsgScNotify(sourceUid, (uint)data.ReceiveUid, (data.ExtraId > 0) ? null : data.Message, (uint)Math.Max(0, data.ExtraId), data.SendTime));
	}

	public List<PlayerData> GetFriendPlayerData(List<int>? uids = null)
	{
		List<PlayerData> list = new List<PlayerData>();
		if (uids == null)
		{
			uids = FriendData.FriendDetailList.Keys.ToList();
		}
		foreach (int uid in uids)
		{
			PlayerData playerByUid = PlayerData.GetPlayerByUid(uid);
			if (playerByUid != null)
			{
				list.Add(playerByUid);
			}
		}
		ServerProfile serverProfile = ConfigManager.Config.ServerOption.ServerProfile;
		list.Add(new PlayerData
		{
			Uid = serverProfile.Uid,
			HeadIcon = serverProfile.HeadIcon,
			Signature = serverProfile.Signature,
			Level = serverProfile.Level,
			WorldLevel = 0,
			Name = serverProfile.Name,
			ChatBubble = serverProfile.ChatBubbleId,
			PersonalCard = serverProfile.PersonalCardId
		});
		return list;
	}

	public List<PlayerData> GetBlackList()
	{
		List<PlayerData> list = new List<PlayerData>();
		foreach (int black in FriendData.BlackList)
		{
			PlayerData playerByUid = PlayerData.GetPlayerByUid(black);
			if (playerByUid != null)
			{
				list.Add(playerByUid);
			}
		}
		return list;
	}

	public List<PlayerData> GetSendApplyList()
	{
		List<PlayerData> list = new List<PlayerData>();
		foreach (int sendApply in FriendData.SendApplyList)
		{
			PlayerData playerByUid = PlayerData.GetPlayerByUid(sendApply);
			if (playerByUid != null)
			{
				list.Add(playerByUid);
			}
		}
		return list;
	}

	public List<PlayerData> GetReceiveApplyList()
	{
		List<PlayerData> list = new List<PlayerData>();
		foreach (int receiveApply in FriendData.ReceiveApplyList)
		{
			PlayerData playerByUid = PlayerData.GetPlayerByUid(receiveApply);
			if (playerByUid != null)
			{
				list.Add(playerByUid);
			}
		}
		return list;
	}

	public List<PlayerData> GetRandomFriend()
	{
		List<PlayerData> list = new List<PlayerData>();
		foreach (March7thHoneyConnection value in March7thHoneyListener.Connections.Values)
		{
			if (value.State == SessionStateEnum.ACTIVE && value is Connection connection && connection.Player?.Uid != base.Player.Uid)
			{
				PlayerData playerData = connection.Player?.Data;
				if (playerData != null)
				{
					list.Add(playerData);
				}
			}
		}
		return list.Take(20).ToList();
	}

	public void RemarkFriendName(int uid, string remarkName)
	{
		if (FriendData.FriendDetailList.TryGetValue(uid, out FriendDetailData value))
		{
			value.RemarkName = remarkName;
		}
	}

	public void MarkFriend(int uid, bool isMark)
	{
		if (FriendData.FriendDetailList.TryGetValue(uid, out FriendDetailData value))
		{
			value.IsMark = isMark;
		}
	}

	public GetFriendListInfoScRsp ToProto()
	{
		GetFriendListInfoScRsp getFriendListInfoScRsp = new GetFriendListInfoScRsp();
		foreach (PlayerData friendPlayerDatum in GetFriendPlayerData())
		{
			FriendOnlineStatus status = ((Listener.GetActiveConnection(friendPlayerDatum.Uid) != null) ? FriendOnlineStatus.Online : FriendOnlineStatus.Offline);
			FriendDetailData friendDetailData = GetFriendDetailData(friendPlayerDatum.Uid) ?? new FriendDetailData();
			getFriendListInfoScRsp.FriendList.Add(new FriendSimpleInfo
			{
				PlayerInfo = friendPlayerDatum.ToSimpleProto(status),
				IsMarked = friendDetailData.IsMark,
				RemarkName = friendDetailData.RemarkName
			});
		}
		foreach (PlayerData black in GetBlackList())
		{
			FriendOnlineStatus status2 = ((Listener.GetActiveConnection(black.Uid) != null) ? FriendOnlineStatus.Online : FriendOnlineStatus.Offline);
			getFriendListInfoScRsp.BlackList.Add(black.ToSimpleProto(status2));
		}
		return getFriendListInfoScRsp;
	}

	public GetFriendApplyListInfoScRsp ToApplyListProto()
	{
		GetFriendApplyListInfoScRsp getFriendApplyListInfoScRsp = new GetFriendApplyListInfoScRsp();
		foreach (PlayerData sendApply in GetSendApplyList())
		{
			getFriendApplyListInfoScRsp.SendApplyList.Add((uint)sendApply.Uid);
		}
		foreach (PlayerData receiveApply in GetReceiveApplyList())
		{
			FriendOnlineStatus status = ((Listener.GetActiveConnection(receiveApply.Uid) != null) ? FriendOnlineStatus.Online : FriendOnlineStatus.Offline);
			getFriendApplyListInfoScRsp.ReceiveApplyList.Add(new FriendApplyInfo
			{
				PlayerInfo = receiveApply.ToSimpleProto(status)
			});
		}
		return getFriendApplyListInfoScRsp;
	}
}
