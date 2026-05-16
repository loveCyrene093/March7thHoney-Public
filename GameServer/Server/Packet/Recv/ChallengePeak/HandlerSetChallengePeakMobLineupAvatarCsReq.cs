using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.ChallengePeak;

[Opcode(8931)]
public class HandlerSetChallengePeakMobLineupAvatarCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SetChallengePeakMobLineupAvatarCsReq setChallengePeakMobLineupAvatarCsReq = SetChallengePeakMobLineupAvatarCsReq.Parser.ParseFrom(data);
		await connection.Player.ChallengePeakManager.SetLineupAvatars((int)setChallengePeakMobLineupAvatarCsReq.PeakGroupId, setChallengePeakMobLineupAvatarCsReq.LineupList.ToList());
		await connection.SendPacket(8921);
	}
}
