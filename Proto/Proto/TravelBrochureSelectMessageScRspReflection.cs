using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TravelBrochureSelectMessageScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TravelBrochureSelectMessageScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiZUcmF2ZWxCcm9jaHVyZVNlbGVjdE1lc3NhZ2VTY1JzcC5wcm90bxoOSXRl";
		buffer[1] = "bUxpc3QucHJvdG8aEVBCUElPRkdPREhDLnByb3RvInEKIFRyYXZlbEJyb2No";
		buffer[2] = "dXJlU2VsZWN0TWVzc2FnZVNjUnNwEhkKBnJld2FyZBgBIAEoCzIJLkl0ZW1M";
		buffer[3] = "aXN0Eg8KB3JldGNvZGUYAiABKA0SIQoLTUhNRElES05DSUgYCSABKAsyDC5Q";
		buffer[4] = "QlBJT0ZHT0RIQ0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ItemListReflection.Descriptor,
			PBPIOFGODHCReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TravelBrochureSelectMessageScRsp), TravelBrochureSelectMessageScRsp.Parser, new string[3] { "Reward", "Retcode", "MHMDIDKNCIH" }, null, null, null, null)
		}));
	}
}
