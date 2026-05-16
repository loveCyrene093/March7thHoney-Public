using System.Threading.Tasks;
using March7thHoney.GameServer.Game.GridFight;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.GridFight;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.GridFight;

[Opcode(8708)]
public class HandlerGridFightBuyExpCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GridFightBuyExpCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		new GridFightService(player).BuyExp();
		await connection.SendPacket(new PacketDJCHCHCAJPB());
		await connection.SendPacket(new PacketGridFightSyncUpdateResultScNotify(player, 6));
	}
}
