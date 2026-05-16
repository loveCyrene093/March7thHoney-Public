using System.Threading.Tasks;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Lineup;

[Opcode(744)]
public class HandlerReplaceLineupCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		ReplaceLineupCsReq req = ReplaceLineupCsReq.Parser.ParseFrom(data);
		await connection.Player.LineupManager.ReplaceLineup(req);
		await connection.SendPacket(800);
	}
}
