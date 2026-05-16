using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LNOBPFKAAGAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LNOBPFKAAGAReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFMTk9CUEZLQUFHQS5wcm90bxoRSEROT0ZGR01ETkoucHJvdG8aEU5FSUlE";
		buffer[1] = "REFNUEdMLnByb3RvIn0KC0xOT0JQRktBQUdBEiEKC0NHTElQTUlNTUpHGAQg";
		buffer[2] = "AygLMgwuTkVJSUREQU1QR0wSEwoLdXNlX2l0ZW1faWQYBSABKA0SIQoLRElC";
		buffer[3] = "TktNSUNPT0QYByADKAsyDC5IRE5PRkZHTUROShITCgtJSkdKT0RDSURKQRgM";
		buffer[4] = "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			HDNOFFGMDNJReflection.Descriptor,
			NEIIDDAMPGLReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LNOBPFKAAGA), LNOBPFKAAGA.Parser, new string[4] { "CGLIPMIMMJG", "UseItemId", "DIBNKMICOOD", "IJGJODCIDJA" }, null, null, null, null)
		}));
	}
}
