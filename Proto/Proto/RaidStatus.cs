using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum RaidStatus
{
	[OriginalName("RAID_STATUS_NONE")]
	None,
	[OriginalName("RAID_STATUS_DOING")]
	Doing,
	[OriginalName("RAID_STATUS_FINISH")]
	Finish,
	[OriginalName("RAID_STATUS_FAILED")]
	Failed
}
