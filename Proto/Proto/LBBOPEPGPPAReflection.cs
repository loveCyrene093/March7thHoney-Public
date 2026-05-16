using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LBBOPEPGPPAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LBBOPEPGPPAReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFMQkJPUEVQR1BQQS5wcm90byqBAQoLTEJCT1BFUEdQUEESGwoXTEJCT1BF";
		buffer[1] = "UEdQUEFfSFBES0FJS1BPSUcQABIbChdMQkJPUEVQR1BQQV9MTkZKT0xCSkxP";
		buffer[2] = "RRABEhsKF0xCQk9QRVBHUFBBX0RBUEFKTU5HSExQEAISGwoXTEJCT1BFUEdQ";
		buffer[3] = "UEFfRUxKSUpQSkxLR1AQA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(LBBOPEPGPPA) }, null, null));
	}
}
