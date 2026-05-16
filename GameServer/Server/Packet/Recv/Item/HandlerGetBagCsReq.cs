using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Item;

namespace March7thHoney.GameServer.Server.Packet.Recv.Item;

[Opcode(591)]
public class HandlerGetBagCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketGetBagScRsp(connection.Player));
	}
}
