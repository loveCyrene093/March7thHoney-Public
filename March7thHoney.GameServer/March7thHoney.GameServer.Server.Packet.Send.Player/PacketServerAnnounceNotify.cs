using March7thHoney.Kcp;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Server.Packet.Send.Player;

public class PacketServerAnnounceNotify : BasePacket
{
	public PacketServerAnnounceNotify()
		: base(65)
	{
		ServerAnnounceNotify data = new ServerAnnounceNotify
		{
			AnnounceDataList = 
			{
				new AnnounceData
				{
					BeginTime = Extensions.GetUnixSec(),
					EndTime = Extensions.GetUnixSec() + 3600,
					ConfigId = 1u,
					BannerText = ConfigManager.Config.ServerOption.ServerAnnounce.AnnounceContent
				}
			}
		};
		if (ConfigManager.Config.ServerOption.ServerAnnounce.EnableAnnounce)
		{
			SetData(data);
		}
	}
}
