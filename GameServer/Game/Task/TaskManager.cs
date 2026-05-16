using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Game.Task.AvatarTask;

namespace March7thHoney.GameServer.Game.Task;

public class TaskManager(PlayerInstance player) : BasePlayerManager(player)
{
	public PerformanceTrigger PerformanceTrigger { get; } = new PerformanceTrigger(player);

	public LevelTask LevelTask { get; } = new LevelTask(player);

	public SummonUnitLevelTask SummonUnitLevelTask { get; } = new SummonUnitLevelTask();

	public AbilityLevelTask AbilityLevelTask { get; } = new AbilityLevelTask(player);

	public MissionTaskTrigger MissionTaskTrigger { get; } = new MissionTaskTrigger(player);

	public SceneTaskTrigger SceneTaskTrigger { get; } = new SceneTaskTrigger(player);
}
