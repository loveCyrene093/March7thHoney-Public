using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Raid;

namespace March7thHoney.GameServer.Server.Packet.Recv.Raid;

[Opcode(2202)]
public class HandlerGetRaidInfoCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketGetRaidInfoScRsp(connection.Player));
	}
}
