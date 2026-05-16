using System.Collections.Generic;
using SqlSugar;

namespace March7thHoney.Database.Message;

[SugarTable("Message")]
public class MessageData : BaseDatabaseDataHelper
{
	[SugarColumn(IsJson = true)]
	public Dictionary<int, MessageGroupData> Groups { get; set; } = new Dictionary<int, MessageGroupData>();
}
