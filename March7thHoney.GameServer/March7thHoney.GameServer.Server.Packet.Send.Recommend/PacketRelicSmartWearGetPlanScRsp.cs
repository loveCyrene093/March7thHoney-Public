using System.Collections.Generic;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Recommend;

public class PacketRelicSmartWearGetPlanScRsp : BasePacket
{
	public PacketRelicSmartWearGetPlanScRsp(uint avatarId, List<RelicSmartWearPlan> relicPlan)
		: base(8270)
	{
		RelicSmartWearGetPlanScRsp data = new RelicSmartWearGetPlanScRsp
		{
			AvatarId = avatarId,
			RelicPlanList = { (IEnumerable<RelicSmartWearPlan>)relicPlan }
		};
		SetData(data);
	}
}
