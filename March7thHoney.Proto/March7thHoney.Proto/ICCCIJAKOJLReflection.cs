using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ICCCIJAKOJLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ICCCIJAKOJLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJQ0NDSUpBS09KTC5wcm90byIiCgtJQ0NDSUpBS09KTBITCgtDQ0JJRUJJ" + "Q0RNRRgIIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ICCCIJAKOJL), ICCCIJAKOJL.Parser, new string[1] { "CCBIEBICDME" }, null, null, null, null)
		}));
	}
}
