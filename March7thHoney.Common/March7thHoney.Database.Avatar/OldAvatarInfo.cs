using System.Collections.Generic;

namespace March7thHoney.Database.Avatar;

public class OldAvatarInfo
{
	public int AvatarId { get; set; }

	public int PathId { get; set; }

	public int Level { get; set; }

	public int Exp { get; set; }

	public int Promotion { get; set; }

	public int Rewards { get; set; }

	public long Timestamp { get; set; }

	public int CurrentHp { get; set; } = 10000;

	public int CurrentSp { get; set; }

	public int ExtraLineupHp { get; set; } = 10000;

	public int ExtraLineupSp { get; set; }

	public bool IsMarked { get; set; }

	public Dictionary<int, int> SkillTree { get; set; } = new Dictionary<int, int>();

	public Dictionary<int, Dictionary<int, int>> SkillTreeExtra { get; set; } = new Dictionary<int, Dictionary<int, int>>();

	public Dictionary<int, PathInfo> PathInfoes { get; set; } = new Dictionary<int, PathInfo>();
}
