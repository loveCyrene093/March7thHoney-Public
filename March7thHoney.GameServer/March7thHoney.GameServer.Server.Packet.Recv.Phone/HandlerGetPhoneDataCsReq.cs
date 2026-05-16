using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Phone;

namespace March7thHoney.GameServer.Server.Packet.Recv.Phone;

[Opcode(5191)]
public class HandlerGetPhoneDataCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketGetPhoneDataScRsp(connection.Player));
	}
}
