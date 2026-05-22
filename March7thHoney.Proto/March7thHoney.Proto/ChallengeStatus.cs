using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum ChallengeStatus
{
	[OriginalName("CHALLENGE_UNKNOWN")]
	ChallengeUnknown,
	[OriginalName("CHALLENGE_DOING")]
	ChallengeDoing,
	[OriginalName("CHALLENGE_FINISH")]
	ChallengeFinish,
	[OriginalName("CHALLENGE_FAILED")]
	ChallengeFailed
}
