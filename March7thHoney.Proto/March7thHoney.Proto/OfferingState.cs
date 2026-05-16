using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum OfferingState
{
	[OriginalName("OFFERING_STATE_NONE")]
	None,
	[OriginalName("OFFERING_STATE_LOCK")]
	Lock,
	[OriginalName("OFFERING_STATE_OPEN")]
	Open
}
