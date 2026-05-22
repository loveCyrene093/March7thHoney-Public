using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ANDMLIEGPKEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ANDMLIEGPKEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBTkRNTElFR1BLRS5wcm90bxoRRFBCRUdCTklDUEcucHJvdG8iPgoLQU5E" + "TUxJRUdQS0USIQoLT0lPRlBBRE9HRkMYDiADKAsyDC5EUEJFR0JOSUNQRxIM" + "CgR0aW1lGA8gASgEQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { DPBEGBNICPGReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ANDMLIEGPKE), ANDMLIEGPKE.Parser, new string[2] { "OIOFPADOGFC", "Time" }, null, null, null, null)
		}));
	}
}
