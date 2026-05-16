using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.GridFight;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.GridFight;

[Opcode(8496)]
public class HandlerGridFightSeasonTalentEnableCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GridFightSeasonTalentEnableCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketGridFightSeasonTalentEnableScRsp());
	}
}
