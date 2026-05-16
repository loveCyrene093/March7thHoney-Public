using System.Collections.Generic;
using March7thHoney.Enums.Quest;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Excel;

[ResourceEntity("QuestData.json")]
public class QuestDataExcel : ExcelResource
{
	public int QuestID { get; set; }

	public int QuestType { get; set; }

	public HashName QuestTitle { get; set; } = new HashName();

	public int RewardID { get; set; }

	public int FinishWayID { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public QuestUnlockTypeEnum UnlockType { get; set; }

	public List<int> UnlockParamList { get; set; } = new List<int>();

	public override int GetId()
	{
		return QuestID;
	}

	public override void Loaded()
	{
		GameData.QuestDataData.Add(QuestID, this);
	}
}
