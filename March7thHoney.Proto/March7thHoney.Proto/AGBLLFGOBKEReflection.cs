using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AGBLLFGOBKEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AGBLLFGOBKEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBR0JMTEZHT0JLRS5wcm90byJMCgtBR0JMTEZHT0JLRRITCgtKRkZJS0NG" + "TEJDSBgCIAEoDRITCgtJRkRLRUxCS0lMRhgLIAEoBRITCgtBQkNLTUtGS0FI" + "QhgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AGBLLFGOBKE), AGBLLFGOBKE.Parser, new string[3] { "JFFIKCFLBCH", "IFDKELBKILF", "ABCKMKFKAHB" }, null, null, null, null)
		}));
	}
}
