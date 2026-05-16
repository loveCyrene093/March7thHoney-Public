using System.Collections.Generic;
using System.Linq;
using March7thHoney.Data.Custom;
using March7thHoney.Util;

namespace March7thHoney.Data.Excel;

[ResourceEntity("RogueTournBuffGroup.json")]
public class RogueTournBuffGroupExcel : BaseRogueBuffGroupExcel
{
	public int RogueBuffGroupID { get; set; }

	public List<int> RogueBuffDrop { get; set; } = new List<int>();

	public override void Loaded()
	{
		base.GroupId = RogueBuffGroupID;
		GameData.RogueBuffGroupData.Add(GetId(), this);
		LoadBuff();
	}

	public override void AfterAllDone()
	{
		LoadBuff();
	}

	public void LoadBuff()
	{
		if (base.IsLoaded)
		{
			return;
		}
		int num = 0;
		foreach (int buffId in RogueBuffDrop)
		{
			RogueTournBuffExcel rogueTournBuffExcel = (from x in GameData.RogueBuffData
				where x.Value is RogueTournBuffExcel
				select x.Value as RogueTournBuffExcel).ToList().ToList().FirstOrDefault((RogueTournBuffExcel x) => x.RogueBuffTag == buffId);
			BaseRogueBuffGroupExcel value;
			if (rogueTournBuffExcel != null)
			{
				base.BuffList.SafeAdd(rogueTournBuffExcel);
				num++;
			}
			else if (GameData.RogueBuffGroupData.TryGetValue(buffId, out value) && value is RogueTournBuffGroupExcel rogueTournBuffGroupExcel)
			{
				rogueTournBuffGroupExcel.LoadBuff();
				base.BuffList.SafeAddRange(rogueTournBuffGroupExcel.BuffList);
				num++;
			}
		}
		if (num == RogueBuffDrop.Count)
		{
			base.IsLoaded = true;
		}
	}
}
