using System.Collections.Generic;
using SqlSugar;

namespace March7thHoney.Database.TrainParty;

[SugarTable("TrainParty")]
public class TrainData : BaseDatabaseDataHelper
{
	public int Fund { get; set; }

	public int RecordId { get; set; }

	public uint WorldId { get; set; }

	public long RefreshTime { get; set; }

	public bool BadgeAutoFill { get; set; }

	[SugarColumn(IsJson = true)]
	public List<uint> UnlockedPassengerIds { get; set; } = new List<uint>();

	[SugarColumn(IsJson = true)]
	public List<uint> PassengerRecordMarks { get; set; } = new List<uint>();

	[SugarColumn(IsJson = true)]
	public List<TrainCardInfo> Cards { get; set; } = new List<TrainCardInfo>();

	[SugarColumn(IsJson = true)]
	public List<TrainPendingPassengerInfo> GameplayPassengers { get; set; } = new List<TrainPendingPassengerInfo>();

	[SugarColumn(IsJson = true)]
	public List<TrainSkillInfo> GameplaySkills { get; set; } = new List<TrainSkillInfo>();

	[SugarColumn(IsJson = true)]
	public List<TrainMoveInfo> MoveHistory { get; set; } = new List<TrainMoveInfo>();

	public int GameplayRound { get; set; }

	public int GameplayType { get; set; }

	public int GameplayQueuePosition { get; set; }

	public int LastUsedCardId { get; set; }

	[SugarColumn(IsJson = true)]
	public Dictionary<int, TrainAreaInfo> Areas { get; set; } = new Dictionary<int, TrainAreaInfo>();

	[SugarColumn(IsJson = true)]
	public List<TrainSelfDisplayEntry> SelfDisplay { get; set; } = new List<TrainSelfDisplayEntry>();

	[SugarColumn(IsJson = true)]
	public Dictionary<int, long> PropTimes { get; set; } = new Dictionary<int, long>();

	[SugarColumn(IsJson = true)]
	public Dictionary<int, long> TimedDynamicPropTimes { get; set; } = new Dictionary<int, long>();
}
