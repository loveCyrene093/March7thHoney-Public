using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Mission;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Mission;

[Opcode(1261)]
public class HandlerGetMissionStatusCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GetMissionStatusCsReq getMissionStatusCsReq = GetMissionStatusCsReq.Parser.ParseFrom(data);
		if (getMissionStatusCsReq != null)
		{
			await connection.SendPacket(new PacketGetMissionStatusScRsp(getMissionStatusCsReq, connection.Player));
		}
	}
}
