using System.Threading.Tasks;
using March7thHoney.GameServer.Game.GridFight;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.GridFight;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.GridFight;

[Opcode(8660)]
public class HandlerGridFightRefreshShopCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GridFightRefreshShopCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		new GridFightService(player).RefreshShop();
		BasePacket basePacket = new BasePacket(8658);
		basePacket.SetData(new CMJCEEDCIAN());
		await connection.SendPacket(basePacket);
		await connection.SendPacket(new PacketGridFightSyncUpdateResultScNotify(player, 4));
	}
}
