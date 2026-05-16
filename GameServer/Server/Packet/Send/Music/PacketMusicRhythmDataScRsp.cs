using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Music;

public class PacketMusicRhythmDataScRsp : BasePacket
{
	public PacketMusicRhythmDataScRsp()
		: base(7588)
	{
		MusicRhythmDataScRsp musicRhythmDataScRsp = new MusicRhythmDataScRsp
		{
			ShowHint = true
		};
		foreach (MusicRhythmLevelExcel value in GameData.MusicRhythmLevelData.Values)
		{
			musicRhythmDataScRsp.LevelDataList.Add(new MusicRhythmLevel
			{
				LevelId = (uint)value.GetId(),
				FullCombo = true,
				UnlockLevel = 3u
			});
		}
		foreach (MusicRhythmGroupExcel value2 in GameData.MusicRhythmGroupData.Values)
		{
			musicRhythmDataScRsp.MusicGroup.Add(new MusicRhythmGroup
			{
				MusicGroupId = (uint)value2.GetId(),
				MusicGroupPhase = (uint)value2.Phase
			});
		}
		foreach (MusicRhythmSongExcel value3 in GameData.MusicRhythmSongData.Values)
		{
			musicRhythmDataScRsp.UnlockSongList.Add((uint)value3.GetId());
		}
		foreach (MusicRhythmTrackExcel value4 in GameData.MusicRhythmTrackData.Values)
		{
			musicRhythmDataScRsp.UnlockTrackList.Add((uint)value4.GetId());
		}
		foreach (MusicRhythmPhaseExcel value5 in GameData.MusicRhythmPhaseData.Values)
		{
			musicRhythmDataScRsp.UnlockPhaseList.Add((uint)value5.GetId());
		}
		SetData(musicRhythmDataScRsp);
	}
}
