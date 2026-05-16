using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CLHDILKAKEPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CLHDILKAKEPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDTEhESUxLQUtFUC5wcm90byI3CgtDTEhESUxLQUtFUBITCgtGQkNKQ0tF" + "QUhDTRgIIAEoDRITCgtPR0tORUJHREVGThgMIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CLHDILKAKEP), CLHDILKAKEP.Parser, new string[2] { "FBCJCKEAHCM", "OGKNEBGDEFN" }, null, null, null, null)
		}));
	}
}
