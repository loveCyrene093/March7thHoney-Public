using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TravelBrochureApplyPasterListScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TravelBrochureApplyPasterListScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CihUcmF2ZWxCcm9jaHVyZUFwcGx5UGFzdGVyTGlzdFNjUnNwLnByb3RvGhFQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "QlBJT0ZHT0RIQy5wcm90byJYCiJUcmF2ZWxCcm9jaHVyZUFwcGx5UGFzdGVy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "TGlzdFNjUnNwEg8KB3JldGNvZGUYBSABKA0SIQoLTUhNRElES05DSUgYCCAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "KAsyDC5QQlBJT0ZHT0RIQ0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { PBPIOFGODHCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TravelBrochureApplyPasterListScRsp), TravelBrochureApplyPasterListScRsp.Parser, new string[2] { "Retcode", "MHMDIDKNCIH" }, null, null, null, null)
		}));
	}
}
