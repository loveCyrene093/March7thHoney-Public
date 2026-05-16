using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Avatar;

public class PacketAddAvatarScNotify : BasePacket
{
	public PacketAddAvatarScNotify(int avatarId, bool isGacha)
		: base(374)
	{
		AddAvatarScNotify data = new AddAvatarScNotify
		{
			BaseAvatarId = (uint)avatarId,
			IsNew = true,
			Src = (isGacha ? AddAvatarSrcState.AddAvatarSrcGacha : AddAvatarSrcState.AddAvatarSrcNone)
		};
		SetData(data);
	}
}
