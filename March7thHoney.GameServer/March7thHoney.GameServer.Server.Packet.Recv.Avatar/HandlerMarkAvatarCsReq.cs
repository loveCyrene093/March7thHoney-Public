using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Avatar;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Avatar;

[Opcode(357)]
public class HandlerMarkAvatarCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		MarkAvatarCsReq markAvatarCsReq = MarkAvatarCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketMarkAvatarScRsp(await connection.Player.MarkAvatar((int)markAvatarCsReq.AvatarId, markAvatarCsReq.IsMarked)));
	}
}
