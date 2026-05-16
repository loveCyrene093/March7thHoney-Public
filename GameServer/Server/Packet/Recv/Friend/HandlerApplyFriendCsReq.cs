using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Friend;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Friend;

[Opcode(2909)]
public class HandlerApplyFriendCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		ApplyFriendCsReq req = ApplyFriendCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketApplyFriendScRsp(await connection.Player.FriendManager.AddFriend((int)req.Uid), req.Uid));
	}
}
