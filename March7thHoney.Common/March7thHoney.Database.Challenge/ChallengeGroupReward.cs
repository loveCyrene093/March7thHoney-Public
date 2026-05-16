using March7thHoney.Proto;

namespace March7thHoney.Database.Challenge;

public class ChallengeGroupReward
{
	public int OwnerUid;

	public int GroupId { get; set; }

	public long TakenStars { get; set; }

	public ChallengeGroupReward(int uid, int groupId)
	{
		OwnerUid = uid;
		GroupId = groupId;
		base._002Ector();
	}

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
