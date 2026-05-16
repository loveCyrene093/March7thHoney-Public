using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Player;
using March7thHoney.GameServer.Server.Packet.Send.Scene;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Server.Packet.Recv.Scene;

[Opcode(1493)]
public class HandlerSetClientPausedCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		bool paused = SetClientPausedCsReq.Parser.ParseFrom(data).Paused;
		await connection.SendPacket(new PacketSetClientPausedScRsp(paused));
		if (ConfigManager.Config.ServerOption.ServerAnnounce.EnableAnnounce)
		{
			await connection.SendPacket(new PacketServerAnnounceNotify());
		}
	}
}
