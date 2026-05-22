using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DODELEAICGIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DODELEAICGIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFET0RFTEVBSUNHSS5wcm90byIxCgtET0RFTEVBSUNHSRITCgtIRUxKS0ZN" + "SUZGRRgBIAEoCRINCgV2YWx1ZRgCIAEoCUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DODELEAICGI), DODELEAICGI.Parser, new string[2] { "HELJKFMIFFE", "Value" }, null, null, null, null)
		}));
	}
}
