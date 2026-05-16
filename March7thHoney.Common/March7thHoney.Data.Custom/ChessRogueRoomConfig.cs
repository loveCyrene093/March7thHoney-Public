using System.Collections.Generic;
using March7thHoney.Enums.Rogue;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Custom;

public class ChessRogueRoomConfig
{
	public int EntranceId { get; set; }

	public int RoomPrefix { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public RogueDLCBlockTypeEnum BlockType { get; set; }

	public int AnchorGroup { get; set; }

	public int AnchorId { get; set; }

	public List<int> DefaultLoadBasicGroup { get; set; } = new List<int>();

	public List<int> DefaultLoadGroup { get; set; } = new List<int>();

	public List<int> DoubleEventLoadGroup { get; set; } = new List<int>();

	public List<int> SelectEventLoadGroup { get; set; } = new List<int>();

	public List<int> SubMonsterGroup { get; set; } = new List<int>();
}
