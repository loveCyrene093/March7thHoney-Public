using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.ChallengePeak;

[Opcode(8930)]
public class HandlerStartChallengePeakCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		StartChallengePeakCsReq startChallengePeakCsReq = StartChallengePeakCsReq.Parser.ParseFrom(data);
		await connection.Player.ChallengePeakManager.StartChallenge((int)startChallengePeakCsReq.PeakId, startChallengePeakCsReq.BossBuffId, startChallengePeakCsReq.PeakAvatarIdList.Select((uint x) => (int)x).ToList());
	}
}
