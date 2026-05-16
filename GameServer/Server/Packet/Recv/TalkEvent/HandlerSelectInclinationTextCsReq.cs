using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.TalkEvent;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.TalkEvent;

[Opcode(2163)]
public class HandlerSelectInclinationTextCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SelectInclinationTextCsReq selectInclinationTextCsReq = SelectInclinationTextCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketSelectInclinationTextScRsp(selectInclinationTextCsReq.TalkSentenceId));
	}
}
