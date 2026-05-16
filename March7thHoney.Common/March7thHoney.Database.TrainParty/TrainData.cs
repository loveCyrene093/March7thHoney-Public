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

	[SugarColumn(IsJson = true)]
	public Dictionary<int, TrainAreaInfo> Areas { get; set; } = new Dictionary<int, TrainAreaInfo>();

	[SugarColumn(IsJson = true)]
	public List<TrainSelfDisplayEntry> SelfDisplay { get; set; } = new List<TrainSelfDisplayEntry>();
}
