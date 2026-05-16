using System.Collections.Generic;
using March7thHoney.Database.Inventory;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Mission;

public class PacketSubMissionRewardScNotify : BasePacket
{
	public PacketSubMissionRewardScNotify(int subMissionId, List<ItemData> item)
		: base(1296)
	{
		SubMissionRewardScNotify subMissionRewardScNotify = new SubMissionRewardScNotify
		{
			SubMissionId = (uint)subMissionId,
			Reward = new ItemList()
		};
		foreach (ItemData item2 in item)
		{
			subMissionRewardScNotify.Reward.ItemList_.Add(item2.ToProto());
		}
		SetData(subMissionRewardScNotify);
	}
}
