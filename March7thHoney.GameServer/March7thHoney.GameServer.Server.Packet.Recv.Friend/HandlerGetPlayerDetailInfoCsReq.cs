using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Database.Player;
using March7thHoney.GameServer.Server.Packet.Send.Friend;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Friend;

[Opcode(2994)]
public class HandlerGetPlayerDetailInfoCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GetPlayerDetailInfoCsReq getPlayerDetailInfoCsReq = GetPlayerDetailInfoCsReq.Parser.ParseFrom(data);
		PlayerData playerData = connection.Player.FriendManager.GetFriendPlayerData(new List<int>(1) { (int)getPlayerDetailInfoCsReq.Uid }).FirstOrDefault();
		if (playerData == null)
		{
			await connection.SendPacket(new PacketGetPlayerDetailInfoScRsp());
		}
		else
		{
			await connection.SendPacket(new PacketGetPlayerDetailInfoScRsp(playerData.ToDetailProto()));
		}
	}
}
