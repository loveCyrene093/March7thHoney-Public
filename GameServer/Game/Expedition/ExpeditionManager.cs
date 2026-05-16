using System.Collections.Generic;
using System.Linq;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database;
using March7thHoney.Database.Expedition;
using March7thHoney.Database.Inventory;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.Expedition;

public class ExpeditionManager : BasePlayerManager
{
	private const int ExpeditionRefreshDelaySec = 300;

	private const int MaxExpeditionTeamCount = 4;

	private readonly List<uint> _activeExpeditionIds = new List<uint>();

	public ExpeditionData Data { get; }

	public ExpeditionManager(PlayerInstance player)
		: base(player)
	{
		Data = DatabaseHelper.Instance.GetInstanceOrCreateNew<ExpeditionData>(player.Uid);
		if (Data.ActiveExpeditionIds.Count > 0)
		{
			_activeExpeditionIds.AddRange(Data.ActiveExpeditionIds);
		}
	}

	public long GetRefreshTime()
	{
		return Data.RefreshTime;
	}

	public uint GetTotalExpeditionCount()
	{
		return 4u;
	}

	public IReadOnlyList<uint> GetAllExpeditionIds()
	{
		return (from id in GameData.ExpeditionDataData.Keys
			orderby id
			select (uint)id).ToList();
	}

	public IEnumerable<ExpeditionInfo> GetActiveExpeditionInfo()
	{
		return _activeExpeditionIds.Select((uint id) => new ExpeditionInfo
		{
			Id = id
		});
	}

	public List<ExpeditionInfo> AcceptMultipleExpedition(IEnumerable<ExpeditionInfo> requested)
	{
		HashSet<uint> validIds = GetAllExpeditionIds().ToHashSet();
		List<uint> list = (from x in requested
			select x.Id into id
			where validIds.Contains(id)
			select id).Distinct().Take(4).ToList();
		if (list.Count == 0)
		{
			return GetActiveExpeditionInfo().ToList();
		}
		_activeExpeditionIds.Clear();
		_activeExpeditionIds.AddRange(list);
		Data.ActiveExpeditionIds = _activeExpeditionIds.ToList();
		Data.RefreshTime = Extensions.GetUnixSec() + 300;
		DatabaseHelper.ToSaveUidList.SafeAdd(base.Player.Uid);
		return _activeExpeditionIds.Select((uint id) => new ExpeditionInfo
		{
			Id = id
		}).ToList();
	}

	public bool CanTakeRewardNow()
	{
		if (Data.RefreshTime > 0)
		{
			return Extensions.GetUnixSec() >= Data.RefreshTime;
		}
		return false;
	}

	public List<ItemData> BuildTakeRewardItems()
	{
		List<ItemData> list = new List<ItemData>();
		foreach (uint activeExpeditionId in _activeExpeditionIds)
		{
			if (!GameData.ExpeditionRewardData.TryGetValue((int)activeExpeditionId, out List<ExpeditionRewardExcel> value))
			{
				continue;
			}
			ExpeditionRewardExcel expeditionRewardExcel = value.OrderBy((ExpeditionRewardExcel x) => x.Duration).FirstOrDefault();
			if (expeditionRewardExcel == null || !GameData.RewardDataData.TryGetValue(expeditionRewardExcel.RewardID, out RewardDataExcel value2))
			{
				continue;
			}
			if (value2.Hcoin > 0)
			{
				list.Add(new ItemData
				{
					ItemId = 1,
					Count = value2.Hcoin
				});
			}
			foreach (var (itemId, count) in value2.GetItems())
			{
				list.Add(new ItemData
				{
					ItemId = itemId,
					Count = count
				});
			}
		}
		return list;
	}

	public void MarkRewardTaken()
	{
		Data.RefreshTime = Extensions.GetUnixSec() + 300;
		DatabaseHelper.ToSaveUidList.SafeAdd(base.Player.Uid);
	}
}
