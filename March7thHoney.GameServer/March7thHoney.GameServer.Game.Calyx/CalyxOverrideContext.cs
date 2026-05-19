using System;
using System.Collections.Generic;
using System.Linq;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Data.Freesr;
using March7thHoney.GameServer.Game.Battle;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.Calyx;

public sealed class CalyxOverrideContext
{
	public CalyxOverrideContext(FreesrCalyxData data)
	{
		_003Cdata_003EP = data;
		base._002Ector();
	}

	public void Apply(BattleInstance battle, SceneBattleInfo proto)
	{
		if (_003Cdata_003EP.BattleConfig?.Blessings != null)
		{
			foreach (FreesrBlessing blessing in _003Cdata_003EP.BattleConfig.Blessings)
			{
				battle.Buffs.Add(new MazeBuff(blessing.Id, Math.Max(1, blessing.Level), -1)
				{
					WaveFlag = -1
				});
			}
		}
		if (_003Cdata_003EP.Avatars == null)
		{
			return;
		}
		foreach (BattleAvatar battleAvatar in proto.BattleAvatarList)
		{
			int aid = (int)battleAvatar.Id;
			FreesrCalyxAvatar freesrCalyxAvatar = null;
			if (_003Cdata_003EP.Avatars.TryGetValue(aid, out FreesrCalyxAvatar value))
			{
				freesrCalyxAvatar = value;
			}
			else if (freesrCalyxAvatar == null)
			{
				freesrCalyxAvatar = _003Cdata_003EP.Avatars.Values.FirstOrDefault((FreesrCalyxAvatar a) => a.AvatarId == aid);
			}
			if (freesrCalyxAvatar == null)
			{
				continue;
			}
			int? spMax;
			if (freesrCalyxAvatar.SpValue.HasValue)
			{
				spMax = freesrCalyxAvatar.SpMax;
				if (spMax.HasValue && spMax.GetValueOrDefault() > 0)
				{
					battleAvatar.SpBar = new SpBarInfo
					{
						CurSp = (uint)Math.Max(0, freesrCalyxAvatar.SpValue.Value * 100),
						MaxSp = (uint)(freesrCalyxAvatar.SpMax.Value * 100)
					};
				}
			}
			spMax = freesrCalyxAvatar.EnhancedId;
			if (spMax.HasValue)
			{
				int valueOrDefault = spMax.GetValueOrDefault();
				if (valueOrDefault > 0)
				{
					battleAvatar.EnhancedId = (uint)valueOrDefault;
				}
			}
		}
		HashSet<int> hashSet = proto.BattleAvatarList.Select((BattleAvatar b) => (int)b.Id).ToHashSet();
		foreach (var (num2, freesrCalyxAvatar3) in _003Cdata_003EP.Avatars)
		{
			if (freesrCalyxAvatar3.Techniques == null || freesrCalyxAvatar3.Techniques.Count == 0)
			{
				continue;
			}
			int num3 = ((freesrCalyxAvatar3.AvatarId > 0) ? freesrCalyxAvatar3.AvatarId : num2);
			if (!hashSet.Contains(num3))
			{
				continue;
			}
			foreach (int buffId in freesrCalyxAvatar3.Techniques)
			{
				if (buffId > 0)
				{
					int buffLevel = (from x in GameData.MazeBuffData.Values
						where x.ID == buffId
						select x.Lv).DefaultIfEmpty(1).Max();
					MazeBuff mazeBuff = new MazeBuff(buffId, buffLevel, -1)
					{
						OwnerAvatarId = num3,
						WaveFlag = -1
					};
					mazeBuff.DynamicValues["SkillIndex"] = 0f;
					battle.Buffs.Add(mazeBuff);
				}
			}
		}
	}
}
