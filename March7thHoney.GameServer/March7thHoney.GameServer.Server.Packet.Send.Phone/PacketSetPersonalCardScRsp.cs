using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Phone;

public class PacketSetPersonalCardScRsp : BasePacket
{
	public PacketSetPersonalCardScRsp(uint id)
		: base(2804)
	{
		SetPersonalCardScRsp data = new SetPersonalCardScRsp
		{
			CurrentPersonalCardId = id
		};
		SetData(data);
	}
}
