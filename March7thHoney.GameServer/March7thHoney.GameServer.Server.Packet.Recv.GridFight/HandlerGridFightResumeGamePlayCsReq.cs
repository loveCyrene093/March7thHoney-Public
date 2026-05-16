using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.GridFight;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.GridFight;

[Opcode(8752)]
public class HandlerGridFightResumeGamePlayCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GridFightResumeGamePlayCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		if (player.GridFightManager.GridFightInstance == null)
		{
			player.GridFightManager.StartGamePlay(0u, 0u, isOverLock: false);
		}
		await connection.SendPacket(new PacketKMDHLENLIMF());
		await connection.SendPacket(new PacketINHDFEIOBNK(player));
		await connection.SendPacket(new PacketGridFightSyncUpdateResultScNotify(player, 0));
	}
}
