using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum HeartDialUnlockStatus
{
	[OriginalName("HEART_DIAL_UNLOCK_STATUS_LOCK")]
	Lock,
	[OriginalName("HEART_DIAL_UNLOCK_STATUS_UNLOCK_SINGLE")]
	UnlockSingle,
	[OriginalName("HEART_DIAL_UNLOCK_STATUS_UNLOCK_ALL")]
	UnlockAll
}
