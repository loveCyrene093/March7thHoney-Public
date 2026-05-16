using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Music;

namespace March7thHoney.GameServer.Server.Packet.Recv.Music;

[Opcode(7573)]
public class HandlerMusicRhythmFinishLevelCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		int curMusicLevel = connection.Player.Data.CurMusicLevel;
		await connection.SendPacket(new PacketMusicRhythmFinishLevelScRsp((uint)curMusicLevel));
	}
}
