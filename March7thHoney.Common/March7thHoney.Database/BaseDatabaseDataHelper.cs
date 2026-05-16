using SqlSugar;

namespace March7thHoney.Database;

public abstract class BaseDatabaseDataHelper
{
	[SugarColumn(IsPrimaryKey = true)]
	public int Uid { get; set; }
}
