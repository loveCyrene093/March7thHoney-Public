using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Recommend;

public class PacketGetBigDataRecommendScRsp : BasePacket
{
	public PacketGetBigDataRecommendScRsp(uint avatarId, BigDataRecommendType type)
		: base(2401)
	{
		GetBigDataRecommendScRsp data = new GetBigDataRecommendScRsp
		{
			HasRecommand = true,
			EquipAvatar = avatarId,
			BigDataRecommendType = type
		};
		SetData(data);
	}
}
