using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HGCIDHBILACReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HGCIDHBILACReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIR0NJREhCSUxBQy5wcm90byIiCgtIR0NJREhCSUxBQxITCgtJSU1ORk1M" + "TENNTBgKIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HGCIDHBILAC), HGCIDHBILAC.Parser, new string[1] { "IIMNFMLLCML" }, null, null, null, null)
		}));
	}
}
