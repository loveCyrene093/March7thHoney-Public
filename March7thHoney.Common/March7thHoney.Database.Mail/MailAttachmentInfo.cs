using System.Collections.Generic;
using System.Linq;
using March7thHoney.Database.Inventory;
using March7thHoney.Proto;

namespace March7thHoney.Database.Mail;

public class MailAttachmentInfo
{
	public List<ItemData> Items { get; set; } = new List<ItemData>();

	public ItemList ToProto()
	{
		return new ItemList
		{
			ItemList_ = { (IEnumerable<Item>)Items.Select((ItemData x) => x.ToProto()).ToList() }
		};
	}
}
