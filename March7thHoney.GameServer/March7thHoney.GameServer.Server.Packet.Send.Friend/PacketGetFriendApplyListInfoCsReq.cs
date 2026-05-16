using March7thHoney.Kcp;

namespace March7thHoney.GameServer.Server.Packet.Send.Friend;

public class PacketGetFriendApplyListInfoCsReq : BasePacket
{
	public PacketGetFriendApplyListInfoCsReq(Connection connection)
		: base(2918)
	{
		SetData(connection.Player.FriendManager.ToApplyListProto());
	}
}
