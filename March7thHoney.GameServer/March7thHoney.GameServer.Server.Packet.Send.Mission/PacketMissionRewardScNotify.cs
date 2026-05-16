using System.Collections.Generic;
using March7thHoney.Database.Inventory;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Mission;

public class PacketMissionRewardScNotify : BasePacket
{
	public PacketMissionRewardScNotify(int mainMissionId, int subMissionId, List<ItemData> item)
		: base(1214)
	{
		MissionRewardScNotify missionRewardScNotify = new MissionRewardScNotify
		{
			MainMissionId = (uint)mainMissionId,
			SubMissionId = (uint)subMissionId,
			Reward = new ItemList()
		};
		foreach (ItemData item2 in item)
		{
			missionRewardScNotify.Reward.ItemList_.Add(item2.ToProto());
		}
		SetData(missionRewardScNotify);
	}
}
