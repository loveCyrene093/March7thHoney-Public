using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.StoryLine;

public class PacketChangeStoryLineFinishScNotify : BasePacket
{
	public PacketChangeStoryLineFinishScNotify(int curId, ChangeStoryLineAction reason)
		: base(6218)
	{
		ChangeStoryLineFinishScNotify data = new ChangeStoryLineFinishScNotify
		{
			Action = reason,
			CurStoryLineId = (uint)curId
		};
		SetData(data);
	}
}
