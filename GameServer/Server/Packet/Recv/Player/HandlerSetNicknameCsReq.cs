using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.PlayerSync;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Player;

[Opcode(61)]
public class HandlerSetNicknameCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		PlayerInstance player = connection.Player;
		SetNicknameCsReq setNicknameCsReq = SetNicknameCsReq.Parser.ParseFrom(data);
		if (setNicknameCsReq != null)
		{
			player.Data.Name = setNicknameCsReq.Nickname;
			await connection.SendPacket(7);
			await connection.SendPacket(new PacketPlayerSyncScNotify(player.ToProto()));
			await connection.SendWatermarkLuaAsync();
		}
	}
}
