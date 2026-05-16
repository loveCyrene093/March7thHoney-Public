using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Chat;

public class PacketRevcMsgScNotify : BasePacket
{
	public PacketRevcMsgScNotify(uint fromUid, uint toUid, string? message, uint extraId, long sendTime)
		: base(3994)
	{
		ChatMessageData recvMessageData = BuildChat(fromUid, toUid, message, extraId, sendTime);
		RevcMsgScNotify data = new RevcMsgScNotify
		{
			ChatType = ChatType.Private,
			SourceUid = fromUid,
			RecvMessageData = recvMessageData
		};
		SetData(data);
	}

	private static ChatMessageData BuildChat(uint fromUid, uint toUid, string? message, uint extraId, long sendTime)
	{
		ChatData chatData = new ChatData();
		if (extraId != 0)
		{
			chatData.ExtraId = extraId;
		}
		else
		{
			chatData.MessageText = message ?? "";
		}
		return new ChatMessageData
		{
			CreateTime = (ulong)sendTime,
			ExtraA = new ChatMessageExtra
			{
				Kind = 1u,
				Value = fromUid
			},
			ExtraB = new ChatMessageExtra
			{
				Kind = 1u,
				Value = toUid
			},
			MessageDatas = 
			{
				new MessageChatData
				{
					MessageType = ((extraId == 0) ? MsgType.CustomText : MsgType.Emoji),
					ChatData = chatData
				}
			}
		};
	}
}
