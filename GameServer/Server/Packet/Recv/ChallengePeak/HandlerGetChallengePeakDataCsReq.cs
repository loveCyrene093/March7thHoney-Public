using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.ChallengePeak;

namespace March7thHoney.GameServer.Server.Packet.Recv.ChallengePeak;

[Opcode(8913)]
public class HandlerGetChallengePeakDataCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketGetChallengePeakDataScRsp(connection.Player));
	}
}
