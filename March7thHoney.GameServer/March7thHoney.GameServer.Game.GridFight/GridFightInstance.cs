using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Protobuf.Collections;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.GameServer.Game.Battle;
using March7thHoney.GameServer.Game.GridFight.Battle;
using March7thHoney.GameServer.Game.GridFight.Component;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.GridFight;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.GridFight;

public class GridFightInstance
{
	public static readonly (uint AvatarId, uint Pos, uint UniqueId, string Component)[] InitialBenchRoles = new(uint, uint, uint, string)[4]
	{
		(1009u, 15u, 5u, "GP_Avatar_Asta_01"),
		(1306u, 16u, 6u, "GP_Avatar_Sparkle_01"),
		(1403u, 17u, 7u, "GP_Avatar_Tribbie_01"),
		(1502u, 18u, 8u, "GP_Avatar_YaoGuang_01")
	};

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

	public Dictionary<uint, uint> RoleByUniqueId { get; }

	public Dictionary<uint, uint> UniqueIdByPos { get; }

	public Dictionary<uint, uint> RoleStarByUniqueId { get; }

	public uint ShopRefreshLeft { get; set; }

	public List<GridFightShopGoodsInfo> ShopGoods { get; }

	public List<uint> ShopRolePool { get; }

	public List<uint> StageCandidates { get; }

	public List<uint> CurrentEquipDraft { get; private set; }

	public List<GridFightEquipmentInfo> Equipments { get; }

	public List<GridFightConsumableInfo> Consumables { get; }

	public List<uint> SectionAffixIds { get; }

	public List<uint> ActivePortalBuffIds { get; }

	public List<uint> AvailablePortalBuffRerolls { get; }

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
		RoleByUniqueId = new Dictionary<uint, uint>();
		UniqueIdByPos = new Dictionary<uint, uint>();
		RoleStarByUniqueId = new Dictionary<uint, uint>();
		ShopRefreshLeft = 2u;
		ShopGoods = new List<GridFightShopGoodsInfo>();
		ShopRolePool = new List<uint>
		{
			1217u, 1314u, 1108u, 1220u, 1406u, 1001u, 1009u, 1306u, 1403u, 1502u,
			1408u, 1321u, 1409u, 1402u
		};
		StageCandidates = new List<uint> { 35030205u, 35030405u, 35030208u, 350202u, 35030606u };
		CurrentEquipDraft = new List<uint> { 35030205u, 35030405u, 35030208u };
		Equipments = new List<GridFightEquipmentInfo>
		{
			new GridFightEquipmentInfo
			{
				GridFightEquipmentId = 350205u,
				Source = 1u,
				UniqueId = 10u
			}
		};
		Consumables = new List<GridFightConsumableInfo>
		{
			new GridFightConsumableInfo
			{
				ItemId = 350101u,
				Num = 1u
			}
		};
		SectionAffixIds = new List<uint> { 1002u, 3005u, 4010u };
		ActivePortalBuffIds = new List<uint> { 106u };
		AvailablePortalBuffRerolls = new List<uint> { 105u, 1014u, 132u };
		base._002Ector();
	}

	public void EnsureDefaultRoles()
	{
		if (ShopGoods.Count == 0)
		{
			RotateShop();
		}
	}

	public void MaterializeInitialBenchTeam()
	{
		if (RoleByUniqueId.Count <= 0)
		{
			(uint, uint, uint, string)[] initialBenchRoles = InitialBenchRoles;
			for (int i = 0; i < initialBenchRoles.Length; i++)
			{
				var (value, key, num, _) = initialBenchRoles[i];
				RoleByUniqueId[num] = value;
				RoleStarByUniqueId[num] = 1u;
				UniqueIdByPos[key] = num;
			}
		}
	}

	public uint AllocRoleUniqueId()
	{
		return ++NextRoleUniqueId;
	}

	public uint AllocEquipUniqueId()
	{
		return ++NextEquipUniqueId;
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
			if (posInfo.UniqueId != 0 && !RoleByUniqueId.ContainsKey(posInfo.UniqueId))
			{
				RoleByUniqueId[posInfo.UniqueId] = 8001u;
				RoleStarByUniqueId[posInfo.UniqueId] = 1u;
			}
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
		if (ShopRolePool.Count != 0)
		{
			for (int i = 0; i < 5; i++)
			{
				uint roleId = ShopRolePool[(BattlesFinished * 5 + i) % ShopRolePool.Count];
				ShopGoods.Add(new GridFightShopGoodsInfo
				{
					ShopGoodsPrice = 1u,
					RoleGoodsInfo = new GridFightRoleGoodsInfo
					{
						RoleId = roleId,
						RoleStar = 1u
					}
				});
			}
		}
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
		if (gridFightShopGoodsInfo.RoleGoodsInfo == null)
		{
			return (ok: false, addedUniqueId: 0u, roleId: 0u, pos: 0u);
		}
		uint shopGoodsPrice = gridFightShopGoodsInfo.ShopGoodsPrice;
		if (Gold < shopGoodsPrice)
		{
			Gold = shopGoodsPrice;
		}
		Gold -= shopGoodsPrice;
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

	public (bool ok, uint refund) TryRecycleRole(uint uniqueId)
	{
		if (!RoleByUniqueId.Remove(uniqueId))
		{
			return (ok: false, refund: 0u);
		}
		RoleStarByUniqueId.Remove(uniqueId);
		foreach (uint item in (from kv in UniqueIdByPos
			where kv.Value == uniqueId
			select kv.Key).ToList())
		{
			UniqueIdByPos.Remove(item);
		}
		uint num = 1u;
		Gold += num;
		return (ok: true, refund: num);
	}

	public bool TryRefreshShop()
	{
		if (ShopRefreshLeft == 0)
		{
			ShopRefreshLeft = 1u;
		}
		ShopRefreshLeft--;
		RotateShop();
		return true;
	}

	public bool TryBuyExp()
	{
		Gold = ((Gold >= 4) ? (Gold - 4) : 0u);
		return true;
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
			Gold += 5u;
		}
		else
		{
			LineupHp = ((LineupHp >= 20) ? (LineupHp - 20) : 0u);
		}
		ShopRefreshLeft = 2u;
		RotateShop();
		RefreshEquipDraft();
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
		return new GridFightEndBattleStageNotify
		{
			BCOLJFHDLLD = LineupHp,
			FGEDKOINMAG = LineupHp,
			IJEIEJLPGGJ = LineupMaxHp,
			KDOINLGKMBI = LineupMaxHp,
			DCPKPNLKGMM = Level,
			NDOCIKPLKIF = NDOCIKPLKIF,
			SectionId = SectionId,
			EJEIBPEKHLD = 3u,
			PNOJLNNHBIH = 1u,
			HPOACJCPJHN = win
		};
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
		AdvanceQueue(7u);
		PendingAction = new GridFightPendingAction
		{
			QueuePosition = QueuePosition,
			RoundBeginAction = new GridFightRoundBeginActionInfo()
		};
		await Player.SendPacket(new PacketGridFightEndBattleStageNotify(this, win));
		await Player.SendPacket(new PacketGridFightSyncUpdateResultScNotify(Player, 7));
		OnBattleResolved(win);
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
					GridFightPortalBuffList = { 1115u, 106u, 147u }
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
				GridGameOrbList = 
				{
					new GridGameOrbInfo
					{
						OrbItemId = 199u,
						UniqueId = 7u
					}
				}
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
		gridFightLevelInfo.HGAHMIPIBLO.Add(new OPBCCOLPDPC
		{
			PMOGHFIGKPO = 17u
		});
		gridFightLevelInfo.HGAHMIPIBLO.Add(new OPBCCOLPDPC
		{
			PMOGHFIGKPO = 8u
		});
		gridFightLevelInfo.HGAHMIPIBLO.Add(new OPBCCOLPDPC
		{
			PMOGHFIGKPO = 24u
		});
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
