namespace March7thHoney.Database.Friend;

public class FriendChatData
{
	public long SendTime { get; set; }

	public string Message { get; set; } = "";

	public int ExtraId { get; set; }

	public int SendUid { get; set; }

	public int ReceiveUid { get; set; }
}
