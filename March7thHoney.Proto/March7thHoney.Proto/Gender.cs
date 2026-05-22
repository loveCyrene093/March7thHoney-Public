using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum Gender
{
	[OriginalName("GenderNone")]
	None,
	[OriginalName("GenderMan")]
	Man,
	[OriginalName("GenderWoman")]
	Woman
}
