using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Challenge;

[Opcode(1794)]
public class HandlerStartChallengeCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		StartChallengeCsReq req = StartChallengeCsReq.Parser.ParseFrom(data);
		ChallengeStoryBuffInfo storyBuffInfo = null;
		ChallengeBuffInfo stageInfo = req.StageInfo;
		if (stageInfo != null && stageInfo.StoryInfo != null)
		{
			storyBuffInfo = req.StageInfo.StoryInfo;
		}
		ChallengeBossBuffInfo bossBuffInfo = null;
		if (req.StageInfo != null && req.StageInfo.BossInfo != null)
		{
			bossBuffInfo = req.StageInfo.BossInfo;
		}
		List<int> list = ((req.BKNKLEOCJNO.Count > 0) ? (from x in req.BKNKLEOCJNO
			select (int)x.Id into x
			where x > 0
			select x).ToList() : (from x in req.FirstLineup
			select (int)x into x
			where x > 0
			select x).ToList());
		if (list.Count > 0)
		{
			await connection.Player.LineupManager.ReplaceLineup(0, list, ExtraLineupType.LineupChallenge);
		}
		List<int> list2 = ((req.ABNDFKFIKCI.Count > 0) ? (from x in req.ABNDFKFIKCI
			select (int)x.Id into x
			where x > 0
			select x).ToList() : (from x in req.SecondLineup
			select (int)x into x
			where x > 0
			select x).ToList());
		if (list2.Count > 0)
		{
			await connection.Player.LineupManager.ReplaceLineup(0, list2, ExtraLineupType.LineupChallenge2);
		}
		await connection.Player.ChallengeManager.StartChallenge((int)req.ChallengeId, storyBuffInfo, bossBuffInfo);
	}
}
