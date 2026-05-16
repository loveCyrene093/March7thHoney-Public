using Google.Protobuf.Collections;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.PlayerBoard;

public class PacketSetAssistAvatarScRsp : BasePacket
{
	public PacketSetAssistAvatarScRsp(RepeatedField<uint> avatarId)
		: base(2874)
	{
		SetAssistAvatarScRsp setAssistAvatarScRsp = new SetAssistAvatarScRsp();
		setAssistAvatarScRsp.AvatarIdList.AddRange(avatarId);
		SetData(setAssistAvatarScRsp);
	}
}
