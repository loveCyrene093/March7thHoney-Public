using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.TalkEvent;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.TalkEvent;

[Opcode(2174)]
public class HandlerFinishFirstTalkByPerformanceNpcCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		FinishFirstTalkByPerformanceNpcCsReq finishFirstTalkByPerformanceNpcCsReq = FinishFirstTalkByPerformanceNpcCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketFinishFirstTalkByPerformanceNpcScRsp(finishFirstTalkByPerformanceNpcCsReq.PerformanceId));
	}
}
