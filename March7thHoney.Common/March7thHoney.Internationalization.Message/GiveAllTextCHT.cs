namespace March7thHoney.Internationalization.Message;

public class GiveAllTextCHT
{
	public string Desc => "給予玩家全部指定類型的物品\navatar意為角色，equipment意為光錐，relic意為遺器，unlock意為氣泡、手機壁紙、頭像，train意為開拓者房間內容，pet意為寵物，path意為多命途角色命途";

	public string Usage => "用法：/giveall avatar r<星魂> l<等級>\n\n用法：/giveall equipment r<疊影> l<等級> x<數量>\n\n用法：/giveall relic l<等級> x<數量>\n\n用法：/giveall unlock\n\n用法：/giveall train\n\n用法：/giveall pet\n\n用法：/giveall path";

	public string GiveAllItems => "已給予所有 {0}, 各 {1} 個";
}
