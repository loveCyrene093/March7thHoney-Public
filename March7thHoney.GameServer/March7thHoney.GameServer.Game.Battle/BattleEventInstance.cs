using System;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.Battle;

public class BattleEventInstance
{
	public int BattleEventId { get; set; }

	public int CurSp { get; set; }

	public int MaxSp { get; set; }

	public BattleEventInstance(int battleEventId, int curSp, int maxSp = 10000)
	{
		BattleEventId = battleEventId;
		CurSp = curSp;
		MaxSp = maxSp;
		base._002Ector();
	}

	public void AddSp(int sp)
	{
		CurSp = Math.Min(CurSp + sp, MaxSp);
	}

	public void SubSp(int sp)
	{
		CurSp = Math.Max(CurSp - sp, 0);
	}

	public BattleEventBattleInfo ToProto()
	{
		return new BattleEventBattleInfo
		{
			BattleEventId = (uint)BattleEventId,
			Status = new BattleEventProperty
			{
				SpBar = new SpBarInfo
				{
					CurSp = (uint)CurSp,
					MaxSp = (uint)MaxSp
				}
			}
		};
	}
}
