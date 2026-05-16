namespace March7thHoney.Internationalization.Message;

public class RelicTextEN
{
	public string Desc => "Manage player's relics.\nMain stat is optional, sub stats are optional, but at least one must exist.\nLevel restriction: 1 ≤ Level ≤ 9999.";

	public string Usage => "Usage: /relic <RelicID> <MainAffixID> <SubAffixID1:SubAffixLevel> <SubAffixID2:SubAffixLevel> <SubAffixID3:SubAffixLevel> <SubAffixID4:SubAffixLevel> l<Level> x<Count>";

	public string RelicNotFound => "Relic not found!";

	public string InvalidMainAffixId => "Invalid main affix ID";

	public string InvalidSubAffixId => "Invalid sub affix ID";

	public string RelicGiven => "Gave player @{0} {1} relic(s) {2}, main stat {3}";
}
