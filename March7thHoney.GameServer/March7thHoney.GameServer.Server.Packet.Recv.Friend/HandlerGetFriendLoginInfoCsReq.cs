using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Database.Player;
using March7thHoney.GameServer.Server.Packet.Send.Friend;

namespace March7thHoney.GameServer.Server.Packet.Recv.Friend;

[Opcode(2966)]
public class HandlerGetFriendLoginInfoCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		List<int> friends = (from x in connection.Player.FriendManager.GetFriendPlayerData()
			select x.Uid).ToList();
		await connection.SendPacket(new PacketGetFriendLoginInfoScRsp(friends));
	}
}
