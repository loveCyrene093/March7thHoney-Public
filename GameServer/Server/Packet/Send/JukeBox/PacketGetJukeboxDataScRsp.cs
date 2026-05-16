using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.JukeBox;

public class PacketGetJukeboxDataScRsp : BasePacket
{
	public PacketGetJukeboxDataScRsp(PlayerInstance player)
		: base(3110)
	{
		GetJukeboxDataScRsp getJukeboxDataScRsp = new GetJukeboxDataScRsp
		{
			JILKOPINLDC = new MCPPIEJEBEF
			{
				LEKGBMCOJDB = new NKLAFFLJCHG
				{
					Id = (uint)player.Data.CurrentBgm
				}
			}
		};
		foreach (BackGroundMusicExcel value in GameData.BackGroundMusicData.Values)
		{
			getJukeboxDataScRsp.UnlockedMusicList.Add(new MusicData
			{
				Id = (uint)value.ID,
				GroupId = (uint)value.GroupID,
				IsPlayed = true
			});
		}
		SetData(getJukeboxDataScRsp);
	}
}
