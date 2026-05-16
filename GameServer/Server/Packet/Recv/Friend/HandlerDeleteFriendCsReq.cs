using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Friend;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Friend;

[Opcode(2974)]
public class HandlerDeleteFriendCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		DeleteFriendCsReq deleteFriendCsReq = DeleteFriendCsReq.Parser.ParseFrom(data);
		int? num = await connection.Player.FriendManager.RemoveFriend((int)deleteFriendCsReq.Uid);
		if (!num.HasValue)
		{
			await connection.SendPacket(new PacketDeleteFriendScRsp());
		}
		else
		{
			await connection.SendPacket(new PacketDeleteFriendScRsp((uint)num.Value));
		}
	}
}
