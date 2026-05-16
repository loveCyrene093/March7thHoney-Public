using System.Collections.Generic;
using March7thHoney.Proto;
using SqlSugar;

namespace March7thHoney.Database.Tutorial;

[SugarTable("Tutorial")]
public class TutorialData : BaseDatabaseDataHelper
{
	[SugarColumn(IsJson = true)]
	public Dictionary<int, TutorialStatus> Tutorials { get; set; } = new Dictionary<int, TutorialStatus>();
}
