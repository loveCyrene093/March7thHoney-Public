using System.Threading.Tasks;

namespace March7thHoney.GameServer.Server.Packet.Recv.RndOption;

[Opcode(3491)]
public class HandlerGetRndOptionCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(3410);
	}
}
