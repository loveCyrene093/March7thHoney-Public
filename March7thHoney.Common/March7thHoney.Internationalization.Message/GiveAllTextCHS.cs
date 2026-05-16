namespace March7thHoney.Internationalization.Message;

public class GiveAllTextCHS
{
	public string Desc => "给予玩家全部指定类型的物品\navatar意为角色，equipment意为光锥，relic意为遗器，unlock意为气泡、手机壁纸、头像，train意为开拓者房间内容，pet意为宠物，path意为多命途角色命途";

	public string Usage => "用法：/giveall avatar r<星魂> l<等级>\n\n用法：/giveall equipment r<叠影> l<等级> x<数量>\n\n用法：/giveall relic l<等级> x<数量>\n\n用法：/giveall unlock\n\n用法：/giveall train\n\n用法：/giveall pet\n\n用法：/giveall path";

	public string GiveAllItems => "已给予所有 {0}, 各 {1} 个";
}
