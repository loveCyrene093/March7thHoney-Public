using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.Database.Inventory;
using March7thHoney.GameServer.Game.Expedition;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Expedition;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Expedition;

[Opcode(2516)]
public class HandlerTakeMultipleExpeditionRewardCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		PlayerInstance player = connection.Player;
		ExpeditionManager manager = player.ExpeditionManager;
		if (!manager.CanTakeRewardNow())
		{
			await connection.SendPacket(new PacketTakeMultipleExpeditionRewardScRsp(player, Retcode.RetExpeditionNotFinish));
			return;
		}
		List<ItemData> rewards = manager.BuildTakeRewardItems();
		if (rewards.Count > 0)
		{
			await player.InventoryManager.AddItems(rewards);
		}
		manager.MarkRewardTaken();
		await connection.SendPacket(new PacketTakeMultipleExpeditionRewardScRsp(player, Retcode.RetSucc, rewards));
	}
}
