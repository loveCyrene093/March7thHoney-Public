using System.Collections.Generic;
using SqlSugar;

namespace March7thHoney.Database.Player;

[SugarTable("UnlockData")]
public class PlayerUnlockData : BaseDatabaseDataHelper
{
	[SugarColumn(IsJson = true)]
	public List<int> HeadIcons { get; set; } = new List<int>();

	[SugarColumn(IsJson = true)]
	public List<int> ChatBubbles { get; set; } = new List<int>();

	[SugarColumn(IsJson = true)]
	public List<int> PhoneThemes { get; set; } = new List<int>();

	[SugarColumn(IsJson = true)]
	public List<int> PersonalCards { get; set; } = new List<int>();

	[SugarColumn(IsJson = true)]
	public List<int> PhoneCases { get; set; } = new List<int>();

	[SugarColumn(IsJson = true)]
	public Dictionary<int, List<int>> Skins { get; set; } = new Dictionary<int, List<int>>();
}
