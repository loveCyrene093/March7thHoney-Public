using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DJDACJOJGLEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DJDACJOJGLEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFESkRBQ0pPSkdMRS5wcm90byINCgtESkRBQ0pPSkdMRUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DJDACJOJGLE), DJDACJOJGLE.Parser, null, null, null, null, null)
		}));
	}
}
