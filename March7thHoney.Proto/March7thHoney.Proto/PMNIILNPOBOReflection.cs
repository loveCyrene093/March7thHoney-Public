using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PMNIILNPOBOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PMNIILNPOBOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQTU5JSUxOUE9CTy5wcm90byINCgtQTU5JSUxOUE9CT0IWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PMNIILNPOBO), PMNIILNPOBO.Parser, null, null, null, null, null)
		}));
	}
}
