using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Scene;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Scene;

[Opcode(1431)]
public class HandlerGetUnlockTeleportCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GetUnlockTeleportCsReq req = GetUnlockTeleportCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketGetUnlockTeleportScRsp(req));
	}
}
