using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Mission;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Mission;

[Opcode(1208)]
public class HandlerGetMainMissionCustomValueCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GetMainMissionCustomValueCsReq req = GetMainMissionCustomValueCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		await connection.SendPacket(new PacketGetMainMissionCustomValueScRsp(req, player));
	}
}
