using System.Collections.Generic;

namespace March7thHoney.Database.Friend;

public class StoryGroupStatisticsPb
{
	public uint RecordId { get; set; }

	public uint Level { get; set; }

	public uint Score { get; set; }

	public uint BuffOne { get; set; }

	public uint BuffTwo { get; set; }

	public uint Stars { get; set; }

	public List<List<ChallengeAvatarInfoPb>> Lineups { get; set; } = new List<List<ChallengeAvatarInfoPb>>();

	public object ToProto()
	{
		return new { RecordId, Level, Score, BuffOne, BuffTwo, Stars };
	}
}
