using System.Collections.Generic;
using March7thHoney.Enums.Rogue;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Config;

public class RogueChestGridItem
{
	public int PosX { get; set; }

	public int PosY { get; set; }

	[JsonProperty(ItemConverterType = typeof(StringEnumConverter))]
	public List<RogueDLCBlockTypeEnum> BlockTypeList { get; set; } = new List<RogueDLCBlockTypeEnum>();

	public bool ExportToJson { get; set; }
}
