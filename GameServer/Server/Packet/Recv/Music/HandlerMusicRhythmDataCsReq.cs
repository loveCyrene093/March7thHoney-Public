using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Music;

namespace March7thHoney.GameServer.Server.Packet.Recv.Music;

[Opcode(7572)]
public class HandlerMusicRhythmDataCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketMusicRhythmDataScRsp());
		await connection.SendPacket(7597);
	}
}
