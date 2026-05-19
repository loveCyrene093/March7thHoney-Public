using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Config;
using March7thHoney.Data.Config.AdventureAbility;
using March7thHoney.Data.Config.Scene;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Inventory;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Battle;
using March7thHoney.GameServer.Game.Scene.Component;
using March7thHoney.GameServer.Server.Packet.Send.Scene;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.Scene.Entity;

public class EntityMonster : BaseGameEntity, IGameModifier
{
	public Position Position { get; set; }

	public Position Rotation { get; set; }

	public int InstId { get; set; }

	public SceneInstance Scene { get; set; }

	public NPCMonsterDataExcel MonsterData { get; set; }

	public MonsterInfo Info { get; set; }

	public SceneBuff? TempBuff { get; set; }

	public bool IsAlive { get; private set; }

	public int EventId { get; set; }

	public int CustomStageId { get; set; }

	public int RogueMonsterId { get; set; }

	public int CustomLevel { get; set; }

	public int HardLevelGroup { get; set; }

	public override int EntityId { get; set; }

	public override int GroupId { get; set; }

	public List<string> Modifiers { get; set; }

	public EntityMonster(SceneInstance scene, Position pos, Position rot, int groupId, int instId, NPCMonsterDataExcel excel, MonsterInfo info)
	{
		Position = pos;
		Rotation = rot;
		InstId = instId;
		Scene = scene;
		MonsterData = excel;
		Info = info;
		IsAlive = true;
		EventId = info.EventID;
		GroupId = groupId;
		Modifiers = new List<string>();
		base._002Ector();
	}

	public async ValueTask AddModifier(string modifierName)
	{
		if (!Modifiers.Contains(modifierName))
		{
			GameData.AdventureModifierData.TryGetValue(modifierName, out AdventureModifierConfig value);
			GameData.AdventureAbilityConfigListData.TryGetValue(MonsterData.ID, out AdventureAbilityConfigListInfo value2);
			if (value != null && value2 != null)
			{
				await Scene.Player.TaskManager.AbilityLevelTask.TriggerTasks(value2, value.OnCreate, this, new List<BaseGameEntity>(), new SceneCastSkillCsReq());
				Modifiers.Add(modifierName);
			}
		}
	}

	public async ValueTask RemoveModifier(string modifierName)
	{
		if (Modifiers.Contains(modifierName))
		{
			GameData.AdventureModifierData.TryGetValue(modifierName, out AdventureModifierConfig value);
			GameData.AdventureAbilityConfigListData.TryGetValue(MonsterData.ID, out AdventureAbilityConfigListInfo value2);
			if (value != null && value2 != null)
			{
				await Scene.Player.TaskManager.AbilityLevelTask.TriggerTasks(value2, value.OnDestroy, this, new List<BaseGameEntity>(), new SceneCastSkillCsReq());
				Modifiers.Remove(modifierName);
			}
		}
	}

	public override async ValueTask AddBuff(SceneBuff buff)
	{
		if (GameData.MazeBuffData.TryGetValue(buff.BuffId * 10 + buff.BuffLevel, out MazeBuffExcel value))
		{
			await AddModifier(value.ModifierName);
			SceneBuff sceneBuff = base.BuffList.Find((SceneBuff x) => x.BuffId == buff.BuffId);
			if (sceneBuff != null)
			{
				base.BuffList.Remove(sceneBuff);
			}
			base.BuffList.Add(buff);
			await Scene.Player.SendPacket(new PacketSyncEntityBuffChangeListScNotify(this, buff));
		}
	}

	public override async ValueTask ApplyBuff(BattleInstance instance)
	{
		if (TempBuff != null)
		{
			instance.Buffs.Add(new MazeBuff(TempBuff));
			TempBuff = null;
		}
		if (base.BuffList.Count == 0)
		{
			return;
		}
		foreach (SceneBuff buff in base.BuffList)
		{
			if (!buff.IsExpired())
			{
				instance.Buffs.Add(new MazeBuff(buff));
			}
		}
		await Scene.Player.SendPacket(new PacketSyncEntityBuffChangeListScNotify(this, base.BuffList));
		base.BuffList.Clear();
	}

	public override SceneEntityInfo ToProto()
	{
		SceneEntityInfo sceneEntityInfo = new SceneEntityInfo
		{
			EntityId = (uint)EntityId,
			GroupId = (uint)GroupId,
			InstId = (uint)InstId,
			Motion = new MotionInfo
			{
				Pos = Position.ToProto(),
				Rot = Rotation.ToProto()
			},
			NpcMonster = new SceneNpcMonsterInfo
			{
				EventId = (uint)EventId,
				MonsterId = (uint)MonsterData.ID,
				WorldLevel = (uint)Scene.Player.Data.WorldLevel
			}
		};
		if (RogueMonsterId > 0)
		{
			sceneEntityInfo.NpcMonster.ExtraInfo = new NpcMonsterExtraInfo
			{
				RogueGameInfo = new NpcMonsterRogueInfo
				{
					RogueMonsterId = (uint)RogueMonsterId,
					Level = (uint)CustomLevel,
					HardLevelGroup = (uint)HardLevelGroup
				}
			};
		}
		return sceneEntityInfo;
	}

	public async ValueTask RemoveBuff(int buffId)
	{
		if (GameData.MazeBuffData.TryGetValue(buffId * 10 + 1, out MazeBuffExcel buffExcel))
		{
			SceneBuff sceneBuff = base.BuffList.Find((SceneBuff x) => x.BuffId == buffId);
			if (sceneBuff != null)
			{
				base.BuffList.Remove(sceneBuff);
				await Scene.Player.SendPacket(new PacketSyncEntityBuffChangeListScNotify(this, new List<SceneBuff>(1) { sceneBuff }));
				await RemoveModifier(buffExcel.ModifierName);
			}
		}
	}

	public int GetStageId()
	{
		if (CustomStageId > 0)
		{
			return CustomStageId;
		}
		return Info.EventID;
	}

	public async ValueTask<List<ItemData>> Kill(bool sendPacket = true, bool removeFromScene = true)
	{
		if (removeFromScene)
		{
			IsAlive = false;
		}
		GameData.MonsterDropData.TryGetValue(MonsterData.ID * 10 + Scene.Player.Data.WorldLevel, out MonsterDropExcel value);
		if (value == null)
		{
			return new List<ItemData>();
		}
		List<ItemData> dropItems = value.CalculateDrop();
		await Scene.Player.InventoryManager.AddItems(dropItems, sendPacket);
		await Scene.Player.MissionManager.HandleFinishType(MissionFinishTypeEnum.KillMonster, this);
		if (removeFromScene)
		{
			await Scene.RemoveEntity(this);
		}
		return dropItems;
	}
}
