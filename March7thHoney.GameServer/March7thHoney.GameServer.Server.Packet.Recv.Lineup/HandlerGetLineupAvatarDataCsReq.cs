using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Lineup;

namespace March7thHoney.GameServer.Server.Packet.Recv.Lineup;

[Opcode(701)]
public class HandlerGetLineupAvatarDataCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketGetLineupAvatarDataScRsp(connection.Player));
	}
}
