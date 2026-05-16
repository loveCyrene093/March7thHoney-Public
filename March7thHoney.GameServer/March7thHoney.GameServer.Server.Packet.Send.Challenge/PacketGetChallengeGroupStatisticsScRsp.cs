using System.Collections.Generic;
using System.Linq;
using Google.Protobuf.Collections;
using March7thHoney.Database.Friend;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Challenge;

public class PacketGetChallengeGroupStatisticsScRsp : BasePacket
{
	public PacketGetChallengeGroupStatisticsScRsp(uint groupId, ChallengeGroupStatisticsPb? data)
		: base(1732)
	{
		GetChallengeGroupStatisticsScRsp getChallengeGroupStatisticsScRsp = new GetChallengeGroupStatisticsScRsp
		{
			GroupId = groupId
		};
		if (data != null)
		{
			if (data.StoryGroupStatistics != null && data.StoryGroupStatistics.Count > 0)
			{
				StoryGroupStatisticsPb storyGroupStatisticsPb = data.StoryGroupStatistics.Values.MaxBy((StoryGroupStatisticsPb x) => x.Level);
				getChallengeGroupStatisticsScRsp.ChallengeStory = new ChallengeStoryStatistics
				{
					RecordId = storyGroupStatisticsPb.RecordId,
					NCEGEKNLJCE = new PLJJECPCMJD
					{
						Level = storyGroupStatisticsPb.Level,
						ABJGNBJMJJG = storyGroupStatisticsPb.Stars,
						BuffOne = storyGroupStatisticsPb.BuffOne,
						BuffTwo = storyGroupStatisticsPb.BuffTwo,
						ScoreId = storyGroupStatisticsPb.Score
					}
				};
				AddLineups(getChallengeGroupStatisticsScRsp.ChallengeStory.NCEGEKNLJCE.LineupList, storyGroupStatisticsPb.Lineups);
			}
			else if (data.MemoryGroupStatistics != null && data.MemoryGroupStatistics.Count > 0)
			{
				MemoryGroupStatisticsPb memoryGroupStatisticsPb = data.MemoryGroupStatistics.Values.MaxBy((MemoryGroupStatisticsPb x) => x.Level);
				getChallengeGroupStatisticsScRsp.ChallengeDefault = new ChallengeStatistics
				{
					RecordId = memoryGroupStatisticsPb.RecordId,
					NCEGEKNLJCE = new FPDKBGJKPFF
					{
						Level = memoryGroupStatisticsPb.Level,
						ABJGNBJMJJG = memoryGroupStatisticsPb.Stars,
						RoundCount = memoryGroupStatisticsPb.RoundCount
					}
				};
				AddLineups(getChallengeGroupStatisticsScRsp.ChallengeDefault.NCEGEKNLJCE.LineupList, memoryGroupStatisticsPb.Lineups);
			}
			else if (data.BossGroupStatistics != null && data.BossGroupStatistics.Count > 0)
			{
				BossGroupStatisticsPb bossGroupStatisticsPb = data.BossGroupStatistics.Values.MaxBy((BossGroupStatisticsPb x) => x.Level);
				getChallengeGroupStatisticsScRsp.ChallengeBoss = new ChallengeBossStatistics
				{
					RecordId = bossGroupStatisticsPb.RecordId,
					NCEGEKNLJCE = new BHFAFMDHKKC
					{
						Level = bossGroupStatisticsPb.Level,
						ABJGNBJMJJG = bossGroupStatisticsPb.Stars,
						BuffOne = bossGroupStatisticsPb.BuffOne,
						BuffTwo = bossGroupStatisticsPb.BuffTwo,
						ScoreId = bossGroupStatisticsPb.Score
					}
				};
				AddLineups(getChallengeGroupStatisticsScRsp.ChallengeBoss.NCEGEKNLJCE.LineupList, bossGroupStatisticsPb.Lineups);
			}
		}
		SetData(getChallengeGroupStatisticsScRsp);
	}

	private static void AddLineups(RepeatedField<ChallengeLineupList> target, List<List<ChallengeAvatarInfoPb>> source)
	{
		foreach (List<ChallengeAvatarInfoPb> item in source)
		{
			ChallengeLineupList challengeLineupList = new ChallengeLineupList();
			challengeLineupList.AvatarList.AddRange(item.Select((ChallengeAvatarInfoPb x) => x.ToProto()));
			target.Add(challengeLineupList);
		}
	}
}
