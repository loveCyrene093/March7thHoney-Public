using System.Collections.Generic;

namespace March7thHoney.Database.Avatar;

public class EnhanceInfo
{
	public int EnhanceId { get; set; }

	public Dictionary<int, int> SkillTree { get; set; }

	public EnhanceInfo(int enhanceId)
	{
		EnhanceId = enhanceId;
		SkillTree = new Dictionary<int, int>();
		base._002Ector();
	}
}
