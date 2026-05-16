using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Music;

public class PacketMusicRhythmUnlockTrackScNotify : BasePacket
{
	public PacketMusicRhythmUnlockTrackScNotify()
		: base(7578)
	{
		MusicRhythmUnlockTrackScNotify data = new MusicRhythmUnlockTrackScNotify();
		SetData(data);
	}
}
