using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Friend;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Friend;

[Opcode(2989)]
public class HandlerDeleteBlacklistCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		DeleteBlacklistCsReq deleteBlacklistCsReq = DeleteBlacklistCsReq.Parser.ParseFrom(data);
		connection.Player.FriendManager.RemoveBlackList((int)deleteBlacklistCsReq.Uid);
		await connection.SendPacket(new PacketDeleteBlacklistScRsp(deleteBlacklistCsReq.Uid));
	}
}
