using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AHDICMGKLMBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AHDICMGKLMBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBSERJQ01HS0xNQi5wcm90bxoRSUZHREZITE5QR0QucHJvdG8iRQoLQUhE" + "SUNNR0tMTUISIQoLREpJRENBQkpOTEEYAiABKAsyDC5JRkdERkhMTlBHRBIT" + "CgtKR09FUEFET0tFTRgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { IFGDFHLNPGDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AHDICMGKLMB), AHDICMGKLMB.Parser, new string[2] { "DJIDCABJNLA", "JGOEPADOKEM" }, null, null, null, null)
		}));
	}
}
