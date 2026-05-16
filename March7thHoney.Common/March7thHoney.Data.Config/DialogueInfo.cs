using System.Collections.Generic;
using Newtonsoft.Json;

namespace March7thHoney.Data.Config;

public class DialogueInfo
{
	public List<DialogueTaskInfo> OnInitSequece { get; set; } = new List<DialogueTaskInfo>();

	public List<DialogueTaskInfo> OnStartSequece { get; set; } = new List<DialogueTaskInfo>();

	[JsonIgnore]
	public List<int> DialogueIds { get; set; } = new List<int>();

	public void Loaded()
	{
		foreach (DialogueTaskInfo item in OnInitSequece)
		{
			foreach (DialogueTaskInfo task in item.TaskList)
			{
				foreach (DialogueTaskInfo option in task.OptionList)
				{
					DialogueIds.Add(option.DialogueEventID);
				}
			}
		}
		foreach (DialogueTaskInfo item2 in OnStartSequece)
		{
			foreach (DialogueTaskInfo task2 in item2.TaskList)
			{
				foreach (DialogueTaskInfo option2 in task2.OptionList)
				{
					DialogueIds.Add(option2.DialogueEventID);
				}
			}
		}
	}
}
