namespace March7thHoney.Internationalization.Message;

public class SceneTextEN
{
	public string Desc => "Manage player's scene.\nNote: Most of these are for debugging. Before using commands, ensure you know what you are doing!\nUse prop to set prop state. Get state list from Common/Enums/Scene/PropStateEnum.cs.\nUse unlockall to unlock all props in the scene (set all props that can be set to open state to open). This command may cause the game to load stuck at about 90%. Use /scene reset <floorId> to solve.\nUse change to enter a specific scene. To get EntryId, visit Resources/MapEntrance.json.\nUse reload to reload the current scene and return to the starting position.\nUse reset to reset all prop states in a specified scene. To get current FloorId, use /scene cur.";

	public string Usage => "Usage: /scene prop [GroupID] [PropID] [State]\n\nUsage: /scene remove [EntityID]\n\nUsage: /scene unlockall\n\nUsage: /scene change [entryId]\n\nUsage: /scene reload\n\nUsage: /scene reset <floorId>";

	public string LoadedGroups => "Loaded groups: {0}";

	public string PropStateChanged => "Prop: {0} state set to {1}";

	public string PropNotFound => "Prop not found!";

	public string EntityRemoved => "Entity {0} removed";

	public string EntityNotFound => "Entity not found!";

	public string AllPropsUnlocked => "All props unlocked!";

	public string SceneChanged => "Entered scene {0}";

	public string SceneReloaded => "Scene reloaded!";

	public string SceneReset => "Reset all prop states in scene {0}!";

	public string CurrentScene => "Current scene Entry Id: {0}, Plane Id: {1}, Floor Id: {2}";
}
