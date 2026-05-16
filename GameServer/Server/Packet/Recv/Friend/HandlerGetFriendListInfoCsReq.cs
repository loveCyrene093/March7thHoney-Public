using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Friend;

namespace March7thHoney.GameServer.Server.Packet.Recv.Friend;

[Opcode(2991)]
public class HandlerGetFriendListInfoCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketGetFriendListInfoScRsp(connection));
	}
}
