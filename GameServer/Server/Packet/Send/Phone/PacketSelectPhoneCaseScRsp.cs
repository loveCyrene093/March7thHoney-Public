using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Phone;

public class PacketSelectPhoneCaseScRsp : BasePacket
{
	public PacketSelectPhoneCaseScRsp(uint id)
		: base(5126)
	{
		SelectPhoneCaseScRsp data = new SelectPhoneCaseScRsp
		{
			CurPhoneCase = id
		};
		SetData(data);
	}
}
