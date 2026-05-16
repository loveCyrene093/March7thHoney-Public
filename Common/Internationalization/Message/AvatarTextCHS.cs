namespace March7thHoney.Internationalization.Message;

public class AvatarTextCHS
{
	public string Desc => "设定玩家已有角色的属性\n设置行迹等级时，设置X级即设置所有行迹节点至X级，若大于此节点允许的最高等级，设置为最高等级\n注意：-1意为所有已拥有角色";

	public string Usage => "用法：/avatar talent [角色ID/-1] [行迹等级]\n\n用法：/avatar get [角色ID]\n\n用法：/avatar rank [角色ID/-1] [星魂]\n\n用法：/avatar level [角色ID/-1] [角色等级]";

	public string InvalidLevel => "{0}等级无效";

	public string AllAvatarsLevelSet => "已将全部角色 {0}等级设置为 {1}";

	public string AvatarLevelSet => "已将 {0} 角色 {1}等级设置为 {2}";

	public string AvatarNotFound => "角色不存在!";

	public string AvatarGet => "获取到角色 {0}!";

	public string AvatarFailedGet => "获取角色 {0} 失败!";
}
