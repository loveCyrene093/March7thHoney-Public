using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.Database.Friend;
using March7thHoney.GameServer.Server.Packet.Send.Chat;

namespace March7thHoney.GameServer.Server.Packet.Recv.Chat;

[Opcode(3909)]
public class HandlerGetChatFriendHistoryCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		Dictionary<int, FriendChatHistory> chatHistory = connection.Player.FriendManager.FriendData.ChatHistory;
		await connection.SendPacket(new PacketGetChatFriendHistoryScRsp(chatHistory));
	}
}
