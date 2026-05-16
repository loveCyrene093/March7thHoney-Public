using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database;
using March7thHoney.Database.Avatar;
using March7thHoney.Database.Lineup;
using March7thHoney.Enums.Avatar;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Plugin.Event;
using March7thHoney.GameServer.Server.Packet.Send.Lineup;
using March7thHoney.GameServer.Server.Packet.Send.Scene;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.Lineup;

public class LineupManager : BasePlayerManager
{
	public LineupData LineupData { get; }

	public LineupManager(PlayerInstance player)
		: base(player)
	{
		LineupData = DatabaseHelper.Instance.GetInstanceOrCreateNew<LineupData>(player.Uid);
		foreach (March7thHoney.Database.Lineup.LineupInfo value in LineupData.Lineups.Values)
		{
			value.LineupData = LineupData;
			value.AvatarData = player.AvatarManager.AvatarData;
		}
	}

	public March7thHoney.Database.Lineup.LineupInfo? GetLineup(int lineupIndex)
	{
		LineupData.Lineups.TryGetValue(lineupIndex, out March7thHoney.Database.Lineup.LineupInfo value);
		return value;
	}

	public March7thHoney.Database.Lineup.LineupInfo? GetExtraLineup(ExtraLineupType type)
	{
		int key = (int)(type + 10);
		LineupData.Lineups.TryGetValue(key, out March7thHoney.Database.Lineup.LineupInfo value);
		return value;
	}

	public March7thHoney.Database.Lineup.LineupInfo? GetCurLineup()
	{
		return GetLineup(LineupData.GetCurLineupIndex());
	}

	public int GetMaxMp()
	{
		return 5 + LineupData.ExtraMpCount;
	}

	public List<AvatarLineupData> GetAvatarsFromTeam(int index)
	{
		March7thHoney.Database.Lineup.LineupInfo lineup = GetLineup(index);
		if (lineup == null)
		{
			return new List<AvatarLineupData>();
		}
		List<AvatarLineupData> list = new List<AvatarLineupData>();
		foreach (LineupAvatarInfo avatar in lineup.BaseAvatars)
		{
			AvatarType avatarType = AvatarType.AvatarFormalType;
			BaseAvatarInfo baseAvatarInfo = null;
			if (avatar.SpecialAvatarId > 0)
			{
				baseAvatarInfo = base.Player.AvatarManager.GetTrialAvatar(avatar.SpecialAvatarId);
				avatarType = AvatarType.AvatarTrialType;
			}
			else if (avatar.AssistUid > 0)
			{
				AvatarData avatarData = DatabaseHelper.Instance?.GetInstance<AvatarData>(avatar.AssistUid);
				avatarType = AvatarType.AvatarAssistType;
				if (avatarData == null)
				{
					continue;
				}
				using IEnumerator<FormalAvatarInfo> enumerator2 = avatarData.FormalAvatars.Where((FormalAvatarInfo formalAvatarInfo) => formalAvatarInfo.AvatarId == avatar.BaseAvatarId).GetEnumerator();
				if (enumerator2.MoveNext())
				{
					baseAvatarInfo = enumerator2.Current;
				}
			}
			else
			{
				baseAvatarInfo = base.Player.AvatarManager.GetFormalAvatar(avatar.BaseAvatarId);
			}
			if (baseAvatarInfo != null)
			{
				list.Add(new AvatarLineupData(baseAvatarInfo, avatarType));
			}
		}
		return list;
	}

	public List<AvatarLineupData> GetAvatarsFromCurTeam()
	{
		return GetAvatarsFromTeam(LineupData.GetCurLineupIndex());
	}

	public List<March7thHoney.Database.Lineup.LineupInfo> GetAllLineup()
	{
		List<March7thHoney.Database.Lineup.LineupInfo> list = new List<March7thHoney.Database.Lineup.LineupInfo>();
		foreach (March7thHoney.Database.Lineup.LineupInfo value in LineupData.Lineups.Values)
		{
			list.Add(value);
		}
		if (list.Count < 9)
		{
			for (int i = list.Count; i < 9; i++)
			{
				March7thHoney.Database.Lineup.LineupInfo lineupInfo = new March7thHoney.Database.Lineup.LineupInfo
				{
					Name = "",
					LineupType = 0,
					BaseAvatars = new List<LineupAvatarInfo>(),
					LineupData = LineupData,
					AvatarData = base.Player.AvatarManager.AvatarData
				};
				list.Add(lineupInfo);
				LineupData.Lineups.Add(i, lineupInfo);
			}
		}
		return list;
	}

	public async ValueTask<bool> SetCurLineup(int lineupIndex)
	{
		if (lineupIndex < 0 || !LineupData.Lineups.ContainsKey(lineupIndex))
		{
			return false;
		}
		if (GetLineup(lineupIndex).BaseAvatars.Count == 0)
		{
			return false;
		}
		LineupData.CurLineup = lineupIndex;
		LineupData.CurExtraLineup = -1;
		base.Player.SceneInstance?.SyncLineup();
		await base.Player.SendPacket(new PacketSyncLineupNotify(GetCurLineup()));
		return true;
	}

	public void SetExtraLineup(ExtraLineupType type, List<int> baseAvatarIds, bool refresh = false)
	{
		if (type == ExtraLineupType.LineupNone)
		{
			LineupData.CurExtraLineup = -1;
			return;
		}
		int num = (int)(type + 10);
		LineupData.Lineups.Remove(num);
		March7thHoney.Database.Lineup.LineupInfo lineupInfo = new March7thHoney.Database.Lineup.LineupInfo
		{
			Name = "",
			LineupType = (int)type,
			BaseAvatars = new List<LineupAvatarInfo>(),
			LineupData = LineupData,
			AvatarData = base.Player.AvatarManager.AvatarData
		};
		int worldLevel = ((type != ExtraLineupType.LineupStageTrial) ? base.Player.Data.WorldLevel : 0);
		foreach (int baseAvatarId in baseAvatarIds)
		{
			SpecialAvatarInfo trialAvatar = base.Player.AvatarManager.GetTrialAvatar(baseAvatarId, refresh);
			if (trialAvatar != null)
			{
				if (!GameData.MultiplePathAvatarConfigData.TryGetValue(trialAvatar.AvatarId, out MultiplePathAvatarConfigExcel value) || value.Gender == GenderTypeEnum.GENDER_NONE || value.Gender == (GenderTypeEnum)base.Player.Data.CurrentGender)
				{
					trialAvatar.CheckLevel(worldLevel);
					lineupInfo.BaseAvatars.Add(new LineupAvatarInfo
					{
						BaseAvatarId = trialAvatar.BaseAvatarId,
						SpecialAvatarId = trialAvatar.SpecialAvatarId
					});
				}
			}
			else
			{
				lineupInfo.BaseAvatars.Add(new LineupAvatarInfo
				{
					BaseAvatarId = baseAvatarId
				});
			}
		}
		LineupData.Lineups.Add(num, lineupInfo);
		LineupData.CurExtraLineup = num;
	}

	public async ValueTask SetExtraLineup(ExtraLineupType type, bool notify = true)
	{
		if (type == ExtraLineupType.LineupNone)
		{
			LineupData.CurExtraLineup = -1;
			if (notify)
			{
				await base.Player.SendPacket(new PacketSyncLineupNotify(GetCurLineup()));
			}
			return;
		}
		int curExtraLineup = (int)(type + 10);
		March7thHoney.Database.Lineup.LineupInfo extraLineup = GetExtraLineup(type);
		if (extraLineup == null)
		{
			return;
		}
		List<LineupAvatarInfo>? baseAvatars = extraLineup.BaseAvatars;
		if (baseAvatars == null || baseAvatars.Count != 0)
		{
			LineupData.CurExtraLineup = curExtraLineup;
			if (notify)
			{
				await base.Player.SendPacket(new PacketSyncLineupNotify(GetCurLineup()));
			}
		}
	}

	public async ValueTask AddAvatar(int lineupIndex, int avatarId, bool sendPacket = true)
	{
		if (lineupIndex < 0)
		{
			return;
		}
		LineupData.Lineups.TryGetValue(lineupIndex, out March7thHoney.Database.Lineup.LineupInfo value);
		if (value == null)
		{
			int num = avatarId;
			if (GameData.MultiplePathAvatarConfigData.TryGetValue(num, out MultiplePathAvatarConfigExcel value2))
			{
				num = value2.BaseAvatarID;
			}
			int key = avatarId * 10;
			GameData.SpecialAvatarData.TryGetValue(key, out SpecialAvatarExcel value3);
			if (value3 != null)
			{
				base.Player.AvatarManager.GetTrialAvatar(avatarId)?.CheckLevel(base.Player.Data.WorldLevel);
				num = value3.AvatarID;
			}
			else if (num > 8000 && !GameData.AvatarConfigData.ContainsKey(num))
			{
				num = 8001;
			}
			value = new March7thHoney.Database.Lineup.LineupInfo
			{
				Name = "",
				LineupType = 0,
				BaseAvatars = new List<LineupAvatarInfo>(1)
				{
					new LineupAvatarInfo
					{
						BaseAvatarId = num,
						SpecialAvatarId = (value3?.SpecialAvatarID ?? 0)
					}
				},
				LineupData = LineupData,
				AvatarData = base.Player.AvatarManager.AvatarData
			};
			LineupData.Lineups.Add(lineupIndex, value);
		}
		else
		{
			if (value.BaseAvatars.Count >= 4)
			{
				return;
			}
			int num2 = avatarId;
			if (GameData.MultiplePathAvatarConfigData.TryGetValue(num2, out MultiplePathAvatarConfigExcel value4))
			{
				num2 = value4.BaseAvatarID;
			}
			int key2 = avatarId * 10;
			GameData.SpecialAvatarData.TryGetValue(key2, out SpecialAvatarExcel value5);
			if (value5 != null)
			{
				base.Player.AvatarManager.GetTrialAvatar(avatarId)?.CheckLevel(base.Player.Data.WorldLevel);
				num2 = value5.AvatarID;
			}
			else if (num2 > 8000 && !GameData.AvatarConfigData.ContainsKey(num2))
			{
				num2 = 8001;
			}
			value.BaseAvatars?.Add(new LineupAvatarInfo
			{
				BaseAvatarId = num2,
				SpecialAvatarId = (value5?.SpecialAvatarID ?? 0)
			});
			LineupData.Lineups[lineupIndex] = value;
		}
		if (sendPacket)
		{
			if (lineupIndex == LineupData.GetCurLineupIndex())
			{
				base.Player.SceneInstance?.SyncLineup();
			}
			PluginEvent.InvokeOnPlayerSyncLineup(base.Player, value);
			await base.Player.SendPacket(new PacketSyncLineupNotify(value));
		}
	}

	public async ValueTask AddAvatarToCurTeam(int avatarId, bool sendPacket = true)
	{
		await AddAvatar(LineupData.GetCurLineupIndex(), avatarId, sendPacket);
	}

	public async ValueTask AddSpecialAvatarToCurTeam(int specialAvatarId, bool sendPacket = true)
	{
		LineupData.Lineups.TryGetValue(LineupData.GetCurLineupIndex(), out March7thHoney.Database.Lineup.LineupInfo value);
		GameData.SpecialAvatarData.TryGetValue(specialAvatarId, out SpecialAvatarExcel value2);
		if (value2 == null)
		{
			return;
		}
		base.Player.AvatarManager.GetTrialAvatar(value2.SpecialAvatarID)?.CheckLevel(base.Player.Data.WorldLevel);
		if (value == null)
		{
			value = new March7thHoney.Database.Lineup.LineupInfo
			{
				Name = "",
				LineupType = 0,
				BaseAvatars = new List<LineupAvatarInfo>(1)
				{
					new LineupAvatarInfo
					{
						BaseAvatarId = value2.AvatarID,
						SpecialAvatarId = value2.SpecialAvatarID
					}
				},
				LineupData = LineupData,
				AvatarData = base.Player.AvatarManager.AvatarData
			};
			LineupData.Lineups.Add(LineupData.GetCurLineupIndex(), value);
		}
		else
		{
			if (value.BaseAvatars.Count >= 4)
			{
				value.BaseAvatars.RemoveAt(3);
			}
			value.BaseAvatars?.Add(new LineupAvatarInfo
			{
				BaseAvatarId = value2.AvatarID,
				SpecialAvatarId = value2.SpecialAvatarID
			});
			LineupData.Lineups[LineupData.GetCurLineupIndex()] = value;
		}
		if (sendPacket)
		{
			base.Player.SceneInstance?.SyncLineup();
			PluginEvent.InvokeOnPlayerSyncLineup(base.Player, value);
			await base.Player.SendPacket(new PacketSyncLineupNotify(value));
		}
	}

	public async ValueTask RemoveAvatar(int lineupIndex, int avatarId, bool sendPacket = true)
	{
		if (lineupIndex < 0)
		{
			return;
		}
		LineupData.Lineups.TryGetValue(lineupIndex, out March7thHoney.Database.Lineup.LineupInfo value);
		if (value == null)
		{
			return;
		}
		GameData.SpecialAvatarData.TryGetValue(avatarId * 10 + base.Player.Data.WorldLevel, out SpecialAvatarExcel specialAvatar);
		if (specialAvatar != null)
		{
			value.BaseAvatars?.RemoveAll((LineupAvatarInfo avatar) => avatar.BaseAvatarId == specialAvatar.AvatarID);
		}
		else
		{
			value.BaseAvatars?.RemoveAll((LineupAvatarInfo avatar) => avatar.BaseAvatarId == avatarId);
		}
		LineupData.Lineups[lineupIndex] = value;
		if (sendPacket)
		{
			if (lineupIndex == LineupData.GetCurLineupIndex())
			{
				base.Player.SceneInstance?.SyncLineup();
			}
			PluginEvent.InvokeOnPlayerSyncLineup(base.Player, value);
			await base.Player.SendPacket(new PacketSyncLineupNotify(value));
		}
	}

	public async ValueTask RemoveAvatarFromCurTeam(int avatarId, bool sendPacket = true)
	{
		await RemoveAvatar(LineupData.GetCurLineupIndex(), avatarId, sendPacket);
	}

	public async ValueTask ReplaceLineup(int lineupIndex, List<int> lineupSlotList, ExtraLineupType extraLineupType = ExtraLineupType.LineupNone)
	{
		if (extraLineupType != ExtraLineupType.LineupNone)
		{
			LineupData.CurExtraLineup = (int)(extraLineupType + 10);
			if (!LineupData.Lineups.ContainsKey(LineupData.CurExtraLineup))
			{
				SetExtraLineup(extraLineupType, new List<int>());
			}
		}
		March7thHoney.Database.Lineup.LineupInfo lineup;
		if (LineupData.CurExtraLineup != -1)
		{
			lineup = LineupData.Lineups[LineupData.CurExtraLineup];
		}
		else
		{
			if (lineupIndex < 0 || !LineupData.Lineups.TryGetValue(lineupIndex, out March7thHoney.Database.Lineup.LineupInfo value))
			{
				return;
			}
			lineup = value;
		}
		lineup.BaseAvatars = new List<LineupAvatarInfo>();
		int index = ((lineup.LineupType == 0) ? lineupIndex : LineupData.GetCurLineupIndex());
		foreach (int lineupSlot in lineupSlotList)
		{
			await AddAvatar(index, lineupSlot, sendPacket: false);
		}
		if (index == LineupData.GetCurLineupIndex())
		{
			base.Player.SceneInstance?.SyncLineup();
		}
		PluginEvent.InvokeOnPlayerSyncLineup(base.Player, lineup);
		await base.Player.SendPacket(new PacketSyncLineupNotify(lineup));
	}

	public async ValueTask ReplaceLineup(ReplaceLineupCsReq req)
	{
		if (req.ExtraLineupType != ExtraLineupType.LineupNone)
		{
			LineupData.CurExtraLineup = (int)(req.ExtraLineupType + 10);
			if (!LineupData.Lineups.ContainsKey(LineupData.CurExtraLineup))
			{
				SetExtraLineup(req.ExtraLineupType, new List<int>());
			}
		}
		March7thHoney.Database.Lineup.LineupInfo lineup;
		if (LineupData.CurExtraLineup != -1)
		{
			lineup = LineupData.Lineups[LineupData.CurExtraLineup];
		}
		else
		{
			if (!LineupData.Lineups.ContainsKey((int)req.Index))
			{
				return;
			}
			lineup = LineupData.Lineups[(int)req.Index];
		}
		lineup.BaseAvatars = new List<LineupAvatarInfo>();
		int index = ((lineup.LineupType == 0) ? ((int)req.Index) : LineupData.GetCurLineupIndex());
		foreach (LineupSlotData lineupSlot in req.LineupSlotList)
		{
			await AddAvatar(index, (int)lineupSlot.Id, sendPacket: false);
		}
		if (index == LineupData.GetCurLineupIndex())
		{
			base.Player.SceneInstance?.SyncLineup();
		}
		PluginEvent.InvokeOnPlayerSyncLineup(base.Player, lineup);
		await base.Player.SendPacket(new PacketSyncLineupNotify(lineup));
	}

	public async ValueTask DestroyExtraLineup(ExtraLineupType type)
	{
		int key = (int)(type + 10);
		LineupData.Lineups.Remove(key);
		await base.Player.SendPacket(new PacketExtraLineupDestroyNotify(type));
	}

	public async ValueTask CostMp(int count, uint castEntityId = 1u)
	{
		March7thHoney.Database.Lineup.LineupInfo curLineup = GetCurLineup();
		curLineup.Mp -= count;
		curLineup.Mp = Math.Min(Math.Max(0, curLineup.Mp), GetMaxMp());
		await base.Player.SendPacket(new PacketSceneCastSkillMpUpdateScNotify(castEntityId, curLineup.Mp));
	}

	public async ValueTask GainMp(int count, bool sendPacket = true, SyncLineupReason reason = SyncLineupReason.SyncReasonNone)
	{
		March7thHoney.Database.Lineup.LineupInfo curLineup = GetCurLineup();
		curLineup.Mp += count;
		curLineup.Mp = Math.Min(Math.Max(0, curLineup.Mp), GetMaxMp());
		if (sendPacket)
		{
			await base.Player.SendPacket(new PacketSyncLineupNotify(GetCurLineup(), reason));
		}
	}
}
