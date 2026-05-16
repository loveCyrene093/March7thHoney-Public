using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Phone;

public class PacketSelectPhoneThemeScRsp : BasePacket
{
	public PacketSelectPhoneThemeScRsp(uint themeId)
		: base(5109)
	{
		SelectPhoneThemeScRsp data = new SelectPhoneThemeScRsp
		{
			CurPhoneTheme = themeId
		};
		SetData(data);
	}
}
