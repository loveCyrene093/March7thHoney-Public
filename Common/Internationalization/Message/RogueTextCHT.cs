namespace March7thHoney.Internationalization.Message;

public class RogueTextCHT
{
	public string Desc => "管理玩家模擬宇宙中的數據\n-1意為所有祝福（已擁有祝福）\n使用 buff 來獲取祝福\n使用 enhance 來強化祝福";

	public string Usage => "用法：/rogue money [宇宙碎片數量]\n\n用法：/rogue buff [祝福ID/-1]\n\n用法：/rogue miracle [奇物ID]\n\n用法：/rogue enhance [祝福ID/-1]\n\n用法：/rogue unstuck - 脫離事件";

	public string PlayerGainedMoney => "玩家已獲得 {0} 宇宙碎片";

	public string PlayerGainedAllItems => "玩家已獲得所有{0}";

	public string PlayerGainedItem => "玩家已獲得{0} {1}";

	public string PlayerEnhancedBuff => "玩家已強化祝福 {0}";

	public string PlayerEnhancedAllBuffs => "玩家已強化所有祝福";

	public string PlayerUnstuck => "玩家已脫離事件";

	public string NotFoundItem => "未找到 {0}!";

	public string PlayerNotInRogue => "玩家不在模擬宇宙中!";
}
