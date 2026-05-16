using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class VirtualLineupTrialAvatarChangeScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static VirtualLineupTrialAvatarChangeScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CixWaXJ0dWFsTGluZXVwVHJpYWxBdmF0YXJDaGFuZ2VTY05vdGlmeS5wcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "byJ5CiZWaXJ0dWFsTGluZXVwVHJpYWxBdmF0YXJDaGFuZ2VTY05vdGlmeRIQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "CghwbGFuZV9pZBgBIAEoDRITCgtPQ0FLRk5GRVBDTxgGIAMoDRITCgtPTU5I";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "SkRCTEZOSxgNIAMoDRITCgtCUEpMTEJERE5ETRgPIAEoCEIWqgITTWFyY2g3";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(VirtualLineupTrialAvatarChangeScNotify), VirtualLineupTrialAvatarChangeScNotify.Parser, new string[4] { "PlaneId", "OCAKFNFEPCO", "OMNHJDBLFNK", "BPJLLBDDNDM" }, null, null, null, null)
		}));
	}
}
