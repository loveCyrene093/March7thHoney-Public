using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IADIBNIPHBOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IADIBNIPHBOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJQURJQk5JUEhCTy5wcm90byINCgtJQURJQk5JUEhCT0IWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IADIBNIPHBO), IADIBNIPHBO.Parser, null, null, null, null, null)
		}));
	}
}
