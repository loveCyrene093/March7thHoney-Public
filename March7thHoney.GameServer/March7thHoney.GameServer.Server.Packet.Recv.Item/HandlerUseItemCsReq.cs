using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.Database.Inventory;
using March7thHoney.GameServer.Server.Packet.Send.Item;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Item;

[Opcode(509)]
public class HandlerUseItemCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		UseItemCsReq req = UseItemCsReq.Parser.ParseFrom(data);
		(Retcode, List<ItemData>) tuple = await connection.Player.InventoryManager.UseItem((int)req.UseItemId, (int)req.UseItemCount, (int)req.BaseAvatarId);
		await connection.SendPacket(new PacketUseItemScRsp(tuple.Item1, req.UseItemId, req.UseItemCount, tuple.Item2));
	}
}
