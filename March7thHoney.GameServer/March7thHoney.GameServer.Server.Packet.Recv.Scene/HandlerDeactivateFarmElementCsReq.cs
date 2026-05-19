using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Scene;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Scene;

[Opcode(1466)]
public class HandlerDeactivateFarmElementCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		DeactivateFarmElementCsReq deactivateFarmElementCsReq = DeactivateFarmElementCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		if (player.ActiveFarmElementEntityId == deactivateFarmElementCsReq.EntityId)
		{
			player.ActiveFarmElementEntityId = 0u;
			player.FarmElementReturnPos = null;
			player.FarmElementReturnRot = null;
		}
		await connection.SendPacket(new PacketDeactivateFarmElementScRsp(deactivateFarmElementCsReq.EntityId));
	}
}
