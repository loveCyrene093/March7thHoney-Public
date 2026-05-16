using System.Collections.Generic;

namespace March7thHoney.Data.Excel;

[ResourceEntity("MessageGroupConfig.json")]
public class MessageGroupConfigExcel : ExcelResource
{
	public int ID { get; set; }

	public int MessageContactsID { get; set; }

	public List<int> MessageSectionIDList { get; set; } = new List<int>();

	public override int GetId()
	{
		return ID;
	}

	public override void Loaded()
	{
		GameData.MessageGroupConfigData.Add(ID, this);
	}

	public override void AfterAllDone()
	{
		GameData.MessageContactsConfigData[MessageContactsID].Groups.Add(this);
		MessageSectionIDList.ForEach(delegate(int m)
		{
			GameData.MessageSectionConfigData.TryGetValue(m, out MessageSectionConfigExcel value);
			if (value != null)
			{
				value.GroupID = ID;
			}
		});
	}
}
