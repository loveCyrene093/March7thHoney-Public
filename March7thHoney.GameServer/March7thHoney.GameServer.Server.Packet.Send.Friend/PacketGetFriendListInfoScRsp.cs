using March7thHoney.Kcp;

namespace March7thHoney.GameServer.Server.Packet.Send.Friend;

public class PacketGetFriendListInfoScRsp : BasePacket
{
	public PacketGetFriendListInfoScRsp(Connection connection)
		: base(2910)
	{
		SetData(connection.Player.FriendManager.ToProto());
	}
}
