using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Message;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Message;

[Opcode(2714)]
public class HandlerFinishItemIdCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		FinishItemIdCsReq req = FinishItemIdCsReq.Parser.ParseFrom(data);
		await connection.Player.MessageManager.FinishMessageItem((int)req.ItemId);
		await connection.SendPacket(new PacketFinishItemIdScRsp(req.ItemId));
	}
}
