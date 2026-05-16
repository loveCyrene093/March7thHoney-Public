using System.Collections.Generic;
using March7thHoney.Enums.Rogue;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Config.Rogue;

public class RogueNPCConfigInfo
{
	[JsonConverter(typeof(StringEnumConverter))]
	public RogueDialogueTypeEnum DialogueType { get; set; }

	public List<RogueNPCDialogueConfigInfo> DialogueList { get; set; } = new List<RogueNPCDialogueConfigInfo>();

	public void Loaded()
	{
		if (DialogueList.Count == 0)
		{
			return;
		}
		foreach (RogueNPCDialogueConfigInfo dialogue in DialogueList)
		{
			dialogue.Loaded();
		}
	}
}
