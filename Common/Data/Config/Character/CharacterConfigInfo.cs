using System.Collections.Generic;

namespace March7thHoney.Data.Config.Character;

public class CharacterConfigInfo
{
	public List<SkillConfigInfo> SkillList { get; set; } = new List<SkillConfigInfo>();

	public List<string> AbilityList { get; set; } = new List<string>();
}
