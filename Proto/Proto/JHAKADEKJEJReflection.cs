using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JHAKADEKJEJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JHAKADEKJEJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKSEFLQURFS0pFSi5wcm90byJMCgtKSEFLQURFS0pFShITCgtDR0hNTkNF" + "QVBQQhgEIAEoBRITCgtFSVBMR0lJSERJRBgGIAEoBRITCgtBS0FGSEhMS0ZL" + "SRgJIAEoBUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JHAKADEKJEJ), JHAKADEKJEJ.Parser, new string[3] { "CGHMNCEAPPB", "EIPLGIIHDID", "AKAFHHLKFKI" }, null, null, null, null)
		}));
	}
}
