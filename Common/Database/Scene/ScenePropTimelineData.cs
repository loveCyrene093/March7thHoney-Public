using Google.Protobuf;
using March7thHoney.Proto;

namespace March7thHoney.Database.Scene;

public class ScenePropTimelineData
{
	public bool BoolValue { get; set; }

	public string ByteValue { get; set; } = "";

	public PropTimelineInfo ToProto()
	{
		return new PropTimelineInfo
		{
			TimelineBoolValue = BoolValue,
			TimelineByteValue = ByteString.FromBase64(ByteValue)
		};
	}
}
