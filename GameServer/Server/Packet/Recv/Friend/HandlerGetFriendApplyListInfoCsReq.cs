using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Friend;

namespace March7thHoney.GameServer.Server.Packet.Recv.Friend;

[Opcode(2914)]
public class HandlerGetFriendApplyListInfoCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketGetFriendApplyListInfoCsReq(connection));
	}
}
