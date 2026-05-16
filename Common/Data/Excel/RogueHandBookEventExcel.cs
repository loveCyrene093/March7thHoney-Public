using System.Collections.Generic;

namespace March7thHoney.Data.Excel;

[ResourceEntity("RogueHandBookEvent.json")]
public class RogueHandBookEventExcel : ExcelResource
{
	public int EventHandbookID { get; set; }

	public HashName EventTitle { get; set; } = new HashName();

	public int EventReward { get; set; }

	public List<int> EventTypeList { get; set; } = new List<int>();

	public override int GetId()
	{
		return EventHandbookID;
	}

	public override void Loaded()
	{
		GameData.RogueHandBookEventData.Add(GetId(), this);
	}
}
