using System.Collections.Generic;
using March7thHoney.Database.Lineup;
using March7thHoney.Proto;

namespace March7thHoney.Database.Avatar;

public abstract class BaseAvatarInfo
{
	public int BaseAvatarId { get; set; }

	public int AvatarId { get; set; }

	public int Promotion { get; set; }

	public int Level { get; set; }

	public int CurrentHp { get; set; } = 10000;

	public int CurrentSp { get; set; }

	public int ExtraLineupHp { get; set; } = 10000;

	public int ExtraLineupSp { get; set; }

	public Dictionary<int, PathInfo> PathInfos { get; set; } = new Dictionary<int, PathInfo>();

	public void SetCurHp(int value, bool isExtraLineup)
	{
		if (isExtraLineup)
		{
			ExtraLineupHp = value;
		}
		else
		{
			CurrentHp = value;
		}
	}

	public void SetCurSp(int value, bool isExtraLineup)
	{
		if (isExtraLineup)
		{
			ExtraLineupSp = value;
		}
		else
		{
			CurrentSp = value;
		}
	}

	public int GetCurHp(bool isExtraLineup)
	{
		if (!isExtraLineup)
		{
			return CurrentHp;
		}
		return ExtraLineupHp;
	}

	public int GetCurSp(bool isExtraLineup)
	{
		if (!isExtraLineup)
		{
			return CurrentSp;
		}
		return ExtraLineupSp;
	}

	public PathInfo GetCurPathInfo()
	{
		if (PathInfos.TryGetValue(AvatarId, out PathInfo value))
		{
			return value;
		}
		PathInfos.Add(AvatarId, new PathInfo(AvatarId));
		return PathInfos[AvatarId];
	}

	public PathInfo? GetPathInfo(int pathId)
	{
		if (PathInfos.TryGetValue(pathId, out PathInfo value))
		{
			return value;
		}
		return null;
	}

	public abstract BattleAvatar ToBattleProto(PlayerDataCollection collection, AvatarType avatarType = AvatarType.AvatarFormalType);

	public abstract LineupAvatar ToLineupInfo(int slot, March7thHoney.Database.Lineup.LineupInfo info, AvatarType avatarType = AvatarType.AvatarFormalType);

	public abstract March7thHoney.Proto.Avatar ToProto();
}
