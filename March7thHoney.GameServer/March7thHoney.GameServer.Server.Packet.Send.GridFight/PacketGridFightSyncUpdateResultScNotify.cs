using System.Collections.Generic;
using March7thHoney.GameServer.Game.GridFight.Sync;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.GridFight;

public class PacketGridFightSyncUpdateResultScNotify : BasePacket
{
	public PacketGridFightSyncUpdateResultScNotify(PlayerInstance player, IEnumerable<GridFightPosInfo>? updatedPosList = null)
		: base(8456)
	{
		SetData(GridFightSyncBuilder.Build(player, updatedPosList));
	}

	public PacketGridFightSyncUpdateResultScNotify(PlayerInstance player, int kind, object? extra = null)
		: base(8456)
	{
		SetData(GridFightSyncBuilder.Build(player, null, kind, extra));
	}

	public PacketGridFightSyncUpdateResultScNotify(GridFightSyncUpdateResultScNotify built)
		: base(8456)
	{
		SetData(built);
	}
}
