using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Challenge.Instances;
using March7thHoney.GameServer.Server.Packet.Send.Challenge;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Challenge;

[Opcode(1800)]
public class HandlerEnterChallengeNextPhaseCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		if (!(connection.Player.ChallengeManager?.ChallengeInstance is ChallengeBossInstance challengeBossInstance))
		{
			await connection.SendPacket(new PacketEnterChallengeNextPhaseScRsp(Retcode.RetChallengeNotDoing));
			return;
		}
		await challengeBossInstance.NextPhase();
		await connection.SendPacket(new PacketEnterChallengeNextPhaseScRsp(connection.Player));
	}
}
