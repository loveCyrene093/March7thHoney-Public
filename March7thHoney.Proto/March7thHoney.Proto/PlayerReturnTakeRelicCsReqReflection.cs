using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerReturnTakeRelicCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerReturnTakeRelicCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBQbGF5ZXJSZXR1cm5UYWtlUmVsaWNDc1JlcS5wcm90byIvChpQbGF5ZXJS" + "ZXR1cm5UYWtlUmVsaWNDc1JlcRIRCglhdmF0YXJfaWQYBiABKA1CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerReturnTakeRelicCsReq), PlayerReturnTakeRelicCsReq.Parser, new string[1] { "AvatarId" }, null, null, null, null)
		}));
	}
}
