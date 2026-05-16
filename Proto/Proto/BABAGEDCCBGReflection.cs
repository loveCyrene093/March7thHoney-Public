using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BABAGEDCCBGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BABAGEDCCBGReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChFCQUJBR0VEQ0NCRy5wcm90bxoRR0NJTU1JSEtQRUkucHJvdG8aEUhDR0VH";
		buffer[1] = "R0dMT0ZJLnByb3RvGhFIR09JTENHSEtOTS5wcm90bxoRSUNIQkdMQ0hMRFAu";
		buffer[2] = "cHJvdG8iwwEKC0JBQkFHRURDQ0JHEiEKC0JPQ0lQUEJFQkVBGAIgASgLMgwu";
		buffer[3] = "SEdPSUxDR0hLTk0SIQoLdGFsZW50X2luZm8YBCABKAsyDC5IQ0dFR0dHTE9G";
		buffer[4] = "SRITCgtKSENNRUFMUERFQhgGIAMoDRITCgtKTERLS0VERUtJTRgHIAMoDRIh";
		buffer[5] = "CgtCREpEQk1JQ0tLUBgIIAEoCzIMLkdDSU1NSUhLUEVJEiEKC0VQS0VOREVB";
		buffer[6] = "SlBCGA0gASgLMgwuSUNIQkdMQ0hMRFBCFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		buffer[7] = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
		{
			GCIMMIHKPEIReflection.Descriptor,
			HCGEGGGLOFIReflection.Descriptor,
			HGOILCGHKNMReflection.Descriptor,
			ICHBGLCHLDPReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BABAGEDCCBG), BABAGEDCCBG.Parser, new string[6] { "BOCIPPBEBEA", "TalentInfo", "JHCMEALPDEB", "JLDKKEDEKIM", "BDJDBMICKKP", "EPKENDEAJPB" }, null, null, null, null)
		}));
	}
}
