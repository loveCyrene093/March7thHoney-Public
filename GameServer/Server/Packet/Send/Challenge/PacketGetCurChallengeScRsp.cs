using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Challenge.Definitions;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Challenge;

public class PacketGetCurChallengeScRsp : BasePacket
{
	public PacketGetCurChallengeScRsp(PlayerInstance player)
		: base(1739)
	{
		GetCurChallengeScRsp getCurChallengeScRsp = new GetCurChallengeScRsp();
		BaseChallengeInstance challengeInstance = player.ChallengeManager.ChallengeInstance;
		BaseLegacyChallengeInstance inst = challengeInstance as BaseLegacyChallengeInstance;
		if (inst != null)
		{
			getCurChallengeScRsp.CurChallenge = inst.ToProto();
			Task.Run(async delegate
			{
				await player.LineupManager.SetExtraLineup((ExtraLineupType)inst.GetCurrentExtraLineupType());
			}).Wait();
			LineupInfo lineupInfo = player.LineupManager?.GetExtraLineup(ExtraLineupType.LineupChallenge)?.ToProto();
			if (lineupInfo != null)
			{
				getCurChallengeScRsp.LineupList.Add(lineupInfo);
			}
			LineupInfo lineupInfo2 = player.LineupManager?.GetExtraLineup(ExtraLineupType.LineupChallenge2)?.ToProto();
			if (lineupInfo2 != null)
			{
				getCurChallengeScRsp.LineupList.Add(lineupInfo2);
			}
		}
		else
		{
			getCurChallengeScRsp.Retcode = 0u;
		}
		SetData(getCurChallengeScRsp);
	}
}
