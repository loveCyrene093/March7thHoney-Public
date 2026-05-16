using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NOKKAPGBNHPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NOKKAPGBNHPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOT0tLQVBHQk5IUC5wcm90byI3CgtOT0tLQVBHQk5IUBITCgtJR0pLRkhL" + "TU9OSRgDIAEoDRITCgtJSE1BQklQSExLThgKIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NOKKAPGBNHP), NOKKAPGBNHP.Parser, new string[2] { "IGJKFHKMONI", "IHMABIPHLKN" }, null, null, null, null)
		}));
	}
}
