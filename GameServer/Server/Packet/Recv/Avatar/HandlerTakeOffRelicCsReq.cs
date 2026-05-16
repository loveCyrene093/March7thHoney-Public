using System.Threading.Tasks;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Avatar;

[Opcode(332)]
public class HandlerTakeOffRelicCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		TakeOffRelicCsReq req = TakeOffRelicCsReq.Parser.ParseFrom(data);
		foreach (uint relicType in req.RelicTypeList)
		{
			await connection.Player.InventoryManager.UnequipRelic((int)req.AvatarId, (int)relicType);
		}
		await connection.SendPacket(333);
	}
}
