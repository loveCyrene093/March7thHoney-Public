using System.Threading.Tasks;

namespace March7thHoney.GameServer.Server.Packet.Recv.DiceCombat;

[Opcode(9261)]
public class HandlerDiceCombatMainPageRollDiceCsReq : Handler
{
	public override Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		return Task.CompletedTask;
	}
}
