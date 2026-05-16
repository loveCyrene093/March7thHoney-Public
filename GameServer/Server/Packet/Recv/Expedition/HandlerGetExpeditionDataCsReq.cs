using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Expedition;

namespace March7thHoney.GameServer.Server.Packet.Recv.Expedition;

[Opcode(2513)]
public class HandlerGetExpeditionDataCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketGetExpeditionDataScRsp(connection.Player));
	}
}
