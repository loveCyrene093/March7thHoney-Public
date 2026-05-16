using March7thHoney.Proto;

namespace March7thHoney.Database.Friend;

public class ChallengeAvatarInfoPb
{
	public uint Level { get; set; }

	public uint Index { get; set; }

	public uint Id { get; set; }

	public AvatarType AvatarType { get; set; } = AvatarType.AvatarFormalType;

	public ChallengeAvatarInfo ToProto()
	{
		return new ChallengeAvatarInfo
		{
			Level = Level,
			AvatarType = AvatarType,
			Id = Id,
			Index = Index
		};
	}
}
