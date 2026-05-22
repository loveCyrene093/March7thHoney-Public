using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HDCOOFAHMHJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HDCOOFAHMHJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIRENPT0ZBSE1ISi5wcm90byINCgtIRENPT0ZBSE1ISkIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HDCOOFAHMHJ), HDCOOFAHMHJ.Parser, null, null, null, null, null)
		}));
	}
}
