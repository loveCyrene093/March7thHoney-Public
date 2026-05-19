using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.GameServer.Game.GridFight;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.GridFight;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.GridFight;

[Opcode(8654)]
public class HandlerGridFightUseOrbCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GJMIIBDEAAJ req = GJMIIBDEAAJ.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		GridFightInstance inst = player.GridFightManager?.GridFightInstance;
		await connection.SendPacket(new PacketCEFIMADBIBH());
		if (inst == null)
		{
			return;
		}
		(List<uint> removedOrbUniqueIds, bool levelChanged, bool goldChanged) tuple = inst.TryUseOrbs(req.HDFJAINBKJG, req.IsGetAll);
		List<uint> item = tuple.removedOrbUniqueIds;
		bool item2 = tuple.levelChanged;
		bool item3 = tuple.goldChanged;
		GridFightSyncUpdateResultScNotify gridFightSyncUpdateResultScNotify = new GridFightSyncUpdateResultScNotify();
		GridFightSyncResultData gridFightSyncResultData = new GridFightSyncResultData();
		foreach (uint item4 in item)
		{
			gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
			{
				RemoveOrbUniqueId = item4
			});
		}
		if (item3)
		{
			gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
			{
				ItemValue = inst.Gold
			});
		}
		if (item2)
		{
			gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
			{
				PlayerLevel = new GridFightPlayerLevelSyncInfo
				{
					Level = inst.PlayerLevel,
					Exp = inst.PlayerExp,
					MaxLevel = inst.PlayerMaxLevel
				}
			});
			gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
			{
				GridFightBuyExpCost = inst.GetBuyExpCost()
			});
			gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
			{
				MaxBattleRoleNum = inst.GetCurrentMaxBattleRoleNum()
			});
		}
		if (gridFightSyncResultData.UpdateDynamicList.Count == 0)
		{
			gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
			{
				ItemValue = inst.Gold
			});
		}
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData);
		await connection.SendPacket(new PacketGridFightSyncUpdateResultScNotify(gridFightSyncUpdateResultScNotify));
	}
}
