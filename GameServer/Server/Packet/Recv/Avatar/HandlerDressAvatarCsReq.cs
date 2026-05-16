using System.Threading.Tasks;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Avatar;

[Opcode(363)]
public class HandlerDressAvatarCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		DressAvatarCsReq dressAvatarCsReq = DressAvatarCsReq.Parser.ParseFrom(data);
		await connection.Player.InventoryManager.EquipAvatar((int)dressAvatarCsReq.AvatarId, (int)dressAvatarCsReq.EquipmentUniqueId);
		await connection.SendPacket(326);
	}
}
