using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using March7thHoney.Data.Config.Task;
using March7thHoney.GameServer.Game.Scene;
using March7thHoney.GameServer.Game.Scene.Entity;
using March7thHoney.GameServer.Server.Packet.Send.Lineup;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.Task.AvatarTask;

public class SummonUnitLevelTask
{
	private delegate ValueTask<object?> ExecuteTask(TaskConfigInfo act, List<BaseGameEntity> targetEntities, EntitySummonUnit? summonUnit);

	private readonly ConcurrentDictionary<string, ExecuteTask> _cachedTasks = new ConcurrentDictionary<string, ExecuteTask>();

	public async ValueTask<object?> ByIsContainAdventureModifier(TaskConfigInfo act, List<BaseGameEntity> targetEntities, EntitySummonUnit? summonUnit)
	{
		await ValueTask.CompletedTask;
		return true;
	}

	public void TriggerTasks(List<TaskConfigInfo> tasks, List<BaseGameEntity> targetEntities, EntitySummonUnit? summonUnit)
	{
		foreach (TaskConfigInfo task in tasks)
		{
			TriggerTask(task, targetEntities, summonUnit);
		}
	}

	public void TriggerTask(TaskConfigInfo act, List<BaseGameEntity> targetEntities, EntitySummonUnit? summonUnit)
	{
		try
		{
			string methodName = act.Type.Replace("RPG.GameCore.", "");
			GetOrCreateExecuteTask(methodName)?.Invoke(act, targetEntities, summonUnit);
		}
		catch (Exception e)
		{
			Logger.GetByClassName().Error("An error occured, ", e);
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

	public async ValueTask<object?> PredicateTaskList(TaskConfigInfo act, List<BaseGameEntity> targetEntities, EntitySummonUnit? summonUnit)
	{
		if (act is PredicateTaskList predicateTaskList)
		{
			string methodName = predicateTaskList.Predicate.Type.Replace("RPG.GameCore.", "");
			ExecuteTask orCreateExecuteTask = GetOrCreateExecuteTask(methodName);
			if (orCreateExecuteTask == null)
			{
				return null;
			}
			object obj = await orCreateExecuteTask(predicateTaskList.Predicate, targetEntities, summonUnit);
			if (obj is bool && (bool)obj)
			{
				foreach (TaskConfigInfo successTask in predicateTaskList.SuccessTaskList)
				{
					TriggerTask(successTask, targetEntities, summonUnit);
				}
			}
			else
			{
				foreach (TaskConfigInfo failedTask in predicateTaskList.FailedTaskList)
				{
					TriggerTask(failedTask, targetEntities, summonUnit);
				}
			}
		}
		return null;
	}

	public async ValueTask<object?> AddMazeBuff(TaskConfigInfo act, List<BaseGameEntity> targetEntities, EntitySummonUnit? summonUnit)
	{
		if (!(act is AddMazeBuff { ID: var iD } addMazeBuff))
		{
			return null;
		}
		SceneBuff buff = new SceneBuff(iD, 1, summonUnit?.CreateAvatarId ?? 0)
		{
			SummonUnitEntityId = (summonUnit?.AttachEntityId ?? 0),
			CastEntityId = (summonUnit?.AttachEntityId ?? 0),
			ChangeReason = SceneEntityBuffChangeType.AddMazebuff
		};
		foreach (KeyValuePair<string, DynamicFloat> dynamicValue in addMazeBuff.DynamicValues)
		{
			buff.DynamicValues.Add(dynamicValue.Key, dynamicValue.Value.GetValue());
		}
		foreach (BaseGameEntity targetEntity in targetEntities)
		{
			if (targetEntity is EntityMonster entityMonster)
			{
				await entityMonster.AddBuff(buff);
			}
		}
		return null;
	}

	public async ValueTask<object?> RemoveMazeBuff(TaskConfigInfo act, List<BaseGameEntity> targetEntities, EntitySummonUnit? summonUnit)
	{
		if (!(act is RemoveMazeBuff removeMazeBuff))
		{
			return null;
		}
		foreach (BaseGameEntity targetEntity in targetEntities)
		{
			if (targetEntity is EntityMonster entityMonster)
			{
				await entityMonster.RemoveBuff(removeMazeBuff.ID);
			}
		}
		return null;
	}

	public async ValueTask<object?> RefreshMazeBuffTime(TaskConfigInfo act, List<BaseGameEntity> targetEntities, EntitySummonUnit? summonUnit)
	{
		if (!(act is RefreshMazeBuffTime { ID: var iD } refreshMazeBuffTime))
		{
			return null;
		}
		SceneBuff buff = new SceneBuff(iD, 1, summonUnit?.CreateAvatarId ?? 0)
		{
			SummonUnitEntityId = (summonUnit?.AttachEntityId ?? 0),
			CastEntityId = (summonUnit?.AttachEntityId ?? 0),
			ChangeReason = SceneEntityBuffChangeType.AddMazebuff,
			Duration = ((refreshMazeBuffTime.LifeTime.GetValue() == 0) ? (-1) : refreshMazeBuffTime.LifeTime.GetValue())
		};
		foreach (BaseGameEntity targetEntity in targetEntities)
		{
			if (targetEntity is EntityMonster entityMonster)
			{
				await entityMonster.AddBuff(buff);
			}
		}
		return null;
	}

	public async ValueTask<object?> TriggerHitProp(TaskConfigInfo act, List<BaseGameEntity> targetEntities, EntitySummonUnit? summonUnit)
	{
		foreach (BaseGameEntity targetEntity in targetEntities)
		{
			if (targetEntity is EntityProp prop)
			{
				await prop.Scene.RemoveEntity(prop);
				if (prop.Excel.IsMpRecover)
				{
					await prop.Scene.Player.LineupManager.GainMp(2, sendPacket: true, SyncLineupReason.SyncReasonMpAddPropHit);
				}
				else if (prop.Excel.IsHpRecover)
				{
					prop.Scene.Player.LineupManager.GetCurLineup().Heal(2000, allowRevive: false);
					await prop.Scene.Player.SendPacket(new PacketSyncLineupNotify(prop.Scene.Player.LineupManager.GetCurLineup()));
				}
				else
				{
					prop.Scene.Player.InventoryManager.HandlePlaneEvent(prop.PropInfo.EventID);
				}
			}
		}
		return null;
	}
}
