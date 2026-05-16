using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.StoryLine;

namespace March7thHoney.GameServer.Server.Packet.Recv.StoryLine;

[Opcode(6291)]
public class HandlerGetStoryLineInfoCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketGetStoryLineInfoScRsp(connection.Player));
	}
}
