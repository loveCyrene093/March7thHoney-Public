using System.Collections.Generic;

namespace March7thHoney.Database.Friend;

public class FriendChatHistory
{
	public List<FriendChatData> MessageList { get; set; } = new List<FriendChatData>();
}
