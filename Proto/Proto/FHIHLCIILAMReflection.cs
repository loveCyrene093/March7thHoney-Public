using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FHIHLCIILAMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FHIHLCIILAMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGSElITENJSUxBTS5wcm90byIfCgtGSElITENJSUxBTRIQCghwcm9ncmVz" + "cxgBIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FHIHLCIILAM), FHIHLCIILAM.Parser, new string[1] { "Progress" }, null, null, null, null)
		}));
	}
}
