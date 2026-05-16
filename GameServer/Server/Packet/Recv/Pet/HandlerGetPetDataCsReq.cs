using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Pet;

namespace March7thHoney.GameServer.Server.Packet.Recv.Pet;

[Opcode(7601)]
public class HandlerGetPetDataCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		PlayerInstance player = connection.Player;
		await connection.SendPacket(new PacketGetPetDataScRsp(player));
	}
}
