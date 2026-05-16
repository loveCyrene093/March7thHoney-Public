using March7thHoney.Database.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Friend;

public class PacketHandleFriendScRsp : BasePacket
{
	public PacketHandleFriendScRsp(uint uid, bool isAccept)
		: base(2939)
	{
		HandleFriendScRsp data = new HandleFriendScRsp
		{
			Uid = uid,
			IsAccept = isAccept
		};
		SetData(data);
	}

	public PacketHandleFriendScRsp(uint uid, bool isAccept, PlayerData playerData)
		: base(2939)
	{
		FriendOnlineStatus status = ((Listener.GetActiveConnection((int)uid) != null) ? FriendOnlineStatus.Online : FriendOnlineStatus.Offline);
		HandleFriendScRsp data = new HandleFriendScRsp
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
