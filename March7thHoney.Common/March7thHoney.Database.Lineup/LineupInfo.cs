using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using March7thHoney.Database.Avatar;
using March7thHoney.Database.Quests;
using March7thHoney.Proto;
using Newtonsoft.Json;

namespace March7thHoney.Database.Lineup;

public class LineupInfo
{
	public string? Name { get; set; }

	public int LineupType { get; set; }

	public int LeaderAvatarId { get; set; }

	public List<LineupAvatarInfo>? BaseAvatars { get; set; }

	[DefaultValue(5)]
	public int Mp { get; set; } = 5;

	[JsonIgnore]
	public LineupData? LineupData { get; set; }

	[JsonIgnore]
	public AvatarData? AvatarData { get; set; }

	public int GetSlot(int avatarId)
	{
		return BaseAvatars?.FindIndex((LineupAvatarInfo item) => item.BaseAvatarId == avatarId) ?? (-1);
	}

	public bool Heal(int count, bool allowRevive)
	{
		bool result = false;
		if (BaseAvatars != null && AvatarData != null)
		{
			foreach (LineupAvatarInfo avatar in BaseAvatars)
			{
				BaseAvatarInfo baseAvatarInfo = ((avatar.SpecialAvatarId <= 0) ? ((BaseAvatarInfo)(AvatarData?.FormalAvatars?.Find((FormalAvatarInfo item) => item.BaseAvatarId == avatar.BaseAvatarId))) : ((BaseAvatarInfo)(AvatarData?.TrialAvatars?.Find((SpecialAvatarInfo item) => item.SpecialAvatarId == avatar.SpecialAvatarId))));
				if (baseAvatarInfo != null && (baseAvatarInfo.GetCurHp(IsExtraLineup()) > 0 || allowRevive) && (baseAvatarInfo.GetCurHp(IsExtraLineup()) < 10000 || count <= 0) && (baseAvatarInfo.GetCurHp(IsExtraLineup()) > 0 || count >= 0))
				{
					baseAvatarInfo.SetCurHp(Math.Max(Math.Min(baseAvatarInfo.GetCurHp(IsExtraLineup()) + count, 10000), 0), IsExtraLineup());
					result = true;
				}
			}
		}
		return result;
	}

	public bool CostNowPercentHp(double count)
	{
		bool result = false;
		if (BaseAvatars != null && AvatarData != null)
		{
			foreach (LineupAvatarInfo avatar in BaseAvatars)
			{
				BaseAvatarInfo baseAvatarInfo = ((avatar.SpecialAvatarId <= 0) ? ((BaseAvatarInfo)(AvatarData?.FormalAvatars?.Find((FormalAvatarInfo item) => item.BaseAvatarId == avatar.BaseAvatarId))) : ((BaseAvatarInfo)(AvatarData?.TrialAvatars?.Find((SpecialAvatarInfo item) => item.SpecialAvatarId == avatar.SpecialAvatarId))));
				if (baseAvatarInfo != null && baseAvatarInfo.CurrentHp > 0)
				{
					baseAvatarInfo.SetCurHp((int)Math.Max((double)baseAvatarInfo.GetCurHp(IsExtraLineup()) * (1.0 - count), 100.0), IsExtraLineup());
					result = true;
				}
			}
		}
		return result;
	}

	public bool AddPercentSp(int count)
	{
		bool result = false;
		if (BaseAvatars != null && AvatarData != null)
		{
			foreach (LineupAvatarInfo avatar in BaseAvatars)
			{
				BaseAvatarInfo baseAvatarInfo = ((avatar.SpecialAvatarId <= 0) ? ((BaseAvatarInfo)(AvatarData?.FormalAvatars?.Find((FormalAvatarInfo item) => item.BaseAvatarId == avatar.BaseAvatarId))) : ((BaseAvatarInfo)(AvatarData?.TrialAvatars?.Find((SpecialAvatarInfo item) => item.SpecialAvatarId == avatar.SpecialAvatarId))));
				if (baseAvatarInfo != null && baseAvatarInfo.CurrentHp > 0)
				{
					baseAvatarInfo.SetCurSp(Math.Min(baseAvatarInfo.GetCurSp(IsExtraLineup()) + count, 10000), IsExtraLineup());
					result = true;
				}
			}
		}
		return result;
	}

	public bool IsExtraLineup()
	{
		return LineupType != 0;
	}

	public March7thHoney.Proto.LineupInfo ToProto()
	{
		Mp = Math.Min(5 + (LineupData?.ExtraMpCount ?? 0), Mp);
		March7thHoney.Proto.LineupInfo info = new March7thHoney.Proto.LineupInfo
		{
			Name = Name,
			MaxMp = (uint)(5 + (LineupData?.ExtraMpCount ?? 0)),
			Mp = (uint)Mp,
			ExtraLineupType = ((LineupType != 13) ? ((ExtraLineupType)LineupType) : ExtraLineupType.LineupNone),
			Index = (uint)(LineupData?.Lineups?.Values.ToList().IndexOf(this)).GetValueOrDefault()
		};
		if (LineupType != 0)
		{
			info.Index = 0u;
		}
		if (BaseAvatars?.Find((LineupAvatarInfo item) => item.BaseAvatarId == LeaderAvatarId) != null)
		{
			info.LeaderSlot = (uint)BaseAvatars.IndexOf(BaseAvatars.Find((LineupAvatarInfo item) => item.BaseAvatarId == LeaderAvatarId));
		}
		else
		{
			info.LeaderSlot = 0u;
		}
		if (BaseAvatars != null)
		{
			foreach (LineupAvatarInfo avatar in BaseAvatars)
			{
				if (avatar == null)
				{
					continue;
				}
				if (avatar.AssistUid != 0)
				{
					AvatarData avatarData = DatabaseHelper.Instance?.GetInstance<AvatarData>(avatar.AssistUid);
					if (avatarData != null)
					{
						LineupAvatar lineupAvatar = avatarData.FormalAvatars?.Find((FormalAvatarInfo item) => item.BaseAvatarId == avatar.BaseAvatarId)?.ToLineupInfo(BaseAvatars.IndexOf(avatar), this, AvatarType.AvatarAssistType);
						if (lineupAvatar != null)
						{
							info.AvatarList.Add(lineupAvatar);
						}
					}
				}
				else if (avatar.SpecialAvatarId != 0)
				{
					LineupAvatar lineupAvatar2 = AvatarData?.TrialAvatars?.Find((SpecialAvatarInfo item) => item.SpecialAvatarId == avatar.SpecialAvatarId)?.ToLineupInfo(BaseAvatars.IndexOf(avatar), this, AvatarType.AvatarTrialType);
					if (lineupAvatar2 != null)
					{
						info.AvatarList.Add(lineupAvatar2);
					}
				}
				else
				{
					LineupAvatar lineupAvatar3 = AvatarData?.FormalAvatars?.Find((FormalAvatarInfo item) => item.BaseAvatarId == avatar.BaseAvatarId)?.ToLineupInfo(BaseAvatars.IndexOf(avatar), this);
					if (lineupAvatar3 != null)
					{
						info.AvatarList.Add(lineupAvatar3);
					}
				}
			}
		}
		int? num = DatabaseHelper.Instance.GetInstance<StoryLineData>(AvatarData.Uid)?.CurStoryLineId;
		if (num.HasValue && num != 0)
		{
			info.GameStoryLineId = (uint)num.Value;
			BaseAvatars?.ForEach(delegate(LineupAvatarInfo item)
			{
				if (item.SpecialAvatarId != 0)
				{
					info.StoryLineAvatarIdList.Add((uint)item.SpecialAvatarId);
				}
			});
		}
		return info;
	}
}
