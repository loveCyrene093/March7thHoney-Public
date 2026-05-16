using System.Collections.Generic;

namespace March7thHoney.Data.Custom;

public class RogueDialogueEventDialogueActionData
{
	public uint DynamicId { get; set; }

	public List<RogueDialogueEventActionData> SelectActions { get; set; } = new List<RogueDialogueEventActionData>();
}
