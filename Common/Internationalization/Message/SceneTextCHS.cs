namespace March7thHoney.Internationalization.Message;

public class SceneTextCHS
{
	public string Desc => "管理玩家场景\n提示：此组大多为调试使用，使用命令前，请确保你清楚你在做什么！\n使用 prop 来设置道具状态，在Common/Enums/Scene/PropStateEnum.cs获取状态列表\n使用 unlockall 来解锁场景内所有道具（即将所有能设置为open状态的道具设置为open状态），此命令有较大可能会导致游戏加载卡条约90%，使用 /scene reset <floorId> 来解决问题\n使用 change 来进入指定场景，要获取EntryId，请访问 Resources/MapEntrance.json\n使用 reload 来重新加载当前场景，并回到初始位置\n使用 reset 来重置指定场景所有道具状态，要获取当前FloorId，请使用 /scene cur";

	public string Usage => "用法：/scene prop [组ID] [道具ID] [状态]\n\n用法：/scene remove [实体ID]\n\n用法：/scene unlockall\n\n用法：/scene change [entryId]\n\n用法：/scene reload\n\n用法：/scene reset <floorId>";

	public string LoadedGroups => "已加载组: {0}";

	public string PropStateChanged => "道具: {0} 的状态已设置为 {1}";

	public string PropNotFound => "未找到道具!";

	public string EntityRemoved => "实体 {0} 已被移除";

	public string EntityNotFound => "未找到实体!";

	public string AllPropsUnlocked => "所有道具已解锁!";

	public string SceneChanged => "已进入场景 {0}";

	public string SceneReloaded => "场景已重新加载!";

	public string SceneReset => "已重置场景 {0} 中所有道具状态！";

	public string CurrentScene => "当前场景Entry Id: {0}, Plane Id: {1}, Floor Id: {2}";
}
