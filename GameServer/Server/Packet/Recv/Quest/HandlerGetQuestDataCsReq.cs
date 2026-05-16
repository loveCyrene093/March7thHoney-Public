using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Quest;

namespace March7thHoney.GameServer.Server.Packet.Recv.Quest;

[Opcode(991)]
public class HandlerGetQuestDataCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketGetQuestDataScRsp(connection.Player));
	}
}
