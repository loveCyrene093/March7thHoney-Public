using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Player;

namespace March7thHoney.GameServer.Server.Packet.Recv.Player;

[Opcode(66)]
public class HandlerQueryProductInfoCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketQueryProductInfoScRsp());
	}
}
