using System.Threading.Tasks;
using March7thHoney.Database.Lineup;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Lineup;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Lineup;

[Opcode(737)]
public class HandlerChangeLineupLeaderCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		ChangeLineupLeaderCsReq req = ChangeLineupLeaderCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		if (player.LineupManager.GetCurLineup() == null)
		{
			await connection.SendPacket(new PacketChangeLineupLeaderScRsp());
			return;
		}
		March7thHoney.Database.Lineup.LineupInfo curLineup = player.LineupManager.GetCurLineup();
		if (curLineup.BaseAvatars?.Count <= (int?)req.Slot)
		{
			await connection.SendPacket(new PacketChangeLineupLeaderScRsp());
			return;
		}
		int leaderAvatarId = (curLineup.LeaderAvatarId = curLineup.BaseAvatars[(int)req.Slot].BaseAvatarId);
		await player.MissionManager.HandleFinishType(MissionFinishTypeEnum.TeamLeaderChange);
		await player.SceneInstance.OnChangeLeader(leaderAvatarId);
		await connection.SendPacket(new PacketChangeLineupLeaderScRsp(req.Slot));
	}
}
