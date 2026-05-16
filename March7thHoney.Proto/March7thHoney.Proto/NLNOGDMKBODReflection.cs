using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NLNOGDMKBODReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NLNOGDMKBODReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOTE5PR0RNS0JPRC5wcm90byINCgtOTE5PR0RNS0JPREIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NLNOGDMKBOD), NLNOGDMKBOD.Parser, null, null, null, null, null)
		}));
	}
}
