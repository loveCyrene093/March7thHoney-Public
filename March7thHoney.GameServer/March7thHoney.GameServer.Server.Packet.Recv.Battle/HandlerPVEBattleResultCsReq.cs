using System.Threading.Tasks;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Battle;

[Opcode(191)]
public class HandlerPVEBattleResultCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		PVEBattleResultCsReq req = PVEBattleResultCsReq.Parser.ParseFrom(data);
		await connection.Player.BattleManager.EndBattle(req);
	}
}
