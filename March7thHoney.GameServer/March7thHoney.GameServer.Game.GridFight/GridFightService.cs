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

	public GridFightInstance EnsureOrStart(uint season = 1u, uint divisionId = 10939u, bool isOverlock = false)
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
					GridFightPortalBuffList = { 1115u, 106u, 147u }
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

	public (uint roleId, uint roleUniqueId, uint pos, int goldDelta) BuyGoods(IList<uint> buyGoodsIndexList)
	{
		GridFightInstance current = Current;
		if (current == null || buyGoodsIndexList.Count == 0)
		{
			return (roleId: 0u, roleUniqueId: 0u, pos: 14u, goldDelta: 0);
		}
		int shopIndex = (int)buyGoodsIndexList[0];
		var (flag, item, item2, num) = current.TryBuyGoods(shopIndex);
		if (!flag)
		{
			return (roleId: 0u, roleUniqueId: 0u, pos: 14u, goldDelta: 0);
		}
		return (roleId: item2, roleUniqueId: item, pos: (num == 0) ? 14u : num, goldDelta: -1);
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
