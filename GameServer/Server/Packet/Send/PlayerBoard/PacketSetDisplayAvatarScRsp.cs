using Google.Protobuf.Collections;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.PlayerBoard;

public class PacketSetDisplayAvatarScRsp : BasePacket
{
	public PacketSetDisplayAvatarScRsp(RepeatedField<DisplayAvatarData> avatars)
		: base(2818)
	{
		SetDisplayAvatarScRsp setDisplayAvatarScRsp = new SetDisplayAvatarScRsp();
		setDisplayAvatarScRsp.DisplayAvatarList.AddRange(avatars);
		SetData(setDisplayAvatarScRsp);
	}
}
