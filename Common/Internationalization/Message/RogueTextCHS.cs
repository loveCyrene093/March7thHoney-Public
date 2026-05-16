namespace March7thHoney.Internationalization.Message;

public class RogueTextCHS
{
	public string Desc => "管理玩家模拟宇宙中的数据\n-1意为所有祝福（已拥有祝福）\n使用 buff 来获取祝福\n使用 enhance 来强化祝福";

	public string Usage => "用法：/rogue money [宇宙碎片数量]\n\n用法：/rogue buff [祝福ID/-1]\n\n用法：/rogue miracle [奇物ID]\n\n用法：/rogue enhance [祝福ID/-1]\n\n用法：/rogue unstuck - 脱离事件";

	public string PlayerGainedMoney => "玩家已获得 {0} 宇宙碎片";

	public string PlayerGainedAllItems => "玩家已获得所有{0}";

	public string PlayerGainedItem => "玩家已获得{0} {1}";

	public string PlayerEnhancedBuff => "玩家已强化祝福 {0}";

	public string PlayerEnhancedAllBuffs => "玩家已强化所有祝福";

	public string PlayerUnstuck => "玩家已脱离事件";

	public string NotFoundItem => "未找到 {0}!";

	public string PlayerNotInRogue => "玩家不在模拟宇宙中!";
}
