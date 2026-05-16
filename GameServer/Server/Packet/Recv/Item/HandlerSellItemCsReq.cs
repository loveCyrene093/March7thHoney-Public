using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Item;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Item;

[Opcode(533)]
public class HandlerSellItemCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SellItemCsReq sellItemCsReq = SellItemCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketSellItemScRsp(await connection.Player.InventoryManager.SellItem(sellItemCsReq.CostData, sellItemCsReq.ToMaterial)));
	}
}
