using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Mail;

public class PacketMarkReadMailScRsp : BasePacket
{
	public PacketMarkReadMailScRsp(uint mailId)
		: base(895)
	{
		MarkReadMailScRsp data = new MarkReadMailScRsp
		{
			Id = mailId
		};
		SetData(data);
	}

	public PacketMarkReadMailScRsp(Retcode retcode)
		: base(895)
	{
		MarkReadMailScRsp data = new MarkReadMailScRsp
		{
			Retcode = (uint)retcode
		};
		SetData(data);
	}
}
