using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IHBGAHNNEKIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IHBGAHNNEKIReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFJSEJHQUhOTkVLSS5wcm90bxoRQ0lNQ0RDQk5OS0oucHJvdG8i1QEKC0lI";
		buffer[1] = "QkdBSE5ORUtJEg8KB3Jvb21faWQYASABKAQSEwoLTU1MS0ZKSUFLS0gYAiAB";
		buffer[2] = "KA0SEwoLTkRLQUlBRlBOQkoYAyABKA0SEwoLR0xOTUVQTktITE4YBCABKA0S";
		buffer[3] = "EwoLRUVKQ0lPR0hGQ0sYBSABKA0SIQoLRktFSE9HTUdMSkYYBiABKAsyDC5D";
		buffer[4] = "SU1DRENCTk5LShIhCgtITURCQUdFTEVJRRgHIAEoCzIMLkNJTUNEQ0JOTktK";
		buffer[5] = "EhsKE21vbnN0ZXJfYmF0dGxlX3R5cGUYCCABKA1CFqoCE01hcmNoN3RoSG9u";
		buffer[6] = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { CIMCDCBNNKJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IHBGAHNNEKI), IHBGAHNNEKI.Parser, new string[8] { "RoomId", "MMLKFJIAKKH", "NDKAIAFPNBJ", "GLNMEPNKHLN", "EEJCIOGHFCK", "FKEHOGMGLJF", "HMDBAGELEIE", "MonsterBattleType" }, null, null, null, null)
		}));
	}
}
