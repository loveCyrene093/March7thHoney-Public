using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.Database.Inventory;
using March7thHoney.GameServer.Server.Packet.Send.DailyActive;
using March7thHoney.GameServer.Server.Packet.Send.Mission;
using March7thHoney.GameServer.Server.Packet.Send.Player;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Server.Packet.Recv.Player;

[Opcode(41)]
public class HandlerPlayerLoginFinishCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(62);
		if (ConfigManager.Config.ServerOption.EnableMonthCard && connection.Player?.InventoryManager != null)
		{
			await connection.Player.InventoryManager.AddItem(1, 90, notify: false);
			await connection.SendPacket(new PacketMonthCardRewardNotify(new List<ItemData>(1)
			{
				new ItemData
				{
					ItemId = 1,
					Count = 90
				}
			}));
		}
		await connection.SendPacket(new PacketFinishedMissionScNotify(connection.Player?.MissionManager?.GetAllFinishedMissionIds() ?? new List<int>()));
		await connection.SendPacket(new PacketDailyActiveInfoNotify());
	}
}
