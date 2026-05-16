using March7thHoney.Proto;

namespace March7thHoney.Database.Player;

public class PlayerHeadFrameInfo
{
	public long HeadFrameExpireTime { get; set; }

	public uint HeadFrameId { get; set; }

	public HeadFrameInfo ToProto()
	{
		return new HeadFrameInfo
		{
			HeadFrameExpireTime = HeadFrameExpireTime,
			HeadFrameItemId = HeadFrameId
		};
	}
}
