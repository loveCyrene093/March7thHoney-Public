namespace March7thHoney.Internationalization.Message;

public class AvatarTextCHT
{
	public string Desc => "設定玩家已有角色的屬性\n設置行跡等級時，設置X級即設置所有行跡節點至X級，若大於此節點允許的最高等級，設置為最高等級\n注意：-1意為所有已擁有角色";

	public string Usage => "用法：/avatar talent [角色ID/-1] [行跡等級]\n\n用法：/avatar get [角色ID]\n\n用法：/avatar rank [角色ID/-1] [星魂]\n\n用法：/avatar level [角色ID/-1] [角色等級]";

	public string InvalidLevel => "{0}等級無效";

	public string AllAvatarsLevelSet => "已將全部角色 {0}等級設置為 {1}";

	public string AvatarLevelSet => "已將 {0} 角色 {1}等級設置為 {2}";

	public string AvatarNotFound => "角色不存在!";

	public string AvatarGet => "獲取到角色 {0}!";

	public string AvatarFailedGet => "獲取角色 {0} 失敗!";
}
