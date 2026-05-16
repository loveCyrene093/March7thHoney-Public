using System.Collections.Generic;
using System.Linq;
using SqlSugar;

namespace March7thHoney.Database.Friend;

[SugarTable("friend_record_data")]
public class FriendRecordData : BaseDatabaseDataHelper
{
	[SugarColumn(IsJson = true)]
	public List<FriendDevelopmentInfoPb> DevelopmentInfos { get; set; } = new List<FriendDevelopmentInfoPb>();

	[SugarColumn(IsJson = true)]
	public Dictionary<uint, ChallengeGroupStatisticsPb> ChallengeGroupStatistics { get; set; } = new Dictionary<uint, ChallengeGroupStatisticsPb>();

	public uint NextRecordId { get; set; }

	public void AddAndRemoveOld(FriendDevelopmentInfoPb info)
	{
		FriendDevelopmentInfoPb[] array = DevelopmentInfos.Where((FriendDevelopmentInfoPb x) => x.DevelopmentType == info.DevelopmentType).ToArray();
		foreach (FriendDevelopmentInfoPb friendDevelopmentInfoPb in array)
		{
			if (friendDevelopmentInfoPb.Params.SequenceEqual(info.Params))
			{
				DevelopmentInfos.Remove(friendDevelopmentInfoPb);
			}
		}
		DevelopmentInfos.Add(info);
	}
}
