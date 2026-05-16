using System.Threading.Tasks;
using March7thHoney.GameServer.Game.GridFight;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.GridFight;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.GridFight;

[Opcode(8643)]
public class HandlerGridFightRecycleRoleCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GridFightRecycleRoleCsReq req = GridFightRecycleRoleCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		uint refund = new GridFightService(player).RecycleRole(req.UniqueId);
		await connection.SendPacket(new PacketGridFightRecycleRoleScRsp());
		await connection.SendPacket(new PacketGridFightSyncUpdateResultScNotify(player, 5, (req.UniqueId, (int)refund)));
	}
}
