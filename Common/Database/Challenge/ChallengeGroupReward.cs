using March7thHoney.Proto;

namespace March7thHoney.Database.Challenge;

public class ChallengeGroupReward(int uid, int groupId)
{
	public int OwnerUid = uid;

	public int GroupId { get; set; } = groupId;

	public long TakenStars { get; set; }

	public bool HasTakenReward(int starCount)
	{
		return (TakenStars & (1L << starCount)) != 0;
	}

	public void SetTakenReward(int starCount)
	{
		TakenStars |= 1L << starCount;
	}

	public ChallengeGroup ToProto()
	{
		return new ChallengeGroup
		{
			GroupId = (uint)GroupId,
			TakenStarsCountReward = (ulong)TakenStars
		};
	}
}
