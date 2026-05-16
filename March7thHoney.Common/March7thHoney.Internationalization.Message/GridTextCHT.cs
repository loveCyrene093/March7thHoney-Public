namespace March7thHoney.Internationalization.Message;

public class GridTextCHT
{
	public string Desc => "管理貨幣戰爭內容，注意，此部分內容尚未完善，若有問題請及時反饋。\n此命令不一定會檢查ID是否存在，若無效果，請檢查參數是否正確";

	public string Usage => "用法：/grid gold [金幣數量]\n\n用法：/grid role [角色ID] [角色星級]\n\n用法：/grid equip [裝備ID]\n\n用法：/grid consumable [消耗品ID]\n\n用法：/grid orb [晶礦ID]";

	public string NotInGame => "不在貨幣戰爭中！";

	public string InvalidRole => "角色ID或星級不存在！";

	public string AddedRole => "已添加角色。";

	public string UpdateGold => "獲得 {0} 個金幣。";

	public string AddEquipment => "已添加 {0} 裝備。";

	public string AddOrb => "已添加 {0} 晶礦。";

	public string AddConsumable => "已添加 {0} 消耗品。";

	public string EnterSection => "進入 {0}-{1}。";
}
