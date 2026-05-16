using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ResetMapRotationRegionScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ResetMapRotationRegionScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiFSZXNldE1hcFJvdGF0aW9uUmVnaW9uU2NSc3AucHJvdG8aEE1vdGlvbklu";
		buffer[1] = "Zm8ucHJvdG8iZwobUmVzZXRNYXBSb3RhdGlvblJlZ2lvblNjUnNwEhsKBm1v";
		buffer[2] = "dGlvbhgCIAEoCzILLk1vdGlvbkluZm8SGgoSY2xpZW50X3Bvc192ZXJzaW9u";
		buffer[3] = "GAQgASgNEg8KB3JldGNvZGUYBiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		buffer[4] = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MotionInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ResetMapRotationRegionScRsp), ResetMapRotationRegionScRsp.Parser, new string[3] { "Motion", "ClientPosVersion", "Retcode" }, null, null, null, null)
		}));
	}
}
