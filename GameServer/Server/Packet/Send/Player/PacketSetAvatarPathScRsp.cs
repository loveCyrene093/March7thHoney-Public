using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Player;

public class PacketSetAvatarPathScRsp : BasePacket
{
	public PacketSetAvatarPathScRsp(int avatarId)
		: base(305)
	{
		SetAvatarPathScRsp data = new SetAvatarPathScRsp
		{
			AvatarId = (MultiPathAvatarType)avatarId
		};
		SetData(data);
	}
}
