using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Music;

public class PacketMusicRhythmStartLevelScRsp : BasePacket
{
	public PacketMusicRhythmStartLevelScRsp(uint levelId)
		: base(7589)
	{
		MusicRhythmStartLevelScRsp data = new MusicRhythmStartLevelScRsp
		{
			LevelId = levelId
		};
		SetData(data);
	}
}
