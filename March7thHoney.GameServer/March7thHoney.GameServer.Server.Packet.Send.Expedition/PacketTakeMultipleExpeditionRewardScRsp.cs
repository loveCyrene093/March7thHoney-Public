using System.Collections.Generic;
using System.Linq;
using March7thHoney.Database.Inventory;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Expedition;

public class PacketTakeMultipleExpeditionRewardScRsp : BasePacket
{
	public PacketTakeMultipleExpeditionRewardScRsp(PlayerInstance player, Retcode retcode, List<ItemData>? rewards = null)
		: base(2531)
	{
		TakeMultipleExpeditionRewardScRsp takeMultipleExpeditionRewardScRsp = new TakeMultipleExpeditionRewardScRsp
		{
			KAMBBFDEBAM = player.ExpeditionManager.GetRefreshTime(),
			Retcode = (uint)retcode
		};
		if (rewards != null && rewards.Count > 0)
		{
			ItemList item = new ItemList
			{
				ItemList_ = { rewards.Select((ItemData x) => x.ToProto()) }
			};
			takeMultipleExpeditionRewardScRsp.HALFGLGLDLO.Add(item);
		}
		takeMultipleExpeditionRewardScRsp.ANMHKDANNDL.Add(from x in player.ExpeditionManager.GetActiveExpeditionInfo()
			select x.Id);
		SetData(takeMultipleExpeditionRewardScRsp);
	}
}
