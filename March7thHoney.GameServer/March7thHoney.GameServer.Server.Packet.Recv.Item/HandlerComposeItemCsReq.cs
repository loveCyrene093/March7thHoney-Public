using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Database.Inventory;
using March7thHoney.GameServer.Server.Packet.Send.Item;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Item;

[Opcode(574)]
public class HandlerComposeItemCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		ComposeItemCsReq req = ComposeItemCsReq.Parser.ParseFrom(data);
		List<ItemCost> costData = new List<ItemCost>();
		if (req.ComposeItemList != null)
		{
			costData = req.ComposeItemList.ItemList.ToList();
		}
		ItemData itemData = await connection.Player.InventoryManager.ComposeItem((int)req.ComposeId, (int)req.Count, costData);
		if (itemData == null)
		{
			await connection.SendPacket(new PacketComposeItemScRsp());
		}
		else
		{
			await connection.SendPacket(new PacketComposeItemScRsp(req.ComposeId, req.Count, itemData));
		}
	}
}
