using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IdleLiveTakeAssistRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IdleLiveTakeAssistRewardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiNJZGxlTGl2ZVRha2VBc3Npc3RSZXdhcmRTY1JzcC5wcm90bxoOSXRlbUxp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "c3QucHJvdG8aEU1CSUNCS0FGR0lLLnByb3RvIm4KHUlkbGVMaXZlVGFrZUFz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "c2lzdFJld2FyZFNjUnNwEhkKBnJld2FyZBgHIAEoCzIJLkl0ZW1MaXN0Eg8K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "B3JldGNvZGUYCiABKA0SIQoLQ0FEUEpNQU5QQ0EYDyADKAsyDC5NQklDQktB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "RkdJS0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			ItemListReflection.Descriptor,
			MBICBKAFGIKReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IdleLiveTakeAssistRewardScRsp), IdleLiveTakeAssistRewardScRsp.Parser, new string[3] { "Reward", "Retcode", "CADPJMANPCA" }, null, null, null, null)
		}));
	}
}
