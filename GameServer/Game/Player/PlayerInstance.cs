using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Config.Scene;
using March7thHoney.Data.Excel;
using March7thHoney.Database;
using March7thHoney.Database.Avatar;
using March7thHoney.Database.Friend;
using March7thHoney.Database.Inventory;
using March7thHoney.Database.Lineup;
using March7thHoney.Database.Player;
using March7thHoney.Database.Scene;
using March7thHoney.Database.Tutorial;
using March7thHoney.Enums.Avatar;
using March7thHoney.Enums.Mission;
using March7thHoney.Enums.Scene;
using March7thHoney.GameServer.Game.Activity;
using March7thHoney.GameServer.Game.Avatar;
using March7thHoney.GameServer.Game.Battle;
using March7thHoney.GameServer.Game.Challenge;
using March7thHoney.GameServer.Game.ChallengePeak;
using March7thHoney.GameServer.Game.Drop;
using March7thHoney.GameServer.Game.Expedition;
using March7thHoney.GameServer.Game.Friend;
using March7thHoney.GameServer.Game.Gacha;
using March7thHoney.GameServer.Game.GridFight;
using March7thHoney.GameServer.Game.Inventory;
using March7thHoney.GameServer.Game.Lineup;
using March7thHoney.GameServer.Game.Mail;
using March7thHoney.GameServer.Game.Message;
using March7thHoney.GameServer.Game.Mission;
using March7thHoney.GameServer.Game.Player.Components;
using March7thHoney.GameServer.Game.Quest;
using March7thHoney.GameServer.Game.Raid;
using March7thHoney.GameServer.Game.Scene;
using March7thHoney.GameServer.Game.Scene.Entity;
using March7thHoney.GameServer.Game.Shop;
using March7thHoney.GameServer.Game.Sync;
using March7thHoney.GameServer.Game.Sync.Player;
using March7thHoney.GameServer.Game.Task;
using March7thHoney.GameServer.Game.TrainCakeCatch;
using March7thHoney.GameServer.Game.TrainParty;
using March7thHoney.GameServer.Plugin.Event;
using March7thHoney.GameServer.Server;
using March7thHoney.GameServer.Server.Packet.Send.Lineup;
using March7thHoney.GameServer.Server.Packet.Send.MarkChest;
using March7thHoney.GameServer.Server.Packet.Send.Player;
using March7thHoney.GameServer.Server.Packet.Send.PlayerSync;
using March7thHoney.GameServer.Server.Packet.Send.Scene;
using March7thHoney.Kcp;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.Player;

public class PlayerInstance(PlayerData data)
{
	public AvatarManager? AvatarManager { get; private set; }

	public LineupManager? LineupManager { get; private set; }

	public InventoryManager? InventoryManager { get; private set; }

	public BattleManager? BattleManager { get; private set; }

	public SceneSkillManager? SceneSkillManager { get; private set; }

	public BattleInstance? BattleInstance { get; set; }

	public GachaManager? GachaManager { get; private set; }

	public ShopService? ShopService { get; private set; }

	public OfferingManager? OfferingManager { get; private set; }

	public MissionManager? MissionManager { get; private set; }

	public QuestManager? QuestManager { get; private set; }

	public RaidManager? RaidManager { get; private set; }

	public StoryLineManager? StoryLineManager { get; private set; }

	public MessageManager? MessageManager { get; private set; }

	public TaskManager? TaskManager { get; private set; }

	public ActivityManager? ActivityManager { get; private set; }

	public TrainPartyManager? TrainPartyManager { get; private set; }

	public TrainCakeCatchManager? TrainCakeCatchManager { get; private set; }

	public MailManager? MailManager { get; private set; }

	public FriendManager? FriendManager { get; private set; }

	public ChallengeManager? ChallengeManager { get; private set; }

	public ChallengePeakManager? ChallengePeakManager { get; private set; }

	public GridFightManager? GridFightManager { get; private set; }

	public ExpeditionManager? ExpeditionManager { get; private set; }

	public PlayerData Data { get; set; } = data;

	public PlayerUnlockData? PlayerUnlockData { get; private set; }

	public FriendRecordData? FriendRecordData { get; private set; }

	public SceneData? SceneData { get; private set; }

	public HeartDialData? HeartDialData { get; private set; }

	public TutorialData? TutorialData { get; private set; }

	public TutorialGuideData? TutorialGuideData { get; private set; }

	public BattleCollegeData? BattleCollegeData { get; private set; }

	public ServerPrefsData? ServerPrefsData { get; private set; }

	public SceneInstance? SceneInstance { get; private set; }

	public List<BasePlayerComponent> Components { get; } = new List<BasePlayerComponent>();

	public int Uid { get; set; }

	public Connection? Connection { get; set; }

	public bool Initialized { get; set; }

	public bool IsNewPlayer { get; set; }

	public int NextBattleId { get; set; }

	public int ChargerNum { get; set; }

	public PlayerInstance(int uid)
		: this(new PlayerData
		{
			Uid = uid
		})
	{
		IsNewPlayer = true;
		Data.NextStaminaRecover = Extensions.GetUnixSec() + 1080;
		Data.Level = ConfigManager.Config.ServerOption.StartTrailblazerLevel;
		Data.Name = ConfigManager.Config.ServerOption.DefaultNickname;
		DatabaseHelper.SaveInstance(Data);
		System.Threading.Tasks.Task.Run(async delegate
		{
			await InitialPlayerManager();
			await AddAvatar(8001);
			await AddAvatar(8002);
			await AddAvatar(1001);
			if (ConfigManager.Config.ServerOption.EnableMission)
			{
				await LineupManager.AddSpecialAvatarToCurTeam(10010050);
			}
			else
			{
				await LineupManager.AddAvatarToCurTeam(8001);
				Data.CurrentGender = Gender.Woman;
				Data.CurBasicType = 8002;
				FormalAvatarInfo hero = AvatarManager.GetHero();
				if (hero != null)
				{
					hero.AvatarId = 8002;
				}
			}
		}).Wait();
		Initialized = true;
	}

	private async ValueTask InitialPlayerManager()
	{
		Uid = Data.Uid;
		ActivityManager = new ActivityManager(this);
		PlayerInstance playerInstance = this;
		AvatarManager avatarManager = new AvatarManager(this);
		avatarManager.AvatarData.DatabaseVersion = "20250430";
		playerInstance.AvatarManager = avatarManager;
		LineupManager = new LineupManager(this);
		InventoryManager = new InventoryManager(this);
		BattleManager = new BattleManager(this);
		SceneSkillManager = new SceneSkillManager(this);
		MissionManager = new MissionManager(this);
		GachaManager = new GachaManager(this);
		MessageManager = new MessageManager(this);
		MailManager = new MailManager(this);
		FriendManager = new FriendManager(this);
		ShopService = new ShopService(this);
		ChallengeManager = new ChallengeManager(this);
		ChallengePeakManager = new ChallengePeakManager(this);
		GridFightManager = new GridFightManager(this);
		ExpeditionManager = new ExpeditionManager(this);
		TaskManager = new TaskManager(this);
		RaidManager = new RaidManager(this);
		StoryLineManager = new StoryLineManager(this);
		QuestManager = new QuestManager(this);
		TrainPartyManager = new TrainPartyManager(this);
		TrainCakeCatchManager = new TrainCakeCatchManager(this);
		OfferingManager = new OfferingManager(this);
		PlayerUnlockData = InitializeDatabase<PlayerUnlockData>();
		SceneData = InitializeDatabase<SceneData>();
		HeartDialData = InitializeDatabase<HeartDialData>();
		TutorialData = InitializeDatabase<TutorialData>();
		TutorialGuideData = InitializeDatabase<TutorialGuideData>();
		ServerPrefsData = InitializeDatabase<ServerPrefsData>();
		BattleCollegeData = InitializeDatabase<BattleCollegeData>();
		FriendRecordData = InitializeDatabase<FriendRecordData>();
		Components.Add(new SwitchHandComponent(this));
		if ((int)(ServerPrefsData.Version * 1000.0) != 3200)
		{
			ServerPrefsData.ServerPrefsDict.Clear();
			ServerPrefsData.Version = 3.2;
		}
		Data.LastActiveTime = Extensions.GetUnixSec();
		foreach (FormalAvatarInfo item in AvatarManager?.AvatarData.FormalAvatars ?? new List<FormalAvatarInfo>())
		{
			foreach (PathInfo value4 in item.PathInfos.Values)
			{
				foreach (KeyValuePair<int, int> item2 in value4.GetSkillTree())
				{
					GameData.AvatarSkillTreeConfigData.TryGetValue(item2.Key * 100 + 1, out AvatarSkillTreeConfigExcel value);
					if (value != null)
					{
						value4.GetSkillTree()[item2.Key] = Math.Min(item2.Value, value.MaxLevel);
					}
				}
			}
		}
		foreach (LineupAvatarInfo item3 in LineupManager.GetAllLineup().SelectMany((March7thHoney.Database.Lineup.LineupInfo lineupInfo) => lineupInfo.BaseAvatars ?? new List<LineupAvatarInfo>()))
		{
			if (item3.SpecialAvatarId > 0 && GameData.SpecialAvatarData.TryGetValue(item3.SpecialAvatarId, out SpecialAvatarExcel value2))
			{
				item3.SpecialAvatarId = value2.SpecialAvatarID;
				AvatarManager.GetTrialAvatar(value2.SpecialAvatarID)?.CheckLevel(Data.WorldLevel);
			}
			if (item3.SpecialAvatarId > 0 && GameData.SpecialAvatarData.TryGetValue(item3.SpecialAvatarId * 10, out SpecialAvatarExcel value3))
			{
				AvatarManager.GetTrialAvatar(value3.SpecialAvatarID)?.CheckLevel(Data.WorldLevel);
			}
		}
		if (ConfigManager.Config.ServerOption.EnableMission)
		{
			await MissionManager.AcceptMainMissionByCondition();
		}
		FriendDevelopmentInfoPb[] array = FriendRecordData.DevelopmentInfos.ToArray();
		foreach (FriendDevelopmentInfoPb friendDevelopmentInfoPb in array)
		{
			if (Extensions.GetUnixSec() - friendDevelopmentInfoPb.Time >= 604800)
			{
				FriendRecordData.DevelopmentInfos.Remove(friendDevelopmentInfoPb);
			}
		}
		await QuestManager.AcceptQuestByCondition();
	}

	public T InitializeDatabase<T>() where T : BaseDatabaseDataHelper, new()
	{
		DatabaseHelper? instance = DatabaseHelper.Instance;
		if (instance == null)
		{
			return null;
		}
		return instance.GetInstanceOrCreateNew<T>(Uid);
	}

	public async ValueTask OnGetToken()
	{
		if (!Initialized)
		{
			await InitialPlayerManager();
		}
	}

	public async ValueTask OnLogin()
	{
		await SendPacket(new PacketStaminaInfoScNotify(this));
		ChallengeManager?.ResurrectInstance();
		if (StoryLineManager != null)
		{
			await StoryLineManager.OnLogin();
		}
		if (RaidManager != null)
		{
			await RaidManager.OnLogin();
		}
		if (LineupManager.GetCurLineup() != null)
		{
			if (LineupManager.GetCurLineup().IsExtraLineup() && RaidManager.RaidData.CurRaidId == 0 && StoryLineManager.StoryLineData.CurStoryLineId == 0 && ChallengeManager.ChallengeInstance == null)
			{
				LineupManager.SetExtraLineup(ExtraLineupType.LineupNone, new List<int>());
				if (LineupManager.GetCurLineup().IsExtraLineup())
				{
					await LineupManager.SetCurLineup(0);
				}
			}
			foreach (KeyValuePair<int, March7thHoney.Database.Lineup.LineupInfo> lineup in LineupManager.LineupData.Lineups)
			{
				if (lineup.Value.BaseAvatars.Count >= 5)
				{
					lineup.Value.BaseAvatars = lineup.Value.BaseAvatars.GetRange(0, 4);
				}
				foreach (LineupAvatarInfo baseAvatar in lineup.Value.BaseAvatars)
				{
					if (baseAvatar.BaseAvatarId <= 10000)
					{
						continue;
					}
					GameData.SpecialAvatarData.TryGetValue(baseAvatar.BaseAvatarId, out SpecialAvatarExcel value);
					if (value != null)
					{
						baseAvatar.SpecialAvatarId = value.SpecialAvatarID;
						baseAvatar.BaseAvatarId = value.AvatarID;
						continue;
					}
					GameData.SpecialAvatarData.TryGetValue(baseAvatar.BaseAvatarId * 10 + Data.WorldLevel, out value);
					if (value != null)
					{
						baseAvatar.SpecialAvatarId = value.SpecialAvatarID;
						baseAvatar.BaseAvatarId = value.AvatarID;
					}
				}
			}
			foreach (LineupAvatarInfo baseAvatar2 in LineupManager.GetCurLineup().BaseAvatars)
			{
				FormalAvatarInfo formalAvatar = AvatarManager.GetFormalAvatar(baseAvatar2.BaseAvatarId);
				if (formalAvatar != null && formalAvatar.CurrentHp <= 0)
				{
					formalAvatar.CurrentHp = 2000;
				}
			}
		}
		await LoadScene(Data.PlaneId, Data.FloorId, Data.EntryId, Data.Pos, Data.Rot, sendPacket: false);
		if (SceneInstance == null)
		{
			await EnterScene(2000101, 0, sendPacket: false);
		}
		PluginEvent.InvokeOnPlayerLogin(this);
	}

	public void OnLogoutAsync()
	{
		PluginEvent.InvokeOnPlayerLogout(this);
	}

	public async ValueTask SendPacket(BasePacket packet)
	{
		if (Connection?.IsOnline ?? false)
		{
			await Connection.SendPacket(packet);
		}
	}

	public async ValueTask SetPlayerHeadFrameId(uint headFrameId, long expireTime)
	{
		Data.HeadFrame = new PlayerHeadFrameInfo
		{
			HeadFrameId = headFrameId,
			HeadFrameExpireTime = expireTime
		};
		await SendPacket(new PacketPlayerSyncScNotify(new List<BaseSyncData>(1)
		{
			new PlayerBoardSync(this)
		}));
	}

	public async ValueTask ChangeAvatarPathType(int baseAvatarId, MultiPathAvatarTypeEnum type)
	{
		if (baseAvatarId == 8001)
		{
			int num = (int)type + (int)Data.CurrentGender - 1;
			if (Data.CurBasicType == num)
			{
				return;
			}
			Data.CurBasicType = num;
			FormalAvatarInfo avatar = AvatarManager.GetHero();
			avatar.AvatarId = num;
			avatar.ValidateHero(Data.CurrentGender);
			avatar.SetCurSp(0, LineupManager.GetCurLineup().IsExtraLineup());
			avatar.CheckPathSkillTree();
			await SendPacket(new PacketAvatarPathChangedNotify(8001u, (MultiPathAvatarType)num));
			await SendPacket(new PacketPlayerSyncScNotify(AvatarManager.GetHero()));
		}
		else
		{
			FormalAvatarInfo avatar = AvatarManager.GetFormalAvatar(baseAvatarId);
			avatar.AvatarId = (int)type;
			avatar.SetCurSp(0, LineupManager.GetCurLineup().IsExtraLineup());
			avatar.CheckPathSkillTree();
			await SendPacket(new PacketAvatarPathChangedNotify((uint)baseAvatarId, (MultiPathAvatarType)type));
			await SendPacket(new PacketPlayerSyncScNotify(avatar));
		}
		if (SceneInstance != null)
		{
			AvatarSceneInfo avatarSceneInfo = SceneInstance.AvatarInfo.Values.FirstOrDefault((AvatarSceneInfo x) => x.AvatarInfo.BaseAvatarId == baseAvatarId);
			if (avatarSceneInfo != null)
			{
				await avatarSceneInfo.ClearAllBuff();
			}
		}
	}

	public async ValueTask ChangeAvatarSkin(int avatarId, int skinId)
	{
		PlayerUnlockData.Skins.TryGetValue(avatarId, out List<int> value);
		if (value != null && (value.Contains(skinId) || skinId == 0))
		{
			FormalAvatarInfo formalAvatar = AvatarManager.GetFormalAvatar(avatarId);
			formalAvatar.GetPathInfo(avatarId).Skin = skinId;
			await SendPacket(new PacketPlayerSyncScNotify(formalAvatar));
		}
	}

	public async ValueTask<FormalAvatarInfo> MarkAvatar(int avatarId, bool isMarked, bool sendPacket = true)
	{
		FormalAvatarInfo avatar = AvatarManager.GetFormalAvatar(avatarId);
		avatar.IsMarked = isMarked;
		if (sendPacket)
		{
			await SendPacket(new PacketPlayerSyncScNotify(avatar));
		}
		return avatar;
	}

	public async ValueTask AddAvatar(int avatarId, bool sync = true, bool notify = true)
	{
		await AvatarManager.AddAvatar(avatarId, sync, notify);
	}

	public async ValueTask SpendStamina(int staminaCost)
	{
		Data.Stamina -= staminaCost;
		await SendPacket(new PacketStaminaInfoScNotify(this));
	}

	public void OnAddExp()
	{
		GameData.PlayerLevelConfigData.TryGetValue(Data.Level, out PlayerLevelConfigExcel value);
		GameData.PlayerLevelConfigData.TryGetValue(Data.Level + 1, out PlayerLevelConfigExcel value2);
		if (value == null || value2 == null)
		{
			return;
		}
		int num = value2.PlayerExp - value.PlayerExp;
		while (Data.Exp >= num)
		{
			Data.Exp -= num;
			Data.Level++;
			GameData.PlayerLevelConfigData.TryGetValue(Data.Level, out value);
			GameData.PlayerLevelConfigData.TryGetValue(Data.Level + 1, out value2);
			if (value == null || value2 == null)
			{
				break;
			}
			num = value2.PlayerExp - value.PlayerExp;
		}
		OnLevelChange();
	}

	public void OnLevelChange()
	{
		if (!ConfigManager.Config.ServerOption.AutoUpgradeWorldLevel)
		{
			return;
		}
		int num = 0;
		foreach (int item in GameConstants.UpgradeWorldLevel)
		{
			if (item <= Data.Level)
			{
				num++;
			}
		}
		if (Data.WorldLevel != num)
		{
			Data.WorldLevel = num;
		}
	}

	public async ValueTask OnStaminaRecover()
	{
		bool flag = false;
		while (Data.NextStaminaRecover <= Extensions.GetUnixSec())
		{
			if (Data.Stamina >= 300)
			{
				if (Data.StaminaReserve >= 2400.0)
				{
					break;
				}
				Data.StaminaReserve = Math.Min(Data.StaminaReserve + 1.0, 2400.0);
			}
			else
			{
				Data.Stamina++;
			}
			Data.NextStaminaRecover += ((Data.Stamina >= 300) ? 1080 : 360);
			flag = true;
		}
		if (flag)
		{
			await SendPacket(new PacketStaminaInfoScNotify(this));
		}
	}

	public async ValueTask OnHeartBeat()
	{
		await OnStaminaRecover();
		PluginEvent.InvokeOnPlayerHeartBeat(this);
		if (MissionManager != null)
		{
			await MissionManager.HandleAllFinishType();
		}
		if (SceneInstance != null)
		{
			await SceneInstance.OnHeartBeat();
		}
		if (OfferingManager != null)
		{
			await OfferingManager.UpdateOfferingData();
		}
		DatabaseHelper.ToSaveUidList.SafeAdd(Uid);
	}

	public T GetComponent<T>() where T : BasePlayerComponent
	{
		return Components.OfType<T>().FirstOrDefault() ?? throw new InvalidOperationException($"Component {typeof(T)} not found.");
	}

	public PlayerBasicInfo ToProto()
	{
		return Data.ToProto();
	}

	public PlayerSimpleInfo ToSimpleProto()
	{
		return Data.ToSimpleProto(FriendOnlineStatus.Online);
	}

	public async ValueTask OnMove()
	{
		if (SceneInstance != null && SceneInstance.GetNearestSpring(25000000L) != null)
		{
			LineupManager? lineupManager = LineupManager;
			if (lineupManager != null && lineupManager.GetCurLineup()?.Heal(10000, allowRevive: true) == true)
			{
				await SendPacket(new PacketSyncLineupNotify(LineupManager.GetCurLineup()));
			}
		}
	}

	public async ValueTask<EntityProp?> InteractProp(int propEntityId, int interactId)
	{
		if (SceneInstance == null)
		{
			return null;
		}
		SceneInstance.Entities.TryGetValue(propEntityId, out BaseGameEntity value);
		EntityProp prop = value as EntityProp;
		if (prop == null)
		{
			return null;
		}
		GameData.InteractConfigData.TryGetValue(interactId, out InteractConfigExcel config);
		if (config == null || config.SrcState != prop.State)
		{
			return prop;
		}
		PropStateEnum oldState = prop.State;
		await prop.SetState(config.TargetState);
		PropStateEnum newState = prop.State;
		switch (prop.Excel.PropType)
		{
		case PropTypeEnum.PROP_TREASURE_CHEST:
		{
			if (oldState != PropStateEnum.ChestClosed || newState != PropStateEnum.ChestUsed)
			{
				break;
			}
			List<ItemData> items = DropService.CalculateDropsFromProp(prop.PropInfo.ChestID);
			await InventoryManager.AddItems(items);
			await SendPacket(new PacketOpenChestScNotify(prop.PropInfo.ChestID));
			bool flag = false;
			foreach (List<SceneMarkedChestData> value3 in SceneData.MarkedChestData.Values)
			{
				SceneMarkedChestData sceneMarkedChestData = value3.Find((SceneMarkedChestData x) => x.FloorId == SceneInstance.FloorId && x.GroupId == prop.GroupId && x.ConfigId == prop.PropInfo.ID);
				if (sceneMarkedChestData != null)
				{
					value3.Remove(sceneMarkedChestData);
					flag = true;
				}
			}
			if (flag)
			{
				await SendPacket(new PacketMarkChestChangedScNotify(this));
			}
			break;
		}
		case PropTypeEnum.PROP_DESTRUCT:
			if (newState == PropStateEnum.Closed)
			{
				await prop.SetState(PropStateEnum.Open);
			}
			break;
		case PropTypeEnum.PROP_MAZE_JIGSAW:
			switch (newState)
			{
			case PropStateEnum.Closed:
				foreach (EntityProp item in SceneInstance.GetEntitiesInGroup<EntityProp>(prop.GroupId))
				{
					if (item.Excel.PropType == PropTypeEnum.PROP_TREASURE_CHEST)
					{
						await item.SetState(PropStateEnum.ChestClosed);
					}
					else if (item.Excel.PropType != prop.Excel.PropType)
					{
						await item.SetState(PropStateEnum.Open);
					}
				}
				break;
			case PropStateEnum.Open:
				foreach (EntityProp item2 in from p in SceneInstance.GetEntitiesInGroup<EntityProp>(prop.GroupId)
					where p.Excel.PropType != PropTypeEnum.PROP_TREASURE_CHEST && p.Excel.PropType != prop.Excel.PropType
					select p)
				{
					await item2.SetState(PropStateEnum.Open);
				}
				break;
			}
			break;
		case PropTypeEnum.PROP_MAZE_PUZZLE:
			if ((uint)newState > 1u)
			{
				break;
			}
			foreach (EntityProp item3 in SceneInstance.GetEntitiesInGroup<EntityProp>(prop.GroupId))
			{
				if (item3.Excel.PropType == PropTypeEnum.PROP_TREASURE_CHEST)
				{
					await item3.SetState(PropStateEnum.ChestClosed);
				}
				else if (item3.Excel.PropType != prop.Excel.PropType)
				{
					await item3.SetState(PropStateEnum.Open);
				}
				await MissionManager.OnPlayerInteractWithProp();
			}
			break;
		case PropTypeEnum.PROP_ORDINARY:
			if (prop.PropInfo.CommonConsole)
			{
				foreach (EntityProp item4 in SceneInstance.GetEntitiesInGroup<EntityProp>(prop.GroupId))
				{
					await item4.SetState(newState);
					await MissionManager.OnPlayerInteractWithProp();
				}
			}
			if (prop.Excel.ID == 104039)
			{
				foreach (EntityProp item5 in SceneInstance.GetEntitiesInGroup<EntityProp>(prop.GroupId))
				{
					await item5.SetState(newState);
				}
				await MissionManager.OnPlayerInteractWithProp();
			}
			if (!prop.PropInfo.Name.Contains("Piece") || !(from p in SceneInstance.GetEntitiesInGroup<EntityProp>(prop.GroupId)
				where p.PropInfo.Name.Contains("Piece")
				select p).All((EntityProp p) => p.State == PropStateEnum.Closed))
			{
				break;
			}
			foreach (EntityProp item6 in from p in SceneInstance.GetEntitiesInGroup<EntityProp>(prop.GroupId)
				where p.PropInfo.Name.Contains("JigsawSir") && p.State != PropStateEnum.Closed
				select p)
			{
				await item6.SetState(PropStateEnum.TriggerEnable);
			}
			break;
		}
		if (prop.PropInfo.UnlockDoorID.Count > 0)
		{
			foreach (EntityProp item7 in prop.PropInfo.UnlockDoorID.SelectMany<KeyValuePair<int, List<int>>, EntityProp>((KeyValuePair<int, List<int>> id) => from p in SceneInstance.GetEntitiesInGroup<EntityProp>(id.Key)
				where id.Value.Contains(p.PropInfo.ID)
				select p))
			{
				await item7.SetState(PropStateEnum.Open);
				await MissionManager.OnPlayerInteractWithProp();
			}
		}
		await MissionManager.OnPlayerInteractWithProp();
		InventoryManager.HandlePlaneEvent(prop.PropInfo.EventID);
		PluginEvent.InvokeOnPlayerInteract(this, prop);
		string text = prop.PropInfo.Name.Replace("Controller_", "");
		string key = "FSV_ML" + text + ((config.TargetState == PropStateEnum.Open) ? "Started" : "Complete");
		if (prop.Group.GroupName.Contains("JigsawPuzzle") && prop.Group.GroupName.Contains("MainLine"))
		{
			string[] array = prop.Group.GroupName.Split('_');
			key = "JG_ML_" + array[3] + "_Puzzle" + ((config.TargetState == PropStateEnum.Open) ? "Started" : "Complete");
		}
		if (SceneInstance?.FloorInfo?.FloorSavedValue.Find((FloorSavedValueInfo x) => x.Name == key) != null)
		{
			int plane = SceneInstance.PlaneId;
			int floor = SceneInstance.FloorId;
			SceneData.FloorSavedData.TryGetValue(floor, out Dictionary<string, int> value2);
			if (value2 == null)
			{
				value2 = new Dictionary<string, int>();
				SceneData.FloorSavedData[floor] = value2;
			}
			value2[key] = 1;
			await SendPacket(new PacketUpdateFloorSavedValueNotify(key, 1, this));
			TaskManager?.SceneTaskTrigger.TriggerFloor(plane, floor);
			MissionManager?.HandleFinishType(MissionFinishTypeEnum.FloorSavedValue);
		}
		if (prop.PropInfo.IsLevelBtn)
		{
			await prop.SetState(PropStateEnum.Closed);
		}
		return prop;
	}

	public async ValueTask SetPropTimeline(int propEntityId, PropTimelineInfo info)
	{
		if (SceneInstance == null)
		{
			return;
		}
		SceneInstance.Entities.TryGetValue(propEntityId, out BaseGameEntity value);
		if (value is EntityProp entityProp)
		{
			ScenePropTimelineData scenePropTimelineData = new ScenePropTimelineData
			{
				BoolValue = info.TimelineBoolValue,
				ByteValue = info.TimelineByteValue.ToBase64()
			};
			SceneData.PropTimelineData.TryGetValue(Data.FloorId, out Dictionary<int, Dictionary<int, ScenePropTimelineData>> value2);
			if (value2 == null)
			{
				value2 = new Dictionary<int, Dictionary<int, ScenePropTimelineData>>();
				SceneData.PropTimelineData[Data.FloorId] = value2;
			}
			if (!value2.ContainsKey(entityProp.GroupId))
			{
				value2[entityProp.GroupId] = new Dictionary<int, ScenePropTimelineData>();
			}
			value2[entityProp.GroupId][entityProp.PropInfo.ID] = scenePropTimelineData;
			entityProp.PropTimelineData = scenePropTimelineData;
			await MissionManager.HandleFinishType(MissionFinishTypeEnum.TimeLineSetState);
			await MissionManager.HandleFinishType(MissionFinishTypeEnum.TimeLineSetStateCnt);
		}
	}

	public ScenePropTimelineData? GetScenePropTimelineData(int floorId, int groupId, int propId)
	{
		SceneData.PropTimelineData.TryGetValue(floorId, out Dictionary<int, Dictionary<int, ScenePropTimelineData>> value);
		if (value == null)
		{
			return null;
		}
		value.TryGetValue(groupId, out var value2);
		if (value2 == null)
		{
			return null;
		}
		value2.TryGetValue(propId, out var value3);
		return value3;
	}

	public async ValueTask<bool> EnterScene(int entryId, int teleportId, bool sendPacket, int storyLineId = 0, bool mapTp = false)
	{
		int? beforeStoryLineId = StoryLineManager?.StoryLineData.CurStoryLineId;
		if (storyLineId != StoryLineManager?.StoryLineData.CurStoryLineId)
		{
			if (StoryLineManager != null)
			{
				await StoryLineManager.EnterStoryLine(storyLineId, entryId == 0);
			}
			mapTp = false;
		}
		GameData.MapEntranceData.TryGetValue(entryId, out MapEntranceExcel entrance);
		if (entrance == null)
		{
			return false;
		}
		GameData.GetFloorInfo(entrance.PlaneID, entrance.FloorID, out FloorInfo outer);
		int groupId = entrance.StartGroupID;
		int num = entrance.StartAnchorID;
		if (teleportId != 0)
		{
			outer.CachedTeleports.TryGetValue(teleportId, out PropInfo value);
			if (value != null)
			{
				groupId = value.AnchorGroupID;
				num = value.AnchorID;
			}
		}
		else if (num == 0)
		{
			groupId = outer.StartGroupID;
			num = outer.StartAnchorID;
		}
		AnchorInfo anchor = outer.GetAnchorInfo(groupId, num);
		await MissionManager.HandleFinishType(MissionFinishTypeEnum.EnterMapByEntrance, entrance);
		int beforeEntryId = Data.EntryId;
		await LoadScene(entrance.PlaneID, entrance.FloorID, entryId, anchor.ToPositionProto(), anchor.ToRotationProto(), sendPacket, mapTp);
		int entryId2 = Data.EntryId;
		return beforeEntryId != entryId2 || beforeStoryLineId != storyLineId;
	}

	public async ValueTask EnterSceneByEntranceId(int entranceId, int anchorGroupId, int anchorId, bool sendPacket)
	{
		GameData.MapEntranceData.TryGetValue(entranceId, out MapEntranceExcel value);
		if (value != null)
		{
			GameData.GetFloorInfo(value.PlaneID, value.FloorID, out FloorInfo outer);
			int groupId = ((anchorGroupId == 0) ? value.StartGroupID : anchorGroupId);
			int num = ((anchorId == 0) ? value.StartAnchorID : anchorId);
			if (num == 0)
			{
				groupId = outer.StartGroupID;
				num = outer.StartAnchorID;
			}
			AnchorInfo anchorInfo = outer.GetAnchorInfo(groupId, num);
			await LoadScene(value.PlaneID, value.FloorID, entranceId, anchorInfo.ToPositionProto(), anchorInfo.ToRotationProto(), sendPacket);
		}
	}

	public async ValueTask MoveTo(Position position)
	{
		Data.Pos = position;
		await SendPacket(new PacketSceneEntityMoveScNotify(this));
	}

	public void MoveTo(EntityMotion motion)
	{
		Data.Pos = motion.Motion.Pos.ToPosition();
		Data.Rot = motion.Motion.Rot.ToPosition();
	}

	public async ValueTask MoveTo(Position pos, Position rot)
	{
		Data.Pos = pos;
		Data.Rot = rot;
		await SendPacket(new PacketSceneEntityMoveScNotify(this));
	}

	public async ValueTask LoadScene(int planeId, int floorId, int entryId, Position pos, Position rot, bool sendPacket, bool mapTp = false)
	{
		GameData.MazePlaneData.TryGetValue(planeId, out MazePlaneExcel plane);
		if (plane == null)
		{
			return;
		}
		if (plane.PlaneType == PlaneTypeEnum.Raid && RaidManager.RaidData.CurRaidId == 0)
		{
			await EnterScene(2000101, 0, sendPacket);
			return;
		}
		if (plane.PlaneType == PlaneTypeEnum.Challenge && ChallengeManager.ChallengeInstance == null && entryId != 100000103 && entryId != 1030402 && entryId != 100000352 && entryId != 102020107)
		{
			await EnterScene(100000103, 0, sendPacket);
			return;
		}
		Data.Pos = pos;
		Data.Rot = rot;
		bool notSendMove = true;
		if (planeId != Data.PlaneId || floorId != Data.FloorId || entryId != Data.EntryId || SceneInstance == null || !mapTp)
		{
			if (SceneInstance != null)
			{
				await SceneInstance.OnDestroy();
			}
			SceneInstance sceneInstance = new SceneInstance(this, plane, floorId, entryId);
			PluginEvent.InvokeOnPlayerLoadScene(this, sceneInstance);
			SceneInstance = sceneInstance;
			await sceneInstance.SyncLineup(notSendPacket: true);
			Data.PlaneId = planeId;
			Data.FloorId = floorId;
			Data.EntryId = entryId;
		}
		else
		{
			StoryLineManager? storyLineManager = StoryLineManager;
			if (storyLineManager != null && storyLineManager.StoryLineData.CurStoryLineId == 0 && mapTp)
			{
				notSendMove = false;
			}
		}
		if (MissionManager != null)
		{
			await MissionManager.OnPlayerChangeScene();
		}
		Connection?.SendPacket(1413);
		if (sendPacket && notSendMove)
		{
			await SendPacket(new PacketEnterSceneByServerScNotify(SceneInstance));
		}
		else if (sendPacket && !notSendMove)
		{
			await SendPacket(new PacketSceneEntityMoveScNotify(this));
		}
		if (MissionManager != null)
		{
			await MissionManager.HandleFinishType(MissionFinishTypeEnum.EnterFloor);
			await MissionManager.HandleFinishType(MissionFinishTypeEnum.EnterPlane);
			await MissionManager.HandleFinishType(MissionFinishTypeEnum.NotInFloor);
			await MissionManager.HandleFinishType(MissionFinishTypeEnum.NotInPlane);
		}
	}

	public ScenePropData? GetScenePropData(int floorId, int groupId, int propId)
	{
		if (SceneData != null && SceneData.ScenePropData.TryGetValue(floorId, out Dictionary<int, List<ScenePropData>> value) && value.TryGetValue(groupId, out var value2))
		{
			return value2.Find((ScenePropData x) => x.PropId == propId);
		}
		return null;
	}

	public void SetScenePropData(int floorId, int groupId, int propId, PropStateEnum state)
	{
		if (SceneData != null)
		{
			if (!SceneData.ScenePropData.TryGetValue(floorId, out Dictionary<int, List<ScenePropData>> value))
			{
				value = new Dictionary<int, List<ScenePropData>>();
				SceneData.ScenePropData.Add(floorId, value);
			}
			if (!value.TryGetValue(groupId, out var value2))
			{
				value2 = new List<ScenePropData>();
				value.Add(groupId, value2);
			}
			ScenePropData scenePropData = value2.Find((ScenePropData x) => x.PropId == propId);
			if (scenePropData == null)
			{
				scenePropData = new ScenePropData
				{
					PropId = propId,
					State = state
				};
				value2.Add(scenePropData);
			}
			else
			{
				scenePropData.State = state;
			}
		}
	}

	public void EnterSection(int sectionId)
	{
		if (SceneInstance != null)
		{
			SceneData.UnlockSectionIdList.TryGetValue(SceneInstance.FloorId, out List<int> value);
			if (value == null)
			{
				int num = 1;
				List<int> list = new List<int>(num);
				CollectionsMarshal.SetCount(list, num);
				CollectionsMarshal.AsSpan(list)[0] = sectionId;
				value = list;
				SceneData.UnlockSectionIdList.Add(SceneInstance.FloorId, value);
			}
			else
			{
				SceneData.UnlockSectionIdList[SceneInstance.FloorId].Add(sectionId);
			}
		}
	}

	public void SetCustomSaveData(int entryId, int groupId, string data)
	{
		if (SceneData != null)
		{
			if (!SceneData.CustomSaveData.TryGetValue(entryId, out Dictionary<int, string> value))
			{
				value = new Dictionary<int, string>();
				SceneData.CustomSaveData.Add(entryId, value);
			}
			value[groupId] = data;
		}
	}

	public async ValueTask ForceQuitBattle()
	{
		if (BattleInstance != null)
		{
			BattleInstance = null;
			await Connection.SendPacket(163);
		}
	}
}
