using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MAGNIAAPANOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MAGNIAAPANOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNQUdOSUFBUEFOTy5wcm90byINCgtNQUdOSUFBUEFOT0IWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MAGNIAAPANO), MAGNIAAPANO.Parser, null, null, null, null, null)
		}));
	}
}
