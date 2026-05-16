using System.Collections.Generic;
using SqlSugar;

namespace March7thHoney.Database.Quests;

[SugarTable("quest_data")]
public class QuestData : BaseDatabaseDataHelper
{
	[SugarColumn(IsJson = true, ColumnDataType = "MEDIUMTEXT")]
	public Dictionary<int, QuestInfo> Quests { get; set; } = new Dictionary<int, QuestInfo>();
}
