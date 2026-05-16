using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database;
using March7thHoney.Database.Quests;
using March7thHoney.Database.TrainCakeCatch;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Game.Quest;
using March7thHoney.GameServer.Server.Packet.Send.PlayerSync;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.TrainCakeCatch;

public class TrainCakeCatchManager : BasePlayerManager
{
	public TrainCakeCatchData Data { get; }

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

	public TrainCakeCatchGetDataScRsp ToGetDataProto()
	{
		int count = GetConst("EveryCat_MaxQuantity", 13);
		int eHLIFHPILPG = GetConst("CatCatch_Week_Max", 9);
		TrainCakeCatchGetDataScRsp trainCakeCatchGetDataScRsp = new TrainCakeCatchGetDataScRsp
		{
			DHLGCEGONIB = WeekEndUnixSec(),
			PEOECDDANNP = BuildDiyProto(),
			FMECAHALPKG = new MKHIPFHEKCK
			{
				MFBDMLPDEOE = (uint)base.Player.Uid
			},
			PEPMFGLDGOH = new FAOPPAFAJLO(),
			HJOFGOINOAK = new LLKEMMMEPOB
			{
				EHLIFHPILPG = (uint)eHLIFHPILPG,
				FIHMHJHGHOG = NextDayUnixSec()
			}
		};
		trainCakeCatchGetDataScRsp.PerformanceIdList.AddRange(from x in GameData.CakePerformanceConfigData.Keys.Union(Data.PerformanceIds)
			select (uint)x);
		trainCakeCatchGetDataScRsp.AFEJACMLOLH.AddRange(Data.CatTreeSlots.Select((CakeTreeSlotInfo x) => new NPLEDHFMFDM
		{
			HCJPDNDOHAM = (uint)x.CreatureId,
			Slot = (uint)x.Slot
		}));
		foreach (KeyValuePair<int, CakeConfigExcel> cakeConfigDatum in GameData.CakeConfigData)
		{
			trainCakeCatchGetDataScRsp.BLEDIOOJPNL.Add(new PKILNDNCAMI
			{
				HCJPDNDOHAM = (uint)cakeConfigDatum.Key,
				Count = (uint)count
			});
		}
		return trainCakeCatchGetDataScRsp;
	}

	public FOFNOBHLKGO BuildDiyProto()
	{
		FOFNOBHLKGO fOFNOBHLKGO = new FOFNOBHLKGO();
		fOFNOBHLKGO.MIPPCFJPJDD = (HEAJBHNMJGO)Data.DiyTheme;
		fOFNOBHLKGO.OJNJEDBBAJJ.AddRange(Data.DiceSlots.Select(delegate(DiyDiceSlotInfo x)
		{
			BIAIKHBFALH bIAIKHBFALH = new BIAIKHBFALH();
			bIAIKHBFALH.DiceSlotId = (uint)x.DiceSlotId;
			bIAIKHBFALH.HGJHIJOGGIN = (uint)x.Index;
			bIAIKHBFALH.GBGDLNNOBID.AddRange(x.Values.Select((int v) => (uint)v));
			return bIAIKHBFALH;
		}));
		fOFNOBHLKGO.LKPGMBDBJFA.AddRange(Data.StagePlacements.Select((DiyStagePlacement x) => new GFAHEGCPIEB
		{
			HCJPDNDOHAM = (uint)x.CreatureId,
			Slot = (uint)x.Slot
		}));
		return fOFNOBHLKGO;
	}

	public FOFNOBHLKGO ApplyDiy(FOFNOBHLKGO req)
	{
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
		DatabaseHelper.ToSaveUidList.Add(base.Player.Uid);
		return BuildDiyProto();
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
}
