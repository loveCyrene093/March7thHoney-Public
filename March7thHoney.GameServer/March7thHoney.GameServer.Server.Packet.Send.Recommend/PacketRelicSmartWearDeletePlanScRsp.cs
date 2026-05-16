using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Recommend;

public class PacketRelicSmartWearDeletePlanScRsp : BasePacket
{
	public PacketRelicSmartWearDeletePlanScRsp(uint uniqueId)
		: base(8267)
	{
		RelicSmartWearDeletePlanScRsp data = new RelicSmartWearDeletePlanScRsp
		{
			UniqueId = uniqueId
		};
		SetData(data);
	}
}
