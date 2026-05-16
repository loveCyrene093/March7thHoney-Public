using System.Collections.Generic;
using System.Linq;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Friend;

public class PacketGetFriendLoginInfoScRsp : BasePacket
{
	public PacketGetFriendLoginInfoScRsp(List<int> friends)
		: base(2905)
	{
		GetFriendLoginInfoScRsp data = new GetFriendLoginInfoScRsp
		{
			FriendUidList = { friends.Select((int x) => (uint)x) }
		};
		SetData(data);
	}
}
