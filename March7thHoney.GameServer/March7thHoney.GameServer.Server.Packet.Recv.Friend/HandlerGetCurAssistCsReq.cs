using System.Threading.Tasks;

namespace March7thHoney.GameServer.Server.Packet.Recv.Friend;

[Opcode(2908)]
public class HandlerGetCurAssistCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(2917);
	}
}
