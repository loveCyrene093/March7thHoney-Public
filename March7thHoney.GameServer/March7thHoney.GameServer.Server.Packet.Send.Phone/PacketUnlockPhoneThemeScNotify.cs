using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Phone;

public class PacketUnlockPhoneThemeScNotify : BasePacket
{
	public PacketUnlockPhoneThemeScNotify(int themeId)
		: base(5198)
	{
		SetData(new UnlockPhoneThemeScNotify
		{
			ThemeId = (uint)themeId
		});
	}
}
