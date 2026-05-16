using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.PlayerBoard;

namespace March7thHoney.GameServer.Server.Packet.Recv.PlayerBoard;

[Opcode(2891)]
public class HandlerGetPlayerBoardDataCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketGetPlayerBoardDataScRsp(connection.Player));
	}
}
