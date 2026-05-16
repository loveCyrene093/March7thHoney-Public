using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.HeartDial;

namespace March7thHoney.GameServer.Server.Packet.Recv.HeartDial;

[Opcode(6391)]
public class HandlerGetHeartDialInfoCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketGetHeartDialInfoScRsp(connection.Player));
	}
}
