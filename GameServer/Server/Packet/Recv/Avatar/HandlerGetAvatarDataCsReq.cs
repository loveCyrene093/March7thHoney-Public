using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Avatar;

namespace March7thHoney.GameServer.Server.Packet.Recv.Avatar;

[Opcode(391)]
public class HandlerGetAvatarDataCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketGetAvatarDataScRsp(connection.Player));
	}
}
