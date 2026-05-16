using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Game.Task.AvatarTask;

namespace March7thHoney.GameServer.Game.Task;

public class TaskManager : BasePlayerManager
{
	public PerformanceTrigger PerformanceTrigger { get; }

	public LevelTask LevelTask { get; }

	public SummonUnitLevelTask SummonUnitLevelTask { get; }

	public AbilityLevelTask AbilityLevelTask { get; }

	public MissionTaskTrigger MissionTaskTrigger { get; }

	public SceneTaskTrigger SceneTaskTrigger { get; }

	public TaskManager(PlayerInstance player)
	{
		PerformanceTrigger = new PerformanceTrigger(player);
		LevelTask = new LevelTask(player);
		SummonUnitLevelTask = new SummonUnitLevelTask();
		AbilityLevelTask = new AbilityLevelTask(player);
		MissionTaskTrigger = new MissionTaskTrigger(player);
		SceneTaskTrigger = new SceneTaskTrigger(player);
		base._002Ector(player);
	}
}
