using System.Threading.Tasks;
using March7thHoney.Database.Player;
using March7thHoney.GameServer.Server.Packet.Send.Friend;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Friend;

[Opcode(2938)]
public class HandlerAddBlacklistCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		AddBlacklistCsReq addBlacklistCsReq = AddBlacklistCsReq.Parser.ParseFrom(data);
		PlayerData playerData = await connection.Player.FriendManager.AddBlackList((int)addBlacklistCsReq.Uid);
		if (playerData != null)
		{
			await connection.SendPacket(new PacketAddBlacklistScRsp(playerData));
		}
		else
		{
			await connection.SendPacket(new PacketAddBlacklistScRsp());
		}
	}
}
