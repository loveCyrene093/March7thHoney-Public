using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JMOGPMCJGLEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JMOGPMCJGLEReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFKTU9HUE1DSkdMRS5wcm90bxoRSUNIQkdMQ0hMRFAucHJvdG8aEU1OQ09Q";
		buffer[1] = "RE5FTE1DLnByb3RvIpIBCgtKTU9HUE1DSkdMRRITCgtFQUFEQk9DSk5BRRgE";
		buffer[2] = "IAEoDRITCgtDR05PS0hBQkNQUBgHIAEoBRIhCgtQUElQRk9QSE5ITRgIIAEo";
		buffer[3] = "CzIMLk1OQ09QRE5FTE1DEiEKC0VQS0VOREVBSlBCGAkgASgLMgwuSUNIQkdM";
		buffer[4] = "Q0hMRFASEwoLS0pER0dOTkZHR1AYDiADKA1CFqoCE01hcmNoN3RoSG9uZXku";
		buffer[5] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ICHBGLCHLDPReflection.Descriptor,
			MNCOPDNELMCReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JMOGPMCJGLE), JMOGPMCJGLE.Parser, new string[5] { "EAADBOCJNAE", "CGNOKHABCPP", "PPIPFOPHNHM", "EPKENDEAJPB", "KJDGGNNFGGP" }, null, null, null, null)
		}));
	}
}
