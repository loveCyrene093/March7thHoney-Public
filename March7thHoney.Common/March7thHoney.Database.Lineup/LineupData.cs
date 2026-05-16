using System.Collections.Generic;
using SqlSugar;

namespace March7thHoney.Database.Lineup;

[SugarTable("Lineup")]
public class LineupData : BaseDatabaseDataHelper
{
	public int CurLineup { get; set; }

	public int CurExtraLineup { get; set; } = -1;

	[SugarColumn(IsIgnore = true)]
	public int ExtraMpCount { get; set; }

	[SugarColumn(IsJson = true)]
	public Dictionary<int, LineupInfo> Lineups { get; set; } = new Dictionary<int, LineupInfo>();

	public int GetCurLineupIndex()
	{
		if (CurExtraLineup != -1)
		{
			return CurExtraLineup;
		}
		return CurLineup;
	}
}
