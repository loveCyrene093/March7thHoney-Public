using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Gacha;

public class PacketDoGachaScRsp : BasePacket
{
	public PacketDoGachaScRsp(DoGachaScRsp rsp)
		: base(1995)
	{
		SetData(rsp);
	}

	public PacketDoGachaScRsp()
		: base(1995)
	{
		DoGachaScRsp data = new DoGachaScRsp
		{
			Retcode = 1u
		};
		SetData(data);
	}
}
