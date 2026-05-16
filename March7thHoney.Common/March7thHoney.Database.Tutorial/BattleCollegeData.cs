using System.Collections.Generic;
using SqlSugar;

namespace March7thHoney.Database.Tutorial;

[SugarTable("battle_college_data")]
public class BattleCollegeData : BaseDatabaseDataHelper
{
	[SugarColumn(IsJson = true)]
	public List<int> FinishedCollegeIdList { get; set; } = new List<int>();
}
