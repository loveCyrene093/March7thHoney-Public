using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.Database.Avatar;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Plugin.Event;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Challenge;

[Opcode(1714)]
public class HandlerLeaveChallengeCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		PlayerInstance player = connection.Player;
		if (player.SceneInstance != null)
		{
			await player.ForceQuitBattle();
			player.LineupManager.SetExtraLineup(ExtraLineupType.LineupChallenge, new List<int>());
			player.LineupManager.SetExtraLineup(ExtraLineupType.LineupChallenge2, new List<int>());
			PluginEvent.InvokeOnPlayerQuitChallenge(player, player.ChallengeManager.ChallengeInstance);
			player.ChallengeManager.ChallengeInstance = null;
			player.ChallengeManager.ClearInstance();
			player.LineupManager.SetExtraLineup(ExtraLineupType.LineupNone, new List<int>());
			foreach (FormalAvatarInfo formalAvatar in player.LineupManager.GetCurLineup().AvatarData.FormalAvatars)
			{
				formalAvatar.CurrentHp = 10000;
			}
			int entryId = 100000103;
			if (player.SceneInstance.LeaveEntryId != 0)
			{
				entryId = player.SceneInstance.LeaveEntryId;
			}
			await player.EnterScene(entryId, 0, sendPacket: true);
		}
		await connection.SendPacket(1718);
	}
}
