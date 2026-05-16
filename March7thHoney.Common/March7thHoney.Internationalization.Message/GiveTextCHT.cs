namespace March7thHoney.Internationalization.Message;

public class GiveTextCHT
{
	public string Desc => "給予玩家物品，此處可輸入角色ID，但無法設置行跡、等級及星魂";

	public string Usage => "用法：/give <物品ID> l<等級> x<數量> r<疊影>";

	public string ItemNotFound => "未找到物品!";

	public string GiveItem => "給予 @{0} {1} 個物品 {2}";
}
