using System.Threading.Tasks;
using March7thHoney.Database.Inventory;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Item;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Item;

[Opcode(600)]
public class HandlerComposeSelectedRelicCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		ComposeSelectedRelicCsReq req = ComposeSelectedRelicCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		if (player.InventoryManager.Data.RelicItems.Count >= 1500)
		{
			await connection.SendPacket(new PacketComposeSelectedRelicScRsp(req.ComposeId, Retcode.RetRelicExceedLimit));
			return;
		}
		ItemData itemData = await player.InventoryManager.ComposeRelic(req);
		if (itemData == null)
		{
			await connection.SendPacket(new PacketComposeSelectedRelicScRsp(req.ComposeId));
		}
		else
		{
			await connection.SendPacket(new PacketComposeSelectedRelicScRsp(req.ComposeId, itemData));
		}
	}
}
