using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Avatar;

public class PacketSetAvatarEnhancedIdScRsp : BasePacket
{
	public PacketSetAvatarEnhancedIdScRsp(Retcode retcode)
		: base(379)
	{
		SetAvatarEnhancedIdScRsp data = new SetAvatarEnhancedIdScRsp
		{
			Retcode = (uint)retcode
		};
		SetData(data);
	}

	public PacketSetAvatarEnhancedIdScRsp(uint avatarId, int enhanceId)
		: base(379)
	{
		SetAvatarEnhancedIdScRsp data = new SetAvatarEnhancedIdScRsp
		{
			UnkEnhancedId = (uint)enhanceId,
			GrowthAvatarId = avatarId
		};
		SetData(data);
	}
}
