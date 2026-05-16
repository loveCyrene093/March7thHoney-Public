using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.ContentPackage;
using March7thHoney.GameServer.Server.Packet.Send.Player;
using March7thHoney.Kcp;

namespace March7thHoney.GameServer.Server.Packet.Recv.Player;

[Opcode(91)]
public class HandlerPlayerLoginCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		connection.State = SessionStateEnum.ACTIVE;
		await connection.Player.OnLogin();
		await connection.SendPacket(new PacketPlayerLoginScRsp(connection));
		await connection.SendPacket(new PacketContentPackageSyncDataScNotify());
	}
}
