using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Protobuf.Collections;
using March7thHoney.GameServer.Server;
using March7thHoney.GameServer.Server.Packet.Send.GridFight;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.GridFight.PendingAction;

public static class GridFightPendingActionProcessor
{
	public static async System.Threading.Tasks.Task Handle(Connection connection, GridFightInstance inst, GridFightSelectRecommendEquipCsReq req)
	{
		uint ackPos = req.QueuePosition;
		if (req.PortalBuffRerollAction != null)
		{
			await HandlePortalBuffReroll(connection, inst, ackPos);
			return;
		}
		if (req.PortalBuffAction != null)
		{
			await HandlePortalBuffSelect(connection, inst, ackPos, req.PortalBuffAction.SelectPortalBuffId);
			return;
		}
		if (req.RoundBeginAction != null)
		{
			await HandleRoundBegin(connection, inst, ackPos);
			return;
		}
		if (req.ReturnPreparationAction != null)
		{
			await HandleReturnPreparation(connection, inst, ackPos);
			return;
		}
		inst.QueuePosition = ackPos + 1;
		inst.PendingAction = new GridFightPendingAction
		{
			QueuePosition = inst.QueuePosition,
			RoundBeginAction = new GridFightRoundBeginActionInfo()
		};
		await connection.SendPacket(new PacketGridFightHandlePendingActionScRsp(ackPos));
		await connection.SendPacket(new PacketGridFightSyncUpdateResultScNotify(connection.Player, 1, (ackPos, inst.QueuePosition)));
	}

	private static async System.Threading.Tasks.Task HandlePortalBuffReroll(Connection connection, GridFightInstance inst, uint ackPos)
	{
		List<uint> values = new List<uint> { 105u, 1014u, 132u };
		inst.QueuePosition = ackPos;
		inst.PendingAction = new GridFightPendingAction
		{
			QueuePosition = ackPos,
			PortalBuffAction = new GridFightPortalBuffActionInfo
			{
				FCHPJKAIBHB = 1u,
				GridFightPortalBuffList = { (IEnumerable<uint>)values }
			}
		};
		GridFightSeasonHandBookNotify gridFightSeasonHandBookNotify = new GridFightSeasonHandBookNotify
		{
			HandbookGridFightPortalInfo = new GridFightHandBookPortalInfo()
		};
		gridFightSeasonHandBookNotify.HandbookGridFightPortalInfo.PELJLONLDNM.Add(132u);
		await connection.SendPacket(new PacketGridFightSeasonHandBookNotify(gridFightSeasonHandBookNotify));
		await connection.SendPacket(new PacketGridFightHandlePendingActionScRsp(ackPos));
		GridFightSyncUpdateResultScNotify gridFightSyncUpdateResultScNotify = new GridFightSyncUpdateResultScNotify();
		GridFightSyncResultData gridFightSyncResultData = new GridFightSyncResultData();
		gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
		{
			PendingAction = inst.PendingAction
		});
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData);
		await connection.SendPacket(new PacketGridFightSyncUpdateResultScNotify(gridFightSyncUpdateResultScNotify));
	}

	private static async System.Threading.Tasks.Task HandlePortalBuffSelect(Connection connection, GridFightInstance inst, uint ackPos, uint buffId)
	{
		if (buffId != 0 && !inst.ActivePortalBuffIds.Contains(buffId))
		{
			inst.ActivePortalBuffIds.Add(buffId);
		}
		inst.MaterializeInitialBenchTeam();
		inst.ConfigureNextBattle(90303u, new uint[3] { 300101007u, 800102021u, 300101007u });
		uint queuePosition = (inst.QueuePosition = ackPos + 1);
		inst.PendingAction = new GridFightPendingAction
		{
			QueuePosition = queuePosition,
			RoundBeginAction = new GridFightRoundBeginActionInfo()
		};
		GridFightSeasonHandBookNotify gridFightSeasonHandBookNotify = new GridFightSeasonHandBookNotify
		{
			HandbookGridFightPortalInfo = new GridFightHandBookPortalInfo()
		};
		gridFightSeasonHandBookNotify.HandbookGridFightPortalInfo.GridFightPortalBuffList.Add(buffId);
		await connection.SendPacket(new PacketGridFightSeasonHandBookNotify(gridFightSeasonHandBookNotify));
		await connection.SendPacket(new PacketGridFightHandlePendingActionScRsp(ackPos));
		GridFightSyncUpdateResultScNotify gridFightSyncUpdateResultScNotify = new GridFightSyncUpdateResultScNotify();
		GridFightSyncResultData gridFightSyncResultData = new GridFightSyncResultData
		{
			GridUpdateSrc = GridFightUpdateSrcType.LnpfefkjdhpPnejelgglej
		};
		uint uniqueId = inst.AllocEquipUniqueId();
		gridFightSyncResultData.SyncEffectParamList.Add(buffId);
		gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
		{
			AddGameItemInfo = new GridFightGameItemSyncInfo
			{
				GridFightEquipmentList = 
				{
					new GridFightEquipmentInfo
					{
						GridFightEquipmentId = 350602u,
						Source = 1u,
						UniqueId = uniqueId
					}
				}
			}
		});
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData);
		GridFightSyncResultData gridFightSyncResultData2 = new GridFightSyncResultData
		{
			GridUpdateSrc = GridFightUpdateSrcType.LnpfefkjdhpPnejelgglej
		};
		uint uniqueId2 = inst.AllocEquipUniqueId();
		gridFightSyncResultData2.SyncEffectParamList.Add(buffId);
		gridFightSyncResultData2.UpdateDynamicList.Add(new GridFightSyncData
		{
			AddForgeInfo = new GridGameForgeItemInfo
			{
				ForgeItemId = 99999u,
				Pos = 14u,
				UniqueId = uniqueId2,
				ForgeGoodsList = 
				{
					new GridFightForgeGoodsInfo
					{
						EquipmentGoodsInfo = new GridFightForgeEquipmentInfo
						{
							GridFightEquipmentId = 350204u
						}
					},
					new GridFightForgeGoodsInfo
					{
						EquipmentGoodsInfo = new GridFightForgeEquipmentInfo
						{
							GridFightEquipmentId = 350205u
						}
					},
					new GridFightForgeGoodsInfo
					{
						EquipmentGoodsInfo = new GridFightForgeEquipmentInfo
						{
							GridFightEquipmentId = 350208u
						}
					},
					new GridFightForgeGoodsInfo
					{
						EquipmentGoodsInfo = new GridFightForgeEquipmentInfo
						{
							GridFightEquipmentId = 350207u
						}
					}
				}
			}
		});
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData2);
		GridFightSyncResultData gridFightSyncResultData3 = new GridFightSyncResultData
		{
			GridUpdateSrc = GridFightUpdateSrcType.LnpfefkjdhpHndkhmefaal
		};
		gridFightSyncResultData3.UpdateDynamicList.Add(new GridFightSyncData
		{
			PortalServerDataUpdate = new GridFightPortalServerDataUpdate
			{
				PortalBuffId = buffId
			}
		});
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData3);
		GridFightSyncResultData gridFightSyncResultData4 = new GridFightSyncResultData
		{
			GridUpdateSrc = GridFightUpdateSrcType.LnpfefkjdhpBjdeaahibge
		};
		gridFightSyncResultData4.UpdateDynamicList.Add(new GridFightSyncData
		{
			ItemValue = inst.Gold
		});
		(uint, uint, uint, string)[] initialBenchRoles = GridFightInstance.InitialBenchRoles;
		for (int i = 0; i < initialBenchRoles.Length; i++)
		{
			(uint, uint, uint, string) tuple = initialBenchRoles[i];
			uint item = tuple.Item1;
			uint item2 = tuple.Item2;
			uint item3 = tuple.Item3;
			string item4 = tuple.Item4;
			RepeatedField<GridFightSyncData> updateDynamicList = gridFightSyncResultData4.UpdateDynamicList;
			GridFightSyncData gridFightSyncData = new GridFightSyncData();
			GridGameRoleInfo gridGameRoleInfo = new GridGameRoleInfo();
			gridGameRoleInfo.Id = item;
			gridGameRoleInfo.Pos = item2;
			gridGameRoleInfo.RoleStar = 1u;
			gridGameRoleInfo.UniqueId = item3;
			string key = item4;
			gridGameRoleInfo.GridFightValueInitComponent[key] = 0u;
			gridFightSyncData.AddRoleInfo = gridGameRoleInfo;
			updateDynamicList.Add(gridFightSyncData);
		}
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData4);
		GridFightSyncResultData gridFightSyncResultData5 = new GridFightSyncResultData();
		gridFightSyncResultData5.UpdateDynamicList.Add(new GridFightSyncData
		{
			FinishPendingActionPos = ackPos
		});
		gridFightSyncResultData5.UpdateDynamicList.Add(new GridFightSyncData
		{
			SyncLockInfo = new GridFightLockInfo()
		});
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData5);
		GridFightSyncResultData gridFightSyncResultData6 = new GridFightSyncResultData();
		gridFightSyncResultData6.UpdateDynamicList.Add(new GridFightSyncData
		{
			LevelSyncInfo = new GridFightLevelSyncInfo
			{
				DCPKPNLKGMM = inst.Level,
				SectionId = inst.SectionId,
				GridFightLayerInfo = new GridFightLayerInfo
				{
					RouteInfo = new GridFightRouteInfo
					{
						FightCampId = 20u,
						EliteBranchId = 1u,
						RouteEncounterList = 
						{
							new GridFightEncounterInfo
							{
								LFKBMDHKPFI = inst.BattleComponent.StageId,
								MonsterWaveList = 
								{
									new GridEncounterMonsterWave
									{
										IGMMPDDCJIN = 1u,
										PPOEDDFFEKK = { inst.BattleComponent.MonsterIds.Select((uint x) => new PJLBDMPEKFP
										{
											MonsterId = x,
											RoleStar = 1u
										}) }
									}
								}
							}
						}
					}
				}
			}
		});
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData6);
		GridFightSyncResultData gridFightSyncResultData7 = new GridFightSyncResultData();
		gridFightSyncResultData7.UpdateDynamicList.Add(new GridFightSyncData
		{
			SyncLockInfo = new GridFightLockInfo
			{
				LockReason = GridFightLockReason.DfofffceffoKjmjdbjmbmc,
				LockType = GridFightLockType.PjbmhhnlclbEhfhdgpocnh
			}
		});
		gridFightSyncResultData7.UpdateDynamicList.Add(new GridFightSyncData
		{
			PendingAction = inst.PendingAction
		});
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData7);
		await connection.SendPacket(new PacketGridFightSyncUpdateResultScNotify(gridFightSyncUpdateResultScNotify));
	}

	private static async System.Threading.Tasks.Task HandleRoundBegin(Connection connection, GridFightInstance inst, uint ackPos)
	{
		inst.RotateShop();
		uint nextPos = (inst.QueuePosition = ackPos + 8);
		inst.PendingAction = new GridFightPendingAction
		{
			QueuePosition = nextPos,
			ReturnPreparationAction = new GridFightReturnPreparationActionInfo()
		};
		await connection.SendPacket(new PacketGridFightHandlePendingActionScRsp(ackPos));
		await connection.SendPacket(new PacketGridFightSyncUpdateResultScNotify(connection.Player, 1, (ackPos, nextPos)));
	}

	private static async System.Threading.Tasks.Task HandleReturnPreparation(Connection connection, GridFightInstance inst, uint ackPos)
	{
		uint nextPos = (inst.QueuePosition = ackPos + 1);
		inst.PendingAction = null;
		await connection.SendPacket(new PacketGridFightHandlePendingActionScRsp(ackPos));
		await connection.SendPacket(new PacketGridFightSyncUpdateResultScNotify(connection.Player, 1, (ackPos, nextPos)));
	}
}
