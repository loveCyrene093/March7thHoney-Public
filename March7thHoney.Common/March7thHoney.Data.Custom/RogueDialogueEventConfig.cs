using System.Collections.Generic;
using March7thHoney.Enums.Rogue;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Custom;

public class RogueDialogueEventConfig
{
	public uint NpcId { get; set; }

	public uint Progress { get; set; }

	public int Weight { get; set; }

	[JsonProperty(ItemConverterParameters = new object[] { typeof(StringEnumConverter) })]
	public List<RogueSubModeEnum> AllowRogueType { get; set; } = new List<RogueSubModeEnum>();

	public List<string> AllowRoomType { get; set; } = new List<string>();

	public List<RogueDialogueEventActionData> EnterActions { get; set; } = new List<RogueDialogueEventActionData>();

	public List<RogueDialogueEventOptionData> Options { get; set; } = new List<RogueDialogueEventOptionData>();
}
