using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Mail;

public class PacketNewMailScNotify : BasePacket
{
	public PacketNewMailScNotify(int id)
		: base(863)
	{
		NewMailScNotify data = new NewMailScNotify
		{
			MailIdList = { (uint)id }
		};
		SetData(data);
	}
}
