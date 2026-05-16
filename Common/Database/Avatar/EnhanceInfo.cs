using System.Collections.Generic;

namespace March7thHoney.Database.Avatar;

public class EnhanceInfo(int enhanceId)
{
	public int EnhanceId { get; set; } = enhanceId;

	public Dictionary<int, int> SkillTree { get; set; } = new Dictionary<int, int>();
}
