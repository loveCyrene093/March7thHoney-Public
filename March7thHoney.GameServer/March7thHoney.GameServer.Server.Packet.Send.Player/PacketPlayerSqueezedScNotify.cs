using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Player;

public class PacketPlayerSqueezedScNotify : BasePacket
{
	public PacketPlayerSqueezedScNotify()
		: base(63)
	{
		PlayerSqueezedScNotify data = new PlayerSqueezedScNotify
		{
			KickType = KickType.KickSqueezed
		};
		SetData(data);
	}

	public PacketPlayerSqueezedScNotify(KickType type, BlackInfo? info = null)
		: base(63)
	{
		PlayerSqueezedScNotify playerSqueezedScNotify = new PlayerSqueezedScNotify
		{
			KickType = type
		};
		if (info != null)
		{
			playerSqueezedScNotify.BlackInfo = info;
		}
		SetData(playerSqueezedScNotify);
	}
}
