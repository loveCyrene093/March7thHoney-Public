using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DOADBBOFBJAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DOADBBOFBJAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFET0FEQkJPRkJKQS5wcm90byIiCgtET0FEQkJPRkJKQRITCgtPUEhQTUtG" + "R0xCQRgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DOADBBOFBJA), DOADBBOFBJA.Parser, new string[1] { "OPHPMKFGLBA" }, null, null, null, null)
		}));
	}
}
