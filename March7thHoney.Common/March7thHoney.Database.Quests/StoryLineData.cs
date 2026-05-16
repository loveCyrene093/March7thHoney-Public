using System.Collections.Generic;
using March7thHoney.Util;
using SqlSugar;

namespace March7thHoney.Database.Quests;

[SugarTable("StoryLineData")]
public class StoryLineData : BaseDatabaseDataHelper
{
	public int CurStoryLineId { get; set; }

	public int OldPlaneId { get; set; }

	public int OldFloorId { get; set; }

	public int OldEntryId { get; set; }

	[SugarColumn(IsJson = true)]
	public Position OldPos { get; set; } = new Position();

	[SugarColumn(IsJson = true)]
	public Position OldRot { get; set; } = new Position();

	[SugarColumn(IsJson = true)]
	public Dictionary<int, StoryLineInfo> RunningStoryLines { get; set; } = new Dictionary<int, StoryLineInfo>();
}
