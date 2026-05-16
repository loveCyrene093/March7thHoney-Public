using Google.Protobuf.Reflection;

namespace March7thHoney.Proto.ServerSide;

public enum ChallengeLineupTypePb
{
	[OriginalName("ChallengeLineupTypePb_None")]
	None = 0,
	[OriginalName("ChallengeLineupTypePb_Challenge1")]
	Challenge1 = 1,
	[OriginalName("ChallengeLineupTypePb_Challenge2")]
	Challenge2 = 3,
	[OriginalName("ChallengeLineupTypePb_Challenge3")]
	Challenge3 = 4
}
