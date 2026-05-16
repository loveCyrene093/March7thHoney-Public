using System.Threading.Tasks;

namespace March7thHoney.GameServer.Server.Packet.Recv.Battle;

[Opcode(194)]
public class HandlerQuitBattleCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		connection.Player.BattleInstance = null;
		await connection.SendPacket(195);
	}
}
