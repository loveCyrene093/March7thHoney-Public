using System.Collections.Generic;
using System.Linq;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.GridFight;

public sealed class GridFightService
{
	private GridFightManager Manager => _003Cplayer_003EP.GridFightManager;

	public GridFightInstance? Current => Manager.GridFightInstance;

	public GridFightService(PlayerInstance player)
	{
		_003Cplayer_003EP = player;
		base._002Ector();
	}

	public GridFightInstance EnsureOrStart(uint season = 1u, uint divisionId = 10940u, bool isOverlock = false)
	{
		return Manager.StartGamePlay(season, divisionId, isOverlock).Item2;
	}

	public GridFightInstance StartAndPrepare(uint season, uint divisionId, bool isOverlock)
	{
		GridFightInstance gridFightInstance = EnsureOrStart(season, divisionId, isOverlock);
		if (gridFightInstance.PendingAction == null)
		{
			gridFightInstance.PendingAction = new GridFightPendingAction
			{
				QueuePosition = gridFightInstance.QueuePosition,
				PortalBuffAction = new GridFightPortalBuffActionInfo
				{
					FCHPJKAIBHB = 1u,
					GridFightPortalBuffList = { (IEnumerable<uint>)gridFightInstance.EnsurePortalBuffOffer() }
				}
			};
		}
		return gridFightInstance;
	}

	public List<GridFightPosInfo> UpdatePos(IEnumerable<GridFightPosInfo> posInfoList)
	{
		GridFightInstance? current = Current;
		List<GridFightPosInfo> list = posInfoList.ToList();
		current?.ApplyPositionList(list);
		return list;
	}

	public (uint roleId, uint roleUniqueId, uint pos, int goldDelta, List<uint> mergedRemoved, uint mergedKeepUid, uint mergedNewStar) BuyGoods(IList<uint> buyGoodsIndexList)
	{
		GridFightInstance current = Current;
		if (current == null || buyGoodsIndexList.Count == 0)
		{
			return (roleId: 0u, roleUniqueId: 0u, pos: 14u, goldDelta: 0, mergedRemoved: new List<uint>(), mergedKeepUid: 0u, mergedNewStar: 0u);
		}
		int shopIndex = (int)buyGoodsIndexList[0];
		var (flag, num, num2, num3) = current.TryBuyGoods(shopIndex);
		if (!flag)
		{
			return (roleId: 0u, roleUniqueId: 0u, pos: 14u, goldDelta: 0, mergedRemoved: new List<uint>(), mergedKeepUid: 0u, mergedNewStar: 0u);
		}
		GridFightInstance.RoleMergeResult roleMergeResult = current.TryAutoMergeRole(num2, num);
		return (roleId: num2, roleUniqueId: num, pos: (num3 == 0) ? 14u : num3, goldDelta: -1, mergedRemoved: roleMergeResult.RemovedUniqueIds, mergedKeepUid: roleMergeResult.KeptUniqueId, mergedNewStar: roleMergeResult.NewStar);
	}

	public bool RefreshShop()
	{
		return Current?.TryRefreshShop() ?? false;
	}

	public uint RecycleRole(uint uniqueId)
	{
		return Current?.TryRecycleRole(uniqueId).refund ?? 0;
	}

	public bool BuyExp()
	{
		return Current?.TryBuyExp() ?? false;
	}
}
