using System.Collections.Generic;
using SqlSugar;

namespace March7thHoney.Database.Friend;

[SugarTable("Friend")]
public class FriendData : BaseDatabaseDataHelper
{
	[SugarColumn(IsJson = true, ColumnDataType = "TEXT")]
	public Dictionary<int, FriendDetailData> FriendDetailList { get; set; } = new Dictionary<int, FriendDetailData>();

	[SugarColumn(IsJson = true, ColumnDataType = "TEXT")]
	public List<int> FriendList { get; set; } = new List<int>();

	[SugarColumn(IsJson = true)]
	public List<int> BlackList { get; set; } = new List<int>();

	[SugarColumn(IsJson = true)]
	public List<int> SendApplyList { get; set; } = new List<int>();

	[SugarColumn(IsJson = true)]
	public List<int> ReceiveApplyList { get; set; } = new List<int>();

	[SugarColumn(IsJson = true, ColumnDataType = "TEXT")]
	public Dictionary<int, FriendChatHistory> ChatHistory { get; set; } = new Dictionary<int, FriendChatHistory>();
}
