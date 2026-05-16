using System.Collections.Generic;
using System.Linq;
using March7thHoney.Data.Custom;
using March7thHoney.Util;
using Newtonsoft.Json;

namespace March7thHoney.Data.Excel;

[ResourceEntity("RogueBuffGroup.json")]
public class RogueBuffGroupExcel : BaseRogueBuffGroupExcel
{
	[JsonProperty("IDLBMIHBAPB")]
	public int GroupID { get; set; }

	[JsonProperty("GNGDPDOMDFH")]
	public List<int> BuffTagList { get; set; } = new List<int>();

	public override int GetId()
	{
		return GroupID;
	}

	public override void Loaded()
	{
		GameData.RogueBuffGroupData[GetId()] = this;
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
		foreach (int buffId in BuffTagList)
		{
			RogueBuffExcel rogueBuffExcel = (from x in GameData.RogueBuffData
				where x.Value is RogueBuffExcel
				select x.Value as RogueBuffExcel).ToList().ToList().FirstOrDefault((RogueBuffExcel x) => x.RogueBuffTag == buffId);
			BaseRogueBuffGroupExcel value;
			if (rogueBuffExcel != null)
			{
				base.BuffList.SafeAdd(rogueBuffExcel);
				num++;
			}
			else if (GameData.RogueBuffGroupData.TryGetValue(buffId, out value) && value is RogueBuffGroupExcel rogueBuffGroupExcel)
			{
				rogueBuffGroupExcel.LoadBuff();
				base.BuffList.SafeAddRange(rogueBuffGroupExcel.BuffList);
				num++;
			}
		}
		if (num == BuffTagList.Count)
		{
			base.IsLoaded = true;
		}
	}
}
