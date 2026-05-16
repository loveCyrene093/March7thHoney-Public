using System.Collections.Generic;
using March7thHoney.Enums.Rogue;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Config;

public class RogueBlockCreateGroup
{
	public int BlockCreateID { get; set; }

	public int GroupID { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public RogueDLCBlockTypeEnum BlockType { get; set; }

	public List<RogueDLCBlockWeight> BlockCreatNumList { get; set; } = new List<RogueDLCBlockWeight>();

	public List<RogueDLCMarkType> MarkCreateRandomList { get; set; } = new List<RogueDLCMarkType>();
}
