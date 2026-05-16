using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.JukeBox;

namespace March7thHoney.GameServer.Server.Packet.Recv.JukeBox;

[Opcode(3191)]
public class HandlerGetJukeboxDataCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketGetJukeboxDataScRsp(connection.Player));
	}
}
