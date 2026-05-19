using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using March7thHoney.Configuration;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database;
using March7thHoney.Database.Player;
using March7thHoney.Database.Quests;
using March7thHoney.Database.TrainCakeCatch;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Game.Quest;
using March7thHoney.GameServer.Server;
using March7thHoney.GameServer.Server.Packet.Send.PlayerSync;
using March7thHoney.Kcp;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.TrainCakeCatch;

public class TrainCakeCatchManager : BasePlayerManager
{
	[RequiredMember]
	private sealed class SocialPlayReturnScene
	{
		[RequiredMember]
		public int PlaneId { get; init; }

		[RequiredMember]
		public int FloorId { get; init; }

		[RequiredMember]
		public int EntryId { get; init; }

		[RequiredMember]
		public Position Pos { get; init; }

		[RequiredMember]
		public Position Rot { get; init; }

		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public SocialPlayReturnScene()
		{
		}
	}

	[RequiredMember]
	private sealed class SocialPlayRoom
	{
		[RequiredMember]
		public uint OwnerUid { get; init; }

		public HashSet<int> Members { get; } = new HashSet<int>();

		public Dictionary<int, MACJBIAFNOI> Motions { get; } = new Dictionary<int, MACJBIAFNOI>();

		public Dictionary<int, List<MACJBIAFNOI>> MotionHistory { get; } = new Dictionary<int, List<MACJBIAFNOI>>();

		public List<EHKEJEPNGMB> ArrivalHistory { get; } = new List<EHKEJEPNGMB>();

		public SocialPlaySceneContext? SceneContext { get; set; }

		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public SocialPlayRoom()
		{
		}
	}

	[RequiredMember]
	public sealed class SocialPlaySceneContext
	{
		[RequiredMember]
		public int PlaneId { get; init; }

		[RequiredMember]
		public int FloorId { get; init; }

		[RequiredMember]
		public int EntryId { get; init; }

		[RequiredMember]
		public Position Pos { get; init; }

		[RequiredMember]
		public Position Rot { get; init; }

		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public SocialPlaySceneContext()
		{
		}
	}

	private static readonly object RoomLock = new object();

	private static readonly ConcurrentDictionary<uint, SocialPlayRoom> Rooms = new ConcurrentDictionary<uint, SocialPlayRoom>();

	private const int JoinedRoomGameplayType = 550;

	private const int OwnRoomGameplayType = 4650;

	private const int MaxBufferedMotionsPerPlayer = 20;

	public TrainCakeCatchData Data { get; }

	public uint? CurrentRoomOwnerUid { get; private set; }

	public uint? PendingRoomOwnerUid { get; private set; }

	private SocialPlayReturnScene? ReturnScene { get; set; }

	public TrainCakeCatchManager(PlayerInstance player)
	{
		Data = DatabaseHelper.Instance.GetInstanceOrCreateNew<TrainCakeCatchData>(player.Uid);
		base._002Ector(player);
	}

	private static int GetConst(string name, int fallback)
	{
		if (GameData.CakeCatchConstValueData.TryGetValue(name, out CakeCatchConstValueCommonExcel value))
		{
			int? intValue = value.Value.IntValue;
			if (intValue.HasValue)
			{
				return intValue.GetValueOrDefault();
			}
		}
		return fallback;
	}

	private static long WeekEndUnixSec()
	{
		DateTimeOffset now = DateTimeOffset.Now;
		int num = (0 - now.DayOfWeek + 7) % 7;
		return new DateTimeOffset(now.Date.AddDays(num).AddDays(1.0).AddSeconds(-1.0), now.Offset).ToUnixTimeSeconds();
	}

	private static long NextDayUnixSec()
	{
		DateTimeOffset now = DateTimeOffset.Now;
		return new DateTimeOffset(now.Date.AddDays(1.0), now.Offset).ToUnixTimeSeconds();
	}

	public void EnsureDefaults()
	{
		EnsureDefaults(Data, base.Player.Uid);
	}

	private void EnsureDefaults(TrainCakeCatchData target, int targetUid)
	{
		bool flag = false;
		long unixSec = Extensions.GetUnixSec();
		if (target.RefreshTime == 0L)
		{
			target.RefreshTime = WeekEndUnixSec();
			flag = true;
		}
		if (target.DailyRefreshTime == 0L)
		{
			target.DailyRefreshTime = NextDayUnixSec();
			flag = true;
		}
		if (target.DailyRefreshTime <= unixSec)
		{
			target.DailyRefreshTime = NextDayUnixSec();
			target.AvailableSearchCount = 1;
			flag = true;
		}
		if (target.SearchCreatureIds.SequenceEqual(new _003C_003Ez__ReadOnlyArray<int>(new int[5] { 1, 2, 3, 4, 5 })) && target.CollectedCreatures.Count == 0 && target.AvailableSearchCount == 0)
		{
			target.SearchCreatureIds.Clear();
			flag = true;
		}
		if (target.AvailableSearchCount == 0 && target.SearchCreatureIds.Count == 0)
		{
			target.AvailableSearchCount = 1;
			flag = true;
		}
		if (flag | SyncCollectedCreatures(target))
		{
			DatabaseHelper.ToSaveUidList.Add(targetUid);
		}
	}

	public TrainCakeCatchGetDataScRsp ToGetDataProto()
	{
		return ToGetDataProto(CurrentRoomOwnerUid);
	}

	public TrainCakeCatchGetDataScRsp ToGetDataProto(uint? roomOwnerUid)
	{
		(uint, TrainCakeCatchData) tuple = ResolveRoomView(roomOwnerUid);
		EnsureDefaults(tuple.Item2, (int)tuple.Item1);
		EnsureDefaults();
		MKHIPFHEKCK fMECAHALPKG;
		lock (RoomLock)
		{
			fMECAHALPKG = (Rooms.TryGetValue(tuple.Item1, out SocialPlayRoom value) ? BuildSocialPlayRoomDataLocked(value, tuple.Item1, (uint)base.Player.Uid) : BuildSocialPlayRoomData(tuple.Item1, (uint)base.Player.Uid));
		}
		TrainCakeCatchGetDataScRsp trainCakeCatchGetDataScRsp = new TrainCakeCatchGetDataScRsp
		{
			DHLGCEGONIB = tuple.Item2.RefreshTime,
			PEOECDDANNP = BuildDiyProto(tuple.Item2),
			FMECAHALPKG = fMECAHALPKG,
			PEPMFGLDGOH = new FAOPPAFAJLO(),
			HJOFGOINOAK = new LLKEMMMEPOB
			{
				EHLIFHPILPG = (uint)Math.Max(0, Data.AvailableSearchCount),
				FIHMHJHGHOG = Data.DailyRefreshTime
			}
		};
		trainCakeCatchGetDataScRsp.PerformanceIdList.AddRange(from x in GetUnlockedPerformanceIds(Data)
			select (uint)x);
		trainCakeCatchGetDataScRsp.AFEJACMLOLH.AddRange(tuple.Item2.CatTreeSlots.Select((CakeTreeSlotInfo x) => new NPLEDHFMFDM
		{
			HCJPDNDOHAM = (uint)x.CreatureId,
			Slot = (uint)x.Slot
		}));
		foreach (CakeCreatureInventoryInfo collectedCreature in GetCollectedCreatures(Data))
		{
			trainCakeCatchGetDataScRsp.BLEDIOOJPNL.Add(new PKILNDNCAMI
			{
				HCJPDNDOHAM = (uint)collectedCreature.CreatureId,
				Count = (uint)collectedCreature.Count
			});
		}
		foreach (int searchCreatureId in Data.SearchCreatureIds)
		{
			trainCakeCatchGetDataScRsp.KALIBGCODNF.Add(new LGGABHPGPDD
			{
				HCJPDNDOHAM = (uint)searchCreatureId
			});
		}
		return trainCakeCatchGetDataScRsp;
	}

	public uint GetGameplayType(uint roomOwnerUid, uint roomPlayerUid)
	{
		if (roomOwnerUid != roomPlayerUid)
		{
			return 550u;
		}
		return 4650u;
	}

	public long GetRoomRefreshTime(uint? roomOwnerUid = null)
	{
		(uint, TrainCakeCatchData) tuple = ResolveRoomView(roomOwnerUid);
		EnsureDefaults(tuple.Item2, (int)tuple.Item1);
		return tuple.Item2.RefreshTime;
	}

	public async ValueTask<MKHIPFHEKCK> EnterSocialPlayRoomAsync(uint roomOwnerUid)
	{
		MACJBIAFNOI motion = CreateMotion(base.Player.Data.Pos, base.Player.Data.Rot, isSelf: true);
		List<int> remainingMembers = new List<int>();
		uint? num = null;
		List<int> existingMembers;
		MKHIPFHEKCK snapshot;
		lock (RoomLock)
		{
			if (CurrentRoomOwnerUid == roomOwnerUid && Rooms.TryGetValue(roomOwnerUid, out SocialPlayRoom value) && value.Members.Contains(base.Player.Uid))
			{
				RecordMotionLocked(value, base.Player.Uid, motion);
				PendingRoomOwnerUid = null;
				return BuildSocialPlayRoomDataLocked(value, roomOwnerUid, (uint)base.Player.Uid);
			}
			uint? currentRoomOwnerUid = CurrentRoomOwnerUid;
			if (currentRoomOwnerUid.HasValue)
			{
				uint valueOrDefault = currentRoomOwnerUid.GetValueOrDefault();
				num = valueOrDefault;
				if (Rooms.TryGetValue(valueOrDefault, out SocialPlayRoom value2))
				{
					remainingMembers = value2.Members.Where((int uid) => uid != base.Player.Uid).ToList();
				}
				LeaveSocialPlayRoomInternal(valueOrDefault, base.Player.Uid);
			}
			else
			{
				BookmarkReturnScene();
			}
			SocialPlayRoom orAdd = Rooms.GetOrAdd(roomOwnerUid, (uint ownerUid) => new SocialPlayRoom
			{
				OwnerUid = ownerUid
			});
			existingMembers = orAdd.Members.Where((int uid) => uid != base.Player.Uid).ToList();
			orAdd.Members.Add(base.Player.Uid);
			RecordMotionLocked(orAdd, base.Player.Uid, motion);
			if (roomOwnerUid != (uint)base.Player.Uid)
			{
				AppendArrivalHistoryLocked(orAdd, base.Player.Uid, base.Player.Data.Name ?? string.Empty);
			}
			CurrentRoomOwnerUid = roomOwnerUid;
			PendingRoomOwnerUid = null;
			snapshot = BuildSocialPlayRoomDataLocked(orAdd, roomOwnerUid, (uint)base.Player.Uid);
		}
		if (num.HasValue)
		{
			await NotifyRoomLeaveAsync(num.Value, remainingMembers, roomOwnerUid);
		}
		await NotifyRoomJoinAsync(roomOwnerUid, existingMembers);
		return snapshot;
	}

	public void PrepareSocialPlayRoom(uint roomOwnerUid)
	{
		lock (RoomLock)
		{
			if (!CurrentRoomOwnerUid.HasValue)
			{
				BookmarkReturnScene();
			}
			PendingRoomOwnerUid = ((roomOwnerUid == 0) ? ((uint)base.Player.Uid) : roomOwnerUid);
		}
	}

	public void LeaveSocialPlayRoom()
	{
		List<int> remainingMembers = new List<int>();
		uint? num = null;
		lock (RoomLock)
		{
			uint? currentRoomOwnerUid = CurrentRoomOwnerUid;
			if (!currentRoomOwnerUid.HasValue)
			{
				return;
			}
			uint valueOrDefault = currentRoomOwnerUid.GetValueOrDefault();
			PendingRoomOwnerUid = null;
			num = valueOrDefault;
			if (Rooms.TryGetValue(valueOrDefault, out SocialPlayRoom value))
			{
				remainingMembers = value.Members.Where((int uid) => uid != base.Player.Uid).ToList();
			}
			LeaveSocialPlayRoomInternal(valueOrDefault, base.Player.Uid);
			CurrentRoomOwnerUid = null;
		}
		if (num.HasValue)
		{
			NotifyRoomLeaveAsync(num.Value, remainingMembers);
		}
	}

	public async ValueTask<MKHIPFHEKCK> AttachToSocialPlayRoomAsync(uint roomOwnerUid)
	{
		MACJBIAFNOI motion = CreateMotion(base.Player.Data.Pos, base.Player.Data.Rot, isSelf: true);
		List<int> existingMembers = new List<int>();
		List<int> remainingMembers = new List<int>();
		uint? num = null;
		bool shouldNotifyJoin = false;
		MKHIPFHEKCK snapshot;
		lock (RoomLock)
		{
			if (CurrentRoomOwnerUid == roomOwnerUid)
			{
				SocialPlayRoom orAdd = Rooms.GetOrAdd(roomOwnerUid, (uint ownerUid) => new SocialPlayRoom
				{
					OwnerUid = ownerUid
				});
				existingMembers = orAdd.Members.Where((int uid) => uid != base.Player.Uid).ToList();
				bool flag = orAdd.Members.Contains(base.Player.Uid);
				orAdd.Members.Add(base.Player.Uid);
				RecordMotionLocked(orAdd, base.Player.Uid, motion);
				PendingRoomOwnerUid = null;
				snapshot = BuildSocialPlayRoomDataLocked(orAdd, roomOwnerUid, (uint)base.Player.Uid);
				shouldNotifyJoin = !flag;
			}
			else
			{
				if (!CurrentRoomOwnerUid.HasValue)
				{
					BookmarkReturnScene();
				}
				else
				{
					num = CurrentRoomOwnerUid;
					if (num.HasValue && Rooms.TryGetValue(num.Value, out SocialPlayRoom value))
					{
						remainingMembers = value.Members.Where((int uid) => uid != base.Player.Uid).ToList();
						LeaveSocialPlayRoomInternal(num.Value, base.Player.Uid);
					}
				}
				SocialPlayRoom orAdd2 = Rooms.GetOrAdd(roomOwnerUid, (uint ownerUid) => new SocialPlayRoom
				{
					OwnerUid = ownerUid
				});
				existingMembers = orAdd2.Members.Where((int uid) => uid != base.Player.Uid).ToList();
				orAdd2.Members.Add(base.Player.Uid);
				RecordMotionLocked(orAdd2, base.Player.Uid, motion);
				CurrentRoomOwnerUid = roomOwnerUid;
				PendingRoomOwnerUid = null;
				snapshot = BuildSocialPlayRoomDataLocked(orAdd2, roomOwnerUid, (uint)base.Player.Uid);
				shouldNotifyJoin = true;
			}
		}
		if (num.HasValue)
		{
			await NotifyRoomLeaveAsync(num.Value, remainingMembers, roomOwnerUid);
		}
		if (shouldNotifyJoin)
		{
			await NotifyRoomJoinAsync(roomOwnerUid, existingMembers);
		}
		return snapshot;
	}

	public uint? GetSceneTeleportRoomOwnerUid()
	{
		lock (RoomLock)
		{
			return PendingRoomOwnerUid ?? CurrentRoomOwnerUid;
		}
	}

	public async ValueTask<bool> ReturnToBookedSceneAsync(bool sendPacket)
	{
		PendingRoomOwnerUid = null;
		LeaveSocialPlayRoom();
		if (ReturnScene == null)
		{
			return false;
		}
		SocialPlayReturnScene returnScene = ReturnScene;
		ReturnScene = null;
		await base.Player.LoadScene(returnScene.PlaneId, returnScene.FloorId, returnScene.EntryId, returnScene.Pos, returnScene.Rot, sendPacket);
		return true;
	}

	public SocialPlaySceneContext? GetCurrentRoomSceneContext()
	{
		uint? currentRoomOwnerUid = CurrentRoomOwnerUid;
		if (currentRoomOwnerUid.HasValue)
		{
			uint valueOrDefault = currentRoomOwnerUid.GetValueOrDefault();
			return GetRoomSceneContext(valueOrDefault);
		}
		return null;
	}

	public SocialPlaySceneContext? GetRoomSceneContext(uint roomOwnerUid)
	{
		lock (RoomLock)
		{
			if (!Rooms.TryGetValue(roomOwnerUid, out SocialPlayRoom value))
			{
				return null;
			}
			return (value.SceneContext == null) ? null : new SocialPlaySceneContext
			{
				PlaneId = value.SceneContext.PlaneId,
				FloorId = value.SceneContext.FloorId,
				EntryId = value.SceneContext.EntryId,
				Pos = value.SceneContext.Pos,
				Rot = value.SceneContext.Rot
			};
		}
	}

	public void UpdateCurrentRoomSceneContext()
	{
		uint? currentRoomOwnerUid = CurrentRoomOwnerUid;
		if (!currentRoomOwnerUid.HasValue)
		{
			return;
		}
		uint valueOrDefault = currentRoomOwnerUid.GetValueOrDefault();
		if (base.Player.Data.Pos == null || base.Player.Data.Rot == null || base.Player.Data.PlaneId == 0 || base.Player.Data.FloorId == 0 || base.Player.Data.EntryId == 0)
		{
			return;
		}
		lock (RoomLock)
		{
			if (Rooms.TryGetValue(valueOrDefault, out SocialPlayRoom value) && (value.OwnerUid == (uint)base.Player.Uid || value.SceneContext == null))
			{
				value.SceneContext = new SocialPlaySceneContext
				{
					PlaneId = base.Player.Data.PlaneId,
					FloorId = base.Player.Data.FloorId,
					EntryId = base.Player.Data.EntryId,
					Pos = base.Player.Data.Pos,
					Rot = base.Player.Data.Rot
				};
			}
		}
	}

	public SocialPlayGameplayOperationScNotify? BuildArrivalHistoryNotify(uint roomOwnerUid)
	{
		lock (RoomLock)
		{
			if (!Rooms.TryGetValue(roomOwnerUid, out SocialPlayRoom value) || value.ArrivalHistory.Count == 0)
			{
				return null;
			}
			HMDJNPFBOMM hMDJNPFBOMM = new HMDJNPFBOMM();
			hMDJNPFBOMM.IMBCJKHMOAB.AddRange(value.ArrivalHistory.Select((EHKEJEPNGMB entry) => entry.Clone()));
			return new SocialPlayGameplayOperationScNotify
			{
				MFBDMLPDEOE = roomOwnerUid,
				NCFHGIBCEBG = roomOwnerUid,
				AFCCFJOEIOH = hMDJNPFBOMM
			};
		}
	}

	public async ValueTask BroadcastPlayerStateAsync()
	{
		uint? currentRoomOwnerUid = CurrentRoomOwnerUid;
		if (!currentRoomOwnerUid.HasValue)
		{
			return;
		}
		uint valueOrDefault = currentRoomOwnerUid.GetValueOrDefault();
		HashSet<int> hashSet = new HashSet<int>();
		int? implicitOwnerUid = null;
		MACJBIAFNOI value = null;
		lock (RoomLock)
		{
			if (!Rooms.TryGetValue(valueOrDefault, out SocialPlayRoom value2))
			{
				return;
			}
			value2.Motions.TryGetValue(base.Player.Uid, out value);
			foreach (int item in value2.Members.Where((int uid) => uid != base.Player.Uid))
			{
				hashSet.Add(item);
			}
			if (valueOrDefault != (uint)base.Player.Uid && !value2.Members.Contains((int)valueOrDefault))
			{
				implicitOwnerUid = (int)valueOrDefault;
			}
		}
		TryAddImplicitOwnerRecipient(hashSet, implicitOwnerUid, valueOrDefault, base.Player.Uid);
		if (hashSet.Count == 0)
		{
			return;
		}
		SocialPlayGameplayOperationScNotify playerStateNotify = new SocialPlayGameplayOperationScNotify
		{
			MFBDMLPDEOE = valueOrDefault,
			NCFHGIBCEBG = (uint)base.Player.Uid,
			PEFPFCINABN = BuildSocialPlayPlayer((uint)base.Player.Uid, isSelf: false)
		};
		playerStateNotify.PEFPFCINABN.IACKOCPGIAK = BuildSimpleMotion(value, base.Player.Data.Pos, base.Player.Data.Rot);
		foreach (int item2 in hashSet)
		{
			PlayerInstance playerInstance = Listener.GetActiveConnection(item2)?.Player;
			if (playerInstance != null && playerInstance.Connection?.IsOnline == true)
			{
				BasePacket basePacket = new BasePacket(9662);
				basePacket.SetData(playerStateNotify.Clone());
				await playerInstance.SendPacket(basePacket);
			}
		}
	}

	public MKHIPFHEKCK BuildSocialPlayRoomData(uint roomOwnerUid, uint roomPlayerUid)
	{
		(uint, TrainCakeCatchData) tuple = ResolveRoomView(roomOwnerUid);
		EnsureDefaults(tuple.Item2, (int)tuple.Item1);
		uint gameplayType = GetGameplayType(roomOwnerUid, roomPlayerUid);
		MKHIPFHEKCK mKHIPFHEKCK = new MKHIPFHEKCK();
		mKHIPFHEKCK.MFBDMLPDEOE = roomOwnerUid;
		mKHIPFHEKCK.DFJBNHPAICA = new GFOIOIACDCH
		{
			DMGCIDGKPFF = new MCPPIEJEBEF
			{
				LEKGBMCOJDB = new NKLAFFLJCHG()
			},
			PAIBKOMPFOE = gameplayType,
			KPDHCPCCPNA = new GCOIFAHPGDF
			{
				DHLGCEGONIB = tuple.Item2.RefreshTime,
				GJGAGFEJABC = (uint)Math.Max(1, tuple.Item2.DiyTheme),
				PEOECDDANNP = BuildDiyProto(tuple.Item2)
			}
		};
		if (gameplayType == 4650)
		{
			mKHIPFHEKCK.DFJBNHPAICA.KPDHCPCCPNA.FIHMHJHGHOG = tuple.Item2.DailyRefreshTime;
			mKHIPFHEKCK.DFJBNHPAICA.KPDHCPCCPNA.GIIIBCKEODP = (uint)Math.Max(1, tuple.Item2.CatTreeSlots.Count + 1);
		}
		mKHIPFHEKCK.DFJBNHPAICA.KPDHCPCCPNA.AFEJACMLOLH.Add(tuple.Item2.CatTreeSlots.Select((CakeTreeSlotInfo x) => new NPLEDHFMFDM
		{
			HCJPDNDOHAM = (uint)x.CreatureId,
			Slot = (uint)x.Slot
		}));
		mKHIPFHEKCK.PlayerInfo.Clear();
		if (roomPlayerUid == roomOwnerUid)
		{
			mKHIPFHEKCK.PlayerInfo.Add(BuildPlaceholderSocialPlayPlayer(roomPlayerUid, isSelf: true));
		}
		else
		{
			mKHIPFHEKCK.PlayerInfo.Add(BuildSocialPlayPlayer(roomPlayerUid, isSelf: true));
			mKHIPFHEKCK.PlayerInfo.Add(BuildPlaceholderSocialPlayPlayer(roomOwnerUid, isSelf: false));
		}
		return mKHIPFHEKCK;
	}

	public async ValueTask HandleRoomMovement(MKLFLKDHLIC req)
	{
		uint? currentRoomOwnerUid = CurrentRoomOwnerUid;
		if (!currentRoomOwnerUid.HasValue)
		{
			return;
		}
		uint roomOwnerUid = currentRoomOwnerUid.GetValueOrDefault();
		if (req.IACKOCPGIAK == null)
		{
			return;
		}
		int? implicitOwnerUid = null;
		MACJBIAFNOI motion;
		List<int> otherMembers;
		lock (RoomLock)
		{
			if (!Rooms.TryGetValue(roomOwnerUid, out SocialPlayRoom value))
			{
				return;
			}
			motion = req.IACKOCPGIAK.Clone();
			RecordMotionLocked(value, base.Player.Uid, motion);
			otherMembers = value.Members.Where((int uid) => uid != base.Player.Uid).ToList();
			if (roomOwnerUid != (uint)base.Player.Uid && !value.Members.Contains((int)roomOwnerUid))
			{
				implicitOwnerUid = (int)roomOwnerUid;
			}
		}
		BasePacket basePacket = new BasePacket(9637);
		basePacket.SetData(new IPCKGLOHJLH());
		await base.Player.SendPacket(basePacket);
		SocialPlayRoomPlayerMoveScNotify notify = new SocialPlayRoomPlayerMoveScNotify
		{
			MFBDMLPDEOE = roomOwnerUid,
			NCFHGIBCEBG = (uint)base.Player.Uid,
			FIPIDGKPFHA = new CCKCCKHEFFB
			{
				NCFHGIBCEBG = (uint)base.Player.Uid,
				FIPIDGKPFHA = { motion }
			}
		};
		HashSet<int> hashSet = new HashSet<int>(otherMembers);
		if (roomOwnerUid != (uint)base.Player.Uid)
		{
			TryAddImplicitOwnerRecipient(hashSet, implicitOwnerUid, roomOwnerUid, base.Player.Uid);
		}
		foreach (int item in hashSet)
		{
			PlayerInstance playerInstance = Listener.GetActiveConnection(item)?.Player;
			if (playerInstance != null && playerInstance.Connection?.IsOnline == true)
			{
				BasePacket basePacket2 = new BasePacket(9621);
				basePacket2.SetData(notify.Clone());
				await playerInstance.SendPacket(basePacket2);
			}
		}
	}

	public IReadOnlyList<SocialPlayRoomPlayerMoveScNotify> BuildInitialRoomMoveNotifies(uint roomOwnerUid)
	{
		List<SocialPlayRoomPlayerMoveScNotify> list = new List<SocialPlayRoomPlayerMoveScNotify>();
		lock (RoomLock)
		{
			if (Rooms.TryGetValue(roomOwnerUid, out SocialPlayRoom value))
			{
				foreach (KeyValuePair<int, MACJBIAFNOI> item in from x in value.Motions
					where x.Key != base.Player.Uid
					orderby x.Key
					select x)
				{
					SocialPlayRoomPlayerMoveScNotify socialPlayRoomPlayerMoveScNotify = new SocialPlayRoomPlayerMoveScNotify
					{
						MFBDMLPDEOE = roomOwnerUid,
						NCFHGIBCEBG = (uint)item.Key,
						FIPIDGKPFHA = new CCKCCKHEFFB
						{
							NCFHGIBCEBG = (uint)item.Key
						}
					};
					socialPlayRoomPlayerMoveScNotify.FIPIDGKPFHA.FIPIDGKPFHA.Add(item.Value.Clone());
					list.Add(socialPlayRoomPlayerMoveScNotify);
				}
			}
		}
		return list;
	}

	public MKHIPFHEKCK BuildRoomSnapshotForPlayer(uint roomOwnerUid, uint roomPlayerUid)
	{
		lock (RoomLock)
		{
			SocialPlayRoom value;
			return Rooms.TryGetValue(roomOwnerUid, out value) ? BuildSocialPlayRoomDataLocked(value, roomOwnerUid, roomPlayerUid) : BuildSocialPlayRoomData(roomOwnerUid, roomPlayerUid);
		}
	}

	public async ValueTask BroadcastRoomSnapshotAsync()
	{
		uint? currentRoomOwnerUid = CurrentRoomOwnerUid;
		if (!currentRoomOwnerUid.HasValue)
		{
			return;
		}
		uint roomOwnerUid = currentRoomOwnerUid.GetValueOrDefault();
		List<int> list;
		lock (RoomLock)
		{
			if (!Rooms.TryGetValue(roomOwnerUid, out SocialPlayRoom value))
			{
				return;
			}
			list = value.Members.Where((int uid) => uid != base.Player.Uid).ToList();
		}
		foreach (int item in list)
		{
			PlayerInstance playerInstance = Listener.GetActiveConnection(item)?.Player;
			if (playerInstance != null && playerInstance.Connection?.IsOnline == true)
			{
				BasePacket basePacket = new BasePacket(9662);
				basePacket.SetData(new SocialPlayGameplayOperationScNotify
				{
					MFBDMLPDEOE = roomOwnerUid,
					NCFHGIBCEBG = (uint)item,
					INPEGNFEPAP = BuildRoomSnapshotForPlayer(roomOwnerUid, (uint)item)
				});
				await playerInstance.SendPacket(basePacket);
			}
		}
	}

	public FOFNOBHLKGO BuildDiyProto()
	{
		return BuildDiyProto(Data);
	}

	public FOFNOBHLKGO BuildDiyProto(TrainCakeCatchData source)
	{
		FOFNOBHLKGO fOFNOBHLKGO = new FOFNOBHLKGO();
		fOFNOBHLKGO.MIPPCFJPJDD = (HEAJBHNMJGO)source.DiyTheme;
		fOFNOBHLKGO.OJNJEDBBAJJ.AddRange(source.DiceSlots.Select(delegate(DiyDiceSlotInfo x)
		{
			BIAIKHBFALH bIAIKHBFALH = new BIAIKHBFALH();
			bIAIKHBFALH.DiceSlotId = (uint)x.DiceSlotId;
			bIAIKHBFALH.HGJHIJOGGIN = (uint)x.Index;
			bIAIKHBFALH.GBGDLNNOBID.AddRange(x.Values.Select((int v) => (uint)v));
			return bIAIKHBFALH;
		}));
		fOFNOBHLKGO.LKPGMBDBJFA.AddRange(source.StagePlacements.Select((DiyStagePlacement x) => new GFAHEGCPIEB
		{
			HCJPDNDOHAM = (uint)x.CreatureId,
			Slot = (uint)x.Slot
		}));
		return fOFNOBHLKGO;
	}

	public FOFNOBHLKGO ApplyDiy(FOFNOBHLKGO req)
	{
		EnsureDefaults();
		Data.DiyTheme = (int)req.MIPPCFJPJDD;
		Data.DiceSlots = req.OJNJEDBBAJJ.Select((BIAIKHBFALH x) => new DiyDiceSlotInfo
		{
			DiceSlotId = (int)x.DiceSlotId,
			Index = (int)x.HGJHIJOGGIN,
			Values = x.GBGDLNNOBID.Select((uint v) => (int)v).ToList()
		}).ToList();
		Data.StagePlacements = req.LKPGMBDBJFA.Select((GFAHEGCPIEB x) => new DiyStagePlacement
		{
			CreatureId = (int)x.HCJPDNDOHAM,
			Slot = (int)x.Slot
		}).ToList();
		SyncCollectedCreatures(Data);
		DatabaseHelper.ToSaveUidList.Add(base.Player.Uid);
		return BuildDiyProto();
	}

	public TrainCakeCatchSearchScRsp Search(uint creatureId)
	{
		EnsureDefaults();
		List<int> unlockedPerformanceIds = GetUnlockedPerformanceIds(Data);
		AddCollectedCreature(Data, (int)creatureId);
		if (!Data.SearchCreatureIds.Contains((int)creatureId))
		{
			Data.SearchCreatureIds.Add((int)creatureId);
		}
		if (Data.AvailableSearchCount > 0)
		{
			Data.AvailableSearchCount--;
		}
		List<int> unlockedPerformanceIds2 = GetUnlockedPerformanceIds(Data);
		Data.PerformanceIds = unlockedPerformanceIds2.ToList();
		DatabaseHelper.ToSaveUidList.Add(base.Player.Uid);
		TrainCakeCatchSearchScRsp trainCakeCatchSearchScRsp = new TrainCakeCatchSearchScRsp();
		trainCakeCatchSearchScRsp.HCJPDNDOHAM = creatureId;
		trainCakeCatchSearchScRsp.BLEDIOOJPNL = new PKILNDNCAMI
		{
			HCJPDNDOHAM = creatureId,
			Count = (uint)GetCollectedCreatureCount(Data, (int)creatureId)
		};
		trainCakeCatchSearchScRsp.OMFCGLJDFPD.AddRange(from x in unlockedPerformanceIds2.Except(unlockedPerformanceIds)
			select (uint)x);
		trainCakeCatchSearchScRsp.KALIBGCODNF.AddRange(Data.SearchCreatureIds.Select((int x) => new LGGABHPGPDD
		{
			HCJPDNDOHAM = (uint)x
		}));
		return trainCakeCatchSearchScRsp;
	}

	public TrainCakeCatchOpenBoxScRsp OpenBox()
	{
		EnsureDefaults();
		if (Data.CatTreeSlots.Count == 0)
		{
			TrainCakeCatchData data = Data;
			int num = 3;
			List<CakeTreeSlotInfo> list = new List<CakeTreeSlotInfo>(num);
			CollectionsMarshal.SetCount(list, num);
			Span<CakeTreeSlotInfo> span = CollectionsMarshal.AsSpan(list);
			span[0] = new CakeTreeSlotInfo
			{
				CreatureId = 10,
				Slot = 4
			};
			span[1] = new CakeTreeSlotInfo
			{
				CreatureId = 21,
				Slot = 6
			};
			span[2] = new CakeTreeSlotInfo
			{
				CreatureId = 26,
				Slot = 5
			};
			data.CatTreeSlots = list;
		}
		DatabaseHelper.ToSaveUidList.Add(base.Player.Uid);
		TrainCakeCatchOpenBoxScRsp trainCakeCatchOpenBoxScRsp = new TrainCakeCatchOpenBoxScRsp();
		trainCakeCatchOpenBoxScRsp.DHLGCEGONIB = Data.RefreshTime;
		trainCakeCatchOpenBoxScRsp.AFEJACMLOLH.AddRange(Data.CatTreeSlots.Select((CakeTreeSlotInfo x) => new NPLEDHFMFDM
		{
			HCJPDNDOHAM = (uint)x.CreatureId,
			Slot = (uint)x.Slot
		}));
		return trainCakeCatchOpenBoxScRsp;
	}

	public TrainCakeCatchDiyLikeScRsp LikeDiy()
	{
		EnsureDefaults();
		if (!Data.DiyLikeIds.Contains(base.Player.Uid))
		{
			Data.DiyLikeIds.Add(base.Player.Uid);
		}
		DatabaseHelper.ToSaveUidList.Add(base.Player.Uid);
		TrainCakeCatchDiyLikeScRsp trainCakeCatchDiyLikeScRsp = new TrainCakeCatchDiyLikeScRsp();
		trainCakeCatchDiyLikeScRsp.JNNKJAEMOBN.AddRange(Data.DiyLikeIds.Select((int x) => (uint)x));
		return trainCakeCatchDiyLikeScRsp;
	}

	public async ValueTask UnlockAllPerformanceQuests()
	{
		QuestManager questManager = base.Player.QuestManager;
		if (questManager == null)
		{
			return;
		}
		List<QuestInfo> list = new List<QuestInfo>();
		foreach (CakePerformanceConfigExcel value2 in GameData.CakePerformanceConfigData.Values)
		{
			if (value2.QuestID != 0)
			{
				if (!questManager.QuestData.Quests.TryGetValue(value2.QuestID, out QuestInfo value))
				{
					value = new QuestInfo
					{
						QuestId = value2.QuestID
					};
					questManager.QuestData.Quests[value2.QuestID] = value;
				}
				QuestStatus questStatus = value.QuestStatus;
				if ((uint)(questStatus - 2) > 1u)
				{
					value.QuestStatus = QuestStatus.QuestFinish;
					value.FinishTime = DateTime.Now.ToUnixSec();
					value.Progress = 1;
					list.Add(value);
				}
			}
		}
		if (list.Count != 0)
		{
			DatabaseHelper.ToSaveUidList.Add(base.Player.Uid);
			await base.Player.SendPacket(new PacketPlayerSyncScNotify(list));
		}
	}

	public void SetCatTreeSlots(IEnumerable<(int CreatureId, int Slot)> placements)
	{
		Data.CatTreeSlots = placements.Select(delegate((int CreatureId, int Slot) p)
		{
			CakeTreeSlotInfo cakeTreeSlotInfo = new CakeTreeSlotInfo();
			(cakeTreeSlotInfo.CreatureId, cakeTreeSlotInfo.Slot) = p;
			return cakeTreeSlotInfo;
		}).ToList();
		DatabaseHelper.ToSaveUidList.Add(base.Player.Uid);
	}

	private OEBJBPNNOKO BuildSocialPlayPlayer(uint uid, bool isSelf)
	{
		PlayerData playerData = ResolveSocialPlayPlayer(uid);
		return new OEBJBPNNOKO
		{
			Uid = (uint)playerData.Uid,
			SummonedPetId = ((playerData.Pet > 0) ? ((uint)playerData.Pet) : 0u),
			CGLMHJFCFPH = playerData.ToSimpleProto(FriendOnlineStatus.Online),
			EKODIFJOBFB = Math.Max(0L, playerData.LastActiveTime),
			HCJMLMIGACG = true,
			IACKOCPGIAK = CreateMotion(playerData.Pos, playerData.Rot, isSelf)
		};
	}

	private OEBJBPNNOKO BuildPlaceholderSocialPlayPlayer(uint uid, bool isSelf)
	{
		PlayerData playerData = ResolveSocialPlayPlayer(uid);
		OEBJBPNNOKO oEBJBPNNOKO = new OEBJBPNNOKO
		{
			Uid = (uint)playerData.Uid,
			CGLMHJFCFPH = playerData.ToSimpleProto(FriendOnlineStatus.Online),
			IACKOCPGIAK = CreatePlaceholderMotion()
		};
		if (isSelf && playerData.Pet > 0)
		{
			oEBJBPNNOKO.SummonedPetId = (uint)playerData.Pet;
		}
		return oEBJBPNNOKO;
	}

	private void AppendFullSnapshotPlayer(MKHIPFHEKCK snapshot, SocialPlayRoom room, HashSet<int> addedUids, int memberUid, bool isSelf)
	{
		if (addedUids.Add(memberUid))
		{
			OEBJBPNNOKO oEBJBPNNOKO = BuildSocialPlayPlayer((uint)memberUid, isSelf);
			if (room.Motions.TryGetValue(memberUid, out MACJBIAFNOI value))
			{
				oEBJBPNNOKO.IACKOCPGIAK = BuildSnapshotMotion(value, oEBJBPNNOKO.IACKOCPGIAK, isSelf);
			}
			snapshot.PlayerInfo.Add(oEBJBPNNOKO);
		}
	}

	private void AppendPlaceholderSnapshotPlayer(MKHIPFHEKCK snapshot, HashSet<int> addedUids, int memberUid, bool isSelf)
	{
		if (addedUids.Add(memberUid))
		{
			snapshot.PlayerInfo.Add(BuildPlaceholderSocialPlayPlayer((uint)memberUid, isSelf));
		}
	}

	private static void TryAddImplicitOwnerRecipient(HashSet<int> recipientUids, int? implicitOwnerUid, uint roomOwnerUid, int senderUid)
	{
		if (!implicitOwnerUid.HasValue || implicitOwnerUid.Value == senderUid)
		{
			return;
		}
		PlayerInstance playerInstance = Listener.GetActiveConnection(implicitOwnerUid.Value)?.Player;
		if (playerInstance != null && playerInstance.Connection?.IsOnline == true)
		{
			TrainCakeCatchManager? trainCakeCatchManager = playerInstance.TrainCakeCatchManager;
			if (trainCakeCatchManager != null && trainCakeCatchManager.CurrentRoomOwnerUid == roomOwnerUid)
			{
				recipientUids.Add(implicitOwnerUid.Value);
			}
		}
	}

	private static EHKEJEPNGMB CreateArrivalEntry(uint uid, string name, long? time = null)
	{
		return new EHKEJEPNGMB
		{
			NINNEKFGNLI = 1u,
			NCFHGIBCEBG = uid,
			GNCOPJNBCKI = (time ?? Extensions.GetUnixSec()),
			OFOMBFJEDKC = name
		};
	}

	private static void AppendArrivalHistoryLocked(SocialPlayRoom room, int uid, string name)
	{
		room.ArrivalHistory.Add(CreateArrivalEntry((uint)uid, name));
		if (room.ArrivalHistory.Count > 20)
		{
			room.ArrivalHistory.RemoveRange(0, room.ArrivalHistory.Count - 20);
		}
	}

	private static void RecordMotionLocked(SocialPlayRoom room, int uid, MACJBIAFNOI motion)
	{
		room.Motions[uid] = motion.Clone();
		if (!room.MotionHistory.TryGetValue(uid, out List<MACJBIAFNOI> value))
		{
			value = new List<MACJBIAFNOI>();
			room.MotionHistory[uid] = value;
		}
		value.Add(motion.Clone());
		if (value.Count > 20)
		{
			value.RemoveRange(0, value.Count - 20);
		}
	}

	private static MACJBIAFNOI? GetCurrentMotion(uint roomOwnerUid, int uid)
	{
		lock (RoomLock)
		{
			if (!Rooms.TryGetValue(roomOwnerUid, out SocialPlayRoom value))
			{
				return null;
			}
			MACJBIAFNOI value2;
			return value.Motions.TryGetValue(uid, out value2) ? value2.Clone() : null;
		}
	}

	private MKHIPFHEKCK BuildSocialPlayRoomDataLocked(SocialPlayRoom room, uint roomOwnerUid, uint roomPlayerUid)
	{
		MKHIPFHEKCK mKHIPFHEKCK = BuildSocialPlayRoomData(roomOwnerUid, roomPlayerUid);
		mKHIPFHEKCK.PlayerInfo.Clear();
		HashSet<int> addedUids = new HashSet<int>();
		if (roomPlayerUid == roomOwnerUid)
		{
			foreach (int item in from uid in room.Members
				where uid != roomOwnerUid
				orderby uid
				select uid)
			{
				AppendFullSnapshotPlayer(mKHIPFHEKCK, room, addedUids, item, isSelf: false);
			}
			if (room.Members.Contains((int)roomOwnerUid))
			{
				AppendFullSnapshotPlayer(mKHIPFHEKCK, room, addedUids, (int)roomOwnerUid, isSelf: true);
			}
			else
			{
				AppendPlaceholderSnapshotPlayer(mKHIPFHEKCK, addedUids, (int)roomOwnerUid, isSelf: true);
			}
		}
		else
		{
			if (room.Members.Contains((int)roomPlayerUid))
			{
				AppendFullSnapshotPlayer(mKHIPFHEKCK, room, addedUids, (int)roomPlayerUid, isSelf: true);
			}
			else
			{
				AppendPlaceholderSnapshotPlayer(mKHIPFHEKCK, addedUids, (int)roomPlayerUid, isSelf: true);
			}
			if (room.Members.Contains((int)roomOwnerUid))
			{
				AppendFullSnapshotPlayer(mKHIPFHEKCK, room, addedUids, (int)roomOwnerUid, isSelf: false);
			}
			else
			{
				AppendPlaceholderSnapshotPlayer(mKHIPFHEKCK, addedUids, (int)roomOwnerUid, isSelf: false);
			}
			foreach (int item2 in from uid in room.Members
				where uid != roomPlayerUid && uid != roomOwnerUid
				orderby uid
				select uid)
			{
				AppendFullSnapshotPlayer(mKHIPFHEKCK, room, addedUids, item2, isSelf: false);
			}
		}
		return mKHIPFHEKCK;
	}

	private static IEnumerable<CakeCreatureInventoryInfo> GetCollectedCreatures(TrainCakeCatchData source)
	{
		return source.CollectedCreatures.Where((CakeCreatureInventoryInfo x) => x.CreatureId > 0 && x.Count > 0);
	}

	private static int GetCollectedCreatureCount(TrainCakeCatchData source, int creatureId)
	{
		return source.CollectedCreatures.FirstOrDefault((CakeCreatureInventoryInfo x) => x.CreatureId == creatureId)?.Count ?? 0;
	}

	private static void AddCollectedCreature(TrainCakeCatchData source, int creatureId)
	{
		if (creatureId > 0)
		{
			CakeCreatureInventoryInfo cakeCreatureInventoryInfo = source.CollectedCreatures.FirstOrDefault((CakeCreatureInventoryInfo x) => x.CreatureId == creatureId);
			if (cakeCreatureInventoryInfo != null)
			{
				cakeCreatureInventoryInfo.Count = Math.Max(1, cakeCreatureInventoryInfo.Count + 1);
				return;
			}
			source.CollectedCreatures.Add(new CakeCreatureInventoryInfo
			{
				CreatureId = creatureId,
				Count = 1
			});
		}
	}

	private static bool SyncCollectedCreatures(TrainCakeCatchData source)
	{
		bool result = false;
		for (int num = source.CollectedCreatures.Count - 1; num >= 0; num--)
		{
			if (source.CollectedCreatures[num].CreatureId <= 0)
			{
				source.CollectedCreatures.RemoveAt(num);
				result = true;
			}
			else if (source.CollectedCreatures[num].Count <= 0)
			{
				source.CollectedCreatures[num].Count = 1;
				result = true;
			}
		}
		foreach (DiyStagePlacement placement in source.StagePlacements.Where((DiyStagePlacement x) => x.CreatureId > 0))
		{
			if (!source.CollectedCreatures.Any((CakeCreatureInventoryInfo x) => x.CreatureId == placement.CreatureId))
			{
				source.CollectedCreatures.Add(new CakeCreatureInventoryInfo
				{
					CreatureId = placement.CreatureId,
					Count = 1
				});
				result = true;
			}
		}
		return result;
	}

	private static List<int> GetUnlockedPerformanceIds(TrainCakeCatchData source)
	{
		HashSet<int> hashSet = (from x in GetCollectedCreatures(source)
			select x.CreatureId).ToHashSet();
		HashSet<int> hashSet2 = new HashSet<int>(source.PerformanceIds);
		foreach (CakePerformanceConfigExcel item in GameData.CakePerformanceConfigData.Values.OrderBy((CakePerformanceConfigExcel x) => x.ID))
		{
			if (item.ActorsList.Count != 0 && item.ActorsList.All(hashSet.Contains))
			{
				hashSet2.Add(item.ID);
			}
		}
		return hashSet2.OrderBy((int x) => x).ToList();
	}

	private (uint OwnerUid, TrainCakeCatchData Data) ResolveRoomView(uint? requestedOwnerUid)
	{
		uint num = requestedOwnerUid.GetValueOrDefault((uint)base.Player.Uid);
		if (num == 0)
		{
			num = (uint)base.Player.Uid;
		}
		if (num == (uint)base.Player.Uid)
		{
			return (OwnerUid: num, Data: Data);
		}
		TrainCakeCatchManager trainCakeCatchManager = Listener.GetActiveConnection((int)num)?.Player?.TrainCakeCatchManager;
		if (trainCakeCatchManager != null)
		{
			return (OwnerUid: num, Data: trainCakeCatchManager.Data);
		}
		TrainCakeCatchData instanceOrCreateNew = DatabaseHelper.Instance.GetInstanceOrCreateNew<TrainCakeCatchData>((int)num);
		return (OwnerUid: num, Data: instanceOrCreateNew);
	}

	private async System.Threading.Tasks.Task NotifyRoomJoinAsync(uint roomOwnerUid, List<int> existingMembers)
	{
		HashSet<int> hashSet = new HashSet<int>(existingMembers.Where((int uid) => uid != base.Player.Uid));
		if (roomOwnerUid != (uint)base.Player.Uid)
		{
			hashSet.Add((int)roomOwnerUid);
		}
		if (hashSet.Count == 0)
		{
			return;
		}
		OEBJBPNNOKO oEBJBPNNOKO = BuildSocialPlayPlayer((uint)base.Player.Uid, isSelf: false);
		oEBJBPNNOKO.IACKOCPGIAK = BuildSimpleMotion(GetCurrentMotion(roomOwnerUid, base.Player.Uid), base.Player.Data.Pos, base.Player.Data.Rot);
		SocialPlayGameplayOperationScNotify notify = new SocialPlayGameplayOperationScNotify
		{
			MFBDMLPDEOE = roomOwnerUid,
			NCFHGIBCEBG = (uint)base.Player.Uid,
			PEFPFCINABN = oEBJBPNNOKO
		};
		foreach (int item in hashSet)
		{
			PlayerInstance target = Listener.GetActiveConnection(item)?.Player;
			if (target == null || target.Connection?.IsOnline != true)
			{
				continue;
			}
			if (item == (int)roomOwnerUid && roomOwnerUid != (uint)base.Player.Uid)
			{
				SocialPlayGameplayOperationScNotify socialPlayGameplayOperationScNotify = BuildArrivalHistoryNotify(roomOwnerUid);
				if (socialPlayGameplayOperationScNotify != null)
				{
					BasePacket basePacket = new BasePacket(9662);
					basePacket.SetData(socialPlayGameplayOperationScNotify);
					await target.SendPacket(basePacket);
				}
			}
			BasePacket basePacket2 = new BasePacket(9662);
			basePacket2.SetData(notify.Clone());
			await target.SendPacket(basePacket2);
		}
	}

	private async System.Threading.Tasks.Task NotifyRoomLeaveAsync(uint roomOwnerUid, List<int> remainingMembers, uint? nextRoomOwnerUid = null)
	{
		if (remainingMembers.Count == 0)
		{
			return;
		}
		SocialPlayGameplayOperationScNotify notify = new SocialPlayGameplayOperationScNotify
		{
			MFBDMLPDEOE = roomOwnerUid,
			NCFHGIBCEBG = (uint)base.Player.Uid,
			NEAIFLAADFE = (uint)base.Player.Uid
		};
		foreach (int uid in remainingMembers)
		{
			PlayerInstance target = Listener.GetActiveConnection(uid)?.Player;
			if (target != null && target.Connection?.IsOnline == true)
			{
				BasePacket basePacket = new BasePacket(9662);
				basePacket.SetData(notify.Clone());
				await target.SendPacket(basePacket);
				BasePacket basePacket2 = new BasePacket(9662);
				basePacket2.SetData(new SocialPlayGameplayOperationScNotify
				{
					MFBDMLPDEOE = roomOwnerUid,
					NCFHGIBCEBG = (uint)uid,
					INPEGNFEPAP = BuildRoomSnapshotForPlayer(roomOwnerUid, (uint)uid)
				});
				await target.SendPacket(basePacket2);
			}
		}
	}

	private PlayerData ResolveSocialPlayPlayer(uint uid)
	{
		if (uid == base.Player.Uid)
		{
			return base.Player.Data;
		}
		PlayerData playerByUid = PlayerData.GetPlayerByUid(uid);
		if (playerByUid != null)
		{
			return playerByUid;
		}
		ServerProfile serverProfile = ConfigManager.Config.ServerOption.ServerProfile;
		return new PlayerData
		{
			Uid = ((uid != 0) ? ((int)uid) : serverProfile.Uid),
			Name = serverProfile.Name,
			Signature = serverProfile.Signature,
			Level = serverProfile.Level,
			HeadIcon = serverProfile.HeadIcon,
			ChatBubble = serverProfile.ChatBubbleId,
			PersonalCard = serverProfile.PersonalCardId,
			LastActiveTime = Extensions.GetUnixSec()
		};
	}

	private static MACJBIAFNOI CreateMotion(Position? pos, Position? rot, bool isSelf)
	{
		MACJBIAFNOI mACJBIAFNOI = new MACJBIAFNOI
		{
			Pos = (pos ?? new Position(3278, -14999, 22389)).ToProto(),
			Rot = (rot ?? new Position(0, 18426, 0)).ToProto()
		};
		if (!isSelf)
		{
			mACJBIAFNOI.GNGKNDCKKKC = 1f;
			mACJBIAFNOI.JCBGHAODNDD = 2u;
			mACJBIAFNOI.KHAJDKDHPGD = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
			mACJBIAFNOI.NALBEFMOKIB = new Position(328, 0, -944).ToProto();
		}
		return mACJBIAFNOI;
	}

	private static MACJBIAFNOI CreatePlaceholderMotion()
	{
		return new MACJBIAFNOI
		{
			Pos = new Vector
			{
				Y = -15000,
				Z = 25000
			},
			Rot = new Vector
			{
				X = -180000
			}
		};
	}

	private static MACJBIAFNOI BuildSimpleMotion(MACJBIAFNOI? source, Position? fallbackPos, Position? fallbackRot)
	{
		return new MACJBIAFNOI
		{
			Pos = (source?.Pos?.Clone() ?? (fallbackPos ?? new Position(3278, -14999, 22389)).ToProto()),
			Rot = (source?.Rot?.Clone() ?? (fallbackRot ?? new Position(0, 18426, 0)).ToProto())
		};
	}

	private static MACJBIAFNOI BuildSnapshotMotion(MACJBIAFNOI? source, MACJBIAFNOI fallbackMotion, bool isSelf)
	{
		Position fallbackPos = ((fallbackMotion.Pos != null) ? new Position(fallbackMotion.Pos) : null);
		Position fallbackRot = ((fallbackMotion.Rot != null) ? new Position(fallbackMotion.Rot) : null);
		MACJBIAFNOI mACJBIAFNOI = BuildSimpleMotion(source, fallbackPos, fallbackRot);
		if (isSelf)
		{
			if (source?.NALBEFMOKIB != null)
			{
				mACJBIAFNOI.NALBEFMOKIB = source.NALBEFMOKIB.Clone();
			}
			if (source != null)
			{
				_ = source.JCBGHAODNDD;
				mACJBIAFNOI.JCBGHAODNDD = source.JCBGHAODNDD;
			}
			if (source != null)
			{
				_ = source.DCBBKFFHHDL;
				mACJBIAFNOI.DCBBKFFHHDL = source.DCBBKFFHHDL;
			}
			if (source != null)
			{
				_ = source.KHAJDKDHPGD;
				mACJBIAFNOI.KHAJDKDHPGD = source.KHAJDKDHPGD;
			}
			if (source != null)
			{
				_ = source.GNGKNDCKKKC;
				mACJBIAFNOI.GNGKNDCKKKC = source.GNGKNDCKKKC;
			}
			return mACJBIAFNOI;
		}
		if (source?.NALBEFMOKIB != null)
		{
			mACJBIAFNOI.NALBEFMOKIB = source.NALBEFMOKIB.Clone();
		}
		if (source != null)
		{
			_ = source.JCBGHAODNDD;
			mACJBIAFNOI.JCBGHAODNDD = source.JCBGHAODNDD;
		}
		if (source != null)
		{
			_ = source.DCBBKFFHHDL;
			mACJBIAFNOI.DCBBKFFHHDL = source.DCBBKFFHHDL;
		}
		if (source != null)
		{
			_ = source.KHAJDKDHPGD;
			mACJBIAFNOI.KHAJDKDHPGD = source.KHAJDKDHPGD;
		}
		if (source != null)
		{
			_ = source.GNGKNDCKKKC;
			mACJBIAFNOI.GNGKNDCKKKC = source.GNGKNDCKKKC;
		}
		return mACJBIAFNOI;
	}

	private void BookmarkReturnScene()
	{
		if (ReturnScene == null && base.Player.Data.Pos != null && base.Player.Data.Rot != null && base.Player.Data.PlaneId != 0 && base.Player.Data.FloorId != 0 && base.Player.Data.EntryId != 0)
		{
			ReturnScene = new SocialPlayReturnScene
			{
				PlaneId = base.Player.Data.PlaneId,
				FloorId = base.Player.Data.FloorId,
				EntryId = base.Player.Data.EntryId,
				Pos = base.Player.Data.Pos,
				Rot = base.Player.Data.Rot
			};
		}
	}

	private static void LeaveSocialPlayRoomInternal(uint roomOwnerUid, int uid)
	{
		if (Rooms.TryGetValue(roomOwnerUid, out SocialPlayRoom value))
		{
			value.Members.Remove(uid);
			value.Motions.Remove(uid);
			value.MotionHistory.Remove(uid);
			if (value.Members.Count == 0)
			{
				Rooms.TryRemove(roomOwnerUid, out SocialPlayRoom _);
			}
		}
	}
}
