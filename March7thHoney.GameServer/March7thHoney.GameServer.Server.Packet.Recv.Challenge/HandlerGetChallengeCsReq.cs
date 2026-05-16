using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Challenge;

namespace March7thHoney.GameServer.Server.Packet.Recv.Challenge;

[Opcode(1791)]
public class HandlerGetChallengeCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketGetChallengeScRsp(connection.Player));
	}
}
