using System.Threading.Tasks;
using March7thHoney.Database.Inventory;
using March7thHoney.GameServer.Game.Inventory;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.DiceCombat;

namespace March7thHoney.GameServer.Server.Packet.Recv.DiceCombat;

[Opcode(9267)]
public class HandlerGetDiceCombatSystemDataCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		PlayerInstance player = connection.Player;
		InventoryManager inventoryManager = player.InventoryManager;
		if (inventoryManager.Data.MaterialItems.Find((ItemData x) => x.ItemId == 150093) == null)
		{
			await inventoryManager.AddItem(150093, 1);
		}
		await connection.SendPacket(new PacketGetDiceCombatSystemDataScRsp(player));
	}
}
