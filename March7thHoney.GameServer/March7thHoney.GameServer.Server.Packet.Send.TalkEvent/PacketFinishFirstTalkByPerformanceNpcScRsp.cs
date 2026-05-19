using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.TalkEvent;

public class PacketFinishFirstTalkByPerformanceNpcScRsp : BasePacket
{
	public PacketFinishFirstTalkByPerformanceNpcScRsp(uint performanceId)
		: base(2137)
	{
		SetData(new FinishFirstTalkByPerformanceNpcScRsp
		{
			PerformanceId = performanceId,
			Reward = new ItemList()
		});
	}
}
