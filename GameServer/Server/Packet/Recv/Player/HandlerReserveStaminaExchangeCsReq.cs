using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Player;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Player;

[Opcode(13)]
public class HandlerReserveStaminaExchangeCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		ReserveStaminaExchangeCsReq reserveStaminaExchangeCsReq = ReserveStaminaExchangeCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		if (player != null)
		{
			uint amount = reserveStaminaExchangeCsReq.Num;
			if (amount == 0 || player.Data.StaminaReserve < (double)amount)
			{
				await connection.SendPacket(new PacketReserveStaminaExchangeScRsp(0u));
				return;
			}
			player.Data.StaminaReserve -= amount;
			player.Data.Stamina += (int)amount;
			await connection.SendPacket(new PacketStaminaInfoScNotify(player));
			await connection.SendPacket(new PacketReserveStaminaExchangeScRsp(amount));
		}
	}
}
