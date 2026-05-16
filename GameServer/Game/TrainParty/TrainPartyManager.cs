using System;
using System.Collections.Generic;
using System.Linq;
using March7thHoney.Database;
using March7thHoney.Database.TrainParty;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.TrainParty;

public class TrainPartyManager(PlayerInstance player) : BasePlayerManager(player)
{
	private static readonly (int propId, long time)[] Props = new(int, long)[45]
	{
		(291006, 1776823406L),
		(295008, 1778283303L),
		(293002, 1776823406L),
		(292004, 1776823406L),
		(294005, 1776823406L),
		(295603, 1776823406L),
		(295125, 1776823685L),
		(295608, 1776823406L),
		(291002, 1776823406L),
		(295611, 1777136151L),
		(291005, 1776823406L),
		(293004, 1776823406L),
		(291003, 1776823406L),
		(295609, 1776823406L),
		(294006, 1776823406L),
		(295604, 1776823406L),
		(292005, 1776823406L),
		(295602, 1777908001L),
		(294004, 1776823406L),
		(293005, 1776823406L),
		(295607, 1776823406L),
		(291001, 1776823406L),
		(295606, 1776823406L),
		(293007, 1776823406L),
		(295122, 1776823406L),
		(295605, 1776823406L),
		(294001, 1776823406L),
		(293003, 1776823406L),
		(293006, 1776823406L),
		(295121, 1776823406L),
		(292003, 1776823406L),
		(295011, 1776823406L),
		(295123, 1776823406L),
		(293008, 1776823406L),
		(291007, 1776823406L),
		(295124, 1776823406L),
		(293001, 1776823406L),
		(292001, 1776823406L),
		(294002, 1776823406L),
		(292006, 1776823406L),
		(292002, 1776823406L),
		(294003, 1776823406L),
		(295601, 1776959127L),
		(291004, 1776823406L),
		(295610, 1776823406L)
	};

	public TrainData Data { get; } = DatabaseHelper.Instance.GetInstanceOrCreateNew<TrainData>(player.Uid);

	public void EnsureDefaults()
	{
	}

	public TrainAreaInfo? SetDynamicId(int areaId, int slotId, int dynamicId)
	{
		return null;
	}

	public TrainPartyData ToProto()
	{
		return new TrainPartyData
		{
			RecordId = 5u,
			GGHOAIDMOMC = BuildGamePlayData(),
			TrainPartyInfo = ToPartyInfo(),
			PassengerInfo = ToPassenger(),
			UnlockAreaNum = 6u
		};
	}

	public TrainPartyInfo ToPartyInfo()
	{
		TrainPartyInfo trainPartyInfo = new TrainPartyInfo
		{
			EKLIAOBCHPI = true,
			HIHKGPJCDPK = 30u,
			NMBFMHLNPLM = 100u,
			OBAMHCIFFOC = 30u,
			CurFund = 308874u,
			FCLJEACKGLE = new KJGMAEGNBKL()
		};
		trainPartyInfo.FCLJEACKGLE.IDPHCKABBJM.AddRange(new IOBBILGOFCL[6]
		{
			new IOBBILGOFCL
			{
				Id = 1409u,
				Slot = 1600301u,
				Type = 1u
			},
			new IOBBILGOFCL
			{
				Id = 1415u,
				Slot = 1600302u,
				Type = 1u
			},
			new IOBBILGOFCL
			{
				Id = 1005u,
				Slot = 1600303u,
				Type = 4u
			},
			new IOBBILGOFCL
			{
				Id = 5113u,
				Slot = 1600304u,
				Type = 4u
			},
			new IOBBILGOFCL
			{
				Id = 23052u,
				Slot = 1600305u,
				Type = 3u
			},
			new IOBBILGOFCL
			{
				Id = 23042u,
				Slot = 1600306u,
				Type = 3u
			}
		});
		trainPartyInfo.FCLJEACKGLE.JDBOIHJHEHP.AddRange(new AreaDynamicInfo[6]
		{
			new AreaDynamicInfo
			{
				DiceSlotId = 1600101u,
				DiyDynamicId = 295608u
			},
			new AreaDynamicInfo
			{
				DiceSlotId = 1600102u,
				DiyDynamicId = 295609u
			},
			new AreaDynamicInfo
			{
				DiceSlotId = 1600103u,
				DiyDynamicId = 294003u
			},
			new AreaDynamicInfo
			{
				DiceSlotId = 1600104u,
				DiyDynamicId = 295604u
			},
			new AreaDynamicInfo
			{
				DiceSlotId = 1600105u,
				DiyDynamicId = 295606u
			},
			new AreaDynamicInfo
			{
				DiceSlotId = 1600201u,
				DiyDynamicId = 295121u
			}
		});
		trainPartyInfo.FCLJEACKGLE.NMLANPJGJFA.AddRange(new LMHFOFIEIMN[3]
		{
			new LMHFOFIEIMN
			{
				DiceSlotId = 1600106u,
				OOPOADNHABK = 295523u,
				NJMONGKLJJC = 1780264800L
			},
			new LMHFOFIEIMN
			{
				DiceSlotId = 1600107u,
				OOPOADNHABK = 295527u,
				NJMONGKLJJC = 1783893600L
			},
			new LMHFOFIEIMN
			{
				DiceSlotId = 1600108u,
				OOPOADNHABK = 295531u,
				NJMONGKLJJC = 1787522400L
			}
		});
		(int, long)[] props = Props;
		for (int i = 0; i < props.Length; i++)
		{
			var (propId, time) = props[i];
			trainPartyInfo.GBDEGDGGKOL.Add(new CCAIPEBCIMH
			{
				PropId = (uint)propId,
				Time = time
			});
		}
		trainPartyInfo.MMFEPEBGAFC.AddRange(new CBGAODCKAGB[3]
		{
			new CBGAODCKAGB
			{
				OOPOADNHABK = 295523u,
				NJMONGKLJJC = 1780264800L
			},
			new CBGAODCKAGB
			{
				OOPOADNHABK = 295527u,
				NJMONGKLJJC = 1783893600L
			},
			new CBGAODCKAGB
			{
				OOPOADNHABK = 295531u,
				NJMONGKLJJC = 1787522400L
			}
		});
		trainPartyInfo.AreaList.AddRange(BuildAreas());
		return trainPartyInfo;
	}

	public static TrainPartyPassengerInfo ToPassenger()
	{
		TrainPartyPassengerInfo trainPartyPassengerInfo = new TrainPartyPassengerInfo();
		trainPartyPassengerInfo.DACEDNGJLBM.Add(1010u);
		trainPartyPassengerInfo.PassengerInfoList.AddRange(new TrainPartyPassenger[9]
		{
			new TrainPartyPassenger
			{
				PassengerId = 1001u,
				RecordId = 4u,
				DACEDNGJLBM = { 103u, 101u, 102u }
			},
			new TrainPartyPassenger
			{
				PassengerId = 1002u,
				RecordId = 4u,
				DACEDNGJLBM = { 202u, 201u, 203u }
			},
			new TrainPartyPassenger
			{
				PassengerId = 1003u,
				RecordId = 3u,
				DACEDNGJLBM = { 302u, 303u, 301u }
			},
			new TrainPartyPassenger
			{
				PassengerId = 1004u,
				RecordId = 3u,
				DACEDNGJLBM = { 503u, 502u }
			},
			new TrainPartyPassenger
			{
				PassengerId = 1005u,
				RecordId = 4u,
				DACEDNGJLBM = { 401u, 402u, 403u }
			},
			new TrainPartyPassenger
			{
				PassengerId = 1006u,
				RecordId = 2u,
				DACEDNGJLBM = { 601u }
			},
			new TrainPartyPassenger
			{
				PassengerId = 1007u,
				RecordId = 2u,
				DACEDNGJLBM = { 701u }
			},
			new TrainPartyPassenger
			{
				PassengerId = 1008u,
				RecordId = 2u,
				DACEDNGJLBM = { 801u }
			},
			new TrainPartyPassenger
			{
				PassengerId = 1009u,
				RecordId = 1u,
				DACEDNGJLBM = { 901u }
			}
		});
		return trainPartyPassengerInfo;
	}

	public uint GetWorldId()
	{
		return 501u;
	}

	public ulong GetRefreshTime()
	{
		return 1780264800uL;
	}

	public KJGMAEGNBKL SetSelfDisplay(KJGMAEGNBKL? selfDisplay)
	{
		return ToPartyInfo().FCLJEACKGLE;
	}

	private static FKPMOKOJNHP BuildGamePlayData()
	{
		FKPMOKOJNHP fKPMOKOJNHP = new FKPMOKOJNHP
		{
			MAONLHBKOFK = 5u,
			ADGDMDNMCIK = new LNLMPKALPEF
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
			},
			MBHAHNEJGAC = new AJNICOHFJGC
			{
				IJIMFPEKPOK = 100u,
				IMKOJKJAHMM = new KBNIJFEMBPJ()
			},
			NJFAMMMDDIK = new MEGIHBEMOAB
			{
				AFOLIFFCDHJ = 1001u,
				FNKKIDJPKIH = 28u,
				CurIndex = 1u
			}
		};
		fKPMOKOJNHP.ADGDMDNMCIK.JBOCOPNEJLB.AddRange(new ANBOFKHHDNE[11]
		{
			new ANBOFKHHDNE
			{
				CJOPNFDBJHD = 6101u,
				JBPCICCFPGE = 2u,
				UniqueId = 2u
			},
			new ANBOFKHHDNE
			{
				CJOPNFDBJHD = 6102u,
				JBPCICCFPGE = 3u,
				UniqueId = 3u
			},
			new ANBOFKHHDNE
			{
				CJOPNFDBJHD = 6103u,
				JBPCICCFPGE = 4u,
				UniqueId = 4u
			},
			new ANBOFKHHDNE
			{
				CJOPNFDBJHD = 6104u,
				JBPCICCFPGE = 5u,
				UniqueId = 5u
			},
			new ANBOFKHHDNE
			{
				CJOPNFDBJHD = 2001u,
				JBPCICCFPGE = 6u,
				UniqueId = 6u
			},
			new ANBOFKHHDNE
			{
				CJOPNFDBJHD = 8001u,
				JBPCICCFPGE = 7u,
				UniqueId = 7u
			},
			new ANBOFKHHDNE
			{
				CJOPNFDBJHD = 4001u,
				JBPCICCFPGE = 8u,
				UniqueId = 8u
			},
			new ANBOFKHHDNE
			{
				CJOPNFDBJHD = 6105u,
				JBPCICCFPGE = 9u,
				UniqueId = 9u
			},
			new ANBOFKHHDNE
			{
				CJOPNFDBJHD = 1001u,
				JBPCICCFPGE = 10u,
				UniqueId = 10u
			},
			new ANBOFKHHDNE
			{
				CJOPNFDBJHD = 6101u,
				JBPCICCFPGE = 11u,
				UniqueId = 11u
			},
			new ANBOFKHHDNE
			{
				CJOPNFDBJHD = 2001u,
				JBPCICCFPGE = 12u,
				UniqueId = 12u
			}
		});
		fKPMOKOJNHP.MBHAHNEJGAC.IMKOJKJAHMM.IMKOJKJAHMM.AddRange(new DKBJKODADGM[4]
		{
			new DKBJKODADGM
			{
				CardId = 107u,
				UniqueId = 1u
			},
			new DKBJKODADGM
			{
				CardId = 321u,
				CurIndex = 2u,
				UniqueId = 3u
			},
			new DKBJKODADGM
			{
				CardId = 207u,
				CurIndex = 4u,
				UniqueId = 4u
			},
			new DKBJKODADGM
			{
				CardId = 206u,
				CurIndex = 5u,
				UniqueId = 5u
			}
		});
		fKPMOKOJNHP.NJFAMMMDDIK.DMMNCNGGPHL.AddRange(new DOBIOOHLGAA[5]
		{
			MakePassenger(1001u, 350u, 35u),
			MakePassenger(1006u, 300u, 30u),
			MakePassenger(1007u, 300u, 30u),
			MakePassenger(1008u, 300u, 30u),
			MakePassenger(1009u, 300u, 30u)
		});
		fKPMOKOJNHP.NJFAMMMDDIK.IBEBJMMCIDH.Add(105u);
		fKPMOKOJNHP.NJFAMMMDDIK.PHGLFHDDACM.AddRange(new JAFPMLLOGDI[2]
		{
			new JAFPMLLOGDI
			{
				SkillId = 214u,
				SkillLevel = 1u,
				MOOOPAMBOFK = 1u
			},
			new JAFPMLLOGDI
			{
				SkillId = 208u,
				SkillLevel = 1u,
				MOOOPAMBOFK = 1u
			}
		});
		return fKPMOKOJNHP;
	}

	private static DOBIOOHLGAA MakePassenger(uint id, uint hp, uint atk)
	{
		return new DOBIOOHLGAA
		{
			PassengerId = id,
			IANGBIBHJDF = 100u,
			DGFGNMJALGJ = new DKBNGDHCNCH
			{
				KKIOIFLJEEL = hp,
				PNOCKMEMHLK = atk
			}
		};
	}

	private static IEnumerable<TrainPartyArea> BuildAreas()
	{
		return new _003C_003Ez__ReadOnlyArray<TrainPartyArea>(new TrainPartyArea[6]
		{
			BuildArea(11, new int[12]
			{
				10001, 10003, 11001, 11002, 11003, 11004, 11005, 11006, 11007, 11008,
				11009, 11011
			}, new int[9] { 101010, 101011, 101012, 101013, 101014, 101015, 101016, 101017, 101018 }, new(int, int)[3]
			{
				(1100101, 291002),
				(1100201, 294001),
				(1100901, 292004)
			}),
			BuildArea(12, new int[15]
			{
				10007, 10009, 10010, 12001, 12002, 12003, 12004, 12005, 12006, 12007,
				12008, 12009, 12011, 12012, 12013
			}, new int[8] { 201010, 201011, 201013, 201014, 201016, 201017, 201021, 201022 }, new(int, int)[7]
			{
				(1200101, 292001),
				(1200201, 294006),
				(1200401, 292002),
				(1200501, 294002),
				(1200701, 293007),
				(1200703, 295011),
				(1201201, 291006)
			}),
			BuildArea(13, new int[8] { 10002, 10014, 13001, 13002, 13003, 13004, 13005, 13007 }, new int[5] { 301011, 301012, 301013, 301014, 301015 }, new(int, int)[5]
			{
				(1300201, 291001),
				(1300301, 293001),
				(1300302, 293008),
				(1300401, 291007),
				(1300402, 294004)
			}),
			BuildArea(14, new int[13]
			{
				10004, 10008, 14001, 14002, 14003, 14004, 14005, 14006, 14007, 14008,
				14009, 14010, 14011
			}, new int[7] { 401010, 401011, 401012, 401015, 401016, 401018, 401020 }, new(int, int)[2]
			{
				(1400501, 292005),
				(1400502, 292006)
			}),
			BuildArea(15, new int[8] { 10006, 10011, 15001, 15002, 15005, 15006, 15007, 15008 }, new int[7] { 501010, 501011, 501013, 501014, 501015, 501016, 501017 }, new(int, int)[4]
			{
				(1500101, 294005),
				(1500601, 292003),
				(1500602, 291005),
				(1500701, 293002)
			}),
			BuildArea(16, new int[6] { 10005, 10012, 10013, 16001, 16002, 16003 }, new int[4] { 601010, 601012, 601013, 601014 }, Array.Empty<(int, int)>())
		});
	}

	private static TrainPartyArea BuildArea(int areaId, int[] stepIds, int[] staticProps, (int slotId, int dynamicId)[] dynamic)
	{
		TrainPartyArea trainPartyArea = new TrainPartyArea();
		trainPartyArea.AreaId = (uint)areaId;
		trainPartyArea.Progress = 100u;
		trainPartyArea.AreaStepInfo = new AreaStepInfo();
		trainPartyArea.StepIdList.AddRange(stepIds.Select((int x) => (uint)x));
		trainPartyArea.VerifyStepIdList.AddRange(staticProps.Select((int x) => (uint)x));
		trainPartyArea.StaticPropIdList.AddRange(staticProps.Select((int x) => (uint)x));
		trainPartyArea.DynamicInfo.AddRange(dynamic.Select(((int slotId, int dynamicId) x) => new AreaDynamicInfo
		{
			DiceSlotId = (uint)x.slotId,
			DiyDynamicId = (uint)x.dynamicId
		}));
		return trainPartyArea;
	}
}
