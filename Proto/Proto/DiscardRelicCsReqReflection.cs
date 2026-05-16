using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DiscardRelicCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DiscardRelicCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChdEaXNjYXJkUmVsaWNDc1JlcS5wcm90bxoWUmVsaWNEaXNjYXJkVHlwZS5w";
		buffer[1] = "cm90byJ2ChFEaXNjYXJkUmVsaWNDc1JlcRITCgtNSE1GSUlQRU1KRBgCIAEo";
		buffer[2] = "BBIRCglEaXNjYXJkZWQYBiABKAgSEQoJcmVsaWNfaWRzGAcgAygNEiYKC0hI";
		buffer[3] = "SExNTkxNQUdDGAsgASgOMhEuUmVsaWNEaXNjYXJkVHlwZUIWqgITTWFyY2g3";
		buffer[4] = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { RelicDiscardTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DiscardRelicCsReq), DiscardRelicCsReq.Parser, new string[4] { "MHMFIIPEMJD", "Discarded", "RelicIds", "HHHLMNLMAGC" }, null, null, null, null)
		}));
	}
}
