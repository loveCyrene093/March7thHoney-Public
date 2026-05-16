using March7thHoney.Data;
using March7thHoney.Data.Config;
using March7thHoney.Data.Excel;
using March7thHoney.GameServer.Game.Player;

namespace March7thHoney.GameServer.Game.Task;

public class PerformanceTrigger
{
	public PlayerInstance Player { get; }

	public PerformanceTrigger(PlayerInstance player)
	{
		Player = player;
		base._002Ector();
	}

	public void TriggerPerformanceE(int performanceEId, SubMissionData subMission)
	{
		GameData.PerformanceEData.TryGetValue(performanceEId, out PerformanceEExcel value);
		if (value != null)
		{
			TriggerPerformanceE(value, subMission);
		}
	}

	public void TriggerPerformanceE(PerformanceEExcel excel, SubMissionData subMission)
	{
		if (excel.ActInfo == null)
		{
			return;
		}
		foreach (LevelInitSequeceConfigInfo item in excel.ActInfo.OnInitSequece)
		{
			Player.TaskManager?.LevelTask.TriggerInitAct(item, subMission);
		}
		foreach (LevelStartSequeceConfigInfo item2 in excel.ActInfo.OnStartSequece)
		{
			Player.TaskManager?.LevelTask.TriggerStartAct(item2, subMission);
		}
	}

	public void TriggerPerformanceD(int performanceDId, SubMissionData subMission)
	{
		GameData.PerformanceDData.TryGetValue(performanceDId, out PerformanceDExcel value);
		if (value != null)
		{
			TriggerPerformanceD(value, subMission);
		}
	}

	public void TriggerPerformanceD(PerformanceDExcel excel, SubMissionData subMission)
	{
		if (excel.ActInfo == null)
		{
			return;
		}
		foreach (LevelInitSequeceConfigInfo item in excel.ActInfo.OnInitSequece)
		{
			Player.TaskManager?.LevelTask.TriggerInitAct(item, subMission);
		}
		foreach (LevelStartSequeceConfigInfo item2 in excel.ActInfo.OnStartSequece)
		{
			Player.TaskManager?.LevelTask.TriggerStartAct(item2, subMission);
		}
	}
}
