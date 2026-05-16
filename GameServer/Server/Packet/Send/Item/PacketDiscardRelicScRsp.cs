using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Item;

public class PacketDiscardRelicScRsp : BasePacket
{
	public PacketDiscardRelicScRsp(bool success, bool isDiscard)
		: base(566)
	{
		DiscardRelicScRsp discardRelicScRsp = new DiscardRelicScRsp();
		if (success)
		{
			discardRelicScRsp.Discarded = isDiscard;
		}
		else
		{
			discardRelicScRsp.Retcode = 1u;
		}
		SetData(discardRelicScRsp);
	}
}
