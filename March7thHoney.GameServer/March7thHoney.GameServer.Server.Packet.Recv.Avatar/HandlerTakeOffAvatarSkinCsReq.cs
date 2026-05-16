using System.Threading.Tasks;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Avatar;

[Opcode(400)]
public class HandlerTakeOffAvatarSkinCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		TakeOffAvatarSkinCsReq takeOffAvatarSkinCsReq = TakeOffAvatarSkinCsReq.Parser.ParseFrom(data);
		await connection.Player.ChangeAvatarSkin((int)takeOffAvatarSkinCsReq.AvatarId, 0);
		await connection.SendPacket(389);
	}
}
