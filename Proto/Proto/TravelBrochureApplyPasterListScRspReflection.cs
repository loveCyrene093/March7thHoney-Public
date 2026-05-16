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
		buffer[0] = "CihUcmF2ZWxCcm9jaHVyZUFwcGx5UGFzdGVyTGlzdFNjUnNwLnByb3RvGhFQ";
		buffer[1] = "QlBJT0ZHT0RIQy5wcm90byJYCiJUcmF2ZWxCcm9jaHVyZUFwcGx5UGFzdGVy";
		buffer[2] = "TGlzdFNjUnNwEg8KB3JldGNvZGUYBSABKA0SIQoLTUhNRElES05DSUgYCCAB";
		buffer[3] = "KAsyDC5QQlBJT0ZHT0RIQ0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { PBPIOFGODHCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TravelBrochureApplyPasterListScRsp), TravelBrochureApplyPasterListScRsp.Parser, new string[2] { "Retcode", "MHMDIDKNCIH" }, null, null, null, null)
		}));
	}
}
