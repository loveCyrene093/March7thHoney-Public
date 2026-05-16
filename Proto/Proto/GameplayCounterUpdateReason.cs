using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum GameplayCounterUpdateReason
{
	[OriginalName("GAMEPLAY_COUNTER_UPDATE_REASON_NONE")]
	None,
	[OriginalName("GAMEPLAY_COUNTER_UPDATE_REASON_ACTIVATE")]
	Activate,
	[OriginalName("GAMEPLAY_COUNTER_UPDATE_REASON_DEACTIVATE")]
	Deactivate,
	[OriginalName("GAMEPLAY_COUNTER_UPDATE_REASON_CHANGE")]
	Change
}
