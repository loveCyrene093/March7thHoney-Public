using March7thHoney.Database.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Friend;

public class PacketSyncHandleFriendScNotify : BasePacket
{
	public PacketSyncHandleFriendScNotify(uint uid, bool isAccept, PlayerData playerData)
		: base(2901)
	{
		FriendOnlineStatus status = ((Listener.GetActiveConnection((int)uid) != null) ? FriendOnlineStatus.Online : FriendOnlineStatus.Offline);
		SyncHandleFriendScNotify data = new SyncHandleFriendScNotify
		{
			Uid = uid,
			IsAccept = isAccept,
			FriendInfo = new FriendSimpleInfo
			{
				PlayerInfo = playerData.ToSimpleProto(status)
			}
		};
		SetData(data);
	}
}
