using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Config;
using March7thHoney.Data.Excel;
using March7thHoney.Database;
using March7thHoney.Database.Lineup;
using March7thHoney.Database.Scene;
using March7thHoney.Enums.Mission;
using March7thHoney.Enums.Scene;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Lineup;
using March7thHoney.GameServer.Server.Packet.Send.Raid;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.Raid;

public class RaidManager : BasePlayerManager
{
	public March7thHoney.Database.Scene.RaidData RaidData { get; }

	public RaidManager(PlayerInstance player)
		: base(player)
	{
		RaidData = DatabaseHelper.Instance.GetInstanceOrCreateNew<March7thHoney.Database.Scene.RaidData>(player.Uid);
	}

	public RaidStatus GetRaidStatus(int raidId, int worldLevel = 0)
	{
		if (!RaidData.RaidRecordDatas.TryGetValue(raidId, out Dictionary<int, RaidRecord> value))
		{
			return RaidStatus.None;
		}
		if (!value.TryGetValue(worldLevel, out var value2))
		{
			return RaidStatus.None;
		}
		return value2.Status;
	}

	public async ValueTask OnLogin()
	{
		if (RaidData.CurRaidId > 0 && RaidData.RaidRecordDatas.TryGetValue(RaidData.CurRaidId, out Dictionary<int, RaidRecord> value))
		{
			if (value.TryGetValue(RaidData.CurRaidWorldLevel, out var value2))
			{
				await base.Player.SendPacket(new PacketRaidInfoNotify(value2));
				return;
			}
			RaidData.CurRaidId = 0;
			RaidData.CurRaidWorldLevel = 0;
			await base.Player.SendPacket(new PacketRaidInfoNotify());
		}
		else
		{
			RaidData.CurRaidId = 0;
			RaidData.CurRaidWorldLevel = 0;
			await base.Player.SendPacket(new PacketRaidInfoNotify());
		}
	}

	public async ValueTask<RaidRecord?> EnterRaid(int raidId, int worldLevel, List<int>? avatarList = null, bool enterSaved = false)
	{
		if (RaidData.CurRaidId != 0)
		{
			return null;
		}
		GameData.RaidConfigData.TryGetValue(raidId * 100 + worldLevel, out RaidConfigExcel excel);
		if (excel == null)
		{
			return null;
		}
		RaidData.RaidRecordDatas.TryGetValue(raidId, out Dictionary<int, RaidRecord> dict);
		if (dict == null)
		{
			dict = new Dictionary<int, RaidRecord>();
		}
		if (dict.ContainsKey(worldLevel) && !enterSaved)
		{
			await ClearRaid(raidId, worldLevel);
		}
		dict.TryGetValue(worldLevel, out RaidRecord record);
		RaidData.CurRaidId = excel.RaidID;
		RaidData.CurRaidWorldLevel = worldLevel;
		if (record == null)
		{
			int firstMission = excel.MainMissionIDList[0];
			int key = GameData.MainMissionData[firstMission].MissionInfo.StartSubMissionList[0];
			SubMissionData subMissionData = GameData.SubMissionInfoData[key];
			int entranceId = int.Parse(subMissionData.SubMissionInfo.LevelFloorID.ToString().Replace("00", "0"));
			if (!GameData.MapEntranceData.ContainsKey(entranceId))
			{
				entranceId = subMissionData.SubMissionInfo.LevelFloorID;
			}
			if (avatarList != null && avatarList.Count > 0)
			{
				base.Player.LineupManager.SetExtraLineup(ExtraLineupType.LineupHeliobus, avatarList);
				await base.Player.SendPacket(new PacketSyncLineupNotify(base.Player.LineupManager.GetCurLineup()));
			}
			else if (excel.TeamType == RaidTeamTypeEnum.TrialOnly)
			{
				List<int> list = excel.TrialAvatarList.ToList();
				if (list.Count > 0)
				{
					if (base.Player.Data.CurrentGender == Gender.Man)
					{
						foreach (int trialAvatar in excel.TrialAvatarList)
						{
							if (trialAvatar > 10000 && (trialAvatar.ToString().EndsWith("8002") || trialAvatar.ToString().EndsWith("8004") || trialAvatar.ToString().EndsWith("8006")))
							{
								list.Remove(trialAvatar);
							}
						}
					}
					else
					{
						foreach (int trialAvatar2 in excel.TrialAvatarList)
						{
							if (trialAvatar2 > 10000 && (trialAvatar2.ToString().EndsWith("8001") || trialAvatar2.ToString().EndsWith("8003") || trialAvatar2.ToString().EndsWith("8005")))
							{
								list.Remove(trialAvatar2);
							}
						}
					}
				}
				base.Player.LineupManager.SetExtraLineup(ExtraLineupType.LineupHeliobus, list);
				if (excel.LockCaptain)
				{
					base.Player.LineupManager.GetCurLineup().LeaderAvatarId = excel.LockCaptainAvatarID;
				}
				await base.Player.SendPacket(new PacketSyncLineupNotify(base.Player.LineupManager.GetCurLineup()));
			}
			else
			{
				March7thHoney.Database.Lineup.LineupInfo curLineup = base.Player.LineupManager.GetCurLineup();
				base.Player.LineupManager.SetExtraLineup(ExtraLineupType.LineupHeliobus, curLineup.BaseAvatars.Select((LineupAvatarInfo x) => (x.SpecialAvatarId <= 0) ? x.BaseAvatarId : (x.SpecialAvatarId / 10)).ToList());
				await base.Player.SendPacket(new PacketSyncLineupNotify(base.Player.LineupManager.GetCurLineup()));
			}
			int oldEntryId = base.Player.Data.EntryId;
			Position oldPos = base.Player.Data.Pos;
			Position oldRot = base.Player.Data.Rot;
			await base.Player.MissionManager.AcceptMainMission(firstMission);
			await base.Player.EnterScene(entranceId, 0, sendPacket: false);
			record = new RaidRecord
			{
				PlaneId = base.Player.Data.PlaneId,
				FloorId = base.Player.Data.FloorId,
				EntryId = entranceId,
				Pos = base.Player.Data.Pos,
				Rot = base.Player.Data.Rot,
				Status = RaidStatus.Doing,
				WorldLevel = worldLevel,
				RaidId = raidId,
				Lineup = base.Player.LineupManager.GetCurLineup().BaseAvatars,
				OldEntryId = oldEntryId,
				OldPos = oldPos,
				OldRot = oldRot
			};
			if (RaidData.RaidRecordDatas.TryGetValue(raidId, out Dictionary<int, RaidRecord> value))
			{
				value[worldLevel] = record;
			}
			else
			{
				RaidData.RaidRecordDatas[raidId] = new Dictionary<int, RaidRecord> { { worldLevel, record } };
			}
		}
		else
		{
			record.Status = RaidStatus.Doing;
			base.Player.LineupManager.SetExtraLineup(ExtraLineupType.LineupHeliobus, record.Lineup.Select((LineupAvatarInfo x) => (x.SpecialAvatarId <= 0) ? x.BaseAvatarId : x.SpecialAvatarId).ToList());
			await base.Player.LoadScene(record.PlaneId, record.FloorId, record.EntryId, record.Pos, record.Rot, sendPacket: false);
		}
		await base.Player.SendPacket(new PacketRaidInfoNotify(record));
		return record;
	}

	public async ValueTask CheckIfLeaveRaid()
	{
		if (RaidData.CurRaidId == 0)
		{
			return;
		}
		RaidRecord raidRecord = RaidData.RaidRecordDatas[RaidData.CurRaidId][RaidData.CurRaidWorldLevel];
		GameData.RaidConfigData.TryGetValue(RaidData.CurRaidId * 100 + raidRecord.WorldLevel, out RaidConfigExcel value);
		if (value == null)
		{
			return;
		}
		bool flag = true;
		foreach (int mainMissionID in value.MainMissionIDList)
		{
			if (base.Player.MissionManager.GetMainMissionStatus(mainMissionID) != MissionPhaseEnum.Finish)
			{
				flag = false;
			}
		}
		if (flag)
		{
			await FinishRaid();
			await base.Player.MissionManager.HandleFinishType(MissionFinishTypeEnum.RaidFinishCnt);
		}
	}

	public async ValueTask FinishRaid()
	{
		if (RaidData.CurRaidId != 0)
		{
			RaidRecord raidRecord = RaidData.RaidRecordDatas[RaidData.CurRaidId][RaidData.CurRaidWorldLevel];
			GameData.RaidConfigData.TryGetValue(RaidData.CurRaidId * 100 + raidRecord.WorldLevel, out RaidConfigExcel value);
			if (value != null)
			{
				raidRecord.Status = RaidStatus.Finish;
				await base.Player.SendPacket(new PacketRaidInfoNotify(raidRecord));
			}
		}
	}

	public async ValueTask LeaveRaid(bool save)
	{
		if (RaidData.CurRaidId == 0)
		{
			return;
		}
		RaidRecord record = RaidData.RaidRecordDatas[RaidData.CurRaidId][RaidData.CurRaidWorldLevel];
		GameData.RaidConfigData.TryGetValue(RaidData.CurRaidId * 100 + record.WorldLevel, out RaidConfigExcel config);
		if (config == null)
		{
			return;
		}
		record.PlaneId = base.Player.Data.PlaneId;
		record.FloorId = base.Player.Data.FloorId;
		record.EntryId = base.Player.Data.EntryId;
		record.Pos = base.Player.Data.Pos;
		record.Rot = base.Player.Data.Rot;
		if (base.Player.LineupManager.GetCurLineup().IsExtraLineup())
		{
			base.Player.LineupManager.SetExtraLineup(ExtraLineupType.LineupNone, new List<int>());
			await base.Player.SendPacket(new PacketSyncLineupNotify(base.Player.LineupManager.GetCurLineup()));
		}
		if (record.Status == RaidStatus.Finish)
		{
			await base.Player.SendPacket(new PacketRaidInfoNotify());
			if (config.FinishEntranceID <= 0)
			{
				await base.Player.EnterScene(record.OldEntryId, 0, sendPacket: true);
				await base.Player.MoveTo(record.OldPos, record.OldRot);
			}
			else
			{
				await base.Player.EnterScene(config.FinishEntranceID, 0, sendPacket: true);
			}
		}
		else
		{
			await base.Player.EnterScene(record.OldEntryId, 0, sendPacket: true);
			await base.Player.MoveTo(record.OldPos, record.OldRot);
			await base.Player.SendPacket(new PacketRaidInfoNotify());
			if (!save)
			{
				await ClearRaid(record.RaidId, record.WorldLevel);
			}
		}
		RaidData.CurRaidId = 0;
		RaidData.CurRaidWorldLevel = 0;
	}

	public async ValueTask ClearRaid(int raidId, int worldLevel)
	{
		if (!RaidData.RaidRecordDatas.TryGetValue(raidId, out Dictionary<int, RaidRecord> dict) || !dict.TryGetValue(worldLevel, out RaidRecord _))
		{
			return;
		}
		GameData.RaidConfigData.TryGetValue(raidId * 100 + worldLevel, out RaidConfigExcel value2);
		if (value2 == null)
		{
			return;
		}
		HashSet<int> floorIds = new HashSet<int>();
		foreach (int missionId in value2.MainMissionIDList)
		{
			await base.Player.MissionManager.RemoveMainMission(missionId);
			GameData.MainMissionData.TryGetValue(missionId, out MainMissionExcel value3);
			if (value3?.MissionInfo.SubMissionList == null)
			{
				continue;
			}
			foreach (int item in value3.MissionInfo.SubMissionList.Select((SubMissionInfo x) => x.LevelFloorID).ToHashSet())
			{
				floorIds.Add(item);
			}
		}
		dict.Remove(worldLevel);
		if (dict.Count == 0)
		{
			RaidData.RaidRecordDatas.Remove(raidId);
		}
		foreach (int item2 in floorIds)
		{
			base.Player.SceneData.PropTimelineData.Remove(item2);
			base.Player.SceneData.GroupPropertyData.Remove(item2);
			base.Player.SceneData.FloorTargetPuzzleGroupData.Remove(item2);
			base.Player.SceneData.FloorSavedData.Remove(item2);
			base.Player.SceneData.ScenePropData.Remove(item2);
		}
		await base.Player.SendPacket(new PacketDelSaveRaidScNotify(raidId, worldLevel));
	}
}
