using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum MissionStatus
{
	[OriginalName("MISSION_NONE")]
	MissionNone,
	[OriginalName("MISSION_DOING")]
	MissionDoing,
	[OriginalName("MISSION_FINISH")]
	MissionFinish,
	[OriginalName("MISSION_PREPARED")]
	MissionPrepared
}
