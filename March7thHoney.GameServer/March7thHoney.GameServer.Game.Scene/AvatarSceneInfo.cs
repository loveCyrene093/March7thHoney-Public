using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Config;
using March7thHoney.Data.Config.AdventureAbility;
using March7thHoney.Data.Config.Character;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Avatar;
using March7thHoney.Enums.Avatar;
using March7thHoney.GameServer.Game.Battle;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Game.Scene.Component;
using March7thHoney.GameServer.Game.Scene.Entity;
using March7thHoney.GameServer.Server.Packet.Send.Scene;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.Scene;

public class AvatarSceneInfo : BaseGameEntity, IGameModifier
{
	public BaseAvatarInfo AvatarInfo { get; set; }

	public AvatarType AvatarType { get; set; }

	public PlayerInstance Player { get; set; }

	public override int EntityId { get; set; }

	public override int GroupId { get; set; }

	public List<string> Modifiers { get; set; } = new List<string>();

	public AvatarSceneInfo(BaseAvatarInfo avatarInfo, AvatarType avatarType, PlayerInstance player)
	{
		AvatarInfo = avatarInfo;
		AvatarType = avatarType;
		Player = player;
		if (!GameData.AvatarConfigData.TryGetValue(avatarInfo.AvatarId, out AvatarConfigExcel value))
		{
			return;
		}
		CharacterConfigInfo valueOrDefault = GameData.CharacterConfigInfoData.GetValueOrDefault(value.AdventurePlayerID);
		GameData.AdventureAbilityConfigListData.TryGetValue(value.AdventurePlayerID, out AdventureAbilityConfigListInfo value2);
		if (valueOrDefault == null || value2 == null)
		{
			return;
		}
		foreach (SkillConfigInfo item in valueOrDefault.SkillList.Where((SkillConfigInfo x) => x.UseType == SkillUseTypeEnum.Passive))
		{
			string abilityStr = item.EntryAbility;
			AdventureAbilityConfigInfo adventureAbilityConfigInfo = value2.AbilityList.FirstOrDefault((AdventureAbilityConfigInfo x) => x.Name == abilityStr);
			if (adventureAbilityConfigInfo != null)
			{
				Player.TaskManager.AbilityLevelTask.TriggerTasks(value2, adventureAbilityConfigInfo.OnStart, this, new List<BaseGameEntity>(), new SceneCastSkillCsReq());
			}
		}
	}

	public async ValueTask AddModifier(string modifierName)
	{
		if (!Modifiers.Contains(modifierName))
		{
			Modifiers.Add(modifierName);
			GameData.AdventureModifierData.TryGetValue(modifierName, out AdventureModifierConfig modifier);
			GameData.AdventureAbilityConfigListData.TryGetValue(AvatarInfo.AvatarId, out AdventureAbilityConfigListInfo avatarAbility);
			if (modifier != null && avatarAbility != null)
			{
				await Player.TaskManager.AbilityLevelTask.TriggerTasks(avatarAbility, modifier.OnCreate, this, new List<BaseGameEntity>(), new SceneCastSkillCsReq
				{
					TargetMotion = new MotionInfo
					{
						Pos = (Player.Data.Pos?.ToProto() ?? new Vector()),
						Rot = (Player.Data.Rot?.ToProto() ?? new Vector())
					}
				});
				await Player.TaskManager.AbilityLevelTask.TriggerTasks(avatarAbility, modifier.OnStack, this, new List<BaseGameEntity>(), new SceneCastSkillCsReq
				{
					TargetMotion = new MotionInfo
					{
						Pos = (Player.Data.Pos?.ToProto() ?? new Vector()),
						Rot = (Player.Data.Rot?.ToProto() ?? new Vector())
					}
				});
			}
		}
	}

	public async ValueTask RemoveModifier(string modifierName)
	{
		if (Modifiers.Contains(modifierName))
		{
			Modifiers.Remove(modifierName);
			GameData.AdventureModifierData.TryGetValue(modifierName, out AdventureModifierConfig value);
			GameData.AdventureAbilityConfigListData.TryGetValue(AvatarInfo.AvatarId, out AdventureAbilityConfigListInfo value2);
			if (value != null && value2 != null)
			{
				await Player.TaskManager.AbilityLevelTask.TriggerTasks(value2, value.OnDestroy, this, new List<BaseGameEntity>(), new SceneCastSkillCsReq());
			}
		}
	}

	public override async ValueTask AddBuff(SceneBuff buff)
	{
		if (!GameData.MazeBuffData.TryGetValue(buff.BuffId * 10 + buff.BuffLevel, out MazeBuffExcel buffExcel))
		{
			return;
		}
		SceneBuff sceneBuff = base.BuffList.Find((SceneBuff x) => x.BuffId == buff.BuffId);
		if (sceneBuff != null)
		{
			if (!sceneBuff.IsExpired())
			{
				sceneBuff.CreatedTime = Extensions.GetUnixMs();
				sceneBuff.Duration = buff.Duration;
				await Player.SendPacket(new PacketSyncEntityBuffChangeListScNotify(this, sceneBuff));
				await AddModifier(buffExcel.ModifierName);
				return;
			}
			base.BuffList.Remove(sceneBuff);
		}
		base.BuffList.Add(buff);
		await Player.SendPacket(new PacketSyncEntityBuffChangeListScNotify(this, buff));
		await AddModifier(buffExcel.ModifierName);
	}

	public override async ValueTask ApplyBuff(BattleInstance instance)
	{
		if (base.BuffList.Count == 0)
		{
			return;
		}
		foreach (SceneBuff item in base.BuffList.Where((SceneBuff buff) => !buff.IsExpired()))
		{
			instance.Buffs.Add(new MazeBuff(item));
		}
		await Player.SendPacket(new PacketSyncEntityBuffChangeListScNotify(this, base.BuffList));
		foreach (SceneBuff buff in base.BuffList)
		{
			if (GameData.MazeBuffData.TryGetValue(buff.BuffId * 10 + buff.BuffLevel, out MazeBuffExcel value))
			{
				await RemoveModifier(value.ModifierName);
			}
		}
		base.BuffList.Clear();
	}

	public override SceneEntityInfo ToProto()
	{
		return new SceneEntityInfo
		{
			EntityId = (uint)EntityId,
			Motion = new MotionInfo
			{
				Pos = (Player.Data.Pos?.ToProto() ?? new Vector()),
				Rot = (Player.Data.Rot?.ToProto() ?? new Vector())
			},
			Actor = new SceneActorInfo
			{
				BaseAvatarId = (uint)AvatarInfo.BaseAvatarId,
				AvatarType = AvatarType
			}
		};
	}

	public async ValueTask RemoveBuff(int buffId)
	{
		if (GameData.MazeBuffData.TryGetValue(buffId * 10 + 1, out MazeBuffExcel buffExcel))
		{
			SceneBuff sceneBuff = base.BuffList.Find((SceneBuff x) => x.BuffId == buffId);
			if (sceneBuff != null)
			{
				base.BuffList.Remove(sceneBuff);
				await Player.SendPacket(new PacketSyncEntityBuffChangeListScNotify(this, new List<SceneBuff>(1) { sceneBuff }));
				await RemoveModifier(buffExcel.ModifierName);
			}
		}
	}

	public async ValueTask ClearAllBuff()
	{
		if (base.BuffList.Count == 0)
		{
			return;
		}
		await Player.SendPacket(new PacketSyncEntityBuffChangeListScNotify(this, base.BuffList));
		foreach (SceneBuff buff in base.BuffList)
		{
			if (GameData.MazeBuffData.TryGetValue(buff.BuffId * 10 + buff.BuffLevel, out MazeBuffExcel value))
			{
				await RemoveModifier(value.ModifierName);
			}
		}
		base.BuffList.Clear();
	}

	public async ValueTask OnDestroyInstance()
	{
		string[] array = Modifiers.ToArray();
		foreach (string modifierName in array)
		{
			await RemoveModifier(modifierName);
		}
		EntityMonster[] array2 = Player.SceneInstance.Entities.Values.OfType<EntityMonster>().ToArray();
		foreach (EntityMonster monsterInfo in array2)
		{
			SceneBuff[] array3 = monsterInfo.BuffList.Where((SceneBuff x) => x.OwnerAvatarId == AvatarInfo.BaseAvatarId).ToArray();
			foreach (SceneBuff sceneBuff in array3)
			{
				await monsterInfo.RemoveBuff(sceneBuff.BuffId);
			}
		}
	}
}
