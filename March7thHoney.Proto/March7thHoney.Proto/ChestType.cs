using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum ChestType
{
	[OriginalName("MAP_INFO_CHEST_TYPE_NONE")]
	MapInfoChestTypeNone = 0,
	[OriginalName("MAP_INFO_CHEST_TYPE_NORMAL")]
	MapInfoChestTypeNormal = 101,
	[OriginalName("MAP_INFO_CHEST_TYPE_CHALLENGE")]
	MapInfoChestTypeChallenge = 102,
	[OriginalName("MAP_INFO_CHEST_TYPE_PUZZLE")]
	MapInfoChestTypePuzzle = 104
}
