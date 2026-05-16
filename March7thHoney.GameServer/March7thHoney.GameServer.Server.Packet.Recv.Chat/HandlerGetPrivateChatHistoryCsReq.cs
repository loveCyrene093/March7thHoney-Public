using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Chat;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Chat;

[Opcode(3914)]
public class HandlerGetPrivateChatHistoryCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GetPrivateChatHistoryCsReq getPrivateChatHistoryCsReq = GetPrivateChatHistoryCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketGetPrivateChatHistoryScRsp(getPrivateChatHistoryCsReq.ContactSide, getPrivateChatHistoryCsReq.TargetSide, connection.Player));
	}
}
