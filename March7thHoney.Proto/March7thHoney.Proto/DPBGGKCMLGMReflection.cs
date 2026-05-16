using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DPBGGKCMLGMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DPBGGKCMLGMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFEUEJHR0tDTUxHTS5wcm90byI0CgtEUEJHR0tDTUxHTRIQCghwcm9ncmVz" + "cxgBIAEoDRITCgtCRkVLRE5FQkRLUBgHIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DPBGGKCMLGM), DPBGGKCMLGM.Parser, new string[2] { "Progress", "BFEKDNEBDKP" }, null, null, null, null)
		}));
	}
}
