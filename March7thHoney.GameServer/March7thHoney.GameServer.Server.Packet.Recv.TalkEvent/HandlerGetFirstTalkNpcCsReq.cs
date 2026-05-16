using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.TalkEvent;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.TalkEvent;

[Opcode(2114)]
public class HandlerGetFirstTalkNpcCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GetFirstTalkNpcCsReq req = GetFirstTalkNpcCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketGetFirstTalkNpcScRsp(req));
	}
}
