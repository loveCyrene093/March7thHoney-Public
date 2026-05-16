using System.Collections.Generic;

namespace March7thHoney.Data.Excel;

[ResourceEntity("StoryLineFloorData.json")]
public class StoryLineFloorDataExcel : ExcelResource
{
	public int FloorID { get; set; }

	public int StoryLineID { get; set; }

	public int DimensionID { get; set; }

	public override int GetId()
	{
		return FloorID;
	}

	public override void Loaded()
	{
		GameData.StoryLineFloorDataData.TryGetValue(StoryLineID, out Dictionary<int, StoryLineFloorDataExcel> value);
		if (value == null)
		{
			value = new Dictionary<int, StoryLineFloorDataExcel>();
			GameData.StoryLineFloorDataData.Add(StoryLineID, value);
		}
		value.Add(FloorID, this);
	}
}
