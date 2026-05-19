namespace March7thHoney.Internationalization.Message;

public class GridTextCHS
{
	public string Desc => "管理货币战争内容，注意，此部分内容尚未完善，若有问题请及时反馈。\n此命令不一定会检查ID是否存在，若无效果，请检查参数是否正确";

	public string Usage => "用法：/grid gold [金币数量]\n\n用法：/grid role [角色ID] [角色星级]\n\n用法：/grid equip [装备ID]\n\n用法：/grid consumable [消耗品ID]\n\n用法：/grid orb [晶矿ID]\n\n用法：/grid section [章节ID] [关卡ID]";

	public string NotInGame => "不在货币战争中！";

	public string InvalidRole => "角色ID或星级不存在！";

	public string InvalidEquipment => "装备ID不存在！";

	public string InvalidOrb => "晶矿ID不存在！";

	public string InvalidConsumable => "消耗品ID不存在！";

	public string AddedRole => "已添加角色。";

	public string UpdateGold => "获得 {0} 个金币。";

	public string AddEquipment => "已添加 {0} 装备。";

	public string AddOrb => "已添加 {0} 晶矿。";

	public string AddConsumable => "已添加 {0} 消耗品。";

	public string EnterSection => "进入 {0}-{1}。";
}
