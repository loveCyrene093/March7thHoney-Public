using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.MarkChest;

namespace March7thHoney.GameServer.Server.Packet.Recv.MarkChest;

[Opcode(8181)]
public class HandlerGetMarkChestCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketGetMarkChestScRsp(connection.Player));
	}
}
