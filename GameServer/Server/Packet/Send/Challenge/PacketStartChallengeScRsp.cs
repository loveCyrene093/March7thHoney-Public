using March7thHoney.GameServer.Game.Challenge.Definitions;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Challenge;

public class PacketStartChallengeScRsp : BasePacket
{
	public PacketStartChallengeScRsp(uint Retcode)
		: base(1795)
	{
		StartChallengeScRsp data = new StartChallengeScRsp
		{
			Retcode = Retcode
		};
		SetData(data);
	}

	public PacketStartChallengeScRsp(PlayerInstance player, bool sendScene = true)
		: base(1795)
	{
		StartChallengeScRsp startChallengeScRsp = new StartChallengeScRsp();
		if (player.ChallengeManager.ChallengeInstance != null)
		{
			if (player.ChallengeManager.ChallengeInstance is BaseLegacyChallengeInstance baseLegacyChallengeInstance)
			{
				startChallengeScRsp.CurChallenge = baseLegacyChallengeInstance.ToProto();
				startChallengeScRsp.StageInfo = baseLegacyChallengeInstance.ToStageInfo();
			}
			startChallengeScRsp.LineupList.Add(player.LineupManager.GetExtraLineup(ExtraLineupType.LineupChallenge).ToProto());
			startChallengeScRsp.LineupList.Add(player.LineupManager.GetExtraLineup(ExtraLineupType.LineupChallenge2).ToProto());
			if (sendScene)
			{
				startChallengeScRsp.Scene = player.SceneInstance.ToProto();
			}
		}
		else
		{
			startChallengeScRsp.Retcode = 1u;
		}
		SetData(startChallengeScRsp);
	}
}
