using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum FriendOnlineStatus
{
	[OriginalName("FRIEND_ONLINE_STATUS_OFFLINE")]
	Offline,
	[OriginalName("FRIEND_ONLINE_STATUS_ONLINE")]
	Online
}
