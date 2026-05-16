using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.TalkEvent;

public class PacketGetFirstTalkByPerformanceNpcScRsp : BasePacket
{
	public PacketGetFirstTalkByPerformanceNpcScRsp(GetFirstTalkByPerformanceNpcCsReq req)
		: base(2101)
	{
		GetFirstTalkByPerformanceNpcScRsp getFirstTalkByPerformanceNpcScRsp = new GetFirstTalkByPerformanceNpcScRsp();
		foreach (uint performanceId in req.PerformanceIdList)
		{
			getFirstTalkByPerformanceNpcScRsp.NpcMeetStatusList.Add(new NpcMeetByPerformanceStatus
			{
				PerformanceId = performanceId
			});
		}
		SetData(getFirstTalkByPerformanceNpcScRsp);
	}
}
