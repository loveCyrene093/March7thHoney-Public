using System.Collections.Generic;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Gacha;

public class PacketSetGachaDecideItemScRsp : BasePacket
{
	public PacketSetGachaDecideItemScRsp(uint gachaId, List<uint> order)
		: base(1926)
	{
		SetGachaDecideItemScRsp data = new SetGachaDecideItemScRsp
		{
			LECPJJAMNPF = new OEIEJHBCOOM
			{
				PAPOKACIPPJ = gachaId,
				DGOMHDMJHEK = { (IEnumerable<uint>)order },
				MBOEFLAHLEM = 1u
			}
		};
		SetData(data);
	}
}
