namespace March7thHoney.Internationalization.Message;

public class RelicTextCHT
{
	public string Desc => "管理玩家的遺器\n主詞條可選，副詞條可選，但至少存在其中之一\n等級限制：1≤等級≤9999";

	public string Usage => "用法：/relic <遺器ID> <主詞條ID> <小詞條ID1:小詞條等級> <小詞條ID2:小詞條等級> <小詞條ID3:小詞條等級> <小詞條ID4:小詞條等級> l<等級> x<數量>";

	public string RelicNotFound => "遺器不存在!";

	public string InvalidMainAffixId => "主詞條ID無效";

	public string InvalidSubAffixId => "副詞條ID無效";

	public string RelicGiven => "給予玩家 @{0} {1} 個遺器 {2}, 主詞條 {3}";
}
