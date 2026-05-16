using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Friend;

public class PacketSyncAddBlacklistScNotify : BasePacket
{
	public PacketSyncAddBlacklistScNotify(int uid)
		: base(2932)
	{
		SyncAddBlacklistScNotify data = new SyncAddBlacklistScNotify
		{
			Uid = (uint)uid
		};
		SetData(data);
	}
}
