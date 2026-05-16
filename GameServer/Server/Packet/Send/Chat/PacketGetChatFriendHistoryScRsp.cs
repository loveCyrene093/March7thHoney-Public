using System.Collections.Generic;
using System.Linq;
using March7thHoney.Database.Friend;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Chat;

public class PacketGetChatFriendHistoryScRsp : BasePacket
{
	public PacketGetChatFriendHistoryScRsp(Dictionary<int, FriendChatHistory> history)
		: base(3998)
	{
		GetChatFriendHistoryScRsp getChatFriendHistoryScRsp = new GetChatFriendHistoryScRsp();
		foreach (KeyValuePair<int, FriendChatHistory> item in history)
		{
			getChatFriendHistoryScRsp.FriendHistoryInfo.Add(new FriendHistoryInfo
			{
				ContactSide = (uint)item.Key,
				LastSendTime = item.Value.MessageList.Last().SendTime
			});
		}
		SetData(getChatFriendHistoryScRsp);
	}
}
