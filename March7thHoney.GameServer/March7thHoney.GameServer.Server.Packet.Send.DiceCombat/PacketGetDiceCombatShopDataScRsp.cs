using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.DiceCombat;

public class PacketGetDiceCombatShopDataScRsp : BasePacket
{
	public PacketGetDiceCombatShopDataScRsp()
		: base(9277)
	{
		SetData(new GetShopDataScRsp
		{
			Retcode = 0u
		});
	}
}
