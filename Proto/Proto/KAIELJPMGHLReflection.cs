using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KAIELJPMGHLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KAIELJPMGHLReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFLQUlFTEpQTUdITC5wcm90bxoRSE1KR0FETElPTkEucHJvdG8aEU5NSEtE";
		buffer[1] = "TEpQR0lMLnByb3RvIosBCgtLQUlFTEpQTUdITBITCgtOR0VISUxFRU5LQxgC";
		buffer[2] = "IAEoDRITCgtKSk9PSE9BREpNQRgDIAEoDRIhCgtQUFBITEhBRENQShgEIAEo";
		buffer[3] = "CzIMLkhNSkdBRExJT05BEgwKBHV1aWQYBiABKAkSIQoLTU9ERElCSENQUEQY";
		buffer[4] = "DiABKAsyDC5OTUhLRExKUEdJTEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[5] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			HMJGADLIONAReflection.Descriptor,
			NMHKDLJPGILReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KAIELJPMGHL), KAIELJPMGHL.Parser, new string[5] { "NGEHILEENKC", "JJOOHOADJMA", "PPPHLHADCPJ", "Uuid", "MODDIBHCPPD" }, null, null, null, null)
		}));
	}
}
