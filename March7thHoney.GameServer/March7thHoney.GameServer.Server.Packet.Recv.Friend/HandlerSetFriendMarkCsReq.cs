using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Friend;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Friend;

[Opcode(2971)]
public class HandlerSetFriendMarkCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SetFriendMarkCsReq setFriendMarkCsReq = SetFriendMarkCsReq.Parser.ParseFrom(data);
		connection.Player.FriendManager.MarkFriend((int)setFriendMarkCsReq.Uid, setFriendMarkCsReq.KBNKNAHGPHG);
		await connection.SendPacket(new PacketSetFriendMarkScRsp(setFriendMarkCsReq.Uid, setFriendMarkCsReq.KBNKNAHGPHG));
	}
}
