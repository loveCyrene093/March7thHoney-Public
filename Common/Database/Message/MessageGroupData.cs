using System.Collections.Generic;
using March7thHoney.Proto;

namespace March7thHoney.Database.Message;

public class MessageGroupData
{
	public int GroupId { get; set; }

	public List<MessageSectionData> Sections { get; set; } = new List<MessageSectionData>();

	public MessageGroupStatus Status { get; set; }

	public long RefreshTime { get; set; }

	public int CurrentSectionId { get; set; }
}
