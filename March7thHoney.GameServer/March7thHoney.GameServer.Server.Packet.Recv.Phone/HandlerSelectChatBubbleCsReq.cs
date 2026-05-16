using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Phone;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Phone;

[Opcode(5194)]
public class HandlerSelectChatBubbleCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SelectChatBubbleCsReq selectChatBubbleCsReq = SelectChatBubbleCsReq.Parser.ParseFrom(data);
		connection.Player.Data.ChatBubble = (int)selectChatBubbleCsReq.BubbleId;
		await connection.SendPacket(new PacketSelectChatBubbleScRsp(selectChatBubbleCsReq.BubbleId));
	}
}
