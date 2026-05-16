using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.JukeBox;

public class PacketPlayBackGroundMusicScRsp : BasePacket
{
	public PacketPlayBackGroundMusicScRsp(uint musicId)
		: base(3195)
	{
		PlayBackGroundMusicScRsp data = new PlayBackGroundMusicScRsp
		{
			JILKOPINLDC = new MCPPIEJEBEF
			{
				LEKGBMCOJDB = new NKLAFFLJCHG
				{
					Id = musicId
				}
			}
		};
		SetData(data);
	}
}
