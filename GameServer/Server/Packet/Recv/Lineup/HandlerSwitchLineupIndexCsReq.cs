using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Lineup;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Lineup;

[Opcode(738)]
public class HandlerSwitchLineupIndexCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SwitchLineupIndexCsReq req = SwitchLineupIndexCsReq.Parser.ParseFrom(data);
		if (await connection.Player.LineupManager.SetCurLineup((int)req.Index))
		{
			await connection.SendPacket(new PacketSwitchLineupIndexScRsp(req.Index));
		}
	}
}
