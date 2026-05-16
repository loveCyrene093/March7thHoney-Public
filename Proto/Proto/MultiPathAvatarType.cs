using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum MultiPathAvatarType
{
	[OriginalName("MultiPathAvatarTypeNone")]
	None = 0,
	[OriginalName("Mar_7thKnightType")]
	Mar7ThKnightType = 1001,
	[OriginalName("Mar_7thRogueType")]
	Mar7ThRogueType = 1224,
	[OriginalName("BoyWarriorType")]
	BoyWarriorType = 8001,
	[OriginalName("GirlWarriorType")]
	GirlWarriorType = 8002,
	[OriginalName("BoyKnightType")]
	BoyKnightType = 8003,
	[OriginalName("GirlKnightType")]
	GirlKnightType = 8004,
	[OriginalName("BoyShamanType")]
	BoyShamanType = 8005,
	[OriginalName("GirlShamanType")]
	GirlShamanType = 8006,
	[OriginalName("BoyMemoryType")]
	BoyMemoryType = 8007,
	[OriginalName("GirlMemoryType")]
	GirlMemoryType = 8008,
	[OriginalName("BoyElationType")]
	BoyElationType = 8009,
	[OriginalName("GirlElationType")]
	GirlElationType = 8010
}
