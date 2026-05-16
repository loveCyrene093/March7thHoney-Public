using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database;
using March7thHoney.Database.Lineup;
using March7thHoney.Database.Quests;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Lineup;
using March7thHoney.GameServer.Server.Packet.Send.StoryLine;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.Mission;

public class StoryLineManager : BasePlayerManager
{
	public StoryLineData StoryLineData { get; set; }

	public StoryLineManager(PlayerInstance player)
	{
		StoryLineData = DatabaseHelper.Instance.GetInstanceOrCreateNew<StoryLineData>(player.Uid);
		base._002Ector(player);
	}

	public async ValueTask CheckIfEnterStoryLine()
	{
		if (StoryLineData.CurStoryLineId != 0)
		{
			return;
		}
		foreach (StoryLineExcel value in GameData.StoryLineData.Values)
		{
			if (base.Player.MissionManager.GetSubMissionStatus(value.BeginCondition.Param) == MissionPhaseEnum.Finish)
			{
				await InitStoryLine(value.StoryLineID);
				return;
			}
		}
	}

	public async ValueTask InitStoryLine(int storyLineId, int entryId = 0, int anchorGroupId = 0, int anchorId = 0)
	{
		if (StoryLineData.CurStoryLineId != 0)
		{
			await FinishStoryLine(entryId, anchorGroupId, anchorId, tp: false);
		}
		GameData.StoryLineData.TryGetValue(storyLineId, out StoryLineExcel storyExcel);
		if (storyExcel != null)
		{
			StoryLineData.RunningStoryLines.TryGetValue(storyLineId, out StoryLineInfo lineInfo);
			StoryLineData.OldEntryId = base.Player.Data.EntryId;
			StoryLineData.OldFloorId = base.Player.Data.FloorId;
			StoryLineData.OldPlaneId = base.Player.Data.PlaneId;
			StoryLineData.OldPos = base.Player.Data.Pos;
			StoryLineData.OldRot = base.Player.Data.Rot;
			List<int> baseAvatarIds = base.Player.LineupManager.GetCurLineup().BaseAvatars.Select((LineupAvatarInfo x) => (x.SpecialAvatarId <= 0) ? x.BaseAvatarId : (x.SpecialAvatarId / 10)).ToList();
			base.Player.LineupManager.SetExtraLineup(ExtraLineupType.LineupHeliobus, baseAvatarIds);
			StoryLineData.CurStoryLineId = storyExcel.StoryLineID;
			await base.Player.SendPacket(new PacketStoryLineInfoScNotify(base.Player));
			await base.Player.SendPacket(new PacketSyncLineupNotify(base.Player.LineupManager.GetCurLineup()));
			if (entryId > 0)
			{
				await base.Player.EnterSceneByEntranceId(entryId, anchorGroupId, anchorId, sendPacket: true);
			}
			else if (lineInfo != null)
			{
				await base.Player.LoadScene(lineInfo.SavedPlaneId, lineInfo.SavedFloorId, lineInfo.SavedEntryId, lineInfo.SavedPos, lineInfo.SavedRot, sendPacket: true);
			}
			else
			{
				await base.Player.EnterSceneByEntranceId(storyExcel.InitEntranceID, storyExcel.InitGroupID, storyExcel.InitAnchorID, sendPacket: true);
			}
			await base.Player.SendPacket(new PacketChangeStoryLineFinishScNotify(storyExcel.StoryLineID, ChangeStoryLineAction.FinishAction));
			StoryLineInfo value = new StoryLineInfo
			{
				Lineup = base.Player.LineupManager.GetCurLineup().BaseAvatars,
				SavedEntryId = base.Player.Data.EntryId,
				SavedFloorId = base.Player.Data.FloorId,
				SavedPlaneId = base.Player.Data.PlaneId,
				SavedPos = base.Player.Data.Pos,
				SavedRot = base.Player.Data.Rot,
				StoryLineId = storyExcel.StoryLineID
			};
			StoryLineData.RunningStoryLines[storyExcel.StoryLineID] = value;
		}
	}

	public async ValueTask EnterStoryLine(int storyLineId, bool tp = true)
	{
		if (StoryLineData.CurStoryLineId == storyLineId)
		{
			return;
		}
		if (storyLineId == 0)
		{
			await LeaveStoryLine(tp);
			return;
		}
		StoryLineData.RunningStoryLines.TryGetValue(storyLineId, out StoryLineInfo lineInfo);
		if (lineInfo != null)
		{
			if (StoryLineData.CurStoryLineId != 0)
			{
				await LeaveStoryLine(tp: false);
			}
			else
			{
				StoryLineData.OldEntryId = base.Player.Data.EntryId;
				StoryLineData.OldFloorId = base.Player.Data.FloorId;
				StoryLineData.OldPlaneId = base.Player.Data.PlaneId;
				StoryLineData.OldPos = base.Player.Data.Pos;
				StoryLineData.OldRot = base.Player.Data.Rot;
			}
			base.Player.LineupManager.SetExtraLineup(ExtraLineupType.LineupHeliobus, lineInfo.Lineup.Select((LineupAvatarInfo x) => (x.SpecialAvatarId <= 0) ? x.BaseAvatarId : x.SpecialAvatarId).ToList());
			StoryLineData.CurStoryLineId = lineInfo.StoryLineId;
			await base.Player.SendPacket(new PacketStoryLineInfoScNotify(base.Player));
			await base.Player.SendPacket(new PacketSyncLineupNotify(base.Player.LineupManager.GetCurLineup()));
			if (tp)
			{
				await base.Player.LoadScene(lineInfo.SavedPlaneId, lineInfo.SavedFloorId, lineInfo.SavedEntryId, lineInfo.SavedPos, lineInfo.SavedRot, sendPacket: true);
			}
			await base.Player.SendPacket(new PacketChangeStoryLineFinishScNotify(StoryLineData.CurStoryLineId, ChangeStoryLineAction.Client));
		}
	}

	public async ValueTask LeaveStoryLine(bool tp)
	{
		if (StoryLineData.CurStoryLineId == 0)
		{
			return;
		}
		GameData.StoryLineData.TryGetValue(StoryLineData.CurStoryLineId, out StoryLineExcel value);
		if (value != null)
		{
			StoryLineInfo value2 = new StoryLineInfo
			{
				Lineup = base.Player.LineupManager.GetCurLineup().BaseAvatars,
				SavedEntryId = base.Player.Data.EntryId,
				SavedFloorId = base.Player.Data.FloorId,
				SavedPlaneId = base.Player.Data.PlaneId,
				SavedPos = base.Player.Data.Pos,
				SavedRot = base.Player.Data.Rot,
				StoryLineId = value.StoryLineID
			};
			base.Player.LineupManager.SetExtraLineup(ExtraLineupType.LineupNone, new List<int>());
			StoryLineData.RunningStoryLines[value.StoryLineID] = value2;
			StoryLineData.CurStoryLineId = 0;
			await base.Player.SendPacket(new PacketStoryLineInfoScNotify(base.Player));
			await base.Player.SendPacket(new PacketSyncLineupNotify(base.Player.LineupManager.GetCurLineup()));
			if (tp)
			{
				await base.Player.LoadScene(StoryLineData.OldPlaneId, StoryLineData.OldFloorId, StoryLineData.OldEntryId, StoryLineData.OldPos, StoryLineData.OldRot, sendPacket: true);
				StoryLineData.OldPlaneId = 0;
				StoryLineData.OldEntryId = 0;
				StoryLineData.OldFloorId = 0;
				StoryLineData.OldPos = new Position();
				StoryLineData.OldRot = new Position();
			}
			await base.Player.SendPacket(new PacketChangeStoryLineFinishScNotify(0, ChangeStoryLineAction.None));
		}
	}

	public async ValueTask CheckIfFinishStoryLine()
	{
		if (StoryLineData.CurStoryLineId != 0)
		{
			GameData.StoryLineData.TryGetValue(StoryLineData.CurStoryLineId, out StoryLineExcel value);
			if (value != null && base.Player.MissionManager.GetSubMissionStatus(value.EndCondition.Param) == MissionPhaseEnum.Finish)
			{
				await FinishStoryLine();
			}
		}
	}

	public async ValueTask FinishStoryLine(int entryId = 0, int anchorGroupId = 0, int anchorId = 0, bool tp = true)
	{
		if (StoryLineData.CurStoryLineId == 0)
		{
			return;
		}
		GameData.StoryLineData.TryGetValue(StoryLineData.CurStoryLineId, out StoryLineExcel value);
		if (value == null)
		{
			return;
		}
		base.Player.LineupManager.SetExtraLineup(ExtraLineupType.LineupNone, new List<int>());
		if (base.Player.MissionManager.GetSubMissionStatus(value.EndCondition.Param) == MissionPhaseEnum.Finish)
		{
			StoryLineData.RunningStoryLines.Remove(StoryLineData.CurStoryLineId);
		}
		else
		{
			StoryLineData.RunningStoryLines[StoryLineData.CurStoryLineId] = new StoryLineInfo
			{
				Lineup = base.Player.LineupManager.GetCurLineup().BaseAvatars,
				SavedEntryId = base.Player.Data.EntryId,
				SavedFloorId = base.Player.Data.FloorId,
				SavedPlaneId = base.Player.Data.PlaneId,
				SavedPos = base.Player.Data.Pos,
				SavedRot = base.Player.Data.Rot,
				StoryLineId = StoryLineData.CurStoryLineId
			};
		}
		StoryLineData.CurStoryLineId = 0;
		StoryLineData.OldPlaneId = 0;
		StoryLineData.OldEntryId = 0;
		StoryLineData.OldFloorId = 0;
		StoryLineData.OldPos = new Position();
		StoryLineData.OldRot = new Position();
		await base.Player.SendPacket(new PacketSyncLineupNotify(base.Player.LineupManager.GetCurLineup()));
		await base.Player.SendPacket(new PacketStoryLineInfoScNotify(base.Player));
		await base.Player.SendPacket(new PacketChangeStoryLineFinishScNotify(0, ChangeStoryLineAction.None));
		if (tp)
		{
			if (entryId > 0)
			{
				await base.Player.EnterSceneByEntranceId(entryId, anchorGroupId, anchorId, sendPacket: true);
			}
			else
			{
				await base.Player.LoadScene(StoryLineData.OldPlaneId, StoryLineData.OldFloorId, StoryLineData.OldEntryId, StoryLineData.OldPos, StoryLineData.OldRot, sendPacket: true);
			}
		}
	}

	public async ValueTask OnLogin()
	{
		await base.Player.SendPacket(new PacketStoryLineInfoScNotify(base.Player));
	}
}
