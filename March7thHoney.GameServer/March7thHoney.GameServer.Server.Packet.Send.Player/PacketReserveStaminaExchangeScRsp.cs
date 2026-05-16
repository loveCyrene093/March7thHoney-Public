using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Player;

public class PacketReserveStaminaExchangeScRsp : BasePacket
{
	public PacketReserveStaminaExchangeScRsp(uint amount)
		: base(31)
	{
		ReserveStaminaExchangeScRsp reserveStaminaExchangeScRsp = new ReserveStaminaExchangeScRsp();
		if (amount != 0)
		{
			reserveStaminaExchangeScRsp.Num = amount;
		}
		else
		{
			reserveStaminaExchangeScRsp.Retcode = 1u;
		}
		SetData(reserveStaminaExchangeScRsp);
	}
}
