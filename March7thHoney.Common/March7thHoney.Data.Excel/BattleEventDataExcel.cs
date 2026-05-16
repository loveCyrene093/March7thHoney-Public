using System.CodeDom.Compiler;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;

namespace March7thHoney.Data.Excel;

[ResourceEntity("BattleEventData.json")]
public class BattleEventDataExcel : ExcelResource
{
	public int BattleEventID { get; set; }

	public string Config { get; set; } = "";

	[GeneratedRegex("(?<=Avatar_RogueBattleevent)(.*?)(?=_Config.json)")]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "10.0.14.23019")]
	private static Regex RegexConfig()
	{
		return _003CRegexGenerator_g_003EF7291FEED6CBA9DAB563F4FB56E8DA346D7203BA81A401B837344FB9BC7068CC1__RegexConfig_0.Instance;
	}

	public override int GetId()
	{
		return BattleEventID;
	}

	public override void Loaded()
	{
		Match match = RegexConfig().Match(Config);
		if (match.Success && int.TryParse(match.Value, out var result))
		{
			GameData.RogueBattleEventData.TryAdd(result, this);
		}
	}
}
