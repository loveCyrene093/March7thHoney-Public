using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.GridFight;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.GridFight;

[Opcode(8775)]
public class HandlerGridFightLockShopCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GridFightLockShopCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketHGOIBDBMDBG());
		await connection.SendPacket(new PacketGridFightSyncUpdateResultScNotify(connection.Player, 8));
	}
}
