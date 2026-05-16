using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Challenge;

namespace March7thHoney.GameServer.Server.Packet.Recv.Challenge;

[Opcode(1726)]
public class HandlerGetCurChallengeCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketGetCurChallengeScRsp(connection.Player));
		if (connection.Player.ChallengeManager.ChallengeInstance != null)
		{
			connection.Player.ChallengeManager.ChallengeInstance.OnUpdate();
		}
	}
}
