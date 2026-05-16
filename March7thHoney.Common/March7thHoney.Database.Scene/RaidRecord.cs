using System.Collections.Generic;
using March7thHoney.Database.Lineup;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.Database.Scene;

public class RaidRecord
{
	public int RaidId { get; set; }

	public int WorldLevel { get; set; }

	public RaidStatus Status { get; set; }

	public long FinishTimeStamp { get; set; }

	public List<LineupAvatarInfo> Lineup { get; set; } = new List<LineupAvatarInfo>();

	public Position Pos { get; set; } = new Position();

	public Position Rot { get; set; } = new Position();

	public int PlaneId { get; set; }

	public int FloorId { get; set; }

	public int EntryId { get; set; }

	public Position OldPos { get; set; } = new Position();

	public Position OldRot { get; set; } = new Position();

	public int OldEntryId { get; set; }
}
