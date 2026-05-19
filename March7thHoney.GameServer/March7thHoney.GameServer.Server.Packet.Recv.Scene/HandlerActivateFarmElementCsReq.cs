using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Scene;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Scene;

[Opcode(1411)]
public class HandlerActivateFarmElementCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		ActiveFarmElementCsReq activeFarmElementCsReq = ActiveFarmElementCsReq.Parser.ParseFrom(data);
		PlayerInstance? player = connection.Player;
		player.ActiveFarmElementEntityId = activeFarmElementCsReq.EntityId;
		player.FarmElementReturnPos = player.Data.Pos;
		player.FarmElementReturnRot = player.Data.Rot;
		await connection.SendPacket(new PacketActivateFarmElementScRsp(activeFarmElementCsReq.EntityId, activeFarmElementCsReq.WorldLevel));
	}
}
