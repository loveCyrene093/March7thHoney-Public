using System.Collections.Generic;
using March7thHoney.Enums.TournRogue;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Custom;

public class RogueTournRoomConfig
{
	public int EntranceId { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public RogueTournRoomTypeEnum RoomType { get; set; }

	public int AnchorGroup { get; set; }

	public int AnchorId { get; set; }

	public uint SingleRoomId { get; set; }

	public uint DoubleRoomId { get; set; }

	public uint TripleRoomId { get; set; }

	public List<int> DefaultLoadBasicGroup { get; set; } = new List<int>();

	public List<int> DefaultLoadGroup { get; set; } = new List<int>();

	public List<int> SubMonsterGroup { get; set; } = new List<int>();

	public RogueTournRoomConfig Clone(RogueTournRoomTypeEnum type)
	{
		return new RogueTournRoomConfig
		{
			RoomType = type,
			AnchorGroup = AnchorGroup,
			AnchorId = AnchorId,
			DefaultLoadBasicGroup = DefaultLoadBasicGroup,
			DefaultLoadGroup = DefaultLoadGroup,
			EntranceId = EntranceId,
			TripleRoomId = TripleRoomId,
			SingleRoomId = SingleRoomId,
			DoubleRoomId = DoubleRoomId,
			SubMonsterGroup = SubMonsterGroup
		};
	}
}
