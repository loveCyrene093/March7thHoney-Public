using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Inventory;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Player;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Player;

[Opcode(100)]
public class HandlerGetLevelRewardCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GetLevelRewardCsReq req = GetLevelRewardCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		if (player.Data.TakenLevelReward.Contains((int)req.Level))
		{
			await connection.SendPacket(new PacketGetLevelRewardScRsp(Retcode.RetLevelRewardHasTaken));
			return;
		}
		if (player.Data.Level < req.Level)
		{
			await connection.SendPacket(new PacketGetLevelRewardScRsp(Retcode.RetLevelRewardLevelError));
			return;
		}
		if (!GameData.PlayerLevelConfigData.TryGetValue((int)req.Level, out PlayerLevelConfigExcel value))
		{
			await connection.SendPacket(new PacketGetLevelRewardScRsp(Retcode.RetLevelRewardLevelError));
			return;
		}
		player.Data.TakenLevelReward.Add((int)req.Level);
		List<ItemData> reward = await player.InventoryManager.HandleReward(value.LevelRewardID);
		await connection.SendPacket(new PacketGetLevelRewardScRsp(req.Level, reward));
	}
}
