using System;
using System.Collections.Generic;
using System.Linq;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.GameServer.Game.GridFight.Battle;
using March7thHoney.GameServer.Game.GridFight.Sync;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.GridFight;

public class GridFightManager : BasePlayerManager
{
	public GridFightInstance? GridFightInstance { get; set; }

	public uint CurUniqueId { get; set; }

	public GridFightManager(PlayerInstance player)
		: base(player)
	{
	}

	private static uint MaxDivisionId()
	{
		if (GameData.GridFightDivisionInfoData.Count <= 0)
		{
			return 10940u;
		}
		return GameData.GridFightDivisionInfoData.Keys.Max();
	}

	public GridFightSystemInfo ToProto()
	{
		uint divisionId = MaxDivisionId();
		GridFightStaticGameInfo gridFightStaticGameInfo = new GridFightStaticGameInfo
		{
			DivisionId = divisionId,
			CKFIACKHNAE = 1u,
			CALIMAKGGHJ = 3u,
			Exp = new JIBAKJGOPJM(),
			OJLAODIALLE = new GridFightTalentInfo(),
			EJCFDAABLOC = new GridFightHandBookInfo
			{
				GridFightMonsterInfo = new GridFightHandBookMonsterInfo(),
				GridFightRoleInfo = new GridFightHandBookRoleInfo(),
				GridFightPortalInfo = new GridFightHandBookPortalInfo(),
				GridFightEquipInfo = new GridFightHandBookEquipInfo(),
				GridFightAugmentInfo = new GridFightHandBookAugmentInfo()
			}
		};
		if (GameData.GridFightSeasonTalentData.Count > 0)
		{
			gridFightStaticGameInfo.OJLAODIALLE.DANAGDAPKJE.Add(GameData.GridFightSeasonTalentData.Keys.OrderBy((uint x) => x));
		}
		else
		{
			gridFightStaticGameInfo.OJLAODIALLE.DANAGDAPKJE.Add(new _003C_003Ez__ReadOnlyArray<uint>(new uint[40]
			{
				2011u, 2021u, 2022u, 2031u, 2032u, 2033u, 2041u, 2042u, 2043u, 2044u,
				2051u, 2061u, 2062u, 2063u, 3011u, 3021u, 3022u, 3031u, 3032u, 3033u,
				3041u, 3042u, 3043u, 3044u, 3051u, 3061u, 3062u, 3063u, 4011u, 4021u,
				4022u, 4031u, 4032u, 4041u, 4042u, 4043u, 4051u, 4052u, 4053u, 4061u
			}));
		}
		gridFightStaticGameInfo.EJCFDAABLOC.GridFightMonsterInfo.HGAHMIPIBLO.Add(new _003C_003Ez__ReadOnlyArray<uint>(new uint[17]
		{
			1u, 2u, 4u, 5u, 6u, 8u, 10u, 11u, 12u, 13u,
			15u, 16u, 17u, 23u, 24u, 25u, 27u
		}));
		gridFightStaticGameInfo.EJCFDAABLOC.GridFightRoleInfo.GridFightAvatarList.Add(new _003C_003Ez__ReadOnlyArray<uint>(new uint[63]
		{
			1001u, 1003u, 1004u, 1005u, 1009u, 1013u, 1014u, 1015u, 1105u, 1108u,
			1112u, 1202u, 1203u, 1204u, 1205u, 1208u, 1209u, 1212u, 1213u, 1217u,
			1218u, 1220u, 1221u, 1222u, 1223u, 1225u, 1301u, 1302u, 1303u, 1304u,
			1305u, 1306u, 1307u, 1308u, 1309u, 1310u, 1313u, 1314u, 1317u, 1401u,
			1402u, 1403u, 1404u, 1405u, 1406u, 1407u, 1408u, 1409u, 1410u, 1412u,
			1413u, 1414u, 1415u, 1501u, 1502u, 1505u, 8007u, 8009u, 11011u, 11012u,
			15061u, 15062u, 15063u
		}));
		gridFightStaticGameInfo.EJCFDAABLOC.GridFightPortalInfo.PELJLONLDNM.Add(new _003C_003Ez__ReadOnlyArray<uint>(new uint[52]
		{
			101u, 102u, 103u, 104u, 105u, 106u, 107u, 108u, 109u, 110u,
			111u, 112u, 113u, 114u, 115u, 116u, 117u, 118u, 119u, 120u,
			121u, 122u, 123u, 124u, 125u, 127u, 129u, 134u, 135u, 138u,
			147u, 1001u, 1002u, 1003u, 1004u, 1005u, 1007u, 1008u, 1010u, 1014u,
			1016u, 1101u, 1102u, 1104u, 1106u, 1107u, 1112u, 1113u, 1114u, 1115u,
			1116u, 1118u
		}));
		gridFightStaticGameInfo.EJCFDAABLOC.GridFightPortalInfo.GridFightPortalBuffList.Add(new _003C_003Ez__ReadOnlyArray<uint>(new uint[26]
		{
			101u, 105u, 106u, 107u, 108u, 109u, 110u, 112u, 113u, 115u,
			120u, 121u, 123u, 124u, 127u, 129u, 138u, 1002u, 1003u, 1004u,
			1007u, 1014u, 1016u, 1112u, 1113u, 1116u
		}));
		gridFightStaticGameInfo.EJCFDAABLOC.GridFightEquipInfo.GridFightItemList.Add(new _003C_003Ez__ReadOnlyArray<uint>(new uint[76]
		{
			99990u, 99991u, 99992u, 99998u, 99999u, 350101u, 350102u, 350103u, 350104u, 350105u,
			350106u, 350107u, 350201u, 350202u, 350203u, 350204u, 350205u, 350206u, 350207u, 350208u,
			350601u, 350602u, 350701u, 352101u, 352502u, 35030101u, 35030102u, 35030103u, 35030104u, 35030105u,
			35030106u, 35030107u, 35030108u, 35030202u, 35030203u, 35030204u, 35030205u, 35030206u, 35030207u, 35030208u,
			35030303u, 35030304u, 35030305u, 35030306u, 35030307u, 35030308u, 35030404u, 35030405u, 35030406u, 35030407u,
			35030408u, 35030505u, 35030506u, 35030507u, 35030508u, 35030606u, 35030607u, 35030608u, 35030707u, 35030708u,
			35030808u, 35040101u, 35051001u, 35051006u, 35051007u, 35051008u, 35051010u, 35051012u, 35052001u, 35052002u,
			35052003u, 35052004u, 35052008u, 35052009u, 35100001u, 35100002u
		}));
		gridFightStaticGameInfo.EJCFDAABLOC.GridFightAugmentInfo.JLCDEDKPEAB.Add(new _003C_003Ez__ReadOnlyArray<uint>(new uint[77]
		{
			100301u, 100401u, 100402u, 100702u, 100901u, 101101u, 101401u, 101601u, 101602u, 102501u,
			102901u, 103001u, 103401u, 103701u, 110102u, 150101u, 150201u, 150301u, 150901u, 151101u,
			200201u, 200301u, 200502u, 200601u, 200701u, 200801u, 201001u, 201201u, 201302u, 201601u,
			202001u, 203201u, 203302u, 210701u, 210801u, 211001u, 220401u, 231101u, 250601u, 250701u,
			250801u, 251301u, 251401u, 251601u, 252201u, 252401u, 253101u, 253201u, 300401u, 300701u,
			301002u, 301301u, 301401u, 301601u, 301701u, 301901u, 302601u, 302701u, 320101u, 320301u,
			320401u, 330101u, 330201u, 330901u, 331101u, 332201u, 350101u, 350301u, 350501u, 350601u,
			350701u, 350901u, 351101u, 351401u, 351601u, 351701u, 360201u
		}));
		gridFightStaticGameInfo.EJCFDAABLOC.GridFightAugmentInfo.KDFBCMANFMB.Add(new _003C_003Ez__ReadOnlyArray<uint>(new uint[195]
		{
			100101u, 100301u, 100401u, 100402u, 100403u, 100501u, 100601u, 100701u, 100702u, 100901u,
			101101u, 101102u, 101201u, 101301u, 101401u, 101402u, 101501u, 101601u, 101602u, 101701u,
			101801u, 101901u, 102001u, 102101u, 102201u, 102501u, 102502u, 102601u, 102801u, 102901u,
			103001u, 103201u, 103202u, 103401u, 103402u, 103701u, 110101u, 110102u, 130101u, 130301u,
			130401u, 130501u, 130701u, 131001u, 131101u, 150101u, 150201u, 150301u, 150601u, 150701u,
			150801u, 150901u, 151101u, 200101u, 200201u, 200301u, 200502u, 200601u, 200602u, 200701u,
			200801u, 201001u, 201102u, 201201u, 201301u, 201302u, 201501u, 201601u, 201801u, 201901u,
			202001u, 202101u, 202201u, 202301u, 202501u, 202701u, 202901u, 203001u, 203201u, 203302u,
			210301u, 210701u, 210801u, 211001u, 220401u, 220501u, 220701u, 220801u, 230201u, 230301u,
			230401u, 230501u, 230601u, 230801u, 230901u, 231101u, 231201u, 231301u, 231601u, 250101u,
			250301u, 250401u, 250601u, 250701u, 250801u, 250901u, 251001u, 251201u, 251301u, 251401u,
			251501u, 251601u, 251801u, 252001u, 252101u, 252201u, 252301u, 252401u, 252501u, 252601u,
			252701u, 252801u, 252901u, 253101u, 253201u, 260301u, 300101u, 300401u, 300501u, 300701u,
			300801u, 300901u, 301001u, 301002u, 301101u, 301301u, 301401u, 301601u, 301701u, 301801u,
			301901u, 302001u, 302201u, 302601u, 302701u, 302901u, 303001u, 303101u, 303401u, 310501u,
			310601u, 310701u, 311101u, 320101u, 320201u, 320301u, 320401u, 320801u, 320901u, 321101u,
			330101u, 330201u, 330301u, 330401u, 330501u, 330701u, 330801u, 330901u, 331001u, 331101u,
			331201u, 331301u, 331401u, 331501u, 331601u, 331901u, 332101u, 332201u, 350101u, 350301u,
			350402u, 350403u, 350501u, 350601u, 350701u, 350801u, 350901u, 351001u, 351101u, 351401u,
			351501u, 351601u, 351701u, 351801u, 360201u
		}));
		GridFightSystemInfo gridFightSystemInfo = new GridFightSystemInfo
		{
			EGLCKGKECAJ = gridFightStaticGameInfo,
			FCKKGFFLDFA = new MIGEAHDEBOE
			{
				OJLAODIALLE = new GridFightTalentInfo()
			}
		};
		if (GameData.GridFightTalentData.Count > 0)
		{
			gridFightSystemInfo.FCKKGFFLDFA.OJLAODIALLE.DANAGDAPKJE.Add(GameData.GridFightTalentData.Keys.OrderBy((uint x) => x));
		}
		else
		{
			gridFightSystemInfo.FCKKGFFLDFA.OJLAODIALLE.DANAGDAPKJE.Add(new _003C_003Ez__ReadOnlyArray<uint>(new uint[13]
			{
				1011u, 1021u, 1022u, 1031u, 1041u, 1042u, 1051u, 1061u, 1062u, 1071u,
				1072u, 1073u, 1081u
			}));
		}
		return gridFightSystemInfo;
	}

	public GridFightSyncUpdateResultScNotify BuildSyncUpdateNotify(IEnumerable<GridFightPosInfo>? updatedPosList = null, int kind = 0, object? extra = null)
	{
		if (updatedPosList != null)
		{
			return BuildPosUpdateSync(updatedPosList);
		}
		return kind switch
		{
			0 => BuildBootstrapSync(), 
			1 => BuildPendingAdvanceSync(extra), 
			2 => BuildSelectEquipSync(extra), 
			3 => BuildBuyGoodsSync(extra), 
			4 => BuildRefreshShopSync(), 
			5 => BuildRecycleRoleSync(extra), 
			6 => BuildBuyExpSync(), 
			7 => BuildPostBattleSync(), 
			9 => BuildPreSettleSync(), 
			8 => new GridFightSyncUpdateResultScNotify(), 
			_ => new GridFightSyncUpdateResultScNotify(), 
		};
	}

	private GridFightSyncUpdateResultScNotify BuildPosUpdateSync(IEnumerable<GridFightPosInfo> updatedPosList)
	{
		GridFightSyncUpdateResultScNotify gridFightSyncUpdateResultScNotify = new GridFightSyncUpdateResultScNotify();
		if (GridFightInstance == null)
		{
			return gridFightSyncUpdateResultScNotify;
		}
		GridFightSyncResultData gridFightSyncResultData = new GridFightSyncResultData();
		foreach (GridFightPosInfo updatedPos in updatedPosList)
		{
			if (updatedPos.Pos != 0 && updatedPos.UniqueId != 0 && GridFightInstance.RoleByUniqueId.TryGetValue(updatedPos.UniqueId, out var value))
			{
				GridGameRoleInfo gridGameRoleInfo = new GridGameRoleInfo
				{
					Id = value,
					Pos = updatedPos.Pos,
					UniqueId = updatedPos.UniqueId,
					RoleStar = GridFightInstance.RoleStarByUniqueId.GetValueOrDefault(updatedPos.UniqueId, 1u)
				};
				if (GameData.GridFightRoleBasicInfoData.TryGetValue(value, out GridFightRoleBasicInfoExcel value2) && value2.RoleSavedValueList.Count > 0)
				{
					gridGameRoleInfo.GridFightValueInitComponent[value2.RoleSavedValueList[0]] = 0u;
				}
				gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
				{
					UpdateRoleInfo = gridGameRoleInfo
				});
			}
		}
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData);
		return gridFightSyncUpdateResultScNotify;
	}

	private GridFightSyncUpdateResultScNotify BuildPendingAdvanceSync(object? extra)
	{
		GridFightSyncUpdateResultScNotify gridFightSyncUpdateResultScNotify = new GridFightSyncUpdateResultScNotify();
		GridFightInstance gridFightInstance = GridFightInstance;
		uint num;
		uint num2;
		if (extra is (uint, uint) tuple)
		{
			(num, num2) = tuple;
		}
		else
		{
			num = 0u;
			num2 = 0u;
		}
		if (num != 0 && num2 > num)
		{
			GridFightSyncResultData gridFightSyncResultData = new GridFightSyncResultData();
			gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
			{
				FinishPendingActionPos = num
			});
			gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
			{
				SyncLockInfo = new GridFightLockInfo()
			});
			gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData);
		}
		if (gridFightInstance?.PendingAction != null)
		{
			GridFightSyncResultData gridFightSyncResultData2 = new GridFightSyncResultData();
			gridFightSyncResultData2.UpdateDynamicList.Add(new GridFightSyncData
			{
				SyncLockInfo = new GridFightLockInfo
				{
					LockReason = GridFightLockReason.DfofffceffoKjmjdbjmbmc,
					LockType = GridFightLockType.PjbmhhnlclbEhfhdgpocnh
				}
			});
			gridFightSyncResultData2.UpdateDynamicList.Add(new GridFightSyncData
			{
				PendingAction = gridFightInstance.PendingAction
			});
			gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData2);
		}
		return gridFightSyncUpdateResultScNotify;
	}

	private GridFightSyncUpdateResultScNotify BuildSelectEquipSync(object? extra)
	{
		GridFightSyncUpdateResultScNotify gridFightSyncUpdateResultScNotify = new GridFightSyncUpdateResultScNotify();
		GridFightSyncResultData gridFightSyncResultData = new GridFightSyncResultData();
		if (extra is (uint, uint) { Item1: var item } && item != 0)
		{
			gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
			{
				GMJLJDJDIGM = new JPBCKCDEGOM()
			});
		}
		if (GridFightInstance != null)
		{
			gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
			{
				FinishPendingActionPos = GridFightInstance.QueuePosition
			});
		}
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData);
		return gridFightSyncUpdateResultScNotify;
	}

	private GridFightSyncUpdateResultScNotify BuildBuyGoodsSync(object? extra)
	{
		GridFightSyncUpdateResultScNotify gridFightSyncUpdateResultScNotify = new GridFightSyncUpdateResultScNotify();
		GridFightInstance gridFightInstance = GridFightInstance;
		if (gridFightInstance == null || extra == null)
		{
			gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(new GridFightSyncResultData());
			return gridFightSyncUpdateResultScNotify;
		}
		uint num;
		uint num2;
		uint pos;
		List<uint> list;
		uint mergedKeepUid;
		uint roleStar;
		if (extra is (uint, uint, uint, int, List<uint>, uint, uint) tuple)
		{
			(num, num2, pos, _, list, mergedKeepUid, roleStar) = tuple;
		}
		else
		{
			if (!(extra is (uint, uint, uint, int) tuple3))
			{
				gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(new GridFightSyncResultData());
				return gridFightSyncUpdateResultScNotify;
			}
			(uint, uint, uint, int) tuple4 = tuple3;
			num = tuple4.Item1;
			num2 = tuple4.Item2;
			pos = tuple4.Item3;
			list = new List<uint>();
			mergedKeepUid = 0u;
			roleStar = 0u;
		}
		GridFightSyncResultData gridFightSyncResultData = new GridFightSyncResultData
		{
			GridUpdateSrc = GridFightUpdateSrcType.LnpfefkjdhpDpekjiiicgh
		};
		gridFightSyncResultData.SyncEffectParamList.Add(0u);
		gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
		{
			ItemValue = gridFightInstance.Gold
		});
		if (num2 != 0)
		{
			if (list.Count == 0 || mergedKeepUid == 0)
			{
				GridGameRoleInfo gridGameRoleInfo = new GridGameRoleInfo
				{
					Id = num,
					Pos = pos,
					RoleStar = 1u,
					UniqueId = num2
				};
				if (GameData.GridFightRoleBasicInfoData.TryGetValue(num, out GridFightRoleBasicInfoExcel value) && value.RoleSavedValueList.Count > 0)
				{
					gridGameRoleInfo.GridFightValueInitComponent[value.RoleSavedValueList[0]] = 0u;
				}
				gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
				{
					AddRoleInfo = gridGameRoleInfo
				});
			}
			else
			{
				foreach (uint item in list)
				{
					gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
					{
						RemoveRoleUniqueId = item
					});
				}
				uint key = gridFightInstance.UniqueIdByPos.FirstOrDefault((KeyValuePair<uint, uint> kv) => kv.Value == mergedKeepUid).Key;
				GridGameRoleInfo gridGameRoleInfo2 = new GridGameRoleInfo
				{
					Id = num,
					Pos = key,
					RoleStar = roleStar,
					UniqueId = mergedKeepUid
				};
				if (GameData.GridFightRoleBasicInfoData.TryGetValue(num, out GridFightRoleBasicInfoExcel value2) && value2.RoleSavedValueList.Count > 0)
				{
					gridGameRoleInfo2.GridFightValueInitComponent[value2.RoleSavedValueList[0]] = 0u;
				}
				if (mergedKeepUid == num2)
				{
					gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
					{
						AddRoleInfo = gridGameRoleInfo2
					});
				}
				else
				{
					gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
					{
						UpdateRoleInfo = gridGameRoleInfo2
					});
				}
			}
		}
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData);
		GridFightSyncResultData gridFightSyncResultData2 = new GridFightSyncResultData
		{
			GridUpdateSrc = GridFightUpdateSrcType.LnpfefkjdhpDpekjiiicgh
		};
		gridFightSyncResultData2.SyncEffectParamList.Add(0u);
		gridFightSyncResultData2.UpdateDynamicList.Add(new GridFightSyncData
		{
			ShopSyncInfo = BuildShopSyncInfo(gridFightInstance)
		});
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData2);
		return gridFightSyncUpdateResultScNotify;
	}

	private static GridFightShopSyncInfo BuildShopSyncInfo(GridFightInstance inst)
	{
		GridFightShopSyncInfo gridFightShopSyncInfo = new GridFightShopSyncInfo
		{
			GLIFNMBMMBL = inst.ShopRefreshLeft,
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
			}
		};
		foreach (GridFightShopGoodsInfo shopGood in inst.ShopGoods)
		{
			gridFightShopSyncInfo.ShopGoodsList.Add(shopGood);
		}
		return gridFightShopSyncInfo;
	}

	private GridFightSyncUpdateResultScNotify BuildRefreshShopSync()
	{
		GridFightSyncUpdateResultScNotify gridFightSyncUpdateResultScNotify = new GridFightSyncUpdateResultScNotify();
		GridFightInstance gridFightInstance = GridFightInstance;
		if (gridFightInstance == null)
		{
			return gridFightSyncUpdateResultScNotify;
		}
		GridFightSyncResultData gridFightSyncResultData = new GridFightSyncResultData
		{
			GridUpdateSrc = GridFightUpdateSrcType.LnpfefkjdhpEjkejdnhioe
		};
		gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
		{
			ItemValue = gridFightInstance.Gold
		});
		gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
		{
			ShopSyncInfo = BuildShopSyncInfo(gridFightInstance)
		});
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData);
		return gridFightSyncUpdateResultScNotify;
	}

	private GridFightSyncUpdateResultScNotify BuildRecycleRoleSync(object? extra)
	{
		GridFightSyncUpdateResultScNotify gridFightSyncUpdateResultScNotify = new GridFightSyncUpdateResultScNotify();
		GridFightSyncResultData gridFightSyncResultData = new GridFightSyncResultData();
		if (extra is (uint, int) { Item1: var item })
		{
			gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
			{
				RemoveRoleUniqueId = item
			});
			gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
			{
				ItemValue = Math.Max(0u, GridFightInstance?.Gold ?? 0)
			});
		}
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData);
		return gridFightSyncUpdateResultScNotify;
	}

	private GridFightSyncUpdateResultScNotify BuildBuyExpSync()
	{
		GridFightSyncUpdateResultScNotify gridFightSyncUpdateResultScNotify = new GridFightSyncUpdateResultScNotify();
		GridFightSyncResultData gridFightSyncResultData = new GridFightSyncResultData();
		GridFightInstance gridFightInstance = GridFightInstance;
		gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
		{
			ItemValue = Math.Max(0u, gridFightInstance?.Gold ?? 0)
		});
		if (gridFightInstance != null)
		{
			gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
			{
				PlayerLevel = new GridFightPlayerLevelSyncInfo
				{
					Level = gridFightInstance.PlayerLevel,
					Exp = gridFightInstance.PlayerExp,
					MaxLevel = gridFightInstance.PlayerMaxLevel
				}
			});
			gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
			{
				GridFightBuyExpCost = gridFightInstance.GetBuyExpCost()
			});
			gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
			{
				MaxBattleRoleNum = gridFightInstance.GetCurrentMaxBattleRoleNum()
			});
		}
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData);
		return gridFightSyncUpdateResultScNotify;
	}

	private GridFightSyncUpdateResultScNotify BuildPostBattleSync()
	{
		GridFightSyncUpdateResultScNotify gridFightSyncUpdateResultScNotify = new GridFightSyncUpdateResultScNotify();
		GridFightInstance gridFightInstance = GridFightInstance;
		if (gridFightInstance == null)
		{
			return gridFightSyncUpdateResultScNotify;
		}
		GridFightSyncResultData gridFightSyncResultData = new GridFightSyncResultData();
		GridFightLevelSyncInfo gridFightLevelSyncInfo = new GridFightLevelSyncInfo
		{
			DCPKPNLKGMM = gridFightInstance.Level,
			SectionId = gridFightInstance.SectionId + 1,
			GridFightLayerInfo = new GridFightLayerInfo
			{
				RouteInfo = new GridFightRouteInfo
				{
					EliteBranchId = 1u,
					FightCampId = gridFightInstance.CampId
				}
			}
		};
		GridFightLevelEncounter gridFightLevelEncounter = GridFightLevelResolver.Resolve(gridFightInstance);
		GridFightEncounterInfo gridFightEncounterInfo = new GridFightEncounterInfo
		{
			LFKBMDHKPFI = gridFightLevelEncounter.StageId
		};
		GridEncounterMonsterWave gridEncounterMonsterWave = new GridEncounterMonsterWave
		{
			IGMMPDDCJIN = 1u
		};
		foreach (uint item in (gridFightInstance.BattleComponent.MonsterIds.Count > 0) ? gridFightInstance.BattleComponent.MonsterIds : gridFightLevelEncounter.Monsters.Select((GridFightMonsterSpec m) => m.MonsterId).ToList())
		{
			gridEncounterMonsterWave.PPOEDDFFEKK.Add(new PJLBDMPEKFP
			{
				MonsterId = item,
				RoleStar = 1u
			});
		}
		gridFightEncounterInfo.MonsterWaveList.Add(gridEncounterMonsterWave);
		gridFightLevelSyncInfo.GridFightLayerInfo.RouteInfo.RouteEncounterList.Add(gridFightEncounterInfo);
		gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
		{
			LevelSyncInfo = gridFightLevelSyncInfo
		});
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData);
		GridFightSyncResultData gridFightSyncResultData2 = new GridFightSyncResultData();
		gridFightSyncResultData2.UpdateDynamicList.Add(new GridFightSyncData
		{
			SyncLockInfo = new GridFightLockInfo
			{
				LockReason = GridFightLockReason.DfofffceffoKjmjdbjmbmc,
				LockType = GridFightLockType.PjbmhhnlclbEhfhdgpocnh
			}
		});
		gridFightSyncResultData2.UpdateDynamicList.Add(new GridFightSyncData
		{
			PendingAction = (gridFightInstance.PendingAction ?? new GridFightPendingAction
			{
				QueuePosition = gridFightInstance.QueuePosition,
				RoundBeginAction = new GridFightRoundBeginActionInfo()
			})
		});
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData2);
		return gridFightSyncUpdateResultScNotify;
	}

	private GridFightSyncUpdateResultScNotify BuildPreSettleSync()
	{
		GridFightSyncUpdateResultScNotify gridFightSyncUpdateResultScNotify = new GridFightSyncUpdateResultScNotify();
		GridFightInstance gridFightInstance = GridFightInstance;
		if (gridFightInstance == null)
		{
			return gridFightSyncUpdateResultScNotify;
		}
		GridFightSyncResultData gridFightSyncResultData = new GridFightSyncResultData();
		gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
		{
			SyncLockInfo = new GridFightLockInfo()
		});
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData);
		GridFightSyncResultData gridFightSyncResultData2 = new GridFightSyncResultData
		{
			GridUpdateSrc = GridFightUpdateSrcType.LnpfefkjdhpJalhdinecfe
		};
		gridFightSyncResultData2.SyncEffectParamList.Add(1u);
		gridFightSyncResultData2.SyncEffectParamList.Add(1u);
		if (gridFightInstance.LastBattleDamageStt != null)
		{
			gridFightSyncResultData2.UpdateDynamicList.Add(new GridFightSyncData
			{
				GridFightDamageSttInfo = gridFightInstance.LastBattleDamageStt.Clone()
			});
		}
		gridFightSyncResultData2.UpdateDynamicList.Add(new GridFightSyncData
		{
			GridFightLineupHp = new GridFightLineupHpSyncInfo
			{
				GridFightLineupHp = gridFightInstance.LineupHp,
				GridFightLineupMaxHp = gridFightInstance.LineupMaxHp
			}
		});
		gridFightSyncResultData2.UpdateDynamicList.Add(new GridFightSyncData
		{
			SectionRecordSyncInfo = new GridFightSectionRecordInfo
			{
				DCPKPNLKGMM = gridFightInstance.Level,
				SectionId = gridFightInstance.SectionId,
				CampRecordInfo = new GridFightSectionCampRecordInfo
				{
					PMOGHFIGKPO = gridFightInstance.CampId
				}
			}
		});
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData2);
		GridFightSyncResultData gridFightSyncResultData3 = new GridFightSyncResultData
		{
			GridUpdateSrc = GridFightUpdateSrcType.LnpfefkjdhpJalhdinecfe
		};
		gridFightSyncResultData3.SyncEffectParamList.Add(1u);
		gridFightSyncResultData3.SyncEffectParamList.Add(1u);
		gridFightSyncResultData3.UpdateDynamicList.Add(new GridFightSyncData
		{
			PlayerLevel = new GridFightPlayerLevelSyncInfo
			{
				Level = gridFightInstance.PlayerLevel,
				Exp = gridFightInstance.PlayerExp,
				MaxLevel = gridFightInstance.PlayerMaxLevel
			}
		});
		if (gridFightInstance.Gold > gridFightInstance.PreBattleGold)
		{
			gridFightSyncResultData3.UpdateDynamicList.Add(new GridFightSyncData
			{
				ItemValue = gridFightInstance.PreBattleGold + 3
			});
			gridFightSyncResultData3.UpdateDynamicList.Add(new GridFightSyncData
			{
				ItemValue = gridFightInstance.Gold
			});
		}
		foreach (var (orbItemId, uniqueId) in gridFightInstance.LastRewardedOrbs)
		{
			gridFightSyncResultData3.UpdateDynamicList.Add(new GridFightSyncData
			{
				OrbSyncInfo = new GridFightOrbSyncInfo
				{
					OrbItemId = orbItemId,
					UniqueId = uniqueId
				}
			});
		}
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData3);
		return gridFightSyncUpdateResultScNotify;
	}

	private GridFightSyncUpdateResultScNotify BuildBootstrapSync()
	{
		return GridFightBootstrapSyncBuilder.Build();
	}

	public GridFightSettleNotify BuildSettleNotify()
	{
		GridFightInstance gridFightInstance = GridFightInstance;
		GridFightSettleNotify gridFightSettleNotify = new GridFightSettleNotify
		{
			BHLDAEKNMCD = (gridFightInstance?.KeepWinCnt ?? 0),
			EDKIICIKJKL = MaxDivisionId(),
			OHOPKAAKOGF = MaxDivisionId(),
			EDKJMPACHNJ = new GridFightFinishInfo
			{
				BCHPAOCOHIL = new FCBEHGJBJCN
				{
					AMNJHJJMPJF = { (IEnumerable<uint>)(gridFightInstance?.CurrentEquipDraft ?? new List<uint> { 35030205u, 35030405u, 35030208u }) }
				},
				NLILNONCNFC = new JCFJADFEOJN
				{
					BBDOCJGAEEJ = (gridFightInstance?.DivisionId ?? MaxDivisionId()),
					BCOLJFHDLLD = (gridFightInstance?.LineupHp ?? 80),
					BFNPCJOMGFL = (uint)(gridFightInstance?.BattlesFinished ?? 3),
					DCPKPNLKGMM = (gridFightInstance?.Level ?? 1),
					IJEIEJLPGGJ = (gridFightInstance?.LineupMaxHp ?? 100),
					NDOCIKPLKIF = (gridFightInstance?.NDOCIKPLKIF ?? 1600),
					SectionId = (gridFightInstance?.SectionId ?? 1)
				},
				PGPKPMOIAIL = new CLOEPPBCKGF
				{
					GridFightAvatarList = { 1006u, 1201u, 1202u, 1223u, 1301u, 15062u, 15063u }
				}
			}
		};
		foreach (uint item in gridFightInstance?.ActivePortalBuffIds ?? new List<uint> { 106u })
		{
			gridFightSettleNotify.EDKJMPACHNJ.CEAFFNCKDDD.Add(new GridFightGamePortalBuffInfo
			{
				PortalBuffId = item
			});
		}
		foreach (uint item2 in gridFightInstance?.SectionAffixIds ?? new List<uint> { 1002u, 3005u, 4010u })
		{
			gridFightSettleNotify.EDKJMPACHNJ.IAKFPMOEJLF.Add(new DIBJGAKOCLO
			{
				AffixId = item2
			});
		}
		foreach (GridFightEquipmentInfo item3 in gridFightInstance?.Equipments ?? new List<GridFightEquipmentInfo>())
		{
			gridFightSettleNotify.EDKJMPACHNJ.GridFightEquipmentList.Add(item3);
		}
		return gridFightSettleNotify;
	}

	public GridFightCurrentInfo BuildCurrentInfo()
	{
		if (GridFightInstance != null)
		{
			return GridFightInstance.ToProto();
		}
		uint divisionId = MaxDivisionId();
		GridFightInstance gridFightInstance = new GridFightInstance(base.Player, 1u, divisionId, isOverLock: false, CurUniqueId);
		return new GridFightCurrentInfo
		{
			Season = 1u,
			DivisionId = divisionId,
			UniqueId = CurUniqueId,
			PendingAction = new GridFightPendingAction
			{
				QueuePosition = 1u,
				PortalBuffAction = new GridFightPortalBuffActionInfo
				{
					FCHPJKAIBHB = 1u,
					GridFightPortalBuffList = { (IEnumerable<uint>)gridFightInstance.RollPortalBuffs() }
				}
			}
		};
	}

	public (Retcode, GridFightInstance?) StartGamePlay(uint season, uint divisionId, bool isOverLock)
	{
		if (GridFightInstance != null)
		{
			return (Retcode.RetSucc, GridFightInstance);
		}
		GridFightInstance = new GridFightInstance(base.Player, (season == 0) ? 1u : season, (divisionId == 0) ? MaxDivisionId() : divisionId, isOverLock, ++CurUniqueId);
		return (Retcode.RetSucc, GridFightInstance);
	}
}
