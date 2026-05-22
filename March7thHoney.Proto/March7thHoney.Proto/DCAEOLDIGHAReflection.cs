using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DCAEOLDIGHAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DCAEOLDIGHAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFEQ0FFT0xESUdIQS5wcm90byINCgtEQ0FFT0xESUdIQUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DCAEOLDIGHA), DCAEOLDIGHA.Parser, null, null, null, null, null)
		}));
	}
}
