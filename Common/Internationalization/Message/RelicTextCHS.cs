namespace March7thHoney.Internationalization.Message;

public class RelicTextCHS
{
	public string Desc => "管理玩家的遗器\n主词条可选，副词条可选，但至少存在其中之一\n等级限制：1≤等级≤9999";

	public string Usage => "用法：/relic <遗器ID> <主词条ID> <小词条ID1:小词条等级> <小词条ID2:小词条等级> <小词条ID3:小词条等级> <小词条ID4:小词条等级> l<等级> x<数量>";

	public string RelicNotFound => "遗器不存在!";

	public string InvalidMainAffixId => "主词条ID无效";

	public string InvalidSubAffixId => "副词条ID无效";

	public string RelicGiven => "给予玩家 @{0} {1} 个遗器 {2}, 主词条 {3}";
}
