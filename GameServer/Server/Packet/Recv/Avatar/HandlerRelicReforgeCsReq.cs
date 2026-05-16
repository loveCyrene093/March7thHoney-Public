using System.Threading.Tasks;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Avatar;

[Opcode(506)]
public class HandlerRelicReforgeCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		RelicReforgeCsReq relicReforgeCsReq = RelicReforgeCsReq.Parser.ParseFrom(data);
		await connection.Player.AvatarManager.ReforgeRelic((int)relicReforgeCsReq.RelicUniqueId);
		await connection.SendPacket(588);
	}
}
