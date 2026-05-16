using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Recommend;

public class PacketRelicSmartWearGetPinRelicScRsp : BasePacket
{
	public PacketRelicSmartWearGetPinRelicScRsp(uint avatarId)
		: base(8268)
	{
		RelicSmartWearGetPinRelicScRsp data = new RelicSmartWearGetPinRelicScRsp
		{
			AvatarId = avatarId
		};
		SetData(data);
	}
}
