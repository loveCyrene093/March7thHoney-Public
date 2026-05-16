using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Music;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Music;

[Opcode(7574)]
public class HandlerMusicRhythmStartLevelCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		uint levelId = MusicRhythmStartLevelCsReq.Parser.ParseFrom(data).LevelId;
		connection.Player.Data.CurMusicLevel = (int)levelId;
		await connection.SendPacket(new PacketMusicRhythmStartLevelScRsp(levelId));
	}
}
