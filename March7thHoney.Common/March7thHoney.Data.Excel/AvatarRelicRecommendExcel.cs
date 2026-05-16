using System.Collections.Generic;

namespace March7thHoney.Data.Excel;

[ResourceEntity("AvatarRelicRecommend.json")]
public class AvatarRelicRecommendExcel : ExcelResource
{
	public uint AvatarID { get; set; }

	public List<uint> Set4IDList { get; set; } = new List<uint>();

	public List<uint> Set2IDList { get; set; } = new List<uint>();

	public List<uint> ScoreRankList { get; set; } = new List<uint>();

	public List<AvatarRelicRecommendMainAffix> PropertyList { get; set; } = new List<AvatarRelicRecommendMainAffix>();

	public override int GetId()
	{
		return (int)AvatarID;
	}

	public override void Loaded()
	{
		GameData.AvatarRelicRecommendData.TryAdd(AvatarID, this);
	}
}
