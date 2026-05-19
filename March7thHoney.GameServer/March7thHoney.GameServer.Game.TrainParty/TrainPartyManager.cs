using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database;
using March7thHoney.Database.TrainParty;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.TrainParty;

public class TrainPartyManager : BasePlayerManager
{
	private static readonly TrainSelfDisplayEntry[] DefaultSelfDisplay = new TrainSelfDisplayEntry[6]
	{
		new TrainSelfDisplayEntry
		{
			Id = 1415u,
			Slot = 1600301u,
			Type = 1u
		},
		new TrainSelfDisplayEntry
		{
			Id = 1308u,
			Slot = 1600302u,
			Type = 1u
		},
		new TrainSelfDisplayEntry
		{
			Id = 5161u,
			Slot = 1600303u,
			Type = 4u
		},
		new TrainSelfDisplayEntry
		{
			Id = 5037u,
			Slot = 1600304u,
			Type = 4u
		},
		new TrainSelfDisplayEntry
		{
			Id = 23024u,
			Slot = 1600305u,
			Type = 3u
		},
		new TrainSelfDisplayEntry
		{
			Id = 23052u,
			Slot = 1600306u,
			Type = 3u
		}
	};

	private static readonly AreaDynamicInfo[] DefaultSelfDisplayDynamics = new AreaDynamicInfo[6]
	{
		new AreaDynamicInfo
		{
			DiceSlotId = 1600101u,
			DiyDynamicId = 295603u
		},
		new AreaDynamicInfo
		{
			DiceSlotId = 1600102u,
			DiyDynamicId = 295610u
		},
		new AreaDynamicInfo
		{
			DiceSlotId = 1600103u,
			DiyDynamicId = 294003u
		},
		new AreaDynamicInfo
		{
			DiceSlotId = 1600104u,
			DiyDynamicId = 295609u
		},
		new AreaDynamicInfo
		{
			DiceSlotId = 1600105u,
			DiyDynamicId = 295604u
		},
		new AreaDynamicInfo
		{
			DiceSlotId = 1600201u,
			DiyDynamicId = 295601u
		}
	};

	private static readonly (uint DiceSlotId, uint DynamicId, long Time)[] TimedDynamicProps = new(uint, uint, long)[3]
	{
		(1600106u, 295523u, 1780264800L),
		(1600107u, 295527u, 1783893600L),
		(1600108u, 295531u, 1787522400L)
	};

	private static readonly (int propId, long time)[] Props = new(int, long)[43]
	{
		(295123, 1776823846L),
		(293008, 1776823846L),
		(291006, 1776823846L),
		(295606, 1776823846L),
		(292005, 1776823846L),
		(294005, 1776823846L),
		(295603, 1776823846L),
		(292006, 1776823846L),
		(293001, 1776823846L),
		(295125, 1776824028L),
		(293005, 1776823846L),
		(291005, 1776823846L),
		(295611, 1776879877L),
		(294001, 1776823846L),
		(294004, 1776823846L),
		(295602, 1776873318L),
		(295124, 1776823846L),
		(291007, 1776823846L),
		(295607, 1776823846L),
		(291001, 1776823846L),
		(295605, 1776823846L),
		(293006, 1776823846L),
		(295121, 1776823846L),
		(291004, 1776823846L),
		(295610, 1776823846L),
		(294002, 1776823846L),
		(292001, 1776823846L),
		(293004, 1776823846L),
		(295609, 1776823846L),
		(291003, 1776823846L),
		(295604, 1776823846L),
		(294006, 1776823846L),
		(292004, 1776823846L),
		(295122, 1776823846L),
		(293007, 1776823846L),
		(292003, 1776823846L),
		(293003, 1776823846L),
		(291002, 1776823846L),
		(295608, 1776823846L),
		(292002, 1776823846L),
		(293002, 1776823846L),
		(294003, 1776823846L),
		(295601, 1776828054L)
	};

	private static readonly TrainAreaInfo[] DefaultAreas;

	private static readonly TrainCardInfo[] DefaultCards;

	private static readonly TrainMoveInfo[] DefaultMoveHistory;

	private static readonly TrainPendingPassengerInfo[] DefaultGameplayPassengers;

	private static readonly TrainSkillInfo[] DefaultGameplaySkills;

	private static readonly (uint PassengerId, uint RecordId, uint[] Badges)[] DefaultPassengers;

	public TrainData Data { get; }

	public TrainPartyManager(PlayerInstance player)
	{
		Data = DatabaseHelper.Instance.GetInstanceOrCreateNew<TrainData>(player.Uid);
		base._002Ector(player);
	}

	public void EnsureDefaults()
	{
		bool flag = false;
		if (Data.RecordId == 0)
		{
			Data.RecordId = 5;
			flag = true;
		}
		if (Data.WorldId == 0)
		{
			Data.WorldId = 501u;
			flag = true;
		}
		if (Data.RefreshTime == 0L)
		{
			Data.RefreshTime = 1780264800L;
			flag = true;
		}
		if (Data.Fund == 0)
		{
			Data.Fund = 111712;
			flag = true;
		}
		if (Data.SelfDisplay.Count == 0)
		{
			Data.SelfDisplay.AddRange(DefaultSelfDisplay);
			flag = true;
		}
		if (Data.PassengerRecordMarks.Count == 0)
		{
			Data.PassengerRecordMarks.Add(1004u);
			flag = true;
		}
		if (Data.UnlockedPassengerIds.Count == 0)
		{
			Data.UnlockedPassengerIds.AddRange(DefaultPassengers.Select(((uint PassengerId, uint RecordId, uint[] Badges) x) => x.PassengerId));
			flag = true;
		}
		if (Data.PropTimes.Count == 0)
		{
			(int, long)[] props = Props;
			for (int num = 0; num < props.Length; num++)
			{
				var (key, value) = props[num];
				Data.PropTimes[key] = value;
			}
			flag = true;
		}
		if (Data.TimedDynamicPropTimes.Count == 0)
		{
			(uint, uint, long)[] timedDynamicProps = TimedDynamicProps;
			for (int num = 0; num < timedDynamicProps.Length; num++)
			{
				(uint, uint, long) tuple2 = timedDynamicProps[num];
				uint item = tuple2.Item2;
				long item2 = tuple2.Item3;
				Data.TimedDynamicPropTimes[(int)item] = item2;
			}
			flag = true;
		}
		if (Data.Areas.Count == 0)
		{
			TrainAreaInfo[] defaultAreas = DefaultAreas;
			foreach (TrainAreaInfo trainAreaInfo in defaultAreas)
			{
				Data.Areas[trainAreaInfo.AreaId] = trainAreaInfo;
			}
			flag = true;
		}
		if (Data.Cards.Count == 0)
		{
			Data.Cards.AddRange(DefaultCards);
			flag = true;
		}
		if (Data.MoveHistory.Count == 0)
		{
			Data.MoveHistory.AddRange(DefaultMoveHistory);
			flag = true;
		}
		if (Data.GameplayPassengers.Count == 0)
		{
			Data.GameplayPassengers.AddRange(DefaultGameplayPassengers);
			flag = true;
		}
		if (Data.GameplaySkills.Count == 0)
		{
			Data.GameplaySkills.AddRange(DefaultGameplaySkills);
			flag = true;
		}
		if (Data.GameplayType == 0)
		{
			Data.GameplayType = 5;
			flag = true;
		}
		if (Data.GameplayRound == 0)
		{
			Data.GameplayRound = 1;
			flag = true;
		}
		if (flag)
		{
			MarkDirty();
		}
	}

	public TrainAreaInfo? SetDynamicId(int areaId, int slotId, int dynamicId)
	{
		EnsureDefaults();
		if (!Data.Areas.TryGetValue(areaId, out TrainAreaInfo value))
		{
			return null;
		}
		value.DynamicInfo[slotId] = dynamicId;
		if (!Data.PropTimes.ContainsKey(dynamicId))
		{
			Data.PropTimes[dynamicId] = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
		}
		MarkDirty();
		return value;
	}

	public TrainPartyData ToProto()
	{
		EnsureDefaults();
		return new TrainPartyData
		{
			RecordId = (uint)Data.RecordId,
			GGHOAIDMOMC = BuildGamePlayData(),
			TrainPartyInfo = ToPartyInfo(),
			PassengerInfo = ToPassenger(),
			UnlockAreaNum = (uint)Data.Areas.Count
		};
	}

	public TrainPartyInfo ToPartyInfo()
	{
		EnsureDefaults();
		TrainPartyInfo trainPartyInfo = new TrainPartyInfo
		{
			EKLIAOBCHPI = true,
			HIHKGPJCDPK = 30u,
			NMBFMHLNPLM = 100u,
			OBAMHCIFFOC = 30u,
			CurFund = (uint)Data.Fund,
			FCLJEACKGLE = BuildSelfDisplayProto()
		};
		foreach (KeyValuePair<int, long> propTime in Data.PropTimes)
		{
			trainPartyInfo.GBDEGDGGKOL.Add(new CCAIPEBCIMH
			{
				PropId = (uint)propTime.Key,
				Time = propTime.Value
			});
		}
		foreach (KeyValuePair<int, long> timedDynamicPropTime in Data.TimedDynamicPropTimes)
		{
			trainPartyInfo.MMFEPEBGAFC.Add(new CBGAODCKAGB
			{
				OOPOADNHABK = (uint)timedDynamicPropTime.Key,
				NJMONGKLJJC = timedDynamicPropTime.Value
			});
		}
		trainPartyInfo.AreaList.AddRange(from x in Data.Areas
			orderby x.Key
			select x.Value.ToProto());
		return trainPartyInfo;
	}

	public TrainPartyPassengerInfo ToPassenger()
	{
		EnsureDefaults();
		TrainPartyPassengerInfo trainPartyPassengerInfo = new TrainPartyPassengerInfo();
		trainPartyPassengerInfo.DACEDNGJLBM.AddRange(Data.PassengerRecordMarks);
		trainPartyPassengerInfo.PassengerInfoList.AddRange(DefaultPassengers.Select(delegate((uint PassengerId, uint RecordId, uint[] Badges) x)
		{
			TrainPartyPassenger trainPartyPassenger = new TrainPartyPassenger();
			(trainPartyPassenger.PassengerId, trainPartyPassenger.RecordId, _) = x;
			trainPartyPassenger.DACEDNGJLBM.Add(x.Badges);
			return trainPartyPassenger;
		}));
		return trainPartyPassengerInfo;
	}

	public uint GetWorldId()
	{
		EnsureDefaults();
		return Data.WorldId;
	}

	public ulong GetRefreshTime()
	{
		EnsureDefaults();
		return (ulong)Data.RefreshTime;
	}

	public KJGMAEGNBKL SetSelfDisplay(KJGMAEGNBKL? selfDisplay)
	{
		EnsureDefaults();
		if (selfDisplay != null)
		{
			Data.SelfDisplay = selfDisplay.IDPHCKABBJM.Select((IOBBILGOFCL x) => new TrainSelfDisplayEntry
			{
				Id = x.Id,
				Slot = x.Slot,
				Type = x.Type
			}).ToList();
			foreach (AreaDynamicInfo item in selfDisplay.JDBOIHJHEHP)
			{
				int key = (int)(item.DiceSlotId / 100000);
				if (Data.Areas.TryGetValue(key, out TrainAreaInfo value))
				{
					value.DynamicInfo[(int)item.DiceSlotId] = (int)item.DiyDynamicId;
				}
			}
			MarkDirty();
		}
		return BuildSelfDisplayProto();
	}

	public uint SetBadgeAutoFill(bool enabled)
	{
		EnsureDefaults();
		Data.BadgeAutoFill = enabled;
		MarkDirty();
		return 0u;
	}

	public uint BuildStartStep(uint areaId, uint stepId, AreaDynamicInfo? dynamicInfo, out uint curFund)
	{
		EnsureDefaults();
		curFund = (uint)Data.Fund;
		if (!Data.Areas.TryGetValue((int)areaId, out TrainAreaInfo value))
		{
			return 1u;
		}
		if (!value.StepList.Contains((int)stepId))
		{
			value.StepList.Add((int)stepId);
		}
		if (dynamicInfo != null)
		{
			value.DynamicInfo[(int)dynamicInfo.DiceSlotId] = (int)dynamicInfo.DiyDynamicId;
		}
		int num = 0;
		if (GameData.TrainPartyStepConfigData.TryGetValue((int)stepId, out TrainPartyStepConfigExcel value2))
		{
			num = value2.CoinCost;
		}
		Data.Fund = Math.Max(0, Data.Fund - num);
		curFund = (uint)Data.Fund;
		MarkDirty();
		return 0u;
	}

	public uint UseCard(uint cardUniqueId)
	{
		EnsureDefaults();
		Data.LastUsedCardId = (int)cardUniqueId;
		MarkDirty();
		return 0u;
	}

	public uint StartGameplay(IEnumerable<uint> passengerIds, uint gameplayType, out FKPMOKOJNHP gameplayData)
	{
		EnsureDefaults();
		Data.GameplayType = (int)gameplayType;
		Data.GameplayRound = Math.Max(Data.GameplayRound, 1);
		List<uint> list = passengerIds.ToList();
		if (list.Count > 0)
		{
			Data.GameplayPassengers = list.Select((uint id) => DefaultGameplayPassengers.FirstOrDefault((TrainPendingPassengerInfo x) => x.PassengerId == id) ?? new TrainPendingPassengerInfo
			{
				PassengerId = id,
				Hp = 300u,
				Atk = 30u
			}).ToList();
		}
		MarkDirty();
		gameplayData = BuildGamePlayData();
		return 0u;
	}

	public uint HandlePendingAction(uint queuePosition, out TrainPartyHandlePendingActionScRsp rsp)
	{
		EnsureDefaults();
		Data.GameplayQueuePosition = (int)queuePosition;
		MarkDirty();
		rsp = new TrainPartyHandlePendingActionScRsp
		{
			QueuePosition = queuePosition,
			KEJOPPIDNPP = true,
			OFCKHGLINAG = new MAGFKFCMLJM
			{
				FCLIKOAJCFN = (uint)Data.GameplayRound
			}
		};
		rsp.OFCKHGLINAG.DMMNCNGGPHL.AddRange(Data.GameplayPassengers.Select((TrainPendingPassengerInfo x) => new DOBIOOHLGAA
		{
			PassengerId = x.PassengerId,
			IANGBIBHJDF = 100u,
			DGFGNMJALGJ = new DKBNGDHCNCH
			{
				KKIOIFLJEEL = x.Hp,
				PNOCKMEMHLK = x.Atk
			}
		}));
		return 0u;
	}

	public uint TakeBuildLevelAward(uint level, out ItemList itemList)
	{
		EnsureDefaults();
		itemList = new ItemList();
		return 0u;
	}

	public TrainPartyBuildingUpdateNotify BuildBuildingUpdateNotify(params uint[] areaIds)
	{
		return new TrainPartyBuildingUpdateNotify();
	}

	public TrainPartySyncUpdateScNotify BuildSyncUpdateNotify(params TrainAreaInfo[] areas)
	{
		return new TrainPartySyncUpdateScNotify();
	}

	public TrainPartyMoveScNotify BuildMoveNotify()
	{
		TrainPartyMoveScNotify trainPartyMoveScNotify = new TrainPartyMoveScNotify();
		trainPartyMoveScNotify.DGBNFMAEMKM = (uint)Data.GameplayRound;
		trainPartyMoveScNotify.HACAPEDIPAB.AddRange(Data.MoveHistory.Select((TrainMoveInfo x) => new ANBOFKHHDNE
		{
			CJOPNFDBJHD = x.CardId,
			UniqueId = x.UniqueId,
			DisplayValue = x.DisplayValue,
			JBPCICCFPGE = x.BoardIndex
		}));
		return trainPartyMoveScNotify;
	}

	public TrainPartySettleNotify BuildSettleNotify()
	{
		return new TrainPartySettleNotify
		{
			GDFPBHMMFEA = (uint)Data.LastUsedCardId,
			OFCKHGLINAG = BuildPendingResult()
		};
	}

	public TrainPartyGamePlaySettleNotify BuildGamePlaySettleNotify()
	{
		TrainPartyGamePlaySettleNotify trainPartyGamePlaySettleNotify = new TrainPartyGamePlaySettleNotify();
		trainPartyGamePlaySettleNotify.RecordId = (uint)Data.RecordId;
		trainPartyGamePlaySettleNotify.UnlockAreaNum = (uint)Data.Areas.Count;
		trainPartyGamePlaySettleNotify.FIJHIEOANNM = ToPassenger();
		trainPartyGamePlaySettleNotify.IENGEPCHHMC.AddRange(Data.UnlockedPassengerIds);
		return trainPartyGamePlaySettleNotify;
	}

	private MAGFKFCMLJM BuildPendingResult()
	{
		MAGFKFCMLJM mAGFKFCMLJM = new MAGFKFCMLJM();
		mAGFKFCMLJM.FCLIKOAJCFN = (uint)Data.GameplayRound;
		mAGFKFCMLJM.DMMNCNGGPHL.AddRange(Data.GameplayPassengers.Select((TrainPendingPassengerInfo x) => new DOBIOOHLGAA
		{
			PassengerId = x.PassengerId,
			IANGBIBHJDF = 100u,
			DGFGNMJALGJ = new DKBNGDHCNCH
			{
				KKIOIFLJEEL = x.Hp,
				PNOCKMEMHLK = x.Atk
			}
		}));
		return mAGFKFCMLJM;
	}

	private FKPMOKOJNHP BuildGamePlayData()
	{
		FKPMOKOJNHP fKPMOKOJNHP = new FKPMOKOJNHP();
		fKPMOKOJNHP.MAONLHBKOFK = (uint)Data.GameplayType;
		fKPMOKOJNHP.ADGDMDNMCIK = new LNLMPKALPEF
		{
			AOLHMEFDAHE = 2u,
			BHFDLCPEPHM = 2u,
			FHKEMCLFBON = new GDKPBDAAKBH
			{
				DGGAIEANNBJ = 5u,
				DHFGLLAIFHP = 6u,
				FELAADBOAKD = 4u,
				MPJPBLLCMHK = 8001u
			}
		};
		fKPMOKOJNHP.MBHAHNEJGAC = new AJNICOHFJGC
		{
			IJIMFPEKPOK = 100u,
			IMKOJKJAHMM = new KBNIJFEMBPJ()
		};
		fKPMOKOJNHP.NJFAMMMDDIK = new MEGIHBEMOAB
		{
			AFOLIFFCDHJ = 1001u,
			FNKKIDJPKIH = 28u,
			CurIndex = (uint)Data.GameplayRound
		};
		fKPMOKOJNHP.ADGDMDNMCIK.JBOCOPNEJLB.AddRange(Data.MoveHistory.Select((TrainMoveInfo x) => new ANBOFKHHDNE
		{
			CJOPNFDBJHD = x.CardId,
			UniqueId = x.UniqueId,
			DisplayValue = x.DisplayValue,
			JBPCICCFPGE = x.BoardIndex
		}));
		fKPMOKOJNHP.MBHAHNEJGAC.IMKOJKJAHMM.IMKOJKJAHMM.AddRange(Data.Cards.Select((TrainCardInfo x) => new DKBJKODADGM
		{
			CardId = x.CardId,
			CurIndex = x.CurIndex,
			UniqueId = x.UniqueId
		}));
		fKPMOKOJNHP.NJFAMMMDDIK.DMMNCNGGPHL.AddRange(Data.GameplayPassengers.Select((TrainPendingPassengerInfo x) => new DOBIOOHLGAA
		{
			PassengerId = x.PassengerId,
			IANGBIBHJDF = 100u,
			DGFGNMJALGJ = new DKBNGDHCNCH
			{
				KKIOIFLJEEL = x.Hp,
				PNOCKMEMHLK = x.Atk
			}
		}));
		fKPMOKOJNHP.NJFAMMMDDIK.IBEBJMMCIDH.Add(105u);
		fKPMOKOJNHP.NJFAMMMDDIK.PHGLFHDDACM.AddRange(Data.GameplaySkills.Select((TrainSkillInfo x) => new JAFPMLLOGDI
		{
			SkillId = x.SkillId,
			SkillLevel = x.SkillLevel,
			MOOOPAMBOFK = x.Count
		}));
		return fKPMOKOJNHP;
	}

	private KJGMAEGNBKL BuildSelfDisplayProto()
	{
		KJGMAEGNBKL kJGMAEGNBKL = new KJGMAEGNBKL();
		kJGMAEGNBKL.IDPHCKABBJM.AddRange(Data.SelfDisplay.Select((TrainSelfDisplayEntry x) => new IOBBILGOFCL
		{
			Id = x.Id,
			Slot = x.Slot,
			Type = x.Type
		}));
		kJGMAEGNBKL.JDBOIHJHEHP.AddRange(DefaultSelfDisplayDynamics.Select((AreaDynamicInfo x) => new AreaDynamicInfo
		{
			DiceSlotId = x.DiceSlotId,
			DiyDynamicId = x.DiyDynamicId
		}));
		kJGMAEGNBKL.NMLANPJGJFA.AddRange(TimedDynamicProps.Select(delegate((uint DiceSlotId, uint DynamicId, long Time) x)
		{
			LMHFOFIEIMN lMHFOFIEIMN = new LMHFOFIEIMN();
			(lMHFOFIEIMN.DiceSlotId, lMHFOFIEIMN.OOPOADNHABK, lMHFOFIEIMN.NJMONGKLJJC) = x;
			return lMHFOFIEIMN;
		}));
		return kJGMAEGNBKL;
	}

	private void MarkDirty()
	{
		DatabaseHelper.ToSaveUidList.Add(base.Player.Uid);
	}

	static TrainPartyManager()
	{
		TrainAreaInfo[] array = new TrainAreaInfo[6];
		TrainAreaInfo obj = new TrainAreaInfo
		{
			AreaId = 11
		};
		int num = 12;
		List<int> list = new List<int>(num);
		CollectionsMarshal.SetCount(list, num);
		Span<int> span = CollectionsMarshal.AsSpan(list);
		span[0] = 10001;
		span[1] = 10003;
		span[2] = 11001;
		span[3] = 11002;
		span[4] = 11003;
		span[5] = 11004;
		span[6] = 11005;
		span[7] = 11006;
		span[8] = 11007;
		span[9] = 11008;
		span[10] = 11009;
		span[11] = 11011;
		obj.StepList = list;
		obj.DynamicInfo = new Dictionary<int, int>
		{
			[1100101] = 291004,
			[1100201] = 291005,
			[1100901] = 291006
		};
		array[0] = obj;
		TrainAreaInfo obj2 = new TrainAreaInfo
		{
			AreaId = 12
		};
		num = 15;
		List<int> list2 = new List<int>(num);
		CollectionsMarshal.SetCount(list2, num);
		Span<int> span2 = CollectionsMarshal.AsSpan(list2);
		span2[0] = 10007;
		span2[1] = 10009;
		span2[2] = 10010;
		span2[3] = 12001;
		span2[4] = 12002;
		span2[5] = 12003;
		span2[6] = 12004;
		span2[7] = 12005;
		span2[8] = 12006;
		span2[9] = 12007;
		span2[10] = 12008;
		span2[11] = 12009;
		span2[12] = 12011;
		span2[13] = 12012;
		span2[14] = 12013;
		obj2.StepList = list2;
		obj2.DynamicInfo = new Dictionary<int, int>
		{
			[1200201] = 294002,
			[1200401] = 292002,
			[1200501] = 294001,
			[1200701] = 293003,
			[1200703] = 291007,
			[1201201] = 291001
		};
		array[1] = obj2;
		TrainAreaInfo obj3 = new TrainAreaInfo
		{
			AreaId = 13
		};
		num = 8;
		List<int> list3 = new List<int>(num);
		CollectionsMarshal.SetCount(list3, num);
		Span<int> span3 = CollectionsMarshal.AsSpan(list3);
		span3[0] = 10002;
		span3[1] = 10014;
		span3[2] = 13001;
		span3[3] = 13002;
		span3[4] = 13003;
		span3[5] = 13004;
		span3[6] = 13005;
		span3[7] = 13007;
		obj3.StepList = list3;
		obj3.DynamicInfo = new Dictionary<int, int>
		{
			[1300301] = 293005,
			[1300302] = 293008,
			[1300401] = 292005,
			[1300402] = 292006
		};
		array[2] = obj3;
		TrainAreaInfo obj4 = new TrainAreaInfo
		{
			AreaId = 14
		};
		num = 13;
		List<int> list4 = new List<int>(num);
		CollectionsMarshal.SetCount(list4, num);
		Span<int> span4 = CollectionsMarshal.AsSpan(list4);
		span4[0] = 10004;
		span4[1] = 10008;
		span4[2] = 14001;
		span4[3] = 14002;
		span4[4] = 14003;
		span4[5] = 14004;
		span4[6] = 14005;
		span4[7] = 14006;
		span4[8] = 14007;
		span4[9] = 14008;
		span4[10] = 14009;
		span4[11] = 14010;
		span4[12] = 14011;
		obj4.StepList = list4;
		obj4.DynamicInfo = new Dictionary<int, int> { [1400501] = 294006 };
		array[3] = obj4;
		TrainAreaInfo obj5 = new TrainAreaInfo
		{
			AreaId = 15
		};
		num = 8;
		List<int> list5 = new List<int>(num);
		CollectionsMarshal.SetCount(list5, num);
		Span<int> span5 = CollectionsMarshal.AsSpan(list5);
		span5[0] = 10006;
		span5[1] = 10011;
		span5[2] = 15001;
		span5[3] = 15002;
		span5[4] = 15005;
		span5[5] = 15006;
		span5[6] = 15007;
		span5[7] = 15008;
		obj5.StepList = list5;
		obj5.DynamicInfo = new Dictionary<int, int>
		{
			[1500101] = 293007,
			[1500601] = 292001,
			[1500701] = 292004
		};
		array[4] = obj5;
		TrainAreaInfo obj6 = new TrainAreaInfo
		{
			AreaId = 16
		};
		num = 6;
		List<int> list6 = new List<int>(num);
		CollectionsMarshal.SetCount(list6, num);
		Span<int> span6 = CollectionsMarshal.AsSpan(list6);
		span6[0] = 10005;
		span6[1] = 10012;
		span6[2] = 10013;
		span6[3] = 16001;
		span6[4] = 16002;
		span6[5] = 16003;
		obj6.StepList = list6;
		array[5] = obj6;
		DefaultAreas = array;
		DefaultCards = new TrainCardInfo[4]
		{
			new TrainCardInfo
			{
				CardId = 107u,
				UniqueId = 1u
			},
			new TrainCardInfo
			{
				CardId = 321u,
				CurIndex = 2u,
				UniqueId = 3u
			},
			new TrainCardInfo
			{
				CardId = 207u,
				CurIndex = 4u,
				UniqueId = 4u
			},
			new TrainCardInfo
			{
				CardId = 206u,
				CurIndex = 5u,
				UniqueId = 5u
			}
		};
		DefaultMoveHistory = new TrainMoveInfo[11]
		{
			new TrainMoveInfo
			{
				CardId = 6101u,
				BoardIndex = 2u,
				UniqueId = 2u
			},
			new TrainMoveInfo
			{
				CardId = 6102u,
				BoardIndex = 3u,
				UniqueId = 3u
			},
			new TrainMoveInfo
			{
				CardId = 6103u,
				BoardIndex = 4u,
				UniqueId = 4u
			},
			new TrainMoveInfo
			{
				CardId = 6104u,
				BoardIndex = 5u,
				UniqueId = 5u
			},
			new TrainMoveInfo
			{
				CardId = 2001u,
				BoardIndex = 6u,
				UniqueId = 6u
			},
			new TrainMoveInfo
			{
				CardId = 8001u,
				BoardIndex = 7u,
				UniqueId = 7u
			},
			new TrainMoveInfo
			{
				CardId = 4001u,
				BoardIndex = 8u,
				UniqueId = 8u
			},
			new TrainMoveInfo
			{
				CardId = 6105u,
				BoardIndex = 9u,
				UniqueId = 9u
			},
			new TrainMoveInfo
			{
				CardId = 1001u,
				BoardIndex = 10u,
				UniqueId = 10u
			},
			new TrainMoveInfo
			{
				CardId = 6101u,
				BoardIndex = 11u,
				UniqueId = 11u
			},
			new TrainMoveInfo
			{
				CardId = 2001u,
				BoardIndex = 12u,
				UniqueId = 12u
			}
		};
		DefaultGameplayPassengers = new TrainPendingPassengerInfo[5]
		{
			new TrainPendingPassengerInfo
			{
				PassengerId = 1001u,
				Hp = 350u,
				Atk = 35u
			},
			new TrainPendingPassengerInfo
			{
				PassengerId = 1006u,
				Hp = 300u,
				Atk = 30u
			},
			new TrainPendingPassengerInfo
			{
				PassengerId = 1007u,
				Hp = 300u,
				Atk = 30u
			},
			new TrainPendingPassengerInfo
			{
				PassengerId = 1008u,
				Hp = 300u,
				Atk = 30u
			},
			new TrainPendingPassengerInfo
			{
				PassengerId = 1009u,
				Hp = 300u,
				Atk = 30u
			}
		};
		DefaultGameplaySkills = new TrainSkillInfo[2]
		{
			new TrainSkillInfo
			{
				SkillId = 214u,
				SkillLevel = 1u,
				Count = 1u
			},
			new TrainSkillInfo
			{
				SkillId = 208u,
				SkillLevel = 1u,
				Count = 1u
			}
		};
		DefaultPassengers = new(uint, uint, uint[])[9]
		{
			(1001u, 4u, new uint[3] { 103u, 101u, 102u }),
			(1002u, 4u, new uint[3] { 202u, 203u, 201u }),
			(1003u, 3u, new uint[3] { 301u, 302u, 303u }),
			(1004u, 3u, new uint[2] { 502u, 501u }),
			(1005u, 4u, new uint[3] { 401u, 403u, 402u }),
			(1006u, 2u, new uint[1] { 601u }),
			(1007u, 2u, new uint[1] { 701u }),
			(1008u, 2u, new uint[1] { 801u }),
			(1009u, 1u, new uint[1] { 901u })
		};
	}
}
