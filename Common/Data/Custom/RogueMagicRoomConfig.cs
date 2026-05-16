using System.Collections.Generic;
using March7thHoney.Enums.Rogue;
using March7thHoney.Enums.RogueMagic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Custom;

public class RogueMagicRoomConfig
{
	public int EntranceId { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public RogueMagicRoomTypeEnum RoomType { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public RogueAdventureGameplayTypeEnum AdventureType { get; set; }

	public int AnchorGroup { get; set; }

	public int AnchorId { get; set; }

	public List<int> DefaultLoadBasicGroup { get; set; } = new List<int>();

	public List<int> DefaultLoadGroup { get; set; } = new List<int>();

	public List<int> SubMonsterGroup { get; set; } = new List<int>();

	public RogueMagicRoomConfig Clone(RogueMagicRoomTypeEnum type)
	{
		return new RogueMagicRoomConfig
		{
			RoomType = type,
			AnchorGroup = AnchorGroup,
			AnchorId = AnchorId,
			DefaultLoadBasicGroup = DefaultLoadBasicGroup,
			DefaultLoadGroup = DefaultLoadGroup,
			EntranceId = EntranceId,
			SubMonsterGroup = SubMonsterGroup,
			AdventureType = AdventureType
		};
	}
}
