using System.Threading.Tasks;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Avatar;

[Opcode(337)]
public class HandlerRankUpAvatarCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		RankUpAvatarCsReq rankUpAvatarCsReq = RankUpAvatarCsReq.Parser.ParseFrom(data);
		await connection.Player.InventoryManager.RankUpAvatar((int)rankUpAvatarCsReq.AvatarId, rankUpAvatarCsReq.CostData);
		await connection.SendPacket(304);
	}
}
