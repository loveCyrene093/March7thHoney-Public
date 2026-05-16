using System.Collections.Generic;
using March7thHoney.Database.Lineup;
using March7thHoney.Util;

namespace March7thHoney.Database.Quests;

public class StoryLineInfo
{
	public int StoryLineId { get; set; }

	public int SavedPlaneId { get; set; }

	public int SavedFloorId { get; set; }

	public int SavedEntryId { get; set; }

	public Position SavedPos { get; set; } = new Position();

	public Position SavedRot { get; set; } = new Position();

	public List<LineupAvatarInfo> Lineup { get; set; } = new List<LineupAvatarInfo>();
}
