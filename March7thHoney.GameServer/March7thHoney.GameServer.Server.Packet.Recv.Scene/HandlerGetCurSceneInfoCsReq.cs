using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Scene;

namespace March7thHoney.GameServer.Server.Packet.Recv.Scene;

[Opcode(1409)]
public class HandlerGetCurSceneInfoCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketGetCurSceneInfoScRsp(connection.Player));
	}
}
