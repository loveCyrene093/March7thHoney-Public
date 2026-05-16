using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MBHMOJNPHEJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MBHMOJNPHEJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNQkhNT0pOUEhFSi5wcm90byINCgtNQkhNT0pOUEhFSkIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MBHMOJNPHEJ), MBHMOJNPHEJ.Parser, null, null, null, null, null)
		}));
	}
}
