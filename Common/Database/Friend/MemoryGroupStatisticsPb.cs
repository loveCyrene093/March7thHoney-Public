using System.Collections.Generic;

namespace March7thHoney.Database.Friend;

public class MemoryGroupStatisticsPb
{
	public uint RecordId { get; set; }

	public uint Level { get; set; }

	public uint RoundCount { get; set; }

	public uint Stars { get; set; }

	public List<List<ChallengeAvatarInfoPb>> Lineups { get; set; } = new List<List<ChallengeAvatarInfoPb>>();

	public object ToProto()
	{
		return new { RecordId, Level, RoundCount, Stars };
	}
}
