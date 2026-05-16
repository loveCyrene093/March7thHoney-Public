using System.Collections.Generic;

namespace March7thHoney.Database.Friend;

public class ChallengeGroupStatisticsPb
{
	public uint GroupId { get; set; }

	public Dictionary<uint, MemoryGroupStatisticsPb>? MemoryGroupStatistics { get; set; }

	public Dictionary<uint, StoryGroupStatisticsPb>? StoryGroupStatistics { get; set; }

	public Dictionary<uint, BossGroupStatisticsPb>? BossGroupStatistics { get; set; }

	public object ToProto()
	{
		return new { GroupId };
	}
}
