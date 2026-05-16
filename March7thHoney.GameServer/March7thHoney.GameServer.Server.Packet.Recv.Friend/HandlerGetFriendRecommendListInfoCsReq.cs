using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.Database.Player;
using March7thHoney.GameServer.Server.Packet.Send.Friend;

namespace March7thHoney.GameServer.Server.Packet.Recv.Friend;

[Opcode(2933)]
public class HandlerGetFriendRecommendListInfoCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		List<PlayerData> randomFriend = connection.Player.FriendManager.GetRandomFriend();
		await connection.SendPacket(new PacketGetFriendRecommendListInfoScRsp(randomFriend));
	}
}
