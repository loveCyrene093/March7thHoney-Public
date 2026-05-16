using System.Collections.Generic;

namespace March7thHoney.Data.Excel;

[ResourceEntity("RogueNousSubStory.json")]
public class RogueNousSubStoryExcel : ExcelResource
{
	public int StoryID { get; set; }

	public int Layer { get; set; }

	public int MaxNousValue { get; set; }

	public List<int> NextIDList { get; set; } = new List<int>();

	public int RequireArea { get; set; }

	public override int GetId()
	{
		return StoryID;
	}

	public override void Loaded()
	{
		GameData.RogueNousSubStoryData.Add(GetId(), this);
	}
}
