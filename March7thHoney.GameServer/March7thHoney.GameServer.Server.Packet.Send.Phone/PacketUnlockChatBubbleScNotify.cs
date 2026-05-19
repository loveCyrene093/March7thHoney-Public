using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Phone;

public class PacketUnlockChatBubbleScNotify : BasePacket
{
	public PacketUnlockChatBubbleScNotify(int bubbleId)
		: base(5114)
	{
		SetData(new UnlockChatBubbleScNotify
		{
			BubbleId = (uint)bubbleId
		});
	}
}
