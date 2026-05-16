using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FNBKPIHBDFGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FNBKPIHBDFGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGTkJLUElIQkRGRy5wcm90byI3CgtGTkJLUElIQkRGRxITCgtPUEhQTUtG" + "R0xCQRgJIAEoDRITCgtKQkNDSkxMQkJBSxgLIAMoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FNBKPIHBDFG), FNBKPIHBDFG.Parser, new string[2] { "OPHPMKFGLBA", "JBCCJLLBBAK" }, null, null, null, null)
		}));
	}
}
