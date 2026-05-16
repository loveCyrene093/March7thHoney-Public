using March7thHoney.Data;
using March7thHoney.Data.Config;
using March7thHoney.Data.Config.Scene;
using March7thHoney.Data.Excel;
using March7thHoney.GameServer.Game.Player;

namespace March7thHoney.GameServer.Game.Task;

public class SceneTaskTrigger
{
	public PlayerInstance Player { get; }

	public SceneTaskTrigger(PlayerInstance player)
	{
		Player = player;
		base._002Ector();
	}

	public void TriggerFloor(int planeId, int floorId)
	{
		GameData.GetFloorInfo(planeId, floorId, out FloorInfo outer);
		if (outer == null)
		{
			return;
		}
		foreach (GroupInfo value in outer.Groups.Values)
		{
			if (value.LevelGraphConfig == null)
			{
				continue;
			}
			foreach (LevelInitSequeceConfigInfo item in value.LevelGraphConfig.OnInitSequece)
			{
				Player.TaskManager?.LevelTask.TriggerInitAct(item, new SubMissionData(0), value);
			}
			foreach (LevelStartSequeceConfigInfo item2 in value.LevelGraphConfig.OnStartSequece)
			{
				Player.TaskManager?.LevelTask.TriggerStartAct(item2, new SubMissionData(0), value);
			}
		}
	}

	public void TriggerGroup(int planeId, int floorId, int groupId)
	{
		GameData.GetFloorInfo(planeId, floorId, out FloorInfo outer);
		if (outer == null || !outer.Groups.TryGetValue(groupId, out GroupInfo value) || value.LevelGraphConfig == null)
		{
			return;
		}
		foreach (LevelInitSequeceConfigInfo item in value.LevelGraphConfig.OnInitSequece)
		{
			Player.TaskManager?.LevelTask.TriggerInitAct(item, new SubMissionData(0), value);
		}
		foreach (LevelStartSequeceConfigInfo item2 in value.LevelGraphConfig.OnStartSequece)
		{
			Player.TaskManager?.LevelTask.TriggerStartAct(item2, new SubMissionData(0), value);
		}
	}
}
