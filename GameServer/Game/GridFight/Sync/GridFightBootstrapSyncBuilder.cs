using Google.Protobuf.Collections;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.GridFight.Sync;

public static class GridFightBootstrapSyncBuilder
{
	public static GridFightSyncUpdateResultScNotify Build()
	{
		GridFightSyncUpdateResultScNotify gridFightSyncUpdateResultScNotify = new GridFightSyncUpdateResultScNotify();
		GridFightSyncResultData gridFightSyncResultData = new GridFightSyncResultData();
		GridFightSyncData gridFightSyncData = new GridFightSyncData
		{
			GMJLJDJDIGM = new JPBCKCDEGOM()
		};
		gridFightSyncData.GMJLJDJDIGM.ALIDDLBDPDH.Add(new ELEOGABGBKG
		{
			DMEKIFJDKFL = 8007u,
			CELFGCJFMPH = { 8007u, 8009u }
		});
		gridFightSyncData.GMJLJDJDIGM.ALIDDLBDPDH.Add(new ELEOGABGBKG
		{
			DMEKIFJDKFL = 11011u,
			CELFGCJFMPH = { 11011u, 11012u }
		});
		gridFightSyncResultData.UpdateDynamicList.Add(gridFightSyncData);
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData);
		GridFightSyncResultData gridFightSyncResultData2 = new GridFightSyncResultData
		{
			GridUpdateSrc = GridFightUpdateSrcType.LnpfefkjdhpHndkhmefaal
		};
		gridFightSyncResultData2.UpdateDynamicList.Add(new GridFightSyncData
		{
			PortalServerDataUpdate = new GridFightPortalServerDataUpdate
			{
				PortalBuffId = 111u
			}
		});
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData2);
		GridFightSyncResultData gridFightSyncResultData3 = new GridFightSyncResultData
		{
			GridUpdateSrc = GridFightUpdateSrcType.LnpfefkjdhpBjdeaahibge
		};
		gridFightSyncResultData3.UpdateDynamicList.Add(new GridFightSyncData
		{
			ItemValue = 3u
		});
		RepeatedField<GridFightSyncData> updateDynamicList = gridFightSyncResultData3.UpdateDynamicList;
		GridFightSyncData gridFightSyncData2 = new GridFightSyncData();
		GridGameRoleInfo gridGameRoleInfo = new GridGameRoleInfo();
		gridGameRoleInfo.Id = 1009u;
		gridGameRoleInfo.Pos = 14u;
		gridGameRoleInfo.RoleStar = 1u;
		gridGameRoleInfo.UniqueId = 3u;
		gridGameRoleInfo.GridFightValueInitComponent["GP_Avatar_Asta_01"] = 0u;
		gridFightSyncData2.AddRoleInfo = gridGameRoleInfo;
		updateDynamicList.Add(gridFightSyncData2);
		RepeatedField<GridFightSyncData> updateDynamicList2 = gridFightSyncResultData3.UpdateDynamicList;
		GridFightSyncData gridFightSyncData3 = new GridFightSyncData();
		GridGameRoleInfo gridGameRoleInfo2 = new GridGameRoleInfo();
		gridGameRoleInfo2.Id = 1306u;
		gridGameRoleInfo2.Pos = 15u;
		gridGameRoleInfo2.RoleStar = 1u;
		gridGameRoleInfo2.UniqueId = 4u;
		gridGameRoleInfo2.GridFightValueInitComponent["GP_Avatar_Sparkle_01"] = 0u;
		gridFightSyncData3.AddRoleInfo = gridGameRoleInfo2;
		updateDynamicList2.Add(gridFightSyncData3);
		RepeatedField<GridFightSyncData> updateDynamicList3 = gridFightSyncResultData3.UpdateDynamicList;
		GridFightSyncData gridFightSyncData4 = new GridFightSyncData();
		GridGameRoleInfo gridGameRoleInfo3 = new GridGameRoleInfo();
		gridGameRoleInfo3.Id = 1403u;
		gridGameRoleInfo3.Pos = 16u;
		gridGameRoleInfo3.RoleStar = 1u;
		gridGameRoleInfo3.UniqueId = 5u;
		gridGameRoleInfo3.GridFightValueInitComponent["GP_Avatar_Tribbie_01"] = 0u;
		gridFightSyncData4.AddRoleInfo = gridGameRoleInfo3;
		updateDynamicList3.Add(gridFightSyncData4);
		RepeatedField<GridFightSyncData> updateDynamicList4 = gridFightSyncResultData3.UpdateDynamicList;
		GridFightSyncData gridFightSyncData5 = new GridFightSyncData();
		GridGameRoleInfo gridGameRoleInfo4 = new GridGameRoleInfo();
		gridGameRoleInfo4.Id = 1502u;
		gridGameRoleInfo4.Pos = 17u;
		gridGameRoleInfo4.RoleStar = 1u;
		gridGameRoleInfo4.UniqueId = 6u;
		gridGameRoleInfo4.GridFightValueInitComponent["GP_Avatar_YaoGuang_01"] = 0u;
		gridFightSyncData5.AddRoleInfo = gridGameRoleInfo4;
		updateDynamicList4.Add(gridFightSyncData5);
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData3);
		GridFightSyncResultData item = new GridFightSyncResultData
		{
			UpdateDynamicList = 
			{
				new GridFightSyncData
				{
					FinishPendingActionPos = 1u
				},
				new GridFightSyncData
				{
					SyncLockInfo = new GridFightLockInfo()
				}
			}
		};
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(item);
		GridFightSyncResultData item2 = new GridFightSyncResultData
		{
			UpdateDynamicList = 
			{
				new GridFightSyncData
				{
					ShopSyncInfo = new GridFightShopSyncInfo
					{
						GLIFNMBMMBL = 2u,
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
						ShopGoodsList = 
						{
							new GridFightShopGoodsInfo
							{
								ShopGoodsPrice = 1u,
								RoleGoodsInfo = new GridFightRoleGoodsInfo
								{
									RoleId = 1217u,
									RoleStar = 1u
								}
							},
							new GridFightShopGoodsInfo
							{
								ShopGoodsPrice = 1u,
								RoleGoodsInfo = new GridFightRoleGoodsInfo
								{
									RoleId = 1314u,
									RoleStar = 1u
								}
							},
							new GridFightShopGoodsInfo
							{
								ShopGoodsPrice = 1u,
								RoleGoodsInfo = new GridFightRoleGoodsInfo
								{
									RoleId = 1108u,
									RoleStar = 1u
								}
							},
							new GridFightShopGoodsInfo
							{
								ShopGoodsPrice = 1u,
								RoleGoodsInfo = new GridFightRoleGoodsInfo
								{
									RoleId = 1220u,
									RoleStar = 1u
								}
							},
							new GridFightShopGoodsInfo
							{
								ShopGoodsPrice = 1u,
								RoleGoodsInfo = new GridFightRoleGoodsInfo
								{
									RoleId = 1406u,
									RoleStar = 1u
								}
							}
						}
					}
				}
			}
		};
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(item2);
		GridFightSyncResultData item3 = new GridFightSyncResultData
		{
			UpdateDynamicList = 
			{
				new GridFightSyncData
				{
					SyncLockInfo = new GridFightLockInfo
					{
						LockReason = GridFightLockReason.DfofffceffoKjmjdbjmbmc,
						LockType = GridFightLockType.PjbmhhnlclbEhfhdgpocnh
					}
				},
				new GridFightSyncData
				{
					PendingAction = new GridFightPendingAction
					{
						QueuePosition = 2u,
						RoundBeginAction = new GridFightRoundBeginActionInfo()
					}
				}
			}
		};
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(item3);
		GridFightSyncResultData item4 = new GridFightSyncResultData
		{
			UpdateDynamicList = 
			{
				new GridFightSyncData
				{
					FinishPendingActionPos = 2u
				},
				new GridFightSyncData
				{
					SyncLockInfo = new GridFightLockInfo()
				}
			}
		};
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(item4);
		GridFightSyncResultData item5 = new GridFightSyncResultData
		{
			UpdateDynamicList = 
			{
				new GridFightSyncData
				{
					SyncLockInfo = new GridFightLockInfo
					{
						LockReason = GridFightLockReason.DfofffceffoKjmjdbjmbmc,
						LockType = GridFightLockType.PjbmhhnlclbEhfhdgpocnh
					}
				},
				new GridFightSyncData
				{
					PendingAction = new GridFightPendingAction
					{
						QueuePosition = 8u,
						ReturnPreparationAction = new GridFightReturnPreparationActionInfo()
					}
				}
			}
		};
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(item5);
		return gridFightSyncUpdateResultScNotify;
	}
}
