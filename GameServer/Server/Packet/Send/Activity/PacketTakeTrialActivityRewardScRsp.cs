using System.Collections.Generic;
using System.Linq;
using March7thHoney.Database.Inventory;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Activity;

public class PacketTakeTrialActivityRewardScRsp : BasePacket
{
	public PacketTakeTrialActivityRewardScRsp(uint stageId, List<ItemData> rewards)
		: base(2612)
	{
		TakeTrialActivityRewardScRsp takeTrialActivityRewardScRsp = new TakeTrialActivityRewardScRsp
		{
			StageId = stageId,
			Reward = new ItemList()
		};
		takeTrialActivityRewardScRsp.Reward.ItemList_.Add(rewards.Select((ItemData x) => x.ToProto()).ToArray());
		SetData(takeTrialActivityRewardScRsp);
	}
}
