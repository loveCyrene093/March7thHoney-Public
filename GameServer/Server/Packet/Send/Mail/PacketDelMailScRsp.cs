using System.Collections.Generic;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Mail;

public class PacketDelMailScRsp : BasePacket
{
	public PacketDelMailScRsp(List<uint> ids)
		: base(818)
	{
		DelMailScRsp data = new DelMailScRsp
		{
			IdList = { (IEnumerable<uint>)ids }
		};
		SetData(data);
	}
}
