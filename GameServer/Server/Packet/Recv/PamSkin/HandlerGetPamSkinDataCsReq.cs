using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.PamSkin;

namespace March7thHoney.GameServer.Server.Packet.Recv.PamSkin;

[Opcode(8121)]
public class HandlerGetPamSkinDataCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketGetPamSkinDataScRsp(connection.Player));
	}
}
