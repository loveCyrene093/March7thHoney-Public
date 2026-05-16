using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Player;

public class PacketAvatarPathChangedNotify : BasePacket
{
	public PacketAvatarPathChangedNotify(uint baseAvatarId, MultiPathAvatarType type)
		: base(311)
	{
		AvatarPathChangedNotify data = new AvatarPathChangedNotify
		{
			BaseAvatarId = baseAvatarId,
			CurMultiPathAvatarType = type
		};
		SetData(data);
	}
}
