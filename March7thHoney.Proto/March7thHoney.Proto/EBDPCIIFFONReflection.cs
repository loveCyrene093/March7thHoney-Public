using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EBDPCIIFFONReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EBDPCIIFFONReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFQkRQQ0lJRkZPTi5wcm90byI3CgtFQkRQQ0lJRkZPThITCgtIRkpER0RJ" + "UExBRxgBIAEoCBITCgtGTkhLTkxJSktQSRgIIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EBDPCIIFFON), EBDPCIIFFON.Parser, new string[2] { "HFJDGDIPLAG", "FNHKNLIJKPI" }, null, null, null, null)
		}));
	}
}
