using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Player;

namespace March7thHoney.GameServer.Server.Packet.Recv.Player;

[Opcode(70)]
public class HandlerGetVideoVersionKeyCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketGetVideoVersionKeyScRsp());
	}
}
