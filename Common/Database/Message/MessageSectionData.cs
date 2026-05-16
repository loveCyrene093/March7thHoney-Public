using System.Collections.Generic;
using March7thHoney.Proto;

namespace March7thHoney.Database.Message;

public class MessageSectionData
{
	public int SectionId { get; set; }

	public MessageSectionStatus Status { get; set; }

	public List<MessageItemData> Items { get; set; } = new List<MessageItemData>();

	public List<int> ToChooseItemId { get; set; } = new List<int>();
}
