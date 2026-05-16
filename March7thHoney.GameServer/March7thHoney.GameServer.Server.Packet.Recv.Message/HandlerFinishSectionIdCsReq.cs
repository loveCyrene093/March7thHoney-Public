using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Message;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Message;

[Opcode(2709)]
public class HandlerFinishSectionIdCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		FinishSectionIdCsReq req = FinishSectionIdCsReq.Parser.ParseFrom(data);
		await connection.Player.MessageManager.FinishSection((int)req.SectionId);
		await connection.SendPacket(new PacketFinishSectionIdScRsp(req.SectionId));
	}
}
