using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.TalkEvent;

public class PacketGetFirstTalkNpcScRsp : BasePacket
{
	public PacketGetFirstTalkNpcScRsp(GetFirstTalkNpcCsReq req)
		: base(2118)
	{
		GetFirstTalkNpcScRsp getFirstTalkNpcScRsp = new GetFirstTalkNpcScRsp();
		foreach (uint npcId in req.NpcIdList)
		{
			getFirstTalkNpcScRsp.NpcMeetStatusList.Add(new FirstNpcTalkInfo
			{
				NpcId = npcId,
				IsMeet = true
			});
		}
		SetData(getFirstTalkNpcScRsp);
	}
}
