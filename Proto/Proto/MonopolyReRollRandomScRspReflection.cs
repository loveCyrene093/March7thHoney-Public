using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyReRollRandomScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyReRollRandomScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch9Nb25vcG9seVJlUm9sbFJhbmRvbVNjUnNwLnByb3RvGhFCTElKRUtLT0lK";
		buffer[1] = "SC5wcm90byJhChlNb25vcG9seVJlUm9sbFJhbmRvbVNjUnNwEg8KB3JldGNv";
		buffer[2] = "ZGUYASABKA0SIQoLR0dMRE9HSUhGTEcYCyABKAsyDC5CTElKRUtLT0lKSBIQ";
		buffer[3] = "CghldmVudF9pZBgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { BLIJEKKOIJHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyReRollRandomScRsp), MonopolyReRollRandomScRsp.Parser, new string[3] { "Retcode", "GGLDOGIHFLG", "EventId" }, null, null, null, null)
		}));
	}
}
