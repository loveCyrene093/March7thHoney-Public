using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum HeartDialEmotionType
{
	[OriginalName("HEART_DIAL_EMOTION_TYPE_PEACE")]
	Peace,
	[OriginalName("HEART_DIAL_EMOTION_TYPE_ANGER")]
	Anger,
	[OriginalName("HEART_DIAL_EMOTION_TYPE_HAPPY")]
	Happy,
	[OriginalName("HEART_DIAL_EMOTION_TYPE_SAD")]
	Sad
}
