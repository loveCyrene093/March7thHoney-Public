using March7thHoney.GameServer.Game.GridFight;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.GridFight;

public class PacketGridFightEndBattleStageNotify : BasePacket
{
	public PacketGridFightEndBattleStageNotify(GridFightInstance? inst = null, bool win = true)
		: base(8770)
	{
		SetData((inst != null) ? inst.BuildEndBattleNotify(win) : new GridFightEndBattleStageNotify());
	}
}
