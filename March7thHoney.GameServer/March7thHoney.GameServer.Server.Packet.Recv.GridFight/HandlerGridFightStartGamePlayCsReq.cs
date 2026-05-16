using System.Threading.Tasks;
using March7thHoney.GameServer.Game.GridFight;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.GridFight;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.GridFight;

[Opcode(8519)]
public class HandlerGridFightStartGamePlayCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GridFightStartGamePlayCsReq gridFightStartGamePlayCsReq = GridFightStartGamePlayCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		new GridFightService(player).StartAndPrepare(gridFightStartGamePlayCsReq.Season, gridFightStartGamePlayCsReq.DivisionId, gridFightStartGamePlayCsReq.IsOverlock);
		await connection.SendPacket(new PacketINHDFEIOBNK(player));
	}
}
