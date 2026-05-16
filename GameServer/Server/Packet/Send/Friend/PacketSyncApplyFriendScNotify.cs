using March7thHoney.Database.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Server.Packet.Send.Friend;

public class PacketSyncApplyFriendScNotify : BasePacket
{
	public PacketSyncApplyFriendScNotify(PlayerData player)
		: base(2963)
	{
		SyncApplyFriendScNotify data = new SyncApplyFriendScNotify
		{
			FriendApplyInfo = new FriendApplyInfo
			{
				ApplyTime = Extensions.GetUnixSec(),
				PlayerInfo = player.ToSimpleProto(FriendOnlineStatus.Online)
			}
		};
		SetData(data);
	}
}
