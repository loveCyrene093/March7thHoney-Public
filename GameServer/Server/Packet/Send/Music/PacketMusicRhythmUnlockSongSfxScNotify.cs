using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Music;

public class PacketMusicRhythmUnlockSongSfxScNotify : BasePacket
{
	public PacketMusicRhythmUnlockSongSfxScNotify()
		: base(7595)
	{
		MusicRhythmUnlockSongSfxScNotify data = new MusicRhythmUnlockSongSfxScNotify();
		SetData(data);
	}
}
