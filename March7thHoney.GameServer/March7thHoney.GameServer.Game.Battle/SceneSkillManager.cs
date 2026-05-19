using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Config;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Inventory;
using March7thHoney.Enums.Scene;
using March7thHoney.GameServer.Game.Drop;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Game.Scene;
using March7thHoney.GameServer.Game.Scene.Entity;
using March7thHoney.GameServer.Game.Task.AvatarTask;
using March7thHoney.GameServer.Server.Packet.Send.Scene;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.Battle;

public class SceneSkillManager : BasePlayerManager
{
	private const int SpeedDestructEventId = 10003;

	private const int SpeedDestructBuffId = 2041101;

	private const int SpeedDestructBuffDurationSec = 15;

	public SceneSkillManager(PlayerInstance player)
		: base(player)
	{
	}

	public async ValueTask<SkillResultData> OnCast(SceneCastSkillCsReq req)
	{
		bool flag = await HandleDestructPropDrops(req);
		List<BaseGameEntity> list = new List<BaseGameEntity>();
		List<int> list2 = new List<int>();
		foreach (uint assistMonsterEntityId in req.AssistMonsterEntityIdList)
		{
			if (base.Player.SceneInstance.Entities.TryGetValue((int)assistMonsterEntityId, out BaseGameEntity value))
			{
				list.Add(value);
				list2.Add((int)assistMonsterEntityId);
			}
		}
		foreach (AssistMonsterEntityInfo item in req.AssistMonsterEntityInfo)
		{
			foreach (uint entityId in item.EntityIdList)
			{
				if (!list2.Contains((int)entityId) && base.Player.SceneInstance.Entities.TryGetValue((int)entityId, out BaseGameEntity value2))
				{
					list.Add(value2);
					list2.Add((int)entityId);
				}
			}
		}
		BaseGameEntity attackEntity = base.Player.SceneInstance.Entities.GetValueOrDefault((int)req.AttackedByEntityId);
		if (attackEntity == null)
		{
			return flag ? new SkillResultData(Retcode.RetSucc) : new SkillResultData(Retcode.RetSceneEntityNotExist);
		}
		AdventureAbilityConfigListInfo abilityConfig = GetAbilityConfig(attackEntity);
		if (abilityConfig == null || abilityConfig.AbilityList.Count < 1)
		{
			return new SkillResultData(Retcode.RetMazeNoAbility);
		}
		string abilityName = ((!string.IsNullOrEmpty(req.MazeAbilityStr)) ? req.MazeAbilityStr : ((req.SkillIndex == 0) ? "NormalAtk01" : "MazeSkill"));
		AdventureAbilityConfigInfo adventureAbilityConfigInfo = abilityConfig.AbilityList.Find((AdventureAbilityConfigInfo x) => x.Name.Contains(abilityName));
		if (adventureAbilityConfigInfo == null)
		{
			adventureAbilityConfigInfo = abilityConfig.AbilityList.FirstOrDefault();
			if (adventureAbilityConfigInfo == null)
			{
				return new SkillResultData(Retcode.RetMazeNoAbility);
			}
		}
		AbilityLevelResult res = await base.Player.TaskManager.AbilityLevelTask.TriggerTasks(abilityConfig, adventureAbilityConfigInfo.OnStart, attackEntity, list, req);
		if (attackEntity is AvatarSceneInfo)
		{
			await base.Player.SceneInstance.OnUseSkill(req);
		}
		if (req.SkillIndex == 1)
		{
			AvatarSceneInfo casterAvatar = attackEntity as AvatarSceneInfo;
			if (casterAvatar != null)
			{
				int avatarId = casterAvatar.AvatarInfo.BaseAvatarId;
				List<(int, MazeBuffExcel)> source = (from kvp in GameData.MazeBuffData
					where kvp.Key / 10 / 100 == avatarId && kvp.Value.MazeBuffType == "Character" && (kvp.Value.InBattleBindingType == "CharacterSkill" || kvp.Value.InBattleBindingType == "CharacterSkillAdv") && kvp.Value.InBattleBindingKey == "SkillMaze"
					select (BuffId: kvp.Key / 10, Excel: kvp.Value)).ToList();
				if (!source.Any<(int, MazeBuffExcel)>(((int BuffId, MazeBuffExcel Excel) c) => casterAvatar.BuffList.Any((SceneBuff b) => b.BuffId == c.BuffId)))
				{
					(int, MazeBuffExcel) tuple = source.FirstOrDefault<(int, MazeBuffExcel)>(delegate((int BuffId, MazeBuffExcel Excel) c)
					{
						switch (c.Excel.UseType)
						{
						case "SummonUnit":
						case "AddBattleBuff":
						case "TriggerBattle":
							return true;
						default:
							return false;
						}
					});
					if (tuple.Item1 != 0)
					{
						await casterAvatar.AddBuff(new SceneBuff(tuple.Item1, tuple.Item2.Lv, avatarId));
					}
				}
			}
		}
		return new SkillResultData(Retcode.RetSucc, res.Instance, res.BattleInfos);
	}

	private async ValueTask<bool> HandleDestructPropDrops(SceneCastSkillCsReq req)
	{
		if (base.Player.SceneInstance == null || base.Player.InventoryManager == null)
		{
			return false;
		}
		bool handled = false;
		HashSet<int> hashSet = new HashSet<int> { (int)req.AttackedByEntityId };
		foreach (uint assistMonsterEntityId in req.AssistMonsterEntityIdList)
		{
			hashSet.Add((int)assistMonsterEntityId);
		}
		foreach (AssistMonsterEntityInfo item in req.AssistMonsterEntityInfo)
		{
			foreach (uint entityId in item.EntityIdList)
			{
				hashSet.Add((int)entityId);
			}
		}
		foreach (int item2 in hashSet)
		{
			if (!base.Player.SceneInstance.Entities.TryGetValue(item2, out BaseGameEntity value) || !(value is EntityProp prop) || prop.Excel.PropType != PropTypeEnum.PROP_DESTRUCT)
			{
				continue;
			}
			handled = true;
			if (prop.PropInfo.EventID > 0)
			{
				await ApplyPropEventEffect(prop, req);
				List<ItemData> list = BuildPlaneEventRewards(prop.PropInfo.EventID);
				if (list.Count <= 0)
				{
					await base.Player.SendPacket(new PacketScenePlaneEventScNotify(new ItemList()));
				}
				else
				{
					await base.Player.InventoryManager.AddItems(list);
				}
			}
			if (prop.PropInfo.ChestID > 0)
			{
				List<ItemData> list2 = DropService.CalculateDropsFromProp(prop.PropInfo.ChestID);
				if (list2.Count > 0)
				{
					await base.Player.InventoryManager.AddItems(list2);
				}
			}
			await base.Player.SceneInstance.RemoveEntity(prop, sendPacket: false);
			await base.Player.SendPacket(new PacketSceneGroupRefreshScNotify(base.Player, null, prop, SceneGroupRefreshType.Afibfmafncc));
			if (prop.Group.SaveType != SaveTypeEnum.Reset)
			{
				base.Player.SetScenePropData(base.Player.SceneInstance.FloorId, prop.GroupId, prop.PropInfo.ID, PropStateEnum.Open);
			}
		}
		return handled;
	}

	private async ValueTask ApplyPropEventEffect(EntityProp prop, SceneCastSkillCsReq req)
	{
		if (prop.PropInfo.EventID == 10003 && base.Player.SceneInstance != null && base.Player.SceneInstance.Entities.GetValueOrDefault((int)req.AttackedByEntityId) is AvatarSceneInfo avatarSceneInfo)
		{
			await avatarSceneInfo.AddBuff(new SceneBuff(2041101, 1, avatarSceneInfo.AvatarInfo.BaseAvatarId, 15));
		}
	}

	private List<ItemData> BuildPlaneEventRewards(int eventId)
	{
		List<ItemData> list = new List<ItemData>();
		GameData.PlaneEventData.TryGetValue(eventId * 10 + base.Player.Data.WorldLevel, out PlaneEventExcel value);
		if (value == null)
		{
			return list;
		}
		AddRewardItems(value.Reward, list);
		foreach (int drop in value.DropList)
		{
			AddRewardItems(drop, list);
		}
		return list;
	}

	private static void AddRewardItems(int rewardId, List<ItemData> items)
	{
		GameData.RewardDataData.TryGetValue(rewardId, out RewardDataExcel value);
		if (value == null)
		{
			return;
		}
		if (value.Hcoin > 0)
		{
			items.Add(new ItemData
			{
				ItemId = 1,
				Count = value.Hcoin
			});
		}
		foreach (var (itemId, count) in value.GetItems())
		{
			items.Add(new ItemData
			{
				ItemId = itemId,
				Count = count
			});
		}
	}

	private AdventureAbilityConfigListInfo? GetAbilityConfig(BaseGameEntity entity)
	{
		if (entity is EntityMonster entityMonster)
		{
			return GameData.AdventureAbilityConfigListData.GetValueOrDefault(entityMonster.MonsterData.ID);
		}
		if (entity is AvatarSceneInfo avatarSceneInfo && GameData.AvatarConfigData.TryGetValue(avatarSceneInfo.AvatarInfo.AvatarId, out AvatarConfigExcel value))
		{
			return GameData.AdventureAbilityConfigListData.GetValueOrDefault(value.AdventurePlayerID);
		}
		return null;
	}
}
