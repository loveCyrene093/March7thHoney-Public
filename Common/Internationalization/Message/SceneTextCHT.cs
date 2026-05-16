namespace March7thHoney.Internationalization.Message;

public class SceneTextCHT
{
	public string Desc => "管理玩家場景\n提示：此組大多為調試使用，使用命令前，請確保你清楚你在做什麼！\n使用 prop 來設置道具狀態，在Common/Enums/Scene/PropStateEnum.cs獲取狀態列表\n使用 unlockall 來解鎖場景內所有道具（即將所有能設置為open狀態的道具設置為open狀態），此命令有較大可能會導致遊戲加載卡條約90%，使用 /scene reset <floorId> 來解決問題\n使用 change 來進入指定場景，要獲取EntryId，請訪問 Resources/MapEntrance.json\n使用 reload 來重新加載當前場景，並回到初始位置\n使用 reset 來重置指定場景所有道具狀態，要獲取當前FloorId，請使用 /scene cur";

	public string Usage => "用法：/scene prop [組ID] [道具ID] [狀態]\n\n用法：/scene remove [實體ID]\n\n用法：/scene unlockall\n\n用法：/scene change [entryId]\n\n用法：/scene reload\n\n用法：/scene reset <floorId>";

	public string LoadedGroups => "已加載組: {0}";

	public string PropStateChanged => "道具: {0} 的狀態已設置為 {1}";

	public string PropNotFound => "未找到道具!";

	public string EntityRemoved => "實體 {0} 已被移除";

	public string EntityNotFound => "未找到實體!";

	public string AllPropsUnlocked => "所有道具已解鎖!";

	public string SceneChanged => "已進入場景 {0}";

	public string SceneReloaded => "場景已重新加載!";

	public string SceneReset => "已重置場景 {0} 中所有道具狀態！";

	public string CurrentScene => "當前場景Entry Id: {0}, Plane Id: {1}, Floor Id: {2}";
}
