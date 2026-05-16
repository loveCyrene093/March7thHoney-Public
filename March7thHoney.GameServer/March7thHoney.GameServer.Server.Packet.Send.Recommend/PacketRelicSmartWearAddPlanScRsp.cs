using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Recommend;

public class PacketRelicSmartWearAddPlanScRsp : BasePacket
{
	public PacketRelicSmartWearAddPlanScRsp(RelicSmartWearPlan addPlan)
		: base(8260)
	{
		RelicSmartWearAddPlanScRsp data = new RelicSmartWearAddPlanScRsp
		{
			RelicPlan = addPlan
		};
		SetData(data);
	}
}
