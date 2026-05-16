using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.GridFight;

public class PacketGridFightSyncKeepWinCntNotify : BasePacket
{
	public PacketGridFightSyncKeepWinCntNotify(uint cnt)
		: base(8767)
	{
		SetData(new GridFightSyncKeepWinCntNotify
		{
			LBJPDJFHIBF = cnt
		});
	}
}
