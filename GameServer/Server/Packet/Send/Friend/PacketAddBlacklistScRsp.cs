using March7thHoney.Database.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Friend;

public class PacketAddBlacklistScRsp : BasePacket
{
	public PacketAddBlacklistScRsp()
		: base(2972)
	{
		AddBlacklistScRsp data = new AddBlacklistScRsp();
		SetData(data);
	}

	public PacketAddBlacklistScRsp(PlayerData player)
		: base(2972)
	{
		FriendOnlineStatus status = ((Listener.GetActiveConnection(player.Uid) != null) ? FriendOnlineStatus.Online : FriendOnlineStatus.Offline);
		AddBlacklistScRsp data = new AddBlacklistScRsp
		{
			BlackInfo = player.ToSimpleProto(status)
		};
		SetData(data);
	}
}
