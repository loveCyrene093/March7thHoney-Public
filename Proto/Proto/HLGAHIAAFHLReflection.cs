using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HLGAHIAAFHLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HLGAHIAAFHLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFITEdBSElBQUZITC5wcm90byINCgtITEdBSElBQUZITEIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HLGAHIAAFHL), HLGAHIAAFHL.Parser, null, null, null, null, null)
		}));
	}
}
