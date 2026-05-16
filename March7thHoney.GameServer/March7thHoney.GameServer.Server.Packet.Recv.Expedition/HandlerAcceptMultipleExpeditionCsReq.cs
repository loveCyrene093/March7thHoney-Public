using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Expedition;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Expedition;

[Opcode(2503)]
public class HandlerAcceptMultipleExpeditionCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		AcceptMultipleExpeditionCsReq acceptMultipleExpeditionCsReq = AcceptMultipleExpeditionCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		List<ExpeditionInfo> accepted = player.ExpeditionManager.AcceptMultipleExpedition(acceptMultipleExpeditionCsReq.Expedition);
		await connection.SendPacket(new PacketAcceptMultipleExpeditionScRsp(player, accepted));
	}
}
