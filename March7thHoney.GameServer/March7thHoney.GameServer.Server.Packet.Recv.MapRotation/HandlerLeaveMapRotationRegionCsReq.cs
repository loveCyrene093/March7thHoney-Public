using System.Threading.Tasks;

namespace March7thHoney.GameServer.Server.Packet.Recv.MapRotation;

[Opcode(6863)]
public class HandlerLeaveMapRotationRegionCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(6826);
	}
}
