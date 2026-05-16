using System.Threading.Tasks;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Avatar;

[Opcode(309)]
public class HandlerPromoteAvatarCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		PromoteAvatarCsReq promoteAvatarCsReq = PromoteAvatarCsReq.Parser.ParseFrom(data);
		await connection.Player.InventoryManager.PromoteAvatar((int)promoteAvatarCsReq.BaseAvatarId);
		await connection.SendPacket(398);
	}
}
