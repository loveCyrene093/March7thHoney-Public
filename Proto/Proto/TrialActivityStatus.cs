using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum TrialActivityStatus
{
	[OriginalName("TRIAL_ACTIVITY_STATUS_NONE")]
	None,
	[OriginalName("TRIAL_ACTIVITY_STATUS_FINISH")]
	Finish
}
