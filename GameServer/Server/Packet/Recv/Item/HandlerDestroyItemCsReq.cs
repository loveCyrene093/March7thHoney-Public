using System.Threading.Tasks;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Item;

[Opcode(573)]
public class HandlerDestroyItemCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		DestroyItemCsReq destroyItemCsReq = DestroyItemCsReq.Parser.ParseFrom(data);
		await connection.Player.InventoryManager.RemoveItem((int)destroyItemCsReq.ItemId, (int)destroyItemCsReq.ItemCount);
		await connection.SendPacket(553);
	}
}
