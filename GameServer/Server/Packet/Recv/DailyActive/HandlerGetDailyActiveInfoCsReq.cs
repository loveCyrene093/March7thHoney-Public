using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.DailyActive;

namespace March7thHoney.GameServer.Server.Packet.Recv.DailyActive;

[Opcode(3394)]
public class HandlerGetDailyActiveInfoCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketGetDailyActiveInfoScRsp());
	}
}
