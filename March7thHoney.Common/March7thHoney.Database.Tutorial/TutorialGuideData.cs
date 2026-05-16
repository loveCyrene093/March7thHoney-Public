using System.Collections.Generic;
using March7thHoney.Proto;
using SqlSugar;

namespace March7thHoney.Database.Tutorial;

[SugarTable("TutorialGuide")]
public class TutorialGuideData : BaseDatabaseDataHelper
{
	[SugarColumn(IsJson = true)]
	public Dictionary<int, TutorialStatus> Tutorials { get; set; } = new Dictionary<int, TutorialStatus>();
}
