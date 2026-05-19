using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Protobuf.Collections;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.GameServer.Game.GridFight.Battle;
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
		List<uint> list = inst.RollPortalBuffs(3, inst.CurrentPortalBuffOffer.ToList());
		inst.QueuePosition = ackPos;
		inst.PendingAction = new GridFightPendingAction
		{
			QueuePosition = ackPos,
			PortalBuffAction = new GridFightPortalBuffActionInfo
			{
				FCHPJKAIBHB = 1u,
				GridFightPortalBuffList = { (IEnumerable<uint>)list }
			}
		};
		GridFightSeasonHandBookNotify gridFightSeasonHandBookNotify = new GridFightSeasonHandBookNotify
		{
			HandbookGridFightPortalInfo = new GridFightHandBookPortalInfo()
		};
		foreach (uint item in list)
		{
			gridFightSeasonHandBookNotify.HandbookGridFightPortalInfo.PELJLONLDNM.Add(item);
		}
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
		inst.ClearPortalBuffOffer();
		uint requiredTrait = 0u;
		if (GameData.GridFightPortalBuffData.TryGetValue(buffId, out GridFightPortalBuffExcel value) && value.PortalGameRefTrait.Count > 0)
		{
			requiredTrait = value.PortalGameRefTrait[0];
		}
		inst.MaterializeInitialBenchTeam(requiredTrait);
		GridFightLevelEncounter gridFightLevelEncounter = GridFightLevelResolver.Resolve(inst);
		inst.ConfigureNextBattle(gridFightLevelEncounter.StageId, gridFightLevelEncounter.Monsters.Select((GridFightMonsterSpec m) => m.MonsterId));
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
		List<uint> list = new List<uint>();
		if (GameData.GridFightPortalBuffData.TryGetValue(buffId, out GridFightPortalBuffExcel value2))
		{
			foreach (uint showBonusID in value2.ShowBonusIDList)
			{
				if (GameData.GridFightEquipmentData.ContainsKey(showBonusID))
				{
					list.Add(showBonusID);
				}
			}
		}
		if (list.Count > 0)
		{
			GridFightSyncResultData gridFightSyncResultData = new GridFightSyncResultData
			{
				GridUpdateSrc = GridFightUpdateSrcType.LnpfefkjdhpPnejelgglej
			};
			gridFightSyncResultData.SyncEffectParamList.Add(buffId);
			gridFightSyncResultData.SyncEffectParamList.Add(0u);
			GridFightGameItemSyncInfo gridFightGameItemSyncInfo = new GridFightGameItemSyncInfo();
			foreach (uint item5 in list)
			{
				gridFightGameItemSyncInfo.GridFightEquipmentList.Add(new GridFightEquipmentInfo
				{
					GridFightEquipmentId = item5,
					Source = 1u,
					UniqueId = inst.AllocEquipUniqueId()
				});
			}
			gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
			{
				AddGameItemInfo = gridFightGameItemSyncInfo
			});
			gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData);
		}
		GridFightSyncResultData gridFightSyncResultData2 = new GridFightSyncResultData
		{
			GridUpdateSrc = GridFightUpdateSrcType.LnpfefkjdhpHndkhmefaal
		};
		gridFightSyncResultData2.UpdateDynamicList.Add(new GridFightSyncData
		{
			PortalServerDataUpdate = new GridFightPortalServerDataUpdate
			{
				PortalBuffId = buffId
			}
		});
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData2);
		GridFightSyncResultData gridFightSyncResultData3 = new GridFightSyncResultData
		{
			GridUpdateSrc = GridFightUpdateSrcType.LnpfefkjdhpBjdeaahibge
		};
		gridFightSyncResultData3.UpdateDynamicList.Add(new GridFightSyncData
		{
			ItemValue = inst.Gold
		});
		foreach (var rolledBenchRole in inst.RolledBenchRoles)
		{
			uint item = rolledBenchRole.AvatarId;
			uint item2 = rolledBenchRole.Pos;
			uint item3 = rolledBenchRole.UniqueId;
			string item4 = rolledBenchRole.Component;
			RepeatedField<GridFightSyncData> updateDynamicList = gridFightSyncResultData3.UpdateDynamicList;
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
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData3);
		GridFightSyncResultData gridFightSyncResultData4 = new GridFightSyncResultData();
		gridFightSyncResultData4.UpdateDynamicList.Add(new GridFightSyncData
		{
			FinishPendingActionPos = ackPos
		});
		gridFightSyncResultData4.UpdateDynamicList.Add(new GridFightSyncData
		{
			SyncLockInfo = new GridFightLockInfo()
		});
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData4);
		GridFightSyncResultData gridFightSyncResultData5 = new GridFightSyncResultData();
		gridFightSyncResultData5.UpdateDynamicList.Add(new GridFightSyncData
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
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData5);
		GridFightSyncResultData gridFightSyncResultData6 = new GridFightSyncResultData();
		gridFightSyncResultData6.UpdateDynamicList.Add(new GridFightSyncData
		{
			SyncLockInfo = new GridFightLockInfo
			{
				LockReason = GridFightLockReason.DfofffceffoKjmjdbjmbmc,
				LockType = GridFightLockType.PjbmhhnlclbEhfhdgpocnh
			}
		});
		gridFightSyncResultData6.UpdateDynamicList.Add(new GridFightSyncData
		{
			PendingAction = inst.PendingAction
		});
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData6);
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
		await connection.SendPacket(new PacketGridFightSyncUpdateResultScNotify(connection.Player, 4));
	}

	private static async System.Threading.Tasks.Task HandleReturnPreparation(Connection connection, GridFightInstance inst, uint ackPos)
	{
		uint nextPos = (inst.QueuePosition = ackPos + 1);
		inst.PendingAction = null;
		await connection.SendPacket(new PacketGridFightHandlePendingActionScRsp(ackPos));
		await connection.SendPacket(new PacketGridFightSyncUpdateResultScNotify(connection.Player, 1, (ackPos, nextPos)));
	}
}
