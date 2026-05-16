using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Scene;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Scene;

[Opcode(1460)]
public class HandlerGetSceneMapInfoCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GetSceneMapInfoCsReq req = GetSceneMapInfoCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketGetSceneMapInfoScRsp(req, connection.Player));
	}
}
