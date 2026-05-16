using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.TalkEvent;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.TalkEvent;

[Opcode(2139)]
public class HandlerGetFirstTalkByPerformanceNpcCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GetFirstTalkByPerformanceNpcCsReq req = GetFirstTalkByPerformanceNpcCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketGetFirstTalkByPerformanceNpcScRsp(req));
	}
}
