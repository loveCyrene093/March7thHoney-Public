using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FLGENHNODNIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FLGENHNODNIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGTEdFTkhOT0ROSS5wcm90byINCgtGTEdFTkhOT0ROSUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FLGENHNODNI), FLGENHNODNI.Parser, null, null, null, null, null)
		}));
	}
}
