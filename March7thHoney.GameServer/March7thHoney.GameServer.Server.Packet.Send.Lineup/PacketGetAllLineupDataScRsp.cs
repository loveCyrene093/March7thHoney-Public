using March7thHoney.Database.Lineup;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Lineup;

public class PacketGetAllLineupDataScRsp : BasePacket
{
	public PacketGetAllLineupDataScRsp(PlayerInstance player)
		: base(707)
	{
		GetAllLineupDataScRsp getAllLineupDataScRsp = new GetAllLineupDataScRsp
		{
			CurIndex = (uint)player.LineupManager.LineupData.CurLineup
		};
		foreach (March7thHoney.Database.Lineup.LineupInfo item in player.LineupManager.GetAllLineup())
		{
			getAllLineupDataScRsp.LineupList.Add(item.ToProto());
		}
		SetData(getAllLineupDataScRsp);
	}
}
