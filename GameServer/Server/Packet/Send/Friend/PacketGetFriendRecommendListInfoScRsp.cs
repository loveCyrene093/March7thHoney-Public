using System.Collections.Generic;
using System.Linq;
using March7thHoney.Database.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Friend;

public class PacketGetFriendRecommendListInfoScRsp : BasePacket
{
	public PacketGetFriendRecommendListInfoScRsp(List<PlayerData> friends)
		: base(2961)
	{
		GetFriendRecommendListInfoScRsp data = new GetFriendRecommendListInfoScRsp
		{
			FriendRecommendList = { friends.Select((PlayerData x) => new FriendRecommendInfo
			{
				PlayerInfo = x.ToSimpleProto(FriendOnlineStatus.Online)
			}) }
		};
		SetData(data);
	}
}
