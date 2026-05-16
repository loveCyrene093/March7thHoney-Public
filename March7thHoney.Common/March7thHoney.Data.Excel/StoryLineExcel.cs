namespace March7thHoney.Data.Excel;

[ResourceEntity("StoryLine.json")]
public class StoryLineExcel : ExcelResource
{
	public int StoryLineID { get; set; }

	public StoryLineCondition BeginCondition { get; set; } = new StoryLineCondition();

	public StoryLineCondition EndCondition { get; set; } = new StoryLineCondition();

	public int InitEntranceID { get; set; }

	public int InitGroupID { get; set; }

	public int InitAnchorID { get; set; }

	public override int GetId()
	{
		return StoryLineID;
	}

	public override void Loaded()
	{
		GameData.StoryLineData[StoryLineID] = this;
	}
}
