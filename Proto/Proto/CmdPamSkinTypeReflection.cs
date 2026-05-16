using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdPamSkinTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdPamSkinTypeReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChRDbWRQYW1Ta2luVHlwZS5wcm90byq+AQoOQ21kUGFtU2tpblR5cGUSGwoX";
		buffer[1] = "S0NEQk9OS1BMUENfUENQREhFTFBLRU0QABIaChVDbWRTZWxlY3RQYW1Ta2lu";
		buffer[2] = "Q3NSZXEQuj8SGwoWQ21kR2V0UGFtU2tpbkRhdGFTY1JzcBDMPxIaChVDbWRT";
		buffer[3] = "ZWxlY3RQYW1Ta2luU2NSc3AQwj8SGwoWQ21kR2V0UGFtU2tpbkRhdGFDc1Jl";
		buffer[4] = "cRC5PxIdChhDbWRVbmxvY2tQYW1Ta2luU2NOb3RpZnkQxz9CFqoCE01hcmNo";
		buffer[5] = "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdPamSkinType) }, null, null));
	}
}
