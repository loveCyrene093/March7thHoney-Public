using System.Threading.Tasks;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Avatar;

[Opcode(358)]
public class HandlerDressAvatarSkinCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		DressAvatarSkinCsReq dressAvatarSkinCsReq = DressAvatarSkinCsReq.Parser.ParseFrom(data);
		await connection.Player.ChangeAvatarSkin((int)dressAvatarSkinCsReq.AvatarId, (int)dressAvatarSkinCsReq.SkinId);
		await connection.SendPacket(344);
	}
}
