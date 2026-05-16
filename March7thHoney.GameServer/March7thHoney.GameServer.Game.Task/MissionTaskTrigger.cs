using March7thHoney.Data;
using March7thHoney.Data.Config;
using March7thHoney.Data.Excel;
using March7thHoney.GameServer.Game.Player;

namespace March7thHoney.GameServer.Game.Task;

public class MissionTaskTrigger
{
	public PlayerInstance Player { get; }

	public MissionTaskTrigger(PlayerInstance player)
	{
		Player = player;
		base._002Ector();
	}

	public void TriggerMissionTask(int missionId)
	{
		GameData.SubMissionInfoData.TryGetValue(missionId, out SubMissionData value);
		if (value != null)
		{
			TriggerMissionTask(value.SubMissionTaskInfo ?? new LevelGraphConfigInfo(), value);
		}
	}

	public void TriggerMissionTask(LevelGraphConfigInfo subMissionTaskInfo, SubMissionData subMission)
	{
		foreach (LevelInitSequeceConfigInfo item in subMissionTaskInfo.OnInitSequece)
		{
			Player.TaskManager?.LevelTask.TriggerInitAct(item, subMission);
		}
		foreach (LevelStartSequeceConfigInfo item2 in subMissionTaskInfo.OnStartSequece)
		{
			Player.TaskManager?.LevelTask.TriggerStartAct(item2, subMission);
		}
	}
}
