using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Mission;

namespace March7thHoney.GameServer.Server.Packet.Recv.Mission;

[Opcode(1291)]
public class HandlerGetMissionDataCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketGetMissionDataScRsp(connection.Player));
	}
}
