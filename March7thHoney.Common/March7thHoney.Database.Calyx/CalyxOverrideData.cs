using March7thHoney.Data.Freesr;
using SqlSugar;

namespace March7thHoney.Database.Calyx;

[SugarTable("calyx_override_data")]
public class CalyxOverrideData : BaseDatabaseDataHelper
{
	public bool IsActive { get; set; }

	public string SourceFileName { get; set; } = "";

	public string SourcePath { get; set; } = "";

	public long LoadedAtUnix { get; set; }

	[SugarColumn(IsJson = true, IsNullable = true)]
	public FreesrCalyxData? CachedJson { get; set; }
}
