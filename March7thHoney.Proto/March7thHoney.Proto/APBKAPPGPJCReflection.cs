using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class APBKAPPGPJCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static APBKAPPGPJCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBUEJLQVBQR1BKQy5wcm90byJMCgtBUEJLQVBQR1BKQxITCgtFQUFEQk9D" + "Sk5BRRgCIAEoDRITCgtJR0ZFQUhJS0tQRRgEIAEoDRITCgtORU1GTk1JUE5B" + "TxgHIAEoCEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(APBKAPPGPJC), APBKAPPGPJC.Parser, new string[3] { "EAADBOCJNAE", "IGFEAHIKKPE", "NEMFNMIPNAO" }, null, null, null, null)
		}));
	}
}
