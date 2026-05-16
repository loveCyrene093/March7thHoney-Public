using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Database.Player;
using March7thHoney.GameServer.Server.Packet.Send.Friend;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Friend;

[Opcode(2957)]
public class HandlerSearchPlayerCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SearchPlayerCsReq searchPlayerCsReq = SearchPlayerCsReq.Parser.ParseFrom(data);
		List<PlayerData> list = new List<PlayerData>();
		foreach (uint uid in searchPlayerCsReq.UidList)
		{
			PlayerData playerData = connection.Player.FriendManager.GetFriendPlayerData(new List<int>(1) { (int)uid }).FirstOrDefault((PlayerData x) => x.Uid == (int)uid);
			if (playerData != null)
			{
				list.Add(playerData);
			}
		}
		if (list.Count == 0)
		{
			await connection.SendPacket(new PacketSearchPlayerScRsp());
		}
		else
		{
			await connection.SendPacket(new PacketSearchPlayerScRsp(list));
		}
	}
}
