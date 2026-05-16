using System.Collections.Generic;
using SqlSugar;

namespace March7thHoney.Database.Challenge;

[SugarTable("Challenge")]
public class ChallengeData : BaseDatabaseDataHelper
{
	[SugarColumn(IsJson = true)]
	public Dictionary<int, ChallengeHistoryData> History { get; set; } = new Dictionary<int, ChallengeHistoryData>();

	[SugarColumn(IsNullable = true)]
	public string? ChallengeInstance { get; set; }

	[SugarColumn]
	public string Instance { get; set; } = "";

	[SugarColumn(IsJson = true)]
	public Dictionary<int, ChallengeGroupReward> TakenRewards { get; set; } = new Dictionary<int, ChallengeGroupReward>();

	[SugarColumn(IsJson = true)]
	public Dictionary<int, List<int>> PeakTakenRewardIds { get; set; } = new Dictionary<int, List<int>>();

	[SugarColumn(IsJson = true)]
	public Dictionary<int, ChallengePeakLevelData> PeakLevelDatas { get; set; } = new Dictionary<int, ChallengePeakLevelData>();

	[SugarColumn(IsJson = true)]
	public Dictionary<int, ChallengePeakBossLevelData> PeakBossLevelDatas { get; set; } = new Dictionary<int, ChallengePeakBossLevelData>();

	public void Delete(int challengeId)
	{
		History.Remove(challengeId);
	}
}
