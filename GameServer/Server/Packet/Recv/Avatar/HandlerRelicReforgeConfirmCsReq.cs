using System.Threading.Tasks;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Avatar;

[Opcode(552)]
public class HandlerRelicReforgeConfirmCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		RelicReforgeConfirmCsReq relicReforgeConfirmCsReq = RelicReforgeConfirmCsReq.Parser.ParseFrom(data);
		await connection.Player.AvatarManager.ConfirmReforgeRelic((int)relicReforgeConfirmCsReq.RelicUniqueId, relicReforgeConfirmCsReq.IsCancel);
		await connection.SendPacket(590);
	}
}
