using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Shop;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Shop;

[Opcode(1594)]
public class HandlerBuyGoodsCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		PlayerInstance? player = connection.Player;
		BuyGoodsCsReq req = BuyGoodsCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketBuyGoodsScRsp(req, await player.ShopService.BuyItem((int)req.ShopId, (int)req.GoodsId, (int)req.GoodsNum)));
	}
}
