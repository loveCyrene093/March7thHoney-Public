using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Player;

public class PacketUpdatePlayerSettingScRsp : BasePacket
{
	public PacketUpdatePlayerSettingScRsp(UpdatePlayerSetting setting)
		: base(15)
	{
		UpdatePlayerSettingScRsp data = new UpdatePlayerSettingScRsp
		{
			PlayerSetting = setting
		};
		SetData(data);
	}
}
