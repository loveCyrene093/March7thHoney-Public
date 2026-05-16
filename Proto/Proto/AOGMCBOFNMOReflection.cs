using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AOGMCBOFNMOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AOGMCBOFNMOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBT0dNQ0JPRk5NTy5wcm90byINCgtBT0dNQ0JPRk5NT0IWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AOGMCBOFNMO), AOGMCBOFNMO.Parser, null, null, null, null, null)
		}));
	}
}
