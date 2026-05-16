using System.Collections.Generic;

namespace March7thHoney.Data.Custom;

public class RogueDialogueEventOptionData
{
	public uint OptionId { get; set; }

	public RogueDialogueEventOptionBindData DisplayValueBind { get; set; } = new RogueDialogueEventOptionBindData();

	public List<RogueDialogueEventActionData> SelectActions { get; set; } = new List<RogueDialogueEventActionData>();

	public List<RogueDialogueEventDialogueActionData> DynamicActions { get; set; } = new List<RogueDialogueEventDialogueActionData>();

	public List<RogueDialogueEventConditionData> ValidConditions { get; set; } = new List<RogueDialogueEventConditionData>();
}
