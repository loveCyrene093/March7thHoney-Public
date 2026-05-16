using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpgradeAreaStatScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpgradeAreaStatScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChpVcGdyYWRlQXJlYVN0YXRTY1JzcC5wcm90bxoOU3RhdFR5cGUucHJvdG8i";
		buffer[1] = "ZwoUVXBncmFkZUFyZWFTdGF0U2NSc3ASDwoHYXJlYV9pZBgBIAEoDRIeCgtE";
		buffer[2] = "R0ZHTk1KQUxHShgEIAEoDjIJLlN0YXRUeXBlEg0KBWxldmVsGAwgASgNEg8K";
		buffer[3] = "B3JldGNvZGUYDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[4] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { StatTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpgradeAreaStatScRsp), UpgradeAreaStatScRsp.Parser, new string[4] { "AreaId", "DGFGNMJALGJ", "Level", "Retcode" }, null, null, null, null)
		}));
	}
}
