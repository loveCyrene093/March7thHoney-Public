using System.Collections.Generic;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Chat;

public class PacketGetPrivateChatHistoryScRsp : BasePacket
{
	public PacketGetPrivateChatHistoryScRsp(uint contactSide, uint targetSide, PlayerInstance player)
		: base(3918)
	{
		GetPrivateChatHistoryScRsp getPrivateChatHistoryScRsp = new GetPrivateChatHistoryScRsp
		{
			ContactSide = contactSide,
			TargetSide = targetSide
		};
		List<ChatMessageData> historyInfo = player.FriendManager.GetHistoryInfo((int)targetSide);
		getPrivateChatHistoryScRsp.ChatMessageList.AddRange(historyInfo);
		SetData(getPrivateChatHistoryScRsp);
	}
}
