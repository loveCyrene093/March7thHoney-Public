using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CAFEADMFJIHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CAFEADMFJIHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDQUZFQURNRkpJSC5wcm90byINCgtDQUZFQURNRkpJSEIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CAFEADMFJIH), CAFEADMFJIH.Parser, null, null, null, null, null)
		}));
	}
}
