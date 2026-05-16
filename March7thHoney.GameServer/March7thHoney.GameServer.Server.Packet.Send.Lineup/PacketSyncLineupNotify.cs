using March7thHoney.Database.Lineup;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Lineup;

public class PacketSyncLineupNotify : BasePacket
{
	public PacketSyncLineupNotify(March7thHoney.Database.Lineup.LineupInfo info, SyncLineupReason reason = SyncLineupReason.SyncReasonNone)
		: base(739)
	{
		SyncLineupNotify syncLineupNotify = new SyncLineupNotify
		{
			Lineup = info.ToProto()
		};
		if (reason != SyncLineupReason.SyncReasonNone)
		{
			syncLineupNotify.ReasonList.Add(reason);
		}
		SetData(syncLineupNotify);
	}
}
