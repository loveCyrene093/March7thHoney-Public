using System.Threading.Tasks;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Scene;

[Opcode(1457)]
public class HandlerEnterSectionCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		EnterSectionCsReq enterSectionCsReq = EnterSectionCsReq.Parser.ParseFrom(data);
		connection.Player.EnterSection((int)enterSectionCsReq.SectionId);
		await connection.SendPacket(1421);
	}
}
