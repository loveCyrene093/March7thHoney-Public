using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesBusinessDayRefreshEventScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesBusinessDayRefreshEventScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CitQbGFuZXRGZXNCdXNpbmVzc0RheVJlZnJlc2hFdmVudFNjUnNwLnByb3Rv";
		buffer[1] = "GhFKSVBBQ0RFSktKQy5wcm90byJbCiVQbGFuZXRGZXNCdXNpbmVzc0RheVJl";
		buffer[2] = "ZnJlc2hFdmVudFNjUnNwEg8KB3JldGNvZGUYCCABKA0SIQoLRElIRUNJSUtF";
		buffer[3] = "TEUYDSABKAsyDC5KSVBBQ0RFSktKQ0IWqgITTWFyY2g3dGhIb25leS5Qcm90";
		buffer[4] = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { JIPACDEJKJCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesBusinessDayRefreshEventScRsp), PlanetFesBusinessDayRefreshEventScRsp.Parser, new string[2] { "Retcode", "DIHECIIKELE" }, null, null, null, null)
		}));
	}
}
