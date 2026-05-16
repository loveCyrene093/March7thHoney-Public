using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Item;

public class PacketExchangeHcoinScRsp : BasePacket
{
	public PacketExchangeHcoinScRsp(uint num, Retcode retcode = Retcode.RetSucc)
		: base(544)
	{
		ExchangeHcoinScRsp data = new ExchangeHcoinScRsp
		{
			Num = num,
			Retcode = (uint)retcode
		};
		SetData(data);
	}
}
