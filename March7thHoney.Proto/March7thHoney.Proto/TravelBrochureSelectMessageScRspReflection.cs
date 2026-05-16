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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiZUcmF2ZWxCcm9jaHVyZVNlbGVjdE1lc3NhZ2VTY1JzcC5wcm90bxoOSXRl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "bUxpc3QucHJvdG8aEVBCUElPRkdPREhDLnByb3RvInEKIFRyYXZlbEJyb2No";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "dXJlU2VsZWN0TWVzc2FnZVNjUnNwEhkKBnJld2FyZBgBIAEoCzIJLkl0ZW1M";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "aXN0Eg8KB3JldGNvZGUYAiABKA0SIQoLTUhNRElES05DSUgYCSABKAsyDC5Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "QlBJT0ZHT0RIQ0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			ItemListReflection.Descriptor,
			PBPIOFGODHCReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TravelBrochureSelectMessageScRsp), TravelBrochureSelectMessageScRsp.Parser, new string[3] { "Reward", "Retcode", "MHMDIDKNCIH" }, null, null, null, null)
		}));
	}
}
