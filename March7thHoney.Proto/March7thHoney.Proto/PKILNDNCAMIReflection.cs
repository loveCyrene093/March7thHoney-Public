using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PKILNDNCAMIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PKILNDNCAMIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQS0lMTkROQ0FNSS5wcm90byIxCgtQS0lMTkROQ0FNSRITCgtIQ0pQRE5E" + "T0hBTRgEIAEoDRINCgVjb3VudBgGIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PKILNDNCAMI), PKILNDNCAMI.Parser, new string[2] { "HCJPDNDOHAM", "Count" }, null, null, null, null)
		}));
	}
}
