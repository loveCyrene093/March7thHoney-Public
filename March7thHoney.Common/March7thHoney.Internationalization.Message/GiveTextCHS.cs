namespace March7thHoney.Internationalization.Message;

public class GiveTextCHS
{
	public string Desc => "给予玩家物品，此处可输入角色ID，但无法设置行迹、等级及星魂";

	public string Usage => "用法：/give <物品ID> l<等级> x<数量> r<叠影>";

	public string ItemNotFound => "未找到物品!";

	public string GiveItem => "给予 @{0} {1} 个物品 {2}";
}
