using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LeaveMapRotationRegionScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LeaveMapRotationRegionScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiFMZWF2ZU1hcFJvdGF0aW9uUmVnaW9uU2NSc3AucHJvdG8aEE1vdGlvbklu";
		buffer[1] = "Zm8ucHJvdG8iZwobTGVhdmVNYXBSb3RhdGlvblJlZ2lvblNjUnNwEg8KB3Jl";
		buffer[2] = "dGNvZGUYAyABKA0SGgoSY2xpZW50X3Bvc192ZXJzaW9uGAggASgNEhsKBm1v";
		buffer[3] = "dGlvbhgKIAEoCzILLk1vdGlvbkluZm9CFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		buffer[4] = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MotionInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LeaveMapRotationRegionScRsp), LeaveMapRotationRegionScRsp.Parser, new string[3] { "Retcode", "ClientPosVersion", "Motion" }, null, null, null, null)
		}));
	}
}
