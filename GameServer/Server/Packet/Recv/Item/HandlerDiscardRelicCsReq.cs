using System.Threading.Tasks;
using March7thHoney.Enums.Item;
using March7thHoney.GameServer.Server.Packet.Send.Item;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Item;

[Opcode(549)]
public class HandlerDiscardRelicCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		DiscardRelicCsReq req = DiscardRelicCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketDiscardRelicScRsp(await connection.Player.InventoryManager.DiscardItems(req.RelicIds, req.Discarded, ItemMainTypeEnum.Relic), req.Discarded));
	}
}
