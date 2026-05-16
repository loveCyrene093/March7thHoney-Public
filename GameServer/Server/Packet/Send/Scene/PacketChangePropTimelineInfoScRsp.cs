using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Scene;

public class PacketChangePropTimelineInfoScRsp : BasePacket
{
	public PacketChangePropTimelineInfoScRsp(uint entityId)
		: base(1426)
	{
		ChangePropTimelineInfoScRsp data = new ChangePropTimelineInfoScRsp
		{
			PropEntityId = entityId
		};
		SetData(data);
	}
}
