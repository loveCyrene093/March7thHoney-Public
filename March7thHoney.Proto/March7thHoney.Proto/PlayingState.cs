using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum PlayingState
{
	[OriginalName("PLAYING_STATE_NONE")]
	None,
	[OriginalName("PLAYING_ROGUE_COSMOS")]
	PlayingRogueCosmos,
	[OriginalName("PLAYING_ROGUE_CHESS")]
	PlayingRogueChess,
	[OriginalName("PLAYING_ROGUE_CHESS_NOUS")]
	PlayingRogueChessNous,
	[OriginalName("PLAYING_CHALLENGE_MEMORY")]
	PlayingChallengeMemory,
	[OriginalName("PLAYING_CHALLENGE_STORY")]
	PlayingChallengeStory,
	[OriginalName("PLAYING_CHALLENGE_BOSS")]
	PlayingChallengeBoss,
	[OriginalName("PLAYING_ROGUE_TOURN")]
	PlayingRogueTourn,
	[OriginalName("PLAYING_ROGUE_MAGIC")]
	PlayingRogueMagic,
	[OriginalName("PLAYING_CHALLENGE_PEAK")]
	PlayingChallengePeak,
	[OriginalName("LGGELNENDAO_OKGAHGBKFDJ")]
	LggelnendaoOkgahgbkfdj
}
