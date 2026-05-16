using System.Collections.Generic;

namespace March7thHoney.Database.Challenge;

public class ChallengePeakLevelData
{
	public int LevelId { get; set; }

	public uint RoundCnt { get; set; }

	public uint PeakStar { get; set; }

	public List<uint> BaseAvatarList { get; set; } = new List<uint>();

	public List<uint> FinishedTargetList { get; set; } = new List<uint>();
}
