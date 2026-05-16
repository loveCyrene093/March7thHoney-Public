using System.Collections.Generic;
using March7thHoney.Util;

namespace March7thHoney.Database.Challenge;

public class ChallengeInstanceData
{
	public Position StartPos { get; set; } = new Position();

	public Position StartRot { get; set; } = new Position();

	public int ChallengeId { get; set; }

	public int CurrentStage { get; set; }

	public int CurrentExtraLineup { get; set; }

	public int Status { get; set; }

	public bool HasAvatarDied { get; set; }

	public int SavedMp { get; set; }

	public int RoundsLeft { get; set; }

	public int Stars { get; set; }

	public int ScoreStage1 { get; set; }

	public int ScoreStage2 { get; set; }

	public List<int> StoryBuffs { get; set; } = new List<int>();

	public List<int> BossBuffs { get; set; } = new List<int>();
}
