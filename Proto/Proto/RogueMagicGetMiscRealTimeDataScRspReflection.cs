using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueMagicGetMiscRealTimeDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueMagicGetMiscRealTimeDataScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CihSb2d1ZU1hZ2ljR2V0TWlzY1JlYWxUaW1lRGF0YVNjUnNwLnByb3RvGhFI";
		buffer[1] = "SEFBTkJOQ0xISS5wcm90bxoRSUdKSkZPS0FIQVAucHJvdG8iewoiUm9ndWVN";
		buffer[2] = "YWdpY0dldE1pc2NSZWFsVGltZURhdGFTY1JzcBIhCgtOT0NORU9NS0ZJTxgD";
		buffer[3] = "IAEoCzIMLklHSkpGT0tBSEFQEg8KB3JldGNvZGUYBSABKA0SIQoLS0tMSEdD";
		buffer[4] = "SktQTEoYCSABKAsyDC5ISEFBTkJOQ0xISUIWqgITTWFyY2g3dGhIb25leS5Q";
		buffer[5] = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			HHAANBNCLHIReflection.Descriptor,
			IGJJFOKAHAPReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicGetMiscRealTimeDataScRsp), RogueMagicGetMiscRealTimeDataScRsp.Parser, new string[3] { "NOCNEOMKFIO", "Retcode", "KKLHGCJKPLJ" }, null, null, null, null)
		}));
	}
}
