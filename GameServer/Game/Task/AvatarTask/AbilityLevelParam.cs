using System.Collections.Generic;
using March7thHoney.Data.Config;
using March7thHoney.Data.Config.Task;
using March7thHoney.GameServer.Game.Scene.Entity;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.Task.AvatarTask;

public record AbilityLevelParam(AdventureAbilityConfigListInfo AdventureAbility, TaskConfigInfo Act, BaseGameEntity CasterEntity, List<BaseGameEntity> TargetEntities, SceneCastSkillCsReq Request, string? ModifierName, TargetEvaluator? TargetEvaluator = null);
