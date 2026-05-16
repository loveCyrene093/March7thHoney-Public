using System;
using System.Collections.Generic;
using SqlSugar;

namespace March7thHoney.Database.Scene;

[SugarTable("RaidData")]
public class RaidData : BaseDatabaseDataHelper
{
	[SugarColumn(IsJson = true)]
	public Dictionary<int, Dictionary<int, RaidRecord>> RaidRecordDatas { get; set; } = new Dictionary<int, Dictionary<int, RaidRecord>>();

	[SugarColumn(IsJson = true)]
	[Obsolete("Using RaidRecordDatas")]
	public Dictionary<int, RaidRecord> RaidRecordData { get; set; } = new Dictionary<int, RaidRecord>();

	public int CurRaidId { get; set; }

	public int CurRaidWorldLevel { get; set; }
}
