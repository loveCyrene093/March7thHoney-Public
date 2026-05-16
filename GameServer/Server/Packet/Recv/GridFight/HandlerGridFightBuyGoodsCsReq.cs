using System.Threading.Tasks;
using March7thHoney.GameServer.Game.GridFight;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.GridFight;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.GridFight;

[Opcode(8582)]
public class HandlerGridFightBuyGoodsCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GridFightBuyGoodsCsReq gridFightBuyGoodsCsReq = GridFightBuyGoodsCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		(uint, uint, uint, int) tuple = new GridFightService(player).BuyGoods(gridFightBuyGoodsCsReq.BuyGoodsIndexList);
		uint roleId = tuple.Item1;
		uint roleUniqueId = tuple.Item2;
		uint pos = tuple.Item3;
		int goldDelta = tuple.Item4;
		BasePacket basePacket = new BasePacket(8556);
		basePacket.SetData(new CEFIMADBIBH());
		await connection.SendPacket(basePacket);
		await connection.SendPacket(new PacketGridFightSyncUpdateResultScNotify(player, 3, (roleId, roleUniqueId, pos, goldDelta)));
	}
}
