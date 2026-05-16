using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NCDBPKAIHINReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NCDBPKAIHINReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFOQ0RCUEtBSUhJTi5wcm90bxoRQ0FFQUJISk5MTUkucHJvdG8aEUhKR0ZE";
		buffer[1] = "SUtESUhPLnByb3RvImUKC05DREJQS0FJSElOEhIKCml0ZW1fdmFsdWUYAiAB";
		buffer[2] = "KA0SIQoLR0JIUEhDTUdCR0sYCiADKAsyDC5DQUVBQkhKTkxNSRIfCglidWZm";
		buffer[3] = "X2xpc3QYDCADKAsyDC5ISkdGRElLRElIT0IWqgITTWFyY2g3dGhIb25leS5Q";
		buffer[4] = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			CAEABHJNLMIReflection.Descriptor,
			HJGFDIKDIHOReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NCDBPKAIHIN), NCDBPKAIHIN.Parser, new string[3] { "ItemValue", "GBHPHCMGBGK", "BuffList" }, null, null, null, null)
		}));
	}
}
