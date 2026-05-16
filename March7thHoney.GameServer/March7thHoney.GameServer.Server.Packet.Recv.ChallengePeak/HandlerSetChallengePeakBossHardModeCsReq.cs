using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.ChallengePeak;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.ChallengePeak;

[Opcode(8918)]
public class HandlerSetChallengePeakBossHardModeCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SetChallengePeakBossHardModeCsReq setChallengePeakBossHardModeCsReq = SetChallengePeakBossHardModeCsReq.Parser.ParseFrom(data);
		connection.Player.ChallengePeakManager.BossIsHard = setChallengePeakBossHardModeCsReq.IsHardMode;
		await connection.SendPacket(new PacketSetChallengePeakBossHardModeScRsp(setChallengePeakBossHardModeCsReq.PeakGroupId, setChallengePeakBossHardModeCsReq.IsHardMode));
	}
}
