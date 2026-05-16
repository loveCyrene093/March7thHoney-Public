using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Friend;

public class PacketSyncDeleteFriendScNotify : BasePacket
{
	public PacketSyncDeleteFriendScNotify(int uid)
		: base(2904)
	{
		SyncDeleteFriendScNotify data = new SyncDeleteFriendScNotify
		{
			Uid = (uint)uid
		};
		SetData(data);
	}
}
