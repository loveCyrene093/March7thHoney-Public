using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Google.Protobuf.Collections;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Enums.GridFight;
using March7thHoney.GameServer.Game.Battle;
using March7thHoney.GameServer.Game.GridFight.Battle;
using March7thHoney.GameServer.Game.GridFight.Component;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.GridFight;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.GridFight;

public class GridFightInstance
{
	public sealed class RoleMergeResult
	{
		public List<uint> RemovedUniqueIds { get; } = new List<uint>();

		public uint KeptUniqueId { get; set; }

		public uint NewStar { get; set; }

		public bool Merged
		{
			get
			{
				if (RemovedUniqueIds.Count > 0)
				{
					return KeptUniqueId != 0;
				}
				return false;
			}
		}
	}

	private static readonly uint[] FallbackPortalBuffPool = new uint[53]
	{
		101u, 102u, 103u, 104u, 105u, 106u, 107u, 108u, 109u, 110u,
		111u, 112u, 113u, 114u, 115u, 116u, 117u, 118u, 119u, 120u,
		121u, 122u, 123u, 124u, 125u, 127u, 129u, 134u, 135u, 138u,
		147u, 1001u, 1002u, 1003u, 1004u, 1005u, 1007u, 1008u, 1010u, 1014u,
		1016u, 1101u, 1102u, 1104u, 1106u, 1107u, 1108u, 1112u, 1113u, 1114u,
		1115u, 1116u, 1118u
	};

	private static readonly uint[] Section1RewardOrbs = new uint[4] { 102u, 199u, 203u, 204u };

	public PlayerInstance Player { get; }

	public uint Season { get; }

	public uint DivisionId { get; }

	public bool IsOverLock { get; }

	public uint UniqueId { get; }

	public uint Gold { get; set; }

	public uint LineupHp { get; set; }

	public uint LineupMaxHp { get; }

	public uint BattleMaxHp { get; }

	public uint Level { get; }

	public uint SectionId { get; set; }

	public uint NDOCIKPLKIF { get; }

	public uint CurrentChapterId { get; set; }

	public uint CurrentBranchId { get; set; }

	public uint KeepWinCnt { get; set; }

	public int BattlesFinished { get; set; }

	public GridFightBattleComponent BattleComponent { get; }

	public uint QueuePosition { get; set; }

	public GridFightPendingAction? PendingAction { get; set; }

	public uint NextRoleUniqueId { get; set; }

	public uint NextEquipUniqueId { get; set; }

	public uint NextOrbUniqueId { get; set; }

	public Dictionary<uint, uint> RoleByUniqueId { get; }

	public Dictionary<uint, uint> UniqueIdByPos { get; }

	public Dictionary<uint, uint> RoleStarByUniqueId { get; }

	public uint ShopRefreshLeft { get; set; }

	public uint ShopRollCounter { get; set; }

	public List<GridFightShopGoodsInfo> ShopGoods { get; }

	public List<uint> ShopRolePool { get; }

	public List<uint> StageCandidates { get; }

	public List<uint> CurrentEquipDraft { get; private set; }

	public List<GridFightEquipmentInfo> Equipments { get; }

	public List<GridFightConsumableInfo> Consumables { get; }

	public List<uint> SectionAffixIds { get; private set; }

	public List<uint> SessionCampIds { get; private set; }

	public List<uint> ActivePortalBuffIds { get; }

	public List<uint> AvailablePortalBuffRerolls { get; }

	public List<uint> CurrentPortalBuffOffer { get; private set; }

	public List<(uint AvatarId, uint Pos, uint UniqueId, string Component)> RolledBenchRoles { get; private set; }

	public uint PreBattleLineupHp { get; set; }

	public uint PreBattleLevel { get; set; }

	public uint PreBattleExp { get; set; }

	public uint PlayerLevel { get; set; }

	public uint PlayerExp { get; set; }

	public uint PlayerMaxLevel { get; }

	public uint CampId { get; set; }

	public uint PreBattleGold { get; set; }

	public GridFightDamageSttInfo? LastBattleDamageStt { get; set; }

	public List<(uint ItemId, uint UniqueId)> LastRewardedOrbs { get; }

	public Dictionary<uint, uint> OrbItemByUniqueId { get; }

	public List<GridFightHpModifyInfo> LastHpModifyTimeline { get; }

	public Dictionary<uint, GridFightDropInfo> LastSectionRewards { get; }

	public GridFightInstance(PlayerInstance player, uint season, uint divisionId, bool isOverLock, uint uniqueId)
	{
		Player = player;
		Season = season;
		DivisionId = divisionId;
		IsOverLock = isOverLock;
		UniqueId = uniqueId;
		Gold = 3u;
		LineupHp = 80u;
		LineupMaxHp = 100u;
		BattleMaxHp = 10939u;
		Level = 1u;
		SectionId = 1u;
		NDOCIKPLKIF = 1801u;
		CurrentChapterId = 1u;
		CurrentBranchId = 1u;
		BattleComponent = new GridFightBattleComponent();
		QueuePosition = 1u;
		NextRoleUniqueId = 100u;
		NextEquipUniqueId = 50u;
		NextOrbUniqueId = 10u;
		RoleByUniqueId = new Dictionary<uint, uint>();
		UniqueIdByPos = new Dictionary<uint, uint>();
		RoleStarByUniqueId = new Dictionary<uint, uint>();
		ShopRefreshLeft = 2u;
		ShopGoods = new List<GridFightShopGoodsInfo>();
		ShopRolePool = new List<uint>();
		StageCandidates = new List<uint> { 35030205u, 35030405u, 35030208u, 350202u, 35030606u };
		CurrentEquipDraft = new List<uint> { 35030205u, 35030405u, 35030208u };
		Equipments = new List<GridFightEquipmentInfo>();
		Consumables = new List<GridFightConsumableInfo>();
		SectionAffixIds = new List<uint>();
		SessionCampIds = new List<uint>();
		ActivePortalBuffIds = new List<uint> { 106u };
		AvailablePortalBuffRerolls = new List<uint> { 105u, 1014u, 132u };
		CurrentPortalBuffOffer = new List<uint>();
		RolledBenchRoles = new List<(uint, uint, uint, string)>();
		PlayerLevel = 3u;
		PlayerMaxLevel = 10u;
		CampId = 18u;
		LastRewardedOrbs = new List<(uint, uint)>();
		OrbItemByUniqueId = new Dictionary<uint, uint> { [7u] = 199u };
		LastHpModifyTimeline = new List<GridFightHpModifyInfo>();
		LastSectionRewards = new Dictionary<uint, GridFightDropInfo>();
		base._002Ector();
	}

	public List<uint> RollPortalBuffs(int count = 3, IEnumerable<uint>? exclude = null)
	{
		List<uint> value;
		List<uint> list = ((GameData.GridFightSeasonPortalData.TryGetValue(Season, out value) && value.Count > 0) ? value.ToList() : FallbackPortalBuffPool.ToList());
		if (exclude != null)
		{
			foreach (uint item in exclude)
			{
				list.Remove(item);
			}
		}
		if (list.Count <= count)
		{
			List<uint> list2 = list.Distinct().ToList();
			while (list2.Count < count)
			{
				list2.Add(FallbackPortalBuffPool[list2.Count % FallbackPortalBuffPool.Length]);
			}
			CurrentPortalBuffOffer = list2.Take(count).ToList();
			return CurrentPortalBuffOffer;
		}
		Random shared = Random.Shared;
		List<uint> list3 = new List<uint>(count);
		while (list3.Count < count)
		{
			int index = shared.Next(list.Count);
			list3.Add(list[index]);
			list.RemoveAt(index);
		}
		CurrentPortalBuffOffer = list3;
		return CurrentPortalBuffOffer;
	}

	public List<uint> EnsurePortalBuffOffer()
	{
		if (CurrentPortalBuffOffer.Count == 0)
		{
			RollPortalBuffs();
		}
		return CurrentPortalBuffOffer;
	}

	public void ClearPortalBuffOffer()
	{
		CurrentPortalBuffOffer = new List<uint>();
	}

	public void EnsureDefaultRoles()
	{
		if (ShopGoods.Count == 0)
		{
			RotateShop();
		}
		EnsureSessionPreview();
	}

	public void EnsureSessionPreview()
	{
		if (SessionCampIds.Count == 0)
		{
			SessionCampIds = RollSessionCamps();
		}
		if (SectionAffixIds.Count == 0)
		{
			SectionAffixIds = RollSessionAffixes();
		}
	}

	private List<uint> RollSessionCamps(int count = 3)
	{
		List<uint> list = (from c in GameData.GridFightCampData.Values
			where c.SeasonID == Season || c.SeasonID == 0
			select c.ID).Distinct().ToList();
		if (list.Count == 0)
		{
			list = new List<uint>
			{
				1u, 2u, 4u, 5u, 6u, 8u, 10u, 11u, 12u, 13u,
				15u, 16u, 17u, 23u, 24u, 25u, 26u, 27u, 28u
			};
		}
		return PickDistinct(list, count);
	}

	private List<uint> RollSessionAffixes()
	{
		int num = 3;
		if (GameData.GridFightDivisionStageData.TryGetValue(DivisionId, out GridFightDivisionStageExcel value) && value.AffixChooseNumList.Count > 0)
		{
			num = (int)value.AffixChooseNumList.Sum((uint x) => x);
		}
		if (num <= 0)
		{
			return new List<uint>();
		}
		List<uint> list = GameData.GridFightAffixConfigData.Keys.ToList();
		if (list.Count == 0)
		{
			list = new List<uint>
			{
				1001u, 1002u, 1003u, 1004u, 1005u, 2002u, 2003u, 2004u, 2005u, 2006u,
				3001u, 3002u, 3003u, 3004u, 3005u, 3006u, 3007u, 3008u, 4001u, 4002u,
				4003u, 4005u, 4006u, 4007u, 4008u, 4009u, 4010u, 4011u, 4012u, 4013u
			};
		}
		return PickDistinct(list, num);
	}

	private static List<uint> PickDistinct(List<uint> pool, int count)
	{
		Random shared = Random.Shared;
		List<uint> list = pool.ToList();
		List<uint> list2 = new List<uint>(count);
		while (list2.Count < count && list.Count > 0)
		{
			int index = shared.Next(list.Count);
			list2.Add(list[index]);
			list.RemoveAt(index);
		}
		while (list2.Count < count)
		{
			list2.Add(pool[list2.Count % Math.Max(1, pool.Count)]);
		}
		return list2;
	}

	public void MaterializeInitialBenchTeam(uint requiredTrait = 0u)
	{
		if (RoleByUniqueId.Count > 0)
		{
			return;
		}
		if (RolledBenchRoles.Count == 0 || (requiredTrait != 0 && !RolledBenchRoles.Any<(uint, uint, uint, string)>(((uint AvatarId, uint Pos, uint UniqueId, string Component) r) => RoleHasTrait(r.AvatarId, requiredTrait))))
		{
			RollInitialBenchRoles(4, requiredTrait);
		}
		foreach (var (value, key, num, _) in RolledBenchRoles)
		{
			RoleByUniqueId[num] = value;
			RoleStarByUniqueId[num] = 1u;
			UniqueIdByPos[key] = num;
		}
	}

	private static bool RoleHasTrait(uint avatarId, uint trait)
	{
		return GameData.GridFightRoleBasicInfoData.Values.Any((GridFightRoleBasicInfoExcel r) => r.AvatarID == avatarId && r.TraitList.Contains(trait));
	}

	public List<(uint AvatarId, uint Pos, uint UniqueId, string Component)> RollInitialBenchRoles(int count = 4, uint requiredTrait = 0u)
	{
		List<GridFightRoleBasicInfoExcel> source = (from r in GameData.GridFightRoleBasicInfoData.Values
			where r.IsInPool && (r.SeasonID == Season || r.SeasonID == 0)
			where r.AvatarID >= 1000 && r.AvatarID < 2000
			where r.RoleSavedValueList.Count > 0
			select r).ToList();
		Random shared = Random.Shared;
		List<GridFightRoleBasicInfoExcel> list = source.ToList();
		List<GridFightRoleBasicInfoExcel> list2 = new List<GridFightRoleBasicInfoExcel>(count);
		if (requiredTrait != 0)
		{
			List<GridFightRoleBasicInfoExcel> list3 = list.Where((GridFightRoleBasicInfoExcel r) => r.TraitList.Contains(requiredTrait)).ToList();
			if (list3.Count > 0)
			{
				GridFightRoleBasicInfoExcel item = list3[shared.Next(list3.Count)];
				list2.Add(item);
				list.Remove(item);
			}
		}
		while (list2.Count < count && list.Count > 0)
		{
			int index = shared.Next(list.Count);
			list2.Add(list[index]);
			list.RemoveAt(index);
		}
		RolledBenchRoles = new List<(uint, uint, uint, string)>(list2.Count);
		for (int num = 0; num < list2.Count; num++)
		{
			GridFightRoleBasicInfoExcel gridFightRoleBasicInfoExcel = list2[num];
			RolledBenchRoles.Add((gridFightRoleBasicInfoExcel.AvatarID, (uint)(14 + num), AllocRoleUniqueId(), gridFightRoleBasicInfoExcel.RoleSavedValueList[0]));
		}
		return RolledBenchRoles;
	}

	public uint AllocRoleUniqueId()
	{
		return ++NextRoleUniqueId;
	}

	public uint AllocEquipUniqueId()
	{
		return ++NextEquipUniqueId;
	}

	public uint AllocOrbUniqueId()
	{
		return ++NextOrbUniqueId;
	}

	public void AdvanceQueue(uint by = 1u)
	{
		QueuePosition += by;
		PendingAction = null;
	}

	public void ApplyPositionList(IEnumerable<GridFightPosInfo> posInfoList)
	{
		EnsureDefaultRoles();
		foreach (GridFightPosInfo posInfo in posInfoList)
		{
			if (posInfo.Pos == 0)
			{
				continue;
			}
			foreach (uint item in (from kv in UniqueIdByPos
				where kv.Key != posInfo.Pos && kv.Value == posInfo.UniqueId
				select kv.Key).ToList())
			{
				UniqueIdByPos.Remove(item);
			}
			UniqueIdByPos[posInfo.Pos] = posInfo.UniqueId;
		}
	}

	public List<(uint RoleId, uint Pos)> ResolveForegroundRoles()
	{
		EnsureDefaultRoles();
		return (from kv in UniqueIdByPos.OrderBy((KeyValuePair<uint, uint> kv) => kv.Key).Where(delegate(KeyValuePair<uint, uint> kv)
			{
				uint key = kv.Key;
				return key != 0 && key <= 4;
			})
			select (Role: RoleByUniqueId.GetValueOrDefault(kv.Value), Pos: kv.Key) into t
			where t.Role != 0
			select (RoleId: t.Role, Pos: t.Pos)).ToList();
	}

	public List<(uint RoleId, uint Pos)> ResolveBackgroundRoles()
	{
		EnsureDefaultRoles();
		return (from kv in UniqueIdByPos.OrderBy((KeyValuePair<uint, uint> kv) => kv.Key).Where(delegate(KeyValuePair<uint, uint> kv)
			{
				uint key = kv.Key;
				return key > 4 && key <= 13;
			})
			select (Role: RoleByUniqueId.GetValueOrDefault(kv.Value), Pos: kv.Key) into t
			where t.Role != 0
			select (RoleId: t.Role, Pos: t.Pos)).ToList();
	}

	public List<int> BuildForegroundAvatarIds(int maxCount = 4)
	{
		List<int> list = (from t in ResolveForegroundRoles()
			select RoleIdToAvatarId(t.RoleId) into id
			where id != 0
			select id).Take(maxCount).ToList();
		if (list.Count == 0)
		{
			list = (from x in RoleByUniqueId.Values.Take(maxCount)
				select (int)x).ToList();
		}
		return list;
	}

	public List<int> BuildBackgroundAvatarIds()
	{
		return (from t in ResolveBackgroundRoles()
			select RoleIdToAvatarId(t.RoleId) into id
			where id != 0
			select id).ToList();
	}

	private static int RoleIdToAvatarId(uint roleId)
	{
		if (!GameData.GridFightRoleBasicInfoData.TryGetValue(roleId, out GridFightRoleBasicInfoExcel value))
		{
			return (int)roleId;
		}
		return (int)value.AvatarID;
	}

	public List<IENNMHMOONM> CheckTrait()
	{
		EnsureDefaultRoles();
		Dictionary<uint, uint> dictionary = new Dictionary<uint, uint>();
		Dictionary<uint, List<(uint, uint)>> dictionary2 = new Dictionary<uint, List<(uint, uint)>>();
		foreach (KeyValuePair<uint, uint> item in UniqueIdByPos.Where(delegate(KeyValuePair<uint, uint> kv)
		{
			uint key2 = kv.Key;
			return key2 != 0 && key2 <= 13;
		}))
		{
			uint value = item.Value;
			if (value == 0 || !RoleByUniqueId.TryGetValue(value, out var value2) || !GameData.GridFightRoleBasicInfoData.TryGetValue(value2, out GridFightRoleBasicInfoExcel value3))
			{
				continue;
			}
			foreach (uint trait in value3.TraitList)
			{
				dictionary[trait] = dictionary.GetValueOrDefault(trait) + 1;
				if (!dictionary2.TryGetValue(trait, out var value4))
				{
					value4 = (dictionary2[trait] = new List<(uint, uint)>());
				}
				value4.Add((value3.AvatarID, value));
			}
		}
		List<IENNMHMOONM> list2 = new List<IENNMHMOONM>();
		foreach (KeyValuePair<uint, uint> item2 in dictionary)
		{
			item2.Deconstruct(out var key, out var value5);
			uint num = key;
			uint num2 = value5;
			if (num2 == 0 || !GameData.GridFightTraitBasicInfoData.TryGetValue(num, out GridFightTraitBasicInfoExcel value6))
			{
				continue;
			}
			uint num3 = 0u;
			if (GameData.GridFightTraitLayerData.TryGetValue(num, out Dictionary<uint, GridFightTraitLayerExcel> value7) && value7.Count > 0)
			{
				foreach (KeyValuePair<uint, GridFightTraitLayerExcel> item3 in value7)
				{
					item3.Deconstruct(out value5, out var value8);
					uint num4 = value5;
					GridFightTraitLayerExcel gridFightTraitLayerExcel = value8;
					if (num4 <= num2 && gridFightTraitLayerExcel.Layer > num3)
					{
						num3 = gridFightTraitLayerExcel.Layer;
					}
				}
			}
			IENNMHMOONM iENNMHMOONM = new IENNMHMOONM
			{
				TraitId = num,
				NKFDBEHPNLG = num3
			};
			if (dictionary2.TryGetValue(num, out var value9))
			{
				foreach (var (gDNIKJGAEBH, iPDCMHIEKIJ) in value9)
				{
					iENNMHMOONM.MEEPFKLLIJB.Add(new BGNGLHHBGMI
					{
						EIHHLAOKAPH = GAPBBJCLMGP.Dgecgaafdjm,
						GDNIKJGAEBH = gDNIKJGAEBH,
						IPDCMHIEKIJ = iPDCMHIEKIJ,
						GridUpdateSrc = PFODGDGFBBN.Iomeeecoiob
					});
				}
			}
			if (num3 != 0)
			{
				foreach (uint traitEffect in value6.TraitEffectList)
				{
					iENNMHMOONM.TraitEffectList.Add(new BattleGridFightTraitEffectInfo
					{
						EffectId = traitEffect
					});
				}
			}
			list2.Add(iENNMHMOONM);
		}
		return list2;
	}

	public void RotateShop()
	{
		ShopGoods.Clear();
		ShopRollCounter++;
		Random shared = Random.Shared;
		List<uint> shopRarityWeights = GetShopRarityWeights();
		Dictionary<uint, List<uint>> dictionary = BuildShopRolePoolByRarity();
		for (int i = 0; i < 5; i++)
		{
			uint num = RollShopRarity(shopRarityWeights, shared);
			if (!dictionary.TryGetValue(num, out var value) || value.Count == 0)
			{
				value = dictionary.Values.FirstOrDefault((List<uint> x) => x.Count > 0) ?? new List<uint>();
			}
			if (value.Count != 0)
			{
				uint roleId = value[shared.Next(value.Count)];
				uint shopGoodsPrice = GetShopGoodsPrice(num, 1u);
				ShopGoods.Add(new GridFightShopGoodsInfo
				{
					ShopGoodsPrice = shopGoodsPrice,
					RoleGoodsInfo = new GridFightRoleGoodsInfo
					{
						RoleId = roleId,
						RoleStar = 1u
					}
				});
				continue;
			}
			break;
		}
	}

	private List<uint> GetShopRarityWeights()
	{
		if (GameData.GridFightPlayerLevelData.TryGetValue(PlayerLevel, out GridFightPlayerLevelExcel value) && value.RarityWeights.Count >= 5)
		{
			return value.RarityWeights;
		}
		int num = 5;
		List<uint> list = new List<uint>(num);
		CollectionsMarshal.SetCount(list, num);
		Span<uint> span = CollectionsMarshal.AsSpan(list);
		span[0] = 100u;
		span[1] = 0u;
		span[2] = 0u;
		span[3] = 0u;
		span[4] = 0u;
		return list;
	}

	private Dictionary<uint, List<uint>> BuildShopRolePoolByRarity()
	{
		Dictionary<uint, List<uint>> dictionary = new Dictionary<uint, List<uint>>();
		foreach (GridFightRoleBasicInfoExcel value2 in GameData.GridFightRoleBasicInfoData.Values)
		{
			if (value2.IsInPool && (value2.SeasonID == 0 || value2.SeasonID == Season) && value2.AvatarID >= 1000 && value2.AvatarID < 2000)
			{
				if (!dictionary.TryGetValue(value2.Rarity, out var value))
				{
					value = (dictionary[value2.Rarity] = new List<uint>());
				}
				value.Add(value2.ID);
			}
		}
		return dictionary;
	}

	private static uint RollShopRarity(IReadOnlyList<uint> weights, Random rng)
	{
		uint num = 0u;
		for (int i = 0; i < Math.Min(5, weights.Count); i++)
		{
			num += weights[i];
		}
		if (num == 0)
		{
			return 1u;
		}
		uint num2 = (uint)rng.Next(1, (int)(num + 1));
		for (int j = 0; j < Math.Min(5, weights.Count); j++)
		{
			if (num2 <= weights[j])
			{
				return (uint)(j + 1);
			}
			num2 -= weights[j];
		}
		return 1u;
	}

	private static uint GetShopGoodsPrice(uint rarity, uint star)
	{
		if (!GameData.GridFightShopPriceData.TryGetValue(rarity, out GridFightShopPriceExcel value))
		{
			return 1u;
		}
		int index = (int)(Math.Clamp(star, 1u, 4u) - 1);
		return value.BuyGoldList[index];
	}

	public void RefreshEquipDraft()
	{
		int num = BattlesFinished * 3 % StageCandidates.Count;
		CurrentEquipDraft = new List<uint>
		{
			StageCandidates[num % StageCandidates.Count],
			StageCandidates[(num + 1) % StageCandidates.Count],
			StageCandidates[(num + 2) % StageCandidates.Count]
		};
	}

	public (bool ok, uint addedUniqueId, uint roleId, uint pos) TryBuyGoods(int shopIndex)
	{
		if (shopIndex < 0 || shopIndex >= ShopGoods.Count)
		{
			return (ok: false, addedUniqueId: 0u, roleId: 0u, pos: 0u);
		}
		GridFightShopGoodsInfo gridFightShopGoodsInfo = ShopGoods[shopIndex];
		if (gridFightShopGoodsInfo.RoleGoodsInfo == null || gridFightShopGoodsInfo.IsSoldOut)
		{
			return (ok: false, addedUniqueId: 0u, roleId: 0u, pos: 0u);
		}
		uint shopGoodsPrice = gridFightShopGoodsInfo.ShopGoodsPrice;
		if (Gold < shopGoodsPrice)
		{
			Gold = shopGoodsPrice;
		}
		Gold -= shopGoodsPrice;
		gridFightShopGoodsInfo.IsSoldOut = true;
		uint roleId = gridFightShopGoodsInfo.RoleGoodsInfo.RoleId;
		uint num = AllocRoleUniqueId();
		RoleByUniqueId[num] = roleId;
		RoleStarByUniqueId[num] = 1u;
		uint num2 = 0u;
		uint[] array = new uint[13]
		{
			14u, 15u, 16u, 17u, 18u, 6u, 7u, 8u, 9u, 10u,
			11u, 12u, 13u
		};
		foreach (uint num3 in array)
		{
			if (!UniqueIdByPos.ContainsKey(num3))
			{
				num2 = num3;
				break;
			}
		}
		if (num2 != 0)
		{
			UniqueIdByPos[num2] = num;
		}
		return (ok: true, addedUniqueId: num, roleId: roleId, pos: num2);
	}

	public RoleMergeResult TryAutoMergeRole(uint roleId, uint roleUniqueId)
	{
		RoleMergeResult roleMergeResult = new RoleMergeResult();
		if (roleId == 0 || roleUniqueId == 0)
		{
			return roleMergeResult;
		}
		uint keepUniqueId = roleUniqueId;
		uint currentStar = RoleStarByUniqueId.GetValueOrDefault(keepUniqueId, 1u);
		while (true)
		{
			uint num = currentStar + 1;
			if (!GameData.GridFightRoleStarData.ContainsKey((roleId << 4) | num))
			{
				break;
			}
			List<uint> list = (from kv in RoleByUniqueId
				where kv.Value == roleId && RoleStarByUniqueId.GetValueOrDefault(kv.Key, 1u) == currentStar
				select kv.Key).Distinct().ToList();
			if (list.Count < 3)
			{
				break;
			}
			if (!list.Contains(keepUniqueId))
			{
				keepUniqueId = list[0];
			}
			List<uint> list2 = list.Where((uint x) => x != keepUniqueId).Take(2).ToList();
			if (list2.Count < 2)
			{
				break;
			}
			foreach (uint uid in list2)
			{
				RoleByUniqueId.Remove(uid);
				RoleStarByUniqueId.Remove(uid);
				foreach (uint item in (from kv in UniqueIdByPos
					where kv.Value == uid
					select kv.Key).ToList())
				{
					UniqueIdByPos.Remove(item);
				}
				roleMergeResult.RemovedUniqueIds.Add(uid);
			}
			currentStar = num;
			RoleStarByUniqueId[keepUniqueId] = currentStar;
		}
		if (roleMergeResult.RemovedUniqueIds.Count > 0)
		{
			roleMergeResult.KeptUniqueId = keepUniqueId;
			roleMergeResult.NewStar = RoleStarByUniqueId.GetValueOrDefault(keepUniqueId, 1u);
		}
		return roleMergeResult;
	}

	public (bool ok, uint refund) TryRecycleRole(uint uniqueId)
	{
		if (!RoleByUniqueId.TryGetValue(uniqueId, out var value))
		{
			return (ok: false, refund: 0u);
		}
		RoleByUniqueId.Remove(uniqueId);
		uint valueOrDefault = RoleStarByUniqueId.GetValueOrDefault(uniqueId, 1u);
		RoleStarByUniqueId.Remove(uniqueId);
		foreach (uint item in (from kv in UniqueIdByPos
			where kv.Value == uniqueId
			select kv.Key).ToList())
		{
			UniqueIdByPos.Remove(item);
		}
		uint roleSellPrice = GetRoleSellPrice(value, valueOrDefault);
		Gold += roleSellPrice;
		return (ok: true, refund: roleSellPrice);
	}

	private static uint GetRoleSellPrice(uint roleId, uint roleStar)
	{
		if (!GameData.GridFightRoleBasicInfoData.TryGetValue(roleId, out GridFightRoleBasicInfoExcel value))
		{
			return 1u;
		}
		if (!GameData.GridFightShopPriceData.TryGetValue(value.Rarity, out GridFightShopPriceExcel value2))
		{
			return 1u;
		}
		int index = (int)(Math.Clamp(roleStar, 1u, 4u) - 1);
		return value2.SellGoldList[index];
	}

	public bool TryRefreshShop()
	{
		uint num = ((ShopRefreshLeft == 0) ? 2u : ShopRefreshLeft);
		Gold = ((Gold >= num) ? (Gold - num) : 0u);
		RotateShop();
		return true;
	}

	public bool TryBuyExp()
	{
		uint num = GetBuyExpCost();
		if (num == 0)
		{
			num = 4u;
		}
		Gold = ((Gold >= num) ? (Gold - num) : 0u);
		AddPlayerExp(num);
		return true;
	}

	public uint GetBuyExpCost()
	{
		if (GameData.GridFightPlayerLevelData.TryGetValue(PlayerLevel, out GridFightPlayerLevelExcel value) && value.LevelUpExp == 0)
		{
			return 0u;
		}
		return 4u;
	}

	public uint GetCurrentMaxBattleRoleNum()
	{
		if (GameData.GridFightPlayerLevelData.TryGetValue(PlayerLevel, out GridFightPlayerLevelExcel value))
		{
			return Math.Clamp(value.AvatarMaxNumber, 0u, 13u);
		}
		return 4u;
	}

	private void AddPlayerExp(uint value)
	{
		if (value == 0)
		{
			return;
		}
		PlayerExp += value;
		while (PlayerLevel < GetConfiguredMaxPlayerLevel())
		{
			uint levelUpExpNeed = GetLevelUpExpNeed(PlayerLevel);
			if (levelUpExpNeed != 0 && PlayerExp >= levelUpExpNeed)
			{
				PlayerExp -= levelUpExpNeed;
				PlayerLevel++;
				continue;
			}
			break;
		}
	}

	public void GainPlayerExp(uint value)
	{
		AddPlayerExp(value);
	}

	public (List<uint> removedOrbUniqueIds, bool levelChanged, bool goldChanged) TryUseOrbs(IEnumerable<uint> uniqueIds, bool isGetAll)
	{
		List<uint> obj = (isGetAll ? OrbItemByUniqueId.Keys.ToList() : uniqueIds.Distinct().ToList());
		List<uint> list = new List<uint>();
		uint playerLevel = PlayerLevel;
		uint playerExp = PlayerExp;
		uint gold = Gold;
		foreach (uint item3 in obj)
		{
			if (!OrbItemByUniqueId.TryGetValue(item3, out var value))
			{
				continue;
			}
			OrbItemByUniqueId.Remove(item3);
			list.Add(item3);
			if (GameData.GridFightOrbData.TryGetValue(value, out GridFightOrbExcel value2))
			{
				switch (value2.Type)
				{
				case GridFightOrbTypeEnum.White:
					Gold += 2u;
					break;
				case GridFightOrbTypeEnum.Blue:
					AddPlayerExp(2u);
					break;
				case GridFightOrbTypeEnum.Glod:
					Gold += 5u;
					break;
				case GridFightOrbTypeEnum.Colorful:
					AddPlayerExp(4u);
					break;
				case GridFightOrbTypeEnum.BigColorful:
					AddPlayerExp(8u);
					break;
				case GridFightOrbTypeEnum.GoldenEgg:
					Gold += 8u;
					break;
				default:
					Gold++;
					break;
				}
			}
		}
		bool item = PlayerLevel != playerLevel || PlayerExp != playerExp;
		bool item2 = Gold != gold;
		return (removedOrbUniqueIds: list, levelChanged: item, goldChanged: item2);
	}

	public uint GetLevelUpExpNeed(uint level)
	{
		if (GameData.GridFightPlayerLevelData.TryGetValue(level, out GridFightPlayerLevelExcel value))
		{
			return value.LevelUpExp;
		}
		return 4u;
	}

	public uint GetConfiguredMaxPlayerLevel()
	{
		if (GameData.GridFightPlayerLevelData.Count > 0)
		{
			return GameData.GridFightPlayerLevelData.Keys.Max();
		}
		return PlayerMaxLevel;
	}

	public uint GetEnemyDifficultyLevel()
	{
		if (GameData.GridFightDivisionStageData.TryGetValue(DivisionId, out GridFightDivisionStageExcel value) && value.EnemyDifficultyLevel != 0)
		{
			return value.EnemyDifficultyLevel;
		}
		return 1u;
	}

	public bool TryEquipFromDraft(uint idx)
	{
		if (idx >= CurrentEquipDraft.Count)
		{
			return false;
		}
		uint gridFightEquipmentId = CurrentEquipDraft[(int)idx];
		Equipments.Add(new GridFightEquipmentInfo
		{
			GridFightEquipmentId = gridFightEquipmentId,
			Source = 1u,
			UniqueId = AllocEquipUniqueId()
		});
		return true;
	}

	public void OnBattleResolved(bool win)
	{
		BattlesFinished++;
		if (win)
		{
			KeepWinCnt++;
			SectionId++;
		}
		ShopRefreshLeft = 2u;
		RotateShop();
		RefreshEquipDraft();
	}

	public void RecordBattleSnapshot(PVEBattleResultCsReq req, bool win)
	{
		PreBattleLineupHp = LineupHp;
		PreBattleLevel = PlayerLevel;
		PreBattleExp = PlayerExp;
		PreBattleGold = Gold;
		LastBattleDamageStt = new GridFightDamageSttInfo();
		HashSet<uint> hashSet = new HashSet<uint>();
		if (req.Stt?.OGPOFMOGPIP?.JPDJMCCKENI != null)
		{
			foreach (KJFFJMAMJLD item in req.Stt.OGPOFMOGPIP.JPDJMCCKENI)
			{
				uint roleId = item.RoleId;
				if (roleId != 0)
				{
					bool flag = item.Damage > 0.0 || item.BOIEGPAPHOP > 0.0;
					if (flag)
					{
						hashSet.Add(roleId);
					}
					LastBattleDamageStt.EABPCKEDDBH.Add(new HHHMMJBGCNG
					{
						RoleId = roleId,
						RoleStar = 1u,
						TotalDamage = item.Damage,
						LDMNBDIDFCC = flag,
						HNLEDBPGDBC = !flag
					});
				}
			}
		}
		LastRewardedOrbs.Clear();
		LastSectionRewards.Clear();
		LastHpModifyTimeline.Clear();
		if (win)
		{
			Gold += 3u;
			Gold++;
			GridFightDropInfo gridFightDropInfo = new GridFightDropInfo();
			uint[] section1RewardOrbs = Section1RewardOrbs;
			foreach (uint num in section1RewardOrbs)
			{
				uint num2 = AllocOrbUniqueId();
				LastRewardedOrbs.Add((num, num2));
				OrbItemByUniqueId[num2] = num;
				gridFightDropInfo.PIBLJLBCKJL.Add(new LHPPIAKKFME
				{
					BGKDAMDFFKH = GridFightDropType.HiolcnpoponMkppcdpchie,
					JJFFLMCCCMM = num,
					Num = 1u
				});
			}
			LastSectionRewards[2u] = gridFightDropInfo;
			AddPlayerExp(2u);
			BattleStatistics stt = req.Stt;
			bool flag2 = stt != null && stt.OGPOFMOGPIP?.GMOBFEBBFIE >= 0.0;
			if (req.EndStatus == BattleEndStatus.BattleEndWin && flag2)
			{
				LineupHp = Math.Min(LineupMaxHp, LineupHp + 2);
			}
			uint preBattleLineupHp = PreBattleLineupHp;
			GridFightUpdateGlobalHpReason[] array = new GridFightUpdateGlobalHpReason[4]
			{
				GridFightUpdateGlobalHpReason.BakggpnhnneAhikonfebmj,
				GridFightUpdateGlobalHpReason.BakggpnhnneIkhlilhaiol,
				GridFightUpdateGlobalHpReason.BakggpnhnnePonicjjabek,
				GridFightUpdateGlobalHpReason.BakggpnhnneGpdhibafdcg
			};
			foreach (GridFightUpdateGlobalHpReason reason in array)
			{
				LastHpModifyTimeline.Add(new GridFightHpModifyInfo
				{
					Reason = reason,
					FGEDKOINMAG = (int)preBattleLineupHp,
					EHMKLNEKIOE = (int)preBattleLineupHp
				});
			}
			LastHpModifyTimeline.Add(new GridFightHpModifyInfo
			{
				Reason = GridFightUpdateGlobalHpReason.BakggpnhnneGfimnccfkik,
				FGEDKOINMAG = (int)PreBattleLineupHp,
				EHMKLNEKIOE = (int)LineupHp,
				HPOPDNGCALL = LineupHp - PreBattleLineupHp,
				PDEKDHPNCEN = 1081u
			});
		}
	}

	public GridFightSeasonHandBookNotify BuildHandbookNotifyForBattle()
	{
		GridFightSeasonHandBookNotify gridFightSeasonHandBookNotify = new GridFightSeasonHandBookNotify();
		gridFightSeasonHandBookNotify.HandbookGridFightPortalInfo = new GridFightHandBookPortalInfo();
		gridFightSeasonHandBookNotify.HandbookGridFightPortalInfo.GridFightPortalBuffList.Add(132u);
		return gridFightSeasonHandBookNotify;
	}

	public GridFightEndBattleStageNotify BuildEndBattleNotify(bool win)
	{
		GridFightEndBattleStageNotify gridFightEndBattleStageNotify = new GridFightEndBattleStageNotify
		{
			BCOLJFHDLLD = LineupHp,
			FGEDKOINMAG = PreBattleLineupHp,
			IJEIEJLPGGJ = LineupMaxHp,
			KDOINLGKMBI = LineupMaxHp,
			DCPKPNLKGMM = Level,
			NDOCIKPLKIF = NDOCIKPLKIF,
			SectionId = SectionId,
			EJEIBPEKHLD = PlayerLevel,
			PNOJLNNHBIH = 1u,
			HPOACJCPJHN = win,
			GCBBEEGANEG = new MIOMFOAEHEC
			{
				IPHHGMECAKB = new BLKAIEHOCBC
				{
					Level = PlayerLevel,
					Exp = PlayerExp,
					DKHKEJIAJBN = GetLevelUpExpNeed(PlayerLevel)
				},
				IJAEBDCFEMG = new BLKAIEHOCBC
				{
					Level = PlayerLevel,
					DKHKEJIAJBN = GetLevelUpExpNeed(PlayerLevel)
				},
				MAGCGPMHHEA = 2u
			}
		};
		if (LastBattleDamageStt != null)
		{
			gridFightEndBattleStageNotify.GridFightDamageSttInfo = LastBattleDamageStt.Clone();
		}
		foreach (var (key, gridFightDropInfo2) in LastSectionRewards)
		{
			gridFightEndBattleStageNotify.DHMBKAPKJFN[key] = gridFightDropInfo2.Clone();
		}
		foreach (GridFightHpModifyInfo item in LastHpModifyTimeline)
		{
			gridFightEndBattleStageNotify.NNFAFGCGMBB.Add(item.Clone());
		}
		return gridFightEndBattleStageNotify;
	}

	public BattleInstance? StartBattle()
	{
		return GridFightBattleModule.StartBattle(Player, this);
	}

	public void ConfigureNextBattle(uint stageId, IEnumerable<uint> monsterIds)
	{
		BattleComponent.SetEncounter(stageId, monsterIds);
	}

	public async ValueTask EndBattle(BattleInstance battle, PVEBattleResultCsReq req)
	{
		bool win = req.EndStatus != BattleEndStatus.BattleEndLose;
		RecordBattleSnapshot(req, win);
		AdvanceQueue(7u);
		PendingAction = new GridFightPendingAction
		{
			QueuePosition = QueuePosition,
			RoundBeginAction = new GridFightRoundBeginActionInfo()
		};
		await Player.SendPacket(new PacketGridFightSyncUpdateResultScNotify(Player, 9));
		await Player.SendPacket(new PacketGridFightEndBattleStageNotify(this, win));
		await Player.SendPacket(new PacketGridFightSyncUpdateResultScNotify(Player, 7));
		OnBattleResolved(win);
		await Player.SendPacket(new PacketGridFightSyncUpdateResultScNotify(Player, 4));
	}

	public GridFightCurrentInfo ToProto()
	{
		EnsureDefaultRoles();
		if (CurrentEquipDraft.Count == 0)
		{
			RefreshEquipDraft();
		}
		if (ShopGoods.Count == 0)
		{
			RotateShop();
		}
		GridFightCurrentInfo obj = new GridFightCurrentInfo
		{
			Season = Season,
			DivisionId = DivisionId,
			IsOverlock = IsOverLock,
			UniqueId = UniqueId,
			PendingAction = (PendingAction ?? new GridFightPendingAction
			{
				QueuePosition = QueuePosition,
				PortalBuffAction = new GridFightPortalBuffActionInfo
				{
					FCHPJKAIBHB = 1u,
					GridFightPortalBuffList = { (IEnumerable<uint>)EnsurePortalBuffOffer() }
				}
			}),
			BCHPAOCOHIL = new FCBEHGJBJCN
			{
				AMNJHJJMPJF = { (IEnumerable<uint>)CurrentEquipDraft }
			}
		};
		GridFightGameData obj2 = new GridFightGameData
		{
			PGFMICHMHFC = 
			{
				new GridFightGameItemInfo
				{
					UniqueId = 4u,
					LMGLPGNACLP = new DCGINOONGLH()
				}
			}
		};
		RepeatedField<GridFightGameItemInfo> pGFMICHMHFC = obj2.PGFMICHMHFC;
		GridFightGameItemInfo obj3 = new GridFightGameItemInfo
		{
			UniqueId = 8u
		};
		HJJHNNDAEPF hJJHNNDAEPF = new HJJHNNDAEPF();
		hJJHNNDAEPF.KIBHCHLKGGC[1u] = 2u;
		hJJHNNDAEPF.KIBHCHLKGGC[2u] = 2u;
		hJJHNNDAEPF.KIBHCHLKGGC[3u] = 4u;
		hJJHNNDAEPF.KIBHCHLKGGC[4u] = 6u;
		hJJHNNDAEPF.KIBHCHLKGGC[5u] = 20u;
		hJJHNNDAEPF.KIBHCHLKGGC[6u] = 40u;
		hJJHNNDAEPF.KIBHCHLKGGC[7u] = 52u;
		hJJHNNDAEPF.KIBHCHLKGGC[8u] = 72u;
		hJJHNNDAEPF.KIBHCHLKGGC[9u] = 84u;
		hJJHNNDAEPF.KIBHCHLKGGC[10u] = 0u;
		obj3.MDFGMBJONAM = hJJHNNDAEPF;
		pGFMICHMHFC.Add(obj3);
		obj2.PGFMICHMHFC.Add(new GridFightGameItemInfo
		{
			UniqueId = 9u
		});
		obj2.PGFMICHMHFC.Add(new GridFightGameItemInfo
		{
			UniqueId = 12u,
			ONJFAJOAFOG = new KPNJMMPJDKG()
		});
		obj2.PGFMICHMHFC.Add(new GridFightGameItemInfo
		{
			UniqueId = 49u,
			CJPMGPEIFGG = new BFBNMHEFKIG
			{
				CGDLGFHOECL = 2u
			}
		});
		obj2.PGFMICHMHFC.Add(new GridFightGameItemInfo
		{
			UniqueId = 87u,
			CJPMGPEIFGG = new BFBNMHEFKIG
			{
				CGDLGFHOECL = 1u
			}
		});
		obj.GridFightGameData = obj2;
		obj.RogueCurrentGameInfo.Add(BuildBasicInfoSection());
		obj.RogueCurrentGameInfo.Add(BuildTeamSection());
		obj.RogueCurrentGameInfo.Add(BuildDraftSection());
		obj.RogueCurrentGameInfo.Add(BuildItemsShopSection());
		obj.RogueCurrentGameInfo.Add(BuildOrbSection());
		obj.RogueCurrentGameInfo.Add(BuildLevelSection());
		obj.RogueCurrentGameInfo.Add(new GridFightGameInfo
		{
			GridOrbInfo = new GridFightGameAugmentSync()
		});
		obj.RogueCurrentGameInfo.Add(BuildAugmentSection());
		obj.RogueCurrentGameInfo.Add(BuildTeamGameInfoSection());
		return obj;
	}

	private GridFightGameInfo BuildBasicInfoSection()
	{
		return new GridFightGameInfo
		{
			GridBasicInfo = new GridFightGameBasicInfo
			{
				ANBBPPHBCJH = 3u,
				FLEJPPKLJIC = 3u,
				HAEOPKELNEO = 10u,
				Gold = Gold,
				GridFightBuyExpCost = 4u,
				GridFightLineupHp = LineupHp,
				GridFightLineupMaxHp = LineupMaxHp,
				GridFightMaxAvatarCount = 9u,
				GridFightMaxInterestGold = 5u,
				GridFightOffFieldMaxCount = 6u,
				GridFightSyncCurtaskInfo = new GridFightSyncCurrentTaskInfo(),
				GameLockInfo = new GridFightLockInfo()
			}
		};
	}

	private GridFightGameInfo BuildTeamSection()
	{
		GridFightGameTeamInfo gridFightGameTeamInfo = new GridFightGameTeamInfo();
		foreach (var (pos, num3) in UniqueIdByPos.OrderBy((KeyValuePair<uint, uint> kv) => kv.Key))
		{
			if (num3 != 0 && RoleByUniqueId.TryGetValue(num3, out var value))
			{
				gridFightGameTeamInfo.GridGameRoleList.Add(new GridGameRoleInfo
				{
					Id = value,
					Pos = pos,
					RoleStar = RoleStarByUniqueId.GetValueOrDefault(num3, 1u),
					UniqueId = num3
				});
			}
		}
		return new GridFightGameInfo
		{
			GridTraitGameInfo = gridFightGameTeamInfo
		};
	}

	private GridFightGameInfo BuildDraftSection()
	{
		GridFightGameItemsInfo gridFightGameItemsInfo = new GridFightGameItemsInfo();
		foreach (GridFightConsumableInfo consumable in Consumables)
		{
			gridFightGameItemsInfo.GridFightConsumableList.Add(consumable);
		}
		foreach (GridFightEquipmentInfo equipment in Equipments)
		{
			gridFightGameItemsInfo.GridFightEquipmentList.Add(equipment);
		}
		return new GridFightGameInfo
		{
			GridDraftInfo = gridFightGameItemsInfo
		};
	}

	private GridFightGameInfo BuildItemsShopSection()
	{
		return new GridFightGameInfo
		{
			GridItemsInfo = new GridFightGameShopInfo
			{
				GLIFNMBMMBL = ShopRefreshLeft,
				DNOIFMMLJDN = { (IEnumerable<uint>)ShopRolePool },
				LDEDGOOKHFL = new FJPONJFLOOH
				{
					EDJPMNLLGGB = 
					{
						new MJJEHCBNOKI
						{
							MMKNFIFOPPA = 1u,
							FLICPMGFKOK = 100u
						},
						new MJJEHCBNOKI
						{
							MMKNFIFOPPA = 2u
						},
						new MJJEHCBNOKI
						{
							MMKNFIFOPPA = 3u
						},
						new MJJEHCBNOKI
						{
							MMKNFIFOPPA = 4u
						},
						new MJJEHCBNOKI
						{
							MMKNFIFOPPA = 5u
						}
					}
				},
				ShopGoodsList = { (IEnumerable<GridFightShopGoodsInfo>)ShopGoods }
			}
		};
	}

	private GridFightGameInfo BuildOrbSection()
	{
		return new GridFightGameInfo
		{
			GridLevelInfo = new GridFightGameOrbInfo
			{
				GridGameOrbList = { OrbItemByUniqueId.Select((KeyValuePair<uint, uint> kv) => new GridGameOrbInfo
				{
					UniqueId = kv.Key,
					OrbItemId = kv.Value
				}) }
			}
		};
	}

	private GridFightGameInfo BuildLevelSection()
	{
		GridFightLevelInfo gridFightLevelInfo = new GridFightLevelInfo
		{
			DCPKPNLKGMM = Level,
			NDOCIKPLKIF = NDOCIKPLKIF,
			SectionId = SectionId,
			ECCGJDMOGAN = new DDJIOFONKME(),
			BossInfo = new GridFightBossInfo(),
			CMHBDMOJJEN = new IKFEDFBLOOG()
		};
		EnsureSessionPreview();
		foreach (uint sessionCampId in SessionCampIds)
		{
			gridFightLevelInfo.HGAHMIPIBLO.Add(new OPBCCOLPDPC
			{
				PMOGHFIGKPO = sessionCampId
			});
		}
		foreach (uint sectionAffixId in SectionAffixIds)
		{
			gridFightLevelInfo.IAKFPMOEJLF.Add(new DIBJGAKOCLO
			{
				AffixId = sectionAffixId
			});
		}
		foreach (uint activePortalBuffId in ActivePortalBuffIds)
		{
			gridFightLevelInfo.GridFightPortalBuffList.Add(new GridFightGamePortalBuffInfo
			{
				PortalBuffId = activePortalBuffId
			});
		}
		return new GridFightGameInfo
		{
			GridShopInfo = gridFightLevelInfo
		};
	}

	private GridFightGameInfo BuildAugmentSection()
	{
		GridFightGameTraitInfo gridFightGameTraitInfo = new GridFightGameTraitInfo();
		gridFightGameTraitInfo.ALIDDLBDPDH.Add(new ELEOGABGBKG
		{
			DMEKIFJDKFL = 8007u,
			CELFGCJFMPH = { 8007u, 8009u }
		});
		gridFightGameTraitInfo.ALIDDLBDPDH.Add(new ELEOGABGBKG
		{
			DMEKIFJDKFL = 11011u,
			CELFGCJFMPH = { 11011u, 11012u }
		});
		return new GridFightGameInfo
		{
			GridAugmentInfo = gridFightGameTraitInfo
		};
	}

	private GridFightGameInfo BuildTeamGameInfoSection()
	{
		GridFightGameInfo gridFightGameInfo = new GridFightGameInfo();
		LHFDOPGEOML lHFDOPGEOML = new LHFDOPGEOML();
		lHFDOPGEOML.ANLGPLOLMOH = 8u;
		lHFDOPGEOML.OGHGLMGJGEM["GP_Avatar_Sparxie_00"] = 2u;
		gridFightGameInfo.GridTeamGameInfo = lHFDOPGEOML;
		return gridFightGameInfo;
	}
}
