using System.Collections.Generic;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.Database.Friend;

public class FriendDevelopmentInfoPb
{
	public DevelopmentType DevelopmentType { get; set; }

	public long Time { get; set; } = Extensions.GetUnixSec();

	public Dictionary<string, uint> Params { get; set; } = new Dictionary<string, uint>();

	public OHNPAFLKHNA ToProto()
	{
		return new OHNPAFLKHNA
		{
			Time = Time,
			FKGPLPGKDHN = DevelopmentType,
			AvatarId = Params.GetValueOrDefault("AvatarId", 0u)
		};
	}
}
