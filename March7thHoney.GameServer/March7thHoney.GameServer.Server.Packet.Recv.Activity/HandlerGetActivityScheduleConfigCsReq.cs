using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Activity;

namespace March7thHoney.GameServer.Server.Packet.Recv.Activity;

[Opcode(2614)]
public class HandlerGetActivityScheduleConfigCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketGetActivityScheduleConfigScRsp(connection.Player));
	}
}
