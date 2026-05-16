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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFKTU9HUE1DSkdMRS5wcm90bxoRSUNIQkdMQ0hMRFAucHJvdG8aEU1OQ09Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "RE5FTE1DLnByb3RvIpIBCgtKTU9HUE1DSkdMRRITCgtFQUFEQk9DSk5BRRgE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "IAEoDRITCgtDR05PS0hBQkNQUBgHIAEoBRIhCgtQUElQRk9QSE5ITRgIIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "CzIMLk1OQ09QRE5FTE1DEiEKC0VQS0VOREVBSlBCGAkgASgLMgwuSUNIQkdM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "Q0hMRFASEwoLS0pER0dOTkZHR1AYDiADKA1CFqoCE01hcmNoN3RoSG9uZXku";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			ICHBGLCHLDPReflection.Descriptor,
			MNCOPDNELMCReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JMOGPMCJGLE), JMOGPMCJGLE.Parser, new string[5] { "EAADBOCJNAE", "CGNOKHABCPP", "PPIPFOPHNHM", "EPKENDEAJPB", "KJDGGNNFGGP" }, null, null, null, null)
		}));
	}
}
