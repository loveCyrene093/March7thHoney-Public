using System.Threading.Tasks;

namespace March7thHoney.GameServer.Server.Packet.Recv.TreasureDungeon;

[Opcode(4439)]
public class HandlerGetTreasureDungeonActivityDataCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(4401);
	}
}
