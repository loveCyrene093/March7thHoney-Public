using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using March7thHoney.Data.Config;
using March7thHoney.Data.Config.Scene;
using March7thHoney.Data.Config.Task;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Lineup;
using March7thHoney.Enums.Mission;
using March7thHoney.Enums.Scene;
using March7thHoney.Enums.Task;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Game.Scene.Entity;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.Task;

public class LevelTask
{
	private delegate ValueTask<object?> ExecuteTask(TaskConfigInfo act, SubMissionData subMission, GroupInfo? group = null);

	private readonly ConcurrentDictionary<string, ExecuteTask> _cachedTasks;

	public PlayerInstance Player { get; }

	public LevelTask(PlayerInstance player)
	{
		Player = player;
		_cachedTasks = new ConcurrentDictionary<string, ExecuteTask>();
		base._002Ector();
	}

	public async ValueTask<object?> TargetFetchAdvPropEx(TargetEvaluator act, SubMissionData subMission, GroupInfo? group = null)
	{
		await ValueTask.CompletedTask;
		if (act is TargetFetchAdvPropEx targetFetchAdvPropEx)
		{
			if (targetFetchAdvPropEx.FetchType != TargetFetchAdvPropFetchTypeEnum.SinglePropByPropID)
			{
				return null;
			}
			foreach (BaseGameEntity item in Player.SceneInstance?.Entities.Values.ToList() ?? new List<BaseGameEntity>())
			{
				if (item is EntityProp entityProp && entityProp.GroupId == targetFetchAdvPropEx.SinglePropID.GroupID.GetValue() && entityProp.InstId == targetFetchAdvPropEx.SinglePropID.ID.GetValue())
				{
					return entityProp;
				}
			}
		}
		return null;
	}

	public void TriggerInitAct(LevelInitSequeceConfigInfo act, SubMissionData subMission, GroupInfo? group = null)
	{
		foreach (TaskConfigInfo task in act.TaskList)
		{
			TriggerTask(task, subMission, group);
		}
	}

	public void TriggerStartAct(LevelStartSequeceConfigInfo act, SubMissionData subMission, GroupInfo? group = null)
	{
		foreach (TaskConfigInfo task in act.TaskList)
		{
			TriggerTask(task, subMission, group);
		}
	}

	private void TriggerTask(TaskConfigInfo act, SubMissionData subMission, GroupInfo? group = null)
	{
		try
		{
			string methodName = act.Type.Replace("RPG.GameCore.", "");
			GetOrCreateExecuteTask(methodName)?.Invoke(act, subMission, group);
		}
		catch
		{
		}
	}

	private ExecuteTask? GetOrCreateExecuteTask(string methodName)
	{
		if (_cachedTasks.TryGetValue(methodName, out ExecuteTask value))
		{
			return value;
		}
		MethodInfo method = GetType().GetMethod(methodName);
		if (method == null)
		{
			return null;
		}
		value = (ExecuteTask)Delegate.CreateDelegate(typeof(ExecuteTask), this, method);
		_cachedTasks[methodName] = value;
		return value;
	}

	public async ValueTask<object?> PlayMessage(TaskConfigInfo act, SubMissionData subMission, GroupInfo? group = null)
	{
		if (act is PlayMessage playMessage)
		{
			await Player.MessageManager.AddMessageSection(playMessage.MessageSectionID);
		}
		return null;
	}

	public async ValueTask<object?> DestroyProp(TaskConfigInfo act, SubMissionData subMission, GroupInfo? group = null)
	{
		if (act is DestroyProp destroyProp)
		{
			foreach (BaseGameEntity value in Player.SceneInstance.Entities.Values)
			{
				if (value is EntityProp entityProp && entityProp.GroupId == destroyProp.GroupID.GetValue() && entityProp.InstId == destroyProp.ID.GetValue())
				{
					await Player.SceneInstance.RemoveEntity(value);
				}
			}
		}
		return null;
	}

	public async ValueTask<object?> TriggerCustomString(TaskConfigInfo act, SubMissionData subMission, GroupInfo? group = null)
	{
		if (act is TriggerCustomString triggerCustomString)
		{
			foreach (KeyValuePair<int, GroupInfo> groupInfo in Player.SceneInstance?.FloorInfo?.Groups ?? new ConcurrentDictionary<int, GroupInfo>())
			{
				if (!groupInfo.Value.PropTriggerCustomString.TryGetValue(triggerCustomString.CustomString.Value, out List<int> value))
				{
					continue;
				}
				foreach (int id in value)
				{
					foreach (BaseGameEntity item in Player.SceneInstance?.Entities.Values.ToList() ?? new List<BaseGameEntity>())
					{
						if (item is EntityProp entityProp && entityProp.GroupId == groupInfo.Key && entityProp.InstId == id)
						{
							await entityProp.SetState(PropStateEnum.Closed);
						}
					}
				}
			}
			await Player.MissionManager.HandleFinishType(MissionFinishTypeEnum.PropState);
		}
		return null;
	}

	public async ValueTask<object?> EnterMap(TaskConfigInfo act, SubMissionData subMission, GroupInfo? group = null)
	{
		if (act is EnterMap enterMap)
		{
			await Player.EnterSceneByEntranceId(enterMap.EntranceID, enterMap.GroupID, enterMap.AnchorID, sendPacket: true);
		}
		return null;
	}

	public async ValueTask<object?> EnterMapByCondition(TaskConfigInfo act, SubMissionData subMission, GroupInfo? group = null)
	{
		if (act is EnterMapByCondition enterMapByCondition)
		{
			await Player.EnterSceneByEntranceId(enterMapByCondition.EntranceID.GetValue(), 0, 0, sendPacket: true);
		}
		return null;
	}

	public async ValueTask<object?> TriggerPerformance(TaskConfigInfo act, SubMissionData subMission, GroupInfo? group = null)
	{
		if (act is TriggerPerformance triggerPerformance)
		{
			if (triggerPerformance.PerformanceType == ELevelPerformanceTypeEnum.E)
			{
				Player.TaskManager?.PerformanceTrigger.TriggerPerformanceE(triggerPerformance.PerformanceID, subMission);
			}
			else if (triggerPerformance.PerformanceType == ELevelPerformanceTypeEnum.D)
			{
				Player.TaskManager?.PerformanceTrigger.TriggerPerformanceD(triggerPerformance.PerformanceID, subMission);
			}
		}
		await ValueTask.CompletedTask;
		return null;
	}

	public async ValueTask<object?> PredicateTaskList(TaskConfigInfo act, SubMissionData subMission, GroupInfo? group = null)
	{
		if (act is PredicateTaskList predicateTaskList)
		{
			string methodName = predicateTaskList.Predicate.Type.Replace("RPG.GameCore.", "");
			ExecuteTask orCreateExecuteTask = GetOrCreateExecuteTask(methodName);
			if (orCreateExecuteTask == null)
			{
				return null;
			}
			object obj = await orCreateExecuteTask(predicateTaskList.Predicate, subMission, group);
			if (obj is bool && (bool)obj)
			{
				foreach (TaskConfigInfo successTask in predicateTaskList.SuccessTaskList)
				{
					TriggerTask(successTask, subMission, group);
				}
			}
			else
			{
				foreach (TaskConfigInfo failedTask in predicateTaskList.FailedTaskList)
				{
					TriggerTask(failedTask, subMission, group);
				}
			}
		}
		return null;
	}

	public async ValueTask<object?> ChangePropState(TaskConfigInfo act, SubMissionData subMission, GroupInfo? group = null)
	{
		SubMissionInfo? subMissionInfo = subMission.SubMissionInfo;
		if (subMissionInfo == null || subMissionInfo.FinishType != MissionFinishTypeEnum.PropState)
		{
			return null;
		}
		foreach (BaseGameEntity value in Player.SceneInstance.Entities.Values)
		{
			if (!(value is EntityProp prop) || prop.GroupId != subMission.SubMissionInfo.ParamInt1 || prop.InstId != subMission.SubMissionInfo.ParamInt2)
			{
				continue;
			}
			try
			{
				if (prop.Excel.PropStateList.Contains(PropStateEnum.Closed))
				{
					await prop.SetState(PropStateEnum.Closed);
					continue;
				}
				await prop.SetState(prop.Excel.PropStateList[prop.Excel.PropStateList.IndexOf(prop.State) + 1]);
				foreach (KeyValuePair<int, List<int>> id in prop.PropInfo.UnlockControllerID)
				{
					foreach (BaseGameEntity value2 in Player.SceneInstance.Entities.Values)
					{
						if (value2 is EntityProp entityProp && entityProp.GroupId == id.Key && id.Value.Contains(entityProp.InstId))
						{
							await entityProp.SetState(PropStateEnum.Closed);
						}
					}
				}
			}
			catch
			{
			}
		}
		return null;
	}

	public async ValueTask<object?> CreateTrialPlayer(TaskConfigInfo act, SubMissionData subMission, GroupInfo? group = null)
	{
		SubMissionInfo? subMissionInfo = subMission.SubMissionInfo;
		if (subMissionInfo != null && subMissionInfo.FinishType == MissionFinishTypeEnum.GetTrialAvatar)
		{
			await Player.LineupManager.AddAvatarToCurTeam(subMission.SubMissionInfo.ParamInt1);
		}
		SubMissionInfo? subMissionInfo2 = subMission.SubMissionInfo;
		if (subMissionInfo2 != null && subMissionInfo2.FinishType == MissionFinishTypeEnum.GetTrialAvatarList)
		{
			subMission.SubMissionInfo.ParamIntList?.ForEach(async delegate(int x)
			{
				await Player.LineupManager.AddAvatarToCurTeam(x);
			});
		}
		return null;
	}

	public async ValueTask<object?> ReplaceTrialPlayer(TaskConfigInfo act, SubMissionData subMission, GroupInfo? group = null)
	{
		SubMissionInfo? subMissionInfo = subMission.SubMissionInfo;
		if (subMissionInfo != null && subMissionInfo.FinishType == MissionFinishTypeEnum.GetTrialAvatar)
		{
			(Player.LineupManager.GetCurLineup()?.BaseAvatars?.ToList() ?? new List<LineupAvatarInfo>()).ForEach(async delegate(LineupAvatarInfo x)
			{
				await Player.LineupManager.RemoveAvatarFromCurTeam(x.BaseAvatarId, sendPacket: false);
			});
			await Player.LineupManager.AddAvatarToCurTeam(subMission.SubMissionInfo.ParamInt1);
		}
		SubMissionInfo? subMissionInfo2 = subMission.SubMissionInfo;
		if (subMissionInfo2 != null && subMissionInfo2.FinishType == MissionFinishTypeEnum.GetTrialAvatarList)
		{
			(Player.LineupManager.GetCurLineup()?.BaseAvatars?.ToList() ?? new List<LineupAvatarInfo>()).ForEach(async delegate(LineupAvatarInfo x)
			{
				await Player.LineupManager.RemoveAvatarFromCurTeam(x.BaseAvatarId, sendPacket: false);
			});
			subMission.SubMissionInfo.ParamIntList?.ForEach(async delegate(int x)
			{
				await Player.LineupManager.AddAvatarToCurTeam(x);
			});
		}
		return null;
	}

	public async ValueTask<object?> StoryLineReplaceTrialPlayer(TaskConfigInfo act, SubMissionData subMission, GroupInfo? group = null)
	{
		SubMissionInfo? subMissionInfo = subMission.SubMissionInfo;
		if (subMissionInfo != null && subMissionInfo.FinishType == MissionFinishTypeEnum.StoryLineAddTrialAvatar)
		{
			(Player.LineupManager.GetCurLineup()?.BaseAvatars?.ToList() ?? new List<LineupAvatarInfo>()).ForEach(async delegate(LineupAvatarInfo x)
			{
				await Player.LineupManager.RemoveAvatarFromCurTeam(x.BaseAvatarId, sendPacket: false);
			});
			await Player.LineupManager.AddAvatarToCurTeam(subMission.SubMissionInfo.ParamInt1);
		}
		return null;
	}

	public async ValueTask<object?> ReplaceVirtualTeam(TaskConfigInfo act, SubMissionData subMission, GroupInfo? group = null)
	{
		March7thHoney.Database.Lineup.LineupInfo? curLineup = Player.LineupManager.GetCurLineup();
		if (curLineup == null || !curLineup.IsExtraLineup())
		{
			return null;
		}
		SubMissionInfo? subMissionInfo = subMission.SubMissionInfo;
		if (subMissionInfo != null && subMissionInfo.FinishType == MissionFinishTypeEnum.GetTrialAvatar)
		{
			(Player.LineupManager.GetCurLineup()?.BaseAvatars?.ToList() ?? new List<LineupAvatarInfo>()).ForEach(async delegate(LineupAvatarInfo x)
			{
				await Player.LineupManager.RemoveAvatarFromCurTeam(x.BaseAvatarId, sendPacket: false);
			});
			await Player.LineupManager.AddAvatarToCurTeam(subMission.SubMissionInfo.ParamInt1);
		}
		SubMissionInfo? subMissionInfo2 = subMission.SubMissionInfo;
		if (subMissionInfo2 != null && subMissionInfo2.FinishType == MissionFinishTypeEnum.GetTrialAvatarList)
		{
			(Player.LineupManager.GetCurLineup()?.BaseAvatars?.ToList() ?? new List<LineupAvatarInfo>()).ForEach(async delegate(LineupAvatarInfo x)
			{
				await Player.LineupManager.RemoveAvatarFromCurTeam(x.BaseAvatarId, sendPacket: false);
			});
			subMission.SubMissionInfo.ParamIntList?.ForEach(async delegate(int x)
			{
				await Player.LineupManager.AddAvatarToCurTeam(x);
			});
		}
		return null;
	}

	public async ValueTask<object?> CreateHeroTrialPlayer(TaskConfigInfo act, SubMissionData subMission, GroupInfo? group = null)
	{
		SubMissionInfo? subMissionInfo = subMission.SubMissionInfo;
		if (subMissionInfo != null && subMissionInfo.FinishType == MissionFinishTypeEnum.GetTrialAvatar)
		{
			await Player.LineupManager.AddAvatarToCurTeam(subMission.SubMissionInfo.ParamInt1);
		}
		SubMissionInfo? subMissionInfo2 = subMission.SubMissionInfo;
		if (subMissionInfo2 != null && subMissionInfo2.FinishType == MissionFinishTypeEnum.GetTrialAvatarList)
		{
			List<int> list = (subMission.SubMissionInfo.ParamIntList ?? new List<int>()).ToList();
			if (list.Count > 0)
			{
				if (Player.Data.CurrentGender == Gender.Man)
				{
					foreach (int item in subMission.SubMissionInfo?.ParamIntList ?? new List<int>())
					{
						if (item > 10000 && (item.ToString().EndsWith("8002") || item.ToString().EndsWith("8004") || item.ToString().EndsWith("8006")))
						{
							list.Remove(item);
						}
					}
				}
				else
				{
					foreach (int item2 in subMission.SubMissionInfo?.ParamIntList ?? new List<int>())
					{
						if (item2 > 10000 && (item2.ToString().EndsWith("8001") || item2.ToString().EndsWith("8003") || item2.ToString().EndsWith("8005")))
						{
							list.Remove(item2);
						}
					}
				}
			}
			list.ForEach(async delegate(int x)
			{
				await Player.LineupManager.AddAvatarToCurTeam(x);
			});
		}
		return null;
	}

	public async ValueTask<object?> DestroyTrialPlayer(TaskConfigInfo act, SubMissionData subMission, GroupInfo? group = null)
	{
		SubMissionInfo? subMissionInfo = subMission.SubMissionInfo;
		if (subMissionInfo != null && subMissionInfo.FinishType == MissionFinishTypeEnum.DelTrialAvatar)
		{
			await Player.LineupManager.RemoveAvatarFromCurTeam(subMission.SubMissionInfo.ParamInt1);
		}
		return null;
	}

	public async ValueTask<object?> ChangeGroupState(TaskConfigInfo act, SubMissionData subMission, GroupInfo? group = null)
	{
		if (group != null)
		{
			foreach (BaseGameEntity item in Player.SceneInstance?.Entities.Values.ToList() ?? new List<BaseGameEntity>())
			{
				if (item is EntityProp entityProp && entityProp.GroupId == group.Id && entityProp.Excel.PropStateList.Contains(PropStateEnum.Open))
				{
					await entityProp.SetState(PropStateEnum.Open);
				}
			}
		}
		return null;
	}

	public async ValueTask<object?> TriggerEntityServerEvent(TaskConfigInfo act, SubMissionData subMission, GroupInfo? group = null)
	{
		if (group != null)
		{
			foreach (BaseGameEntity item in Player.SceneInstance?.Entities.Values.ToList() ?? new List<BaseGameEntity>())
			{
				if (item is EntityProp entityProp && entityProp.GroupId == group.Id && entityProp.Excel.PropStateList.Contains(PropStateEnum.Open) && (entityProp.State == PropStateEnum.Closed || entityProp.State == PropStateEnum.Locked))
				{
					await entityProp.SetState(PropStateEnum.Open);
				}
			}
		}
		return null;
	}

	public async ValueTask<object?> TriggerEntityEvent(TaskConfigInfo act, SubMissionData subMission, GroupInfo? group = null)
	{
		if (act is TriggerEntityEvent triggerEntityEvent && group != null)
		{
			foreach (BaseGameEntity item in Player.SceneInstance?.Entities.Values.ToList() ?? new List<BaseGameEntity>())
			{
				if (item is EntityProp entityProp && entityProp.GroupId == group.Id && entityProp.InstId == triggerEntityEvent.InstanceID.GetValue() && entityProp.Excel.PropStateList.Contains(PropStateEnum.Closed))
				{
					await entityProp.SetState(PropStateEnum.Closed);
				}
			}
		}
		return null;
	}

	public async ValueTask<object?> PropSetupUITrigger(TaskConfigInfo act, SubMissionData subMission, GroupInfo? group = null)
	{
		if (act is PropSetupUITrigger propSetupUITrigger)
		{
			foreach (TaskConfigInfo item in propSetupUITrigger.ButtonCallback)
			{
				TriggerTask(item, subMission, group);
			}
		}
		await ValueTask.CompletedTask;
		return null;
	}

	public async ValueTask<object?> PropStateExecute(TaskConfigInfo act, SubMissionData subMission, GroupInfo? group = null)
	{
		if (act is PropStateExecute propStateExecute)
		{
			string name = propStateExecute.TargetType.Type.Replace("RPG.GameCore.", "");
			MethodInfo method = GetType().GetMethod(name);
			if (method != null && method.Invoke(this, new object[3] { propStateExecute.TargetType, subMission, group }) is EntityProp entityProp)
			{
				await entityProp.SetState(propStateExecute.State);
			}
		}
		return null;
	}

	public async ValueTask<object?> ByCompareSubMissionState(TaskConfigInfo act, SubMissionData subMission, GroupInfo? group = null)
	{
		await ValueTask.CompletedTask;
		if (act is ByCompareSubMissionState byCompareSubMissionState)
		{
			return Player.MissionManager.GetSubMissionStatus(byCompareSubMissionState.SubMissionID).ToStateEnum() == byCompareSubMissionState.SubMissionState;
		}
		return false;
	}

	public async ValueTask<object?> ByCompareFloorSavedValue(TaskConfigInfo act, SubMissionData subMission, GroupInfo? group = null)
	{
		await ValueTask.CompletedTask;
		if (act is ByCompareFloorSavedValue byCompareFloorSavedValue)
		{
			Dictionary<string, int> valueOrDefault = Player.SceneData.FloorSavedData.GetValueOrDefault(Player.Data.FloorId, new Dictionary<string, int>());
			return byCompareFloorSavedValue.CompareType switch
			{
				CompareTypeEnum.Equal => valueOrDefault.GetValueOrDefault(byCompareFloorSavedValue.Name, 0) == byCompareFloorSavedValue.CompareValue, 
				CompareTypeEnum.Greater => valueOrDefault.GetValueOrDefault(byCompareFloorSavedValue.Name, 0) > byCompareFloorSavedValue.CompareValue, 
				CompareTypeEnum.Less => valueOrDefault.GetValueOrDefault(byCompareFloorSavedValue.Name, 0) < byCompareFloorSavedValue.CompareValue, 
				CompareTypeEnum.GreaterEqual => valueOrDefault.GetValueOrDefault(byCompareFloorSavedValue.Name, 0) >= byCompareFloorSavedValue.CompareValue, 
				CompareTypeEnum.LessEqual => valueOrDefault.GetValueOrDefault(byCompareFloorSavedValue.Name, 0) <= byCompareFloorSavedValue.CompareValue, 
				CompareTypeEnum.NotEqual => valueOrDefault.GetValueOrDefault(byCompareFloorSavedValue.Name, 0) != byCompareFloorSavedValue.CompareValue, 
				_ => false, 
			};
		}
		return false;
	}
}
