using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Scene;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Scene;

[Opcode(1466)]
public class HandlerDeactivateFarmElementCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		DeactivateFarmElementCsReq deactivateFarmElementCsReq = DeactivateFarmElementCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketDeactivateFarmElementScRsp(deactivateFarmElementCsReq.EntityId));
	}
}
