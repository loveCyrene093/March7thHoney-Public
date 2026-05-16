using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Config;
using March7thHoney.Data.Config.AdventureAbility;
using March7thHoney.Data.Config.SummonUnit;
using March7thHoney.Data.Config.Task;
using March7thHoney.Data.Excel;
using March7thHoney.Enums.Avatar;
using March7thHoney.Enums.Scene;
using March7thHoney.GameServer.Game.Battle;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Game.Scene;
using March7thHoney.GameServer.Game.Scene.Component;
using March7thHoney.GameServer.Game.Scene.Entity;
using March7thHoney.GameServer.Server.Packet.Send.Scene;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.Task.AvatarTask;

public class AbilityLevelTask(PlayerInstance player)
{
	private delegate ValueTask<object> ExecuteTask(AbilityLevelParam param);

	private readonly ConcurrentDictionary<string, ExecuteTask> _cachedTasks = new ConcurrentDictionary<string, ExecuteTask>();

	public PlayerInstance Player { get; set; } = player;

	public async ValueTask<object> TargetAlias(AbilityLevelParam param)
	{
		await ValueTask.CompletedTask;
		TargetEvaluator? targetEvaluator = param.TargetEvaluator;
		BaseGameEntity casterEntity = param.CasterEntity;
		List<BaseGameEntity> targetEntities = param.TargetEntities;
		List<BaseGameEntity> result;
		if (targetEvaluator is TargetAlias targetAlias)
		{
			string alias = targetAlias.Alias;
			if (alias != null)
			{
				int length = alias.Length;
				if (length <= 8)
				{
					if (length != 6)
					{
						if (length == 8 && alias == "AllEnemy")
						{
							goto IL_01b2;
						}
					}
					else if (alias == "Caster")
					{
						goto IL_01a1;
					}
				}
				else if (length != 11)
				{
					if (length == 14)
					{
						char c = alias[3];
						if (c != 'L')
						{
							if (c != 'T' || !(alias == "AdvTeamMembers"))
							{
								goto IL_0214;
							}
							result = Player.SceneInstance.AvatarInfo.Values.ToList().OfType<BaseGameEntity>().ToList();
						}
						else
						{
							if (!(alias == "AdvLocalPlayer"))
							{
								goto IL_0214;
							}
							result = Player.SceneInstance.AvatarInfo.Values.Where((AvatarSceneInfo x) => x.AvatarInfo.BaseAvatarId == Player.LineupManager.GetCurLineup()?.LeaderAvatarId).OfType<BaseGameEntity>().ToList();
						}
						goto IL_0218;
					}
					if (length == 19)
					{
						char c = alias[0];
						if (c != 'A')
						{
							if (c == 'M' && alias == "ModifierOwnerEntity")
							{
								goto IL_01a1;
							}
						}
						else if (alias == "AbilityTargetEntity")
						{
							goto IL_01b2;
						}
					}
				}
				else if (alias == "ParamEntity")
				{
					goto IL_01b2;
				}
			}
			goto IL_0214;
		}
		return new List<BaseGameEntity>();
		IL_01a1:
		result = new List<BaseGameEntity>(1) { casterEntity };
		goto IL_0218;
		IL_01b2:
		result = targetEntities;
		goto IL_0218;
		IL_0214:
		result = targetEntities;
		goto IL_0218;
		IL_0218:
		return result;
	}

	public async ValueTask<AbilityLevelResult> TriggerTasks(AdventureAbilityConfigListInfo abilities, List<TaskConfigInfo> tasks, BaseGameEntity casterEntity, List<BaseGameEntity> targetEntities, SceneCastSkillCsReq req, string? modifierName = null)
	{
		BattleInstance instance = null;
		List<HitMonsterInstance> battleInfos = new List<HitMonsterInstance>();
		foreach (TaskConfigInfo task in tasks)
		{
			try
			{
				AbilityLevelResult abilityLevelResult = await TriggerTask(new AbilityLevelParam(abilities, task, casterEntity, targetEntities, req, modifierName));
				if (abilityLevelResult.BattleInfos != null)
				{
					battleInfos.AddRange(abilityLevelResult.BattleInfos);
				}
				if (abilityLevelResult.Instance != null)
				{
					instance = abilityLevelResult.Instance;
				}
			}
			catch (Exception e)
			{
				Logger.GetByClassName().Error("An error occured, ", e);
			}
		}
		return new AbilityLevelResult(instance, battleInfos);
	}

	public async ValueTask<AbilityLevelResult> TriggerTask(AbilityLevelParam param)
	{
		try
		{
			string methodName = param.Act.Type.Replace("RPG.GameCore.", "");
			ExecuteTask orCreateExecuteTask = GetOrCreateExecuteTask(methodName);
			if (orCreateExecuteTask == null)
			{
				return new AbilityLevelResult();
			}
			if (await orCreateExecuteTask(param) is AbilityLevelResult result)
			{
				return result;
			}
		}
		catch (Exception e)
		{
			Logger.GetByClassName().Error("An error occured, ", e);
		}
		return new AbilityLevelResult();
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

	public async ValueTask<object> PredicateTaskList(AbilityLevelParam param)
	{
		BattleInstance instance = null;
		List<HitMonsterInstance> battleInfos = new List<HitMonsterInstance>();
		TaskConfigInfo act = param.Act;
		if (act is PredicateTaskList predicateTaskList)
		{
			string methodName = predicateTaskList.Predicate.Type.Replace("RPG.GameCore.", "");
			ExecuteTask orCreateExecuteTask = GetOrCreateExecuteTask(methodName);
			bool flag = true;
			if (orCreateExecuteTask != null)
			{
				flag = await orCreateExecuteTask(param with
				{
					Act = predicateTaskList.Predicate
				}) is bool flag2 && (predicateTaskList.Predicate.Inverse ? (!flag2) : flag2);
			}
			if (flag)
			{
				foreach (TaskConfigInfo successTask in predicateTaskList.SuccessTaskList)
				{
					AbilityLevelResult abilityLevelResult = await TriggerTask(param with
					{
						Act = successTask
					});
					if (abilityLevelResult.BattleInfos != null)
					{
						battleInfos.AddRange(abilityLevelResult.BattleInfos);
					}
					if (abilityLevelResult.Instance != null)
					{
						instance = abilityLevelResult.Instance;
					}
				}
			}
			else
			{
				foreach (TaskConfigInfo failedTask in predicateTaskList.FailedTaskList)
				{
					AbilityLevelResult abilityLevelResult2 = await TriggerTask(param with
					{
						Act = failedTask
					});
					if (abilityLevelResult2.BattleInfos != null)
					{
						battleInfos.AddRange(abilityLevelResult2.BattleInfos);
					}
					if (abilityLevelResult2.Instance != null)
					{
						instance = abilityLevelResult2.Instance;
					}
				}
			}
		}
		return new AbilityLevelResult(instance, battleInfos);
	}

	public async ValueTask<object> AdventureTriggerAttack(AbilityLevelParam param)
	{
		BattleInstance instance = null;
		List<HitMonsterInstance> battleInfos = new List<HitMonsterInstance>();
		TaskConfigInfo act = param.Act;
		if (act is AdventureTriggerAttack adventureTriggerAttack)
		{
			List<BaseGameEntity> target;
			if (!string.IsNullOrEmpty(adventureTriggerAttack.AttackTargetType.Type))
			{
				string methodName = adventureTriggerAttack.AttackTargetType.Type.Replace("RPG.GameCore.", "");
				ExecuteTask orCreateExecuteTask = GetOrCreateExecuteTask(methodName);
				if (orCreateExecuteTask == null)
				{
					return new AbilityLevelResult();
				}
				if (!(await orCreateExecuteTask(param with
				{
					TargetEvaluator = adventureTriggerAttack.AttackTargetType
				}) is List<BaseGameEntity> list))
				{
					return new AbilityLevelResult();
				}
				target = list;
			}
			else
			{
				target = param.TargetEntities.ToList();
			}
			foreach (TaskConfigInfo item in adventureTriggerAttack.OnAttack)
			{
				AbilityLevelResult abilityLevelResult = await TriggerTask(param with
				{
					Act = item,
					TargetEntities = target
				});
				if (abilityLevelResult.BattleInfos != null)
				{
					battleInfos.AddRange(abilityLevelResult.BattleInfos);
				}
			}
			bool flag = target.OfType<EntityMonster>().Any((EntityMonster x) => x.IsAlive);
			bool flag2 = adventureTriggerAttack.TriggerBattle || !string.IsNullOrEmpty(adventureTriggerAttack.EnterBattleSelectTargetType) || (param.Request.SkillIndex == 0 && flag);
			if (target.Count > 0 && flag2)
			{
				foreach (TaskConfigInfo item2 in adventureTriggerAttack.OnBattle)
				{
					AbilityLevelResult abilityLevelResult2 = await TriggerTask(param with
					{
						Act = item2,
						TargetEntities = target
					});
					if (abilityLevelResult2.BattleInfos != null)
					{
						battleInfos.AddRange(abilityLevelResult2.BattleInfos);
					}
				}
				foreach (BaseGameEntity item3 in target)
				{
					MonsterBattleType battleType = MonsterBattleType.TriggerBattle;
					if (item3 is EntityMonster { IsAlive: false })
					{
						battleType = MonsterBattleType.DirectDieSkipBattle;
					}
					battleInfos.Add(new HitMonsterInstance(item3.EntityId, battleType));
				}
				instance = await Player.BattleManager.StartBattle(param.CasterEntity, target, param.Request.SkillIndex == 1);
			}
		}
		return new AbilityLevelResult(instance, battleInfos);
	}

	public async ValueTask<object> AddMazeBuff(AbilityLevelParam param)
	{
		BattleInstance instance = null;
		List<HitMonsterInstance> battleInfos = new List<HitMonsterInstance>();
		TaskConfigInfo act = param.Act;
		if (act is AddMazeBuff addMazeBuff)
		{
			string methodName = addMazeBuff.TargetType.Type.Replace("RPG.GameCore.", "");
			ExecuteTask orCreateExecuteTask = GetOrCreateExecuteTask(methodName);
			if (orCreateExecuteTask == null)
			{
				return new AbilityLevelResult();
			}
			object obj = await orCreateExecuteTask(param with
			{
				TargetEvaluator = addMazeBuff.TargetType
			});
			Dictionary<string, float> dynamic = new Dictionary<string, float>();
			foreach (KeyValuePair<string, DynamicFloat> dynamicValue in addMazeBuff.DynamicValues)
			{
				dynamic.Add(dynamicValue.Key, dynamicValue.Value.GetValue());
			}
			if (!(obj is List<BaseGameEntity> list))
			{
				return new AbilityLevelResult(instance, battleInfos);
			}
			int num;
			if (addMazeBuff.LifeTime.FixedValue.Value < -1)
			{
				num = 20;
			}
			else
			{
				int value = addMazeBuff.LifeTime.FixedValue.Value;
				bool flag = ((value > 30 || value < 10) ? true : false);
				num = (flag ? (-1) : addMazeBuff.LifeTime.FixedValue.Value);
			}
			int time = num;
			foreach (BaseGameEntity item in list)
			{
				int owner = (param.CasterEntity as AvatarSceneInfo)?.AvatarInfo.BaseAvatarId ?? 0;
				EntitySummonUnit entitySummonUnit = param.CasterEntity as EntitySummonUnit;
				if (entitySummonUnit != null)
				{
					owner = entitySummonUnit.CreateAvatarId;
				}
				await item.AddBuff(new SceneBuff(addMazeBuff.ID, 1, owner, time)
				{
					DynamicValues = dynamic,
					CastEntityId = ((param.Request.CastEntityId == 0) ? param.CasterEntity.EntityId : ((int)param.Request.CastEntityId)),
					SummonUnitEntityId = (entitySummonUnit?.AttachEntityId ?? 0)
				});
			}
		}
		return new AbilityLevelResult(instance, battleInfos);
	}

	public async ValueTask<object> RemoveMazeBuff(AbilityLevelParam param)
	{
		BattleInstance instance = null;
		List<HitMonsterInstance> battleInfos = new List<HitMonsterInstance>();
		TaskConfigInfo act = param.Act;
		if (act is RemoveMazeBuff removeMazeBuff)
		{
			string methodName = removeMazeBuff.TargetType.Type.Replace("RPG.GameCore.", "");
			ExecuteTask orCreateExecuteTask = GetOrCreateExecuteTask(methodName);
			if (orCreateExecuteTask == null)
			{
				return new AbilityLevelResult();
			}
			if (!(await orCreateExecuteTask(param with
			{
				TargetEvaluator = removeMazeBuff.TargetType
			}) is List<BaseGameEntity> source))
			{
				return new AbilityLevelResult(instance, battleInfos);
			}
			foreach (AvatarSceneInfo item in source.OfType<AvatarSceneInfo>())
			{
				await item.RemoveBuff(removeMazeBuff.ID);
			}
		}
		return new AbilityLevelResult(instance, battleInfos);
	}

	public async ValueTask<object> AdventureFireProjectile(AbilityLevelParam param)
	{
		BattleInstance instance = null;
		List<HitMonsterInstance> battleInfos = new List<HitMonsterInstance>();
		TaskConfigInfo act = param.Act;
		if (act is AdventureFireProjectile adventureFireProjectile)
		{
			foreach (TaskConfigInfo item in adventureFireProjectile.OnProjectileHit)
			{
				AbilityLevelResult abilityLevelResult = await TriggerTask(param with
				{
					Act = item
				});
				if (abilityLevelResult.BattleInfos != null)
				{
					battleInfos.AddRange(abilityLevelResult.BattleInfos);
				}
				if (abilityLevelResult.Instance != null)
				{
					instance = abilityLevelResult.Instance;
				}
			}
			foreach (TaskConfigInfo item2 in adventureFireProjectile.OnProjectileLifetimeFinish)
			{
				AbilityLevelResult abilityLevelResult2 = await TriggerTask(param with
				{
					Act = item2
				});
				if (abilityLevelResult2.BattleInfos != null)
				{
					battleInfos.AddRange(abilityLevelResult2.BattleInfos);
				}
				if (abilityLevelResult2.Instance != null)
				{
					instance = abilityLevelResult2.Instance;
				}
			}
		}
		return new AbilityLevelResult(instance, battleInfos);
	}

	public async ValueTask<object> NewAdventureFireProjectile(AbilityLevelParam param)
	{
		BattleInstance instance = null;
		List<HitMonsterInstance> battleInfos = new List<HitMonsterInstance>();
		TaskConfigInfo act = param.Act;
		if (act is AdventureFireProjectile adventureFireProjectile)
		{
			foreach (TaskConfigInfo item in adventureFireProjectile.OnProjectileHit)
			{
				AbilityLevelResult abilityLevelResult = await TriggerTask(param with
				{
					Act = item
				});
				if (abilityLevelResult.BattleInfos != null)
				{
					battleInfos.AddRange(abilityLevelResult.BattleInfos);
				}
				if (abilityLevelResult.Instance != null)
				{
					instance = abilityLevelResult.Instance;
				}
			}
			foreach (TaskConfigInfo item2 in adventureFireProjectile.OnProjectileLifetimeFinish)
			{
				AbilityLevelResult abilityLevelResult2 = await TriggerTask(param with
				{
					Act = item2
				});
				if (abilityLevelResult2.BattleInfos != null)
				{
					battleInfos.AddRange(abilityLevelResult2.BattleInfos);
				}
				if (abilityLevelResult2.Instance != null)
				{
					instance = abilityLevelResult2.Instance;
				}
			}
		}
		return new AbilityLevelResult(instance, battleInfos);
	}

	public async ValueTask<object> CreateSummonUnit(AbilityLevelParam param)
	{
		if (param.Act is CreateSummonUnit createSummonUnit)
		{
			if (!GameData.SummonUnitDataData.TryGetValue(createSummonUnit.SummonUnitID, out SummonUnitDataExcel value))
			{
				return new AbilityLevelResult();
			}
			MotionInfo motionInfo = new MotionInfo
			{
				Pos = (Player.Data.Pos?.ToProto() ?? new Vector()),
				Rot = (Player.Data.Rot?.ToProto() ?? new Vector())
			};
			MotionInfo motionInfo2 = param.Request.TargetMotion ?? motionInfo;
			if (motionInfo2.Pos == null)
			{
				motionInfo2.Pos = motionInfo.Pos;
			}
			if (motionInfo2.Rot == null)
			{
				motionInfo2.Rot = motionInfo.Rot;
			}
			EntitySummonUnit entity = new EntitySummonUnit
			{
				EntityId = 0,
				CreateAvatarEntityId = param.CasterEntity.EntityId,
				AttachEntityId = ((value.ConfigInfo?.AttachPoint == "Origin") ? param.CasterEntity.EntityId : 0),
				SummonUnitId = value.ID,
				CreateAvatarId = ((param.CasterEntity as AvatarSceneInfo)?.AvatarInfo.BaseAvatarId ?? 0),
				LifeTimeMs = 45000,
				TriggerList = (value.ConfigInfo?.TriggerConfig.CustomTriggers ?? new List<UnitCustomTriggerConfigInfo>()),
				Motion = motionInfo2
			};
			await Player.SceneInstance.AddSummonUnitEntity(entity);
		}
		return new AbilityLevelResult();
	}

	public async ValueTask<object> DestroySummonUnit(AbilityLevelParam param)
	{
		if (param.Act is DestroySummonUnit destroySummonUnit)
		{
			await Player.SceneInstance.RemoveSummonUnitById(destroySummonUnit.SummonUnit.SummonUnitID);
		}
		return new AbilityLevelResult();
	}

	public async ValueTask<object> AddAdventureModifier(AbilityLevelParam param)
	{
		if (param.Act is AddAdventureModifier addAdventureModifier)
		{
			GameData.AdventureModifierData.TryGetValue(addAdventureModifier.ModifierName, out AdventureModifierConfig value);
			if (value == null)
			{
				return new AbilityLevelResult();
			}
			if (param.CasterEntity is IGameModifier gameModifier)
			{
				await gameModifier.AddModifier(addAdventureModifier.ModifierName);
			}
		}
		return new AbilityLevelResult();
	}

	public async ValueTask<object> RemoveAdventureModifier(AbilityLevelParam param)
	{
		if (param.Act is RemoveAdventureModifier removeAdventureModifier)
		{
			GameData.AdventureModifierData.TryGetValue(removeAdventureModifier.ModifierName, out AdventureModifierConfig value);
			if (value == null)
			{
				return new AbilityLevelResult();
			}
			if (param.CasterEntity is IGameModifier gameModifier)
			{
				await gameModifier.RemoveModifier(removeAdventureModifier.ModifierName);
			}
		}
		return new AbilityLevelResult();
	}

	public async ValueTask<object> RemoveSelfModifier(AbilityLevelParam param)
	{
		if (param.ModifierName != null && param.CasterEntity is IGameModifier gameModifier)
		{
			await gameModifier.RemoveModifier(param.ModifierName);
		}
		return new AbilityLevelResult();
	}

	public async ValueTask<object> RefreshMazeBuffTime(AbilityLevelParam param)
	{
		TaskConfigInfo act = param.Act;
		RefreshMazeBuffTime refreshMazeBuffTime = act as RefreshMazeBuffTime;
		if (refreshMazeBuffTime != null)
		{
			SceneBuff sceneBuff = param.CasterEntity.BuffList.FirstOrDefault((SceneBuff x) => x.BuffId == refreshMazeBuffTime.ID);
			if (sceneBuff == null)
			{
				return new AbilityLevelResult();
			}
			sceneBuff.Duration = refreshMazeBuffTime.LifeTime.GetValue();
			await Player.SendPacket(new PacketSyncEntityBuffChangeListScNotify(param.CasterEntity, sceneBuff));
		}
		return new AbilityLevelResult();
	}

	public async ValueTask<object> AdvModifyMaxMazeMP(AbilityLevelParam param)
	{
		await ValueTask.CompletedTask;
		if (param.Act is AdvModifyMaxMazeMP { ModifyFunction: var modifyFunction } advModifyMaxMazeMP)
		{
			switch (modifyFunction)
			{
			case PropertyModifyFunctionEnum.Add:
				Player.LineupManager.LineupData.ExtraMpCount += advModifyMaxMazeMP.ModifyValue.GetValue();
				break;
			case PropertyModifyFunctionEnum.Set:
				Player.LineupManager.LineupData.ExtraMpCount = advModifyMaxMazeMP.ModifyValue.GetValue() - 5;
				break;
			}
		}
		return new AbilityLevelResult();
	}

	public async ValueTask<object> AdventureSetAttackTargetMonsterDie(AbilityLevelParam param)
	{
		AvatarSceneInfo avatarSceneInfo = param.CasterEntity as AvatarSceneInfo;
		if (GameData.AvatarConfigData.TryGetValue(avatarSceneInfo?.AvatarInfo.AvatarId ?? 0, out AvatarConfigExcel value))
		{
			AdventurePlayerExcel valueOrDefault = GameData.AdventurePlayerData.GetValueOrDefault(value.AdventurePlayerID);
			if (valueOrDefault != null && valueOrDefault.MazeSkillIdList.Count > param.Request.SkillIndex)
			{
				MazeSkillExcel valueOrDefault2 = GameData.MazeSkillData.GetValueOrDefault(valueOrDefault.MazeSkillIdList[(int)param.Request.SkillIndex]);
				await Player.LineupManager.CostMp(valueOrDefault2?.MPCost ?? 1, param.Request.CastEntityId);
			}
		}
		foreach (BaseGameEntity targetEntity in param.TargetEntities)
		{
			if (targetEntity is EntityMonster entityMonster && entityMonster.MonsterData.Rank < MonsterRankEnum.Elite)
			{
				await entityMonster.Kill();
			}
		}
		return new AbilityLevelResult();
	}

	public async ValueTask<object> ByAllowInstantKill(AbilityLevelParam param)
	{
		await ValueTask.CompletedTask;
		foreach (BaseGameEntity targetEntity in param.TargetEntities)
		{
			if (targetEntity is EntityMonster entityMonster && entityMonster.MonsterData.Rank < MonsterRankEnum.Elite)
			{
				return true;
			}
		}
		return false;
	}

	public async ValueTask<object> ByIsContainAdventureModifier(AbilityLevelParam param)
	{
		await ValueTask.CompletedTask;
		TaskConfigInfo act = param.Act;
		if (act is ByIsContainAdventureModifier byIsContain)
		{
			bool result = false;
			string methodName = byIsContain.TargetType.Type.Replace("RPG.GameCore.", "");
			ExecuteTask orCreateExecuteTask = GetOrCreateExecuteTask(methodName);
			if (orCreateExecuteTask == null)
			{
				return false;
			}
			if (await orCreateExecuteTask(param with
			{
				TargetEvaluator = byIsContain.TargetType
			}) is List<BaseGameEntity> list)
			{
				foreach (BaseGameEntity item in list)
				{
					if (item is IGameModifier gameModifier && gameModifier.Modifiers.Contains(byIsContain.ModifierName))
					{
						result = true;
						break;
					}
				}
			}
			return result;
		}
		return false;
	}

	public async ValueTask<object> AdventureByInMotionState(AbilityLevelParam param)
	{
		await ValueTask.CompletedTask;
		return true;
	}

	public async ValueTask<object> AdventureByPlayerCurrentSkillType(AbilityLevelParam param)
	{
		await ValueTask.CompletedTask;
		if (param.Act is AdventureByPlayerCurrentSkillType adventureByPlayerCurrentSkillType)
		{
			return param.Request.SkillIndex == (uint)adventureByPlayerCurrentSkillType.SkillType;
		}
		return false;
	}

	public async ValueTask<object> ByCompareCarryMazebuff(AbilityLevelParam param)
	{
		await ValueTask.CompletedTask;
		TaskConfigInfo act = param.Act;
		ByCompareCarryMazebuff byCompareCarryMazebuff = act as ByCompareCarryMazebuff;
		if (byCompareCarryMazebuff != null)
		{
			return param.CasterEntity.BuffList.Any((SceneBuff x) => x.BuffId == byCompareCarryMazebuff.BuffID);
		}
		return false;
	}

	public async ValueTask<object> ByAnd(AbilityLevelParam param)
	{
		await ValueTask.CompletedTask;
		if (param.Act is ByAnd byAnd)
		{
			foreach (PredicateConfigInfo task in byAnd.PredicateList)
			{
				string methodName = task.Type.Replace("RPG.GameCore.", "");
				ExecuteTask orCreateExecuteTask = GetOrCreateExecuteTask(methodName);
				if (orCreateExecuteTask == null)
				{
					return false;
				}
				if (!(await orCreateExecuteTask(param with
				{
					Act = task
				}) is bool flag))
				{
					return false;
				}
				if (!(task.Inverse ? (!flag) : flag))
				{
					return false;
				}
			}
			return true;
		}
		return false;
	}
}
