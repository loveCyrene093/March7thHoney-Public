using System.Collections.Generic;

namespace March7thHoney.Data.Config;

public class DialogueTaskInfo
{
	public List<DialogueTaskInfo> TaskList { get; set; } = new List<DialogueTaskInfo>();

	public List<DialogueTaskInfo> OptionList { get; set; } = new List<DialogueTaskInfo>();

	public int DialogueEventID { get; set; }
}
