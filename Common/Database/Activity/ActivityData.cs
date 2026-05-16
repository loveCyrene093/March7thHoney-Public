using SqlSugar;

namespace March7thHoney.Database.Activity;

[SugarTable("Activity")]
public class ActivityData : BaseDatabaseDataHelper
{
	[SugarColumn(IsJson = true)]
	public TrialActivityData TrialActivityData { get; set; } = new TrialActivityData();
}
