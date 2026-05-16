using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Player;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Player;

[Opcode(12)]
public class HandlerPlayerHeartBeatCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		PlayerHeartBeatCsReq playerHeartBeatCsReq = PlayerHeartBeatCsReq.Parser.ParseFrom(data);
		if (playerHeartBeatCsReq != null)
		{
			await connection.SendPacket(new PacketPlayerHeartBeatScRsp((long)playerHeartBeatCsReq.ClientTimeMs));
		}
		await connection.Player.OnHeartBeat();
	}
}
