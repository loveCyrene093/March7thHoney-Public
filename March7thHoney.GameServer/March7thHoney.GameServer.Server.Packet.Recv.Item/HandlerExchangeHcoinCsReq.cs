using System.Threading.Tasks;
using March7thHoney.Database.Inventory;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Item;
using March7thHoney.GameServer.Server.Packet.Send.PlayerSync;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Item;

[Opcode(558)]
public class HandlerExchangeHcoinCsReq : Handler
{
	private const int SourceItemId = 3;

	private const int TargetItemId = 1;

	private const int ExchangeRate = 1;

	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		ExchangeHcoinCsReq req = ExchangeHcoinCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		if (player?.InventoryManager == null)
		{
			return;
		}
		if (req.Num == 0)
		{
			await connection.SendPacket(new PacketExchangeHcoinScRsp(0u, Retcode.RetHcoinExchangeTooMuch));
			return;
		}
		ItemData item = player.InventoryManager.GetItem(3);
		if (item == null || item.Count < req.Num)
		{
			await connection.SendPacket(new PacketExchangeHcoinScRsp(req.Num, Retcode.RetItemNotEnough));
			return;
		}
		await player.InventoryManager.RemoveItem(3, (int)req.Num, 0, sync: false);
		await player.InventoryManager.AddItem(1, (int)req.Num, notify: false, 1, 1, 0, sync: false);
		await player.SendPacket(new PacketPlayerSyncScNotify(player.ToProto()));
		await connection.SendPacket(new PacketExchangeHcoinScRsp(req.Num));
	}
}
