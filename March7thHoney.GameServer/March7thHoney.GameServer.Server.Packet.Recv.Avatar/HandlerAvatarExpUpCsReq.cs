using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Avatar;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Avatar;

[Opcode(394)]
public class HandlerAvatarExpUpCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		AvatarExpUpCsReq avatarExpUpCsReq = AvatarExpUpCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketAvatarExpUpScRsp(await connection.Player.InventoryManager.LevelUpAvatar((int)avatarExpUpCsReq.BaseAvatarId, avatarExpUpCsReq.ItemCost)));
	}
}
