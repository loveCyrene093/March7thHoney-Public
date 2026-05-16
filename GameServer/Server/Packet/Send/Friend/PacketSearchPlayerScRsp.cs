using System.Collections.Generic;
using System.Linq;
using March7thHoney.Database.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Friend;

public class PacketSearchPlayerScRsp : BasePacket
{
	public PacketSearchPlayerScRsp()
		: base(2921)
	{
		SearchPlayerScRsp data = new SearchPlayerScRsp
		{
			Retcode = 3612u
		};
		SetData(data);
	}

	public PacketSearchPlayerScRsp(List<PlayerData> data)
		: base(2921)
	{
		SearchPlayerScRsp searchPlayerScRsp = new SearchPlayerScRsp();
		searchPlayerScRsp.ResultUidList.AddRange(data.Select((PlayerData x) => (uint)x.Uid));
		searchPlayerScRsp.SimpleInfoList.AddRange(data.Select((PlayerData x) => x.ToSimpleProto(FriendOnlineStatus.Online)));
		SetData(searchPlayerScRsp);
	}
}
