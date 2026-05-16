using System;
using March7thHoney.Proto;

namespace March7thHoney.Database.Challenge;

public class ChallengeHistoryData(int uid, int challengeId)
{
	public int OwnerId { get; set; } = uid;

	public int ChallengeId { get; set; } = challengeId;

	public int GroupId { get; set; }

	public int TakenReward { get; set; }

	public int Stars { get; set; }

	public int Score { get; set; }

	public void SetStars(int stars)
	{
		Stars = Math.Max(Stars, stars);
	}

	public int GetTotalStars()
	{
		int num = 0;
		for (int i = 0; i < 3; i++)
		{
			num += (((Stars & (1 << i)) != 0) ? 1 : 0);
		}
		return num;
	}

	public March7thHoney.Proto.Challenge ToProto()
	{
		return new March7thHoney.Proto.Challenge
		{
			ChallengeId = (uint)ChallengeId,
			TakenReward = (uint)TakenReward,
			ScoreId = (uint)Score,
			Star = (uint)Stars
		};
	}
}
